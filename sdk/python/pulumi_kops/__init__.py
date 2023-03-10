# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from . import _utilities
import typing
# Export this package's modules as members:
from .cluster import *
from .cluster_updater import *
from .get_cluster import *
from .get_cluster_status import *
from .get_instance_group import *
from .get_kube_config import *
from .instance_group import *
from .provider import *
from ._inputs import *
from . import outputs

# Make subpackages available:
if typing.TYPE_CHECKING:
    import pulumi_kops.config as __config
    config = __config
else:
    config = _utilities.lazy_import('pulumi_kops.config')

_utilities.register(
    resource_modules="""
[
 {
  "pkg": "kops",
  "mod": "index/cluster",
  "fqn": "pulumi_kops",
  "classes": {
   "kops:index/cluster:Cluster": "Cluster"
  }
 },
 {
  "pkg": "kops",
  "mod": "index/clusterUpdater",
  "fqn": "pulumi_kops",
  "classes": {
   "kops:index/clusterUpdater:ClusterUpdater": "ClusterUpdater"
  }
 },
 {
  "pkg": "kops",
  "mod": "index/instanceGroup",
  "fqn": "pulumi_kops",
  "classes": {
   "kops:index/instanceGroup:InstanceGroup": "InstanceGroup"
  }
 }
]
""",
    resource_packages="""
[
 {
  "pkg": "kops",
  "token": "pulumi:providers:kops",
  "fqn": "pulumi_kops",
  "class": "Provider"
 }
]
"""
)
