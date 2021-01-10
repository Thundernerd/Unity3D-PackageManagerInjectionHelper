// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageListExtensions, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.UI;
using System.Collections.Generic;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageListExtensions : ReflectiveClass
	{
		private ReflectiveMethod method_Current_1;
		public PackageListExtensions(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageListExtensions(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			method_Current_1 = CreateMethod("Current", BindingFlags.Static | BindingFlags.Public, typeof(IEnumerable<Package>));
		}
		partial void Initialize();
		public IEnumerable<Package> Current(IEnumerable<Package> list)
		{
			return Utilities.GenerateEnumerable<Package>(method_Current_1.Invoke(list));
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageListExtensions, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
