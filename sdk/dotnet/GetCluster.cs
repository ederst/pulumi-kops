// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops
{
    public static class GetCluster
    {
        public static Task<GetClusterResult> InvokeAsync(GetClusterArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetClusterResult>("kops:index/getCluster:getCluster", args ?? new GetClusterArgs(), options.WithDefaults());

        public static Output<GetClusterResult> Invoke(GetClusterInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetClusterResult>("kops:index/getCluster:getCluster", args ?? new GetClusterInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetClusterArgs : global::Pulumi.InvokeArgs
    {
        [Input("externalPolicies")]
        private List<Inputs.GetClusterExternalPolicyArgs>? _externalPolicies;

        /// <summary>
        /// - Map(List(String)) - ExternalPolicies allows the insertion of pre-existing managed policies on IG Roles.
        /// </summary>
        public List<Inputs.GetClusterExternalPolicyArgs> ExternalPolicies
        {
            get => _externalPolicies ?? (_externalPolicies = new List<Inputs.GetClusterExternalPolicyArgs>());
            set => _externalPolicies = value;
        }

        /// <summary>
        /// - String - Name defines the cluster name.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// - Bool(Nullable) - TagSubnets controls if tags are added to subnets to enable use by load balancers (AWS only). Default: true.
        /// </summary>
        [Input("tagSubnets")]
        public Inputs.GetClusterTagSubnetsArgs? TagSubnets { get; set; }

        public GetClusterArgs()
        {
        }
        public static new GetClusterArgs Empty => new GetClusterArgs();
    }

    public sealed class GetClusterInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("externalPolicies")]
        private InputList<Inputs.GetClusterExternalPolicyInputArgs>? _externalPolicies;

        /// <summary>
        /// - Map(List(String)) - ExternalPolicies allows the insertion of pre-existing managed policies on IG Roles.
        /// </summary>
        public InputList<Inputs.GetClusterExternalPolicyInputArgs> ExternalPolicies
        {
            get => _externalPolicies ?? (_externalPolicies = new InputList<Inputs.GetClusterExternalPolicyInputArgs>());
            set => _externalPolicies = value;
        }

        /// <summary>
        /// - String - Name defines the cluster name.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// - Bool(Nullable) - TagSubnets controls if tags are added to subnets to enable use by load balancers (AWS only). Default: true.
        /// </summary>
        [Input("tagSubnets")]
        public Input<Inputs.GetClusterTagSubnetsInputArgs>? TagSubnets { get; set; }

        public GetClusterInvokeArgs()
        {
        }
        public static new GetClusterInvokeArgs Empty => new GetClusterInvokeArgs();
    }


    [OutputType]
    public sealed class GetClusterResult
    {
        public readonly ImmutableArray<string> AdditionalNetworkCidrs;
        public readonly ImmutableDictionary<string, string> AdditionalPolicies;
        public readonly ImmutableArray<string> AdditionalSans;
        public readonly ImmutableArray<Outputs.GetClusterAddonResult> Addons;
        public readonly string AdminSshKey;
        public readonly ImmutableDictionary<string, string> Annotations;
        public readonly ImmutableArray<Outputs.GetClusterApiResult> Apis;
        public readonly ImmutableArray<Outputs.GetClusterAssetResult> Assets;
        public readonly ImmutableArray<Outputs.GetClusterAuthenticationResult> Authentications;
        public readonly ImmutableArray<Outputs.GetClusterAuthorizationResult> Authorizations;
        public readonly ImmutableArray<Outputs.GetClusterAwsLoadBalancerControllerResult> AwsLoadBalancerControllers;
        public readonly ImmutableArray<Outputs.GetClusterCertManagerResult> CertManagers;
        public readonly string Channel;
        public readonly ImmutableArray<Outputs.GetClusterCloudConfigResult> CloudConfigs;
        public readonly ImmutableDictionary<string, string> CloudLabels;
        public readonly ImmutableArray<Outputs.GetClusterCloudProviderResult> CloudProviders;
        public readonly ImmutableArray<Outputs.GetClusterClusterAutoscalerResult> ClusterAutoscalers;
        public readonly string ClusterDnsDomain;
        public readonly string ConfigBase;
        public readonly string ConfigStore;
        public readonly string ContainerRuntime;
        public readonly ImmutableArray<Outputs.GetClusterContainerdResult> Containerds;
        public readonly string DnsZone;
        public readonly ImmutableArray<Outputs.GetClusterDockerResult> Dockers;
        public readonly ImmutableArray<Outputs.GetClusterEgressProxyResult> EgressProxies;
        public readonly bool EncryptionConfig;
        public readonly ImmutableArray<Outputs.GetClusterEtcdClusterResult> EtcdClusters;
        public readonly ImmutableArray<Outputs.GetClusterExternalCloudControllerManagerResult> ExternalCloudControllerManagers;
        public readonly ImmutableArray<Outputs.GetClusterExternalDnResult> ExternalDns;
        public readonly ImmutableArray<Outputs.GetClusterExternalPolicyResult> ExternalPolicies;
        public readonly ImmutableArray<Outputs.GetClusterFileAssetResult> FileAssets;
        public readonly ImmutableArray<Outputs.GetClusterHookResult> Hooks;
        public readonly ImmutableArray<Outputs.GetClusterIamResult> Iams;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly bool IsolateMasters;
        public readonly ImmutableArray<Outputs.GetClusterKarpenterResult> Karpenters;
        public readonly string KeyStore;
        public readonly ImmutableArray<Outputs.GetClusterKubeApiServerResult> KubeApiServers;
        public readonly ImmutableArray<Outputs.GetClusterKubeControllerManagerResult> KubeControllerManagers;
        public readonly ImmutableArray<Outputs.GetClusterKubeDnResult> KubeDns;
        public readonly ImmutableArray<Outputs.GetClusterKubeProxyResult> KubeProxies;
        public readonly ImmutableArray<Outputs.GetClusterKubeSchedulerResult> KubeSchedulers;
        public readonly ImmutableArray<Outputs.GetClusterKubeletResult> Kubelets;
        public readonly ImmutableArray<string> KubernetesApiAccesses;
        public readonly string KubernetesVersion;
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly string MasterInternalName;
        public readonly ImmutableArray<Outputs.GetClusterMasterKubeletResult> MasterKubelets;
        public readonly string MasterPublicName;
        public readonly ImmutableArray<Outputs.GetClusterMetricsServerResult> MetricsServers;
        public readonly string Name;
        public readonly string NetworkCidr;
        public readonly string NetworkId;
        public readonly ImmutableArray<Outputs.GetClusterNetworkingResult> Networkings;
        public readonly ImmutableArray<Outputs.GetClusterNodeAuthorizationResult> NodeAuthorizations;
        public readonly ImmutableArray<string> NodePortAccesses;
        public readonly ImmutableArray<Outputs.GetClusterNodeProblemDetectorResult> NodeProblemDetectors;
        public readonly ImmutableArray<Outputs.GetClusterNodeTerminationHandlerResult> NodeTerminationHandlers;
        public readonly string NonMasqueradeCidr;
        public readonly ImmutableArray<Outputs.GetClusterNtpResult> Ntps;
        public readonly string PodCidr;
        public readonly ImmutableArray<Outputs.GetClusterPodIdentityWebhookResult> PodIdentityWebhooks;
        public readonly string Project;
        public readonly ImmutableArray<Outputs.GetClusterRollingUpdateResult> RollingUpdates;
        public readonly string SecretStore;
        public readonly ImmutableArray<Outputs.GetClusterSecretResult> Secrets;
        public readonly ImmutableArray<Outputs.GetClusterServiceAccountIssuerDiscoveryResult> ServiceAccountIssuerDiscoveries;
        public readonly string ServiceClusterIpRange;
        public readonly ImmutableArray<Outputs.GetClusterSnapshotControllerResult> SnapshotControllers;
        public readonly ImmutableArray<string> SshAccesses;
        public readonly string SshKeyName;
        public readonly ImmutableArray<Outputs.GetClusterSubnetResult> Subnets;
        public readonly ImmutableArray<string> SysctlParameters;
        public readonly Outputs.GetClusterTagSubnetsResult? TagSubnets;
        public readonly ImmutableArray<Outputs.GetClusterTopologyResult> Topologies;
        public readonly string UpdatePolicy;
        public readonly bool UseHostCertificates;
        public readonly ImmutableArray<Outputs.GetClusterWarmPoolResult> WarmPools;

        [OutputConstructor]
        private GetClusterResult(
            ImmutableArray<string> additionalNetworkCidrs,

            ImmutableDictionary<string, string> additionalPolicies,

            ImmutableArray<string> additionalSans,

            ImmutableArray<Outputs.GetClusterAddonResult> addons,

            string adminSshKey,

            ImmutableDictionary<string, string> annotations,

            ImmutableArray<Outputs.GetClusterApiResult> apis,

            ImmutableArray<Outputs.GetClusterAssetResult> assets,

            ImmutableArray<Outputs.GetClusterAuthenticationResult> authentications,

            ImmutableArray<Outputs.GetClusterAuthorizationResult> authorizations,

            ImmutableArray<Outputs.GetClusterAwsLoadBalancerControllerResult> awsLoadBalancerControllers,

            ImmutableArray<Outputs.GetClusterCertManagerResult> certManagers,

            string channel,

            ImmutableArray<Outputs.GetClusterCloudConfigResult> cloudConfigs,

            ImmutableDictionary<string, string> cloudLabels,

            ImmutableArray<Outputs.GetClusterCloudProviderResult> cloudProviders,

            ImmutableArray<Outputs.GetClusterClusterAutoscalerResult> clusterAutoscalers,

            string clusterDnsDomain,

            string configBase,

            string configStore,

            string containerRuntime,

            ImmutableArray<Outputs.GetClusterContainerdResult> containerds,

            string dnsZone,

            ImmutableArray<Outputs.GetClusterDockerResult> dockers,

            ImmutableArray<Outputs.GetClusterEgressProxyResult> egressProxies,

            bool encryptionConfig,

            ImmutableArray<Outputs.GetClusterEtcdClusterResult> etcdClusters,

            ImmutableArray<Outputs.GetClusterExternalCloudControllerManagerResult> externalCloudControllerManagers,

            ImmutableArray<Outputs.GetClusterExternalDnResult> externalDns,

            ImmutableArray<Outputs.GetClusterExternalPolicyResult> externalPolicies,

            ImmutableArray<Outputs.GetClusterFileAssetResult> fileAssets,

            ImmutableArray<Outputs.GetClusterHookResult> hooks,

            ImmutableArray<Outputs.GetClusterIamResult> iams,

            string id,

            bool isolateMasters,

            ImmutableArray<Outputs.GetClusterKarpenterResult> karpenters,

            string keyStore,

            ImmutableArray<Outputs.GetClusterKubeApiServerResult> kubeApiServers,

            ImmutableArray<Outputs.GetClusterKubeControllerManagerResult> kubeControllerManagers,

            ImmutableArray<Outputs.GetClusterKubeDnResult> kubeDns,

            ImmutableArray<Outputs.GetClusterKubeProxyResult> kubeProxies,

            ImmutableArray<Outputs.GetClusterKubeSchedulerResult> kubeSchedulers,

            ImmutableArray<Outputs.GetClusterKubeletResult> kubelets,

            ImmutableArray<string> kubernetesApiAccesses,

            string kubernetesVersion,

            ImmutableDictionary<string, string> labels,

            string masterInternalName,

            ImmutableArray<Outputs.GetClusterMasterKubeletResult> masterKubelets,

            string masterPublicName,

            ImmutableArray<Outputs.GetClusterMetricsServerResult> metricsServers,

            string name,

            string networkCidr,

            string networkId,

            ImmutableArray<Outputs.GetClusterNetworkingResult> networkings,

            ImmutableArray<Outputs.GetClusterNodeAuthorizationResult> nodeAuthorizations,

            ImmutableArray<string> nodePortAccesses,

            ImmutableArray<Outputs.GetClusterNodeProblemDetectorResult> nodeProblemDetectors,

            ImmutableArray<Outputs.GetClusterNodeTerminationHandlerResult> nodeTerminationHandlers,

            string nonMasqueradeCidr,

            ImmutableArray<Outputs.GetClusterNtpResult> ntps,

            string podCidr,

            ImmutableArray<Outputs.GetClusterPodIdentityWebhookResult> podIdentityWebhooks,

            string project,

            ImmutableArray<Outputs.GetClusterRollingUpdateResult> rollingUpdates,

            string secretStore,

            ImmutableArray<Outputs.GetClusterSecretResult> secrets,

            ImmutableArray<Outputs.GetClusterServiceAccountIssuerDiscoveryResult> serviceAccountIssuerDiscoveries,

            string serviceClusterIpRange,

            ImmutableArray<Outputs.GetClusterSnapshotControllerResult> snapshotControllers,

            ImmutableArray<string> sshAccesses,

            string sshKeyName,

            ImmutableArray<Outputs.GetClusterSubnetResult> subnets,

            ImmutableArray<string> sysctlParameters,

            Outputs.GetClusterTagSubnetsResult? tagSubnets,

            ImmutableArray<Outputs.GetClusterTopologyResult> topologies,

            string updatePolicy,

            bool useHostCertificates,

            ImmutableArray<Outputs.GetClusterWarmPoolResult> warmPools)
        {
            AdditionalNetworkCidrs = additionalNetworkCidrs;
            AdditionalPolicies = additionalPolicies;
            AdditionalSans = additionalSans;
            Addons = addons;
            AdminSshKey = adminSshKey;
            Annotations = annotations;
            Apis = apis;
            Assets = assets;
            Authentications = authentications;
            Authorizations = authorizations;
            AwsLoadBalancerControllers = awsLoadBalancerControllers;
            CertManagers = certManagers;
            Channel = channel;
            CloudConfigs = cloudConfigs;
            CloudLabels = cloudLabels;
            CloudProviders = cloudProviders;
            ClusterAutoscalers = clusterAutoscalers;
            ClusterDnsDomain = clusterDnsDomain;
            ConfigBase = configBase;
            ConfigStore = configStore;
            ContainerRuntime = containerRuntime;
            Containerds = containerds;
            DnsZone = dnsZone;
            Dockers = dockers;
            EgressProxies = egressProxies;
            EncryptionConfig = encryptionConfig;
            EtcdClusters = etcdClusters;
            ExternalCloudControllerManagers = externalCloudControllerManagers;
            ExternalDns = externalDns;
            ExternalPolicies = externalPolicies;
            FileAssets = fileAssets;
            Hooks = hooks;
            Iams = iams;
            Id = id;
            IsolateMasters = isolateMasters;
            Karpenters = karpenters;
            KeyStore = keyStore;
            KubeApiServers = kubeApiServers;
            KubeControllerManagers = kubeControllerManagers;
            KubeDns = kubeDns;
            KubeProxies = kubeProxies;
            KubeSchedulers = kubeSchedulers;
            Kubelets = kubelets;
            KubernetesApiAccesses = kubernetesApiAccesses;
            KubernetesVersion = kubernetesVersion;
            Labels = labels;
            MasterInternalName = masterInternalName;
            MasterKubelets = masterKubelets;
            MasterPublicName = masterPublicName;
            MetricsServers = metricsServers;
            Name = name;
            NetworkCidr = networkCidr;
            NetworkId = networkId;
            Networkings = networkings;
            NodeAuthorizations = nodeAuthorizations;
            NodePortAccesses = nodePortAccesses;
            NodeProblemDetectors = nodeProblemDetectors;
            NodeTerminationHandlers = nodeTerminationHandlers;
            NonMasqueradeCidr = nonMasqueradeCidr;
            Ntps = ntps;
            PodCidr = podCidr;
            PodIdentityWebhooks = podIdentityWebhooks;
            Project = project;
            RollingUpdates = rollingUpdates;
            SecretStore = secretStore;
            Secrets = secrets;
            ServiceAccountIssuerDiscoveries = serviceAccountIssuerDiscoveries;
            ServiceClusterIpRange = serviceClusterIpRange;
            SnapshotControllers = snapshotControllers;
            SshAccesses = sshAccesses;
            SshKeyName = sshKeyName;
            Subnets = subnets;
            SysctlParameters = sysctlParameters;
            TagSubnets = tagSubnets;
            Topologies = topologies;
            UpdatePolicy = updatePolicy;
            UseHostCertificates = useHostCertificates;
            WarmPools = warmPools;
        }
    }
}
