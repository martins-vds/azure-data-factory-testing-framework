// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace AzureDataFactory.TestingFramework.Exceptions;

public class ExpectedActivityTypePropertyNotFound : Exception
{
    public ExpectedActivityTypePropertyNotFound(string activityType, string propertyName) : base($"Activity type '{activityType}' does not have a typed property named '{propertyName}'")
    {
    }
}