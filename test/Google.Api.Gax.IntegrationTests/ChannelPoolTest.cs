﻿/*
 * Copyright 2016 Google Inc. All Rights Reserved.
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */
using Grpc.Core;
using System.Threading.Tasks;
using Xunit;

namespace Google.Api.Gax.IntegrationTests
{
    public class ChannelPoolTest
    {
        [Fact]
        public void SameEndpoint_SameChannel()
        {
            var pool = new ChannelPool();
            using (var fixture = new TestServiceFixture())
            {
                var channel1 = pool.GetChannel(fixture.Endpoint);
                var channel2 = pool.GetChannel(fixture.Endpoint);
                Assert.Same(channel1, channel2);                
            }
        }

        [Fact]
        public void DifferentEndpoint_DifferentChannel()
        {
            var pool = new ChannelPool();
            using (TestServiceFixture fixture1 = new TestServiceFixture(), fixture2 = new TestServiceFixture())
            {
                var channel1 = pool.GetChannel(fixture1.Endpoint);
                var channel2 = pool.GetChannel(fixture2.Endpoint);
                Assert.NotSame(channel1, channel2);
            }
        }

        [Fact]
        public async Task ShutdownAsync_ShutsDownChannel()
        {
            var pool = new ChannelPool();
            using (var fixture = new TestServiceFixture())
            {
                var channel = pool.GetChannel(fixture.Endpoint);
                Assert.NotEqual(ChannelState.FatalFailure, channel.State);
                await pool.ShutdownChannelsAsync();
                // TODO: Assert it's shut down.
                // See https://github.com/grpc/grpc/issues/6426
            }
        }

        [Fact]
        public void ShutdownAsync_EmptiesPool()
        {
            var pool = new ChannelPool();
            using (var fixture = new TestServiceFixture())
            {
                var channel1 = pool.GetChannel(fixture.Endpoint);
                // Note: *not* waiting for this to complete.
                pool.ShutdownChannelsAsync();
                var channel2 = pool.GetChannel(fixture.Endpoint);
                Assert.NotSame(channel1, channel2);
            }
        }
    }
}
