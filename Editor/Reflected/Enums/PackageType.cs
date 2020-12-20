using System;

namespace TNRD.PackageManager.Reflected
{
    [Flags]
    public enum PackageType
    {
        None = 0,
        Installable = 1,
        BuiltIn = 2,
        AssetStore = 4,
        Unity = 8,
        ScopedRegistry = 16 // 0x00000010
    }
}