/*
 * Copyright 2016 Google Inc. All Rights Reserved.
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */

// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/api/service.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Api {

  /// <summary>Holder for reflection information generated from google/api/service.proto</summary>
  public static partial class ServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/api/service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chhnb29nbGUvYXBpL3NlcnZpY2UucHJvdG8SCmdvb2dsZS5hcGkaHGdvb2ds",
            "ZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8aFWdvb2dsZS9hcGkvYXV0aC5wcm90",
            "bxoYZ29vZ2xlL2FwaS9iYWNrZW5kLnByb3RvGhhnb29nbGUvYXBpL2NvbnRl",
            "eHQucHJvdG8aGGdvb2dsZS9hcGkvY29udHJvbC5wcm90bxoeZ29vZ2xlL2Fw",
            "aS9kb2N1bWVudGF0aW9uLnByb3RvGhlnb29nbGUvYXBpL2VuZHBvaW50LnBy",
            "b3RvGhVnb29nbGUvYXBpL2h0dHAucHJvdG8aFmdvb2dsZS9hcGkvbGFiZWwu",
            "cHJvdG8aFGdvb2dsZS9hcGkvbG9nLnByb3RvGhhnb29nbGUvYXBpL2xvZ2dp",
            "bmcucHJvdG8aF2dvb2dsZS9hcGkvbWV0cmljLnByb3RvGiNnb29nbGUvYXBp",
            "L21vbml0b3JlZF9yZXNvdXJjZS5wcm90bxobZ29vZ2xlL2FwaS9tb25pdG9y",
            "aW5nLnByb3RvGiFnb29nbGUvYXBpL3N5c3RlbV9wYXJhbWV0ZXIucHJvdG8a",
            "Fmdvb2dsZS9hcGkvdXNhZ2UucHJvdG8aGWdvb2dsZS9wcm90b2J1Zi9hbnku",
            "cHJvdG8aGWdvb2dsZS9wcm90b2J1Zi9hcGkucHJvdG8aGmdvb2dsZS9wcm90",
            "b2J1Zi90eXBlLnByb3RvGh5nb29nbGUvcHJvdG9idWYvd3JhcHBlcnMucHJv",
            "dG8i4QYKB1NlcnZpY2USNAoOY29uZmlnX3ZlcnNpb24YFCABKAsyHC5nb29n",
            "bGUucHJvdG9idWYuVUludDMyVmFsdWUSDAoEbmFtZRgBIAEoCRIKCgJpZBgh",
            "IAEoCRINCgV0aXRsZRgCIAEoCRIbChNwcm9kdWNlcl9wcm9qZWN0X2lkGBYg",
            "ASgJEiIKBGFwaXMYAyADKAsyFC5nb29nbGUucHJvdG9idWYuQXBpEiQKBXR5",
            "cGVzGAQgAygLMhUuZ29vZ2xlLnByb3RvYnVmLlR5cGUSJAoFZW51bXMYBSAD",
            "KAsyFS5nb29nbGUucHJvdG9idWYuRW51bRIwCg1kb2N1bWVudGF0aW9uGAYg",
            "ASgLMhkuZ29vZ2xlLmFwaS5Eb2N1bWVudGF0aW9uEiQKB2JhY2tlbmQYCCAB",
            "KAsyEy5nb29nbGUuYXBpLkJhY2tlbmQSHgoEaHR0cBgJIAEoCzIQLmdvb2ds",
            "ZS5hcGkuSHR0cBIyCg5hdXRoZW50aWNhdGlvbhgLIAEoCzIaLmdvb2dsZS5h",
            "cGkuQXV0aGVudGljYXRpb24SJAoHY29udGV4dBgMIAEoCzITLmdvb2dsZS5h",
            "cGkuQ29udGV4dBIgCgV1c2FnZRgPIAEoCzIRLmdvb2dsZS5hcGkuVXNhZ2US",
            "JwoJZW5kcG9pbnRzGBIgAygLMhQuZ29vZ2xlLmFwaS5FbmRwb2ludBIkCgdj",
            "b250cm9sGBUgASgLMhMuZ29vZ2xlLmFwaS5Db250cm9sEicKBGxvZ3MYFyAD",
            "KAsyGS5nb29nbGUuYXBpLkxvZ0Rlc2NyaXB0b3ISLQoHbWV0cmljcxgYIAMo",
            "CzIcLmdvb2dsZS5hcGkuTWV0cmljRGVzY3JpcHRvchJEChNtb25pdG9yZWRf",
            "cmVzb3VyY2VzGBkgAygLMicuZ29vZ2xlLmFwaS5Nb25pdG9yZWRSZXNvdXJj",
            "ZURlc2NyaXB0b3ISJAoHbG9nZ2luZxgbIAEoCzITLmdvb2dsZS5hcGkuTG9n",
            "Z2luZxIqCgptb25pdG9yaW5nGBwgASgLMhYuZ29vZ2xlLmFwaS5Nb25pdG9y",
            "aW5nEjcKEXN5c3RlbV9wYXJhbWV0ZXJzGB0gASgLMhwuZ29vZ2xlLmFwaS5T",
            "eXN0ZW1QYXJhbWV0ZXJzQicKDmNvbS5nb29nbGUuYXBpQgxTZXJ2aWNlUHJv",
            "dG9QAaICBEdBUEliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.AuthReflection.Descriptor, global::Google.Api.BackendReflection.Descriptor, global::Google.Api.ContextReflection.Descriptor, global::Google.Api.ControlReflection.Descriptor, global::Google.Api.DocumentationReflection.Descriptor, global::Google.Api.EndpointReflection.Descriptor, global::Google.Api.HttpReflection.Descriptor, global::Google.Api.LabelReflection.Descriptor, global::Google.Api.LogReflection.Descriptor, global::Google.Api.LoggingReflection.Descriptor, global::Google.Api.MetricReflection.Descriptor, global::Google.Api.MonitoredResourceReflection.Descriptor, global::Google.Api.MonitoringReflection.Descriptor, global::Google.Api.SystemParameterReflection.Descriptor, global::Google.Api.UsageReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.ApiReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TypeReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Api.Service), global::Google.Api.Service.Parser, new[]{ "ConfigVersion", "Name", "Id", "Title", "ProducerProjectId", "Apis", "Types_", "Enums", "Documentation", "Backend", "Http", "Authentication", "Context", "Usage", "Endpoints", "Control", "Logs", "Metrics", "MonitoredResources", "Logging", "Monitoring", "SystemParameters" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  `Service` is the root object of the configuration schema. It
  ///  describes basic information like the name of the service and the
  ///  exposed API interfaces, and delegates other aspects to configuration
  ///  sub-sections.
  ///
  ///  Example:
  ///
  ///      type: google.api.Service
  ///      config_version: 1
  ///      name: calendar.googleapis.com
  ///      title: Google Calendar API
  ///      apis:
  ///      - name: google.calendar.Calendar
  ///      backend:
  ///        rules:
  ///        - selector: "*"
  ///          address: calendar.example.com
  /// </summary>
  public sealed partial class Service : pb::IMessage<Service> {
    private static readonly pb::MessageParser<Service> _parser = new pb::MessageParser<Service>(() => new Service());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Service> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Api.ServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Service() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Service(Service other) : this() {
      ConfigVersion = other.ConfigVersion;
      name_ = other.name_;
      id_ = other.id_;
      title_ = other.title_;
      producerProjectId_ = other.producerProjectId_;
      apis_ = other.apis_.Clone();
      types_ = other.types_.Clone();
      enums_ = other.enums_.Clone();
      Documentation = other.documentation_ != null ? other.Documentation.Clone() : null;
      Backend = other.backend_ != null ? other.Backend.Clone() : null;
      Http = other.http_ != null ? other.Http.Clone() : null;
      Authentication = other.authentication_ != null ? other.Authentication.Clone() : null;
      Context = other.context_ != null ? other.Context.Clone() : null;
      Usage = other.usage_ != null ? other.Usage.Clone() : null;
      endpoints_ = other.endpoints_.Clone();
      Control = other.control_ != null ? other.Control.Clone() : null;
      logs_ = other.logs_.Clone();
      metrics_ = other.metrics_.Clone();
      monitoredResources_ = other.monitoredResources_.Clone();
      Logging = other.logging_ != null ? other.Logging.Clone() : null;
      Monitoring = other.monitoring_ != null ? other.Monitoring.Clone() : null;
      SystemParameters = other.systemParameters_ != null ? other.SystemParameters.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Service Clone() {
      return new Service(this);
    }

    /// <summary>Field number for the "config_version" field.</summary>
    public const int ConfigVersionFieldNumber = 20;
    private static readonly pb::FieldCodec<uint?> _single_configVersion_codec = pb::FieldCodec.ForStructWrapper<uint>(162);
    private uint? configVersion_;
    /// <summary>
    ///  The version of the service configuration. The config version may
    ///  influence interpretation of the configuration, for example, to
    ///  determine defaults. This is documented together with applicable
    ///  options. The current default for the config version itself is `3`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint? ConfigVersion {
      get { return configVersion_; }
      set {
        configVersion_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    ///  The DNS address at which this service is available,
    ///  e.g. `calendar.googleapis.com`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 33;
    private string id_ = "";
    /// <summary>
    ///  A unique ID for a specific instance of this message, typically assigned
    ///  by the client for tracking purpose. If empty, the server may choose to
    ///  generate one instead.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "title" field.</summary>
    public const int TitleFieldNumber = 2;
    private string title_ = "";
    /// <summary>
    ///  The product title associated with this service.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Title {
      get { return title_; }
      set {
        title_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "producer_project_id" field.</summary>
    public const int ProducerProjectIdFieldNumber = 22;
    private string producerProjectId_ = "";
    /// <summary>
    ///  The id of the Google developer project that owns the service.
    ///  Members of this project can manage the service configuration,
    ///  manage consumption of the service, etc.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ProducerProjectId {
      get { return producerProjectId_; }
      set {
        producerProjectId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "apis" field.</summary>
    public const int ApisFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Google.Protobuf.WellKnownTypes.Api> _repeated_apis_codec
        = pb::FieldCodec.ForMessage(26, global::Google.Protobuf.WellKnownTypes.Api.Parser);
    private readonly pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Api> apis_ = new pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Api>();
    /// <summary>
    ///  A list of API interfaces exported by this service. Only the `name` field
    ///  of the [google.protobuf.Api][google.protobuf.Api] needs to be provided by the configuration
    ///  author, as the remaining fields will be derived from the IDL during the
    ///  normalization process. It is an error to specify an API interface here
    ///  which cannot be resolved against the associated IDL files.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Api> Apis {
      get { return apis_; }
    }

    /// <summary>Field number for the "types" field.</summary>
    public const int Types_FieldNumber = 4;
    private static readonly pb::FieldCodec<global::Google.Protobuf.WellKnownTypes.Type> _repeated_types_codec
        = pb::FieldCodec.ForMessage(34, global::Google.Protobuf.WellKnownTypes.Type.Parser);
    private readonly pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Type> types_ = new pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Type>();
    /// <summary>
    ///  A list of all proto message types included in this API service.
    ///  Types referenced directly or indirectly by the `apis` are
    ///  automatically included.  Messages which are not referenced but
    ///  shall be included, such as types used by the `google.protobuf.Any` type,
    ///  should be listed here by name. Example:
    ///
    ///      types:
    ///      - name: google.protobuf.Int32
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Type> Types_ {
      get { return types_; }
    }

    /// <summary>Field number for the "enums" field.</summary>
    public const int EnumsFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Google.Protobuf.WellKnownTypes.Enum> _repeated_enums_codec
        = pb::FieldCodec.ForMessage(42, global::Google.Protobuf.WellKnownTypes.Enum.Parser);
    private readonly pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Enum> enums_ = new pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Enum>();
    /// <summary>
    ///  A list of all enum types included in this API service.  Enums
    ///  referenced directly or indirectly by the `apis` are automatically
    ///  included.  Enums which are not referenced but shall be included
    ///  should be listed here by name. Example:
    ///
    ///      enums:
    ///      - name: google.someapi.v1.SomeEnum
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Enum> Enums {
      get { return enums_; }
    }

    /// <summary>Field number for the "documentation" field.</summary>
    public const int DocumentationFieldNumber = 6;
    private global::Google.Api.Documentation documentation_;
    /// <summary>
    ///  Additional API documentation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Api.Documentation Documentation {
      get { return documentation_; }
      set {
        documentation_ = value;
      }
    }

    /// <summary>Field number for the "backend" field.</summary>
    public const int BackendFieldNumber = 8;
    private global::Google.Api.Backend backend_;
    /// <summary>
    ///  API backend configuration.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Api.Backend Backend {
      get { return backend_; }
      set {
        backend_ = value;
      }
    }

    /// <summary>Field number for the "http" field.</summary>
    public const int HttpFieldNumber = 9;
    private global::Google.Api.Http http_;
    /// <summary>
    ///  HTTP configuration.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Api.Http Http {
      get { return http_; }
      set {
        http_ = value;
      }
    }

    /// <summary>Field number for the "authentication" field.</summary>
    public const int AuthenticationFieldNumber = 11;
    private global::Google.Api.Authentication authentication_;
    /// <summary>
    ///  Auth configuration.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Api.Authentication Authentication {
      get { return authentication_; }
      set {
        authentication_ = value;
      }
    }

    /// <summary>Field number for the "context" field.</summary>
    public const int ContextFieldNumber = 12;
    private global::Google.Api.Context context_;
    /// <summary>
    ///  Context configuration.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Api.Context Context {
      get { return context_; }
      set {
        context_ = value;
      }
    }

    /// <summary>Field number for the "usage" field.</summary>
    public const int UsageFieldNumber = 15;
    private global::Google.Api.Usage usage_;
    /// <summary>
    ///  Configuration controlling usage of this service.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Api.Usage Usage {
      get { return usage_; }
      set {
        usage_ = value;
      }
    }

    /// <summary>Field number for the "endpoints" field.</summary>
    public const int EndpointsFieldNumber = 18;
    private static readonly pb::FieldCodec<global::Google.Api.Endpoint> _repeated_endpoints_codec
        = pb::FieldCodec.ForMessage(146, global::Google.Api.Endpoint.Parser);
    private readonly pbc::RepeatedField<global::Google.Api.Endpoint> endpoints_ = new pbc::RepeatedField<global::Google.Api.Endpoint>();
    /// <summary>
    ///  Configuration for network endpoints.  If this is empty, then an endpoint
    ///  with the same name as the service is automatically generated to service all
    ///  defined APIs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Api.Endpoint> Endpoints {
      get { return endpoints_; }
    }

    /// <summary>Field number for the "control" field.</summary>
    public const int ControlFieldNumber = 21;
    private global::Google.Api.Control control_;
    /// <summary>
    ///  Configuration for the service control plane.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Api.Control Control {
      get { return control_; }
      set {
        control_ = value;
      }
    }

    /// <summary>Field number for the "logs" field.</summary>
    public const int LogsFieldNumber = 23;
    private static readonly pb::FieldCodec<global::Google.Api.LogDescriptor> _repeated_logs_codec
        = pb::FieldCodec.ForMessage(186, global::Google.Api.LogDescriptor.Parser);
    private readonly pbc::RepeatedField<global::Google.Api.LogDescriptor> logs_ = new pbc::RepeatedField<global::Google.Api.LogDescriptor>();
    /// <summary>
    ///  Defines the logs used by this service.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Api.LogDescriptor> Logs {
      get { return logs_; }
    }

    /// <summary>Field number for the "metrics" field.</summary>
    public const int MetricsFieldNumber = 24;
    private static readonly pb::FieldCodec<global::Google.Api.MetricDescriptor> _repeated_metrics_codec
        = pb::FieldCodec.ForMessage(194, global::Google.Api.MetricDescriptor.Parser);
    private readonly pbc::RepeatedField<global::Google.Api.MetricDescriptor> metrics_ = new pbc::RepeatedField<global::Google.Api.MetricDescriptor>();
    /// <summary>
    ///  Defines the metrics used by this service.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Api.MetricDescriptor> Metrics {
      get { return metrics_; }
    }

    /// <summary>Field number for the "monitored_resources" field.</summary>
    public const int MonitoredResourcesFieldNumber = 25;
    private static readonly pb::FieldCodec<global::Google.Api.MonitoredResourceDescriptor> _repeated_monitoredResources_codec
        = pb::FieldCodec.ForMessage(202, global::Google.Api.MonitoredResourceDescriptor.Parser);
    private readonly pbc::RepeatedField<global::Google.Api.MonitoredResourceDescriptor> monitoredResources_ = new pbc::RepeatedField<global::Google.Api.MonitoredResourceDescriptor>();
    /// <summary>
    ///  Defines the monitored resources used by this service. This is required
    ///  by the [Service.monitoring][google.api.Service.monitoring] and [Service.logging][google.api.Service.logging] configurations.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Api.MonitoredResourceDescriptor> MonitoredResources {
      get { return monitoredResources_; }
    }

    /// <summary>Field number for the "logging" field.</summary>
    public const int LoggingFieldNumber = 27;
    private global::Google.Api.Logging logging_;
    /// <summary>
    ///  Logging configuration of the service.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Api.Logging Logging {
      get { return logging_; }
      set {
        logging_ = value;
      }
    }

    /// <summary>Field number for the "monitoring" field.</summary>
    public const int MonitoringFieldNumber = 28;
    private global::Google.Api.Monitoring monitoring_;
    /// <summary>
    ///  Monitoring configuration of the service.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Api.Monitoring Monitoring {
      get { return monitoring_; }
      set {
        monitoring_ = value;
      }
    }

    /// <summary>Field number for the "system_parameters" field.</summary>
    public const int SystemParametersFieldNumber = 29;
    private global::Google.Api.SystemParameters systemParameters_;
    /// <summary>
    ///  Configuration for system parameters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Api.SystemParameters SystemParameters {
      get { return systemParameters_; }
      set {
        systemParameters_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Service);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Service other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ConfigVersion != other.ConfigVersion) return false;
      if (Name != other.Name) return false;
      if (Id != other.Id) return false;
      if (Title != other.Title) return false;
      if (ProducerProjectId != other.ProducerProjectId) return false;
      if(!apis_.Equals(other.apis_)) return false;
      if(!types_.Equals(other.types_)) return false;
      if(!enums_.Equals(other.enums_)) return false;
      if (!object.Equals(Documentation, other.Documentation)) return false;
      if (!object.Equals(Backend, other.Backend)) return false;
      if (!object.Equals(Http, other.Http)) return false;
      if (!object.Equals(Authentication, other.Authentication)) return false;
      if (!object.Equals(Context, other.Context)) return false;
      if (!object.Equals(Usage, other.Usage)) return false;
      if(!endpoints_.Equals(other.endpoints_)) return false;
      if (!object.Equals(Control, other.Control)) return false;
      if(!logs_.Equals(other.logs_)) return false;
      if(!metrics_.Equals(other.metrics_)) return false;
      if(!monitoredResources_.Equals(other.monitoredResources_)) return false;
      if (!object.Equals(Logging, other.Logging)) return false;
      if (!object.Equals(Monitoring, other.Monitoring)) return false;
      if (!object.Equals(SystemParameters, other.SystemParameters)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (configVersion_ != null) hash ^= ConfigVersion.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Title.Length != 0) hash ^= Title.GetHashCode();
      if (ProducerProjectId.Length != 0) hash ^= ProducerProjectId.GetHashCode();
      hash ^= apis_.GetHashCode();
      hash ^= types_.GetHashCode();
      hash ^= enums_.GetHashCode();
      if (documentation_ != null) hash ^= Documentation.GetHashCode();
      if (backend_ != null) hash ^= Backend.GetHashCode();
      if (http_ != null) hash ^= Http.GetHashCode();
      if (authentication_ != null) hash ^= Authentication.GetHashCode();
      if (context_ != null) hash ^= Context.GetHashCode();
      if (usage_ != null) hash ^= Usage.GetHashCode();
      hash ^= endpoints_.GetHashCode();
      if (control_ != null) hash ^= Control.GetHashCode();
      hash ^= logs_.GetHashCode();
      hash ^= metrics_.GetHashCode();
      hash ^= monitoredResources_.GetHashCode();
      if (logging_ != null) hash ^= Logging.GetHashCode();
      if (monitoring_ != null) hash ^= Monitoring.GetHashCode();
      if (systemParameters_ != null) hash ^= SystemParameters.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Title.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Title);
      }
      apis_.WriteTo(output, _repeated_apis_codec);
      types_.WriteTo(output, _repeated_types_codec);
      enums_.WriteTo(output, _repeated_enums_codec);
      if (documentation_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Documentation);
      }
      if (backend_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Backend);
      }
      if (http_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(Http);
      }
      if (authentication_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(Authentication);
      }
      if (context_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(Context);
      }
      if (usage_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(Usage);
      }
      endpoints_.WriteTo(output, _repeated_endpoints_codec);
      if (configVersion_ != null) {
        _single_configVersion_codec.WriteTagAndValue(output, ConfigVersion);
      }
      if (control_ != null) {
        output.WriteRawTag(170, 1);
        output.WriteMessage(Control);
      }
      if (ProducerProjectId.Length != 0) {
        output.WriteRawTag(178, 1);
        output.WriteString(ProducerProjectId);
      }
      logs_.WriteTo(output, _repeated_logs_codec);
      metrics_.WriteTo(output, _repeated_metrics_codec);
      monitoredResources_.WriteTo(output, _repeated_monitoredResources_codec);
      if (logging_ != null) {
        output.WriteRawTag(218, 1);
        output.WriteMessage(Logging);
      }
      if (monitoring_ != null) {
        output.WriteRawTag(226, 1);
        output.WriteMessage(Monitoring);
      }
      if (systemParameters_ != null) {
        output.WriteRawTag(234, 1);
        output.WriteMessage(SystemParameters);
      }
      if (Id.Length != 0) {
        output.WriteRawTag(138, 2);
        output.WriteString(Id);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (configVersion_ != null) {
        size += _single_configVersion_codec.CalculateSizeWithTag(ConfigVersion);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Id.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Title.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
      }
      if (ProducerProjectId.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(ProducerProjectId);
      }
      size += apis_.CalculateSize(_repeated_apis_codec);
      size += types_.CalculateSize(_repeated_types_codec);
      size += enums_.CalculateSize(_repeated_enums_codec);
      if (documentation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Documentation);
      }
      if (backend_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Backend);
      }
      if (http_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Http);
      }
      if (authentication_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Authentication);
      }
      if (context_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Context);
      }
      if (usage_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Usage);
      }
      size += endpoints_.CalculateSize(_repeated_endpoints_codec);
      if (control_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(Control);
      }
      size += logs_.CalculateSize(_repeated_logs_codec);
      size += metrics_.CalculateSize(_repeated_metrics_codec);
      size += monitoredResources_.CalculateSize(_repeated_monitoredResources_codec);
      if (logging_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(Logging);
      }
      if (monitoring_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(Monitoring);
      }
      if (systemParameters_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(SystemParameters);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Service other) {
      if (other == null) {
        return;
      }
      if (other.configVersion_ != null) {
        if (configVersion_ == null || other.ConfigVersion != 0) {
          ConfigVersion = other.ConfigVersion;
        }
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Title.Length != 0) {
        Title = other.Title;
      }
      if (other.ProducerProjectId.Length != 0) {
        ProducerProjectId = other.ProducerProjectId;
      }
      apis_.Add(other.apis_);
      types_.Add(other.types_);
      enums_.Add(other.enums_);
      if (other.documentation_ != null) {
        if (documentation_ == null) {
          documentation_ = new global::Google.Api.Documentation();
        }
        Documentation.MergeFrom(other.Documentation);
      }
      if (other.backend_ != null) {
        if (backend_ == null) {
          backend_ = new global::Google.Api.Backend();
        }
        Backend.MergeFrom(other.Backend);
      }
      if (other.http_ != null) {
        if (http_ == null) {
          http_ = new global::Google.Api.Http();
        }
        Http.MergeFrom(other.Http);
      }
      if (other.authentication_ != null) {
        if (authentication_ == null) {
          authentication_ = new global::Google.Api.Authentication();
        }
        Authentication.MergeFrom(other.Authentication);
      }
      if (other.context_ != null) {
        if (context_ == null) {
          context_ = new global::Google.Api.Context();
        }
        Context.MergeFrom(other.Context);
      }
      if (other.usage_ != null) {
        if (usage_ == null) {
          usage_ = new global::Google.Api.Usage();
        }
        Usage.MergeFrom(other.Usage);
      }
      endpoints_.Add(other.endpoints_);
      if (other.control_ != null) {
        if (control_ == null) {
          control_ = new global::Google.Api.Control();
        }
        Control.MergeFrom(other.Control);
      }
      logs_.Add(other.logs_);
      metrics_.Add(other.metrics_);
      monitoredResources_.Add(other.monitoredResources_);
      if (other.logging_ != null) {
        if (logging_ == null) {
          logging_ = new global::Google.Api.Logging();
        }
        Logging.MergeFrom(other.Logging);
      }
      if (other.monitoring_ != null) {
        if (monitoring_ == null) {
          monitoring_ = new global::Google.Api.Monitoring();
        }
        Monitoring.MergeFrom(other.Monitoring);
      }
      if (other.systemParameters_ != null) {
        if (systemParameters_ == null) {
          systemParameters_ = new global::Google.Api.SystemParameters();
        }
        SystemParameters.MergeFrom(other.SystemParameters);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            Title = input.ReadString();
            break;
          }
          case 26: {
            apis_.AddEntriesFrom(input, _repeated_apis_codec);
            break;
          }
          case 34: {
            types_.AddEntriesFrom(input, _repeated_types_codec);
            break;
          }
          case 42: {
            enums_.AddEntriesFrom(input, _repeated_enums_codec);
            break;
          }
          case 50: {
            if (documentation_ == null) {
              documentation_ = new global::Google.Api.Documentation();
            }
            input.ReadMessage(documentation_);
            break;
          }
          case 66: {
            if (backend_ == null) {
              backend_ = new global::Google.Api.Backend();
            }
            input.ReadMessage(backend_);
            break;
          }
          case 74: {
            if (http_ == null) {
              http_ = new global::Google.Api.Http();
            }
            input.ReadMessage(http_);
            break;
          }
          case 90: {
            if (authentication_ == null) {
              authentication_ = new global::Google.Api.Authentication();
            }
            input.ReadMessage(authentication_);
            break;
          }
          case 98: {
            if (context_ == null) {
              context_ = new global::Google.Api.Context();
            }
            input.ReadMessage(context_);
            break;
          }
          case 122: {
            if (usage_ == null) {
              usage_ = new global::Google.Api.Usage();
            }
            input.ReadMessage(usage_);
            break;
          }
          case 146: {
            endpoints_.AddEntriesFrom(input, _repeated_endpoints_codec);
            break;
          }
          case 162: {
            uint? value = _single_configVersion_codec.Read(input);
            if (configVersion_ == null || value != 0) {
              ConfigVersion = value;
            }
            break;
          }
          case 170: {
            if (control_ == null) {
              control_ = new global::Google.Api.Control();
            }
            input.ReadMessage(control_);
            break;
          }
          case 178: {
            ProducerProjectId = input.ReadString();
            break;
          }
          case 186: {
            logs_.AddEntriesFrom(input, _repeated_logs_codec);
            break;
          }
          case 194: {
            metrics_.AddEntriesFrom(input, _repeated_metrics_codec);
            break;
          }
          case 202: {
            monitoredResources_.AddEntriesFrom(input, _repeated_monitoredResources_codec);
            break;
          }
          case 218: {
            if (logging_ == null) {
              logging_ = new global::Google.Api.Logging();
            }
            input.ReadMessage(logging_);
            break;
          }
          case 226: {
            if (monitoring_ == null) {
              monitoring_ = new global::Google.Api.Monitoring();
            }
            input.ReadMessage(monitoring_);
            break;
          }
          case 234: {
            if (systemParameters_ == null) {
              systemParameters_ = new global::Google.Api.SystemParameters();
            }
            input.ReadMessage(systemParameters_);
            break;
          }
          case 266: {
            Id = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
