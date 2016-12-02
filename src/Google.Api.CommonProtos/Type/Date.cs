/*
 * Copyright 2016 Google Inc. All Rights Reserved.
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */

// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/type/date.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Type {

  /// <summary>Holder for reflection information generated from google/type/date.proto</summary>
  public static partial class DateReflection {

    #region Descriptor
    /// <summary>File descriptor for google/type/date.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZnb29nbGUvdHlwZS9kYXRlLnByb3RvEgtnb29nbGUudHlwZSIwCgREYXRl",
            "EgwKBHllYXIYASABKAUSDQoFbW9udGgYAiABKAUSCwoDZGF5GAMgASgFQiQK",
            "D2NvbS5nb29nbGUudHlwZUIJRGF0ZVByb3RvUAGiAgNHVFBiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Type.Date), global::Google.Type.Date.Parser, new[]{ "Year", "Month", "Day" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  Represents a whole calendar date, e.g. date of birth. The time of day and
  ///  time zone are either specified elsewhere or are not significant. The date
  ///  is relative to the Proleptic Gregorian Calendar. The day may be 0 to
  ///  represent a year and month where the day is not significant, e.g. credit card
  ///  expiration date. The year may be 0 to represent a month and day independent
  ///  of year, e.g. anniversary date. Related types are [google.type.TimeOfDay][google.type.TimeOfDay]
  ///  and `google.protobuf.Timestamp`.
  /// </summary>
  public sealed partial class Date : pb::IMessage<Date> {
    private static readonly pb::MessageParser<Date> _parser = new pb::MessageParser<Date>(() => new Date());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Date> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Type.DateReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Date() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Date(Date other) : this() {
      year_ = other.year_;
      month_ = other.month_;
      day_ = other.day_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Date Clone() {
      return new Date(this);
    }

    /// <summary>Field number for the "year" field.</summary>
    public const int YearFieldNumber = 1;
    private int year_;
    /// <summary>
    ///  Year of date. Must be from 1 to 9999, or 0 if specifying a date without
    ///  a year.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Year {
      get { return year_; }
      set {
        year_ = value;
      }
    }

    /// <summary>Field number for the "month" field.</summary>
    public const int MonthFieldNumber = 2;
    private int month_;
    /// <summary>
    ///  Month of year. Must be from 1 to 12.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Month {
      get { return month_; }
      set {
        month_ = value;
      }
    }

    /// <summary>Field number for the "day" field.</summary>
    public const int DayFieldNumber = 3;
    private int day_;
    /// <summary>
    ///  Day of month. Must be from 1 to 31 and valid for the year and month, or 0
    ///  if specifying a year/month where the day is not significant.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Day {
      get { return day_; }
      set {
        day_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Date);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Date other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Year != other.Year) return false;
      if (Month != other.Month) return false;
      if (Day != other.Day) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Year != 0) hash ^= Year.GetHashCode();
      if (Month != 0) hash ^= Month.GetHashCode();
      if (Day != 0) hash ^= Day.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Year != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Year);
      }
      if (Month != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Month);
      }
      if (Day != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Day);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Year != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Year);
      }
      if (Month != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Month);
      }
      if (Day != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Day);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Date other) {
      if (other == null) {
        return;
      }
      if (other.Year != 0) {
        Year = other.Year;
      }
      if (other.Month != 0) {
        Month = other.Month;
      }
      if (other.Day != 0) {
        Day = other.Day;
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
          case 8: {
            Year = input.ReadInt32();
            break;
          }
          case 16: {
            Month = input.ReadInt32();
            break;
          }
          case 24: {
            Day = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
