// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class InstanceGroupMixedInstancesPolicyOnDemandBaseArgs : global::Pulumi.ResourceArgs
    {
        [Input("value")]
        public Input<int>? Value { get; set; }

        public InstanceGroupMixedInstancesPolicyOnDemandBaseArgs()
        {
        }
        public static new InstanceGroupMixedInstancesPolicyOnDemandBaseArgs Empty => new InstanceGroupMixedInstancesPolicyOnDemandBaseArgs();
    }
}