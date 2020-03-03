/*
 * Copyright 2020 Google LLC All Rights Reserved.
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/api/label.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Api {

  /// <summary>Holder for reflection information generated from google/api/label.proto</summary>
  public static partial class LabelReflection {

    #region Descriptor
    /// <summary>File descriptor for google/api/label.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LabelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZnb29nbGUvYXBpL2xhYmVsLnByb3RvEgpnb29nbGUuYXBpIpwBCg9MYWJl",
            "bERlc2NyaXB0b3ISCwoDa2V5GAEgASgJEjkKCnZhbHVlX3R5cGUYAiABKA4y",
            "JS5nb29nbGUuYXBpLkxhYmVsRGVzY3JpcHRvci5WYWx1ZVR5cGUSEwoLZGVz",
            "Y3JpcHRpb24YAyABKAkiLAoJVmFsdWVUeXBlEgoKBlNUUklORxAAEggKBEJP",
            "T0wQARIJCgVJTlQ2NBACQl8KDmNvbS5nb29nbGUuYXBpQgpMYWJlbFByb3Rv",
            "UAFaNWdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYXBp",
            "L2xhYmVsO2xhYmVs+AEBogIER0FQSWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Api.LabelDescriptor), global::Google.Api.LabelDescriptor.Parser, new[]{ "Key", "ValueType", "Description" }, null, new[]{ typeof(global::Google.Api.LabelDescriptor.Types.ValueType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A description of a label.
  /// </summary>
  public sealed partial class LabelDescriptor : pb::IMessage<LabelDescriptor> {
    private static readonly pb::MessageParser<LabelDescriptor> _parser = new pb::MessageParser<LabelDescriptor>(() => new LabelDescriptor());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LabelDescriptor> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Api.LabelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LabelDescriptor() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LabelDescriptor(LabelDescriptor other) : this() {
      key_ = other.key_;
      valueType_ = other.valueType_;
      description_ = other.description_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LabelDescriptor Clone() {
      return new LabelDescriptor(this);
    }

    /// <summary>Field number for the "key" field.</summary>
    public const int KeyFieldNumber = 1;
    private string key_ = "";
    /// <summary>
    /// The label key.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Key {
      get { return key_; }
      set {
        key_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "value_type" field.</summary>
    public const int ValueTypeFieldNumber = 2;
    private global::Google.Api.LabelDescriptor.Types.ValueType valueType_ = global::Google.Api.LabelDescriptor.Types.ValueType.String;
    /// <summary>
    /// The type of data that can be assigned to the label.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Api.LabelDescriptor.Types.ValueType ValueType {
      get { return valueType_; }
      set {
        valueType_ = value;
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 3;
    private string description_ = "";
    /// <summary>
    /// A human-readable description for the label.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LabelDescriptor);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LabelDescriptor other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Key != other.Key) return false;
      if (ValueType != other.ValueType) return false;
      if (Description != other.Description) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Key.Length != 0) hash ^= Key.GetHashCode();
      if (ValueType != global::Google.Api.LabelDescriptor.Types.ValueType.String) hash ^= ValueType.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
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
      if (Key.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Key);
      }
      if (ValueType != global::Google.Api.LabelDescriptor.Types.ValueType.String) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ValueType);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Description);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Key.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Key);
      }
      if (ValueType != global::Google.Api.LabelDescriptor.Types.ValueType.String) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ValueType);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LabelDescriptor other) {
      if (other == null) {
        return;
      }
      if (other.Key.Length != 0) {
        Key = other.Key;
      }
      if (other.ValueType != global::Google.Api.LabelDescriptor.Types.ValueType.String) {
        ValueType = other.ValueType;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
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
            Key = input.ReadString();
            break;
          }
          case 16: {
            ValueType = (global::Google.Api.LabelDescriptor.Types.ValueType) input.ReadEnum();
            break;
          }
          case 26: {
            Description = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the LabelDescriptor message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Value types that can be used as label values.
      /// </summary>
      public enum ValueType {
        /// <summary>
        /// A variable-length string. This is the default.
        /// </summary>
        [pbr::OriginalName("STRING")] String = 0,
        /// <summary>
        /// Boolean; true or false.
        /// </summary>
        [pbr::OriginalName("BOOL")] Bool = 1,
        /// <summary>
        /// A 64-bit signed integer.
        /// </summary>
        [pbr::OriginalName("INT64")] Int64 = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
