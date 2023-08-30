// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Azure Function activity. </summary>
    public partial class AzureFunctionActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of AzureFunctionActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="method"> Rest API method for target endpoint. </param>
        /// <param name="functionName"> Name of the Function that the Azure Function Activity will call. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="functionName"/> is null. </exception>
        public AzureFunctionActivity(string name, AzureFunctionActivityMethod method, DataFactoryElement<string> functionName) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(functionName, nameof(functionName));

            Method = method;
            FunctionName = functionName;
            ActivityType = "AzureFunctionActivity";
        }

        /// <summary> Initializes a new instance of AzureFunctionActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="method"> Rest API method for target endpoint. </param>
        /// <param name="functionName"> Name of the Function that the Azure Function Activity will call. Type: string (or Expression with resultType string). </param>
        /// <param name="headers"> Represents the headers that will be sent to the request. For example, to set the language and type on a request: "headers" : { "Accept-Language": "en-us", "Content-Type": "application/json" }. Type: string (or Expression with resultType string). </param>
        /// <param name="body"> Represents the payload that will be sent to the endpoint. Required for POST/PUT method, not allowed for GET method Type: string (or Expression with resultType string). </param>
        internal AzureFunctionActivity(string name, string activityType, string description, PipelineActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<PipelineActivityDependency> dependsOn, IList<PipelineActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, DataFactoryLinkedServiceReference linkedServiceName, PipelineActivityPolicy policy, AzureFunctionActivityMethod method, DataFactoryElement<string> functionName, DataFactoryElement<string> headers, DataFactoryElement<string> body) : base(name, activityType, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            Method = method;
            FunctionName = functionName;
            Headers = headers;
            Body = body;
            ActivityType = activityType ?? "AzureFunctionActivity";
        }

        /// <summary> Rest API method for target endpoint. </summary>
        public AzureFunctionActivityMethod Method { get; set; }
        /// <summary> Name of the Function that the Azure Function Activity will call. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> FunctionName { get; set; }
        /// <summary> Represents the headers that will be sent to the request. For example, to set the language and type on a request: "headers" : { "Accept-Language": "en-us", "Content-Type": "application/json" }. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Headers { get; set; }
        /// <summary> Represents the payload that will be sent to the endpoint. Required for POST/PUT method, not allowed for GET method Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Body { get; set; }
    }
}
