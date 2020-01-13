/*
 * Copyright 2020 Google Inc. All Rights Reserved.
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/api/resource.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Api {

  /// <summary>Holder for reflection information generated from google/api/resource.proto</summary>
  public static partial class ResourceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/api/resource.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ResourceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvEgpnb29nbGUuYXBpGiBnb29n",
            "bGUvcHJvdG9idWYvZGVzY3JpcHRvci5wcm90byL/AQoSUmVzb3VyY2VEZXNj",
            "cmlwdG9yEgwKBHR5cGUYASABKAkSDwoHcGF0dGVybhgCIAMoCRISCgpuYW1l",
            "X2ZpZWxkGAMgASgJEjcKB2hpc3RvcnkYBCABKA4yJi5nb29nbGUuYXBpLlJl",
            "c291cmNlRGVzY3JpcHRvci5IaXN0b3J5Eg4KBnBsdXJhbBgFIAEoCRIQCghz",
            "aW5ndWxhchgGIAEoCSJbCgdIaXN0b3J5EhcKE0hJU1RPUllfVU5TUEVDSUZJ",
            "RUQQABIdChlPUklHSU5BTExZX1NJTkdMRV9QQVRURVJOEAESGAoURlVUVVJF",
            "X01VTFRJX1BBVFRFUk4QAiI1ChFSZXNvdXJjZVJlZmVyZW5jZRIMCgR0eXBl",
            "GAEgASgJEhIKCmNoaWxkX3R5cGUYAiABKAk6WQoScmVzb3VyY2VfcmVmZXJl",
            "bmNlEh0uZ29vZ2xlLnByb3RvYnVmLkZpZWxkT3B0aW9ucxifCCABKAsyHS5n",
            "b29nbGUuYXBpLlJlc291cmNlUmVmZXJlbmNlOloKE3Jlc291cmNlX2RlZmlu",
            "aXRpb24SHC5nb29nbGUucHJvdG9idWYuRmlsZU9wdGlvbnMYnQggAygLMh4u",
            "Z29vZ2xlLmFwaS5SZXNvdXJjZURlc2NyaXB0b3I6UgoIcmVzb3VyY2USHy5n",
            "b29nbGUucHJvdG9idWYuTWVzc2FnZU9wdGlvbnMYnQggASgLMh4uZ29vZ2xl",
            "LmFwaS5SZXNvdXJjZURlc2NyaXB0b3JCbgoOY29tLmdvb2dsZS5hcGlCDVJl",
            "c291cmNlUHJvdG9QAVpBZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29v",
            "Z2xlYXBpcy9hcGkvYW5ub3RhdGlvbnM7YW5ub3RhdGlvbnP4AQGiAgRHQVBJ",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.Reflection.DescriptorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pb::Extension[] { ResourceExtensions.ResourceReference, ResourceExtensions.ResourceDefinition, ResourceExtensions.Resource }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Api.ResourceDescriptor), global::Google.Api.ResourceDescriptor.Parser, new[]{ "Type", "Pattern", "NameField", "History", "Plural", "Singular" }, null, new[]{ typeof(global::Google.Api.ResourceDescriptor.Types.History) }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Api.ResourceReference), global::Google.Api.ResourceReference.Parser, new[]{ "Type", "ChildType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  /// <summary>Holder for extension identifiers generated from the top level of google/api/resource.proto</summary>
  public static partial class ResourceExtensions {
    /// <summary>
    /// An annotation that describes a resource reference, see
    /// [ResourceReference][].
    /// </summary>
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, global::Google.Api.ResourceReference> ResourceReference =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, global::Google.Api.ResourceReference>(1055, pb::FieldCodec.ForMessage(8442, global::Google.Api.ResourceReference.Parser));
    /// <summary>
    /// An annotation that describes a resource definition without a corresponding
    /// message; see [ResourceDescriptor][].
    /// </summary>
    public static readonly pb::RepeatedExtension<global::Google.Protobuf.Reflection.FileOptions, global::Google.Api.ResourceDescriptor> ResourceDefinition =
      new pb::RepeatedExtension<global::Google.Protobuf.Reflection.FileOptions, global::Google.Api.ResourceDescriptor>(1053, pb::FieldCodec.ForMessage(8426, global::Google.Api.ResourceDescriptor.Parser));
    /// <summary>
    /// An annotation that describes a resource definition, see
    /// [ResourceDescriptor][].
    /// </summary>
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, global::Google.Api.ResourceDescriptor> Resource =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, global::Google.Api.ResourceDescriptor>(1053, pb::FieldCodec.ForMessage(8426, global::Google.Api.ResourceDescriptor.Parser));
  }

  #region Messages
  /// <summary>
  /// A simple descriptor of a resource type.
  ///
  /// ResourceDescriptor annotates a resource message (either by means of a
  /// protobuf annotation or use in the service config), and associates the
  /// resource's schema, the resource type, and the pattern of the resource name.
  ///
  /// Example:
  ///
  ///     message Topic {
  ///       // Indicates this message defines a resource schema.
  ///       // Declares the resource type in the format of {service}/{kind}.
  ///       // For Kubernetes resources, the format is {api group}/{kind}.
  ///       option (google.api.resource) = {
  ///         type: "pubsub.googleapis.com/Topic"
  ///         name_descriptor: {
  ///           pattern: "projects/{project}/topics/{topic}"
  ///           parent_type: "cloudresourcemanager.googleapis.com/Project"
  ///           parent_name_extractor: "projects/{project}"
  ///         }
  ///       };
  ///     }
  ///
  /// The ResourceDescriptor Yaml config will look like:
  ///
  ///    resources:
  ///    - type: "pubsub.googleapis.com/Topic"
  ///      name_descriptor:
  ///        - pattern: "projects/{project}/topics/{topic}"
  ///          parent_type: "cloudresourcemanager.googleapis.com/Project"
  ///          parent_name_extractor: "projects/{project}"
  ///
  /// Sometimes, resources have multiple patterns, typically because they can
  /// live under multiple parents.
  ///
  /// Example:
  ///
  ///     message LogEntry {
  ///       option (google.api.resource) = {
  ///         type: "logging.googleapis.com/LogEntry"
  ///         name_descriptor: {
  ///           pattern: "projects/{project}/logs/{log}"
  ///           parent_type: "cloudresourcemanager.googleapis.com/Project"
  ///           parent_name_extractor: "projects/{project}"
  ///         }
  ///         name_descriptor: {
  ///           pattern: "folders/{folder}/logs/{log}"
  ///           parent_type: "cloudresourcemanager.googleapis.com/Folder"
  ///           parent_name_extractor: "folders/{folder}"
  ///         }
  ///         name_descriptor: {
  ///           pattern: "organizations/{organization}/logs/{log}"
  ///           parent_type: "cloudresourcemanager.googleapis.com/Organization"
  ///           parent_name_extractor: "organizations/{organization}"
  ///         }
  ///         name_descriptor: {
  ///           pattern: "billingAccounts/{billing_account}/logs/{log}"
  ///           parent_type: "billing.googleapis.com/BillingAccount"
  ///           parent_name_extractor: "billingAccounts/{billing_account}"
  ///         }
  ///       };
  ///     }
  ///
  /// The ResourceDescriptor Yaml config will look like:
  ///
  ///     resources:
  ///     - type: 'logging.googleapis.com/LogEntry'
  ///       name_descriptor:
  ///         - pattern: "projects/{project}/logs/{log}"
  ///           parent_type: "cloudresourcemanager.googleapis.com/Project"
  ///           parent_name_extractor: "projects/{project}"
  ///         - pattern: "folders/{folder}/logs/{log}"
  ///           parent_type: "cloudresourcemanager.googleapis.com/Folder"
  ///           parent_name_extractor: "folders/{folder}"
  ///         - pattern: "organizations/{organization}/logs/{log}"
  ///           parent_type: "cloudresourcemanager.googleapis.com/Organization"
  ///           parent_name_extractor: "organizations/{organization}"
  ///         - pattern: "billingAccounts/{billing_account}/logs/{log}"
  ///           parent_type: "billing.googleapis.com/BillingAccount"
  ///           parent_name_extractor: "billingAccounts/{billing_account}"
  ///
  /// For flexible resources, the resource name doesn't contain parent names, but
  /// the resource itself has parents for policy evaluation.
  ///
  /// Example:
  ///
  ///     message Shelf {
  ///       option (google.api.resource) = {
  ///         type: "library.googleapis.com/Shelf"
  ///         name_descriptor: {
  ///           pattern: "shelves/{shelf}"
  ///           parent_type: "cloudresourcemanager.googleapis.com/Project"
  ///         }
  ///         name_descriptor: {
  ///           pattern: "shelves/{shelf}"
  ///           parent_type: "cloudresourcemanager.googleapis.com/Folder"
  ///         }
  ///       };
  ///     }
  ///
  /// The ResourceDescriptor Yaml config will look like:
  ///
  ///     resources:
  ///     - type: 'library.googleapis.com/Shelf'
  ///       name_descriptor:
  ///         - pattern: "shelves/{shelf}"
  ///           parent_type: "cloudresourcemanager.googleapis.com/Project"
  ///         - pattern: "shelves/{shelf}"
  ///           parent_type: "cloudresourcemanager.googleapis.com/Folder"
  /// </summary>
  public sealed partial class ResourceDescriptor : pb::IMessage<ResourceDescriptor> {
    private static readonly pb::MessageParser<ResourceDescriptor> _parser = new pb::MessageParser<ResourceDescriptor>(() => new ResourceDescriptor());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ResourceDescriptor> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Api.ResourceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResourceDescriptor() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResourceDescriptor(ResourceDescriptor other) : this() {
      type_ = other.type_;
      pattern_ = other.pattern_.Clone();
      nameField_ = other.nameField_;
      history_ = other.history_;
      plural_ = other.plural_;
      singular_ = other.singular_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResourceDescriptor Clone() {
      return new ResourceDescriptor(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private string type_ = "";
    /// <summary>
    /// The resource type. It must be in the format of
    /// {service_name}/{resource_type_kind}. The `resource_type_kind` must be
    /// singular and must not include version numbers.
    ///
    /// Example: `storage.googleapis.com/Bucket`
    ///
    /// The value of the resource_type_kind must follow the regular expression
    /// /[A-Za-z][a-zA-Z0-9]+/. It should start with an upper case character and
    /// should use PascalCase (UpperCamelCase). The maximum number of
    /// characters allowed for the `resource_type_kind` is 100.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "pattern" field.</summary>
    public const int PatternFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_pattern_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> pattern_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Optional. The relative resource name pattern associated with this resource
    /// type. The DNS prefix of the full resource name shouldn't be specified here.
    ///
    /// The path pattern must follow the syntax, which aligns with HTTP binding
    /// syntax:
    ///
    ///     Template = Segment { "/" Segment } ;
    ///     Segment = LITERAL | Variable ;
    ///     Variable = "{" LITERAL "}" ;
    ///
    /// Examples:
    ///
    ///     - "projects/{project}/topics/{topic}"
    ///     - "projects/{project}/knowledgeBases/{knowledge_base}"
    ///
    /// The components in braces correspond to the IDs for each resource in the
    /// hierarchy. It is expected that, if multiple patterns are provided,
    /// the same component name (e.g. "project") refers to IDs of the same
    /// type of resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Pattern {
      get { return pattern_; }
    }

    /// <summary>Field number for the "name_field" field.</summary>
    public const int NameFieldFieldNumber = 3;
    private string nameField_ = "";
    /// <summary>
    /// Optional. The field on the resource that designates the resource name
    /// field. If omitted, this is assumed to be "name".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string NameField {
      get { return nameField_; }
      set {
        nameField_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "history" field.</summary>
    public const int HistoryFieldNumber = 4;
    private global::Google.Api.ResourceDescriptor.Types.History history_ = global::Google.Api.ResourceDescriptor.Types.History.Unspecified;
    /// <summary>
    /// Optional. The historical or future-looking state of the resource pattern.
    ///
    /// Example:
    ///
    ///     // The InspectTemplate message originally only supported resource
    ///     // names with organization, and project was added later.
    ///     message InspectTemplate {
    ///       option (google.api.resource) = {
    ///         type: "dlp.googleapis.com/InspectTemplate"
    ///         pattern:
    ///         "organizations/{organization}/inspectTemplates/{inspect_template}"
    ///         pattern: "projects/{project}/inspectTemplates/{inspect_template}"
    ///         history: ORIGINALLY_SINGLE_PATTERN
    ///       };
    ///     }
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Api.ResourceDescriptor.Types.History History {
      get { return history_; }
      set {
        history_ = value;
      }
    }

    /// <summary>Field number for the "plural" field.</summary>
    public const int PluralFieldNumber = 5;
    private string plural_ = "";
    /// <summary>
    /// The plural name used in the resource name, such as 'projects' for
    /// the name of 'projects/{project}'. It is the same concept of the `plural`
    /// field in k8s CRD spec
    /// https://kubernetes.io/docs/tasks/access-kubernetes-api/custom-resources/custom-resource-definitions/
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Plural {
      get { return plural_; }
      set {
        plural_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "singular" field.</summary>
    public const int SingularFieldNumber = 6;
    private string singular_ = "";
    /// <summary>
    /// The same concept of the `singular` field in k8s CRD spec
    /// https://kubernetes.io/docs/tasks/access-kubernetes-api/custom-resources/custom-resource-definitions/
    /// Such as "project" for the `resourcemanager.googleapis.com/Project` type.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Singular {
      get { return singular_; }
      set {
        singular_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ResourceDescriptor);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ResourceDescriptor other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if(!pattern_.Equals(other.pattern_)) return false;
      if (NameField != other.NameField) return false;
      if (History != other.History) return false;
      if (Plural != other.Plural) return false;
      if (Singular != other.Singular) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Type.Length != 0) hash ^= Type.GetHashCode();
      hash ^= pattern_.GetHashCode();
      if (NameField.Length != 0) hash ^= NameField.GetHashCode();
      if (History != global::Google.Api.ResourceDescriptor.Types.History.Unspecified) hash ^= History.GetHashCode();
      if (Plural.Length != 0) hash ^= Plural.GetHashCode();
      if (Singular.Length != 0) hash ^= Singular.GetHashCode();
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
      if (Type.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Type);
      }
      pattern_.WriteTo(output, _repeated_pattern_codec);
      if (NameField.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(NameField);
      }
      if (History != global::Google.Api.ResourceDescriptor.Types.History.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) History);
      }
      if (Plural.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Plural);
      }
      if (Singular.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Singular);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      size += pattern_.CalculateSize(_repeated_pattern_codec);
      if (NameField.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NameField);
      }
      if (History != global::Google.Api.ResourceDescriptor.Types.History.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) History);
      }
      if (Plural.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Plural);
      }
      if (Singular.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Singular);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ResourceDescriptor other) {
      if (other == null) {
        return;
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
      }
      pattern_.Add(other.pattern_);
      if (other.NameField.Length != 0) {
        NameField = other.NameField;
      }
      if (other.History != global::Google.Api.ResourceDescriptor.Types.History.Unspecified) {
        History = other.History;
      }
      if (other.Plural.Length != 0) {
        Plural = other.Plural;
      }
      if (other.Singular.Length != 0) {
        Singular = other.Singular;
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
            Type = input.ReadString();
            break;
          }
          case 18: {
            pattern_.AddEntriesFrom(input, _repeated_pattern_codec);
            break;
          }
          case 26: {
            NameField = input.ReadString();
            break;
          }
          case 32: {
            History = (global::Google.Api.ResourceDescriptor.Types.History) input.ReadEnum();
            break;
          }
          case 42: {
            Plural = input.ReadString();
            break;
          }
          case 50: {
            Singular = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ResourceDescriptor message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// A description of the historical or future-looking state of the
      /// resource pattern.
      /// </summary>
      public enum History {
        /// <summary>
        /// The "unset" value.
        /// </summary>
        [pbr::OriginalName("HISTORY_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The resource originally had one pattern and launched as such, and
        /// additional patterns were added later.
        /// </summary>
        [pbr::OriginalName("ORIGINALLY_SINGLE_PATTERN")] OriginallySinglePattern = 1,
        /// <summary>
        /// The resource has one pattern, but the API owner expects to add more
        /// later. (This is the inverse of ORIGINALLY_SINGLE_PATTERN, and prevents
        /// that from being necessary once there are multiple patterns.)
        /// </summary>
        [pbr::OriginalName("FUTURE_MULTI_PATTERN")] FutureMultiPattern = 2,
      }

    }
    #endregion

  }

  /// <summary>
  /// Defines a proto annotation that describes a string field that refers to
  /// an API resource.
  /// </summary>
  public sealed partial class ResourceReference : pb::IMessage<ResourceReference> {
    private static readonly pb::MessageParser<ResourceReference> _parser = new pb::MessageParser<ResourceReference>(() => new ResourceReference());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ResourceReference> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Api.ResourceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResourceReference() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResourceReference(ResourceReference other) : this() {
      type_ = other.type_;
      childType_ = other.childType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResourceReference Clone() {
      return new ResourceReference(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private string type_ = "";
    /// <summary>
    /// The resource type that the annotated field references.
    ///
    /// Example:
    ///
    ///     message Subscription {
    ///       string topic = 2 [(google.api.resource_reference) = {
    ///         type: "pubsub.googleapis.com/Topic"
    ///       }];
    ///     }
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "child_type" field.</summary>
    public const int ChildTypeFieldNumber = 2;
    private string childType_ = "";
    /// <summary>
    /// The resource type of a child collection that the annotated field
    /// references. This is useful for annotating the `parent` field that
    /// doesn't have a fixed resource type.
    ///
    /// Example:
    ///
    ///   message ListLogEntriesRequest {
    ///     string parent = 1 [(google.api.resource_reference) = {
    ///       child_type: "logging.googleapis.com/LogEntry"
    ///     };
    ///   }
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ChildType {
      get { return childType_; }
      set {
        childType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ResourceReference);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ResourceReference other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (ChildType != other.ChildType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Type.Length != 0) hash ^= Type.GetHashCode();
      if (ChildType.Length != 0) hash ^= ChildType.GetHashCode();
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
      if (Type.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Type);
      }
      if (ChildType.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ChildType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      if (ChildType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ChildType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ResourceReference other) {
      if (other == null) {
        return;
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
      }
      if (other.ChildType.Length != 0) {
        ChildType = other.ChildType;
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
            Type = input.ReadString();
            break;
          }
          case 18: {
            ChildType = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
