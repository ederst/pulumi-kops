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
    public sealed class GetClusterKubeApiServerAnonymousAuthResult
    {
        public readonly bool Value;

        [OutputConstructor]
        private GetClusterKubeApiServerAnonymousAuthResult(bool value)
        {
            Value = value;
        }
    }
}
