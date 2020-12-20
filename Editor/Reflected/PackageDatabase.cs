using System;

namespace TNRD.PackageManager.Reflected
{
    public sealed partial class PackageDatabase
    {
        public static IPackageDatabase GetInstance()
        {
            Type type = Type.GetType("UnityEditor.PackageManager.UI.PackageDatabase, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
            PackageDatabase packageDatabase = new PackageDatabase(type);
            return packageDatabase.instance;
        }
    }
}