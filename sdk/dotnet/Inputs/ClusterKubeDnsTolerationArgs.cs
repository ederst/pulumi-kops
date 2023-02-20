// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterKubeDnsTolerationArgs : global::Pulumi.ResourceArgs
    {
        [Input("effect")]
        public Input<string>? Effect { get; set; }

        [Input("key")]
        public Input<string>? Key { get; set; }

        [Input("operator")]
        public Input<string>? Operator { get; set; }

        [Input("tolerationSeconds")]
        public Input<int>? TolerationSeconds { get; set; }

        [Input("value")]
        public Input<string>? Value { get; set; }

        public ClusterKubeDnsTolerationArgs()
        {
        }
        public static new ClusterKubeDnsTolerationArgs Empty => new ClusterKubeDnsTolerationArgs();
    }
}