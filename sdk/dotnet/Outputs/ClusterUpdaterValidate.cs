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
    public sealed class ClusterUpdaterValidate
    {
        public readonly string? PollInterval;
        public readonly bool? Skip;
        public readonly string? Timeout;

        [OutputConstructor]
        private ClusterUpdaterValidate(
            string? pollInterval,

            bool? skip,

            string? timeout)
        {
            PollInterval = pollInterval;
            Skip = skip;
            Timeout = timeout;
        }
    }
}
