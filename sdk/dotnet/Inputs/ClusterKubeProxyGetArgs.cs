// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterKubeProxyGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("bindAddress")]
        public Input<string>? BindAddress { get; set; }

        [Input("clusterCidr")]
        public Input<string>? ClusterCidr { get; set; }

        [Input("conntrackMaxPerCore")]
        public Input<int>? ConntrackMaxPerCore { get; set; }

        [Input("conntrackMin")]
        public Input<int>? ConntrackMin { get; set; }

        [Input("cpuLimit")]
        public Input<string>? CpuLimit { get; set; }

        [Input("cpuRequest")]
        public Input<string>? CpuRequest { get; set; }

        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        [Input("featureGates")]
        private InputMap<string>? _featureGates;
        public InputMap<string> FeatureGates
        {
            get => _featureGates ?? (_featureGates = new InputMap<string>());
            set => _featureGates = value;
        }

        [Input("hostnameOverride")]
        public Input<string>? HostnameOverride { get; set; }

        [Input("image")]
        public Input<string>? Image { get; set; }

        [Input("ipVsExcludeCidrs")]
        private InputList<string>? _ipVsExcludeCidrs;
        public InputList<string> IpVsExcludeCidrs
        {
            get => _ipVsExcludeCidrs ?? (_ipVsExcludeCidrs = new InputList<string>());
            set => _ipVsExcludeCidrs = value;
        }

        [Input("ipVsMinSyncPeriod")]
        public Input<string>? IpVsMinSyncPeriod { get; set; }

        [Input("ipVsScheduler")]
        public Input<string>? IpVsScheduler { get; set; }

        [Input("ipVsSyncPeriod")]
        public Input<string>? IpVsSyncPeriod { get; set; }

        [Input("logLevel")]
        public Input<int>? LogLevel { get; set; }

        [Input("master")]
        public Input<string>? Master { get; set; }

        [Input("memoryLimit")]
        public Input<string>? MemoryLimit { get; set; }

        [Input("memoryRequest")]
        public Input<string>? MemoryRequest { get; set; }

        [Input("metricsBindAddress")]
        public Input<string>? MetricsBindAddress { get; set; }

        [Input("proxyMode")]
        public Input<string>? ProxyMode { get; set; }

        public ClusterKubeProxyGetArgs()
        {
        }
        public static new ClusterKubeProxyGetArgs Empty => new ClusterKubeProxyGetArgs();
    }
}
