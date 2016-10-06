﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Management.Resource.Fluent.Core;

namespace Microsoft.Azure.Management.Compute.Fluent
{
    public enum KnownWindowsVirtualMachineImage
    {
        [EnumName("MicrosoftWindowsServer WindowsServer 2008-R2-SP1")]
        WINDOWS_SERVER_2008_R2_SP1,
        [EnumName("MicrosoftWindowsServer WindowsServer 2012-Datacenter")]
        WINDOWS_SERVER_2012_DATACENTER,
        [EnumName("MicrosoftWindowsServer WindowsServer 2012-R2-Datacenter")]
        WINDOWS_SERVER_2012_R2_DATACENTER,
        [EnumName("MicrosoftWindowsServer WindowsServer 2016-Technical-Preview-with-Containers")]
        WINDOWS_SERVER_2016_TECHNICAL_PREVIEW_WITH_CONTAINERS,
        [EnumName("MicrosoftWindowsServer WindowsServer Windows-Server-Technical-Preview")]
        WINDOWS_SERVER_TECHNICAL_PREVIEW
    }
}