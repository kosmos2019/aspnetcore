// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Buffers;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Internal;
using Microsoft.AspNetCore.SignalR.Protocol;

namespace Microsoft.AspNetCore.Components.Server.BlazorPack
{
    /// <summary>
    /// Implements the SignalR Hub Protocol using MessagePack with limited type support.
    /// </summary>
    [NonDefaultHubProtocol]
    internal sealed class BlazorPackHubProtocol : IHubProtocol
    {
        internal const string ProtocolName = "blazorpack";
        private static readonly int ProtocolVersion = 1;

        private readonly BlazorPackHubProtocolWorker _worker = new BlazorPackHubProtocolWorker();

        /// <inheritdoc />
        public string Name => ProtocolName;

        /// <inheritdoc />
        public int Version => ProtocolVersion;

        /// <inheritdoc />
        public TransferFormat TransferFormat => TransferFormat.Binary;

        /// <inheritdoc />
        public bool IsVersionSupported(int version)
        {
            return version == Version;
        }

        /// <inheritdoc />
        public bool TryParseMessage(ref ReadOnlySequence<byte> input, IInvocationBinder binder, out HubMessage message)
            => _worker.TryParseMessage(ref input, binder, out message);

        /// <inheritdoc />
        public void WriteMessage(HubMessage message, IBufferWriter<byte> output)
            => _worker.WriteMessage(message, output);

        ///// <inheritdoc />
        public ReadOnlyMemory<byte> GetMessageBytes(HubMessage message)
            => _worker.GetMessageBytes(message);
    }
}
