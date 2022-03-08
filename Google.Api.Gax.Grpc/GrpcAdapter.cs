﻿/*
 * Copyright 2020 Google LLC
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */

using Grpc.Core;
using Grpc.Net.Client;
using System;
using System.Threading;

namespace Google.Api.Gax.Grpc
{
    /// <summary>
    /// Interoperability layer for the aspects of gRPC that aren't covered by Grpc.Core.Api.
    /// </summary>
    public abstract class GrpcAdapter
    {
        private const string AdapterOverrideEnvironmentVariable = "GRPC_DEFAULT_ADAPTER_OVERRIDE";

        private static readonly Lazy<GrpcAdapter> s_defaultFactory = new Lazy<GrpcAdapter>(CreateDefaultAdapter, LazyThreadSafetyMode.PublicationOnly);

        /// <summary>
        /// Creates a channel for the given endpoint, using the given credentials and options.
        /// </summary>
        /// <param name="endpoint">The endpoint to connect to. Must not be null.</param>
        /// <param name="credentials">The channel credentials to use. Must not be null.</param>
        /// <param name="options">The channel options to use. Must not be null.</param>
        /// <returns>A channel for the specified settings.</returns>
        public ChannelBase CreateChannel(string endpoint, ChannelCredentials credentials, GrpcChannelOptions options)
        {
            GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint));
            GaxPreconditions.CheckNotNull(credentials, nameof(credentials));
            GaxPreconditions.CheckNotNull(options, nameof(options));
            return CreateChannelImpl(endpoint, credentials, options);
        }

        /// <summary>
        /// Creates a channel for the given endpoint, using the given credentials and options. All parameters
        /// are pre-validated to be non-null.
        /// </summary>
        /// <param name="endpoint">The endpoint to connect to. Will not be null.</param>
        /// <param name="credentials">The channel credentials to use. Will not be null.</param>
        /// <param name="options">The channel options to use. Will not be null.</param>
        /// <returns>A channel for the specified settings.</returns>
        protected abstract ChannelBase CreateChannelImpl(string endpoint, ChannelCredentials credentials, GrpcChannelOptions options);

        /// <summary>
        /// Returns the default gRPC adapter based on the available gRPC implementations.
        /// </summary>
        public static GrpcAdapter DefaultAdapter => s_defaultFactory.Value;

        private static GrpcAdapter CreateDefaultAdapter() =>
            GetDefaultFromEnvironmentVariable() ?? DetectDefaultPreferringGrpcNetClient();

        private static GrpcAdapter GetDefaultFromEnvironmentVariable()
        {
            var env = Environment.GetEnvironmentVariable(AdapterOverrideEnvironmentVariable)?.Trim();
            return env switch
            {
                "Grpc.Net.Client" => GrpcNetClientAdapter.Default,
                "Grpc.Core" => GrpcCoreAdapter.Instance,
                null => null,
                "" => null,
                _ => throw new InvalidOperationException($"Unknown value for environment variable '{AdapterOverrideEnvironmentVariable}': '{env}'")
            };
        }

        // TODO: Is this really what we want? Definitely simple, but not great in other ways...
        private static GrpcAdapter DetectDefaultPreferringGrpcNetClient()
        {
            try
            {
                GrpcChannel.ForAddress("https://ignored.com");
                return GrpcNetClientAdapter.Default;
            }
            catch
            {
                return GrpcCoreAdapter.Instance;
            }
        }
    }
}
