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
    public sealed class GetClusterCloudProviderOpenstackRouterResult
    {
        public readonly ImmutableArray<string> AvailabilityZoneHints;
        public readonly string DnsServers;
        public readonly string ExternalNetwork;
        public readonly string ExternalSubnet;

        [OutputConstructor]
        private GetClusterCloudProviderOpenstackRouterResult(
            ImmutableArray<string> availabilityZoneHints,

            string dnsServers,

            string externalNetwork,

            string externalSubnet)
        {
            AvailabilityZoneHints = availabilityZoneHints;
            DnsServers = dnsServers;
            ExternalNetwork = externalNetwork;
            ExternalSubnet = externalSubnet;
        }
    }
}
