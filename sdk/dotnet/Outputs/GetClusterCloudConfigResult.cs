// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Outputs
{

    [OutputType]
    public sealed class GetClusterCloudConfigResult
    {
        public readonly ImmutableArray<Outputs.GetClusterCloudConfigAwsEbsCsiDriverResult> AwsEbsCsiDrivers;
        public readonly bool DisableSecurityGroupIngress;
        public readonly string ElbSecurityGroup;
        public readonly string GceServiceAccount;
        public readonly ImmutableArray<Outputs.GetClusterCloudConfigGcpPdCsiDriverResult> GcpPdCsiDrivers;
        public readonly bool ManageStorageClasses;
        public readonly bool Multizone;
        public readonly string NodeInstancePrefix;
        public readonly ImmutableArray<string> NodeIpFamilies;
        public readonly string NodeTags;
        public readonly string SpotinstOrientation;
        public readonly string SpotinstProduct;

        [OutputConstructor]
        private GetClusterCloudConfigResult(
            ImmutableArray<Outputs.GetClusterCloudConfigAwsEbsCsiDriverResult> awsEbsCsiDrivers,

            bool disableSecurityGroupIngress,

            string elbSecurityGroup,

            string gceServiceAccount,

            ImmutableArray<Outputs.GetClusterCloudConfigGcpPdCsiDriverResult> gcpPdCsiDrivers,

            bool manageStorageClasses,

            bool multizone,

            string nodeInstancePrefix,

            ImmutableArray<string> nodeIpFamilies,

            string nodeTags,

            string spotinstOrientation,

            string spotinstProduct)
        {
            AwsEbsCsiDrivers = awsEbsCsiDrivers;
            DisableSecurityGroupIngress = disableSecurityGroupIngress;
            ElbSecurityGroup = elbSecurityGroup;
            GceServiceAccount = gceServiceAccount;
            GcpPdCsiDrivers = gcpPdCsiDrivers;
            ManageStorageClasses = manageStorageClasses;
            Multizone = multizone;
            NodeInstancePrefix = nodeInstancePrefix;
            NodeIpFamilies = nodeIpFamilies;
            NodeTags = nodeTags;
            SpotinstOrientation = spotinstOrientation;
            SpotinstProduct = spotinstProduct;
        }
    }
}
