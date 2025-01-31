// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The StreamingEndpointSkuInfo. </summary>
    public partial class StreamingEndpointSkuInfo
    {
        /// <summary> Initializes a new instance of StreamingEndpointSkuInfo. </summary>
        internal StreamingEndpointSkuInfo()
        {
        }

        /// <summary> Initializes a new instance of StreamingEndpointSkuInfo. </summary>
        /// <param name="resourceType"></param>
        /// <param name="capacity"> The streaming endpoint sku capacity. </param>
        /// <param name="sku"> The streaming endpoint sku. </param>
        internal StreamingEndpointSkuInfo(ResourceType? resourceType, StreamingEndpointCapacity capacity, StreamingEndpointSku sku)
        {
            ResourceType = resourceType;
            Capacity = capacity;
            Sku = sku;
        }

        /// <summary> Gets the resource type. </summary>
        public ResourceType? ResourceType { get; }
        /// <summary> The streaming endpoint sku capacity. </summary>
        public StreamingEndpointCapacity Capacity { get; }
        /// <summary> The streaming endpoint sku. </summary>
        internal StreamingEndpointSku Sku { get; }
        /// <summary> The streaming endpoint sku name. </summary>
        public string SkuName
        {
            get => Sku?.Name;
        }
    }
}
