// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Ssis project. </summary>
    public partial class SsisProject : SsisObjectMetadata
    {
        /// <summary> Initializes a new instance of SsisProject. </summary>
        internal SsisProject()
        {
            EnvironmentRefs = new ChangeTrackingList<SsisEnvironmentReference>();
            Parameters = new ChangeTrackingList<SsisParameterInfo>();
            MetadataType = SsisObjectMetadataType.Project;
        }

        /// <summary> Initializes a new instance of SsisProject. </summary>
        /// <param name="metadataType"> Type of metadata. </param>
        /// <param name="id"> Metadata id. </param>
        /// <param name="name"> Metadata name. </param>
        /// <param name="description"> Metadata description. </param>
        /// <param name="folderId"> Folder id which contains project. </param>
        /// <param name="version"> Project version. </param>
        /// <param name="environmentRefs"> Environment reference in project. </param>
        /// <param name="parameters"> Parameters in project. </param>
        internal SsisProject(SsisObjectMetadataType metadataType, long? id, string name, string description, long? folderId, long? version, IReadOnlyList<SsisEnvironmentReference> environmentRefs, IReadOnlyList<SsisParameterInfo> parameters) : base(metadataType, id, name, description)
        {
            FolderId = folderId;
            Version = version;
            EnvironmentRefs = environmentRefs;
            Parameters = parameters;
            MetadataType = metadataType;
        }

        /// <summary> Folder id which contains project. </summary>
        public long? FolderId { get; }
        /// <summary> Project version. </summary>
        public long? Version { get; }
        /// <summary> Environment reference in project. </summary>
        public IReadOnlyList<SsisEnvironmentReference> EnvironmentRefs { get; }
        /// <summary> Parameters in project. </summary>
        public IReadOnlyList<SsisParameterInfo> Parameters { get; }
    }
}
