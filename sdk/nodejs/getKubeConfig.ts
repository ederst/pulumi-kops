// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * ## # kops.getKubeConfig
 *
 * Provides a kOps kube config data source.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as kops from "@pulumi/kops";
 *
 * const kubeConfig = kops.getKubeConfig({
 *     clusterName: "cluster.example.com",
 * });
 * ```
 */
export function getKubeConfig(args: GetKubeConfigArgs, opts?: pulumi.InvokeOptions): Promise<GetKubeConfigResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("kops:index/getKubeConfig:getKubeConfig", {
        "admin": args.admin,
        "clusterName": args.clusterName,
        "internal": args.internal,
    }, opts);
}

/**
 * A collection of arguments for invoking getKubeConfig.
 */
export interface GetKubeConfigArgs {
    /**
     * - (Computed) - Int - Admin is the cluster admin user credential lifetime.
     */
    admin?: number;
    /**
     * - String - The cluster name.
     */
    clusterName: string;
    /**
     * - (Computed) - Bool - Internal use the cluster's internal DNS name.
     */
    internal?: boolean;
}

/**
 * A collection of values returned by getKubeConfig.
 */
export interface GetKubeConfigResult {
    readonly admin: number;
    readonly caCerts: string;
    readonly clientCert: string;
    readonly clientKey: string;
    readonly clusterName: string;
    readonly context: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly internal: boolean;
    readonly kubePassword: string;
    readonly kubeUser: string;
    readonly namespace: string;
    readonly server: string;
}

export function getKubeConfigOutput(args: GetKubeConfigOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetKubeConfigResult> {
    return pulumi.output(args).apply(a => getKubeConfig(a, opts))
}

/**
 * A collection of arguments for invoking getKubeConfig.
 */
export interface GetKubeConfigOutputArgs {
    /**
     * - (Computed) - Int - Admin is the cluster admin user credential lifetime.
     */
    admin?: pulumi.Input<number>;
    /**
     * - String - The cluster name.
     */
    clusterName: pulumi.Input<string>;
    /**
     * - (Computed) - Bool - Internal use the cluster's internal DNS name.
     */
    internal?: pulumi.Input<boolean>;
}