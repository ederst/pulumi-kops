// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterKubeSchedulerLeaderElectionArgs : global::Pulumi.ResourceArgs
    {
        [Input("leaderElect")]
        public Input<bool>? LeaderElect { get; set; }

        [Input("leaderElectLeaseDuration")]
        public Input<string>? LeaderElectLeaseDuration { get; set; }

        [Input("leaderElectRenewDeadlineDuration")]
        public Input<string>? LeaderElectRenewDeadlineDuration { get; set; }

        [Input("leaderElectResourceLock")]
        public Input<string>? LeaderElectResourceLock { get; set; }

        [Input("leaderElectResourceName")]
        public Input<string>? LeaderElectResourceName { get; set; }

        [Input("leaderElectResourceNamespace")]
        public Input<string>? LeaderElectResourceNamespace { get; set; }

        [Input("leaderElectRetryPeriod")]
        public Input<string>? LeaderElectRetryPeriod { get; set; }

        public ClusterKubeSchedulerLeaderElectionArgs()
        {
        }
        public static new ClusterKubeSchedulerLeaderElectionArgs Empty => new ClusterKubeSchedulerLeaderElectionArgs();
    }
}