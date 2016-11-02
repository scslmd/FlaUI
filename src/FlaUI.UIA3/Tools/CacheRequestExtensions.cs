﻿using FlaUI.Core;
using UIA = interop.UIAutomationCore;

namespace FlaUI.UIA3.Tools
{
    public static class CacheRequestExtensions
    {
        public static UIA.IUIAutomationCacheRequest ToNative(this ICacheRequest cacheRequest)
        {
            return cacheRequest == null ? null : ((UIA3CacheRequest)cacheRequest).NativeCacheRequest;
        }
    }
}
