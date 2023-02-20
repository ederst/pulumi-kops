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
    public sealed class GetInstanceGroupVolumeMountResult
    {
        public readonly string Device;
        public readonly string Filesystem;
        public readonly ImmutableArray<string> FormatOptions;
        public readonly ImmutableArray<string> MountOptions;
        public readonly string Path;

        [OutputConstructor]
        private GetInstanceGroupVolumeMountResult(
            string device,

            string filesystem,

            ImmutableArray<string> formatOptions,

            ImmutableArray<string> mountOptions,

            string path)
        {
            Device = device;
            Filesystem = filesystem;
            FormatOptions = formatOptions;
            MountOptions = mountOptions;
            Path = path;
        }
    }
}
