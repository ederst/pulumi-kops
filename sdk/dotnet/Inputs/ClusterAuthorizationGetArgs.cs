// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterAuthorizationGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("alwaysAllow")]
        public Input<Inputs.ClusterAuthorizationAlwaysAllowGetArgs>? AlwaysAllow { get; set; }

        [Input("rbac")]
        public Input<Inputs.ClusterAuthorizationRbacGetArgs>? Rbac { get; set; }

        public ClusterAuthorizationGetArgs()
        {
        }
        public static new ClusterAuthorizationGetArgs Empty => new ClusterAuthorizationGetArgs();
    }
}
