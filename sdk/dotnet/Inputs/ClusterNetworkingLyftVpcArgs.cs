// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterNetworkingLyftVpcArgs : global::Pulumi.ResourceArgs
    {
        [Input("subnetTags")]
        private InputMap<string>? _subnetTags;
        public InputMap<string> SubnetTags
        {
            get => _subnetTags ?? (_subnetTags = new InputMap<string>());
            set => _subnetTags = value;
        }

        public ClusterNetworkingLyftVpcArgs()
        {
        }
        public static new ClusterNetworkingLyftVpcArgs Empty => new ClusterNetworkingLyftVpcArgs();
    }
}