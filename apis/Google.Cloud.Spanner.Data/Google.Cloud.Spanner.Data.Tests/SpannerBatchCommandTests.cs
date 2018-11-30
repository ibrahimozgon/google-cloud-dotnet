﻿// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    // Note: SpannerConnection cannot be mocked because it's a sealed
    // class so there are limits to what can be tested here.
    public class SpannerBatchCommandTests
    {
        [Fact]
        public void DefaultConstructor()
        {
            var command = new SpannerBatchCommand();

            Assert.Empty(command.Commands);
            Assert.Null(command.Connection);
            Assert.Null(command.Transaction);
            Assert.Equal(SpannerBatchCommandType.None, command.CommandType);
        }

        public static IEnumerable<object[]> ValidCommands
        {
            get
            {
                yield return new object[]
                {
                    (Action<SpannerBatchCommand>)(command =>
                    command.Add(
                        "DELETE FROM myTable WHERE Key=@key",
                        new SpannerParameterCollection { { "key", SpannerDbType.Int64, 5} })),
                    "DELETE FROM myTable WHERE Key=@key",
                    1
                };
                yield return new object[]
                {
                    (Action<SpannerBatchCommand>)(command =>
                    command.Add(
                        new SpannerCommand { CommandText = "UPDATE myTable SET Value = 5 WHERE Key = 1" })),
                    "UPDATE myTable SET Value = 5 WHERE Key = 1",
                    0
                };
                yield return new object[]
                {
                    (Action<SpannerBatchCommand>)(command =>
                    command.Add(
                        SpannerCommandTextBuilder.CreateDmlTextBuilder("INSERT INTO myTable (Key, Value) SELECT Key, Value + 1 FROM myTable WHERE KEY = @Key"),
                        new SpannerParameterCollection { { "key", SpannerDbType.Int64, 3} })),
                    "INSERT INTO myTable (Key, Value) SELECT Key, Value + 1 FROM myTable WHERE KEY = @Key",
                    1
                };
            }
        }

        [Theory]
        [MemberData(nameof(ValidCommands))]
        public void AddValidCommands(Action<SpannerBatchCommand> addCommandAction, string expetedCommandText, int expectedParametersCount)
        {
            var command = new SpannerBatchCommand();

            addCommandAction(command);

            Assert.Equal(1, command.Commands.Count);
            Assert.Equal(expetedCommandText, command.Commands[0].CommandText, ignoreCase: true);

            Assert.Equal(expectedParametersCount, command.Commands[0].Parameters.Count);

            Assert.Null(command.Connection);
            Assert.Null(command.Transaction);
            Assert.Equal(SpannerBatchCommandType.BatchDml, command.CommandType);
        }

        [Fact]
        public void AddSeveralCommands()
        {
            var command = new SpannerBatchCommand();

            var expectedCommandsInOrder = new List<string>();
            foreach (var testCase in ValidCommands)
            {
                ((Action<SpannerBatchCommand>)testCase[0])(command);
                expectedCommandsInOrder.Add((string)testCase[1]);
            }

            Assert.Equal(expectedCommandsInOrder, command.Commands.Select(c => c.CommandText), StringComparer.OrdinalIgnoreCase);

            Assert.Null(command.Connection);
            Assert.Null(command.Transaction);
            Assert.Equal(SpannerBatchCommandType.BatchDml, command.CommandType);
        }

        [Fact]
        public void AddNonDmlCommand_FromEmpty()
        {
            var command = new SpannerBatchCommand();
            Assert.Throws<InvalidOperationException>(() => command.Add("drop database myDatabase"));
        }

        [Fact]
        public void AddNonDmlCommand_FromValid()
        {
            var command = new SpannerBatchCommand();

            command.Add(
                "DELETE FROM myTable WHERE Key=@key",
                new SpannerParameterCollection { { "key", SpannerDbType.Int64, 5 } });

            Assert.Throws<InvalidOperationException>(() => command.Add("drop database myDatabase"));
        }
    }
}
