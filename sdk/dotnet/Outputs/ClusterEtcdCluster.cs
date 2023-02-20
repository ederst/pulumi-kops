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
    public sealed class ClusterEtcdCluster
    {
        public readonly Outputs.ClusterEtcdClusterBackups? Backups;
        public readonly string? CpuRequest;
        public readonly string? HeartbeatInterval;
        public readonly string? Image;
        public readonly string? LeaderElectionTimeout;
        public readonly Outputs.ClusterEtcdClusterManager? Manager;
        public readonly ImmutableArray<Outputs.ClusterEtcdClusterMember> Members;
        public readonly string? MemoryRequest;
        /// <summary>
        /// - (Force new) - String - Name defines the cluster name.
        /// </summary>
        public readonly string Name;
        public readonly string? Provider;
        public readonly string? Version;

        [OutputConstructor]
        private ClusterEtcdCluster(
            Outputs.ClusterEtcdClusterBackups? backups,

            string? cpuRequest,

            string? heartbeatInterval,

            string? image,

            string? leaderElectionTimeout,

            Outputs.ClusterEtcdClusterManager? manager,

            ImmutableArray<Outputs.ClusterEtcdClusterMember> members,

            string? memoryRequest,

            string name,

            string? provider,

            string? version)
        {
            Backups = backups;
            CpuRequest = cpuRequest;
            HeartbeatInterval = heartbeatInterval;
            Image = image;
            LeaderElectionTimeout = leaderElectionTimeout;
            Manager = manager;
            Members = members;
            MemoryRequest = memoryRequest;
            Name = name;
            Provider = provider;
            Version = version;
        }
    }
}
