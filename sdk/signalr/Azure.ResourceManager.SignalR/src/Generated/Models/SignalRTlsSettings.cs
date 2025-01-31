// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary> TLS settings for the resource. </summary>
    internal partial class SignalRTlsSettings
    {
        /// <summary> Initializes a new instance of SignalRTlsSettings. </summary>
        public SignalRTlsSettings()
        {
        }

        /// <summary> Initializes a new instance of SignalRTlsSettings. </summary>
        /// <param name="clientCertEnabled"> Request client certificate during TLS handshake if enabled. </param>
        internal SignalRTlsSettings(bool? clientCertEnabled)
        {
            ClientCertEnabled = clientCertEnabled;
        }

        /// <summary> Request client certificate during TLS handshake if enabled. </summary>
        public bool? ClientCertEnabled { get; set; }
    }
}
