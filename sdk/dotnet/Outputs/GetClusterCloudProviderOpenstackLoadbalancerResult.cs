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
    public sealed class GetClusterCloudProviderOpenstackLoadbalancerResult
    {
        public readonly bool EnableIngressHostname;
        public readonly string FloatingNetwork;
        public readonly string FloatingNetworkId;
        public readonly string FloatingSubnet;
        public readonly string IngressHostnameSuffix;
        public readonly bool ManageSecGroups;
        public readonly string Method;
        public readonly string Provider;
        public readonly string SubnetId;
        public readonly bool UseOctavia;

        [OutputConstructor]
        private GetClusterCloudProviderOpenstackLoadbalancerResult(
            bool enableIngressHostname,

            string floatingNetwork,

            string floatingNetworkId,

            string floatingSubnet,

            string ingressHostnameSuffix,

            bool manageSecGroups,

            string method,

            string provider,

            string subnetId,

            bool useOctavia)
        {
            EnableIngressHostname = enableIngressHostname;
            FloatingNetwork = floatingNetwork;
            FloatingNetworkId = floatingNetworkId;
            FloatingSubnet = floatingSubnet;
            IngressHostnameSuffix = ingressHostnameSuffix;
            ManageSecGroups = manageSecGroups;
            Method = method;
            Provider = provider;
            SubnetId = subnetId;
            UseOctavia = useOctavia;
        }
    }
}
