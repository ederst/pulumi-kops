// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterCertManagerGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("defaultIssuer")]
        public Input<string>? DefaultIssuer { get; set; }

        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        [Input("hostedZoneIds")]
        private InputList<string>? _hostedZoneIds;
        public InputList<string> HostedZoneIds
        {
            get => _hostedZoneIds ?? (_hostedZoneIds = new InputList<string>());
            set => _hostedZoneIds = value;
        }

        [Input("image")]
        public Input<string>? Image { get; set; }

        [Input("managed", required: true)]
        public Input<bool> Managed { get; set; } = null!;

        [Input("nameservers")]
        private InputList<string>? _nameservers;
        public InputList<string> Nameservers
        {
            get => _nameservers ?? (_nameservers = new InputList<string>());
            set => _nameservers = value;
        }

        public ClusterCertManagerGetArgs()
        {
        }
        public static new ClusterCertManagerGetArgs Empty => new ClusterCertManagerGetArgs();
    }
}
