// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterHookExecContainerGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("commands")]
        private InputList<string>? _commands;
        public InputList<string> Commands
        {
            get => _commands ?? (_commands = new InputList<string>());
            set => _commands = value;
        }

        [Input("environment")]
        private InputMap<string>? _environment;
        public InputMap<string> Environment
        {
            get => _environment ?? (_environment = new InputMap<string>());
            set => _environment = value;
        }

        [Input("image", required: true)]
        public Input<string> Image { get; set; } = null!;

        public ClusterHookExecContainerGetArgs()
        {
        }
        public static new ClusterHookExecContainerGetArgs Empty => new ClusterHookExecContainerGetArgs();
    }
}
