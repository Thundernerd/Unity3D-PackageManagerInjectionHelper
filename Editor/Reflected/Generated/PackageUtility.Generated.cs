// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageUtility, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageUtility : ReflectiveClass
	{
		private ReflectiveMethod method_BuildExportPackageItemsList_1;
		private ReflectiveMethod method_ExportPackage_1;
		private ReflectiveMethod method_ExportPackageAndPackageManagerManifest_1;
		private ReflectiveMethod method_ExtractAndPrepareAssetList_1;
		private ReflectiveMethod method_ImportPackageAssets_1;
		private ReflectiveMethod method_ImportPackageAssetsImmediately_1;
		private ReflectiveMethod method_ImportPackageAssetsCancelledFromGUI_1;
		private ReflectiveMethod method_TickPackageImport_1;
		public PackageUtility(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageUtility(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			method_BuildExportPackageItemsList_1 = CreateMethod("BuildExportPackageItemsList", BindingFlags.Static | BindingFlags.Public, typeof(string[]),typeof(bool));
			method_ExportPackage_1 = CreateMethod("ExportPackage", BindingFlags.Static | BindingFlags.Public, typeof(string[]),typeof(string));
			method_ExportPackageAndPackageManagerManifest_1 = CreateMethod("ExportPackageAndPackageManagerManifest", BindingFlags.Static | BindingFlags.Public, typeof(string[]),typeof(string));
			method_ExtractAndPrepareAssetList_1 = CreateMethod("ExtractAndPrepareAssetList", BindingFlags.Static | BindingFlags.Public, typeof(string),typeof(string),typeof(bool),typeof(string));
			method_ImportPackageAssets_1 = CreateMethod("ImportPackageAssets", BindingFlags.Static | BindingFlags.Public, typeof(string),typeof(ImportPackageItem[]),typeof(bool));
			method_ImportPackageAssetsImmediately_1 = CreateMethod("ImportPackageAssetsImmediately", BindingFlags.Static | BindingFlags.Public, typeof(string),typeof(ImportPackageItem[]),typeof(bool));
			method_ImportPackageAssetsCancelledFromGUI_1 = CreateMethod("ImportPackageAssetsCancelledFromGUI", BindingFlags.Static | BindingFlags.Public, typeof(string),typeof(ImportPackageItem[]));
			method_TickPackageImport_1 = CreateMethod("TickPackageImport", BindingFlags.Static | BindingFlags.Public, null);
		}
		partial void Initialize();
		public ExportPackageItem[] BuildExportPackageItemsList(string[] guids,bool dependencies)
		{
			return (ExportPackageItem[]) method_BuildExportPackageItemsList_1.Invoke(guids,dependencies);
		}
		public void ExportPackage(string[] guids,string fileName)
		{
			method_ExportPackage_1.Invoke(guids,fileName);
		}
		public void ExportPackageAndPackageManagerManifest(string[] guids,string fileName)
		{
			method_ExportPackageAndPackageManagerManifest_1.Invoke(guids,fileName);
		}
		public ImportPackageItem[] ExtractAndPrepareAssetList(string packagePath,ref string packageIconPath,ref bool canPerformReInstall,ref string packageManagerDependenciesPath)
		{
			return (ImportPackageItem[]) method_ExtractAndPrepareAssetList_1.Invoke(packagePath,packageIconPath,canPerformReInstall,packageManagerDependenciesPath);
		}
		public void ImportPackageAssets(string packageName,ImportPackageItem[] items,bool performReInstall)
		{
			method_ImportPackageAssets_1.Invoke(packageName,items,performReInstall);
		}
		public void ImportPackageAssetsImmediately(string packageName,ImportPackageItem[] items,bool performReInstall)
		{
			method_ImportPackageAssetsImmediately_1.Invoke(packageName,items,performReInstall);
		}
		public void ImportPackageAssetsCancelledFromGUI(string packageName,ImportPackageItem[] items)
		{
			method_ImportPackageAssetsCancelledFromGUI_1.Invoke(packageName,items);
		}
		public void TickPackageImport()
		{
			method_TickPackageImport_1.Invoke();
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageUtility, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
