// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageManagerPrefs, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.UI;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageManagerPrefs : ReflectiveClass
	{
		private ReflectiveField<string> field_kSkipRemoveConfirmationPrefs;
		private ReflectiveField<string> field_kSkipDisableConfirmationPrefs;
		private ReflectiveField<string> field_kShowPackageDependenciesPrefs;
		private ReflectiveField<string> field_kShowPreviewPackagesPrefKeyPrefix;
		private ReflectiveField<string> field_kShowPreviewPackagesWarningPrefs;
		private ReflectiveField<string> field_kLastUsedFilterPrefix;
		private ReflectiveProperty<bool> property_SkipRemoveConfirmation;
		private ReflectiveProperty<bool> property_SkipDisableConfirmation;
		private ReflectiveProperty<bool> property_ShowPackageDependencies;
		private ReflectiveProperty<bool> property_HasShowPreviewPackagesKey;
		private ReflectiveProperty<bool> property_ShowPreviewPackagesFromInstalled;
		private ReflectiveProperty<bool> property_ShowPreviewPackages;
		private ReflectiveProperty<bool> property_ShowPreviewPackagesWarning;
		private ReflectiveProperty property_LastUsedPackageFilter;
		private ReflectiveMethod method_GetProjectIdentifier_1;
		public PackageManagerPrefs(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageManagerPrefs(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_kSkipRemoveConfirmationPrefs = CreateField<string>("kSkipRemoveConfirmationPrefs", BindingFlags.Static | BindingFlags.NonPublic);
			field_kSkipDisableConfirmationPrefs = CreateField<string>("kSkipDisableConfirmationPrefs", BindingFlags.Static | BindingFlags.NonPublic);
			field_kShowPackageDependenciesPrefs = CreateField<string>("kShowPackageDependenciesPrefs", BindingFlags.Static | BindingFlags.NonPublic);
			field_kShowPreviewPackagesPrefKeyPrefix = CreateField<string>("kShowPreviewPackagesPrefKeyPrefix", BindingFlags.Static | BindingFlags.NonPublic);
			field_kShowPreviewPackagesWarningPrefs = CreateField<string>("kShowPreviewPackagesWarningPrefs", BindingFlags.Static | BindingFlags.NonPublic);
			field_kLastUsedFilterPrefix = CreateField<string>("kLastUsedFilterPrefix", BindingFlags.Static | BindingFlags.NonPublic);
			property_SkipRemoveConfirmation = CreateProperty<bool>("SkipRemoveConfirmation", BindingFlags.Static | BindingFlags.Public);
			property_SkipDisableConfirmation = CreateProperty<bool>("SkipDisableConfirmation", BindingFlags.Static | BindingFlags.Public);
			property_ShowPackageDependencies = CreateProperty<bool>("ShowPackageDependencies", BindingFlags.Static | BindingFlags.Public);
			property_HasShowPreviewPackagesKey = CreateProperty<bool>("HasShowPreviewPackagesKey", BindingFlags.Static | BindingFlags.Public);
			property_ShowPreviewPackagesFromInstalled = CreateProperty<bool>("ShowPreviewPackagesFromInstalled", BindingFlags.Static | BindingFlags.Public);
			property_ShowPreviewPackages = CreateProperty<bool>("ShowPreviewPackages", BindingFlags.Static | BindingFlags.Public);
			property_ShowPreviewPackagesWarning = CreateProperty<bool>("ShowPreviewPackagesWarning", BindingFlags.Static | BindingFlags.Public);
			property_LastUsedPackageFilter = CreateProperty("LastUsedPackageFilter", BindingFlags.Static | BindingFlags.Public);
			method_GetProjectIdentifier_1 = CreateMethod("GetProjectIdentifier", BindingFlags.Static | BindingFlags.NonPublic, null);
		}
		partial void Initialize();
		public string kSkipRemoveConfirmationPrefs
		{
			get => field_kSkipRemoveConfirmationPrefs.GetValue();
			set => field_kSkipRemoveConfirmationPrefs.SetValue(value);
		}
		public string kSkipDisableConfirmationPrefs
		{
			get => field_kSkipDisableConfirmationPrefs.GetValue();
			set => field_kSkipDisableConfirmationPrefs.SetValue(value);
		}
		public string kShowPackageDependenciesPrefs
		{
			get => field_kShowPackageDependenciesPrefs.GetValue();
			set => field_kShowPackageDependenciesPrefs.SetValue(value);
		}
		public string kShowPreviewPackagesPrefKeyPrefix
		{
			get => field_kShowPreviewPackagesPrefKeyPrefix.GetValue();
			set => field_kShowPreviewPackagesPrefKeyPrefix.SetValue(value);
		}
		public string kShowPreviewPackagesWarningPrefs
		{
			get => field_kShowPreviewPackagesWarningPrefs.GetValue();
			set => field_kShowPreviewPackagesWarningPrefs.SetValue(value);
		}
		public string kLastUsedFilterPrefix
		{
			get => field_kLastUsedFilterPrefix.GetValue();
			set => field_kLastUsedFilterPrefix.SetValue(value);
		}
		public bool SkipRemoveConfirmation
		{
			get => property_SkipRemoveConfirmation.GetValue();
			set => property_SkipRemoveConfirmation.SetValue(value);
		}
		public bool SkipDisableConfirmation
		{
			get => property_SkipDisableConfirmation.GetValue();
			set => property_SkipDisableConfirmation.SetValue(value);
		}
		public bool ShowPackageDependencies
		{
			get => property_ShowPackageDependencies.GetValue();
			set => property_ShowPackageDependencies.SetValue(value);
		}
		public bool HasShowPreviewPackagesKey
		{
			get => property_HasShowPreviewPackagesKey.GetValue();
		}
		public bool ShowPreviewPackagesFromInstalled
		{
			get => property_ShowPreviewPackagesFromInstalled.GetValue();
			set => property_ShowPreviewPackagesFromInstalled.SetValue(value);
		}
		public bool ShowPreviewPackages
		{
			get => property_ShowPreviewPackages.GetValue();
			set => property_ShowPreviewPackages.SetValue(value);
		}
		public bool ShowPreviewPackagesWarning
		{
			get => property_ShowPreviewPackagesWarning.GetValue();
			set => property_ShowPreviewPackagesWarning.SetValue(value);
		}
		public PackageFilter LastUsedPackageFilter
		{
			get
			{
				object _temp = (int)property_LastUsedPackageFilter.GetValue();
				return (PackageFilter)_temp;
			}
			set => property_LastUsedPackageFilter.SetValue((int)value);
		}
		public string GetProjectIdentifier()
		{
			return (string) method_GetProjectIdentifier_1.Invoke();
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageManagerPrefs, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
