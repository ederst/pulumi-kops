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
    public sealed class ClusterIamServiceAccountExternalPermission
    {
        public readonly Outputs.ClusterIamServiceAccountExternalPermissionAws? Aws;
        /// <summary>
        /// - (Force new) - String - Name defines the cluster name.
        /// </summary>
        public readonly string? Name;
        public readonly string? Namespace;

        [OutputConstructor]
        private ClusterIamServiceAccountExternalPermission(
            Outputs.ClusterIamServiceAccountExternalPermissionAws? aws,

            string? name,

            string? @namespace)
        {
            Aws = aws;
            Name = name;
            Namespace = @namespace;
        }
    }
}
