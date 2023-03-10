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
    public sealed class ClusterTopologyBastion
    {
        public readonly string BastionPublicName;
        public readonly int? IdleTimeoutSeconds;
        public readonly Outputs.ClusterTopologyBastionLoadBalancer? LoadBalancer;

        [OutputConstructor]
        private ClusterTopologyBastion(
            string bastionPublicName,

            int? idleTimeoutSeconds,

            Outputs.ClusterTopologyBastionLoadBalancer? loadBalancer)
        {
            BastionPublicName = bastionPublicName;
            IdleTimeoutSeconds = idleTimeoutSeconds;
            LoadBalancer = loadBalancer;
        }
    }
}
