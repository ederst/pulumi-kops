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
    public sealed class ClusterKubeDnsAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchField
    {
        public readonly string? Key;
        public readonly string? Operator;
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private ClusterKubeDnsAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchField(
            string? key,

            string? @operator,

            ImmutableArray<string> values)
        {
            Key = key;
            Operator = @operator;
            Values = values;
        }
    }
}
