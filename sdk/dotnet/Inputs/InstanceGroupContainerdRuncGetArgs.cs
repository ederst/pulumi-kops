// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class InstanceGroupContainerdRuncGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// - List(String) - Packages specifies additional packages to be installed.
        /// </summary>
        [Input("packages")]
        public Input<Inputs.InstanceGroupContainerdRuncPackagesGetArgs>? Packages { get; set; }

        [Input("version")]
        public Input<string>? Version { get; set; }

        public InstanceGroupContainerdRuncGetArgs()
        {
        }
        public static new InstanceGroupContainerdRuncGetArgs Empty => new InstanceGroupContainerdRuncGetArgs();
    }
}