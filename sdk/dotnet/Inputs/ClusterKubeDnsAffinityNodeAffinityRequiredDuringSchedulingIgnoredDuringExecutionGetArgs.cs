// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterKubeDnsAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("nodeSelectorTerms")]
        private InputList<Inputs.ClusterKubeDnsAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermGetArgs>? _nodeSelectorTerms;
        public InputList<Inputs.ClusterKubeDnsAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermGetArgs> NodeSelectorTerms
        {
            get => _nodeSelectorTerms ?? (_nodeSelectorTerms = new InputList<Inputs.ClusterKubeDnsAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermGetArgs>());
            set => _nodeSelectorTerms = value;
        }

        public ClusterKubeDnsAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionGetArgs()
        {
        }
        public static new ClusterKubeDnsAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionGetArgs Empty => new ClusterKubeDnsAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionGetArgs();
    }
}