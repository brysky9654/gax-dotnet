/*
 * Copyright 2020 Google LLC All Rights Reserved.
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/type/datetime.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Type {

  /// <summary>Holder for reflection information generated from google/type/datetime.proto</summary>
  public static partial class DatetimeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/type/datetime.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DatetimeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chpnb29nbGUvdHlwZS9kYXRldGltZS5wcm90bxILZ29vZ2xlLnR5cGUaHmdv",
            "b2dsZS9wcm90b2J1Zi9kdXJhdGlvbi5wcm90byLgAQoIRGF0ZVRpbWUSDAoE",
            "eWVhchgBIAEoBRINCgVtb250aBgCIAEoBRILCgNkYXkYAyABKAUSDQoFaG91",
            "cnMYBCABKAUSDwoHbWludXRlcxgFIAEoBRIPCgdzZWNvbmRzGAYgASgFEg0K",
            "BW5hbm9zGAcgASgFEi8KCnV0Y19vZmZzZXQYCCABKAsyGS5nb29nbGUucHJv",
            "dG9idWYuRHVyYXRpb25IABIqCgl0aW1lX3pvbmUYCSABKAsyFS5nb29nbGUu",
            "dHlwZS5UaW1lWm9uZUgAQg0KC3RpbWVfb2Zmc2V0IicKCFRpbWVab25lEgoK",
            "AmlkGAEgASgJEg8KB3ZlcnNpb24YAiABKAlCaQoPY29tLmdvb2dsZS50eXBl",
            "Qg1EYXRlVGltZVByb3RvUAFaPGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3Rv",
            "L2dvb2dsZWFwaXMvdHlwZS9kYXRldGltZTtkYXRldGltZfgBAaICA0dUUGIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Type.DateTime), global::Google.Type.DateTime.Parser, new[]{ "Year", "Month", "Day", "Hours", "Minutes", "Seconds", "Nanos", "UtcOffset", "TimeZone" }, new[]{ "TimeOffset" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Type.TimeZone), global::Google.Type.TimeZone.Parser, new[]{ "Id", "Version" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents civil time (or occasionally physical time).
  ///
  /// This type can represent a civil time in one of a few possible ways:
  ///
  ///  * When utc_offset is set and time_zone is unset: a civil time on a calendar
  ///    day with a particular offset from UTC.
  ///  * When time_zone is set and utc_offset is unset: a civil time on a calendar
  ///    day in a particular time zone.
  ///  * When neither time_zone nor utc_offset is set: a civil time on a calendar
  ///    day in local time.
  ///
  /// The date is relative to the Proleptic Gregorian Calendar.
  ///
  /// If year is 0, the DateTime is considered not to have a specific year. month
  /// and day must have valid, non-zero values.
  ///
  /// This type may also be used to represent a physical time if all the date and
  /// time fields are set and either case of the `time_offset` oneof is set.
  /// Consider using `Timestamp` message for physical time instead. If your use
  /// case also would like to store the user's timezone, that can be done in
  /// another field.
  ///
  /// This type is more flexible than some applications may want. Make sure to
  /// document and validate your application's limitations.
  /// </summary>
  public sealed partial class DateTime : pb::IMessage<DateTime>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DateTime> _parser = new pb::MessageParser<DateTime>(() => new DateTime());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DateTime> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Type.DatetimeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DateTime() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DateTime(DateTime other) : this() {
      year_ = other.year_;
      month_ = other.month_;
      day_ = other.day_;
      hours_ = other.hours_;
      minutes_ = other.minutes_;
      seconds_ = other.seconds_;
      nanos_ = other.nanos_;
      switch (other.TimeOffsetCase) {
        case TimeOffsetOneofCase.UtcOffset:
          UtcOffset = other.UtcOffset.Clone();
          break;
        case TimeOffsetOneofCase.TimeZone:
          TimeZone = other.TimeZone.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DateTime Clone() {
      return new DateTime(this);
    }

    /// <summary>Field number for the "year" field.</summary>
    public const int YearFieldNumber = 1;
    private int year_;
    /// <summary>
    /// Optional. Year of date. Must be from 1 to 9999, or 0 if specifying a
    /// datetime without a year.
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
    /// Required. Month of year. Must be from 1 to 12.
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
    /// Required. Day of month. Must be from 1 to 31 and valid for the year and
    /// month.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Day {
      get { return day_; }
      set {
        day_ = value;
      }
    }

    /// <summary>Field number for the "hours" field.</summary>
    public const int HoursFieldNumber = 4;
    private int hours_;
    /// <summary>
    /// Required. Hours of day in 24 hour format. Should be from 0 to 23. An API
    /// may choose to allow the value "24:00:00" for scenarios like business
    /// closing time.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Hours {
      get { return hours_; }
      set {
        hours_ = value;
      }
    }

    /// <summary>Field number for the "minutes" field.</summary>
    public const int MinutesFieldNumber = 5;
    private int minutes_;
    /// <summary>
    /// Required. Minutes of hour of day. Must be from 0 to 59.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Minutes {
      get { return minutes_; }
      set {
        minutes_ = value;
      }
    }

    /// <summary>Field number for the "seconds" field.</summary>
    public const int SecondsFieldNumber = 6;
    private int seconds_;
    /// <summary>
    /// Required. Seconds of minutes of the time. Must normally be from 0 to 59. An
    /// API may allow the value 60 if it allows leap-seconds.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Seconds {
      get { return seconds_; }
      set {
        seconds_ = value;
      }
    }

    /// <summary>Field number for the "nanos" field.</summary>
    public const int NanosFieldNumber = 7;
    private int nanos_;
    /// <summary>
    /// Required. Fractions of seconds in nanoseconds. Must be from 0 to
    /// 999,999,999.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Nanos {
      get { return nanos_; }
      set {
        nanos_ = value;
      }
    }

    /// <summary>Field number for the "utc_offset" field.</summary>
    public const int UtcOffsetFieldNumber = 8;
    /// <summary>
    /// UTC offset. Must be whole seconds, between -18 hours and +18 hours.
    /// For example, a UTC offset of -4:00 would be represented as
    /// { seconds: -14400 }.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration UtcOffset {
      get { return timeOffsetCase_ == TimeOffsetOneofCase.UtcOffset ? (global::Google.Protobuf.WellKnownTypes.Duration) timeOffset_ : null; }
      set {
        timeOffset_ = value;
        timeOffsetCase_ = value == null ? TimeOffsetOneofCase.None : TimeOffsetOneofCase.UtcOffset;
      }
    }

    /// <summary>Field number for the "time_zone" field.</summary>
    public const int TimeZoneFieldNumber = 9;
    /// <summary>
    /// Time zone.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Type.TimeZone TimeZone {
      get { return timeOffsetCase_ == TimeOffsetOneofCase.TimeZone ? (global::Google.Type.TimeZone) timeOffset_ : null; }
      set {
        timeOffset_ = value;
        timeOffsetCase_ = value == null ? TimeOffsetOneofCase.None : TimeOffsetOneofCase.TimeZone;
      }
    }

    private object timeOffset_;
    /// <summary>Enum of possible cases for the "time_offset" oneof.</summary>
    public enum TimeOffsetOneofCase {
      None = 0,
      UtcOffset = 8,
      TimeZone = 9,
    }
    private TimeOffsetOneofCase timeOffsetCase_ = TimeOffsetOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimeOffsetOneofCase TimeOffsetCase {
      get { return timeOffsetCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearTimeOffset() {
      timeOffsetCase_ = TimeOffsetOneofCase.None;
      timeOffset_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DateTime);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DateTime other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Year != other.Year) return false;
      if (Month != other.Month) return false;
      if (Day != other.Day) return false;
      if (Hours != other.Hours) return false;
      if (Minutes != other.Minutes) return false;
      if (Seconds != other.Seconds) return false;
      if (Nanos != other.Nanos) return false;
      if (!object.Equals(UtcOffset, other.UtcOffset)) return false;
      if (!object.Equals(TimeZone, other.TimeZone)) return false;
      if (TimeOffsetCase != other.TimeOffsetCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Year != 0) hash ^= Year.GetHashCode();
      if (Month != 0) hash ^= Month.GetHashCode();
      if (Day != 0) hash ^= Day.GetHashCode();
      if (Hours != 0) hash ^= Hours.GetHashCode();
      if (Minutes != 0) hash ^= Minutes.GetHashCode();
      if (Seconds != 0) hash ^= Seconds.GetHashCode();
      if (Nanos != 0) hash ^= Nanos.GetHashCode();
      if (timeOffsetCase_ == TimeOffsetOneofCase.UtcOffset) hash ^= UtcOffset.GetHashCode();
      if (timeOffsetCase_ == TimeOffsetOneofCase.TimeZone) hash ^= TimeZone.GetHashCode();
      hash ^= (int) timeOffsetCase_;
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
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
      if (Hours != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Hours);
      }
      if (Minutes != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Minutes);
      }
      if (Seconds != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Seconds);
      }
      if (Nanos != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Nanos);
      }
      if (timeOffsetCase_ == TimeOffsetOneofCase.UtcOffset) {
        output.WriteRawTag(66);
        output.WriteMessage(UtcOffset);
      }
      if (timeOffsetCase_ == TimeOffsetOneofCase.TimeZone) {
        output.WriteRawTag(74);
        output.WriteMessage(TimeZone);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
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
      if (Hours != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Hours);
      }
      if (Minutes != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Minutes);
      }
      if (Seconds != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Seconds);
      }
      if (Nanos != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Nanos);
      }
      if (timeOffsetCase_ == TimeOffsetOneofCase.UtcOffset) {
        output.WriteRawTag(66);
        output.WriteMessage(UtcOffset);
      }
      if (timeOffsetCase_ == TimeOffsetOneofCase.TimeZone) {
        output.WriteRawTag(74);
        output.WriteMessage(TimeZone);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

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
      if (Hours != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Hours);
      }
      if (Minutes != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Minutes);
      }
      if (Seconds != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Seconds);
      }
      if (Nanos != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Nanos);
      }
      if (timeOffsetCase_ == TimeOffsetOneofCase.UtcOffset) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UtcOffset);
      }
      if (timeOffsetCase_ == TimeOffsetOneofCase.TimeZone) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TimeZone);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DateTime other) {
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
      if (other.Hours != 0) {
        Hours = other.Hours;
      }
      if (other.Minutes != 0) {
        Minutes = other.Minutes;
      }
      if (other.Seconds != 0) {
        Seconds = other.Seconds;
      }
      if (other.Nanos != 0) {
        Nanos = other.Nanos;
      }
      switch (other.TimeOffsetCase) {
        case TimeOffsetOneofCase.UtcOffset:
          if (UtcOffset == null) {
            UtcOffset = new global::Google.Protobuf.WellKnownTypes.Duration();
          }
          UtcOffset.MergeFrom(other.UtcOffset);
          break;
        case TimeOffsetOneofCase.TimeZone:
          if (TimeZone == null) {
            TimeZone = new global::Google.Type.TimeZone();
          }
          TimeZone.MergeFrom(other.TimeZone);
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
          case 32: {
            Hours = input.ReadInt32();
            break;
          }
          case 40: {
            Minutes = input.ReadInt32();
            break;
          }
          case 48: {
            Seconds = input.ReadInt32();
            break;
          }
          case 56: {
            Nanos = input.ReadInt32();
            break;
          }
          case 66: {
            global::Google.Protobuf.WellKnownTypes.Duration subBuilder = new global::Google.Protobuf.WellKnownTypes.Duration();
            if (timeOffsetCase_ == TimeOffsetOneofCase.UtcOffset) {
              subBuilder.MergeFrom(UtcOffset);
            }
            input.ReadMessage(subBuilder);
            UtcOffset = subBuilder;
            break;
          }
          case 74: {
            global::Google.Type.TimeZone subBuilder = new global::Google.Type.TimeZone();
            if (timeOffsetCase_ == TimeOffsetOneofCase.TimeZone) {
              subBuilder.MergeFrom(TimeZone);
            }
            input.ReadMessage(subBuilder);
            TimeZone = subBuilder;
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
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
          case 32: {
            Hours = input.ReadInt32();
            break;
          }
          case 40: {
            Minutes = input.ReadInt32();
            break;
          }
          case 48: {
            Seconds = input.ReadInt32();
            break;
          }
          case 56: {
            Nanos = input.ReadInt32();
            break;
          }
          case 66: {
            global::Google.Protobuf.WellKnownTypes.Duration subBuilder = new global::Google.Protobuf.WellKnownTypes.Duration();
            if (timeOffsetCase_ == TimeOffsetOneofCase.UtcOffset) {
              subBuilder.MergeFrom(UtcOffset);
            }
            input.ReadMessage(subBuilder);
            UtcOffset = subBuilder;
            break;
          }
          case 74: {
            global::Google.Type.TimeZone subBuilder = new global::Google.Type.TimeZone();
            if (timeOffsetCase_ == TimeOffsetOneofCase.TimeZone) {
              subBuilder.MergeFrom(TimeZone);
            }
            input.ReadMessage(subBuilder);
            TimeZone = subBuilder;
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Represents a time zone from the
  /// [IANA Time Zone Database](https://www.iana.org/time-zones).
  /// </summary>
  public sealed partial class TimeZone : pb::IMessage<TimeZone>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TimeZone> _parser = new pb::MessageParser<TimeZone>(() => new TimeZone());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TimeZone> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Type.DatetimeReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimeZone() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimeZone(TimeZone other) : this() {
      id_ = other.id_;
      version_ = other.version_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimeZone Clone() {
      return new TimeZone(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    /// IANA Time Zone Database time zone, e.g. "America/New_York".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 2;
    private string version_ = "";
    /// <summary>
    /// Optional. IANA Time Zone Database version number, e.g. "2019a".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Version {
      get { return version_; }
      set {
        version_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TimeZone);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TimeZone other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Version != other.Version) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Version.Length != 0) hash ^= Version.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Version.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Version);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Version.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Version);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Version.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Version);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TimeZone other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Version.Length != 0) {
        Version = other.Version;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            Version = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Version = input.ReadString();
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
