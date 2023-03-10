// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterCloudProviderOpenstackBlockStorageGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("createStorageClass")]
        public Input<bool>? CreateStorageClass { get; set; }

        [Input("csiPluginImage")]
        public Input<string>? CsiPluginImage { get; set; }

        [Input("csiTopologySupport")]
        public Input<bool>? CsiTopologySupport { get; set; }

        [Input("ignoreAz")]
        public Input<bool>? IgnoreAz { get; set; }

        [Input("overrideAz")]
        public Input<string>? OverrideAz { get; set; }

        [Input("version")]
        public Input<string>? Version { get; set; }

        public ClusterCloudProviderOpenstackBlockStorageGetArgs()
        {
        }
        public static new ClusterCloudProviderOpenstackBlockStorageGetArgs Empty => new ClusterCloudProviderOpenstackBlockStorageGetArgs();
    }
}
