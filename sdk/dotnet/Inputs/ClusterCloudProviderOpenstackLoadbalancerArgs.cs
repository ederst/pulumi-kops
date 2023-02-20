// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterCloudProviderOpenstackLoadbalancerArgs : global::Pulumi.ResourceArgs
    {
        [Input("enableIngressHostname")]
        public Input<bool>? EnableIngressHostname { get; set; }

        [Input("floatingNetwork")]
        public Input<string>? FloatingNetwork { get; set; }

        [Input("floatingNetworkId")]
        public Input<string>? FloatingNetworkId { get; set; }

        [Input("floatingSubnet")]
        public Input<string>? FloatingSubnet { get; set; }

        [Input("ingressHostnameSuffix")]
        public Input<string>? IngressHostnameSuffix { get; set; }

        [Input("manageSecGroups")]
        public Input<bool>? ManageSecGroups { get; set; }

        [Input("method")]
        public Input<string>? Method { get; set; }

        [Input("provider")]
        public Input<string>? Provider { get; set; }

        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        [Input("useOctavia")]
        public Input<bool>? UseOctavia { get; set; }

        public ClusterCloudProviderOpenstackLoadbalancerArgs()
        {
        }
        public static new ClusterCloudProviderOpenstackLoadbalancerArgs Empty => new ClusterCloudProviderOpenstackLoadbalancerArgs();
    }
}