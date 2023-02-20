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
    public sealed class InstanceGroupGuestAccelerator
    {
        public readonly int? AcceleratorCount;
        public readonly string? AcceleratorType;

        [OutputConstructor]
        private InstanceGroupGuestAccelerator(
            int? acceleratorCount,

            string? acceleratorType)
        {
            AcceleratorCount = acceleratorCount;
            AcceleratorType = acceleratorType;
        }
    }
}
