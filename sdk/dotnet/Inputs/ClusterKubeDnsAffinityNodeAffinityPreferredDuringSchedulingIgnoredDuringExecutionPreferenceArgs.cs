// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterKubeDnsAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceArgs : global::Pulumi.ResourceArgs
    {
        [Input("matchExpressions")]
        private InputList<Inputs.ClusterKubeDnsAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressionArgs>? _matchExpressions;
        public InputList<Inputs.ClusterKubeDnsAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressionArgs> MatchExpressions
        {
            get => _matchExpressions ?? (_matchExpressions = new InputList<Inputs.ClusterKubeDnsAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressionArgs>());
            set => _matchExpressions = value;
        }

        [Input("matchFields")]
        private InputList<Inputs.ClusterKubeDnsAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFieldArgs>? _matchFields;
        public InputList<Inputs.ClusterKubeDnsAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFieldArgs> MatchFields
        {
            get => _matchFields ?? (_matchFields = new InputList<Inputs.ClusterKubeDnsAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFieldArgs>());
            set => _matchFields = value;
        }

        public ClusterKubeDnsAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceArgs()
        {
        }
        public static new ClusterKubeDnsAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceArgs Empty => new ClusterKubeDnsAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceArgs();
    }
}
