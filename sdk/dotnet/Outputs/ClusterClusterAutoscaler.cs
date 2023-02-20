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
    public sealed class ClusterClusterAutoscaler
    {
        public readonly bool? AwsUseStaticInstanceList;
        public readonly bool? BalanceSimilarNodeGroups;
        public readonly bool? CordonNodeBeforeTerminating;
        public readonly string? CpuRequest;
        public readonly bool? Enabled;
        public readonly string? Expander;
        public readonly string? Image;
        public readonly string? MaxNodeProvisionTime;
        public readonly string? MemoryRequest;
        public readonly string? NewPodScaleUpDelay;
        public readonly ImmutableDictionary<string, string>? PodAnnotations;
        public readonly string? ScaleDownDelayAfterAdd;
        public readonly string? ScaleDownUnneededTime;
        public readonly string? ScaleDownUnreadyTime;
        public readonly string? ScaleDownUtilizationThreshold;
        public readonly bool SkipNodesWithLocalStorage;
        public readonly bool SkipNodesWithSystemPods;

        [OutputConstructor]
        private ClusterClusterAutoscaler(
            bool? awsUseStaticInstanceList,

            bool? balanceSimilarNodeGroups,

            bool? cordonNodeBeforeTerminating,

            string? cpuRequest,

            bool? enabled,

            string? expander,

            string? image,

            string? maxNodeProvisionTime,

            string? memoryRequest,

            string? newPodScaleUpDelay,

            ImmutableDictionary<string, string>? podAnnotations,

            string? scaleDownDelayAfterAdd,

            string? scaleDownUnneededTime,

            string? scaleDownUnreadyTime,

            string? scaleDownUtilizationThreshold,

            bool skipNodesWithLocalStorage,

            bool skipNodesWithSystemPods)
        {
            AwsUseStaticInstanceList = awsUseStaticInstanceList;
            BalanceSimilarNodeGroups = balanceSimilarNodeGroups;
            CordonNodeBeforeTerminating = cordonNodeBeforeTerminating;
            CpuRequest = cpuRequest;
            Enabled = enabled;
            Expander = expander;
            Image = image;
            MaxNodeProvisionTime = maxNodeProvisionTime;
            MemoryRequest = memoryRequest;
            NewPodScaleUpDelay = newPodScaleUpDelay;
            PodAnnotations = podAnnotations;
            ScaleDownDelayAfterAdd = scaleDownDelayAfterAdd;
            ScaleDownUnneededTime = scaleDownUnneededTime;
            ScaleDownUnreadyTime = scaleDownUnreadyTime;
            ScaleDownUtilizationThreshold = scaleDownUtilizationThreshold;
            SkipNodesWithLocalStorage = skipNodesWithLocalStorage;
            SkipNodesWithSystemPods = skipNodesWithSystemPods;
        }
    }
}
