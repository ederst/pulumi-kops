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
    public sealed class GetInstanceGroupVolumeResult
    {
        public readonly bool DeleteOnTermination;
        public readonly string Device;
        public readonly bool Encrypted;
        public readonly int Iops;
        public readonly string Key;
        public readonly int Size;
        public readonly int Throughput;
        public readonly string Type;

        [OutputConstructor]
        private GetInstanceGroupVolumeResult(
            bool deleteOnTermination,

            string device,

            bool encrypted,

            int iops,

            string key,

            int size,

            int throughput,

            string type)
        {
            DeleteOnTermination = deleteOnTermination;
            Device = device;
            Encrypted = encrypted;
            Iops = iops;
            Key = key;
            Size = size;
            Throughput = throughput;
            Type = type;
        }
    }
}