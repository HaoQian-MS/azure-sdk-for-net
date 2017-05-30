// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Properties of an artifact deployment.
    /// </summary>
    public partial class ArtifactDeploymentStatusPropertiesFragment
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ArtifactDeploymentStatusPropertiesFragment class.
        /// </summary>
        public ArtifactDeploymentStatusPropertiesFragment() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ArtifactDeploymentStatusPropertiesFragment class.
        /// </summary>
        public ArtifactDeploymentStatusPropertiesFragment(string deploymentStatus = default(string), int? artifactsApplied = default(int?), int? totalArtifacts = default(int?))
        {
            DeploymentStatus = deploymentStatus;
            ArtifactsApplied = artifactsApplied;
            TotalArtifacts = totalArtifacts;
        }

        /// <summary>
        /// The deployment status of the artifact.
        /// </summary>
        [JsonProperty(PropertyName = "deploymentStatus")]
        public string DeploymentStatus { get; set; }

        /// <summary>
        /// The total count of the artifacts that were successfully applied.
        /// </summary>
        [JsonProperty(PropertyName = "artifactsApplied")]
        public int? ArtifactsApplied { get; set; }

        /// <summary>
        /// The total count of the artifacts that were tentatively applied.
        /// </summary>
        [JsonProperty(PropertyName = "totalArtifacts")]
        public int? TotalArtifacts { get; set; }

    }
}