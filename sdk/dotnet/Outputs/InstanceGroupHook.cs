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
    public sealed class InstanceGroupHook
    {
        public readonly ImmutableArray<string> Befores;
        public readonly bool? Enabled;
        public readonly Outputs.InstanceGroupHookExecContainer? ExecContainer;
        public readonly string? Manifest;
        /// <summary>
        /// - (Force new) - String - Name defines the instance group name.
        /// </summary>
        public readonly string Name;
        public readonly ImmutableArray<string> Requires;
        public readonly ImmutableArray<string> Roles;
        public readonly bool? UseRawManifest;

        [OutputConstructor]
        private InstanceGroupHook(
            ImmutableArray<string> befores,

            bool? enabled,

            Outputs.InstanceGroupHookExecContainer? execContainer,

            string? manifest,

            string name,

            ImmutableArray<string> requires,

            ImmutableArray<string> roles,

            bool? useRawManifest)
        {
            Befores = befores;
            Enabled = enabled;
            ExecContainer = execContainer;
            Manifest = manifest;
            Name = name;
            Requires = requires;
            Roles = roles;
            UseRawManifest = useRawManifest;
        }
    }
}
