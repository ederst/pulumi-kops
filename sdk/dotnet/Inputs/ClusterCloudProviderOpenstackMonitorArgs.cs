// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterCloudProviderOpenstackMonitorArgs : global::Pulumi.ResourceArgs
    {
        [Input("delay")]
        public Input<string>? Delay { get; set; }

        [Input("maxRetries")]
        public Input<int>? MaxRetries { get; set; }

        [Input("timeout")]
        public Input<string>? Timeout { get; set; }

        public ClusterCloudProviderOpenstackMonitorArgs()
        {
        }
        public static new ClusterCloudProviderOpenstackMonitorArgs Empty => new ClusterCloudProviderOpenstackMonitorArgs();
    }
}