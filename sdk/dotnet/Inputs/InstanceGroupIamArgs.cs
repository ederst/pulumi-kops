// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class InstanceGroupIamArgs : global::Pulumi.ResourceArgs
    {
        [Input("profile", required: true)]
        public Input<string> Profile { get; set; } = null!;

        public InstanceGroupIamArgs()
        {
        }
        public static new InstanceGroupIamArgs Empty => new InstanceGroupIamArgs();
    }
}
