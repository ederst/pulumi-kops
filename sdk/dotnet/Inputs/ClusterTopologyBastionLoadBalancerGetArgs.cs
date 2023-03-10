// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterTopologyBastionLoadBalancerGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("additionalSecurityGroups", required: true)]
        private InputList<string>? _additionalSecurityGroups;
        public InputList<string> AdditionalSecurityGroups
        {
            get => _additionalSecurityGroups ?? (_additionalSecurityGroups = new InputList<string>());
            set => _additionalSecurityGroups = value;
        }

        [Input("type")]
        public Input<string>? Type { get; set; }

        public ClusterTopologyBastionLoadBalancerGetArgs()
        {
        }
        public static new ClusterTopologyBastionLoadBalancerGetArgs Empty => new ClusterTopologyBastionLoadBalancerGetArgs();
    }
}
