// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents a dns entity. </summary>
    public partial class DnsEntity : EntityData
    {
        /// <summary> Initializes a new instance of DnsEntity. </summary>
        public DnsEntity()
        {
            AdditionalData = new ChangeTrackingDictionary<string, BinaryData>();
            IPAddressEntityIds = new ChangeTrackingList<string>();
            Kind = EntityKind.DnsResolution;
        }

        /// <summary> Initializes a new instance of DnsEntity. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the entity. </param>
        /// <param name="additionalData"> A bag of custom fields that should be part of the entity and will be presented to the user. </param>
        /// <param name="friendlyName"> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </param>
        /// <param name="dnsServerIPEntityId"> An ip entity id for the dns server resolving the request. </param>
        /// <param name="domainName"> The name of the dns record associated with the alert. </param>
        /// <param name="hostIPAddressEntityId"> An ip entity id for the dns request client. </param>
        /// <param name="ipAddressEntityIds"> Ip entity identifiers for the resolved ip address. </param>
        internal DnsEntity(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, EntityKind kind, IReadOnlyDictionary<string, BinaryData> additionalData, string friendlyName, string dnsServerIPEntityId, string domainName, string hostIPAddressEntityId, IReadOnlyList<string> ipAddressEntityIds) : base(id, name, resourceType, systemData, kind)
        {
            AdditionalData = additionalData;
            FriendlyName = friendlyName;
            DnsServerIPEntityId = dnsServerIPEntityId;
            DomainName = domainName;
            HostIPAddressEntityId = hostIPAddressEntityId;
            IPAddressEntityIds = ipAddressEntityIds;
            Kind = kind;
        }

        /// <summary> A bag of custom fields that should be part of the entity and will be presented to the user. </summary>
        public IReadOnlyDictionary<string, BinaryData> AdditionalData { get; }
        /// <summary> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </summary>
        public string FriendlyName { get; }
        /// <summary> An ip entity id for the dns server resolving the request. </summary>
        public string DnsServerIPEntityId { get; }
        /// <summary> The name of the dns record associated with the alert. </summary>
        public string DomainName { get; }
        /// <summary> An ip entity id for the dns request client. </summary>
        public string HostIPAddressEntityId { get; }
        /// <summary> Ip entity identifiers for the resolved ip address. </summary>
        public IReadOnlyList<string> IPAddressEntityIds { get; }
    }
}
