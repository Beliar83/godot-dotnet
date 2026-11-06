namespace Godot;

public partial class GodotInstance
{
    /// <summary>
    /// Creates a Godot instance from a native instance pointer.
    /// </summary>
    public static GodotInstance FromInstancePointer(nint instancePointer)
    {
        return Create(() => new GodotInstance(), new GodotObjectCreationOptions
        {
            NativeClassName = NativeName,
            NativePtr = instancePointer,
            InstanceBindingAlreadyBound = true,
            ReferenceAlreadyOwned = false,
            SkipPostInitializeNotification = true,
        });
    }
}
