// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for InvoiceSectionBillingRoleDefinitionOperations.
    /// </summary>
    public static partial class InvoiceSectionBillingRoleDefinitionOperationsExtensions
    {
            /// <summary>
            /// Gets the role definition for a role
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='billingRoleDefinitionName'>
            /// role definition id.
            /// </param>
            public static BillingRoleDefinition Get(this IInvoiceSectionBillingRoleDefinitionOperations operations, string billingAccountName, string invoiceSectionName, string billingRoleDefinitionName)
            {
                return operations.GetAsync(billingAccountName, invoiceSectionName, billingRoleDefinitionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the role definition for a role
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='billingRoleDefinitionName'>
            /// role definition id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingRoleDefinition> GetAsync(this IInvoiceSectionBillingRoleDefinitionOperations operations, string billingAccountName, string invoiceSectionName, string billingRoleDefinitionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(billingAccountName, invoiceSectionName, billingRoleDefinitionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the role definition for a invoice Section
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            public static BillingRoleDefinitionListResult List(this IInvoiceSectionBillingRoleDefinitionOperations operations, string billingAccountName, string invoiceSectionName)
            {
                return operations.ListAsync(billingAccountName, invoiceSectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the role definition for a invoice Section
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingRoleDefinitionListResult> ListAsync(this IInvoiceSectionBillingRoleDefinitionOperations operations, string billingAccountName, string invoiceSectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(billingAccountName, invoiceSectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}