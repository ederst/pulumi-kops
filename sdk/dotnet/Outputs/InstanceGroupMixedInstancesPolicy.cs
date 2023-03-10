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
    public sealed class InstanceGroupMixedInstancesPolicy
    {
        public readonly Outputs.InstanceGroupMixedInstancesPolicyInstanceRequirements? InstanceRequirements;
        public readonly ImmutableArray<string> Instances;
        public readonly Outputs.InstanceGroupMixedInstancesPolicyOnDemandAboveBase? OnDemandAboveBase;
        public readonly string? OnDemandAllocationStrategy;
        public readonly Outputs.InstanceGroupMixedInstancesPolicyOnDemandBase? OnDemandBase;
        public readonly string? SpotAllocationStrategy;
        public readonly int? SpotInstancePools;

        [OutputConstructor]
        private InstanceGroupMixedInstancesPolicy(
            Outputs.InstanceGroupMixedInstancesPolicyInstanceRequirements? instanceRequirements,

            ImmutableArray<string> instances,

            Outputs.InstanceGroupMixedInstancesPolicyOnDemandAboveBase? onDemandAboveBase,

            string? onDemandAllocationStrategy,

            Outputs.InstanceGroupMixedInstancesPolicyOnDemandBase? onDemandBase,

            string? spotAllocationStrategy,

            int? spotInstancePools)
        {
            InstanceRequirements = instanceRequirements;
            Instances = instances;
            OnDemandAboveBase = onDemandAboveBase;
            OnDemandAllocationStrategy = onDemandAllocationStrategy;
            OnDemandBase = onDemandBase;
            SpotAllocationStrategy = spotAllocationStrategy;
            SpotInstancePools = spotInstancePools;
        }
    }
}
