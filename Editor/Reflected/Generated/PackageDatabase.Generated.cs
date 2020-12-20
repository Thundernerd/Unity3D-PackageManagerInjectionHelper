// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageDatabase, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------

using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager.UI;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageDatabase : ReflectiveClass
	{
		private ReflectiveProperty property_instance;

		public PackageDatabase(object instance) : base(instance)
		{
			property_instance = CreateProperty("instance", BindingFlags.Static | BindingFlags.Public);
		}

		public PackageDatabase(Type type) : base(type)
		{
			property_instance = CreateProperty("instance", BindingFlags.Static | BindingFlags.Public);
		}
		
		public IPackageDatabase instance
		{
			get => new IPackageDatabase(property_instance.GetValue());
		}
	}
}
