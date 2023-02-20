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
    public sealed class ClusterKubeDnsAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
    {
        public readonly Outputs.ClusterKubeDnsAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector;
        public readonly Outputs.ClusterKubeDnsAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector;
        public readonly ImmutableArray<string> Namespaces;
        public readonly string? TopologyKey;

        [OutputConstructor]
        private ClusterKubeDnsAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm(
            Outputs.ClusterKubeDnsAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? labelSelector,

            Outputs.ClusterKubeDnsAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? namespaceSelector,

            ImmutableArray<string> namespaces,

            string? topologyKey)
        {
            LabelSelector = labelSelector;
            NamespaceSelector = namespaceSelector;
            Namespaces = namespaces;
            TopologyKey = topologyKey;
        }
    }
}
