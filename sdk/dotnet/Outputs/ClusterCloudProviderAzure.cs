// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Outputs
{

    [OutputType]
    public sealed class ClusterCloudProviderAzure
    {
        public readonly string? AdminUser;
        public readonly string? ResourceGroupName;
        public readonly string? RouteTableName;
        public readonly string? SubscriptionId;
        public readonly string? TenantId;

        [OutputConstructor]
        private ClusterCloudProviderAzure(
            string? adminUser,

            string? resourceGroupName,

            string? routeTableName,

            string? subscriptionId,

            string? tenantId)
        {
            AdminUser = adminUser;
            ResourceGroupName = resourceGroupName;
            RouteTableName = routeTableName;
            SubscriptionId = subscriptionId;
            TenantId = tenantId;
        }
    }
}
