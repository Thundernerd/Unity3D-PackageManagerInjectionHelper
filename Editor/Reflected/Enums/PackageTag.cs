using System;

namespace TNRD.PackageManager.Reflected
{
    [Flags]
    public enum PackageTag : uint
    {
        None = 0,
        InDevelopment = 1,
        Custom = InDevelopment, // 0x00000001
        Local = 2,
        Git = 4,
        Bundled = 8,
        BuiltIn = 16, // 0x00000010
        VersionLocked = 256, // 0x00000100
        Installable = 512, // 0x00000200
        Removable = 1024, // 0x00000400
        Downloadable = 2048, // 0x00000800
        Importable = 4096, // 0x00001000
        Embeddable = 8192, // 0x00002000
        Published = 65536, // 0x00010000
        Deprecated = 131072, // 0x00020000
        Verified = 262144, // 0x00040000
        Preview = 524288, // 0x00080000
        Release = 1048576 // 0x00100000
    }
}