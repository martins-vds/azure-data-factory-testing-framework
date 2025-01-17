// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using AzureDataFactory.TestingFramework.Models.Activities.Base;
using AzureDataFactory.TestingFramework.Models.Pipelines;

namespace AzureDataFactory.TestingFramework.Models;

public partial class UntilActivity : IIterationActivity
{
    protected override List<PipelineActivity> GetNextActivities()
    {
        return Activities.ToList();
    }
}