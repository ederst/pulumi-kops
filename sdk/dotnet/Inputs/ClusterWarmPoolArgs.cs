// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterWarmPoolArgs : global::Pulumi.ResourceArgs
    {
        [Input("enableLifecycleHook")]
        public Input<bool>? EnableLifecycleHook { get; set; }

        [Input("maxSize")]
        public Input<int>? MaxSize { get; set; }

        [Input("minSize")]
        public Input<int>? MinSize { get; set; }

        public ClusterWarmPoolArgs()
        {
        }
        public static new ClusterWarmPoolArgs Empty => new ClusterWarmPoolArgs();
    }
}
