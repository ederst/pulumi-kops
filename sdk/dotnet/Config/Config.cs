// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Immutable;

namespace Pulumi.Kops
{
    public static class Config
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "IDE1006", Justification = 
        "Double underscore prefix used to avoid conflicts with variable names.")]
        private sealed class __Value<T>
        {
            private readonly Func<T> _getter;
            private T _value = default!;
            private bool _set;

            public __Value(Func<T> getter)
            {
                _getter = getter;
            }

            public T Get() => _set ? _value : _getter();

            public void Set(T value)
            {
                _value = value;
                _set = true;
            }
        }

        private static readonly Pulumi.Config __config = new Pulumi.Config("kops");

        private static readonly __Value<Pulumi.Kops.Config.Types.Aws?> _aws = new __Value<Pulumi.Kops.Config.Types.Aws?>(() => __config.GetObject<Pulumi.Kops.Config.Types.Aws>("aws"));
        public static Pulumi.Kops.Config.Types.Aws? Aws
        {
            get => _aws.Get();
            set => _aws.Set(value);
        }

        private static readonly __Value<ImmutableArray<string>> _featureFlags = new __Value<ImmutableArray<string>>(() => __config.GetObject<ImmutableArray<string>>("featureFlags"));
        public static ImmutableArray<string> FeatureFlags
        {
            get => _featureFlags.Get();
            set => _featureFlags.Set(value);
        }

        private static readonly __Value<Pulumi.Kops.Config.Types.Klog?> _klog = new __Value<Pulumi.Kops.Config.Types.Klog?>(() => __config.GetObject<Pulumi.Kops.Config.Types.Klog>("klog"));
        public static Pulumi.Kops.Config.Types.Klog? Klog
        {
            get => _klog.Get();
            set => _klog.Set(value);
        }

        private static readonly __Value<bool?> _mock = new __Value<bool?>(() => __config.GetBoolean("mock"));
        public static bool? Mock
        {
            get => _mock.Get();
            set => _mock.Set(value);
        }

        private static readonly __Value<Pulumi.Kops.Config.Types.Openstack?> _openstack = new __Value<Pulumi.Kops.Config.Types.Openstack?>(() => __config.GetObject<Pulumi.Kops.Config.Types.Openstack>("openstack"));
        public static Pulumi.Kops.Config.Types.Openstack? Openstack
        {
            get => _openstack.Get();
            set => _openstack.Set(value);
        }

        private static readonly __Value<string?> _stateStore = new __Value<string?>(() => __config.Get("stateStore"));
        public static string? StateStore
        {
            get => _stateStore.Get();
            set => _stateStore.Set(value);
        }

        public static class Types
        {

             public class Aws
             {
                public string? AccessKey { get; set; } = null!;
                public Pulumi.Kops.Config.Types.AwsAssumeRole? AssumeRole { get; set; } = null!;
                public string? Profile { get; set; } = null!;
                public string? Region { get; set; } = null!;
                public string? S3AccessKey { get; set; } = null!;
                public string? S3Endpoint { get; set; } = null!;
                public string? S3Region { get; set; } = null!;
                public string? S3SecretKey { get; set; } = null!;
                public string? SecretKey { get; set; } = null!;
                public bool? SkipRegionCheck { get; set; }
            }

             public class AwsAssumeRole
             {
                public string? RoleArn { get; set; } = null!;
            }

             public class Klog
             {
                public Pulumi.Kops.Config.Types.KlogVerbosity? Verbosity { get; set; } = null!;
            }

             public class KlogVerbosity
             {
                public int? Value { get; set; }
            }

             public class Openstack
             {
                public string? ApplicationCredentialId { get; set; } = null!;
                public string? ApplicationCredentialSecret { get; set; } = null!;
                public string? AuthUrl { get; set; } = null!;
                public string? DomainId { get; set; } = null!;
                public string? DomainName { get; set; } = null!;
                public string? Password { get; set; } = null!;
                public string? ProjectDomainId { get; set; } = null!;
                public string? ProjectDomainName { get; set; } = null!;
                public string? ProjectId { get; set; } = null!;
                public string? ProjectName { get; set; } = null!;
                public string? RegionName { get; set; } = null!;
                public string? TenantId { get; set; } = null!;
                public string? TenantName { get; set; } = null!;
                public string? Username { get; set; } = null!;
            }
        }
    }
}
