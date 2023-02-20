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
    public sealed class GetClusterCloudProviderResult
    {
        public readonly ImmutableArray<Outputs.GetClusterCloudProviderAwResult> Aws;
        public readonly ImmutableArray<Outputs.GetClusterCloudProviderAzureResult> Azures;
        public readonly ImmutableArray<Outputs.GetClusterCloudProviderDoResult> Dos;
        public readonly ImmutableArray<Outputs.GetClusterCloudProviderGceResult> Gces;
        public readonly ImmutableArray<Outputs.GetClusterCloudProviderHetznerResult> Hetzners;
        public readonly ImmutableArray<Outputs.GetClusterCloudProviderOpenstackResult> Openstacks;

        [OutputConstructor]
        private GetClusterCloudProviderResult(
            ImmutableArray<Outputs.GetClusterCloudProviderAwResult> aws,

            ImmutableArray<Outputs.GetClusterCloudProviderAzureResult> azures,

            ImmutableArray<Outputs.GetClusterCloudProviderDoResult> dos,

            ImmutableArray<Outputs.GetClusterCloudProviderGceResult> gces,

            ImmutableArray<Outputs.GetClusterCloudProviderHetznerResult> hetzners,

            ImmutableArray<Outputs.GetClusterCloudProviderOpenstackResult> openstacks)
        {
            Aws = aws;
            Azures = azures;
            Dos = dos;
            Gces = gces;
            Hetzners = hetzners;
            Openstacks = openstacks;
        }
    }
}