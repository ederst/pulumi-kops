// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterKubeletAnonymousAuthGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("value")]
        public Input<bool>? Value { get; set; }

        public ClusterKubeletAnonymousAuthGetArgs()
        {
        }
        public static new ClusterKubeletAnonymousAuthGetArgs Empty => new ClusterKubeletAnonymousAuthGetArgs();
    }
}
