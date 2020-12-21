// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.VisualState, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class VisualState : ReflectiveClass
	{
		private ReflectiveField<string> field_packageUniqueId;
		private ReflectiveField<string> field_groupName;
		private ReflectiveField<bool> field_visible;
		private ReflectiveField<bool> field_expanded;
		private ReflectiveField<bool> field_seeAllVersions;
		private ReflectiveField<string> field_selectedVersionId;
		private ReflectiveMethod method_Equals_1;
		private ReflectiveMethod method_Clone_1;
		public VisualState(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public VisualState(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_packageUniqueId = CreateField<string>("packageUniqueId", BindingFlags.Instance | BindingFlags.Public);
			field_groupName = CreateField<string>("groupName", BindingFlags.Instance | BindingFlags.Public);
			field_visible = CreateField<bool>("visible", BindingFlags.Instance | BindingFlags.Public);
			field_expanded = CreateField<bool>("expanded", BindingFlags.Instance | BindingFlags.Public);
			field_seeAllVersions = CreateField<bool>("seeAllVersions", BindingFlags.Instance | BindingFlags.Public);
			field_selectedVersionId = CreateField<string>("selectedVersionId", BindingFlags.Instance | BindingFlags.Public);
			method_Equals_1 = CreateMethod("Equals", BindingFlags.Instance | BindingFlags.Public, typeof(VisualState));
			method_Clone_1 = CreateMethod("Clone", BindingFlags.Instance | BindingFlags.Public, null);
		}
		partial void Initialize();
		public string packageUniqueId
		{
			get => field_packageUniqueId.GetValue();
			set => field_packageUniqueId.SetValue(value);
		}
		public string groupName
		{
			get => field_groupName.GetValue();
			set => field_groupName.SetValue(value);
		}
		public bool visible
		{
			get => field_visible.GetValue();
			set => field_visible.SetValue(value);
		}
		public bool expanded
		{
			get => field_expanded.GetValue();
			set => field_expanded.SetValue(value);
		}
		public bool seeAllVersions
		{
			get => field_seeAllVersions.GetValue();
			set => field_seeAllVersions.SetValue(value);
		}
		public string selectedVersionId
		{
			get => field_selectedVersionId.GetValue();
			set => field_selectedVersionId.SetValue(value);
		}
		public bool Equals(VisualState other)
		{
			return (bool) method_Equals_1.Invoke(other);
		}
		public VisualState Clone()
		{
			return new VisualState(method_Clone_1.Invoke());
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.VisualState, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
