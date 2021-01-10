// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManagerUtilityInternal, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageManagerUtilityInternal : ReflectiveClass
	{
		private ReflectiveProperty<int> property_HiddenPackagesCount;
		private ReflectiveMethod method_GetAllVisiblePackages_1;
		private ReflectiveMethod method_IsPathInVisiblePackage_1;
		public PackageManagerUtilityInternal(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageManagerUtilityInternal(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			property_HiddenPackagesCount = CreateProperty<int>("HiddenPackagesCount", BindingFlags.Static | BindingFlags.Public);
			method_GetAllVisiblePackages_1 = CreateMethod("GetAllVisiblePackages", BindingFlags.Static | BindingFlags.Public, typeof(bool));
			method_IsPathInVisiblePackage_1 = CreateMethod("IsPathInVisiblePackage", BindingFlags.Static | BindingFlags.Public, typeof(string));
		}
		partial void Initialize();
		public int HiddenPackagesCount
		{
			get => property_HiddenPackagesCount.GetValue();
		}
		public PackageInfo[] GetAllVisiblePackages(bool skipHiddenPackages)
		{
			return (PackageInfo[]) method_GetAllVisiblePackages_1.Invoke(skipHiddenPackages);
		}
		public bool IsPathInVisiblePackage(string path)
		{
			return (bool) method_IsPathInVisiblePackage_1.Invoke(path);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManagerUtilityInternal, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
