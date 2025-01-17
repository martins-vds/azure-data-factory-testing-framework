// <auto-generated/>

#nullable disable

using Azure.Core;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Factory's git repo information. </summary>
    public partial class FactoryRepoContent
    {
        /// <summary> Initializes a new instance of FactoryRepoContent. </summary>
        public FactoryRepoContent()
        {
        }

        /// <summary> The factory resource id. </summary>
        public ResourceIdentifier FactoryResourceId { get; set; }
        /// <summary>
        /// Git repo information of the factory.
        /// Please note <see cref="FactoryRepoConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FactoryGitHubConfiguration"/> and <see cref="FactoryVstsConfiguration"/>.
        /// </summary>
        public FactoryRepoConfiguration RepoConfiguration { get; set; }
    }
}
