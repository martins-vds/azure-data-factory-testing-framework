// <auto-generated/>

#nullable disable

using Azure.Core;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> A list of exposure control features. </summary>
    public partial class ExposureControlBatchContent
    {
        /// <summary> Initializes a new instance of ExposureControlBatchContent. </summary>
        /// <param name="exposureControlRequests"> List of exposure control features. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="exposureControlRequests"/> is null. </exception>
        public ExposureControlBatchContent(IEnumerable<ExposureControlContent> exposureControlRequests)
        {
            Argument.AssertNotNull(exposureControlRequests, nameof(exposureControlRequests));

            ExposureControlRequests = exposureControlRequests.ToList();
        }

        /// <summary> List of exposure control features. </summary>
        public IList<ExposureControlContent> ExposureControlRequests { get; }
    }
}
