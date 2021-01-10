// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageFiltering, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageFiltering : ReflectiveClass
	{
		private ReflectiveMethod method_FilterByText_1;
		private ReflectiveMethod method_FilterByText_2;
		private ReflectiveMethod method_FilterByText_3;
		private ReflectiveMethod method_FilterPackageList_1;
		public PackageFiltering(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageFiltering(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			method_FilterByText_1 = CreateMethod("FilterByText", BindingFlags.Static | BindingFlags.NonPublic, typeof(PackageInfo),typeof(string));
			method_FilterByText_2 = CreateMethod("FilterByText", BindingFlags.Static | BindingFlags.NonPublic, typeof(Package),typeof(string));
			method_FilterByText_3 = CreateMethod("FilterByText", BindingFlags.Static | BindingFlags.NonPublic, typeof(PackageItem),typeof(string));
			method_FilterPackageList_1 = CreateMethod("FilterPackageList", BindingFlags.Static | BindingFlags.Public, typeof(PackageList));
		}
		partial void Initialize();
		public bool FilterByText(PackageInfo info,string text)
		{
			return (bool) method_FilterByText_1.Invoke(info,text);
		}
		public bool FilterByText(Package package,string text)
		{
			return (bool) method_FilterByText_2.Invoke(package,text);
		}
		public bool FilterByText(PackageItem item,string text)
		{
			return (bool) method_FilterByText_3.Invoke(item,text);
		}
		public void FilterPackageList(PackageList packageList)
		{
			method_FilterPackageList_1.Invoke(packageList);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageFiltering, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
