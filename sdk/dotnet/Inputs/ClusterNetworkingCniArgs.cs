// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterNetworkingCniArgs : global::Pulumi.ResourceArgs
    {
        [Input("usesSecondaryIp")]
        public Input<bool>? UsesSecondaryIp { get; set; }

        public ClusterNetworkingCniArgs()
        {
        }
        public static new ClusterNetworkingCniArgs Empty => new ClusterNetworkingCniArgs();
    }
}
