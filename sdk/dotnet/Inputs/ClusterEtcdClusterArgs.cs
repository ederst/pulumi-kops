// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterEtcdClusterArgs : global::Pulumi.ResourceArgs
    {
        [Input("backups")]
        public Input<Inputs.ClusterEtcdClusterBackupsArgs>? Backups { get; set; }

        [Input("cpuRequest")]
        public Input<string>? CpuRequest { get; set; }

        [Input("heartbeatInterval")]
        public Input<string>? HeartbeatInterval { get; set; }

        [Input("image")]
        public Input<string>? Image { get; set; }

        [Input("leaderElectionTimeout")]
        public Input<string>? LeaderElectionTimeout { get; set; }

        [Input("manager")]
        public Input<Inputs.ClusterEtcdClusterManagerArgs>? Manager { get; set; }

        [Input("members", required: true)]
        private InputList<Inputs.ClusterEtcdClusterMemberArgs>? _members;
        public InputList<Inputs.ClusterEtcdClusterMemberArgs> Members
        {
            get => _members ?? (_members = new InputList<Inputs.ClusterEtcdClusterMemberArgs>());
            set => _members = value;
        }

        [Input("memoryRequest")]
        public Input<string>? MemoryRequest { get; set; }

        /// <summary>
        /// - (Force new) - String - Name defines the cluster name.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("provider")]
        public Input<string>? Provider { get; set; }

        [Input("version")]
        public Input<string>? Version { get; set; }

        public ClusterEtcdClusterArgs()
        {
        }
        public static new ClusterEtcdClusterArgs Empty => new ClusterEtcdClusterArgs();
    }
}