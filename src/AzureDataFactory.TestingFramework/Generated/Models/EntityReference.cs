// <auto-generated/>

#nullable disable

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The entity reference. </summary>
    public partial class EntityReference
    {
        /// <summary> Initializes a new instance of EntityReference. </summary>
        public EntityReference()
        {
        }

        /// <summary> Initializes a new instance of EntityReference. </summary>
        /// <param name="integrationRuntimeEntityReferenceType"> The type of this referenced entity. </param>
        /// <param name="referenceName"> The name of this referenced entity. </param>
        internal EntityReference(IntegrationRuntimeEntityReferenceType? integrationRuntimeEntityReferenceType, string referenceName)
        {
            IntegrationRuntimeEntityReferenceType = integrationRuntimeEntityReferenceType;
            ReferenceName = referenceName;
        }

        /// <summary> The type of this referenced entity. </summary>
        public IntegrationRuntimeEntityReferenceType? IntegrationRuntimeEntityReferenceType { get; set; }
        /// <summary> The name of this referenced entity. </summary>
        public string ReferenceName { get; set; }
    }
}
