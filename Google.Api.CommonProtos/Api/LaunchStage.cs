/*
 * Copyright 2020 Google LLC All Rights Reserved.
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/api/launch_stage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Api {

  /// <summary>Holder for reflection information generated from google/api/launch_stage.proto</summary>
  public static partial class LaunchStageReflection {

    #region Descriptor
    /// <summary>File descriptor for google/api/launch_stage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LaunchStageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1nb29nbGUvYXBpL2xhdW5jaF9zdGFnZS5wcm90bxIKZ29vZ2xlLmFwaSpq",
            "CgtMYXVuY2hTdGFnZRIcChhMQVVOQ0hfU1RBR0VfVU5TUEVDSUZJRUQQABIQ",
            "CgxFQVJMWV9BQ0NFU1MQARIJCgVBTFBIQRACEggKBEJFVEEQAxIGCgJHQRAE",
            "Eg4KCkRFUFJFQ0FURUQQBUJaCg5jb20uZ29vZ2xlLmFwaUIQTGF1bmNoU3Rh",
            "Z2VQcm90b1ABWi1nb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVh",
            "cGlzL2FwaTthcGmiAgRHQVBJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Api.LaunchStage), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// The launch stage as defined by [Google Cloud Platform
  /// Launch Stages](http://cloud.google.com/terms/launch-stages).
  /// </summary>
  public enum LaunchStage {
    /// <summary>
    /// Do not use this default value.
    /// </summary>
    [pbr::OriginalName("LAUNCH_STAGE_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// Early Access features are limited to a closed group of testers. To use
    /// these features, you must sign up in advance and sign a Trusted Tester
    /// agreement (which includes confidentiality provisions). These features may
    /// be unstable, changed in backward-incompatible ways, and are not
    /// guaranteed to be released.
    /// </summary>
    [pbr::OriginalName("EARLY_ACCESS")] EarlyAccess = 1,
    /// <summary>
    /// Alpha is a limited availability test for releases before they are cleared
    /// for widespread use. By Alpha, all significant design issues are resolved
    /// and we are in the process of verifying functionality. Alpha customers
    /// need to apply for access, agree to applicable terms, and have their
    /// projects whitelisted. Alpha releases don’t have to be feature complete,
    /// no SLAs are provided, and there are no technical support obligations, but
    /// they will be far enough along that customers can actually use them in
    /// test environments or for limited-use tests -- just like they would in
    /// normal production cases.
    /// </summary>
    [pbr::OriginalName("ALPHA")] Alpha = 2,
    /// <summary>
    /// Beta is the point at which we are ready to open a release for any
    /// customer to use. There are no SLA or technical support obligations in a
    /// Beta release. Products will be complete from a feature perspective, but
    /// may have some open outstanding issues. Beta releases are suitable for
    /// limited production use cases.
    /// </summary>
    [pbr::OriginalName("BETA")] Beta = 3,
    /// <summary>
    /// GA features are open to all developers and are considered stable and
    /// fully qualified for production use.
    /// </summary>
    [pbr::OriginalName("GA")] Ga = 4,
    /// <summary>
    /// Deprecated features are scheduled to be shut down and removed. For more
    /// information, see the “Deprecation Policy” section of our [Terms of
    /// Service](https://cloud.google.com/terms/)
    /// and the [Google Cloud Platform Subject to the Deprecation
    /// Policy](https://cloud.google.com/terms/deprecation) documentation.
    /// </summary>
    [pbr::OriginalName("DEPRECATED")] Deprecated = 5,
  }

  #endregion

}

#endregion Designer generated code
