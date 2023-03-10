// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterEtcdClusterMemberGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("encryptedVolume")]
        public Input<bool>? EncryptedVolume { get; set; }

        [Input("instanceGroup", required: true)]
        public Input<string> InstanceGroup { get; set; } = null!;

        [Input("kmsKeyId")]
        public Input<string>? KmsKeyId { get; set; }

        /// <summary>
        /// - (Force new) - String - Name defines the cluster name.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("volumeIops")]
        public Input<int>? VolumeIops { get; set; }

        [Input("volumeSize")]
        public Input<int>? VolumeSize { get; set; }

        [Input("volumeThroughput")]
        public Input<int>? VolumeThroughput { get; set; }

        [Input("volumeType")]
        public Input<string>? VolumeType { get; set; }

        public ClusterEtcdClusterMemberGetArgs()
        {
        }
        public static new ClusterEtcdClusterMemberGetArgs Empty => new ClusterEtcdClusterMemberGetArgs();
    }
}
