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
    public sealed class ClusterIam
    {
        public readonly bool? AllowContainerRegistry;
        public readonly bool? Legacy;
        public readonly string? PermissionsBoundary;
        public readonly ImmutableArray<Outputs.ClusterIamServiceAccountExternalPermission> ServiceAccountExternalPermissions;
        public readonly bool? UseServiceAccountExternalPermissions;

        [OutputConstructor]
        private ClusterIam(
            bool? allowContainerRegistry,

            bool? legacy,

            string? permissionsBoundary,

            ImmutableArray<Outputs.ClusterIamServiceAccountExternalPermission> serviceAccountExternalPermissions,

            bool? useServiceAccountExternalPermissions)
        {
            AllowContainerRegistry = allowContainerRegistry;
            Legacy = legacy;
            PermissionsBoundary = permissionsBoundary;
            ServiceAccountExternalPermissions = serviceAccountExternalPermissions;
            UseServiceAccountExternalPermissions = useServiceAccountExternalPermissions;
        }
    }
}
