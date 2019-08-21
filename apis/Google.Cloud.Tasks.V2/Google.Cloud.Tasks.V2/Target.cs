// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/tasks/v2/target.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Tasks.V2 {

  /// <summary>Holder for reflection information generated from google/cloud/tasks/v2/target.proto</summary>
  public static partial class TargetReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/tasks/v2/target.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TargetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJnb29nbGUvY2xvdWQvdGFza3MvdjIvdGFyZ2V0LnByb3RvEhVnb29nbGUu",
            "Y2xvdWQudGFza3MudjIaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i",
            "sgIKFEFwcEVuZ2luZUh0dHBSZXF1ZXN0EjYKC2h0dHBfbWV0aG9kGAEgASgO",
            "MiEuZ29vZ2xlLmNsb3VkLnRhc2tzLnYyLkh0dHBNZXRob2QSQwoSYXBwX2Vu",
            "Z2luZV9yb3V0aW5nGAIgASgLMicuZ29vZ2xlLmNsb3VkLnRhc2tzLnYyLkFw",
            "cEVuZ2luZVJvdXRpbmcSFAoMcmVsYXRpdmVfdXJpGAMgASgJEkkKB2hlYWRl",
            "cnMYBCADKAsyOC5nb29nbGUuY2xvdWQudGFza3MudjIuQXBwRW5naW5lSHR0",
            "cFJlcXVlc3QuSGVhZGVyc0VudHJ5EgwKBGJvZHkYBSABKAwaLgoMSGVhZGVy",
            "c0VudHJ5EgsKA2tleRgBIAEoCRINCgV2YWx1ZRgCIAEoCToCOAEiVAoQQXBw",
            "RW5naW5lUm91dGluZxIPCgdzZXJ2aWNlGAEgASgJEg8KB3ZlcnNpb24YAiAB",
            "KAkSEAoIaW5zdGFuY2UYAyABKAkSDAoEaG9zdBgEIAEoCSpzCgpIdHRwTWV0",
            "aG9kEhsKF0hUVFBfTUVUSE9EX1VOU1BFQ0lGSUVEEAASCAoEUE9TVBABEgcK",
            "A0dFVBACEggKBEhFQUQQAxIHCgNQVVQQBBIKCgZERUxFVEUQBRIJCgVQQVRD",
            "SBAGEgsKB09QVElPTlMQB0JmChljb20uZ29vZ2xlLmNsb3VkLnRhc2tzLnYy",
            "QgtUYXJnZXRQcm90b1ABWjpnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9n",
            "b29nbGVhcGlzL2Nsb3VkL3Rhc2tzL3YyO3Rhc2tzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Cloud.Tasks.V2.HttpMethod), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Tasks.V2.AppEngineHttpRequest), global::Google.Cloud.Tasks.V2.AppEngineHttpRequest.Parser, new[]{ "HttpMethod", "AppEngineRouting", "RelativeUri", "Headers", "Body" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Tasks.V2.AppEngineRouting), global::Google.Cloud.Tasks.V2.AppEngineRouting.Parser, new[]{ "Service", "Version", "Instance", "Host" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// The HTTP method used to deliver the task.
  /// </summary>
  public enum HttpMethod {
    /// <summary>
    /// HTTP method unspecified
    /// </summary>
    [pbr::OriginalName("HTTP_METHOD_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// HTTP POST
    /// </summary>
    [pbr::OriginalName("POST")] Post = 1,
    /// <summary>
    /// HTTP GET
    /// </summary>
    [pbr::OriginalName("GET")] Get = 2,
    /// <summary>
    /// HTTP HEAD
    /// </summary>
    [pbr::OriginalName("HEAD")] Head = 3,
    /// <summary>
    /// HTTP PUT
    /// </summary>
    [pbr::OriginalName("PUT")] Put = 4,
    /// <summary>
    /// HTTP DELETE
    /// </summary>
    [pbr::OriginalName("DELETE")] Delete = 5,
    /// <summary>
    /// HTTP PATCH
    /// </summary>
    [pbr::OriginalName("PATCH")] Patch = 6,
    /// <summary>
    /// HTTP OPTIONS
    /// </summary>
    [pbr::OriginalName("OPTIONS")] Options = 7,
  }

  #endregion

  #region Messages
  /// <summary>
  /// App Engine HTTP request.
  ///
  /// The message defines the HTTP request that is sent to an App Engine app when
  /// the task is dispatched.
  ///
  /// Using [AppEngineHttpRequest][google.cloud.tasks.v2.AppEngineHttpRequest] requires
  /// [`appengine.applications.get`](https://cloud.google.com/appengine/docs/admin-api/access-control)
  /// Google IAM permission for the project
  /// and the following scope:
  ///
  /// `https://www.googleapis.com/auth/cloud-platform`
  ///
  /// The task will be delivered to the App Engine app which belongs to the same
  /// project as the queue. For more information, see
  /// [How Requests are
  /// Routed](https://cloud.google.com/appengine/docs/standard/python/how-requests-are-routed)
  /// and how routing is affected by
  /// [dispatch
  /// files](https://cloud.google.com/appengine/docs/python/config/dispatchref).
  /// Traffic is encrypted during transport and never leaves Google datacenters.
  /// Because this traffic is carried over a communication mechanism internal to
  /// Google, you cannot explicitly set the protocol (for example, HTTP or HTTPS).
  /// The request to the handler, however, will appear to have used the HTTP
  /// protocol.
  ///
  /// The [AppEngineRouting][google.cloud.tasks.v2.AppEngineRouting] used to construct the URL that the task is
  /// delivered to can be set at the queue-level or task-level:
  ///
  /// * If [app_engine_routing_override is set on the
  ///    queue][Queue.app_engine_routing_override], this value is used for all
  ///    tasks in the queue, no matter what the setting is for the [task-level
  ///    app_engine_routing][AppEngineHttpRequest.app_engine_routing].
  ///
  /// The `url` that the task will be sent to is:
  ///
  /// * `url =` [host][google.cloud.tasks.v2.AppEngineRouting.host] `+`
  ///   [relative_uri][google.cloud.tasks.v2.AppEngineHttpRequest.relative_uri]
  ///
  /// Tasks can be dispatched to secure app handlers, unsecure app handlers, and
  /// URIs restricted with
  /// [`login:
  /// admin`](https://cloud.google.com/appengine/docs/standard/python/config/appref).
  /// Because tasks are not run as any user, they cannot be dispatched to URIs
  /// restricted with
  /// [`login:
  /// required`](https://cloud.google.com/appengine/docs/standard/python/config/appref)
  /// Task dispatches also do not follow redirects.
  ///
  /// The task attempt has succeeded if the app's request handler returns an HTTP
  /// response code in the range [`200` - `299`]. The task attempt has failed if
  /// the app's handler returns a non-2xx response code or Cloud Tasks does
  /// not receive response before the [deadline][google.cloud.tasks.v2.Task.dispatch_deadline]. Failed
  /// tasks will be retried according to the
  /// [retry configuration][google.cloud.tasks.v2.Queue.retry_config]. `503` (Service Unavailable) is
  /// considered an App Engine system error instead of an application error and
  /// will cause Cloud Tasks' traffic congestion control to temporarily throttle
  /// the queue's dispatches. Unlike other types of task targets, a `429` (Too Many
  /// Requests) response from an app handler does not cause traffic congestion
  /// control to throttle the queue.
  /// </summary>
  public sealed partial class AppEngineHttpRequest : pb::IMessage<AppEngineHttpRequest> {
    private static readonly pb::MessageParser<AppEngineHttpRequest> _parser = new pb::MessageParser<AppEngineHttpRequest>(() => new AppEngineHttpRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AppEngineHttpRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Tasks.V2.TargetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppEngineHttpRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppEngineHttpRequest(AppEngineHttpRequest other) : this() {
      httpMethod_ = other.httpMethod_;
      appEngineRouting_ = other.appEngineRouting_ != null ? other.appEngineRouting_.Clone() : null;
      relativeUri_ = other.relativeUri_;
      headers_ = other.headers_.Clone();
      body_ = other.body_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppEngineHttpRequest Clone() {
      return new AppEngineHttpRequest(this);
    }

    /// <summary>Field number for the "http_method" field.</summary>
    public const int HttpMethodFieldNumber = 1;
    private global::Google.Cloud.Tasks.V2.HttpMethod httpMethod_ = 0;
    /// <summary>
    /// The HTTP method to use for the request. The default is POST.
    ///
    /// The app's request handler for the task's target URL must be able to handle
    /// HTTP requests with this http_method, otherwise the task attempt will fail
    /// with error code 405 (Method Not Allowed). See
    /// [Writing a push task request
    /// handler](https://cloud.google.com/appengine/docs/java/taskqueue/push/creating-handlers#writing_a_push_task_request_handler)
    /// and the documentation for the request handlers in the language your app is
    /// written in e.g.
    /// [Python Request
    /// Handler](https://cloud.google.com/appengine/docs/python/tools/webapp/requesthandlerclass).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Tasks.V2.HttpMethod HttpMethod {
      get { return httpMethod_; }
      set {
        httpMethod_ = value;
      }
    }

    /// <summary>Field number for the "app_engine_routing" field.</summary>
    public const int AppEngineRoutingFieldNumber = 2;
    private global::Google.Cloud.Tasks.V2.AppEngineRouting appEngineRouting_;
    /// <summary>
    /// Task-level setting for App Engine routing.
    ///
    /// * If [app_engine_routing_override is set on the
    ///    queue][Queue.app_engine_routing_override], this value is used for all
    ///    tasks in the queue, no matter what the setting is for the [task-level
    ///    app_engine_routing][AppEngineHttpRequest.app_engine_routing].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Tasks.V2.AppEngineRouting AppEngineRouting {
      get { return appEngineRouting_; }
      set {
        appEngineRouting_ = value;
      }
    }

    /// <summary>Field number for the "relative_uri" field.</summary>
    public const int RelativeUriFieldNumber = 3;
    private string relativeUri_ = "";
    /// <summary>
    /// The relative URI.
    ///
    /// The relative URI must begin with "/" and must be a valid HTTP relative URI.
    /// It can contain a path and query string arguments.
    /// If the relative URI is empty, then the root path "/" will be used.
    /// No spaces are allowed, and the maximum length allowed is 2083 characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RelativeUri {
      get { return relativeUri_; }
      set {
        relativeUri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "headers" field.</summary>
    public const int HeadersFieldNumber = 4;
    private static readonly pbc::MapField<string, string>.Codec _map_headers_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 34);
    private readonly pbc::MapField<string, string> headers_ = new pbc::MapField<string, string>();
    /// <summary>
    /// HTTP request headers.
    ///
    /// This map contains the header field names and values.
    /// Headers can be set when the
    /// [task is created][google.cloud.tasks.v2.CloudTasks.CreateTask].
    /// Repeated headers are not supported but a header value can contain commas.
    ///
    /// Cloud Tasks sets some headers to default values:
    ///
    /// * `User-Agent`: By default, this header is
    ///   `"AppEngine-Google; (+http://code.google.com/appengine)"`.
    ///   This header can be modified, but Cloud Tasks will append
    ///   `"AppEngine-Google; (+http://code.google.com/appengine)"` to the
    ///   modified `User-Agent`.
    ///
    /// If the task has a [body][google.cloud.tasks.v2.AppEngineHttpRequest.body], Cloud
    /// Tasks sets the following headers:
    ///
    /// * `Content-Type`: By default, the `Content-Type` header is set to
    ///   `"application/octet-stream"`. The default can be overridden by explicitly
    ///   setting `Content-Type` to a particular media type when the
    ///   [task is created][google.cloud.tasks.v2.CloudTasks.CreateTask].
    ///   For example, `Content-Type` can be set to `"application/json"`.
    /// * `Content-Length`: This is computed by Cloud Tasks. This value is
    ///   output only.   It cannot be changed.
    ///
    /// The headers below cannot be set or overridden:
    ///
    /// * `Host`
    /// * `X-Google-*`
    /// * `X-AppEngine-*`
    ///
    /// In addition, Cloud Tasks sets some headers when the task is dispatched,
    /// such as headers containing information about the task; see
    /// [request
    /// headers](https://cloud.google.com/appengine/docs/python/taskqueue/push/creating-handlers#reading_request_headers).
    /// These headers are set only when the task is dispatched, so they are not
    /// visible when the task is returned in a Cloud Tasks response.
    ///
    /// Although there is no specific limit for the maximum number of headers or
    /// the size, there is a limit on the maximum size of the [Task][google.cloud.tasks.v2.Task]. For more
    /// information, see the [CreateTask][google.cloud.tasks.v2.CloudTasks.CreateTask] documentation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Headers {
      get { return headers_; }
    }

    /// <summary>Field number for the "body" field.</summary>
    public const int BodyFieldNumber = 5;
    private pb::ByteString body_ = pb::ByteString.Empty;
    /// <summary>
    /// HTTP request body.
    ///
    /// A request body is allowed only if the HTTP method is POST or PUT. It is
    /// an error to set a body on a task with an incompatible [HttpMethod][google.cloud.tasks.v2.HttpMethod].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Body {
      get { return body_; }
      set {
        body_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AppEngineHttpRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AppEngineHttpRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HttpMethod != other.HttpMethod) return false;
      if (!object.Equals(AppEngineRouting, other.AppEngineRouting)) return false;
      if (RelativeUri != other.RelativeUri) return false;
      if (!Headers.Equals(other.Headers)) return false;
      if (Body != other.Body) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HttpMethod != 0) hash ^= HttpMethod.GetHashCode();
      if (appEngineRouting_ != null) hash ^= AppEngineRouting.GetHashCode();
      if (RelativeUri.Length != 0) hash ^= RelativeUri.GetHashCode();
      hash ^= Headers.GetHashCode();
      if (Body.Length != 0) hash ^= Body.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (HttpMethod != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) HttpMethod);
      }
      if (appEngineRouting_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AppEngineRouting);
      }
      if (RelativeUri.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(RelativeUri);
      }
      headers_.WriteTo(output, _map_headers_codec);
      if (Body.Length != 0) {
        output.WriteRawTag(42);
        output.WriteBytes(Body);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HttpMethod != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) HttpMethod);
      }
      if (appEngineRouting_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AppEngineRouting);
      }
      if (RelativeUri.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RelativeUri);
      }
      size += headers_.CalculateSize(_map_headers_codec);
      if (Body.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Body);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AppEngineHttpRequest other) {
      if (other == null) {
        return;
      }
      if (other.HttpMethod != 0) {
        HttpMethod = other.HttpMethod;
      }
      if (other.appEngineRouting_ != null) {
        if (appEngineRouting_ == null) {
          AppEngineRouting = new global::Google.Cloud.Tasks.V2.AppEngineRouting();
        }
        AppEngineRouting.MergeFrom(other.AppEngineRouting);
      }
      if (other.RelativeUri.Length != 0) {
        RelativeUri = other.RelativeUri;
      }
      headers_.Add(other.headers_);
      if (other.Body.Length != 0) {
        Body = other.Body;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            HttpMethod = (global::Google.Cloud.Tasks.V2.HttpMethod) input.ReadEnum();
            break;
          }
          case 18: {
            if (appEngineRouting_ == null) {
              AppEngineRouting = new global::Google.Cloud.Tasks.V2.AppEngineRouting();
            }
            input.ReadMessage(AppEngineRouting);
            break;
          }
          case 26: {
            RelativeUri = input.ReadString();
            break;
          }
          case 34: {
            headers_.AddEntriesFrom(input, _map_headers_codec);
            break;
          }
          case 42: {
            Body = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// App Engine Routing.
  ///
  /// Defines routing characteristics specific to App Engine - service, version,
  /// and instance.
  ///
  /// For more information about services, versions, and instances see
  /// [An Overview of App
  /// Engine](https://cloud.google.com/appengine/docs/python/an-overview-of-app-engine),
  /// [Microservices Architecture on Google App
  /// Engine](https://cloud.google.com/appengine/docs/python/microservices-on-app-engine),
  /// [App Engine Standard request
  /// routing](https://cloud.google.com/appengine/docs/standard/python/how-requests-are-routed),
  /// and [App Engine Flex request
  /// routing](https://cloud.google.com/appengine/docs/flexible/python/how-requests-are-routed).
  ///
  /// Using [AppEngineRouting][google.cloud.tasks.v2.AppEngineRouting] requires
  /// [`appengine.applications.get`](https://cloud.google.com/appengine/docs/admin-api/access-control)
  /// Google IAM permission for the project
  /// and the following scope:
  ///
  /// `https://www.googleapis.com/auth/cloud-platform`
  /// </summary>
  public sealed partial class AppEngineRouting : pb::IMessage<AppEngineRouting> {
    private static readonly pb::MessageParser<AppEngineRouting> _parser = new pb::MessageParser<AppEngineRouting>(() => new AppEngineRouting());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AppEngineRouting> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Tasks.V2.TargetReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppEngineRouting() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppEngineRouting(AppEngineRouting other) : this() {
      service_ = other.service_;
      version_ = other.version_;
      instance_ = other.instance_;
      host_ = other.host_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppEngineRouting Clone() {
      return new AppEngineRouting(this);
    }

    /// <summary>Field number for the "service" field.</summary>
    public const int ServiceFieldNumber = 1;
    private string service_ = "";
    /// <summary>
    /// App service.
    ///
    /// By default, the task is sent to the service which is the default
    /// service when the task is attempted.
    ///
    /// For some queues or tasks which were created using the App Engine
    /// Task Queue API, [host][google.cloud.tasks.v2.AppEngineRouting.host] is not parsable
    /// into [service][google.cloud.tasks.v2.AppEngineRouting.service],
    /// [version][google.cloud.tasks.v2.AppEngineRouting.version], and
    /// [instance][google.cloud.tasks.v2.AppEngineRouting.instance]. For example, some tasks
    /// which were created using the App Engine SDK use a custom domain
    /// name; custom domains are not parsed by Cloud Tasks. If
    /// [host][google.cloud.tasks.v2.AppEngineRouting.host] is not parsable, then
    /// [service][google.cloud.tasks.v2.AppEngineRouting.service],
    /// [version][google.cloud.tasks.v2.AppEngineRouting.version], and
    /// [instance][google.cloud.tasks.v2.AppEngineRouting.instance] are the empty string.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Service {
      get { return service_; }
      set {
        service_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 2;
    private string version_ = "";
    /// <summary>
    /// App version.
    ///
    /// By default, the task is sent to the version which is the default
    /// version when the task is attempted.
    ///
    /// For some queues or tasks which were created using the App Engine
    /// Task Queue API, [host][google.cloud.tasks.v2.AppEngineRouting.host] is not parsable
    /// into [service][google.cloud.tasks.v2.AppEngineRouting.service],
    /// [version][google.cloud.tasks.v2.AppEngineRouting.version], and
    /// [instance][google.cloud.tasks.v2.AppEngineRouting.instance]. For example, some tasks
    /// which were created using the App Engine SDK use a custom domain
    /// name; custom domains are not parsed by Cloud Tasks. If
    /// [host][google.cloud.tasks.v2.AppEngineRouting.host] is not parsable, then
    /// [service][google.cloud.tasks.v2.AppEngineRouting.service],
    /// [version][google.cloud.tasks.v2.AppEngineRouting.version], and
    /// [instance][google.cloud.tasks.v2.AppEngineRouting.instance] are the empty string.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Version {
      get { return version_; }
      set {
        version_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "instance" field.</summary>
    public const int InstanceFieldNumber = 3;
    private string instance_ = "";
    /// <summary>
    /// App instance.
    ///
    /// By default, the task is sent to an instance which is available when
    /// the task is attempted.
    ///
    /// Requests can only be sent to a specific instance if
    /// [manual scaling is used in App Engine
    /// Standard](https://cloud.google.com/appengine/docs/python/an-overview-of-app-engine?hl=en_US#scaling_types_and_instance_classes).
    /// App Engine Flex does not support instances. For more information, see
    /// [App Engine Standard request
    /// routing](https://cloud.google.com/appengine/docs/standard/python/how-requests-are-routed)
    /// and [App Engine Flex request
    /// routing](https://cloud.google.com/appengine/docs/flexible/python/how-requests-are-routed).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Instance {
      get { return instance_; }
      set {
        instance_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "host" field.</summary>
    public const int HostFieldNumber = 4;
    private string host_ = "";
    /// <summary>
    /// Output only. The host that the task is sent to.
    ///
    /// The host is constructed from the domain name of the app associated with
    /// the queue's project ID (for example &lt;app-id>.appspot.com), and the
    /// [service][google.cloud.tasks.v2.AppEngineRouting.service], [version][google.cloud.tasks.v2.AppEngineRouting.version],
    /// and [instance][google.cloud.tasks.v2.AppEngineRouting.instance]. Tasks which were created using
    /// the App Engine SDK might have a custom domain name.
    ///
    /// For more information, see
    /// [How Requests are
    /// Routed](https://cloud.google.com/appengine/docs/standard/python/how-requests-are-routed).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Host {
      get { return host_; }
      set {
        host_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AppEngineRouting);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AppEngineRouting other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Service != other.Service) return false;
      if (Version != other.Version) return false;
      if (Instance != other.Instance) return false;
      if (Host != other.Host) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Service.Length != 0) hash ^= Service.GetHashCode();
      if (Version.Length != 0) hash ^= Version.GetHashCode();
      if (Instance.Length != 0) hash ^= Instance.GetHashCode();
      if (Host.Length != 0) hash ^= Host.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Service.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Service);
      }
      if (Version.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Version);
      }
      if (Instance.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Instance);
      }
      if (Host.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Host);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Service.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Service);
      }
      if (Version.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Version);
      }
      if (Instance.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Instance);
      }
      if (Host.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Host);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AppEngineRouting other) {
      if (other == null) {
        return;
      }
      if (other.Service.Length != 0) {
        Service = other.Service;
      }
      if (other.Version.Length != 0) {
        Version = other.Version;
      }
      if (other.Instance.Length != 0) {
        Instance = other.Instance;
      }
      if (other.Host.Length != 0) {
        Host = other.Host;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Service = input.ReadString();
            break;
          }
          case 18: {
            Version = input.ReadString();
            break;
          }
          case 26: {
            Instance = input.ReadString();
            break;
          }
          case 34: {
            Host = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
