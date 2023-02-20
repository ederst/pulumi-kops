// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class InstanceGroupWarmPoolGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("enableLifecycleHook")]
        public Input<bool>? EnableLifecycleHook { get; set; }

        /// <summary>
        /// - Int - MaxSize is the maximum size of the pool.
        /// </summary>
        [Input("maxSize")]
        public Input<int>? MaxSize { get; set; }

        /// <summary>
        /// - Int - MinSize is the minimum size of the pool.
        /// </summary>
        [Input("minSize")]
        public Input<int>? MinSize { get; set; }

        public InstanceGroupWarmPoolGetArgs()
        {
        }
        public static new InstanceGroupWarmPoolGetArgs Empty => new InstanceGroupWarmPoolGetArgs();
    }
}
