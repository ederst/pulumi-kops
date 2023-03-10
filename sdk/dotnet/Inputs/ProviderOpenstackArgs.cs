// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ProviderOpenstackArgs : global::Pulumi.ResourceArgs
    {
        [Input("applicationCredentialId")]
        public Input<string>? ApplicationCredentialId { get; set; }

        [Input("applicationCredentialSecret")]
        public Input<string>? ApplicationCredentialSecret { get; set; }

        [Input("authUrl")]
        public Input<string>? AuthUrl { get; set; }

        [Input("domainId")]
        public Input<string>? DomainId { get; set; }

        [Input("domainName")]
        public Input<string>? DomainName { get; set; }

        [Input("password")]
        public Input<string>? Password { get; set; }

        [Input("projectDomainId")]
        public Input<string>? ProjectDomainId { get; set; }

        [Input("projectDomainName")]
        public Input<string>? ProjectDomainName { get; set; }

        [Input("projectId")]
        public Input<string>? ProjectId { get; set; }

        [Input("projectName")]
        public Input<string>? ProjectName { get; set; }

        [Input("regionName")]
        public Input<string>? RegionName { get; set; }

        [Input("tenantId")]
        public Input<string>? TenantId { get; set; }

        [Input("tenantName")]
        public Input<string>? TenantName { get; set; }

        [Input("username")]
        public Input<string>? Username { get; set; }

        public ProviderOpenstackArgs()
        {
        }
        public static new ProviderOpenstackArgs Empty => new ProviderOpenstackArgs();
    }
}
