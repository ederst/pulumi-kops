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
    public sealed class ClusterKubeScheduler
    {
        public readonly string? AuthenticationKubeconfig;
        public readonly ImmutableArray<string> AuthorizationAlwaysAllowPaths;
        public readonly string? AuthorizationKubeconfig;
        public readonly int? Burst;
        public readonly bool? EnableProfiling;
        public readonly ImmutableDictionary<string, string>? FeatureGates;
        public readonly string? Image;
        public readonly Outputs.ClusterKubeSchedulerLeaderElection? LeaderElection;
        public readonly string? LogFormat;
        public readonly int? LogLevel;
        public readonly string? Master;
        public readonly int? MaxPersistentVolumes;
        public readonly string? Qps;
        public readonly string? TlsCertFile;
        public readonly string? TlsPrivateKeyFile;
        public readonly bool? UsePolicyConfigMap;

        [OutputConstructor]
        private ClusterKubeScheduler(
            string? authenticationKubeconfig,

            ImmutableArray<string> authorizationAlwaysAllowPaths,

            string? authorizationKubeconfig,

            int? burst,

            bool? enableProfiling,

            ImmutableDictionary<string, string>? featureGates,

            string? image,

            Outputs.ClusterKubeSchedulerLeaderElection? leaderElection,

            string? logFormat,

            int? logLevel,

            string? master,

            int? maxPersistentVolumes,

            string? qps,

            string? tlsCertFile,

            string? tlsPrivateKeyFile,

            bool? usePolicyConfigMap)
        {
            AuthenticationKubeconfig = authenticationKubeconfig;
            AuthorizationAlwaysAllowPaths = authorizationAlwaysAllowPaths;
            AuthorizationKubeconfig = authorizationKubeconfig;
            Burst = burst;
            EnableProfiling = enableProfiling;
            FeatureGates = featureGates;
            Image = image;
            LeaderElection = leaderElection;
            LogFormat = logFormat;
            LogLevel = logLevel;
            Master = master;
            MaxPersistentVolumes = maxPersistentVolumes;
            Qps = qps;
            TlsCertFile = tlsCertFile;
            TlsPrivateKeyFile = tlsPrivateKeyFile;
            UsePolicyConfigMap = usePolicyConfigMap;
        }
    }
}
