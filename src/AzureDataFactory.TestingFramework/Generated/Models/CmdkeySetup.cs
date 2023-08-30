// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The custom setup of running cmdkey commands. </summary>
    public partial class CmdkeySetup : CustomSetupBase
    {
        /// <summary> Initializes a new instance of CmdkeySetup. </summary>
        /// <param name="targetName"> The server name of data source access. </param>
        /// <param name="userName"> The user name of data source access. </param>
        /// <param name="password"> The password of data source access. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetName"/>, <paramref name="userName"/> or <paramref name="password"/> is null. </exception>
        public CmdkeySetup(BinaryData targetName, BinaryData userName, DataFactorySecretBaseDefinition password)
        {
            Argument.AssertNotNull(targetName, nameof(targetName));
            Argument.AssertNotNull(userName, nameof(userName));
            Argument.AssertNotNull(password, nameof(password));

            TargetName = targetName;
            UserName = userName;
            Password = password;
            CustomSetupBaseType = "CmdkeySetup";
        }

        /// <summary> Initializes a new instance of CmdkeySetup. </summary>
        /// <param name="customSetupBaseType"> The type of custom setup. </param>
        /// <param name="targetName"> The server name of data source access. </param>
        /// <param name="userName"> The user name of data source access. </param>
        /// <param name="password"> The password of data source access. </param>
        internal CmdkeySetup(string customSetupBaseType, BinaryData targetName, BinaryData userName, DataFactorySecretBaseDefinition password) : base(customSetupBaseType)
        {
            TargetName = targetName;
            UserName = userName;
            Password = password;
            CustomSetupBaseType = customSetupBaseType ?? "CmdkeySetup";
        }

        /// <summary>
        /// The server name of data source access.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData TargetName { get; set; }
        /// <summary>
        /// The user name of data source access.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData UserName { get; set; }
        /// <summary> The password of data source access. </summary>
        public DataFactorySecretBaseDefinition Password { get; set; }
    }
}
