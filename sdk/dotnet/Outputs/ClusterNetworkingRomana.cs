// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Outputs
{

    [OutputType]
    public sealed class ClusterNetworkingRomana
    {
        public readonly string? DaemonServiceIp;
        public readonly string? EtcdServiceIp;

        [OutputConstructor]
        private ClusterNetworkingRomana(
            string? daemonServiceIp,

            string? etcdServiceIp)
        {
            DaemonServiceIp = daemonServiceIp;
            EtcdServiceIp = etcdServiceIp;
        }
    }
}
