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
    public sealed class GetClusterAuthorizationResult
    {
        public readonly ImmutableArray<Outputs.GetClusterAuthorizationAlwaysAllowResult> AlwaysAllows;
        public readonly ImmutableArray<Outputs.GetClusterAuthorizationRbacResult> Rbacs;

        [OutputConstructor]
        private GetClusterAuthorizationResult(
            ImmutableArray<Outputs.GetClusterAuthorizationAlwaysAllowResult> alwaysAllows,

            ImmutableArray<Outputs.GetClusterAuthorizationRbacResult> rbacs)
        {
            AlwaysAllows = alwaysAllows;
            Rbacs = rbacs;
        }
    }
}