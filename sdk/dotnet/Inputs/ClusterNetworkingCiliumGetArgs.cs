// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterNetworkingCiliumGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("agentPodAnnotations")]
        private InputMap<string>? _agentPodAnnotations;
        public InputMap<string> AgentPodAnnotations
        {
            get => _agentPodAnnotations ?? (_agentPodAnnotations = new InputMap<string>());
            set => _agentPodAnnotations = value;
        }

        [Input("agentPrometheusPort")]
        public Input<int>? AgentPrometheusPort { get; set; }

        [Input("autoDirectNodeRoutes")]
        public Input<bool>? AutoDirectNodeRoutes { get; set; }

        [Input("bpfNeighGlobalMax")]
        public Input<int>? BpfNeighGlobalMax { get; set; }

        [Input("bpfPolicyMapMax")]
        public Input<int>? BpfPolicyMapMax { get; set; }

        [Input("bpfctGlobalAnyMax")]
        public Input<int>? BpfctGlobalAnyMax { get; set; }

        [Input("bpfctGlobalTcpMax")]
        public Input<int>? BpfctGlobalTcpMax { get; set; }

        [Input("bpflbAlgorithm")]
        public Input<string>? BpflbAlgorithm { get; set; }

        [Input("bpflbMaglevTableSize")]
        public Input<string>? BpflbMaglevTableSize { get; set; }

        [Input("bpflbMapMax")]
        public Input<int>? BpflbMapMax { get; set; }

        [Input("bpflbSockHostNsOnly")]
        public Input<bool>? BpflbSockHostNsOnly { get; set; }

        [Input("bpfnatGlobalMax")]
        public Input<int>? BpfnatGlobalMax { get; set; }

        [Input("chainingMode")]
        public Input<string>? ChainingMode { get; set; }

        [Input("clusterName")]
        public Input<string>? ClusterName { get; set; }

        [Input("cpuRequest")]
        public Input<string>? CpuRequest { get; set; }

        [Input("debug")]
        public Input<bool>? Debug { get; set; }

        [Input("disableCnpStatusUpdates")]
        public Input<bool>? DisableCnpStatusUpdates { get; set; }

        [Input("disableEndpointCrd")]
        public Input<bool>? DisableEndpointCrd { get; set; }

        [Input("enableBpfMasquerade")]
        public Input<bool>? EnableBpfMasquerade { get; set; }

        [Input("enableEncryption")]
        public Input<bool>? EnableEncryption { get; set; }

        [Input("enableEndpointHealthChecking")]
        public Input<bool>? EnableEndpointHealthChecking { get; set; }

        [Input("enableHostReachableServices")]
        public Input<bool>? EnableHostReachableServices { get; set; }

        [Input("enableL7Proxy")]
        public Input<bool>? EnableL7Proxy { get; set; }

        [Input("enableNodePort")]
        public Input<bool>? EnableNodePort { get; set; }

        [Input("enablePolicy")]
        public Input<string>? EnablePolicy { get; set; }

        [Input("enablePrometheusMetrics")]
        public Input<bool>? EnablePrometheusMetrics { get; set; }

        [Input("enableRemoteNodeIdentity", required: true)]
        public Input<bool> EnableRemoteNodeIdentity { get; set; } = null!;

        [Input("enableServiceTopology")]
        public Input<bool>? EnableServiceTopology { get; set; }

        [Input("encryptionType")]
        public Input<string>? EncryptionType { get; set; }

        [Input("etcdManaged")]
        public Input<bool>? EtcdManaged { get; set; }

        [Input("hubble")]
        public Input<Inputs.ClusterNetworkingCiliumHubbleGetArgs>? Hubble { get; set; }

        [Input("identityAllocationMode")]
        public Input<string>? IdentityAllocationMode { get; set; }

        [Input("identityChangeGracePeriod")]
        public Input<string>? IdentityChangeGracePeriod { get; set; }

        [Input("installIptablesRules")]
        public Input<bool>? InstallIptablesRules { get; set; }

        [Input("ipam")]
        public Input<string>? Ipam { get; set; }

        [Input("masquerade")]
        public Input<bool>? Masquerade { get; set; }

        [Input("memoryRequest")]
        public Input<string>? MemoryRequest { get; set; }

        [Input("metrics")]
        private InputList<string>? _metrics;
        public InputList<string> Metrics
        {
            get => _metrics ?? (_metrics = new InputList<string>());
            set => _metrics = value;
        }

        [Input("monitorAggregation")]
        public Input<string>? MonitorAggregation { get; set; }

        [Input("preallocateBpfMaps", required: true)]
        public Input<bool> PreallocateBpfMaps { get; set; } = null!;

        [Input("sidecarIstioProxyImage")]
        public Input<string>? SidecarIstioProxyImage { get; set; }

        [Input("toFqdnsDnsRejectResponseCode")]
        public Input<string>? ToFqdnsDnsRejectResponseCode { get; set; }

        [Input("toFqdnsEnablePoller")]
        public Input<bool>? ToFqdnsEnablePoller { get; set; }

        [Input("tunnel")]
        public Input<string>? Tunnel { get; set; }

        [Input("version")]
        public Input<string>? Version { get; set; }

        public ClusterNetworkingCiliumGetArgs()
        {
        }
        public static new ClusterNetworkingCiliumGetArgs Empty => new ClusterNetworkingCiliumGetArgs();
    }
}
