// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterNetworkingFlannelArgs : global::Pulumi.ResourceArgs
    {
        [Input("backend")]
        public Input<string>? Backend { get; set; }

        [Input("iptablesResyncSeconds")]
        public Input<int>? IptablesResyncSeconds { get; set; }

        public ClusterNetworkingFlannelArgs()
        {
        }
        public static new ClusterNetworkingFlannelArgs Empty => new ClusterNetworkingFlannelArgs();
    }
}
