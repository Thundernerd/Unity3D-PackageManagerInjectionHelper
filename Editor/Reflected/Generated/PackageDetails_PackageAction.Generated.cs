namespace TNRD.PackageManager.Reflected
{
	public enum PackageAction : int
	{
		Add=0,
		Remove=1,
		Update=2,
		Downgrade=3,
		Enable=4,
		Disable=5,
		UpToDate=6,
		Current=7,
		Local=8,
		Git=9,
		Embedded=10
	}
}
