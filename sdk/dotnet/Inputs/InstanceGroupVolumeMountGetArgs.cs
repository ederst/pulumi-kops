// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class InstanceGroupVolumeMountGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("device", required: true)]
        public Input<string> Device { get; set; } = null!;

        [Input("filesystem", required: true)]
        public Input<string> Filesystem { get; set; } = null!;

        [Input("formatOptions")]
        private InputList<string>? _formatOptions;
        public InputList<string> FormatOptions
        {
            get => _formatOptions ?? (_formatOptions = new InputList<string>());
            set => _formatOptions = value;
        }

        [Input("mountOptions")]
        private InputList<string>? _mountOptions;
        public InputList<string> MountOptions
        {
            get => _mountOptions ?? (_mountOptions = new InputList<string>());
            set => _mountOptions = value;
        }

        [Input("path", required: true)]
        public Input<string> Path { get; set; } = null!;

        public InstanceGroupVolumeMountGetArgs()
        {
        }
        public static new InstanceGroupVolumeMountGetArgs Empty => new InstanceGroupVolumeMountGetArgs();
    }
}
