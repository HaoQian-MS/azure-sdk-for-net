// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Azure;
    using Management;
    using Compute;
    using Fluent;
    using Rest;
    using Rest.Azure;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes an Image.
    /// </summary>
    [JsonTransformation]
    public partial class ImageInner : Microsoft.Azure.Management.Resource.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the ImageInner class.
        /// </summary>
        public ImageInner() { }

        /// <summary>
        /// Initializes a new instance of the ImageInner class.
        /// </summary>
        /// <param name="sourceVirtualMachine">The source virtual machine from
        /// which Image is created.</param>
        /// <param name="storageProfile">The storage profile.</param>
        /// <param name="provisioningState">The provisioning state.</param>
        public ImageInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Microsoft.Azure.Management.Resource.Fluent.SubResource sourceVirtualMachine = default(Microsoft.Azure.Management.Resource.Fluent.SubResource), ImageStorageProfile storageProfile = default(ImageStorageProfile), string provisioningState = default(string))
            : base(location, id, name, type, tags)
        {
            SourceVirtualMachine = sourceVirtualMachine;
            StorageProfile = storageProfile;
            ProvisioningState = provisioningState;
        }

        /// <summary>
        /// Gets or sets the source virtual machine from which Image is
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceVirtualMachine")]
        public Microsoft.Azure.Management.Resource.Fluent.SubResource SourceVirtualMachine { get; set; }

        /// <summary>
        /// Gets or sets the storage profile.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageProfile")]
        public ImageStorageProfile StorageProfile { get; set; }

        /// <summary>
        /// Gets the provisioning state.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; protected set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StorageProfile != null)
            {
                StorageProfile.Validate();
            }
        }
    }
}
