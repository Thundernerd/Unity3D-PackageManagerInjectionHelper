// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageLink, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageLink : ReflectiveClass
	{
		private ReflectiveField<string> field_name;
		private ReflectiveField<string> field_url;
		public PackageLink(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageLink(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_name = CreateField<string>("name", BindingFlags.Instance | BindingFlags.Public);
			field_url = CreateField<string>("url", BindingFlags.Instance | BindingFlags.Public);
		}
		partial void Initialize();
		public string name
		{
			get => field_name.GetValue();
			set => field_name.SetValue(value);
		}
		public string url
		{
			get => field_url.GetValue();
			set => field_url.SetValue(value);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageLink, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
