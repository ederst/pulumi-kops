// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterNetworkingAmazonVpcGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("envs")]
        private InputList<Inputs.ClusterNetworkingAmazonVpcEnvGetArgs>? _envs;
        public InputList<Inputs.ClusterNetworkingAmazonVpcEnvGetArgs> Envs
        {
            get => _envs ?? (_envs = new InputList<Inputs.ClusterNetworkingAmazonVpcEnvGetArgs>());
            set => _envs = value;
        }

        [Input("image")]
        public Input<string>? Image { get; set; }

        [Input("initImage")]
        public Input<string>? InitImage { get; set; }

        public ClusterNetworkingAmazonVpcGetArgs()
        {
        }
        public static new ClusterNetworkingAmazonVpcGetArgs Empty => new ClusterNetworkingAmazonVpcGetArgs();
    }
}