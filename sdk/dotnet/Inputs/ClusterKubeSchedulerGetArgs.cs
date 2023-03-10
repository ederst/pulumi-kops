// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterKubeSchedulerGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("authenticationKubeconfig")]
        public Input<string>? AuthenticationKubeconfig { get; set; }

        [Input("authorizationAlwaysAllowPaths")]
        private InputList<string>? _authorizationAlwaysAllowPaths;
        public InputList<string> AuthorizationAlwaysAllowPaths
        {
            get => _authorizationAlwaysAllowPaths ?? (_authorizationAlwaysAllowPaths = new InputList<string>());
            set => _authorizationAlwaysAllowPaths = value;
        }

        [Input("authorizationKubeconfig")]
        public Input<string>? AuthorizationKubeconfig { get; set; }

        [Input("burst")]
        public Input<int>? Burst { get; set; }

        [Input("enableProfiling")]
        public Input<bool>? EnableProfiling { get; set; }

        [Input("featureGates")]
        private InputMap<string>? _featureGates;
        public InputMap<string> FeatureGates
        {
            get => _featureGates ?? (_featureGates = new InputMap<string>());
            set => _featureGates = value;
        }

        [Input("image")]
        public Input<string>? Image { get; set; }

        [Input("leaderElection")]
        public Input<Inputs.ClusterKubeSchedulerLeaderElectionGetArgs>? LeaderElection { get; set; }

        [Input("logFormat")]
        public Input<string>? LogFormat { get; set; }

        [Input("logLevel")]
        public Input<int>? LogLevel { get; set; }

        [Input("master")]
        public Input<string>? Master { get; set; }

        [Input("maxPersistentVolumes")]
        public Input<int>? MaxPersistentVolumes { get; set; }

        [Input("qps")]
        public Input<string>? Qps { get; set; }

        [Input("tlsCertFile")]
        public Input<string>? TlsCertFile { get; set; }

        [Input("tlsPrivateKeyFile")]
        public Input<string>? TlsPrivateKeyFile { get; set; }

        [Input("usePolicyConfigMap")]
        public Input<bool>? UsePolicyConfigMap { get; set; }

        public ClusterKubeSchedulerGetArgs()
        {
        }
        public static new ClusterKubeSchedulerGetArgs Empty => new ClusterKubeSchedulerGetArgs();
    }
}
