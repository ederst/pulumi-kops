// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterNodeTerminationHandlerGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("cpuRequest")]
        public Input<string>? CpuRequest { get; set; }

        [Input("enablePrometheusMetrics")]
        public Input<bool>? EnablePrometheusMetrics { get; set; }

        [Input("enableRebalanceDraining")]
        public Input<bool>? EnableRebalanceDraining { get; set; }

        [Input("enableRebalanceMonitoring")]
        public Input<bool>? EnableRebalanceMonitoring { get; set; }

        [Input("enableScheduledEventDraining")]
        public Input<bool>? EnableScheduledEventDraining { get; set; }

        [Input("enableSpotInterruptionDraining", required: true)]
        public Input<bool> EnableSpotInterruptionDraining { get; set; } = null!;

        [Input("enableSqsTerminationDraining")]
        public Input<bool>? EnableSqsTerminationDraining { get; set; }

        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        [Input("excludeFromLoadBalancers")]
        public Input<bool>? ExcludeFromLoadBalancers { get; set; }

        [Input("managedAsgTag")]
        public Input<string>? ManagedAsgTag { get; set; }

        [Input("memoryRequest")]
        public Input<string>? MemoryRequest { get; set; }

        [Input("version")]
        public Input<string>? Version { get; set; }

        public ClusterNodeTerminationHandlerGetArgs()
        {
        }
        public static new ClusterNodeTerminationHandlerGetArgs Empty => new ClusterNodeTerminationHandlerGetArgs();
    }
}
