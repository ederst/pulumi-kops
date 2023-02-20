// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterCloudProviderAzureArgs : global::Pulumi.ResourceArgs
    {
        [Input("adminUser")]
        public Input<string>? AdminUser { get; set; }

        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        [Input("routeTableName")]
        public Input<string>? RouteTableName { get; set; }

        [Input("subscriptionId")]
        public Input<string>? SubscriptionId { get; set; }

        [Input("tenantId")]
        public Input<string>? TenantId { get; set; }

        public ClusterCloudProviderAzureArgs()
        {
        }
        public static new ClusterCloudProviderAzureArgs Empty => new ClusterCloudProviderAzureArgs();
    }
}
