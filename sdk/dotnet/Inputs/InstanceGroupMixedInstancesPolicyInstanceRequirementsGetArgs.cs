// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class InstanceGroupMixedInstancesPolicyInstanceRequirementsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("cpu")]
        public Input<Inputs.InstanceGroupMixedInstancesPolicyInstanceRequirementsCpuGetArgs>? Cpu { get; set; }

        [Input("memory")]
        public Input<Inputs.InstanceGroupMixedInstancesPolicyInstanceRequirementsMemoryGetArgs>? Memory { get; set; }

        public InstanceGroupMixedInstancesPolicyInstanceRequirementsGetArgs()
        {
        }
        public static new InstanceGroupMixedInstancesPolicyInstanceRequirementsGetArgs Empty => new InstanceGroupMixedInstancesPolicyInstanceRequirementsGetArgs();
    }
}
