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
    public sealed class GetClusterApiLoadBalancerSubnetResult
    {
        public readonly string AllocationId;
        /// <summary>
        /// - String - Name defines the cluster name.
        /// </summary>
        public readonly string Name;
        public readonly string PrivateIpv4Address;

        [OutputConstructor]
        private GetClusterApiLoadBalancerSubnetResult(
            string allocationId,

            string name,

            string privateIpv4Address)
        {
            AllocationId = allocationId;
            Name = name;
            PrivateIpv4Address = privateIpv4Address;
        }
    }
}
