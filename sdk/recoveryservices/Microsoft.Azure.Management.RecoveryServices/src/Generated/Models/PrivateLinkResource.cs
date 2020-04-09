// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Information of the private link resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PrivateLinkResource
    {
        /// <summary>
        /// Initializes a new instance of the PrivateLinkResource class.
        /// </summary>
        public PrivateLinkResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateLinkResource class.
        /// </summary>
        /// <param name="groupId">e.g. f9ad6492-33d4-4690-9999-6bfd52a0d081
        /// (Backup) or f9ad6492-33d4-4690-9999-6bfd52a0d082
        /// (SiteRecovery)</param>
        /// <param name="requiredMembers">[backup-ecs1, backup-prot1,
        /// backup-prot1b, backup-prot1c, backup-id1]</param>
        /// <param name="requiredZoneNames">The private link resource Private
        /// link DNS zone name.</param>
        /// <param name="id">Fully qualified identifier of the
        /// resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">e.g.
        /// Microsoft.RecoveryServices/vaults/privateLinkResources</param>
        public PrivateLinkResource(string groupId = default(string), IList<string> requiredMembers = default(IList<string>), IList<string> requiredZoneNames = default(IList<string>), string id = default(string), string name = default(string), string type = default(string))
        {
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            RequiredZoneNames = requiredZoneNames;
            Id = id;
            Name = name;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets e.g. f9ad6492-33d4-4690-9999-6bfd52a0d081 (Backup) or
        /// f9ad6492-33d4-4690-9999-6bfd52a0d082 (SiteRecovery)
        /// </summary>
        [JsonProperty(PropertyName = "properties.groupId")]
        public string GroupId { get; private set; }

        /// <summary>
        /// Gets [backup-ecs1, backup-prot1, backup-prot1b, backup-prot1c,
        /// backup-id1]
        /// </summary>
        [JsonProperty(PropertyName = "properties.requiredMembers")]
        public IList<string> RequiredMembers { get; private set; }

        /// <summary>
        /// Gets the private link resource Private link DNS zone name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requiredZoneNames")]
        public IList<string> RequiredZoneNames { get; private set; }

        /// <summary>
        /// Gets fully qualified identifier of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets e.g. Microsoft.RecoveryServices/vaults/privateLinkResources
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

    }
}