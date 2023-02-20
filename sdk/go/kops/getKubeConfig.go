// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package kops

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// ## # getKubeConfig
//
// Provides a kOps kube config data source.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi-kops/sdk/go/kops"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := kops.GetKubeConfig(ctx, &GetKubeConfigArgs{
//				ClusterName: "cluster.example.com",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func GetKubeConfig(ctx *pulumi.Context, args *GetKubeConfigArgs, opts ...pulumi.InvokeOption) (*GetKubeConfigResult, error) {
	var rv GetKubeConfigResult
	err := ctx.Invoke("kops:index/getKubeConfig:getKubeConfig", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getKubeConfig.
type GetKubeConfigArgs struct {
	// - (Computed) - Int - Admin is the cluster admin user credential lifetime.
	Admin *int `pulumi:"admin"`
	// - String - The cluster name.
	ClusterName string `pulumi:"clusterName"`
	// - (Computed) - Bool - Internal use the cluster's internal DNS name.
	Internal *bool `pulumi:"internal"`
}

// A collection of values returned by getKubeConfig.
type GetKubeConfigResult struct {
	Admin       int    `pulumi:"admin"`
	CaCerts     string `pulumi:"caCerts"`
	ClientCert  string `pulumi:"clientCert"`
	ClientKey   string `pulumi:"clientKey"`
	ClusterName string `pulumi:"clusterName"`
	Context     string `pulumi:"context"`
	// The provider-assigned unique ID for this managed resource.
	Id           string `pulumi:"id"`
	Internal     bool   `pulumi:"internal"`
	KubePassword string `pulumi:"kubePassword"`
	KubeUser     string `pulumi:"kubeUser"`
	Namespace    string `pulumi:"namespace"`
	Server       string `pulumi:"server"`
}

func GetKubeConfigOutput(ctx *pulumi.Context, args GetKubeConfigOutputArgs, opts ...pulumi.InvokeOption) GetKubeConfigResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetKubeConfigResult, error) {
			args := v.(GetKubeConfigArgs)
			r, err := GetKubeConfig(ctx, &args, opts...)
			var s GetKubeConfigResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetKubeConfigResultOutput)
}

// A collection of arguments for invoking getKubeConfig.
type GetKubeConfigOutputArgs struct {
	// - (Computed) - Int - Admin is the cluster admin user credential lifetime.
	Admin pulumi.IntPtrInput `pulumi:"admin"`
	// - String - The cluster name.
	ClusterName pulumi.StringInput `pulumi:"clusterName"`
	// - (Computed) - Bool - Internal use the cluster's internal DNS name.
	Internal pulumi.BoolPtrInput `pulumi:"internal"`
}

func (GetKubeConfigOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetKubeConfigArgs)(nil)).Elem()
}

// A collection of values returned by getKubeConfig.
type GetKubeConfigResultOutput struct{ *pulumi.OutputState }

func (GetKubeConfigResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetKubeConfigResult)(nil)).Elem()
}

func (o GetKubeConfigResultOutput) ToGetKubeConfigResultOutput() GetKubeConfigResultOutput {
	return o
}

func (o GetKubeConfigResultOutput) ToGetKubeConfigResultOutputWithContext(ctx context.Context) GetKubeConfigResultOutput {
	return o
}

func (o GetKubeConfigResultOutput) Admin() pulumi.IntOutput {
	return o.ApplyT(func(v GetKubeConfigResult) int { return v.Admin }).(pulumi.IntOutput)
}

func (o GetKubeConfigResultOutput) CaCerts() pulumi.StringOutput {
	return o.ApplyT(func(v GetKubeConfigResult) string { return v.CaCerts }).(pulumi.StringOutput)
}

func (o GetKubeConfigResultOutput) ClientCert() pulumi.StringOutput {
	return o.ApplyT(func(v GetKubeConfigResult) string { return v.ClientCert }).(pulumi.StringOutput)
}

func (o GetKubeConfigResultOutput) ClientKey() pulumi.StringOutput {
	return o.ApplyT(func(v GetKubeConfigResult) string { return v.ClientKey }).(pulumi.StringOutput)
}

func (o GetKubeConfigResultOutput) ClusterName() pulumi.StringOutput {
	return o.ApplyT(func(v GetKubeConfigResult) string { return v.ClusterName }).(pulumi.StringOutput)
}

func (o GetKubeConfigResultOutput) Context() pulumi.StringOutput {
	return o.ApplyT(func(v GetKubeConfigResult) string { return v.Context }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetKubeConfigResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetKubeConfigResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetKubeConfigResultOutput) Internal() pulumi.BoolOutput {
	return o.ApplyT(func(v GetKubeConfigResult) bool { return v.Internal }).(pulumi.BoolOutput)
}

func (o GetKubeConfigResultOutput) KubePassword() pulumi.StringOutput {
	return o.ApplyT(func(v GetKubeConfigResult) string { return v.KubePassword }).(pulumi.StringOutput)
}

func (o GetKubeConfigResultOutput) KubeUser() pulumi.StringOutput {
	return o.ApplyT(func(v GetKubeConfigResult) string { return v.KubeUser }).(pulumi.StringOutput)
}

func (o GetKubeConfigResultOutput) Namespace() pulumi.StringOutput {
	return o.ApplyT(func(v GetKubeConfigResult) string { return v.Namespace }).(pulumi.StringOutput)
}

func (o GetKubeConfigResultOutput) Server() pulumi.StringOutput {
	return o.ApplyT(func(v GetKubeConfigResult) string { return v.Server }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetKubeConfigResultOutput{})
}