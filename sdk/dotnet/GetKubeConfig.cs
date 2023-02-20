// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kops
{
    public static class GetKubeConfig
    {
        /// <summary>
        /// ## # kops.getKubeConfig
        /// 
        /// Provides a kOps kube config data source.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using Kops = Pulumi.Kops;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var kubeConfig = Kops.GetKubeConfig.Invoke(new()
        ///     {
        ///         ClusterName = "cluster.example.com",
        ///     });
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetKubeConfigResult> InvokeAsync(GetKubeConfigArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetKubeConfigResult>("kops:index/getKubeConfig:getKubeConfig", args ?? new GetKubeConfigArgs(), options.WithDefaults());

        /// <summary>
        /// ## # kops.getKubeConfig
        /// 
        /// Provides a kOps kube config data source.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using Kops = Pulumi.Kops;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var kubeConfig = Kops.GetKubeConfig.Invoke(new()
        ///     {
        ///         ClusterName = "cluster.example.com",
        ///     });
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetKubeConfigResult> Invoke(GetKubeConfigInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetKubeConfigResult>("kops:index/getKubeConfig:getKubeConfig", args ?? new GetKubeConfigInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetKubeConfigArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// - (Computed) - Int - Admin is the cluster admin user credential lifetime.
        /// </summary>
        [Input("admin")]
        public int? Admin { get; set; }

        /// <summary>
        /// - String - The cluster name.
        /// </summary>
        [Input("clusterName", required: true)]
        public string ClusterName { get; set; } = null!;

        /// <summary>
        /// - (Computed) - Bool - Internal use the cluster's internal DNS name.
        /// </summary>
        [Input("internal")]
        public bool? Internal { get; set; }

        public GetKubeConfigArgs()
        {
        }
        public static new GetKubeConfigArgs Empty => new GetKubeConfigArgs();
    }

    public sealed class GetKubeConfigInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// - (Computed) - Int - Admin is the cluster admin user credential lifetime.
        /// </summary>
        [Input("admin")]
        public Input<int>? Admin { get; set; }

        /// <summary>
        /// - String - The cluster name.
        /// </summary>
        [Input("clusterName", required: true)]
        public Input<string> ClusterName { get; set; } = null!;

        /// <summary>
        /// - (Computed) - Bool - Internal use the cluster's internal DNS name.
        /// </summary>
        [Input("internal")]
        public Input<bool>? Internal { get; set; }

        public GetKubeConfigInvokeArgs()
        {
        }
        public static new GetKubeConfigInvokeArgs Empty => new GetKubeConfigInvokeArgs();
    }


    [OutputType]
    public sealed class GetKubeConfigResult
    {
        public readonly int Admin;
        public readonly string CaCerts;
        public readonly string ClientCert;
        public readonly string ClientKey;
        public readonly string ClusterName;
        public readonly string Context;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly bool Internal;
        public readonly string KubePassword;
        public readonly string KubeUser;
        public readonly string Namespace;
        public readonly string Server;

        [OutputConstructor]
        private GetKubeConfigResult(
            int admin,

            string caCerts,

            string clientCert,

            string clientKey,

            string clusterName,

            string context,

            string id,

            bool @internal,

            string kubePassword,

            string kubeUser,

            string @namespace,

            string server)
        {
            Admin = admin;
            CaCerts = caCerts;
            ClientCert = clientCert;
            ClientKey = clientKey;
            ClusterName = clusterName;
            Context = context;
            Id = id;
            Internal = @internal;
            KubePassword = kubePassword;
            KubeUser = kubeUser;
            Namespace = @namespace;
            Server = server;
        }
    }
}
