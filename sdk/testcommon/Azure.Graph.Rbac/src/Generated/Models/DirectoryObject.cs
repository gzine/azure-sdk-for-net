// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    /// <summary> Represents an Azure Active Directory object. </summary>
    public partial class DirectoryObject : IReadOnlyDictionary<string, object>
    {
        /// <summary> Initializes a new instance of DirectoryObject. </summary>
        internal DirectoryObject()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
            ObjectType = "DirectoryObject";
        }

        /// <summary> Initializes a new instance of DirectoryObject. </summary>
        /// <param name="objectId"> The object ID. </param>
        /// <param name="objectType"> The object type. </param>
        /// <param name="deletionTimestamp"> The time at which the directory object was deleted. </param>
        /// <param name="additionalProperties"> . </param>
        internal DirectoryObject(string objectId, string objectType, DateTimeOffset? deletionTimestamp, IReadOnlyDictionary<string, object> additionalProperties)
        {
            ObjectId = objectId;
            ObjectType = objectType ?? "DirectoryObject";
            DeletionTimestamp = deletionTimestamp;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The object ID. </summary>
        public string ObjectId { get; }
        /// <summary> The object type. </summary>
        internal string ObjectType { get; set; }
        /// <summary> The time at which the directory object was deleted. </summary>
        public DateTimeOffset? DeletionTimestamp { get; }
        internal IReadOnlyDictionary<string, object> AdditionalProperties { get; }
        /// <inheritdoc />
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        public bool TryGetValue(string key, out object value) => AdditionalProperties.TryGetValue(key, out value);
        /// <inheritdoc />
        public bool ContainsKey(string key) => AdditionalProperties.ContainsKey(key);
        /// <inheritdoc />
        public IEnumerable<string> Keys => AdditionalProperties.Keys;
        /// <inheritdoc />
        public IEnumerable<object> Values => AdditionalProperties.Values;
        /// <inheritdoc />
        int IReadOnlyCollection<KeyValuePair<string, object>>.Count => AdditionalProperties.Count;
        /// <inheritdoc />
        public object this[string key]
        {
            get => AdditionalProperties[key];
        }
    }
}
