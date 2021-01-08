namespace TNRD.PackageManager.Reflected
{
    public sealed partial class PackageDatabase
    {
        public static IPackageDatabase GetInstance()
        {
            PackageDatabase packageDatabase = new PackageDatabase(GetOriginalType());
            return packageDatabase.instance;
        }
    }
}