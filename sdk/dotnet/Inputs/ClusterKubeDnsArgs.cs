// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops.Inputs
{

    public sealed class ClusterKubeDnsArgs : global::Pulumi.ResourceArgs
    {
        [Input("affinity")]
        public Input<Inputs.ClusterKubeDnsAffinityArgs>? Affinity { get; set; }

        [Input("cacheMaxConcurrent")]
        public Input<int>? CacheMaxConcurrent { get; set; }

        [Input("cacheMaxSize")]
        public Input<int>? CacheMaxSize { get; set; }

        [Input("coreDnsImage")]
        public Input<string>? CoreDnsImage { get; set; }

        [Input("cpaImage")]
        public Input<string>? CpaImage { get; set; }

        [Input("cpuRequest")]
        public Input<string>? CpuRequest { get; set; }

        [Input("domain")]
        public Input<string>? Domain { get; set; }

        [Input("externalCoreFile")]
        public Input<string>? ExternalCoreFile { get; set; }

        [Input("memoryLimit")]
        public Input<string>? MemoryLimit { get; set; }

        [Input("memoryRequest")]
        public Input<string>? MemoryRequest { get; set; }

        [Input("nodeLocalDns")]
        public Input<Inputs.ClusterKubeDnsNodeLocalDnsArgs>? NodeLocalDns { get; set; }

        [Input("provider")]
        public Input<string>? Provider { get; set; }

        [Input("serverIp")]
        public Input<string>? ServerIp { get; set; }

        [Input("stubDomains")]
        private InputList<Inputs.ClusterKubeDnsStubDomainArgs>? _stubDomains;
        public InputList<Inputs.ClusterKubeDnsStubDomainArgs> StubDomains
        {
            get => _stubDomains ?? (_stubDomains = new InputList<Inputs.ClusterKubeDnsStubDomainArgs>());
            set => _stubDomains = value;
        }

        [Input("tolerations")]
        private InputList<Inputs.ClusterKubeDnsTolerationArgs>? _tolerations;
        public InputList<Inputs.ClusterKubeDnsTolerationArgs> Tolerations
        {
            get => _tolerations ?? (_tolerations = new InputList<Inputs.ClusterKubeDnsTolerationArgs>());
            set => _tolerations = value;
        }

        [Input("upstreamNameservers")]
        private InputList<string>? _upstreamNameservers;
        public InputList<string> UpstreamNameservers
        {
            get => _upstreamNameservers ?? (_upstreamNameservers = new InputList<string>());
            set => _upstreamNameservers = value;
        }

        public ClusterKubeDnsArgs()
        {
        }
        public static new ClusterKubeDnsArgs Empty => new ClusterKubeDnsArgs();
    }
}
