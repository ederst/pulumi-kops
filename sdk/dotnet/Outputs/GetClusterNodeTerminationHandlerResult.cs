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
    public sealed class GetClusterNodeTerminationHandlerResult
    {
        public readonly string CpuRequest;
        public readonly bool EnablePrometheusMetrics;
        public readonly bool EnableRebalanceDraining;
        public readonly bool EnableRebalanceMonitoring;
        public readonly bool EnableScheduledEventDraining;
        public readonly bool EnableSpotInterruptionDraining;
        public readonly bool EnableSqsTerminationDraining;
        public readonly bool Enabled;
        public readonly bool ExcludeFromLoadBalancers;
        public readonly string ManagedAsgTag;
        public readonly string MemoryRequest;
        public readonly string Version;

        [OutputConstructor]
        private GetClusterNodeTerminationHandlerResult(
            string cpuRequest,

            bool enablePrometheusMetrics,

            bool enableRebalanceDraining,

            bool enableRebalanceMonitoring,

            bool enableScheduledEventDraining,

            bool enableSpotInterruptionDraining,

            bool enableSqsTerminationDraining,

            bool enabled,

            bool excludeFromLoadBalancers,

            string managedAsgTag,

            string memoryRequest,

            string version)
        {
            CpuRequest = cpuRequest;
            EnablePrometheusMetrics = enablePrometheusMetrics;
            EnableRebalanceDraining = enableRebalanceDraining;
            EnableRebalanceMonitoring = enableRebalanceMonitoring;
            EnableScheduledEventDraining = enableScheduledEventDraining;
            EnableSpotInterruptionDraining = enableSpotInterruptionDraining;
            EnableSqsTerminationDraining = enableSqsTerminationDraining;
            Enabled = enabled;
            ExcludeFromLoadBalancers = excludeFromLoadBalancers;
            ManagedAsgTag = managedAsgTag;
            MemoryRequest = memoryRequest;
            Version = version;
        }
    }
}
