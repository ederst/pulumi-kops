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
    public sealed class GetClusterDockerPackageResult
    {
        public readonly string HashAmd64;
        public readonly string HashArm64;
        public readonly string UrlAmd64;
        public readonly string UrlArm64;

        [OutputConstructor]
        private GetClusterDockerPackageResult(
            string hashAmd64,

            string hashArm64,

            string urlAmd64,

            string urlArm64)
        {
            HashAmd64 = hashAmd64;
            HashArm64 = hashArm64;
            UrlAmd64 = urlAmd64;
            UrlArm64 = urlArm64;
        }
    }
}
