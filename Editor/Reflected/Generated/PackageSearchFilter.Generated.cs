// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageSearchFilter, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageSearchFilter : ReflectiveClass
	{
		private ReflectiveField<string> field_SearchText;
		public PackageSearchFilter(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageSearchFilter(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_SearchText = CreateField<string>("SearchText", BindingFlags.Instance | BindingFlags.Public);
		}
		partial void Initialize();
		public string SearchText
		{
			get => field_SearchText.GetValue();
			set => field_SearchText.SetValue(value);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageSearchFilter, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
