// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterDockerArgs : global::Pulumi.ResourceArgs
    {
        [Input("authorizationPlugins")]
        private InputList<string>? _authorizationPlugins;
        public InputList<string> AuthorizationPlugins
        {
            get => _authorizationPlugins ?? (_authorizationPlugins = new InputList<string>());
            set => _authorizationPlugins = value;
        }

        [Input("bridge")]
        public Input<string>? Bridge { get; set; }

        [Input("bridgeIp")]
        public Input<string>? BridgeIp { get; set; }

        [Input("dataRoot")]
        public Input<string>? DataRoot { get; set; }

        [Input("defaultRuntime")]
        public Input<string>? DefaultRuntime { get; set; }

        [Input("defaultUlimits")]
        private InputList<string>? _defaultUlimits;
        public InputList<string> DefaultUlimits
        {
            get => _defaultUlimits ?? (_defaultUlimits = new InputList<string>());
            set => _defaultUlimits = value;
        }

        [Input("dns")]
        private InputList<string>? _dns;
        public InputList<string> Dns
        {
            get => _dns ?? (_dns = new InputList<string>());
            set => _dns = value;
        }

        [Input("execOpts")]
        private InputList<string>? _execOpts;
        public InputList<string> ExecOpts
        {
            get => _execOpts ?? (_execOpts = new InputList<string>());
            set => _execOpts = value;
        }

        [Input("execRoot")]
        public Input<string>? ExecRoot { get; set; }

        [Input("experimental")]
        public Input<bool>? Experimental { get; set; }

        [Input("healthCheck")]
        public Input<bool>? HealthCheck { get; set; }

        [Input("hosts")]
        private InputList<string>? _hosts;
        public InputList<string> Hosts
        {
            get => _hosts ?? (_hosts = new InputList<string>());
            set => _hosts = value;
        }

        [Input("insecureRegistries")]
        private InputList<string>? _insecureRegistries;
        public InputList<string> InsecureRegistries
        {
            get => _insecureRegistries ?? (_insecureRegistries = new InputList<string>());
            set => _insecureRegistries = value;
        }

        [Input("insecureRegistry")]
        public Input<string>? InsecureRegistry { get; set; }

        [Input("ipMasq")]
        public Input<bool>? IpMasq { get; set; }

        [Input("ipTables")]
        public Input<bool>? IpTables { get; set; }

        [Input("liveRestore")]
        public Input<bool>? LiveRestore { get; set; }

        [Input("logDriver")]
        public Input<string>? LogDriver { get; set; }

        [Input("logLevel")]
        public Input<string>? LogLevel { get; set; }

        [Input("logOpts")]
        private InputList<string>? _logOpts;
        public InputList<string> LogOpts
        {
            get => _logOpts ?? (_logOpts = new InputList<string>());
            set => _logOpts = value;
        }

        [Input("maxConcurrentDownloads")]
        public Input<int>? MaxConcurrentDownloads { get; set; }

        [Input("maxConcurrentUploads")]
        public Input<int>? MaxConcurrentUploads { get; set; }

        [Input("maxDownloadAttempts")]
        public Input<int>? MaxDownloadAttempts { get; set; }

        [Input("metricsAddress")]
        public Input<string>? MetricsAddress { get; set; }

        [Input("mtu")]
        public Input<int>? Mtu { get; set; }

        [Input("packages")]
        public Input<Inputs.ClusterDockerPackagesArgs>? Packages { get; set; }

        [Input("registryMirrors")]
        private InputList<string>? _registryMirrors;
        public InputList<string> RegistryMirrors
        {
            get => _registryMirrors ?? (_registryMirrors = new InputList<string>());
            set => _registryMirrors = value;
        }

        [Input("runtimes")]
        private InputList<string>? _runtimes;
        public InputList<string> Runtimes
        {
            get => _runtimes ?? (_runtimes = new InputList<string>());
            set => _runtimes = value;
        }

        [Input("selinuxEnabled")]
        public Input<bool>? SelinuxEnabled { get; set; }

        [Input("skipInstall")]
        public Input<bool>? SkipInstall { get; set; }

        [Input("storage")]
        public Input<string>? Storage { get; set; }

        [Input("storageOpts")]
        private InputList<string>? _storageOpts;
        public InputList<string> StorageOpts
        {
            get => _storageOpts ?? (_storageOpts = new InputList<string>());
            set => _storageOpts = value;
        }

        [Input("userNamespaceRemap")]
        public Input<string>? UserNamespaceRemap { get; set; }

        [Input("version")]
        public Input<string>? Version { get; set; }

        public ClusterDockerArgs()
        {
        }
        public static new ClusterDockerArgs Empty => new ClusterDockerArgs();
    }
}