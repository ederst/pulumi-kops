// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterNetworkingRomanaGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("daemonServiceIp")]
        public Input<string>? DaemonServiceIp { get; set; }

        [Input("etcdServiceIp")]
        public Input<string>? EtcdServiceIp { get; set; }

        public ClusterNetworkingRomanaGetArgs()
        {
        }
        public static new ClusterNetworkingRomanaGetArgs Empty => new ClusterNetworkingRomanaGetArgs();
    }
}
