// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterCloudProviderGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("aws")]
        public Input<Inputs.ClusterCloudProviderAwsGetArgs>? Aws { get; set; }

        [Input("azure")]
        public Input<Inputs.ClusterCloudProviderAzureGetArgs>? Azure { get; set; }

        [Input("do")]
        public Input<Inputs.ClusterCloudProviderDoGetArgs>? Do { get; set; }

        [Input("gce")]
        public Input<Inputs.ClusterCloudProviderGceGetArgs>? Gce { get; set; }

        [Input("hetzner")]
        public Input<Inputs.ClusterCloudProviderHetznerGetArgs>? Hetzner { get; set; }

        [Input("openstack")]
        public Input<Inputs.ClusterCloudProviderOpenstackGetArgs>? Openstack { get; set; }

        public ClusterCloudProviderGetArgs()
        {
        }
        public static new ClusterCloudProviderGetArgs Empty => new ClusterCloudProviderGetArgs();
    }
}