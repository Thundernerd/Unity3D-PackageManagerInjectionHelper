// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.SemVersionExtension, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class SemVersionExtension : ReflectiveClass
	{
		private ReflectiveMethod method_VersionOnly_1;
		private ReflectiveMethod method_ShortVersion_1;
		public SemVersionExtension(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public SemVersionExtension(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			method_VersionOnly_1 = CreateMethod("VersionOnly", BindingFlags.Static | BindingFlags.Public, typeof(SemVersion));
			method_ShortVersion_1 = CreateMethod("ShortVersion", BindingFlags.Static | BindingFlags.Public, typeof(SemVersion));
		}
		partial void Initialize();
		public string VersionOnly(SemVersion version)
		{
			return (string) method_VersionOnly_1.Invoke(version);
		}
		public string ShortVersion(SemVersion version)
		{
			return (string) method_ShortVersion_1.Invoke(version);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.SemVersionExtension, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
