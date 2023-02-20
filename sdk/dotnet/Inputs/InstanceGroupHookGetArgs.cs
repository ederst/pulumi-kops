// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class InstanceGroupHookGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("befores")]
        private InputList<string>? _befores;
        public InputList<string> Befores
        {
            get => _befores ?? (_befores = new InputList<string>());
            set => _befores = value;
        }

        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("execContainer")]
        public Input<Inputs.InstanceGroupHookExecContainerGetArgs>? ExecContainer { get; set; }

        [Input("manifest")]
        public Input<string>? Manifest { get; set; }

        /// <summary>
        /// - (Force new) - String - Name defines the instance group name.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("requires")]
        private InputList<string>? _requires;
        public InputList<string> Requires
        {
            get => _requires ?? (_requires = new InputList<string>());
            set => _requires = value;
        }

        [Input("roles")]
        private InputList<string>? _roles;
        public InputList<string> Roles
        {
            get => _roles ?? (_roles = new InputList<string>());
            set => _roles = value;
        }

        [Input("useRawManifest")]
        public Input<bool>? UseRawManifest { get; set; }

        public InstanceGroupHookGetArgs()
        {
        }
        public static new InstanceGroupHookGetArgs Empty => new InstanceGroupHookGetArgs();
    }
}
