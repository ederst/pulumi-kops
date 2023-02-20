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
    public sealed class GetClusterExternalCloudControllerManagerResult
    {
        public readonly bool AllocateNodeCidrs;
        public readonly bool AllowUntaggedCloud;
        public readonly string CidrAllocatorType;
        /// <summary>
        /// - cloud_provider_spec - CloudProvider configures the cloud provider to use.
        /// </summary>
        public readonly string CloudProvider;
        public readonly string ClusterCidr;
        public readonly string ClusterName;
        public readonly bool ConfigureCloudRoutes;
        public readonly ImmutableArray<string> Controllers;
        public readonly string CpuRequest;
        public readonly bool EnableLeaderMigration;
        public readonly string Image;
        public readonly ImmutableArray<Outputs.GetClusterExternalCloudControllerManagerLeaderElectionResult> LeaderElections;
        public readonly int LogLevel;
        public readonly string Master;
        public readonly bool UseServiceAccountCredentials;

        [OutputConstructor]
        private GetClusterExternalCloudControllerManagerResult(
            bool allocateNodeCidrs,

            bool allowUntaggedCloud,

            string cidrAllocatorType,

            string cloudProvider,

            string clusterCidr,

            string clusterName,

            bool configureCloudRoutes,

            ImmutableArray<string> controllers,

            string cpuRequest,

            bool enableLeaderMigration,

            string image,

            ImmutableArray<Outputs.GetClusterExternalCloudControllerManagerLeaderElectionResult> leaderElections,

            int logLevel,

            string master,

            bool useServiceAccountCredentials)
        {
            AllocateNodeCidrs = allocateNodeCidrs;
            AllowUntaggedCloud = allowUntaggedCloud;
            CidrAllocatorType = cidrAllocatorType;
            CloudProvider = cloudProvider;
            ClusterCidr = clusterCidr;
            ClusterName = clusterName;
            ConfigureCloudRoutes = configureCloudRoutes;
            Controllers = controllers;
            CpuRequest = cpuRequest;
            EnableLeaderMigration = enableLeaderMigration;
            Image = image;
            LeaderElections = leaderElections;
            LogLevel = logLevel;
            Master = master;
            UseServiceAccountCredentials = useServiceAccountCredentials;
        }
    }
}
