// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterSecretsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("clusterCaCert")]
        public Input<string>? ClusterCaCert { get; set; }

        [Input("clusterCaKey")]
        public Input<string>? ClusterCaKey { get; set; }

        [Input("dockerConfig")]
        public Input<string>? DockerConfig { get; set; }

        public ClusterSecretsGetArgs()
        {
        }
        public static new ClusterSecretsGetArgs Empty => new ClusterSecretsGetArgs();
    }
}
