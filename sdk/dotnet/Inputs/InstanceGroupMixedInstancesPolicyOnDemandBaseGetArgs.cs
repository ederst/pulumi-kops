// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class InstanceGroupMixedInstancesPolicyOnDemandBaseGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("value")]
        public Input<int>? Value { get; set; }

        public InstanceGroupMixedInstancesPolicyOnDemandBaseGetArgs()
        {
        }
        public static new InstanceGroupMixedInstancesPolicyOnDemandBaseGetArgs Empty => new InstanceGroupMixedInstancesPolicyOnDemandBaseGetArgs();
    }
}