# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs

import types

__config__ = pulumi.Config('kops')


class _ExportableConfig(types.ModuleType):
    @property
    def aws(self) -> Optional[str]:
        return __config__.get('aws')

    @property
    def feature_flags(self) -> Optional[str]:
        return __config__.get('featureFlags')

    @property
    def klog(self) -> Optional[str]:
        return __config__.get('klog')

    @property
    def mock(self) -> Optional[bool]:
        return __config__.get_bool('mock')

    @property
    def openstack(self) -> Optional[str]:
        return __config__.get('openstack')

    @property
    def state_store(self) -> Optional[str]:
        return __config__.get('stateStore')

