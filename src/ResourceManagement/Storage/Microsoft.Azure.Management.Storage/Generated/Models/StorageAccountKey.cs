// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Storage.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// An access key for the storage account.
    /// </summary>
    public partial class StorageAccountKey
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccountKey class.
        /// </summary>
        public StorageAccountKey() { }

        /// <summary>
        /// Initializes a new instance of the StorageAccountKey class.
        /// </summary>
        public StorageAccountKey(string keyName = default(string), string value = default(string), KeyPermission? permissions = default(KeyPermission?))
        {
            KeyName = keyName;
            Value = value;
            Permissions = permissions;
        }

        /// <summary>
        /// Name of the key.
        /// </summary>
        [JsonProperty(PropertyName = "keyName")]
        public string KeyName { get; private set; }

        /// <summary>
        /// Base 64 encoded value of the key.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; private set; }

        /// <summary>
        /// Permissions for the key. Possible values include: 'READ', 'FULL'
        /// </summary>
        [JsonProperty(PropertyName = "permissions")]
        public KeyPermission? Permissions { get; private set; }

    }
}
