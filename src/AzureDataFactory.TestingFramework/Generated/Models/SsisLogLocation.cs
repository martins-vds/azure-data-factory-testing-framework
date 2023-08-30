// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> SSIS package execution log location. </summary>
    public partial class SsisLogLocation
    {
        /// <summary> Initializes a new instance of SsisLogLocation. </summary>
        /// <param name="logPath"> The SSIS package execution log path. Type: string (or Expression with resultType string). </param>
        /// <param name="locationType"> The type of SSIS log location. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="logPath"/> is null. </exception>
        public SsisLogLocation(DataFactoryElement<string> logPath, SsisLogLocationType locationType)
        {
            Argument.AssertNotNull(logPath, nameof(logPath));

            LogPath = logPath;
            LocationType = locationType;
        }

        /// <summary> Initializes a new instance of SsisLogLocation. </summary>
        /// <param name="logPath"> The SSIS package execution log path. Type: string (or Expression with resultType string). </param>
        /// <param name="locationType"> The type of SSIS log location. </param>
        /// <param name="accessCredential"> The package execution log access credential. </param>
        /// <param name="logRefreshInterval"> Specifies the interval to refresh log. The default interval is 5 minutes. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        internal SsisLogLocation(DataFactoryElement<string> logPath, SsisLogLocationType locationType, SsisAccessCredential accessCredential, DataFactoryElement<string> logRefreshInterval)
        {
            LogPath = logPath;
            LocationType = locationType;
            AccessCredential = accessCredential;
            LogRefreshInterval = logRefreshInterval;
        }

        /// <summary> The SSIS package execution log path. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> LogPath { get; set; }
        /// <summary> The type of SSIS log location. </summary>
        public SsisLogLocationType LocationType { get; set; }
        /// <summary> The package execution log access credential. </summary>
        public SsisAccessCredential AccessCredential { get; set; }
        /// <summary> Specifies the interval to refresh log. The default interval is 5 minutes. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </summary>
        public DataFactoryElement<string> LogRefreshInterval { get; set; }
    }
}
