// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.PackageTemplateOptions, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageTemplateOptions : ReflectiveClass
	{
		private ReflectiveProperty<string> property_name;
		private ReflectiveProperty<string> property_displayName;
		private ReflectiveProperty<string> property_rootNamespace;
		public PackageTemplateOptions(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageTemplateOptions(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			property_name = CreateProperty<string>("name", BindingFlags.Instance | BindingFlags.Public);
			property_displayName = CreateProperty<string>("displayName", BindingFlags.Instance | BindingFlags.Public);
			property_rootNamespace = CreateProperty<string>("rootNamespace", BindingFlags.Instance | BindingFlags.Public);
		}
		partial void Initialize();
		public string name
		{
			get => property_name.GetValue();
			set => property_name.SetValue(value);
		}
		public string displayName
		{
			get => property_displayName.GetValue();
			set => property_displayName.SetValue(value);
		}
		public string rootNamespace
		{
			get => property_rootNamespace.GetValue();
			set => property_rootNamespace.SetValue(value);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.PackageTemplateOptions, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
