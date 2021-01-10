// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.DependencyInfo, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class DependencyInfo : ReflectiveClass
	{
		private ReflectiveField<string> field_mName;
		private ReflectiveField<string> field_mVersion;
		private ReflectiveProperty<string> property_version;
		private ReflectiveProperty<string> property_name;
		public DependencyInfo(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public DependencyInfo(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_mName = CreateField<string>("mName", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mVersion = CreateField<string>("mVersion", BindingFlags.Instance | BindingFlags.NonPublic);
			property_version = CreateProperty<string>("version", BindingFlags.Instance | BindingFlags.Public);
			property_name = CreateProperty<string>("name", BindingFlags.Instance | BindingFlags.Public);
		}
		partial void Initialize();
		public string mName
		{
			get => field_mName.GetValue();
			set => field_mName.SetValue(value);
		}
		public string mVersion
		{
			get => field_mVersion.GetValue();
			set => field_mVersion.SetValue(value);
		}
		public string version
		{
			get => property_version.GetValue();
		}
		public string name
		{
			get => property_name.GetValue();
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.DependencyInfo, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
