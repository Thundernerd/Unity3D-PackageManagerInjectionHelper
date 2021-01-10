// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.ExportPackageItem, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class ExportPackageItem : ReflectiveClass
	{
		private ReflectiveField<string> field_assetPath;
		private ReflectiveField<string> field_guid;
		private ReflectiveField<bool> field_isFolder;
		private ReflectiveField<int> field_enabledStatus;
		public ExportPackageItem(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public ExportPackageItem(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_assetPath = CreateField<string>("assetPath", BindingFlags.Instance | BindingFlags.Public);
			field_guid = CreateField<string>("guid", BindingFlags.Instance | BindingFlags.Public);
			field_isFolder = CreateField<bool>("isFolder", BindingFlags.Instance | BindingFlags.Public);
			field_enabledStatus = CreateField<int>("enabledStatus", BindingFlags.Instance | BindingFlags.Public);
		}
		partial void Initialize();
		public string assetPath
		{
			get => field_assetPath.GetValue();
			set => field_assetPath.SetValue(value);
		}
		public string guid
		{
			get => field_guid.GetValue();
			set => field_guid.SetValue(value);
		}
		public bool isFolder
		{
			get => field_isFolder.GetValue();
			set => field_isFolder.SetValue(value);
		}
		public int enabledStatus
		{
			get => field_enabledStatus.GetValue();
			set => field_enabledStatus.SetValue(value);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.ExportPackageItem, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
