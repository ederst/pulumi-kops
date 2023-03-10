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
    public sealed class ClusterKubeSchedulerLeaderElection
    {
        public readonly bool? LeaderElect;
        public readonly string? LeaderElectLeaseDuration;
        public readonly string? LeaderElectRenewDeadlineDuration;
        public readonly string? LeaderElectResourceLock;
        public readonly string? LeaderElectResourceName;
        public readonly string? LeaderElectResourceNamespace;
        public readonly string? LeaderElectRetryPeriod;

        [OutputConstructor]
        private ClusterKubeSchedulerLeaderElection(
            bool? leaderElect,

            string? leaderElectLeaseDuration,

            string? leaderElectRenewDeadlineDuration,

            string? leaderElectResourceLock,

            string? leaderElectResourceName,

            string? leaderElectResourceNamespace,

            string? leaderElectRetryPeriod)
        {
            LeaderElect = leaderElect;
            LeaderElectLeaseDuration = leaderElectLeaseDuration;
            LeaderElectRenewDeadlineDuration = leaderElectRenewDeadlineDuration;
            LeaderElectResourceLock = leaderElectResourceLock;
            LeaderElectResourceName = leaderElectResourceName;
            LeaderElectResourceNamespace = leaderElectResourceNamespace;
            LeaderElectRetryPeriod = leaderElectRetryPeriod;
        }
    }
}
