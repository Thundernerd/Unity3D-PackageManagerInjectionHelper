// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageLink, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageLink : ReflectiveClass
	{
		private ReflectiveField<string> field_name;
		private ReflectiveField<string> field_url;

		public PackageLink(object instance) : base(instance)
		{
			field_name = CreateField<string>("name", BindingFlags.Instance | BindingFlags.Public);
			field_url = CreateField<string>("url", BindingFlags.Instance | BindingFlags.Public);
		}

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
	}
}
