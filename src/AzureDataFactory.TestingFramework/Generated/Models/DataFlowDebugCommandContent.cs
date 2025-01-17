// <auto-generated/>

#nullable disable

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Request body structure for data flow debug command. </summary>
    public partial class DataFlowDebugCommandContent
    {
        /// <summary> Initializes a new instance of DataFlowDebugCommandContent. </summary>
        public DataFlowDebugCommandContent()
        {
        }

        /// <summary> The ID of data flow debug session. </summary>
        public Guid? SessionId { get; set; }
        /// <summary> The command type. </summary>
        public DataFlowDebugCommandType? Command { get; set; }
        /// <summary> The command payload object. </summary>
        public DataFlowDebugCommandPayload CommandPayload { get; set; }
    }
}
