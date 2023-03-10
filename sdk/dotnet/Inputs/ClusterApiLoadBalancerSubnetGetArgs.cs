// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterApiLoadBalancerSubnetGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("allocationId")]
        public Input<string>? AllocationId { get; set; }

        /// <summary>
        /// - (Force new) - String - Name defines the cluster name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("privateIpv4Address")]
        public Input<string>? PrivateIpv4Address { get; set; }

        public ClusterApiLoadBalancerSubnetGetArgs()
        {
        }
        public static new ClusterApiLoadBalancerSubnetGetArgs Empty => new ClusterApiLoadBalancerSubnetGetArgs();
    }
}
