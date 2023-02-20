// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package config

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type Aws struct {
	AccessKey       *string        `pulumi:"accessKey"`
	AssumeRole      *AwsAssumeRole `pulumi:"assumeRole"`
	Profile         *string        `pulumi:"profile"`
	Region          *string        `pulumi:"region"`
	S3AccessKey     *string        `pulumi:"s3AccessKey"`
	S3Endpoint      *string        `pulumi:"s3Endpoint"`
	S3Region        *string        `pulumi:"s3Region"`
	S3SecretKey     *string        `pulumi:"s3SecretKey"`
	SecretKey       *string        `pulumi:"secretKey"`
	SkipRegionCheck *bool          `pulumi:"skipRegionCheck"`
}

// AwsInput is an input type that accepts AwsArgs and AwsOutput values.
// You can construct a concrete instance of `AwsInput` via:
//
//	AwsArgs{...}
type AwsInput interface {
	pulumi.Input

	ToAwsOutput() AwsOutput
	ToAwsOutputWithContext(context.Context) AwsOutput
}

type AwsArgs struct {
	AccessKey       pulumi.StringPtrInput `pulumi:"accessKey"`
	AssumeRole      AwsAssumeRolePtrInput `pulumi:"assumeRole"`
	Profile         pulumi.StringPtrInput `pulumi:"profile"`
	Region          pulumi.StringPtrInput `pulumi:"region"`
	S3AccessKey     pulumi.StringPtrInput `pulumi:"s3AccessKey"`
	S3Endpoint      pulumi.StringPtrInput `pulumi:"s3Endpoint"`
	S3Region        pulumi.StringPtrInput `pulumi:"s3Region"`
	S3SecretKey     pulumi.StringPtrInput `pulumi:"s3SecretKey"`
	SecretKey       pulumi.StringPtrInput `pulumi:"secretKey"`
	SkipRegionCheck pulumi.BoolPtrInput   `pulumi:"skipRegionCheck"`
}

func (AwsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*Aws)(nil)).Elem()
}

func (i AwsArgs) ToAwsOutput() AwsOutput {
	return i.ToAwsOutputWithContext(context.Background())
}

func (i AwsArgs) ToAwsOutputWithContext(ctx context.Context) AwsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AwsOutput)
}

type AwsOutput struct{ *pulumi.OutputState }

func (AwsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Aws)(nil)).Elem()
}

func (o AwsOutput) ToAwsOutput() AwsOutput {
	return o
}

func (o AwsOutput) ToAwsOutputWithContext(ctx context.Context) AwsOutput {
	return o
}

func (o AwsOutput) AccessKey() pulumi.StringPtrOutput {
	return o.ApplyT(func(v Aws) *string { return v.AccessKey }).(pulumi.StringPtrOutput)
}

func (o AwsOutput) AssumeRole() AwsAssumeRolePtrOutput {
	return o.ApplyT(func(v Aws) *AwsAssumeRole { return v.AssumeRole }).(AwsAssumeRolePtrOutput)
}

func (o AwsOutput) Profile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v Aws) *string { return v.Profile }).(pulumi.StringPtrOutput)
}

func (o AwsOutput) Region() pulumi.StringPtrOutput {
	return o.ApplyT(func(v Aws) *string { return v.Region }).(pulumi.StringPtrOutput)
}

func (o AwsOutput) S3AccessKey() pulumi.StringPtrOutput {
	return o.ApplyT(func(v Aws) *string { return v.S3AccessKey }).(pulumi.StringPtrOutput)
}

func (o AwsOutput) S3Endpoint() pulumi.StringPtrOutput {
	return o.ApplyT(func(v Aws) *string { return v.S3Endpoint }).(pulumi.StringPtrOutput)
}

func (o AwsOutput) S3Region() pulumi.StringPtrOutput {
	return o.ApplyT(func(v Aws) *string { return v.S3Region }).(pulumi.StringPtrOutput)
}

func (o AwsOutput) S3SecretKey() pulumi.StringPtrOutput {
	return o.ApplyT(func(v Aws) *string { return v.S3SecretKey }).(pulumi.StringPtrOutput)
}

func (o AwsOutput) SecretKey() pulumi.StringPtrOutput {
	return o.ApplyT(func(v Aws) *string { return v.SecretKey }).(pulumi.StringPtrOutput)
}

func (o AwsOutput) SkipRegionCheck() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v Aws) *bool { return v.SkipRegionCheck }).(pulumi.BoolPtrOutput)
}

type AwsAssumeRole struct {
	RoleArn *string `pulumi:"roleArn"`
}

// AwsAssumeRoleInput is an input type that accepts AwsAssumeRoleArgs and AwsAssumeRoleOutput values.
// You can construct a concrete instance of `AwsAssumeRoleInput` via:
//
//	AwsAssumeRoleArgs{...}
type AwsAssumeRoleInput interface {
	pulumi.Input

	ToAwsAssumeRoleOutput() AwsAssumeRoleOutput
	ToAwsAssumeRoleOutputWithContext(context.Context) AwsAssumeRoleOutput
}

type AwsAssumeRoleArgs struct {
	RoleArn pulumi.StringPtrInput `pulumi:"roleArn"`
}

func (AwsAssumeRoleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*AwsAssumeRole)(nil)).Elem()
}

func (i AwsAssumeRoleArgs) ToAwsAssumeRoleOutput() AwsAssumeRoleOutput {
	return i.ToAwsAssumeRoleOutputWithContext(context.Background())
}

func (i AwsAssumeRoleArgs) ToAwsAssumeRoleOutputWithContext(ctx context.Context) AwsAssumeRoleOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AwsAssumeRoleOutput)
}

func (i AwsAssumeRoleArgs) ToAwsAssumeRolePtrOutput() AwsAssumeRolePtrOutput {
	return i.ToAwsAssumeRolePtrOutputWithContext(context.Background())
}

func (i AwsAssumeRoleArgs) ToAwsAssumeRolePtrOutputWithContext(ctx context.Context) AwsAssumeRolePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AwsAssumeRoleOutput).ToAwsAssumeRolePtrOutputWithContext(ctx)
}

// AwsAssumeRolePtrInput is an input type that accepts AwsAssumeRoleArgs, AwsAssumeRolePtr and AwsAssumeRolePtrOutput values.
// You can construct a concrete instance of `AwsAssumeRolePtrInput` via:
//
//	        AwsAssumeRoleArgs{...}
//
//	or:
//
//	        nil
type AwsAssumeRolePtrInput interface {
	pulumi.Input

	ToAwsAssumeRolePtrOutput() AwsAssumeRolePtrOutput
	ToAwsAssumeRolePtrOutputWithContext(context.Context) AwsAssumeRolePtrOutput
}

type awsAssumeRolePtrType AwsAssumeRoleArgs

func AwsAssumeRolePtr(v *AwsAssumeRoleArgs) AwsAssumeRolePtrInput {
	return (*awsAssumeRolePtrType)(v)
}

func (*awsAssumeRolePtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**AwsAssumeRole)(nil)).Elem()
}

func (i *awsAssumeRolePtrType) ToAwsAssumeRolePtrOutput() AwsAssumeRolePtrOutput {
	return i.ToAwsAssumeRolePtrOutputWithContext(context.Background())
}

func (i *awsAssumeRolePtrType) ToAwsAssumeRolePtrOutputWithContext(ctx context.Context) AwsAssumeRolePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AwsAssumeRolePtrOutput)
}

type AwsAssumeRoleOutput struct{ *pulumi.OutputState }

func (AwsAssumeRoleOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*AwsAssumeRole)(nil)).Elem()
}

func (o AwsAssumeRoleOutput) ToAwsAssumeRoleOutput() AwsAssumeRoleOutput {
	return o
}

func (o AwsAssumeRoleOutput) ToAwsAssumeRoleOutputWithContext(ctx context.Context) AwsAssumeRoleOutput {
	return o
}

func (o AwsAssumeRoleOutput) ToAwsAssumeRolePtrOutput() AwsAssumeRolePtrOutput {
	return o.ToAwsAssumeRolePtrOutputWithContext(context.Background())
}

func (o AwsAssumeRoleOutput) ToAwsAssumeRolePtrOutputWithContext(ctx context.Context) AwsAssumeRolePtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v AwsAssumeRole) *AwsAssumeRole {
		return &v
	}).(AwsAssumeRolePtrOutput)
}

func (o AwsAssumeRoleOutput) RoleArn() pulumi.StringPtrOutput {
	return o.ApplyT(func(v AwsAssumeRole) *string { return v.RoleArn }).(pulumi.StringPtrOutput)
}

type AwsAssumeRolePtrOutput struct{ *pulumi.OutputState }

func (AwsAssumeRolePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AwsAssumeRole)(nil)).Elem()
}

func (o AwsAssumeRolePtrOutput) ToAwsAssumeRolePtrOutput() AwsAssumeRolePtrOutput {
	return o
}

func (o AwsAssumeRolePtrOutput) ToAwsAssumeRolePtrOutputWithContext(ctx context.Context) AwsAssumeRolePtrOutput {
	return o
}

func (o AwsAssumeRolePtrOutput) Elem() AwsAssumeRoleOutput {
	return o.ApplyT(func(v *AwsAssumeRole) AwsAssumeRole {
		if v != nil {
			return *v
		}
		var ret AwsAssumeRole
		return ret
	}).(AwsAssumeRoleOutput)
}

func (o AwsAssumeRolePtrOutput) RoleArn() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AwsAssumeRole) *string {
		if v == nil {
			return nil
		}
		return v.RoleArn
	}).(pulumi.StringPtrOutput)
}

type Klog struct {
	Verbosity *KlogVerbosity `pulumi:"verbosity"`
}

// KlogInput is an input type that accepts KlogArgs and KlogOutput values.
// You can construct a concrete instance of `KlogInput` via:
//
//	KlogArgs{...}
type KlogInput interface {
	pulumi.Input

	ToKlogOutput() KlogOutput
	ToKlogOutputWithContext(context.Context) KlogOutput
}

type KlogArgs struct {
	Verbosity KlogVerbosityPtrInput `pulumi:"verbosity"`
}

func (KlogArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*Klog)(nil)).Elem()
}

func (i KlogArgs) ToKlogOutput() KlogOutput {
	return i.ToKlogOutputWithContext(context.Background())
}

func (i KlogArgs) ToKlogOutputWithContext(ctx context.Context) KlogOutput {
	return pulumi.ToOutputWithContext(ctx, i).(KlogOutput)
}

type KlogOutput struct{ *pulumi.OutputState }

func (KlogOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Klog)(nil)).Elem()
}

func (o KlogOutput) ToKlogOutput() KlogOutput {
	return o
}

func (o KlogOutput) ToKlogOutputWithContext(ctx context.Context) KlogOutput {
	return o
}

func (o KlogOutput) Verbosity() KlogVerbosityPtrOutput {
	return o.ApplyT(func(v Klog) *KlogVerbosity { return v.Verbosity }).(KlogVerbosityPtrOutput)
}

type KlogVerbosity struct {
	Value *int `pulumi:"value"`
}

// KlogVerbosityInput is an input type that accepts KlogVerbosityArgs and KlogVerbosityOutput values.
// You can construct a concrete instance of `KlogVerbosityInput` via:
//
//	KlogVerbosityArgs{...}
type KlogVerbosityInput interface {
	pulumi.Input

	ToKlogVerbosityOutput() KlogVerbosityOutput
	ToKlogVerbosityOutputWithContext(context.Context) KlogVerbosityOutput
}

type KlogVerbosityArgs struct {
	Value pulumi.IntPtrInput `pulumi:"value"`
}

func (KlogVerbosityArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*KlogVerbosity)(nil)).Elem()
}

func (i KlogVerbosityArgs) ToKlogVerbosityOutput() KlogVerbosityOutput {
	return i.ToKlogVerbosityOutputWithContext(context.Background())
}

func (i KlogVerbosityArgs) ToKlogVerbosityOutputWithContext(ctx context.Context) KlogVerbosityOutput {
	return pulumi.ToOutputWithContext(ctx, i).(KlogVerbosityOutput)
}

func (i KlogVerbosityArgs) ToKlogVerbosityPtrOutput() KlogVerbosityPtrOutput {
	return i.ToKlogVerbosityPtrOutputWithContext(context.Background())
}

func (i KlogVerbosityArgs) ToKlogVerbosityPtrOutputWithContext(ctx context.Context) KlogVerbosityPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(KlogVerbosityOutput).ToKlogVerbosityPtrOutputWithContext(ctx)
}

// KlogVerbosityPtrInput is an input type that accepts KlogVerbosityArgs, KlogVerbosityPtr and KlogVerbosityPtrOutput values.
// You can construct a concrete instance of `KlogVerbosityPtrInput` via:
//
//	        KlogVerbosityArgs{...}
//
//	or:
//
//	        nil
type KlogVerbosityPtrInput interface {
	pulumi.Input

	ToKlogVerbosityPtrOutput() KlogVerbosityPtrOutput
	ToKlogVerbosityPtrOutputWithContext(context.Context) KlogVerbosityPtrOutput
}

type klogVerbosityPtrType KlogVerbosityArgs

func KlogVerbosityPtr(v *KlogVerbosityArgs) KlogVerbosityPtrInput {
	return (*klogVerbosityPtrType)(v)
}

func (*klogVerbosityPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**KlogVerbosity)(nil)).Elem()
}

func (i *klogVerbosityPtrType) ToKlogVerbosityPtrOutput() KlogVerbosityPtrOutput {
	return i.ToKlogVerbosityPtrOutputWithContext(context.Background())
}

func (i *klogVerbosityPtrType) ToKlogVerbosityPtrOutputWithContext(ctx context.Context) KlogVerbosityPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(KlogVerbosityPtrOutput)
}

type KlogVerbosityOutput struct{ *pulumi.OutputState }

func (KlogVerbosityOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*KlogVerbosity)(nil)).Elem()
}

func (o KlogVerbosityOutput) ToKlogVerbosityOutput() KlogVerbosityOutput {
	return o
}

func (o KlogVerbosityOutput) ToKlogVerbosityOutputWithContext(ctx context.Context) KlogVerbosityOutput {
	return o
}

func (o KlogVerbosityOutput) ToKlogVerbosityPtrOutput() KlogVerbosityPtrOutput {
	return o.ToKlogVerbosityPtrOutputWithContext(context.Background())
}

func (o KlogVerbosityOutput) ToKlogVerbosityPtrOutputWithContext(ctx context.Context) KlogVerbosityPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v KlogVerbosity) *KlogVerbosity {
		return &v
	}).(KlogVerbosityPtrOutput)
}

func (o KlogVerbosityOutput) Value() pulumi.IntPtrOutput {
	return o.ApplyT(func(v KlogVerbosity) *int { return v.Value }).(pulumi.IntPtrOutput)
}

type KlogVerbosityPtrOutput struct{ *pulumi.OutputState }

func (KlogVerbosityPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**KlogVerbosity)(nil)).Elem()
}

func (o KlogVerbosityPtrOutput) ToKlogVerbosityPtrOutput() KlogVerbosityPtrOutput {
	return o
}

func (o KlogVerbosityPtrOutput) ToKlogVerbosityPtrOutputWithContext(ctx context.Context) KlogVerbosityPtrOutput {
	return o
}

func (o KlogVerbosityPtrOutput) Elem() KlogVerbosityOutput {
	return o.ApplyT(func(v *KlogVerbosity) KlogVerbosity {
		if v != nil {
			return *v
		}
		var ret KlogVerbosity
		return ret
	}).(KlogVerbosityOutput)
}

func (o KlogVerbosityPtrOutput) Value() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *KlogVerbosity) *int {
		if v == nil {
			return nil
		}
		return v.Value
	}).(pulumi.IntPtrOutput)
}

type Openstack struct {
	ApplicationCredentialId     *string `pulumi:"applicationCredentialId"`
	ApplicationCredentialSecret *string `pulumi:"applicationCredentialSecret"`
	AuthUrl                     *string `pulumi:"authUrl"`
	DomainId                    *string `pulumi:"domainId"`
	DomainName                  *string `pulumi:"domainName"`
	Password                    *string `pulumi:"password"`
	ProjectDomainId             *string `pulumi:"projectDomainId"`
	ProjectDomainName           *string `pulumi:"projectDomainName"`
	ProjectId                   *string `pulumi:"projectId"`
	ProjectName                 *string `pulumi:"projectName"`
	RegionName                  *string `pulumi:"regionName"`
	TenantId                    *string `pulumi:"tenantId"`
	TenantName                  *string `pulumi:"tenantName"`
	Username                    *string `pulumi:"username"`
}

// OpenstackInput is an input type that accepts OpenstackArgs and OpenstackOutput values.
// You can construct a concrete instance of `OpenstackInput` via:
//
//	OpenstackArgs{...}
type OpenstackInput interface {
	pulumi.Input

	ToOpenstackOutput() OpenstackOutput
	ToOpenstackOutputWithContext(context.Context) OpenstackOutput
}

type OpenstackArgs struct {
	ApplicationCredentialId     pulumi.StringPtrInput `pulumi:"applicationCredentialId"`
	ApplicationCredentialSecret pulumi.StringPtrInput `pulumi:"applicationCredentialSecret"`
	AuthUrl                     pulumi.StringPtrInput `pulumi:"authUrl"`
	DomainId                    pulumi.StringPtrInput `pulumi:"domainId"`
	DomainName                  pulumi.StringPtrInput `pulumi:"domainName"`
	Password                    pulumi.StringPtrInput `pulumi:"password"`
	ProjectDomainId             pulumi.StringPtrInput `pulumi:"projectDomainId"`
	ProjectDomainName           pulumi.StringPtrInput `pulumi:"projectDomainName"`
	ProjectId                   pulumi.StringPtrInput `pulumi:"projectId"`
	ProjectName                 pulumi.StringPtrInput `pulumi:"projectName"`
	RegionName                  pulumi.StringPtrInput `pulumi:"regionName"`
	TenantId                    pulumi.StringPtrInput `pulumi:"tenantId"`
	TenantName                  pulumi.StringPtrInput `pulumi:"tenantName"`
	Username                    pulumi.StringPtrInput `pulumi:"username"`
}

func (OpenstackArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*Openstack)(nil)).Elem()
}

func (i OpenstackArgs) ToOpenstackOutput() OpenstackOutput {
	return i.ToOpenstackOutputWithContext(context.Background())
}

func (i OpenstackArgs) ToOpenstackOutputWithContext(ctx context.Context) OpenstackOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OpenstackOutput)
}

type OpenstackOutput struct{ *pulumi.OutputState }

func (OpenstackOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Openstack)(nil)).Elem()
}

func (o OpenstackOutput) ToOpenstackOutput() OpenstackOutput {
	return o
}

func (o OpenstackOutput) ToOpenstackOutputWithContext(ctx context.Context) OpenstackOutput {
	return o
}

func (o OpenstackOutput) ApplicationCredentialId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v Openstack) *string { return v.ApplicationCredentialId }).(pulumi.StringPtrOutput)
}

func (o OpenstackOutput) ApplicationCredentialSecret() pulumi.StringPtrOutput {
	return o.ApplyT(func(v Openstack) *string { return v.ApplicationCredentialSecret }).(pulumi.StringPtrOutput)
}

func (o OpenstackOutput) AuthUrl() pulumi.StringPtrOutput {
	return o.ApplyT(func(v Openstack) *string { return v.AuthUrl }).(pulumi.StringPtrOutput)
}

func (o OpenstackOutput) DomainId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v Openstack) *string { return v.DomainId }).(pulumi.StringPtrOutput)
}

func (o OpenstackOutput) DomainName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v Openstack) *string { return v.DomainName }).(pulumi.StringPtrOutput)
}

func (o OpenstackOutput) Password() pulumi.StringPtrOutput {
	return o.ApplyT(func(v Openstack) *string { return v.Password }).(pulumi.StringPtrOutput)
}

func (o OpenstackOutput) ProjectDomainId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v Openstack) *string { return v.ProjectDomainId }).(pulumi.StringPtrOutput)
}

func (o OpenstackOutput) ProjectDomainName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v Openstack) *string { return v.ProjectDomainName }).(pulumi.StringPtrOutput)
}

func (o OpenstackOutput) ProjectId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v Openstack) *string { return v.ProjectId }).(pulumi.StringPtrOutput)
}

func (o OpenstackOutput) ProjectName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v Openstack) *string { return v.ProjectName }).(pulumi.StringPtrOutput)
}

func (o OpenstackOutput) RegionName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v Openstack) *string { return v.RegionName }).(pulumi.StringPtrOutput)
}

func (o OpenstackOutput) TenantId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v Openstack) *string { return v.TenantId }).(pulumi.StringPtrOutput)
}

func (o OpenstackOutput) TenantName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v Openstack) *string { return v.TenantName }).(pulumi.StringPtrOutput)
}

func (o OpenstackOutput) Username() pulumi.StringPtrOutput {
	return o.ApplyT(func(v Openstack) *string { return v.Username }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AwsInput)(nil)).Elem(), AwsArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*AwsAssumeRoleInput)(nil)).Elem(), AwsAssumeRoleArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*AwsAssumeRolePtrInput)(nil)).Elem(), AwsAssumeRoleArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*KlogInput)(nil)).Elem(), KlogArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*KlogVerbosityInput)(nil)).Elem(), KlogVerbosityArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*KlogVerbosityPtrInput)(nil)).Elem(), KlogVerbosityArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*OpenstackInput)(nil)).Elem(), OpenstackArgs{})
	pulumi.RegisterOutputType(AwsOutput{})
	pulumi.RegisterOutputType(AwsAssumeRoleOutput{})
	pulumi.RegisterOutputType(AwsAssumeRolePtrOutput{})
	pulumi.RegisterOutputType(KlogOutput{})
	pulumi.RegisterOutputType(KlogVerbosityOutput{})
	pulumi.RegisterOutputType(KlogVerbosityPtrOutput{})
	pulumi.RegisterOutputType(OpenstackOutput{})
}