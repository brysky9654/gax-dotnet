/*
 * Copyright 2016 Google Inc. All Rights Reserved.
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/api/endpoint.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Api {

  /// <summary>Holder for reflection information generated from google/api/endpoint.proto</summary>
  public static partial class EndpointReflection {

    #region Descriptor
    /// <summary>File descriptor for google/api/endpoint.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EndpointReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chlnb29nbGUvYXBpL2VuZHBvaW50LnByb3RvEgpnb29nbGUuYXBpImMKCEVu",
            "ZHBvaW50EgwKBG5hbWUYASABKAkSEwoHYWxpYXNlcxgCIAMoCUICGAESEAoI",
            "ZmVhdHVyZXMYBCADKAkSDgoGdGFyZ2V0GGUgASgJEhIKCmFsbG93X2NvcnMY",
            "BSABKAhCbwoOY29tLmdvb2dsZS5hcGlCDUVuZHBvaW50UHJvdG9QAVpFZ29v",
            "Z2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hcGkvc2Vydmlj",
            "ZWNvbmZpZztzZXJ2aWNlY29uZmlnogIER0FQSWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Api.Endpoint), global::Google.Api.Endpoint.Parser, new[]{ "Name", "Aliases", "Features", "Target", "AllowCors" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// `Endpoint` describes a network endpoint that serves a set of APIs.
  /// A service may expose any number of endpoints, and all endpoints share the
  /// same service configuration, such as quota configuration and monitoring
  /// configuration.
  ///
  /// Example service configuration:
  ///
  ///     name: library-example.googleapis.com
  ///     endpoints:
  ///       # Below entry makes 'google.example.library.v1.Library'
  ///       # API be served from endpoint address library-example.googleapis.com.
  ///       # It also allows HTTP OPTIONS calls to be passed to the backend, for
  ///       # it to decide whether the subsequent cross-origin request is
  ///       # allowed to proceed.
  ///     - name: library-example.googleapis.com
  ///       allow_cors: true
  /// </summary>
  public sealed partial class Endpoint : pb::IMessage<Endpoint> {
    private static readonly pb::MessageParser<Endpoint> _parser = new pb::MessageParser<Endpoint>(() => new Endpoint());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Endpoint> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Api.EndpointReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Endpoint() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Endpoint(Endpoint other) : this() {
      name_ = other.name_;
      aliases_ = other.aliases_.Clone();
      features_ = other.features_.Clone();
      target_ = other.target_;
      allowCors_ = other.allowCors_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Endpoint Clone() {
      return new Endpoint(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The canonical name of this endpoint.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "aliases" field.</summary>
    public const int AliasesFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_aliases_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> aliases_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// DEPRECATED: This field is no longer supported. Instead of using aliases,
    /// please specify multiple [google.api.Endpoint][google.api.Endpoint] for each of the intended
    /// aliases.
    ///
    /// Additional names that this endpoint will be hosted on.
    /// </summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Aliases {
      get { return aliases_; }
    }

    /// <summary>Field number for the "features" field.</summary>
    public const int FeaturesFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _repeated_features_codec
        = pb::FieldCodec.ForString(34);
    private readonly pbc::RepeatedField<string> features_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// The list of features enabled on this endpoint.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Features {
      get { return features_; }
    }

    /// <summary>Field number for the "target" field.</summary>
    public const int TargetFieldNumber = 101;
    private string target_ = "";
    /// <summary>
    /// The specification of an Internet routable address of API frontend that will
    /// handle requests to this [API
    /// Endpoint](https://cloud.google.com/apis/design/glossary). It should be
    /// either a valid IPv4 address or a fully-qualified domain name. For example,
    /// "8.8.8.8" or "myservice.appspot.com".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Target {
      get { return target_; }
      set {
        target_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "allow_cors" field.</summary>
    public const int AllowCorsFieldNumber = 5;
    private bool allowCors_;
    /// <summary>
    /// Allowing
    /// [CORS](https://en.wikipedia.org/wiki/Cross-origin_resource_sharing), aka
    /// cross-domain traffic, would allow the backends served from this endpoint to
    /// receive and respond to HTTP OPTIONS requests. The response will be used by
    /// the browser to determine whether the subsequent cross-origin request is
    /// allowed to proceed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool AllowCors {
      get { return allowCors_; }
      set {
        allowCors_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Endpoint);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Endpoint other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if(!aliases_.Equals(other.aliases_)) return false;
      if(!features_.Equals(other.features_)) return false;
      if (Target != other.Target) return false;
      if (AllowCors != other.AllowCors) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= aliases_.GetHashCode();
      hash ^= features_.GetHashCode();
      if (Target.Length != 0) hash ^= Target.GetHashCode();
      if (AllowCors != false) hash ^= AllowCors.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      aliases_.WriteTo(output, _repeated_aliases_codec);
      features_.WriteTo(output, _repeated_features_codec);
      if (AllowCors != false) {
        output.WriteRawTag(40);
        output.WriteBool(AllowCors);
      }
      if (Target.Length != 0) {
        output.WriteRawTag(170, 6);
        output.WriteString(Target);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      size += aliases_.CalculateSize(_repeated_aliases_codec);
      size += features_.CalculateSize(_repeated_features_codec);
      if (Target.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Target);
      }
      if (AllowCors != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Endpoint other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      aliases_.Add(other.aliases_);
      features_.Add(other.features_);
      if (other.Target.Length != 0) {
        Target = other.Target;
      }
      if (other.AllowCors != false) {
        AllowCors = other.AllowCors;
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            aliases_.AddEntriesFrom(input, _repeated_aliases_codec);
            break;
          }
          case 34: {
            features_.AddEntriesFrom(input, _repeated_features_codec);
            break;
          }
          case 40: {
            AllowCors = input.ReadBool();
            break;
          }
          case 810: {
            Target = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
