// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

export function getInstanceGroup(args: GetInstanceGroupArgs, opts?: pulumi.InvokeOptions): Promise<GetInstanceGroupResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("kops:index/getInstanceGroup:getInstanceGroup", {
        "clusterName": args.clusterName,
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getInstanceGroup.
 */
export interface GetInstanceGroupArgs {
    /**
     * - String - ClusterName defines the cluster name the instance group belongs to.
     */
    clusterName: string;
    /**
     * - String - Name defines the instance group name.
     */
    name: string;
}

/**
 * A collection of values returned by getInstanceGroup.
 */
export interface GetInstanceGroupResult {
    readonly additionalSecurityGroups: string[];
    readonly additionalUserDatas: outputs.GetInstanceGroupAdditionalUserData[];
    readonly annotations: {[key: string]: string};
    readonly associatePublicIp: boolean;
    readonly autoscale: boolean;
    readonly cloudLabels: {[key: string]: string};
    readonly clusterName: string;
    readonly compressUserData: boolean;
    readonly containerds: outputs.GetInstanceGroupContainerd[];
    readonly cpuCredits: string;
    readonly detailedInstanceMonitoring: boolean;
    readonly externalLoadBalancers: outputs.GetInstanceGroupExternalLoadBalancer[];
    readonly fileAssets: outputs.GetInstanceGroupFileAsset[];
    readonly gcpProvisioningModel: string;
    readonly guestAccelerators: outputs.GetInstanceGroupGuestAccelerator[];
    readonly hooks: outputs.GetInstanceGroupHook[];
    readonly iams: outputs.GetInstanceGroupIam[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly image: string;
    readonly instanceInterruptionBehavior: string;
    readonly instanceMetadatas: outputs.GetInstanceGroupInstanceMetadata[];
    readonly instanceProtection: boolean;
    readonly kubelets: outputs.GetInstanceGroupKubelet[];
    readonly labels: {[key: string]: string};
    readonly machineType: string;
    readonly manager: string;
    readonly maxInstanceLifetime: string;
    readonly maxPrice: string;
    readonly maxSize: number;
    readonly minSize: number;
    readonly mixedInstancesPolicies: outputs.GetInstanceGroupMixedInstancesPolicy[];
    readonly name: string;
    readonly nodeLabels: {[key: string]: string};
    readonly packages: string[];
    readonly role: string;
    readonly rollingUpdates: outputs.GetInstanceGroupRollingUpdate[];
    readonly rootVolumeEncryption: boolean;
    readonly rootVolumeEncryptionKey: string;
    readonly rootVolumeIops: number;
    readonly rootVolumeOptimization: boolean;
    readonly rootVolumeSize: number;
    readonly rootVolumeThroughput: number;
    readonly rootVolumeType: string;
    readonly securityGroupOverride: string;
    readonly spotDurationInMinutes: number;
    readonly subnets: string[];
    readonly suspendProcesses: string[];
    readonly sysctlParameters: string[];
    readonly taints: string[];
    readonly tenancy: string;
    readonly updatePolicy: string;
    readonly volumeMounts: outputs.GetInstanceGroupVolumeMount[];
    readonly volumes: outputs.GetInstanceGroupVolume[];
    readonly warmPools: outputs.GetInstanceGroupWarmPool[];
    readonly zones: string[];
}

export function getInstanceGroupOutput(args: GetInstanceGroupOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetInstanceGroupResult> {
    return pulumi.output(args).apply(a => getInstanceGroup(a, opts))
}

/**
 * A collection of arguments for invoking getInstanceGroup.
 */
export interface GetInstanceGroupOutputArgs {
    /**
     * - String - ClusterName defines the cluster name the instance group belongs to.
     */
    clusterName: pulumi.Input<string>;
    /**
     * - String - Name defines the instance group name.
     */
    name: pulumi.Input<string>;
}
