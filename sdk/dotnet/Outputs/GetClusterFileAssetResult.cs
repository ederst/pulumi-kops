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
    public sealed class GetClusterFileAssetResult
    {
        public readonly string Content;
        public readonly bool IsBase64;
        public readonly string Mode;
        /// <summary>
        /// - String - Name defines the cluster name.
        /// </summary>
        public readonly string Name;
        public readonly string Path;
        public readonly ImmutableArray<string> Roles;

        [OutputConstructor]
        private GetClusterFileAssetResult(
            string content,

            bool isBase64,

            string mode,

            string name,

            string path,

            ImmutableArray<string> roles)
        {
            Content = content;
            IsBase64 = isBase64;
            Mode = mode;
            Name = name;
            Path = path;
            Roles = roles;
        }
    }
}