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
    public sealed class ClusterIamServiceAccountExternalPermissionAws
    {
        public readonly string? InlinePolicy;
        public readonly ImmutableArray<string> PolicyArNs;

        [OutputConstructor]
        private ClusterIamServiceAccountExternalPermissionAws(
            string? inlinePolicy,

            ImmutableArray<string> policyArNs)
        {
            InlinePolicy = inlinePolicy;
            PolicyArNs = policyArNs;
        }
    }
}
