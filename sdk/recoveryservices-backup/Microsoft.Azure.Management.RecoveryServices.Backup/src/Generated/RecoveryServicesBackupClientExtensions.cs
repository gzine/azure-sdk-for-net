// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RecoveryServicesBackupClient.
    /// </summary>
    public static partial class RecoveryServicesBackupClientExtensions
    {
            /// <summary>
            /// Gets the operation status for a private endpoint connection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            /// <param name='operationId'>
            /// Operation id
            /// </param>
            public static OperationStatus GetOperationStatus(this IRecoveryServicesBackupClient operations, string vaultName, string resourceGroupName, string privateEndpointConnectionName, string operationId)
            {
                return operations.GetOperationStatusAsync(vaultName, resourceGroupName, privateEndpointConnectionName, operationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the operation status for a private endpoint connection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            /// <param name='operationId'>
            /// Operation id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatus> GetOperationStatusAsync(this IRecoveryServicesBackupClient operations, string vaultName, string resourceGroupName, string privateEndpointConnectionName, string operationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetOperationStatusWithHttpMessagesAsync(vaultName, resourceGroupName, privateEndpointConnectionName, operationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
