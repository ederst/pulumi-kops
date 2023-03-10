// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterNodeAuthorizationNodeAuthorizerGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("authorizer")]
        public Input<string>? Authorizer { get; set; }

        [Input("features")]
        private InputList<string>? _features;
        public InputList<string> Features
        {
            get => _features ?? (_features = new InputList<string>());
            set => _features = value;
        }

        [Input("image")]
        public Input<string>? Image { get; set; }

        [Input("interval")]
        public Input<string>? Interval { get; set; }

        [Input("nodeUrl")]
        public Input<string>? NodeUrl { get; set; }

        [Input("port")]
        public Input<int>? Port { get; set; }

        [Input("timeout")]
        public Input<string>? Timeout { get; set; }

        [Input("tokenTtl")]
        public Input<string>? TokenTtl { get; set; }

        public ClusterNodeAuthorizationNodeAuthorizerGetArgs()
        {
        }
        public static new ClusterNodeAuthorizationNodeAuthorizerGetArgs Empty => new ClusterNodeAuthorizationNodeAuthorizerGetArgs();
    }
}
