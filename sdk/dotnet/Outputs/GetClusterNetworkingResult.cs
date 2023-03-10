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
    public sealed class GetClusterNetworkingResult
    {
        public readonly ImmutableArray<Outputs.GetClusterNetworkingAmazonVpcResult> AmazonVpcs;
        public readonly ImmutableArray<Outputs.GetClusterNetworkingCalicoResult> Calicos;
        public readonly ImmutableArray<Outputs.GetClusterNetworkingCanalResult> Canals;
        public readonly ImmutableArray<Outputs.GetClusterNetworkingCiliaResult> Cilias;
        public readonly ImmutableArray<Outputs.GetClusterNetworkingClassicResult> Classics;
        public readonly ImmutableArray<Outputs.GetClusterNetworkingCniResult> Cnis;
        public readonly ImmutableArray<Outputs.GetClusterNetworkingExternalResult> Externals;
        public readonly ImmutableArray<Outputs.GetClusterNetworkingFlannelResult> Flannels;
        public readonly ImmutableArray<Outputs.GetClusterNetworkingGceResult> Gces;
        public readonly ImmutableArray<Outputs.GetClusterNetworkingKopeioResult> Kopeios;
        public readonly ImmutableArray<Outputs.GetClusterNetworkingKubenetResult> Kubenets;
        public readonly ImmutableArray<Outputs.GetClusterNetworkingKuberouterResult> Kuberouters;
        public readonly ImmutableArray<Outputs.GetClusterNetworkingLyftVpcResult> LyftVpcs;
        public readonly ImmutableArray<Outputs.GetClusterNetworkingRomanaResult> Romanas;
        public readonly ImmutableArray<Outputs.GetClusterNetworkingWeafeResult> Weaves;

        [OutputConstructor]
        private GetClusterNetworkingResult(
            ImmutableArray<Outputs.GetClusterNetworkingAmazonVpcResult> amazonVpcs,

            ImmutableArray<Outputs.GetClusterNetworkingCalicoResult> calicos,

            ImmutableArray<Outputs.GetClusterNetworkingCanalResult> canals,

            ImmutableArray<Outputs.GetClusterNetworkingCiliaResult> cilias,

            ImmutableArray<Outputs.GetClusterNetworkingClassicResult> classics,

            ImmutableArray<Outputs.GetClusterNetworkingCniResult> cnis,

            ImmutableArray<Outputs.GetClusterNetworkingExternalResult> externals,

            ImmutableArray<Outputs.GetClusterNetworkingFlannelResult> flannels,

            ImmutableArray<Outputs.GetClusterNetworkingGceResult> gces,

            ImmutableArray<Outputs.GetClusterNetworkingKopeioResult> kopeios,

            ImmutableArray<Outputs.GetClusterNetworkingKubenetResult> kubenets,

            ImmutableArray<Outputs.GetClusterNetworkingKuberouterResult> kuberouters,

            ImmutableArray<Outputs.GetClusterNetworkingLyftVpcResult> lyftVpcs,

            ImmutableArray<Outputs.GetClusterNetworkingRomanaResult> romanas,

            ImmutableArray<Outputs.GetClusterNetworkingWeafeResult> weaves)
        {
            AmazonVpcs = amazonVpcs;
            Calicos = calicos;
            Canals = canals;
            Cilias = cilias;
            Classics = classics;
            Cnis = cnis;
            Externals = externals;
            Flannels = flannels;
            Gces = gces;
            Kopeios = kopeios;
            Kubenets = kubenets;
            Kuberouters = kuberouters;
            LyftVpcs = lyftVpcs;
            Romanas = romanas;
            Weaves = weaves;
        }
    }
}
