// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterCloudProviderOpenstackArgs : global::Pulumi.ResourceArgs
    {
        [Input("blockStorage")]
        public Input<Inputs.ClusterCloudProviderOpenstackBlockStorageArgs>? BlockStorage { get; set; }

        [Input("insecureSkipVerify")]
        public Input<bool>? InsecureSkipVerify { get; set; }

        [Input("loadbalancer")]
        public Input<Inputs.ClusterCloudProviderOpenstackLoadbalancerArgs>? Loadbalancer { get; set; }

        [Input("metadata")]
        public Input<Inputs.ClusterCloudProviderOpenstackMetadataArgs>? Metadata { get; set; }

        [Input("monitor")]
        public Input<Inputs.ClusterCloudProviderOpenstackMonitorArgs>? Monitor { get; set; }

        [Input("network")]
        public Input<Inputs.ClusterCloudProviderOpenstackNetworkArgs>? Network { get; set; }

        [Input("router")]
        public Input<Inputs.ClusterCloudProviderOpenstackRouterArgs>? Router { get; set; }

        public ClusterCloudProviderOpenstackArgs()
        {
        }
        public static new ClusterCloudProviderOpenstackArgs Empty => new ClusterCloudProviderOpenstackArgs();
    }
}