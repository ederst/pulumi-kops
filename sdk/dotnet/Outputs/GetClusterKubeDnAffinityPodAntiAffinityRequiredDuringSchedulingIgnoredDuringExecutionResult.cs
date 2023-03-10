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
    public sealed class GetClusterKubeDnAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionResult
    {
        public readonly ImmutableArray<Outputs.GetClusterKubeDnAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorResult> LabelSelectors;
        public readonly ImmutableArray<Outputs.GetClusterKubeDnAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorResult> NamespaceSelectors;
        public readonly ImmutableArray<string> Namespaces;
        public readonly string TopologyKey;

        [OutputConstructor]
        private GetClusterKubeDnAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionResult(
            ImmutableArray<Outputs.GetClusterKubeDnAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorResult> labelSelectors,

            ImmutableArray<Outputs.GetClusterKubeDnAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorResult> namespaceSelectors,

            ImmutableArray<string> namespaces,

            string topologyKey)
        {
            LabelSelectors = labelSelectors;
            NamespaceSelectors = namespaceSelectors;
            Namespaces = namespaces;
            TopologyKey = topologyKey;
        }
    }
}
