// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class InstanceGroupMixedInstancesPolicyInstanceRequirementsCpuArgs : global::Pulumi.ResourceArgs
    {
        [Input("max")]
        public Input<string>? Max { get; set; }

        [Input("min")]
        public Input<string>? Min { get; set; }

        public InstanceGroupMixedInstancesPolicyInstanceRequirementsCpuArgs()
        {
        }
        public static new InstanceGroupMixedInstancesPolicyInstanceRequirementsCpuArgs Empty => new InstanceGroupMixedInstancesPolicyInstanceRequirementsCpuArgs();
    }
}
