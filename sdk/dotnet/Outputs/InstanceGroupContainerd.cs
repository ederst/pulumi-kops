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
    public sealed class InstanceGroupContainerd
    {
        public readonly string? Address;
        public readonly string? ConfigOverride;
        public readonly string? LogLevel;
        public readonly Outputs.InstanceGroupContainerdNvidiaGpu? NvidiaGpu;
        /// <summary>
        /// - List(String) - Packages specifies additional packages to be installed.
        /// </summary>
        public readonly Outputs.InstanceGroupContainerdPackages? Packages;
        public readonly ImmutableArray<Outputs.InstanceGroupContainerdRegistryMirror> RegistryMirrors;
        public readonly string? Root;
        public readonly Outputs.InstanceGroupContainerdRunc? Runc;
        public readonly bool? SkipInstall;
        public readonly string? State;
        public readonly string? Version;

        [OutputConstructor]
        private InstanceGroupContainerd(
            string? address,

            string? configOverride,

            string? logLevel,

            Outputs.InstanceGroupContainerdNvidiaGpu? nvidiaGpu,

            Outputs.InstanceGroupContainerdPackages? packages,

            ImmutableArray<Outputs.InstanceGroupContainerdRegistryMirror> registryMirrors,

            string? root,

            Outputs.InstanceGroupContainerdRunc? runc,

            bool? skipInstall,

            string? state,

            string? version)
        {
            Address = address;
            ConfigOverride = configOverride;
            LogLevel = logLevel;
            NvidiaGpu = nvidiaGpu;
            Packages = packages;
            RegistryMirrors = registryMirrors;
            Root = root;
            Runc = runc;
            SkipInstall = skipInstall;
            State = state;
            Version = version;
        }
    }
}
