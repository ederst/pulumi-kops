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
    public sealed class GetClusterHookExecContainerResult
    {
        public readonly ImmutableArray<string> Commands;
        public readonly ImmutableDictionary<string, string> Environment;
        public readonly string Image;

        [OutputConstructor]
        private GetClusterHookExecContainerResult(
            ImmutableArray<string> commands,

            ImmutableDictionary<string, string> environment,

            string image)
        {
            Commands = commands;
            Environment = environment;
            Image = image;
        }
    }
}