// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class InstanceGroupContainerdNvidiaGpuArgs : global::Pulumi.ResourceArgs
    {
        [Input("driverPackage")]
        public Input<string>? DriverPackage { get; set; }

        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        public InstanceGroupContainerdNvidiaGpuArgs()
        {
        }
        public static new InstanceGroupContainerdNvidiaGpuArgs Empty => new InstanceGroupContainerdNvidiaGpuArgs();
    }
}