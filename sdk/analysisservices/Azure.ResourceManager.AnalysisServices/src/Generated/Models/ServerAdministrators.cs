// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AnalysisServices.Models
{
    /// <summary> An array of administrator user identities. </summary>
    internal partial class ServerAdministrators
    {
        /// <summary> Initializes a new instance of ServerAdministrators. </summary>
        public ServerAdministrators()
        {
            AsAdministratorIdentities = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ServerAdministrators. </summary>
        /// <param name="asAdministratorIdentities"> An array of administrator user identities. </param>
        internal ServerAdministrators(IList<string> asAdministratorIdentities)
        {
            AsAdministratorIdentities = asAdministratorIdentities;
        }

        /// <summary> An array of administrator user identities. </summary>
        public IList<string> AsAdministratorIdentities { get; }
    }
}
