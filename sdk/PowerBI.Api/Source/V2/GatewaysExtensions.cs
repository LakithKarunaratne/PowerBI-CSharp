// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.V2
{
    using Microsoft.PowerBI;
    using Microsoft.PowerBI.Api;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Gateways.
    /// </summary>
    public static partial class GatewaysExtensions
    {
            /// <summary>
            /// Returns a list of gateways
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static ODataResponseListGateway GetGateways(this IGateways operations)
            {
                return operations.GetGatewaysAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of gateways
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListGateway> GetGatewaysAsync(this IGateways operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetGatewaysWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the specified gateway
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway id
            /// </param>
            public static Gateway GetGatewayById(this IGateways operations, string gatewayId)
            {
                return operations.GetGatewayByIdAsync(gatewayId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the specified gateway
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Gateway> GetGatewayByIdAsync(this IGateways operations, string gatewayId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetGatewayByIdWithHttpMessagesAsync(gatewayId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all datasources of specific gateway
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway id
            /// </param>
            public static ODataResponseListGatewayDatasource GetDatasources(this IGateways operations, string gatewayId)
            {
                return operations.GetDatasourcesAsync(gatewayId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all datasources of specific gateway
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListGatewayDatasource> GetDatasourcesAsync(this IGateways operations, string gatewayId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDatasourcesWithHttpMessagesAsync(gatewayId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a datasource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway id
            /// </param>
            /// <param name='datasourceToGatewayRequest'>
            /// The datasource requested to create
            /// </param>
            public static GatewayDatasource CreateDatasource(this IGateways operations, string gatewayId, PublishDatasourceToGatewayRequest datasourceToGatewayRequest)
            {
                return operations.CreateDatasourceAsync(gatewayId, datasourceToGatewayRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a datasource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway id
            /// </param>
            /// <param name='datasourceToGatewayRequest'>
            /// The datasource requested to create
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GatewayDatasource> CreateDatasourceAsync(this IGateways operations, string gatewayId, PublishDatasourceToGatewayRequest datasourceToGatewayRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateDatasourceWithHttpMessagesAsync(gatewayId, datasourceToGatewayRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a datasource by id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway id
            /// </param>
            /// <param name='datasourceId'>
            /// The datasource id
            /// </param>
            public static GatewayDatasource GetDatasourceById(this IGateways operations, string gatewayId, string datasourceId)
            {
                return operations.GetDatasourceByIdAsync(gatewayId, datasourceId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a datasource by id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway id
            /// </param>
            /// <param name='datasourceId'>
            /// The datasource id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GatewayDatasource> GetDatasourceByIdAsync(this IGateways operations, string gatewayId, string datasourceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDatasourceByIdWithHttpMessagesAsync(gatewayId, datasourceId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a datasource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway id
            /// </param>
            /// <param name='datasourceId'>
            /// The datasource id
            /// </param>
            public static object DeleteDatasource(this IGateways operations, string gatewayId, string datasourceId)
            {
                return operations.DeleteDatasourceAsync(gatewayId, datasourceId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a datasource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway id
            /// </param>
            /// <param name='datasourceId'>
            /// The datasource id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> DeleteDatasourceAsync(this IGateways operations, string gatewayId, string datasourceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteDatasourceWithHttpMessagesAsync(gatewayId, datasourceId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a datasource credentials
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway id
            /// </param>
            /// <param name='datasourceId'>
            /// The datasource id
            /// </param>
            /// <param name='updateDatasourceRequest'>
            /// The update datasource request
            /// </param>
            public static object UpdateDatasource(this IGateways operations, string gatewayId, string datasourceId, UpdateDatasourceRequest updateDatasourceRequest)
            {
                return operations.UpdateDatasourceAsync(gatewayId, datasourceId, updateDatasourceRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a datasource credentials
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway id
            /// </param>
            /// <param name='datasourceId'>
            /// The datasource id
            /// </param>
            /// <param name='updateDatasourceRequest'>
            /// The update datasource request
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> UpdateDatasourceAsync(this IGateways operations, string gatewayId, string datasourceId, UpdateDatasourceRequest updateDatasourceRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateDatasourceWithHttpMessagesAsync(gatewayId, datasourceId, updateDatasourceRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a datasource status by id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway id
            /// </param>
            /// <param name='datasourceId'>
            /// The datasource id
            /// </param>
            public static object GetDatasourceStatusById(this IGateways operations, string gatewayId, string datasourceId)
            {
                return operations.GetDatasourceStatusByIdAsync(gatewayId, datasourceId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a datasource status by id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway id
            /// </param>
            /// <param name='datasourceId'>
            /// The datasource id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetDatasourceStatusByIdAsync(this IGateways operations, string gatewayId, string datasourceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDatasourceStatusByIdWithHttpMessagesAsync(gatewayId, datasourceId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a datasource users list
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway id
            /// </param>
            /// <param name='datasourceId'>
            /// The datasource id
            /// </param>
            public static ODataResponseListUserAccessRight GetDatasourceUsers(this IGateways operations, string gatewayId, string datasourceId)
            {
                return operations.GetDatasourceUsersAsync(gatewayId, datasourceId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a datasource users list
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway id
            /// </param>
            /// <param name='datasourceId'>
            /// The datasource id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListUserAccessRight> GetDatasourceUsersAsync(this IGateways operations, string gatewayId, string datasourceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDatasourceUsersWithHttpMessagesAsync(gatewayId, datasourceId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a datasource user
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway id
            /// </param>
            /// <param name='datasourceId'>
            /// The datasource id
            /// </param>
            /// <param name='addUserToDatasourceRequest'>
            /// The add user to datasource request
            /// </param>
            public static object AddDatasourceUser(this IGateways operations, string gatewayId, string datasourceId, UserAccessRight addUserToDatasourceRequest)
            {
                return operations.AddDatasourceUserAsync(gatewayId, datasourceId, addUserToDatasourceRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a datasource user
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway id
            /// </param>
            /// <param name='datasourceId'>
            /// The datasource id
            /// </param>
            /// <param name='addUserToDatasourceRequest'>
            /// The add user to datasource request
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> AddDatasourceUserAsync(this IGateways operations, string gatewayId, string datasourceId, UserAccessRight addUserToDatasourceRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddDatasourceUserWithHttpMessagesAsync(gatewayId, datasourceId, addUserToDatasourceRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a datasource user
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway id
            /// </param>
            /// <param name='datasourceId'>
            /// The datasource id
            /// </param>
            /// <param name='emailAdress'>
            /// The user's email address
            /// </param>
            public static object DeleteDatasourceUser(this IGateways operations, string gatewayId, string datasourceId, string emailAdress)
            {
                return operations.DeleteDatasourceUserAsync(gatewayId, datasourceId, emailAdress).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a datasource user
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gatewayId'>
            /// The gateway id
            /// </param>
            /// <param name='datasourceId'>
            /// The datasource id
            /// </param>
            /// <param name='emailAdress'>
            /// The user's email address
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> DeleteDatasourceUserAsync(this IGateways operations, string gatewayId, string datasourceId, string emailAdress, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteDatasourceUserWithHttpMessagesAsync(gatewayId, datasourceId, emailAdress, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
