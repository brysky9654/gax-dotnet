/*
 * Copyright 2021 Google LLC All Rights Reserved.
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/type/calendar_period.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Type {

  /// <summary>Holder for reflection information generated from google/type/calendar_period.proto</summary>
  public static partial class CalendarPeriodReflection {

    #region Descriptor
    /// <summary>File descriptor for google/type/calendar_period.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CalendarPeriodReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFnb29nbGUvdHlwZS9jYWxlbmRhcl9wZXJpb2QucHJvdG8SC2dvb2dsZS50",
            "eXBlKn8KDkNhbGVuZGFyUGVyaW9kEh8KG0NBTEVOREFSX1BFUklPRF9VTlNQ",
            "RUNJRklFRBAAEgcKA0RBWRABEggKBFdFRUsQAhINCglGT1JUTklHSFQQAxIJ",
            "CgVNT05USBAEEgsKB1FVQVJURVIQBRIICgRIQUxGEAYSCAoEWUVBUhAHQngK",
            "D2NvbS5nb29nbGUudHlwZUITQ2FsZW5kYXJQZXJpb2RQcm90b1ABWkhnb29n",
            "bGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL3R5cGUvY2FsZW5k",
            "YXJwZXJpb2Q7Y2FsZW5kYXJwZXJpb2SiAgNHVFBiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Type.CalendarPeriod), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// A `CalendarPeriod` represents the abstract concept of a time period that has
  /// a canonical start. Grammatically, "the start of the current
  /// `CalendarPeriod`." All calendar times begin at midnight UTC.
  /// </summary>
  public enum CalendarPeriod {
    /// <summary>
    /// Undefined period, raises an error.
    /// </summary>
    [pbr::OriginalName("CALENDAR_PERIOD_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// A day.
    /// </summary>
    [pbr::OriginalName("DAY")] Day = 1,
    /// <summary>
    /// A week. Weeks begin on Monday, following
    /// [ISO 8601](https://en.wikipedia.org/wiki/ISO_week_date).
    /// </summary>
    [pbr::OriginalName("WEEK")] Week = 2,
    /// <summary>
    /// A fortnight. The first calendar fortnight of the year begins at the start
    /// of week 1 according to
    /// [ISO 8601](https://en.wikipedia.org/wiki/ISO_week_date).
    /// </summary>
    [pbr::OriginalName("FORTNIGHT")] Fortnight = 3,
    /// <summary>
    /// A month.
    /// </summary>
    [pbr::OriginalName("MONTH")] Month = 4,
    /// <summary>
    /// A quarter. Quarters start on dates 1-Jan, 1-Apr, 1-Jul, and 1-Oct of each
    /// year.
    /// </summary>
    [pbr::OriginalName("QUARTER")] Quarter = 5,
    /// <summary>
    /// A half-year. Half-years start on dates 1-Jan and 1-Jul.
    /// </summary>
    [pbr::OriginalName("HALF")] Half = 6,
    /// <summary>
    /// A year.
    /// </summary>
    [pbr::OriginalName("YEAR")] Year = 7,
  }

  #endregion

}

#endregion Designer generated code