// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterApiLoadBalancerAccessLogArgs : global::Pulumi.ResourceArgs
    {
        [Input("bucket")]
        public Input<string>? Bucket { get; set; }

        [Input("bucketPrefix")]
        public Input<string>? BucketPrefix { get; set; }

        [Input("interval")]
        public Input<int>? Interval { get; set; }

        public ClusterApiLoadBalancerAccessLogArgs()
        {
        }
        public static new ClusterApiLoadBalancerAccessLogArgs Empty => new ClusterApiLoadBalancerAccessLogArgs();
    }
}
