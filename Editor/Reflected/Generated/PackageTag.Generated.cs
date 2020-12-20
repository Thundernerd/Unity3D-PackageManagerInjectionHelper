namespace TNRD.PackageManager.Reflected
{
	public enum PackageTag : uint
	{
		None=0,
		InDevelopment=1,
		Custom=1,
		Local=2,
		Git=4,
		Bundled=8,
		BuiltIn=16,
		VersionLocked=256,
		Installable=512,
		Removable=1024,
		Downloadable=2048,
		Importable=4096,
		Embeddable=8192,
		Published=65536,
		Deprecated=131072,
		Verified=262144,
		Preview=524288,
		Release=1048576
	}
}
