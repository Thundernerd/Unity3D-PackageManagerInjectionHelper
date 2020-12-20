// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageProgress, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager.UI;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageProgress : ReflectiveClass
	{
		private ReflectiveField<int> field_value_;
		private ReflectiveField field_None;
		private ReflectiveField field_Refreshing;
		private ReflectiveField field_Downloading;
		private ReflectiveField field_Installing;
		private ReflectiveField field_Removing;

		public PackageProgress(object instance) : base(instance)
		{
			field_value_ = CreateField<int>("value_", BindingFlags.Instance | BindingFlags.Public);
			field_None = CreateField("None", BindingFlags.Static | BindingFlags.Public);
			field_Refreshing = CreateField("Refreshing", BindingFlags.Static | BindingFlags.Public);
			field_Downloading = CreateField("Downloading", BindingFlags.Static | BindingFlags.Public);
			field_Installing = CreateField("Installing", BindingFlags.Static | BindingFlags.Public);
			field_Removing = CreateField("Removing", BindingFlags.Static | BindingFlags.Public);
		}

		public int value_
		{
			get => field_value_.GetValue();
			set => field_value_.SetValue(value);
		}
		public PackageProgress None
		{
			get => new PackageProgress(field_None.GetValue());
			set => field_None.SetValue(value.Instance);
		}
		public PackageProgress Refreshing
		{
			get => new PackageProgress(field_Refreshing.GetValue());
			set => field_Refreshing.SetValue(value.Instance);
		}
		public PackageProgress Downloading
		{
			get => new PackageProgress(field_Downloading.GetValue());
			set => field_Downloading.SetValue(value.Instance);
		}
		public PackageProgress Installing
		{
			get => new PackageProgress(field_Installing.GetValue());
			set => field_Installing.SetValue(value.Instance);
		}
		public PackageProgress Removing
		{
			get => new PackageProgress(field_Removing.GetValue());
			set => field_Removing.SetValue(value.Instance);
		}
	}
}
