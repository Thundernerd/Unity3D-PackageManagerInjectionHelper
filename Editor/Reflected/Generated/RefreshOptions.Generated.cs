namespace TNRD.PackageManager.Reflected
{
	public enum RefreshOptions : uint
	{
		None=0,
		UpmListOffline=1,
		UpmList=2,
		UpmSearchOffline=4,
		AllOffline=5,
		UpmSearch=8,
		AllOnline=10,
		All=15,
		Purchased=16,
		PurchasedOffline=32,
		CurrentFilter=64
	}
}
