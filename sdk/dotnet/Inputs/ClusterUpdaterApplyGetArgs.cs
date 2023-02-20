// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterUpdaterApplyGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("allowKopsDowngrade")]
        public Input<bool>? AllowKopsDowngrade { get; set; }

        [Input("lifecycleOverrides")]
        private InputMap<string>? _lifecycleOverrides;
        public InputMap<string> LifecycleOverrides
        {
            get => _lifecycleOverrides ?? (_lifecycleOverrides = new InputMap<string>());
            set => _lifecycleOverrides = value;
        }

        [Input("skip")]
        public Input<bool>? Skip { get; set; }

        public ClusterUpdaterApplyGetArgs()
        {
        }
        public static new ClusterUpdaterApplyGetArgs Empty => new ClusterUpdaterApplyGetArgs();
    }
}
