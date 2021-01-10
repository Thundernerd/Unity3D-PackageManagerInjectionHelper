// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageManagerExtensions, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.UI;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageManagerExtensions : ReflectiveClass
	{
		private ReflectiveField<List<IPackageManagerExtension>> field_extensions;
		private ReflectiveProperty<List<IPackageManagerExtension>> property_Extensions;
		private ReflectiveMethod method_RegisterExtension_1;
		public PackageManagerExtensions(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageManagerExtensions(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_extensions = CreateField<List<IPackageManagerExtension>>("extensions", BindingFlags.Static | BindingFlags.NonPublic);
			property_Extensions = CreateProperty<List<IPackageManagerExtension>>("Extensions", BindingFlags.Static | BindingFlags.NonPublic);
			method_RegisterExtension_1 = CreateMethod("RegisterExtension", BindingFlags.Static | BindingFlags.Public, typeof(IPackageManagerExtension));
		}
		partial void Initialize();
		public List<IPackageManagerExtension> extensions
		{
			get => field_extensions.GetValue();
			set => field_extensions.SetValue(value);
		}
		public List<IPackageManagerExtension> Extensions
		{
			get => property_Extensions.GetValue();
		}
		public void RegisterExtension(IPackageManagerExtension extension)
		{
			method_RegisterExtension_1.Invoke(extension);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageManagerExtensions, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
