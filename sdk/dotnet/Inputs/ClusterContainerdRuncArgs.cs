// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterContainerdRuncArgs : global::Pulumi.ResourceArgs
    {
        [Input("packages")]
        public Input<Inputs.ClusterContainerdRuncPackagesArgs>? Packages { get; set; }

        [Input("version")]
        public Input<string>? Version { get; set; }

        public ClusterContainerdRuncArgs()
        {
        }
        public static new ClusterContainerdRuncArgs Empty => new ClusterContainerdRuncArgs();
    }
}
