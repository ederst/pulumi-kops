// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterAddonGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("manifest", required: true)]
        public Input<string> Manifest { get; set; } = null!;

        public ClusterAddonGetArgs()
        {
        }
        public static new ClusterAddonGetArgs Empty => new ClusterAddonGetArgs();
    }
}
