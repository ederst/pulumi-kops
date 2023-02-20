// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterKubeletArgs : global::Pulumi.ResourceArgs
    {
        [Input("allowPrivileged")]
        public Input<bool>? AllowPrivileged { get; set; }

        [Input("allowedUnsafeSysctls")]
        private InputList<string>? _allowedUnsafeSysctls;
        public InputList<string> AllowedUnsafeSysctls
        {
            get => _allowedUnsafeSysctls ?? (_allowedUnsafeSysctls = new InputList<string>());
            set => _allowedUnsafeSysctls = value;
        }

        [Input("anonymousAuth")]
        public Input<Inputs.ClusterKubeletAnonymousAuthArgs>? AnonymousAuth { get; set; }

        [Input("apiServers")]
        public Input<string>? ApiServers { get; set; }

        [Input("authenticationTokenWebhook")]
        public Input<bool>? AuthenticationTokenWebhook { get; set; }

        [Input("authenticationTokenWebhookCacheTtl")]
        public Input<string>? AuthenticationTokenWebhookCacheTtl { get; set; }

        [Input("authorizationMode")]
        public Input<string>? AuthorizationMode { get; set; }

        [Input("babysitDaemons")]
        public Input<bool>? BabysitDaemons { get; set; }

        [Input("bootstrapKubeconfig")]
        public Input<string>? BootstrapKubeconfig { get; set; }

        [Input("cgroupDriver")]
        public Input<string>? CgroupDriver { get; set; }

        [Input("cgroupRoot")]
        public Input<string>? CgroupRoot { get; set; }

        [Input("clientCaFile")]
        public Input<string>? ClientCaFile { get; set; }

        /// <summary>
        /// - cloud_provider_spec - CloudProvider configures the cloud provider to use.
        /// </summary>
        [Input("cloudProvider")]
        public Input<string>? CloudProvider { get; set; }

        [Input("clusterDns")]
        public Input<string>? ClusterDns { get; set; }

        [Input("clusterDomain")]
        public Input<string>? ClusterDomain { get; set; }

        [Input("configureCbr0")]
        public Input<bool>? ConfigureCbr0 { get; set; }

        [Input("containerLogMaxFiles")]
        public Input<int>? ContainerLogMaxFiles { get; set; }

        [Input("containerLogMaxSize")]
        public Input<string>? ContainerLogMaxSize { get; set; }

        [Input("cpuCfsQuota")]
        public Input<Inputs.ClusterKubeletCpuCfsQuotaArgs>? CpuCfsQuota { get; set; }

        [Input("cpuCfsQuotaPeriod")]
        public Input<string>? CpuCfsQuotaPeriod { get; set; }

        [Input("cpuManagerPolicy")]
        public Input<string>? CpuManagerPolicy { get; set; }

        [Input("dockerDisableSharedPid")]
        public Input<bool>? DockerDisableSharedPid { get; set; }

        [Input("enableCadvisorJsonEndpoints")]
        public Input<bool>? EnableCadvisorJsonEndpoints { get; set; }

        [Input("enableCustomMetrics")]
        public Input<bool>? EnableCustomMetrics { get; set; }

        [Input("enableDebuggingHandlers")]
        public Input<bool>? EnableDebuggingHandlers { get; set; }

        [Input("enforceNodeAllocatable")]
        public Input<string>? EnforceNodeAllocatable { get; set; }

        [Input("eventBurst")]
        public Input<int>? EventBurst { get; set; }

        [Input("eventQps")]
        public Input<int>? EventQps { get; set; }

        [Input("evictionHard")]
        public Input<string>? EvictionHard { get; set; }

        [Input("evictionMaxPodGracePeriod")]
        public Input<int>? EvictionMaxPodGracePeriod { get; set; }

        [Input("evictionMinimumReclaim")]
        public Input<string>? EvictionMinimumReclaim { get; set; }

        [Input("evictionPressureTransitionPeriod")]
        public Input<string>? EvictionPressureTransitionPeriod { get; set; }

        [Input("evictionSoft")]
        public Input<string>? EvictionSoft { get; set; }

        [Input("evictionSoftGracePeriod")]
        public Input<string>? EvictionSoftGracePeriod { get; set; }

        [Input("experimentalAllowedUnsafeSysctls")]
        private InputList<string>? _experimentalAllowedUnsafeSysctls;
        public InputList<string> ExperimentalAllowedUnsafeSysctls
        {
            get => _experimentalAllowedUnsafeSysctls ?? (_experimentalAllowedUnsafeSysctls = new InputList<string>());
            set => _experimentalAllowedUnsafeSysctls = value;
        }

        [Input("failSwapOn")]
        public Input<bool>? FailSwapOn { get; set; }

        [Input("featureGates")]
        private InputMap<string>? _featureGates;
        public InputMap<string> FeatureGates
        {
            get => _featureGates ?? (_featureGates = new InputMap<string>());
            set => _featureGates = value;
        }

        [Input("hairpinMode")]
        public Input<string>? HairpinMode { get; set; }

        [Input("hostnameOverride")]
        public Input<string>? HostnameOverride { get; set; }

        [Input("housekeepingInterval")]
        public Input<string>? HousekeepingInterval { get; set; }

        [Input("imageGcHighThresholdPercent")]
        public Input<int>? ImageGcHighThresholdPercent { get; set; }

        [Input("imageGcLowThresholdPercent")]
        public Input<int>? ImageGcLowThresholdPercent { get; set; }

        [Input("imagePullProgressDeadline")]
        public Input<string>? ImagePullProgressDeadline { get; set; }

        [Input("kernelMemcgNotification")]
        public Input<bool>? KernelMemcgNotification { get; set; }

        [Input("kubeReserved")]
        private InputMap<string>? _kubeReserved;
        public InputMap<string> KubeReserved
        {
            get => _kubeReserved ?? (_kubeReserved = new InputMap<string>());
            set => _kubeReserved = value;
        }

        [Input("kubeReservedCgroup")]
        public Input<string>? KubeReservedCgroup { get; set; }

        [Input("kubeconfigPath")]
        public Input<string>? KubeconfigPath { get; set; }

        [Input("kubeletCgroups")]
        public Input<string>? KubeletCgroups { get; set; }

        [Input("logFormat")]
        public Input<string>? LogFormat { get; set; }

        [Input("logLevel")]
        public Input<int>? LogLevel { get; set; }

        [Input("maxPods")]
        public Input<int>? MaxPods { get; set; }

        [Input("networkPluginMtu")]
        public Input<int>? NetworkPluginMtu { get; set; }

        [Input("networkPluginName")]
        public Input<string>? NetworkPluginName { get; set; }

        [Input("nodeLabels")]
        private InputMap<string>? _nodeLabels;
        public InputMap<string> NodeLabels
        {
            get => _nodeLabels ?? (_nodeLabels = new InputMap<string>());
            set => _nodeLabels = value;
        }

        [Input("nodeStatusUpdateFrequency")]
        public Input<string>? NodeStatusUpdateFrequency { get; set; }

        /// <summary>
        /// - (Computed) - String - NonMasqueradeCIDR is the CIDR for the internal k8s network (on which pods &amp; services live)&lt;br /&gt;It cannot overlap ServiceClusterIPRange.
        /// </summary>
        [Input("nonMasqueradeCidr")]
        public Input<string>? NonMasqueradeCidr { get; set; }

        [Input("nvidiaGpUs")]
        public Input<int>? NvidiaGpUs { get; set; }

        /// <summary>
        /// - String - PodCIDR is the CIDR from which we allocate IPs for pods.
        /// </summary>
        [Input("podCidr")]
        public Input<string>? PodCidr { get; set; }

        [Input("podInfraContainerImage")]
        public Input<string>? PodInfraContainerImage { get; set; }

        [Input("podManifestPath")]
        public Input<string>? PodManifestPath { get; set; }

        [Input("podPidsLimit")]
        public Input<int>? PodPidsLimit { get; set; }

        [Input("protectKernelDefaults")]
        public Input<bool>? ProtectKernelDefaults { get; set; }

        [Input("readOnlyPort")]
        public Input<int>? ReadOnlyPort { get; set; }

        [Input("reconcileCidr")]
        public Input<bool>? ReconcileCidr { get; set; }

        [Input("registerNode")]
        public Input<bool>? RegisterNode { get; set; }

        [Input("registerSchedulable")]
        public Input<bool>? RegisterSchedulable { get; set; }

        [Input("registryBurst")]
        public Input<int>? RegistryBurst { get; set; }

        [Input("registryPullQps")]
        public Input<int>? RegistryPullQps { get; set; }

        [Input("requireKubeconfig")]
        public Input<bool>? RequireKubeconfig { get; set; }

        [Input("resolverConfig")]
        public Input<string>? ResolverConfig { get; set; }

        [Input("rootDir")]
        public Input<string>? RootDir { get; set; }

        [Input("rotateCertificates")]
        public Input<bool>? RotateCertificates { get; set; }

        [Input("runtimeCgroups")]
        public Input<string>? RuntimeCgroups { get; set; }

        [Input("runtimeRequestTimeout")]
        public Input<string>? RuntimeRequestTimeout { get; set; }

        [Input("seccompProfileRoot")]
        public Input<string>? SeccompProfileRoot { get; set; }

        [Input("serializeImagePulls")]
        public Input<bool>? SerializeImagePulls { get; set; }

        [Input("shutdownGracePeriod")]
        public Input<string>? ShutdownGracePeriod { get; set; }

        [Input("shutdownGracePeriodCriticalPods")]
        public Input<string>? ShutdownGracePeriodCriticalPods { get; set; }

        [Input("streamingConnectionIdleTimeout")]
        public Input<string>? StreamingConnectionIdleTimeout { get; set; }

        [Input("systemCgroups")]
        public Input<string>? SystemCgroups { get; set; }

        [Input("systemReserved")]
        private InputMap<string>? _systemReserved;
        public InputMap<string> SystemReserved
        {
            get => _systemReserved ?? (_systemReserved = new InputMap<string>());
            set => _systemReserved = value;
        }

        [Input("systemReservedCgroup")]
        public Input<string>? SystemReservedCgroup { get; set; }

        [Input("taints")]
        private InputList<string>? _taints;
        public InputList<string> Taints
        {
            get => _taints ?? (_taints = new InputList<string>());
            set => _taints = value;
        }

        [Input("tlsCertFile")]
        public Input<string>? TlsCertFile { get; set; }

        [Input("tlsCipherSuites")]
        private InputList<string>? _tlsCipherSuites;
        public InputList<string> TlsCipherSuites
        {
            get => _tlsCipherSuites ?? (_tlsCipherSuites = new InputList<string>());
            set => _tlsCipherSuites = value;
        }

        [Input("tlsMinVersion")]
        public Input<string>? TlsMinVersion { get; set; }

        [Input("tlsPrivateKeyFile")]
        public Input<string>? TlsPrivateKeyFile { get; set; }

        [Input("topologyManagerPolicy")]
        public Input<string>? TopologyManagerPolicy { get; set; }

        [Input("volumePluginDirectory")]
        public Input<string>? VolumePluginDirectory { get; set; }

        [Input("volumeStatsAggPeriod")]
        public Input<string>? VolumeStatsAggPeriod { get; set; }

        public ClusterKubeletArgs()
        {
        }
        public static new ClusterKubeletArgs Empty => new ClusterKubeletArgs();
    }
}