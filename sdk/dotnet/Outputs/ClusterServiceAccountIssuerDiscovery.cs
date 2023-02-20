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
    public sealed class ClusterServiceAccountIssuerDiscovery
    {
        public readonly ImmutableArray<string> AdditionalAudiences;
        public readonly string? DiscoveryStore;
        public readonly bool? EnableAwsOidcProvider;

        [OutputConstructor]
        private ClusterServiceAccountIssuerDiscovery(
            ImmutableArray<string> additionalAudiences,

            string? discoveryStore,

            bool? enableAwsOidcProvider)
        {
            AdditionalAudiences = additionalAudiences;
            DiscoveryStore = discoveryStore;
            EnableAwsOidcProvider = enableAwsOidcProvider;
        }
    }
}
