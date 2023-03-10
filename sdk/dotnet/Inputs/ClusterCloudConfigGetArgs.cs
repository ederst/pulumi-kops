// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterCloudConfigGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("awsEbsCsiDriver")]
        public Input<Inputs.ClusterCloudConfigAwsEbsCsiDriverGetArgs>? AwsEbsCsiDriver { get; set; }

        [Input("disableSecurityGroupIngress")]
        public Input<bool>? DisableSecurityGroupIngress { get; set; }

        [Input("elbSecurityGroup")]
        public Input<string>? ElbSecurityGroup { get; set; }

        [Input("gceServiceAccount")]
        public Input<string>? GceServiceAccount { get; set; }

        [Input("gcpPdCsiDriver")]
        public Input<Inputs.ClusterCloudConfigGcpPdCsiDriverGetArgs>? GcpPdCsiDriver { get; set; }

        [Input("manageStorageClasses")]
        public Input<bool>? ManageStorageClasses { get; set; }

        [Input("multizone")]
        public Input<bool>? Multizone { get; set; }

        [Input("nodeInstancePrefix")]
        public Input<string>? NodeInstancePrefix { get; set; }

        [Input("nodeIpFamilies")]
        private InputList<string>? _nodeIpFamilies;
        public InputList<string> NodeIpFamilies
        {
            get => _nodeIpFamilies ?? (_nodeIpFamilies = new InputList<string>());
            set => _nodeIpFamilies = value;
        }

        [Input("nodeTags")]
        public Input<string>? NodeTags { get; set; }

        [Input("spotinstOrientation")]
        public Input<string>? SpotinstOrientation { get; set; }

        [Input("spotinstProduct")]
        public Input<string>? SpotinstProduct { get; set; }

        public ClusterCloudConfigGetArgs()
        {
        }
        public static new ClusterCloudConfigGetArgs Empty => new ClusterCloudConfigGetArgs();
    }
}
