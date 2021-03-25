// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.CompilerServices;

[assembly: TypeForwardedTo(typeof(System.Web.HttpUtility))]

namespace System.Web.UI
{
    // There appears to be a bug in GenAPI where it emits internal abstract members but doesn't emit the internal implementations in derived types
    public sealed partial class PageParser
    {
        internal override string UnknownOutputCacheAttributeError => throw new PlatformNotSupportedException(SR.PlatformNotSupportedSystemWeb);
    }
    public partial class StaticPartialCachingControl
    {
        internal override Control CreateCachedControl() => throw new PlatformNotSupportedException(SR.PlatformNotSupportedSystemWeb);
    }
    public partial class PartialCachingControl
    {
        internal override Control CreateCachedControl() => throw new PlatformNotSupportedException(SR.PlatformNotSupportedSystemWeb);
    }
}
