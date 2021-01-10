// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.ItemState, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class ItemState : ReflectiveClass
	{
		private ReflectiveField<string> field_PackageId;
		private ReflectiveField<bool> field_Expanded;
		private ReflectiveField<bool> field_SeeAllVersions;
		private ReflectiveField<bool> field_Selected;
		public ItemState(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public ItemState(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_PackageId = CreateField<string>("PackageId", BindingFlags.Instance | BindingFlags.Public);
			field_Expanded = CreateField<bool>("Expanded", BindingFlags.Instance | BindingFlags.Public);
			field_SeeAllVersions = CreateField<bool>("SeeAllVersions", BindingFlags.Instance | BindingFlags.Public);
			field_Selected = CreateField<bool>("Selected", BindingFlags.Instance | BindingFlags.Public);
		}
		partial void Initialize();
		public string PackageId
		{
			get => field_PackageId.GetValue();
			set => field_PackageId.SetValue(value);
		}
		public bool Expanded
		{
			get => field_Expanded.GetValue();
			set => field_Expanded.SetValue(value);
		}
		public bool SeeAllVersions
		{
			get => field_SeeAllVersions.GetValue();
			set => field_SeeAllVersions.SetValue(value);
		}
		public bool Selected
		{
			get => field_Selected.GetValue();
			set => field_Selected.SetValue(value);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.ItemState, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
