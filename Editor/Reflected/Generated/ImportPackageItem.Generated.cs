// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.ImportPackageItem, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class ImportPackageItem : ReflectiveClass
	{
		private ReflectiveField<string> field_exportedAssetPath;
		private ReflectiveField<string> field_destinationAssetPath;
		private ReflectiveField<string> field_sourceFolder;
		private ReflectiveField<string> field_previewPath;
		private ReflectiveField<string> field_guid;
		private ReflectiveField<int> field_enabledStatus;
		private ReflectiveField<bool> field_isFolder;
		private ReflectiveField<bool> field_exists;
		private ReflectiveField<bool> field_assetChanged;
		private ReflectiveField<bool> field_pathConflict;
		private ReflectiveField<bool> field_projectAsset;
		public ImportPackageItem(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public ImportPackageItem(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_exportedAssetPath = CreateField<string>("exportedAssetPath", BindingFlags.Instance | BindingFlags.Public);
			field_destinationAssetPath = CreateField<string>("destinationAssetPath", BindingFlags.Instance | BindingFlags.Public);
			field_sourceFolder = CreateField<string>("sourceFolder", BindingFlags.Instance | BindingFlags.Public);
			field_previewPath = CreateField<string>("previewPath", BindingFlags.Instance | BindingFlags.Public);
			field_guid = CreateField<string>("guid", BindingFlags.Instance | BindingFlags.Public);
			field_enabledStatus = CreateField<int>("enabledStatus", BindingFlags.Instance | BindingFlags.Public);
			field_isFolder = CreateField<bool>("isFolder", BindingFlags.Instance | BindingFlags.Public);
			field_exists = CreateField<bool>("exists", BindingFlags.Instance | BindingFlags.Public);
			field_assetChanged = CreateField<bool>("assetChanged", BindingFlags.Instance | BindingFlags.Public);
			field_pathConflict = CreateField<bool>("pathConflict", BindingFlags.Instance | BindingFlags.Public);
			field_projectAsset = CreateField<bool>("projectAsset", BindingFlags.Instance | BindingFlags.Public);
		}
		partial void Initialize();
		public string exportedAssetPath
		{
			get => field_exportedAssetPath.GetValue();
			set => field_exportedAssetPath.SetValue(value);
		}
		public string destinationAssetPath
		{
			get => field_destinationAssetPath.GetValue();
			set => field_destinationAssetPath.SetValue(value);
		}
		public string sourceFolder
		{
			get => field_sourceFolder.GetValue();
			set => field_sourceFolder.SetValue(value);
		}
		public string previewPath
		{
			get => field_previewPath.GetValue();
			set => field_previewPath.SetValue(value);
		}
		public string guid
		{
			get => field_guid.GetValue();
			set => field_guid.SetValue(value);
		}
		public int enabledStatus
		{
			get => field_enabledStatus.GetValue();
			set => field_enabledStatus.SetValue(value);
		}
		public bool isFolder
		{
			get => field_isFolder.GetValue();
			set => field_isFolder.SetValue(value);
		}
		public bool exists
		{
			get => field_exists.GetValue();
			set => field_exists.SetValue(value);
		}
		public bool assetChanged
		{
			get => field_assetChanged.GetValue();
			set => field_assetChanged.SetValue(value);
		}
		public bool pathConflict
		{
			get => field_pathConflict.GetValue();
			set => field_pathConflict.SetValue(value);
		}
		public bool projectAsset
		{
			get => field_projectAsset.GetValue();
			set => field_projectAsset.SetValue(value);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.ImportPackageItem, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
