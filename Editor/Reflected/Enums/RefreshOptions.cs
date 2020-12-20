using System;

namespace TNRD.PackageManager.Reflected
{
    public sealed partial class IPageManager
    {
        [Flags]
        public enum RefreshOptions : uint
        {
            None             = 0,

            UpmListOffline   = 1 << 0,
            UpmList          = 1 << 1,
            UpmSearchOffline = 1 << 2,
            UpmSearch        = 1 << 3,
            Purchased        = 1 << 4,
            PurchasedOffline = 1 << 5,

            CurrentFilter    = 1 << 6,

            // combinations
            AllOnline        = UpmList | UpmSearch,
            AllOffline       = UpmListOffline | UpmSearchOffline,
            All              = AllOnline | AllOffline
        }
    }
}