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
    public sealed class ClusterCloudProviderOpenstackMonitor
    {
        public readonly string? Delay;
        public readonly int? MaxRetries;
        public readonly string? Timeout;

        [OutputConstructor]
        private ClusterCloudProviderOpenstackMonitor(
            string? delay,

            int? maxRetries,

            string? timeout)
        {
            Delay = delay;
            MaxRetries = maxRetries;
            Timeout = timeout;
        }
    }
}