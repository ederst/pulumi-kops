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
    public sealed class GetClusterWarmPoolResult
    {
        public readonly bool EnableLifecycleHook;
        public readonly int MaxSize;
        public readonly int MinSize;

        [OutputConstructor]
        private GetClusterWarmPoolResult(
            bool enableLifecycleHook,

            int maxSize,

            int minSize)
        {
            EnableLifecycleHook = enableLifecycleHook;
            MaxSize = maxSize;
            MinSize = minSize;
        }
    }
}
