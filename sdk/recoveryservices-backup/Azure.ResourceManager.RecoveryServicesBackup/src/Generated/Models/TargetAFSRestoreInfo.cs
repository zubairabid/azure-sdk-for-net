// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Target Azure File Share Info. </summary>
    public partial class TargetAFSRestoreInfo
    {
        /// <summary> Initializes a new instance of TargetAFSRestoreInfo. </summary>
        public TargetAFSRestoreInfo()
        {
        }

        /// <summary> Initializes a new instance of TargetAFSRestoreInfo. </summary>
        /// <param name="name"> File share name. </param>
        /// <param name="targetResourceId"> Target file share resource ARM ID. </param>
        internal TargetAFSRestoreInfo(string name, string targetResourceId)
        {
            Name = name;
            TargetResourceId = targetResourceId;
        }

        /// <summary> File share name. </summary>
        public string Name { get; set; }
        /// <summary> Target file share resource ARM ID. </summary>
        public string TargetResourceId { get; set; }
    }
}
