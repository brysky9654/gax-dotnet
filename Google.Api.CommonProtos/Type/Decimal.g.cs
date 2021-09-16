/*
 * Copyright 2021 Google LLC All Rights Reserved.
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/type/decimal.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Type {

  /// <summary>Holder for reflection information generated from google/type/decimal.proto</summary>
  public static partial class DecimalReflection {

    #region Descriptor
    /// <summary>File descriptor for google/type/decimal.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DecimalReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chlnb29nbGUvdHlwZS9kZWNpbWFsLnByb3RvEgtnb29nbGUudHlwZSIYCgdE",
            "ZWNpbWFsEg0KBXZhbHVlGAEgASgJQmYKD2NvbS5nb29nbGUudHlwZUIMRGVj",
            "aW1hbFByb3RvUAFaOmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2ds",
            "ZWFwaXMvdHlwZS9kZWNpbWFsO2RlY2ltYWz4AQGiAgNHVFBiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Type.Decimal), global::Google.Type.Decimal.Parser, new[]{ "Value" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A representation of a decimal value, such as 2.5. Clients may convert values
  /// into language-native decimal formats, such as Java's [BigDecimal][] or
  /// Python's [decimal.Decimal][].
  ///
  /// [BigDecimal]:
  /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html
  /// [decimal.Decimal]: https://docs.python.org/3/library/decimal.html
  /// </summary>
  public sealed partial class Decimal : pb::IMessage<Decimal>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Decimal> _parser = new pb::MessageParser<Decimal>(() => new Decimal());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Decimal> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Type.DecimalReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Decimal() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Decimal(Decimal other) : this() {
      value_ = other.value_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Decimal Clone() {
      return new Decimal(this);
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 1;
    private string value_ = "";
    /// <summary>
    /// The decimal value, as a string.
    ///
    /// The string representation consists of an optional sign, `+` (`U+002B`)
    /// or `-` (`U+002D`), followed by a sequence of zero or more decimal digits
    /// ("the integer"), optionally followed by a fraction, optionally followed
    /// by an exponent.
    ///
    /// The fraction consists of a decimal point followed by zero or more decimal
    /// digits. The string must contain at least one digit in either the integer
    /// or the fraction. The number formed by the sign, the integer and the
    /// fraction is referred to as the significand.
    ///
    /// The exponent consists of the character `e` (`U+0065`) or `E` (`U+0045`)
    /// followed by one or more decimal digits.
    ///
    /// Services **should** normalize decimal values before storing them by:
    ///
    ///   - Removing an explicitly-provided `+` sign (`+2.5` -> `2.5`).
    ///   - Replacing a zero-length integer value with `0` (`.5` -> `0.5`).
    ///   - Coercing the exponent character to lower-case (`2.5E8` -> `2.5e8`).
    ///   - Removing an explicitly-provided zero exponent (`2.5e0` -> `2.5`).
    ///
    /// Services **may** perform additional normalization based on its own needs
    /// and the internal decimal implementation selected, such as shifting the
    /// decimal point and exponent value together (example: `2.5e-1` &lt;-> `0.25`).
    /// Additionally, services **may** preserve trailing zeroes in the fraction
    /// to indicate increased precision, but are not required to do so.
    ///
    /// Note that only the `.` character is supported to divide the integer
    /// and the fraction; `,` **should not** be supported regardless of locale.
    /// Additionally, thousand separators **should not** be supported. If a
    /// service does support them, values **must** be normalized.
    ///
    /// The ENBF grammar is:
    ///
    ///     DecimalString =
    ///       [Sign] Significand [Exponent];
    ///
    ///     Sign = '+' | '-';
    ///
    ///     Significand =
    ///       Digits ['.'] [Digits] | [Digits] '.' Digits;
    ///
    ///     Exponent = ('e' | 'E') [Sign] Digits;
    ///
    ///     Digits = { '0' | '1' | '2' | '3' | '4' | '5' | '6' | '7' | '8' | '9' };
    ///
    /// Services **should** clearly document the range of supported values, the
    /// maximum supported precision (total number of digits), and, if applicable,
    /// the scale (number of digits after the decimal point), as well as how it
    /// behaves when receiving out-of-bounds values.
    ///
    /// Services **may** choose to accept values passed as input even when the
    /// value has a higher precision or scale than the service supports, and
    /// **should** round the value to fit the supported scale. Alternatively, the
    /// service **may** error with `400 Bad Request` (`INVALID_ARGUMENT` in gRPC)
    /// if precision would be lost.
    ///
    /// Services **should** error with `400 Bad Request` (`INVALID_ARGUMENT` in
    /// gRPC) if the service receives a value outside of the supported range.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Value {
      get { return value_; }
      set {
        value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Decimal);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Decimal other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Value != other.Value) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Value.Length != 0) hash ^= Value.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Value.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Value);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Value.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Value);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Value.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Value);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Decimal other) {
      if (other == null) {
        return;
      }
      if (other.Value.Length != 0) {
        Value = other.Value;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Value = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Value = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
