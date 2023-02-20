// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package kops

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupInstanceGroup(ctx *pulumi.Context, args *LookupInstanceGroupArgs, opts ...pulumi.InvokeOption) (*LookupInstanceGroupResult, error) {
	var rv LookupInstanceGroupResult
	err := ctx.Invoke("kops:index/getInstanceGroup:getInstanceGroup", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getInstanceGroup.
type LookupInstanceGroupArgs struct {
	// - String - ClusterName defines the cluster name the instance group belongs to.
	ClusterName string `pulumi:"clusterName"`
	// - String - Name defines the instance group name.
	Name string `pulumi:"name"`
}

// A collection of values returned by getInstanceGroup.
type LookupInstanceGroupResult struct {
	AdditionalSecurityGroups   []string                               `pulumi:"additionalSecurityGroups"`
	AdditionalUserDatas        []GetInstanceGroupAdditionalUserData   `pulumi:"additionalUserDatas"`
	Annotations                map[string]string                      `pulumi:"annotations"`
	AssociatePublicIp          bool                                   `pulumi:"associatePublicIp"`
	Autoscale                  bool                                   `pulumi:"autoscale"`
	CloudLabels                map[string]string                      `pulumi:"cloudLabels"`
	ClusterName                string                                 `pulumi:"clusterName"`
	CompressUserData           bool                                   `pulumi:"compressUserData"`
	Containerds                []GetInstanceGroupContainerd           `pulumi:"containerds"`
	CpuCredits                 string                                 `pulumi:"cpuCredits"`
	DetailedInstanceMonitoring bool                                   `pulumi:"detailedInstanceMonitoring"`
	ExternalLoadBalancers      []GetInstanceGroupExternalLoadBalancer `pulumi:"externalLoadBalancers"`
	FileAssets                 []GetInstanceGroupFileAsset            `pulumi:"fileAssets"`
	GcpProvisioningModel       string                                 `pulumi:"gcpProvisioningModel"`
	GuestAccelerators          []GetInstanceGroupGuestAccelerator     `pulumi:"guestAccelerators"`
	Hooks                      []GetInstanceGroupHook                 `pulumi:"hooks"`
	Iams                       []GetInstanceGroupIam                  `pulumi:"iams"`
	// The provider-assigned unique ID for this managed resource.
	Id                           string                                 `pulumi:"id"`
	Image                        string                                 `pulumi:"image"`
	InstanceInterruptionBehavior string                                 `pulumi:"instanceInterruptionBehavior"`
	InstanceMetadatas            []GetInstanceGroupInstanceMetadata     `pulumi:"instanceMetadatas"`
	InstanceProtection           bool                                   `pulumi:"instanceProtection"`
	Kubelets                     []GetInstanceGroupKubelet              `pulumi:"kubelets"`
	Labels                       map[string]string                      `pulumi:"labels"`
	MachineType                  string                                 `pulumi:"machineType"`
	Manager                      string                                 `pulumi:"manager"`
	MaxInstanceLifetime          string                                 `pulumi:"maxInstanceLifetime"`
	MaxPrice                     string                                 `pulumi:"maxPrice"`
	MaxSize                      int                                    `pulumi:"maxSize"`
	MinSize                      int                                    `pulumi:"minSize"`
	MixedInstancesPolicies       []GetInstanceGroupMixedInstancesPolicy `pulumi:"mixedInstancesPolicies"`
	Name                         string                                 `pulumi:"name"`
	NodeLabels                   map[string]string                      `pulumi:"nodeLabels"`
	Packages                     []string                               `pulumi:"packages"`
	Role                         string                                 `pulumi:"role"`
	RollingUpdates               []GetInstanceGroupRollingUpdate        `pulumi:"rollingUpdates"`
	RootVolumeEncryption         bool                                   `pulumi:"rootVolumeEncryption"`
	RootVolumeEncryptionKey      string                                 `pulumi:"rootVolumeEncryptionKey"`
	RootVolumeIops               int                                    `pulumi:"rootVolumeIops"`
	RootVolumeOptimization       bool                                   `pulumi:"rootVolumeOptimization"`
	RootVolumeSize               int                                    `pulumi:"rootVolumeSize"`
	RootVolumeThroughput         int                                    `pulumi:"rootVolumeThroughput"`
	RootVolumeType               string                                 `pulumi:"rootVolumeType"`
	SecurityGroupOverride        string                                 `pulumi:"securityGroupOverride"`
	SpotDurationInMinutes        int                                    `pulumi:"spotDurationInMinutes"`
	Subnets                      []string                               `pulumi:"subnets"`
	SuspendProcesses             []string                               `pulumi:"suspendProcesses"`
	SysctlParameters             []string                               `pulumi:"sysctlParameters"`
	Taints                       []string                               `pulumi:"taints"`
	Tenancy                      string                                 `pulumi:"tenancy"`
	UpdatePolicy                 string                                 `pulumi:"updatePolicy"`
	VolumeMounts                 []GetInstanceGroupVolumeMount          `pulumi:"volumeMounts"`
	Volumes                      []GetInstanceGroupVolume               `pulumi:"volumes"`
	WarmPools                    []GetInstanceGroupWarmPool             `pulumi:"warmPools"`
	Zones                        []string                               `pulumi:"zones"`
}

func LookupInstanceGroupOutput(ctx *pulumi.Context, args LookupInstanceGroupOutputArgs, opts ...pulumi.InvokeOption) LookupInstanceGroupResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupInstanceGroupResult, error) {
			args := v.(LookupInstanceGroupArgs)
			r, err := LookupInstanceGroup(ctx, &args, opts...)
			var s LookupInstanceGroupResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupInstanceGroupResultOutput)
}

// A collection of arguments for invoking getInstanceGroup.
type LookupInstanceGroupOutputArgs struct {
	// - String - ClusterName defines the cluster name the instance group belongs to.
	ClusterName pulumi.StringInput `pulumi:"clusterName"`
	// - String - Name defines the instance group name.
	Name pulumi.StringInput `pulumi:"name"`
}

func (LookupInstanceGroupOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupInstanceGroupArgs)(nil)).Elem()
}

// A collection of values returned by getInstanceGroup.
type LookupInstanceGroupResultOutput struct{ *pulumi.OutputState }

func (LookupInstanceGroupResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupInstanceGroupResult)(nil)).Elem()
}

func (o LookupInstanceGroupResultOutput) ToLookupInstanceGroupResultOutput() LookupInstanceGroupResultOutput {
	return o
}

func (o LookupInstanceGroupResultOutput) ToLookupInstanceGroupResultOutputWithContext(ctx context.Context) LookupInstanceGroupResultOutput {
	return o
}

func (o LookupInstanceGroupResultOutput) AdditionalSecurityGroups() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) []string { return v.AdditionalSecurityGroups }).(pulumi.StringArrayOutput)
}

func (o LookupInstanceGroupResultOutput) AdditionalUserDatas() GetInstanceGroupAdditionalUserDataArrayOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) []GetInstanceGroupAdditionalUserData { return v.AdditionalUserDatas }).(GetInstanceGroupAdditionalUserDataArrayOutput)
}

func (o LookupInstanceGroupResultOutput) Annotations() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) map[string]string { return v.Annotations }).(pulumi.StringMapOutput)
}

func (o LookupInstanceGroupResultOutput) AssociatePublicIp() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) bool { return v.AssociatePublicIp }).(pulumi.BoolOutput)
}

func (o LookupInstanceGroupResultOutput) Autoscale() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) bool { return v.Autoscale }).(pulumi.BoolOutput)
}

func (o LookupInstanceGroupResultOutput) CloudLabels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) map[string]string { return v.CloudLabels }).(pulumi.StringMapOutput)
}

func (o LookupInstanceGroupResultOutput) ClusterName() pulumi.StringOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) string { return v.ClusterName }).(pulumi.StringOutput)
}

func (o LookupInstanceGroupResultOutput) CompressUserData() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) bool { return v.CompressUserData }).(pulumi.BoolOutput)
}

func (o LookupInstanceGroupResultOutput) Containerds() GetInstanceGroupContainerdArrayOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) []GetInstanceGroupContainerd { return v.Containerds }).(GetInstanceGroupContainerdArrayOutput)
}

func (o LookupInstanceGroupResultOutput) CpuCredits() pulumi.StringOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) string { return v.CpuCredits }).(pulumi.StringOutput)
}

func (o LookupInstanceGroupResultOutput) DetailedInstanceMonitoring() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) bool { return v.DetailedInstanceMonitoring }).(pulumi.BoolOutput)
}

func (o LookupInstanceGroupResultOutput) ExternalLoadBalancers() GetInstanceGroupExternalLoadBalancerArrayOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) []GetInstanceGroupExternalLoadBalancer {
		return v.ExternalLoadBalancers
	}).(GetInstanceGroupExternalLoadBalancerArrayOutput)
}

func (o LookupInstanceGroupResultOutput) FileAssets() GetInstanceGroupFileAssetArrayOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) []GetInstanceGroupFileAsset { return v.FileAssets }).(GetInstanceGroupFileAssetArrayOutput)
}

func (o LookupInstanceGroupResultOutput) GcpProvisioningModel() pulumi.StringOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) string { return v.GcpProvisioningModel }).(pulumi.StringOutput)
}

func (o LookupInstanceGroupResultOutput) GuestAccelerators() GetInstanceGroupGuestAcceleratorArrayOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) []GetInstanceGroupGuestAccelerator { return v.GuestAccelerators }).(GetInstanceGroupGuestAcceleratorArrayOutput)
}

func (o LookupInstanceGroupResultOutput) Hooks() GetInstanceGroupHookArrayOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) []GetInstanceGroupHook { return v.Hooks }).(GetInstanceGroupHookArrayOutput)
}

func (o LookupInstanceGroupResultOutput) Iams() GetInstanceGroupIamArrayOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) []GetInstanceGroupIam { return v.Iams }).(GetInstanceGroupIamArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupInstanceGroupResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupInstanceGroupResultOutput) Image() pulumi.StringOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) string { return v.Image }).(pulumi.StringOutput)
}

func (o LookupInstanceGroupResultOutput) InstanceInterruptionBehavior() pulumi.StringOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) string { return v.InstanceInterruptionBehavior }).(pulumi.StringOutput)
}

func (o LookupInstanceGroupResultOutput) InstanceMetadatas() GetInstanceGroupInstanceMetadataArrayOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) []GetInstanceGroupInstanceMetadata { return v.InstanceMetadatas }).(GetInstanceGroupInstanceMetadataArrayOutput)
}

func (o LookupInstanceGroupResultOutput) InstanceProtection() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) bool { return v.InstanceProtection }).(pulumi.BoolOutput)
}

func (o LookupInstanceGroupResultOutput) Kubelets() GetInstanceGroupKubeletArrayOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) []GetInstanceGroupKubelet { return v.Kubelets }).(GetInstanceGroupKubeletArrayOutput)
}

func (o LookupInstanceGroupResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

func (o LookupInstanceGroupResultOutput) MachineType() pulumi.StringOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) string { return v.MachineType }).(pulumi.StringOutput)
}

func (o LookupInstanceGroupResultOutput) Manager() pulumi.StringOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) string { return v.Manager }).(pulumi.StringOutput)
}

func (o LookupInstanceGroupResultOutput) MaxInstanceLifetime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) string { return v.MaxInstanceLifetime }).(pulumi.StringOutput)
}

func (o LookupInstanceGroupResultOutput) MaxPrice() pulumi.StringOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) string { return v.MaxPrice }).(pulumi.StringOutput)
}

func (o LookupInstanceGroupResultOutput) MaxSize() pulumi.IntOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) int { return v.MaxSize }).(pulumi.IntOutput)
}

func (o LookupInstanceGroupResultOutput) MinSize() pulumi.IntOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) int { return v.MinSize }).(pulumi.IntOutput)
}

func (o LookupInstanceGroupResultOutput) MixedInstancesPolicies() GetInstanceGroupMixedInstancesPolicyArrayOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) []GetInstanceGroupMixedInstancesPolicy {
		return v.MixedInstancesPolicies
	}).(GetInstanceGroupMixedInstancesPolicyArrayOutput)
}

func (o LookupInstanceGroupResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupInstanceGroupResultOutput) NodeLabels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) map[string]string { return v.NodeLabels }).(pulumi.StringMapOutput)
}

func (o LookupInstanceGroupResultOutput) Packages() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) []string { return v.Packages }).(pulumi.StringArrayOutput)
}

func (o LookupInstanceGroupResultOutput) Role() pulumi.StringOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) string { return v.Role }).(pulumi.StringOutput)
}

func (o LookupInstanceGroupResultOutput) RollingUpdates() GetInstanceGroupRollingUpdateArrayOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) []GetInstanceGroupRollingUpdate { return v.RollingUpdates }).(GetInstanceGroupRollingUpdateArrayOutput)
}

func (o LookupInstanceGroupResultOutput) RootVolumeEncryption() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) bool { return v.RootVolumeEncryption }).(pulumi.BoolOutput)
}

func (o LookupInstanceGroupResultOutput) RootVolumeEncryptionKey() pulumi.StringOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) string { return v.RootVolumeEncryptionKey }).(pulumi.StringOutput)
}

func (o LookupInstanceGroupResultOutput) RootVolumeIops() pulumi.IntOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) int { return v.RootVolumeIops }).(pulumi.IntOutput)
}

func (o LookupInstanceGroupResultOutput) RootVolumeOptimization() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) bool { return v.RootVolumeOptimization }).(pulumi.BoolOutput)
}

func (o LookupInstanceGroupResultOutput) RootVolumeSize() pulumi.IntOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) int { return v.RootVolumeSize }).(pulumi.IntOutput)
}

func (o LookupInstanceGroupResultOutput) RootVolumeThroughput() pulumi.IntOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) int { return v.RootVolumeThroughput }).(pulumi.IntOutput)
}

func (o LookupInstanceGroupResultOutput) RootVolumeType() pulumi.StringOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) string { return v.RootVolumeType }).(pulumi.StringOutput)
}

func (o LookupInstanceGroupResultOutput) SecurityGroupOverride() pulumi.StringOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) string { return v.SecurityGroupOverride }).(pulumi.StringOutput)
}

func (o LookupInstanceGroupResultOutput) SpotDurationInMinutes() pulumi.IntOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) int { return v.SpotDurationInMinutes }).(pulumi.IntOutput)
}

func (o LookupInstanceGroupResultOutput) Subnets() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) []string { return v.Subnets }).(pulumi.StringArrayOutput)
}

func (o LookupInstanceGroupResultOutput) SuspendProcesses() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) []string { return v.SuspendProcesses }).(pulumi.StringArrayOutput)
}

func (o LookupInstanceGroupResultOutput) SysctlParameters() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) []string { return v.SysctlParameters }).(pulumi.StringArrayOutput)
}

func (o LookupInstanceGroupResultOutput) Taints() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) []string { return v.Taints }).(pulumi.StringArrayOutput)
}

func (o LookupInstanceGroupResultOutput) Tenancy() pulumi.StringOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) string { return v.Tenancy }).(pulumi.StringOutput)
}

func (o LookupInstanceGroupResultOutput) UpdatePolicy() pulumi.StringOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) string { return v.UpdatePolicy }).(pulumi.StringOutput)
}

func (o LookupInstanceGroupResultOutput) VolumeMounts() GetInstanceGroupVolumeMountArrayOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) []GetInstanceGroupVolumeMount { return v.VolumeMounts }).(GetInstanceGroupVolumeMountArrayOutput)
}

func (o LookupInstanceGroupResultOutput) Volumes() GetInstanceGroupVolumeArrayOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) []GetInstanceGroupVolume { return v.Volumes }).(GetInstanceGroupVolumeArrayOutput)
}

func (o LookupInstanceGroupResultOutput) WarmPools() GetInstanceGroupWarmPoolArrayOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) []GetInstanceGroupWarmPool { return v.WarmPools }).(GetInstanceGroupWarmPoolArrayOutput)
}

func (o LookupInstanceGroupResultOutput) Zones() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupInstanceGroupResult) []string { return v.Zones }).(pulumi.StringArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupInstanceGroupResultOutput{})
}
