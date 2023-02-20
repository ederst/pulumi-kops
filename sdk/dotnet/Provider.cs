// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops
{
    /// <summary>
    /// The provider type for the kops package. By default, resources use package-wide configuration
    /// settings, however an explicit `Provider` instance may be created and passed during resource
    /// construction to achieve fine-grained programmatic control over provider settings. See the
    /// [documentation](https://www.pulumi.com/docs/reference/programming-model/#providers) for more information.
    /// </summary>
    [KopsResourceType("pulumi:providers:kops")]
    public partial class Provider : global::Pulumi.ProviderResource
    {
        [Output("stateStore")]
        public Output<string> StateStore { get; private set; } = null!;


        /// <summary>
        /// Create a Provider resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Provider(string name, ProviderArgs args, CustomResourceOptions? options = null)
            : base("kops", name, args ?? new ProviderArgs(), MakeResourceOptions(options, ""))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
    }

    public sealed class ProviderArgs : global::Pulumi.ResourceArgs
    {
        [Input("aws", json: true)]
        public Input<Inputs.ProviderAwsArgs>? Aws { get; set; }

        [Input("featureFlags", json: true)]
        private InputList<string>? _featureFlags;
        public InputList<string> FeatureFlags
        {
            get => _featureFlags ?? (_featureFlags = new InputList<string>());
            set => _featureFlags = value;
        }

        [Input("klog", json: true)]
        public Input<Inputs.ProviderKlogArgs>? Klog { get; set; }

        [Input("mock", json: true)]
        public Input<bool>? Mock { get; set; }

        [Input("openstack", json: true)]
        public Input<Inputs.ProviderOpenstackArgs>? Openstack { get; set; }

        [Input("stateStore", required: true)]
        public Input<string> StateStore { get; set; } = null!;

        public ProviderArgs()
        {
        }
        public static new ProviderArgs Empty => new ProviderArgs();
    }
}
