// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package kops

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupCluster(ctx *pulumi.Context, args *LookupClusterArgs, opts ...pulumi.InvokeOption) (*LookupClusterResult, error) {
	var rv LookupClusterResult
	err := ctx.Invoke("kops:index/getCluster:getCluster", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getCluster.
type LookupClusterArgs struct {
	// - Map(List(String)) - ExternalPolicies allows the insertion of pre-existing managed policies on IG Roles.
	ExternalPolicies []GetClusterExternalPolicy `pulumi:"externalPolicies"`
	// - String - Name defines the cluster name.
	Name string `pulumi:"name"`
	// - Bool(Nullable) - TagSubnets controls if tags are added to subnets to enable use by load balancers (AWS only). Default: true.
	TagSubnets *GetClusterTagSubnets `pulumi:"tagSubnets"`
}

// A collection of values returned by getCluster.
type LookupClusterResult struct {
	AdditionalNetworkCidrs          []string                                   `pulumi:"additionalNetworkCidrs"`
	AdditionalPolicies              map[string]string                          `pulumi:"additionalPolicies"`
	AdditionalSans                  []string                                   `pulumi:"additionalSans"`
	Addons                          []GetClusterAddon                          `pulumi:"addons"`
	AdminSshKey                     string                                     `pulumi:"adminSshKey"`
	Annotations                     map[string]string                          `pulumi:"annotations"`
	Apis                            []GetClusterApi                            `pulumi:"apis"`
	Assets                          []GetClusterAsset                          `pulumi:"assets"`
	Authentications                 []GetClusterAuthentication                 `pulumi:"authentications"`
	Authorizations                  []GetClusterAuthorization                  `pulumi:"authorizations"`
	AwsLoadBalancerControllers      []GetClusterAwsLoadBalancerController      `pulumi:"awsLoadBalancerControllers"`
	CertManagers                    []GetClusterCertManager                    `pulumi:"certManagers"`
	Channel                         string                                     `pulumi:"channel"`
	CloudConfigs                    []GetClusterCloudConfig                    `pulumi:"cloudConfigs"`
	CloudLabels                     map[string]string                          `pulumi:"cloudLabels"`
	CloudProviders                  []GetClusterCloudProvider                  `pulumi:"cloudProviders"`
	ClusterAutoscalers              []GetClusterClusterAutoscaler              `pulumi:"clusterAutoscalers"`
	ClusterDnsDomain                string                                     `pulumi:"clusterDnsDomain"`
	ConfigBase                      string                                     `pulumi:"configBase"`
	ConfigStore                     string                                     `pulumi:"configStore"`
	ContainerRuntime                string                                     `pulumi:"containerRuntime"`
	Containerds                     []GetClusterContainerd                     `pulumi:"containerds"`
	DnsZone                         string                                     `pulumi:"dnsZone"`
	Dockers                         []GetClusterDocker                         `pulumi:"dockers"`
	EgressProxies                   []GetClusterEgressProxy                    `pulumi:"egressProxies"`
	EncryptionConfig                bool                                       `pulumi:"encryptionConfig"`
	EtcdClusters                    []GetClusterEtcdCluster                    `pulumi:"etcdClusters"`
	ExternalCloudControllerManagers []GetClusterExternalCloudControllerManager `pulumi:"externalCloudControllerManagers"`
	ExternalDns                     []GetClusterExternalDn                     `pulumi:"externalDns"`
	ExternalPolicies                []GetClusterExternalPolicy                 `pulumi:"externalPolicies"`
	FileAssets                      []GetClusterFileAsset                      `pulumi:"fileAssets"`
	Hooks                           []GetClusterHook                           `pulumi:"hooks"`
	Iams                            []GetClusterIam                            `pulumi:"iams"`
	// The provider-assigned unique ID for this managed resource.
	Id                              string                                    `pulumi:"id"`
	IsolateMasters                  bool                                      `pulumi:"isolateMasters"`
	Karpenters                      []GetClusterKarpenter                     `pulumi:"karpenters"`
	KeyStore                        string                                    `pulumi:"keyStore"`
	KubeApiServers                  []GetClusterKubeApiServer                 `pulumi:"kubeApiServers"`
	KubeControllerManagers          []GetClusterKubeControllerManager         `pulumi:"kubeControllerManagers"`
	KubeDns                         []GetClusterKubeDn                        `pulumi:"kubeDns"`
	KubeProxies                     []GetClusterKubeProxy                     `pulumi:"kubeProxies"`
	KubeSchedulers                  []GetClusterKubeScheduler                 `pulumi:"kubeSchedulers"`
	Kubelets                        []GetClusterKubelet                       `pulumi:"kubelets"`
	KubernetesApiAccesses           []string                                  `pulumi:"kubernetesApiAccesses"`
	KubernetesVersion               string                                    `pulumi:"kubernetesVersion"`
	Labels                          map[string]string                         `pulumi:"labels"`
	MasterInternalName              string                                    `pulumi:"masterInternalName"`
	MasterKubelets                  []GetClusterMasterKubelet                 `pulumi:"masterKubelets"`
	MasterPublicName                string                                    `pulumi:"masterPublicName"`
	MetricsServers                  []GetClusterMetricsServer                 `pulumi:"metricsServers"`
	Name                            string                                    `pulumi:"name"`
	NetworkCidr                     string                                    `pulumi:"networkCidr"`
	NetworkId                       string                                    `pulumi:"networkId"`
	Networkings                     []GetClusterNetworking                    `pulumi:"networkings"`
	NodeAuthorizations              []GetClusterNodeAuthorization             `pulumi:"nodeAuthorizations"`
	NodePortAccesses                []string                                  `pulumi:"nodePortAccesses"`
	NodeProblemDetectors            []GetClusterNodeProblemDetector           `pulumi:"nodeProblemDetectors"`
	NodeTerminationHandlers         []GetClusterNodeTerminationHandler        `pulumi:"nodeTerminationHandlers"`
	NonMasqueradeCidr               string                                    `pulumi:"nonMasqueradeCidr"`
	Ntps                            []GetClusterNtp                           `pulumi:"ntps"`
	PodCidr                         string                                    `pulumi:"podCidr"`
	PodIdentityWebhooks             []GetClusterPodIdentityWebhook            `pulumi:"podIdentityWebhooks"`
	Project                         string                                    `pulumi:"project"`
	RollingUpdates                  []GetClusterRollingUpdate                 `pulumi:"rollingUpdates"`
	SecretStore                     string                                    `pulumi:"secretStore"`
	Secrets                         []GetClusterSecret                        `pulumi:"secrets"`
	ServiceAccountIssuerDiscoveries []GetClusterServiceAccountIssuerDiscovery `pulumi:"serviceAccountIssuerDiscoveries"`
	ServiceClusterIpRange           string                                    `pulumi:"serviceClusterIpRange"`
	SnapshotControllers             []GetClusterSnapshotController            `pulumi:"snapshotControllers"`
	SshAccesses                     []string                                  `pulumi:"sshAccesses"`
	SshKeyName                      string                                    `pulumi:"sshKeyName"`
	Subnets                         []GetClusterSubnet                        `pulumi:"subnets"`
	SysctlParameters                []string                                  `pulumi:"sysctlParameters"`
	TagSubnets                      *GetClusterTagSubnets                     `pulumi:"tagSubnets"`
	Topologies                      []GetClusterTopology                      `pulumi:"topologies"`
	UpdatePolicy                    string                                    `pulumi:"updatePolicy"`
	UseHostCertificates             bool                                      `pulumi:"useHostCertificates"`
	WarmPools                       []GetClusterWarmPool                      `pulumi:"warmPools"`
}

func LookupClusterOutput(ctx *pulumi.Context, args LookupClusterOutputArgs, opts ...pulumi.InvokeOption) LookupClusterResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupClusterResult, error) {
			args := v.(LookupClusterArgs)
			r, err := LookupCluster(ctx, &args, opts...)
			var s LookupClusterResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupClusterResultOutput)
}

// A collection of arguments for invoking getCluster.
type LookupClusterOutputArgs struct {
	// - Map(List(String)) - ExternalPolicies allows the insertion of pre-existing managed policies on IG Roles.
	ExternalPolicies GetClusterExternalPolicyArrayInput `pulumi:"externalPolicies"`
	// - String - Name defines the cluster name.
	Name pulumi.StringInput `pulumi:"name"`
	// - Bool(Nullable) - TagSubnets controls if tags are added to subnets to enable use by load balancers (AWS only). Default: true.
	TagSubnets GetClusterTagSubnetsPtrInput `pulumi:"tagSubnets"`
}

func (LookupClusterOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupClusterArgs)(nil)).Elem()
}

// A collection of values returned by getCluster.
type LookupClusterResultOutput struct{ *pulumi.OutputState }

func (LookupClusterResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupClusterResult)(nil)).Elem()
}

func (o LookupClusterResultOutput) ToLookupClusterResultOutput() LookupClusterResultOutput {
	return o
}

func (o LookupClusterResultOutput) ToLookupClusterResultOutputWithContext(ctx context.Context) LookupClusterResultOutput {
	return o
}

func (o LookupClusterResultOutput) AdditionalNetworkCidrs() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []string { return v.AdditionalNetworkCidrs }).(pulumi.StringArrayOutput)
}

func (o LookupClusterResultOutput) AdditionalPolicies() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupClusterResult) map[string]string { return v.AdditionalPolicies }).(pulumi.StringMapOutput)
}

func (o LookupClusterResultOutput) AdditionalSans() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []string { return v.AdditionalSans }).(pulumi.StringArrayOutput)
}

func (o LookupClusterResultOutput) Addons() GetClusterAddonArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterAddon { return v.Addons }).(GetClusterAddonArrayOutput)
}

func (o LookupClusterResultOutput) AdminSshKey() pulumi.StringOutput {
	return o.ApplyT(func(v LookupClusterResult) string { return v.AdminSshKey }).(pulumi.StringOutput)
}

func (o LookupClusterResultOutput) Annotations() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupClusterResult) map[string]string { return v.Annotations }).(pulumi.StringMapOutput)
}

func (o LookupClusterResultOutput) Apis() GetClusterApiArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterApi { return v.Apis }).(GetClusterApiArrayOutput)
}

func (o LookupClusterResultOutput) Assets() GetClusterAssetArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterAsset { return v.Assets }).(GetClusterAssetArrayOutput)
}

func (o LookupClusterResultOutput) Authentications() GetClusterAuthenticationArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterAuthentication { return v.Authentications }).(GetClusterAuthenticationArrayOutput)
}

func (o LookupClusterResultOutput) Authorizations() GetClusterAuthorizationArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterAuthorization { return v.Authorizations }).(GetClusterAuthorizationArrayOutput)
}

func (o LookupClusterResultOutput) AwsLoadBalancerControllers() GetClusterAwsLoadBalancerControllerArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterAwsLoadBalancerController { return v.AwsLoadBalancerControllers }).(GetClusterAwsLoadBalancerControllerArrayOutput)
}

func (o LookupClusterResultOutput) CertManagers() GetClusterCertManagerArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterCertManager { return v.CertManagers }).(GetClusterCertManagerArrayOutput)
}

func (o LookupClusterResultOutput) Channel() pulumi.StringOutput {
	return o.ApplyT(func(v LookupClusterResult) string { return v.Channel }).(pulumi.StringOutput)
}

func (o LookupClusterResultOutput) CloudConfigs() GetClusterCloudConfigArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterCloudConfig { return v.CloudConfigs }).(GetClusterCloudConfigArrayOutput)
}

func (o LookupClusterResultOutput) CloudLabels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupClusterResult) map[string]string { return v.CloudLabels }).(pulumi.StringMapOutput)
}

func (o LookupClusterResultOutput) CloudProviders() GetClusterCloudProviderArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterCloudProvider { return v.CloudProviders }).(GetClusterCloudProviderArrayOutput)
}

func (o LookupClusterResultOutput) ClusterAutoscalers() GetClusterClusterAutoscalerArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterClusterAutoscaler { return v.ClusterAutoscalers }).(GetClusterClusterAutoscalerArrayOutput)
}

func (o LookupClusterResultOutput) ClusterDnsDomain() pulumi.StringOutput {
	return o.ApplyT(func(v LookupClusterResult) string { return v.ClusterDnsDomain }).(pulumi.StringOutput)
}

func (o LookupClusterResultOutput) ConfigBase() pulumi.StringOutput {
	return o.ApplyT(func(v LookupClusterResult) string { return v.ConfigBase }).(pulumi.StringOutput)
}

func (o LookupClusterResultOutput) ConfigStore() pulumi.StringOutput {
	return o.ApplyT(func(v LookupClusterResult) string { return v.ConfigStore }).(pulumi.StringOutput)
}

func (o LookupClusterResultOutput) ContainerRuntime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupClusterResult) string { return v.ContainerRuntime }).(pulumi.StringOutput)
}

func (o LookupClusterResultOutput) Containerds() GetClusterContainerdArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterContainerd { return v.Containerds }).(GetClusterContainerdArrayOutput)
}

func (o LookupClusterResultOutput) DnsZone() pulumi.StringOutput {
	return o.ApplyT(func(v LookupClusterResult) string { return v.DnsZone }).(pulumi.StringOutput)
}

func (o LookupClusterResultOutput) Dockers() GetClusterDockerArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterDocker { return v.Dockers }).(GetClusterDockerArrayOutput)
}

func (o LookupClusterResultOutput) EgressProxies() GetClusterEgressProxyArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterEgressProxy { return v.EgressProxies }).(GetClusterEgressProxyArrayOutput)
}

func (o LookupClusterResultOutput) EncryptionConfig() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupClusterResult) bool { return v.EncryptionConfig }).(pulumi.BoolOutput)
}

func (o LookupClusterResultOutput) EtcdClusters() GetClusterEtcdClusterArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterEtcdCluster { return v.EtcdClusters }).(GetClusterEtcdClusterArrayOutput)
}

func (o LookupClusterResultOutput) ExternalCloudControllerManagers() GetClusterExternalCloudControllerManagerArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterExternalCloudControllerManager {
		return v.ExternalCloudControllerManagers
	}).(GetClusterExternalCloudControllerManagerArrayOutput)
}

func (o LookupClusterResultOutput) ExternalDns() GetClusterExternalDnArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterExternalDn { return v.ExternalDns }).(GetClusterExternalDnArrayOutput)
}

func (o LookupClusterResultOutput) ExternalPolicies() GetClusterExternalPolicyArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterExternalPolicy { return v.ExternalPolicies }).(GetClusterExternalPolicyArrayOutput)
}

func (o LookupClusterResultOutput) FileAssets() GetClusterFileAssetArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterFileAsset { return v.FileAssets }).(GetClusterFileAssetArrayOutput)
}

func (o LookupClusterResultOutput) Hooks() GetClusterHookArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterHook { return v.Hooks }).(GetClusterHookArrayOutput)
}

func (o LookupClusterResultOutput) Iams() GetClusterIamArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterIam { return v.Iams }).(GetClusterIamArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupClusterResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupClusterResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupClusterResultOutput) IsolateMasters() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupClusterResult) bool { return v.IsolateMasters }).(pulumi.BoolOutput)
}

func (o LookupClusterResultOutput) Karpenters() GetClusterKarpenterArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterKarpenter { return v.Karpenters }).(GetClusterKarpenterArrayOutput)
}

func (o LookupClusterResultOutput) KeyStore() pulumi.StringOutput {
	return o.ApplyT(func(v LookupClusterResult) string { return v.KeyStore }).(pulumi.StringOutput)
}

func (o LookupClusterResultOutput) KubeApiServers() GetClusterKubeApiServerArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterKubeApiServer { return v.KubeApiServers }).(GetClusterKubeApiServerArrayOutput)
}

func (o LookupClusterResultOutput) KubeControllerManagers() GetClusterKubeControllerManagerArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterKubeControllerManager { return v.KubeControllerManagers }).(GetClusterKubeControllerManagerArrayOutput)
}

func (o LookupClusterResultOutput) KubeDns() GetClusterKubeDnArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterKubeDn { return v.KubeDns }).(GetClusterKubeDnArrayOutput)
}

func (o LookupClusterResultOutput) KubeProxies() GetClusterKubeProxyArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterKubeProxy { return v.KubeProxies }).(GetClusterKubeProxyArrayOutput)
}

func (o LookupClusterResultOutput) KubeSchedulers() GetClusterKubeSchedulerArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterKubeScheduler { return v.KubeSchedulers }).(GetClusterKubeSchedulerArrayOutput)
}

func (o LookupClusterResultOutput) Kubelets() GetClusterKubeletArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterKubelet { return v.Kubelets }).(GetClusterKubeletArrayOutput)
}

func (o LookupClusterResultOutput) KubernetesApiAccesses() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []string { return v.KubernetesApiAccesses }).(pulumi.StringArrayOutput)
}

func (o LookupClusterResultOutput) KubernetesVersion() pulumi.StringOutput {
	return o.ApplyT(func(v LookupClusterResult) string { return v.KubernetesVersion }).(pulumi.StringOutput)
}

func (o LookupClusterResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupClusterResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

func (o LookupClusterResultOutput) MasterInternalName() pulumi.StringOutput {
	return o.ApplyT(func(v LookupClusterResult) string { return v.MasterInternalName }).(pulumi.StringOutput)
}

func (o LookupClusterResultOutput) MasterKubelets() GetClusterMasterKubeletArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterMasterKubelet { return v.MasterKubelets }).(GetClusterMasterKubeletArrayOutput)
}

func (o LookupClusterResultOutput) MasterPublicName() pulumi.StringOutput {
	return o.ApplyT(func(v LookupClusterResult) string { return v.MasterPublicName }).(pulumi.StringOutput)
}

func (o LookupClusterResultOutput) MetricsServers() GetClusterMetricsServerArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterMetricsServer { return v.MetricsServers }).(GetClusterMetricsServerArrayOutput)
}

func (o LookupClusterResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupClusterResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupClusterResultOutput) NetworkCidr() pulumi.StringOutput {
	return o.ApplyT(func(v LookupClusterResult) string { return v.NetworkCidr }).(pulumi.StringOutput)
}

func (o LookupClusterResultOutput) NetworkId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupClusterResult) string { return v.NetworkId }).(pulumi.StringOutput)
}

func (o LookupClusterResultOutput) Networkings() GetClusterNetworkingArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterNetworking { return v.Networkings }).(GetClusterNetworkingArrayOutput)
}

func (o LookupClusterResultOutput) NodeAuthorizations() GetClusterNodeAuthorizationArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterNodeAuthorization { return v.NodeAuthorizations }).(GetClusterNodeAuthorizationArrayOutput)
}

func (o LookupClusterResultOutput) NodePortAccesses() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []string { return v.NodePortAccesses }).(pulumi.StringArrayOutput)
}

func (o LookupClusterResultOutput) NodeProblemDetectors() GetClusterNodeProblemDetectorArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterNodeProblemDetector { return v.NodeProblemDetectors }).(GetClusterNodeProblemDetectorArrayOutput)
}

func (o LookupClusterResultOutput) NodeTerminationHandlers() GetClusterNodeTerminationHandlerArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterNodeTerminationHandler { return v.NodeTerminationHandlers }).(GetClusterNodeTerminationHandlerArrayOutput)
}

func (o LookupClusterResultOutput) NonMasqueradeCidr() pulumi.StringOutput {
	return o.ApplyT(func(v LookupClusterResult) string { return v.NonMasqueradeCidr }).(pulumi.StringOutput)
}

func (o LookupClusterResultOutput) Ntps() GetClusterNtpArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterNtp { return v.Ntps }).(GetClusterNtpArrayOutput)
}

func (o LookupClusterResultOutput) PodCidr() pulumi.StringOutput {
	return o.ApplyT(func(v LookupClusterResult) string { return v.PodCidr }).(pulumi.StringOutput)
}

func (o LookupClusterResultOutput) PodIdentityWebhooks() GetClusterPodIdentityWebhookArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterPodIdentityWebhook { return v.PodIdentityWebhooks }).(GetClusterPodIdentityWebhookArrayOutput)
}

func (o LookupClusterResultOutput) Project() pulumi.StringOutput {
	return o.ApplyT(func(v LookupClusterResult) string { return v.Project }).(pulumi.StringOutput)
}

func (o LookupClusterResultOutput) RollingUpdates() GetClusterRollingUpdateArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterRollingUpdate { return v.RollingUpdates }).(GetClusterRollingUpdateArrayOutput)
}

func (o LookupClusterResultOutput) SecretStore() pulumi.StringOutput {
	return o.ApplyT(func(v LookupClusterResult) string { return v.SecretStore }).(pulumi.StringOutput)
}

func (o LookupClusterResultOutput) Secrets() GetClusterSecretArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterSecret { return v.Secrets }).(GetClusterSecretArrayOutput)
}

func (o LookupClusterResultOutput) ServiceAccountIssuerDiscoveries() GetClusterServiceAccountIssuerDiscoveryArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterServiceAccountIssuerDiscovery {
		return v.ServiceAccountIssuerDiscoveries
	}).(GetClusterServiceAccountIssuerDiscoveryArrayOutput)
}

func (o LookupClusterResultOutput) ServiceClusterIpRange() pulumi.StringOutput {
	return o.ApplyT(func(v LookupClusterResult) string { return v.ServiceClusterIpRange }).(pulumi.StringOutput)
}

func (o LookupClusterResultOutput) SnapshotControllers() GetClusterSnapshotControllerArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterSnapshotController { return v.SnapshotControllers }).(GetClusterSnapshotControllerArrayOutput)
}

func (o LookupClusterResultOutput) SshAccesses() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []string { return v.SshAccesses }).(pulumi.StringArrayOutput)
}

func (o LookupClusterResultOutput) SshKeyName() pulumi.StringOutput {
	return o.ApplyT(func(v LookupClusterResult) string { return v.SshKeyName }).(pulumi.StringOutput)
}

func (o LookupClusterResultOutput) Subnets() GetClusterSubnetArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterSubnet { return v.Subnets }).(GetClusterSubnetArrayOutput)
}

func (o LookupClusterResultOutput) SysctlParameters() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []string { return v.SysctlParameters }).(pulumi.StringArrayOutput)
}

func (o LookupClusterResultOutput) TagSubnets() GetClusterTagSubnetsPtrOutput {
	return o.ApplyT(func(v LookupClusterResult) *GetClusterTagSubnets { return v.TagSubnets }).(GetClusterTagSubnetsPtrOutput)
}

func (o LookupClusterResultOutput) Topologies() GetClusterTopologyArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterTopology { return v.Topologies }).(GetClusterTopologyArrayOutput)
}

func (o LookupClusterResultOutput) UpdatePolicy() pulumi.StringOutput {
	return o.ApplyT(func(v LookupClusterResult) string { return v.UpdatePolicy }).(pulumi.StringOutput)
}

func (o LookupClusterResultOutput) UseHostCertificates() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupClusterResult) bool { return v.UseHostCertificates }).(pulumi.BoolOutput)
}

func (o LookupClusterResultOutput) WarmPools() GetClusterWarmPoolArrayOutput {
	return o.ApplyT(func(v LookupClusterResult) []GetClusterWarmPool { return v.WarmPools }).(GetClusterWarmPoolArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupClusterResultOutput{})
}
