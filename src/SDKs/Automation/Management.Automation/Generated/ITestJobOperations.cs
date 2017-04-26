// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation
{
    /// <summary>
    /// Service operation for automation test jobs.  (see
    /// http://aka.ms/azureautomationsdk/testjoboperations for more
    /// information)
    /// </summary>
    public partial interface ITestJobOperations
    {
        /// <summary>
        /// Create a test job of the runbook.  (see
        /// http://aka.ms/azureautomationsdk/testjoboperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// The parameters supplied to the create test job operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the create test job operation.
        /// </returns>
        Task<TestJobCreateResponse> CreateAsync(string resourceGroupName, string automationAccount, TestJobCreateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieve the test job for the specified runbook.  (see
        /// http://aka.ms/azureautomationsdk/testjoboperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// The runbook name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the get test job operation.
        /// </returns>
        Task<TestJobGetResponse> GetAsync(string resourceGroupName, string automationAccount, string runbookName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Resume the test job.  (see
        /// http://aka.ms/azureautomationsdk/testjoboperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// The runbook name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> ResumeAsync(string resourceGroupName, string automationAccount, string runbookName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Stop the test job.  (see
        /// http://aka.ms/azureautomationsdk/testjoboperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// The runbook name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> StopAsync(string resourceGroupName, string automationAccount, string runbookName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Suspend the test job.  (see
        /// http://aka.ms/azureautomationsdk/testjoboperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// The runbook name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> SuspendAsync(string resourceGroupName, string automationAccount, string runbookName, CancellationToken cancellationToken);
    }
}