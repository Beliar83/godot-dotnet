using System;
using System.Collections.Frozen;

namespace Godot.NativeInterop;

internal static partial class InteropUtils
{
    internal static FrozenDictionary<StringName, Func<nint, GodotObject>> CreateHelpers { get; private set; }

    static InteropUtils()
    {
        EnsureHelpersInitialized();
    }
}
