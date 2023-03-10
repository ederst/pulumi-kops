// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class InstanceGroupContainerdGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("address")]
        public Input<string>? Address { get; set; }

        [Input("configOverride")]
        public Input<string>? ConfigOverride { get; set; }

        [Input("logLevel")]
        public Input<string>? LogLevel { get; set; }

        [Input("nvidiaGpu")]
        public Input<Inputs.InstanceGroupContainerdNvidiaGpuGetArgs>? NvidiaGpu { get; set; }

        /// <summary>
        /// - List(String) - Packages specifies additional packages to be installed.
        /// </summary>
        [Input("packages")]
        public Input<Inputs.InstanceGroupContainerdPackagesGetArgs>? Packages { get; set; }

        [Input("registryMirrors")]
        private InputList<Inputs.InstanceGroupContainerdRegistryMirrorGetArgs>? _registryMirrors;
        public InputList<Inputs.InstanceGroupContainerdRegistryMirrorGetArgs> RegistryMirrors
        {
            get => _registryMirrors ?? (_registryMirrors = new InputList<Inputs.InstanceGroupContainerdRegistryMirrorGetArgs>());
            set => _registryMirrors = value;
        }

        [Input("root")]
        public Input<string>? Root { get; set; }

        [Input("runc")]
        public Input<Inputs.InstanceGroupContainerdRuncGetArgs>? Runc { get; set; }

        [Input("skipInstall")]
        public Input<bool>? SkipInstall { get; set; }

        [Input("state")]
        public Input<string>? State { get; set; }

        [Input("version")]
        public Input<string>? Version { get; set; }

        public InstanceGroupContainerdGetArgs()
        {
        }
        public static new InstanceGroupContainerdGetArgs Empty => new InstanceGroupContainerdGetArgs();
    }
}
