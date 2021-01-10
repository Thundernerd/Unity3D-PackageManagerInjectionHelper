// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.PackageInfo, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
using System.Collections.Generic;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageInfo : ReflectiveClass
	{
		private ReflectiveField<string> field_mPackageId;
		private ReflectiveField<bool> field_mIsDirectDependency;
		private ReflectiveField<string> field_mVersion;
		private ReflectiveField<PackageSource> field_mSource;
		private ReflectiveField<string> field_mResolvedPath;
		private ReflectiveField<string> field_mAssetPath;
		private ReflectiveField<string> field_mName;
		private ReflectiveField<string> field_mDisplayName;
		private ReflectiveField<string> field_mCategory;
		private ReflectiveField<string> field_mType;
		private ReflectiveField<string> field_mDescription;
		private ReflectiveField<PackageStatus> field_mStatus;
		private ReflectiveField<Error[]> field_mErrors;
		private ReflectiveField<VersionsInfo> field_mVersions;
		private ReflectiveField<DependencyInfo[]> field_mDependencies;
		private ReflectiveField<DependencyInfo[]> field_mResolvedDependencies;
		private ReflectiveField<string[]> field_mKeywords;
		private ReflectiveField<AuthorInfo> field_mAuthor;
		private ReflectiveField<bool> field_mHasRegistry;
		private ReflectiveField<RegistryInfo> field_mRegistry;
		private ReflectiveField<bool> field_mHideInEditor;
		private ReflectiveField<long> field_mDatePublishedTicks;
		private ReflectiveProperty<string> property_packageId;
		private ReflectiveProperty<bool> property_isDirectDependency;
		private ReflectiveProperty<string> property_version;
		private ReflectiveProperty<PackageSource> property_source;
		private ReflectiveProperty<string> property_resolvedPath;
		private ReflectiveProperty<string> property_assetPath;
		private ReflectiveProperty<string> property_name;
		private ReflectiveProperty<string> property_displayName;
		private ReflectiveProperty<string> property_category;
		private ReflectiveProperty<string> property_type;
		private ReflectiveProperty<string> property_description;
		private ReflectiveProperty<PackageStatus> property_status;
		private ReflectiveProperty<Error[]> property_errors;
		private ReflectiveProperty<VersionsInfo> property_versions;
		private ReflectiveProperty<DependencyInfo[]> property_dependencies;
		private ReflectiveProperty<DependencyInfo[]> property_resolvedDependencies;
		private ReflectiveProperty<string[]> property_keywords;
		private ReflectiveProperty<AuthorInfo> property_author;
		private ReflectiveProperty<bool> property_hideInEditor;
		private ReflectiveProperty<RegistryInfo> property_registry;
		private ReflectiveProperty<DateTime?> property_datePublished;
		private ReflectiveMethod method_FindForAssetPath_1;
		private ReflectiveMethod method_FindForAssembly_1;
		private ReflectiveMethod method_GetPathForPackageAssemblyName_1;
		private ReflectiveMethod method_GetRelativePathForAssemblyFilePath_1;
		private ReflectiveMethod method_GetForAssemblyFilePaths_1;
		private ReflectiveMethod method_GetAll_1;
		private ReflectiveMethod method_GetPredefinedPackageTypes_1;
		private ReflectiveMethod method_GetPredefinedHiddenByDefaultPackageTypes_1;
		private ReflectiveMethod method_TryGetForAssetPath_1;
		public PackageInfo(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageInfo(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_mPackageId = CreateField<string>("mPackageId", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mIsDirectDependency = CreateField<bool>("mIsDirectDependency", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mVersion = CreateField<string>("mVersion", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mSource = CreateField<PackageSource>("mSource", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mResolvedPath = CreateField<string>("mResolvedPath", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mAssetPath = CreateField<string>("mAssetPath", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mName = CreateField<string>("mName", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mDisplayName = CreateField<string>("mDisplayName", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mCategory = CreateField<string>("mCategory", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mType = CreateField<string>("mType", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mDescription = CreateField<string>("mDescription", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mStatus = CreateField<PackageStatus>("mStatus", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mErrors = CreateField<Error[]>("mErrors", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mVersions = CreateField<VersionsInfo>("mVersions", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mDependencies = CreateField<DependencyInfo[]>("mDependencies", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mResolvedDependencies = CreateField<DependencyInfo[]>("mResolvedDependencies", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mKeywords = CreateField<string[]>("mKeywords", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mAuthor = CreateField<AuthorInfo>("mAuthor", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mHasRegistry = CreateField<bool>("mHasRegistry", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mRegistry = CreateField<RegistryInfo>("mRegistry", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mHideInEditor = CreateField<bool>("mHideInEditor", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mDatePublishedTicks = CreateField<long>("mDatePublishedTicks", BindingFlags.Instance | BindingFlags.NonPublic);
			property_packageId = CreateProperty<string>("packageId", BindingFlags.Instance | BindingFlags.Public);
			property_isDirectDependency = CreateProperty<bool>("isDirectDependency", BindingFlags.Instance | BindingFlags.Public);
			property_version = CreateProperty<string>("version", BindingFlags.Instance | BindingFlags.Public);
			property_source = CreateProperty<PackageSource>("source", BindingFlags.Instance | BindingFlags.Public);
			property_resolvedPath = CreateProperty<string>("resolvedPath", BindingFlags.Instance | BindingFlags.Public);
			property_assetPath = CreateProperty<string>("assetPath", BindingFlags.Instance | BindingFlags.Public);
			property_name = CreateProperty<string>("name", BindingFlags.Instance | BindingFlags.Public);
			property_displayName = CreateProperty<string>("displayName", BindingFlags.Instance | BindingFlags.Public);
			property_category = CreateProperty<string>("category", BindingFlags.Instance | BindingFlags.Public);
			property_type = CreateProperty<string>("type", BindingFlags.Instance | BindingFlags.Public);
			property_description = CreateProperty<string>("description", BindingFlags.Instance | BindingFlags.Public);
			property_status = CreateProperty<PackageStatus>("status", BindingFlags.Instance | BindingFlags.Public);
			property_errors = CreateProperty<Error[]>("errors", BindingFlags.Instance | BindingFlags.Public);
			property_versions = CreateProperty<VersionsInfo>("versions", BindingFlags.Instance | BindingFlags.Public);
			property_dependencies = CreateProperty<DependencyInfo[]>("dependencies", BindingFlags.Instance | BindingFlags.Public);
			property_resolvedDependencies = CreateProperty<DependencyInfo[]>("resolvedDependencies", BindingFlags.Instance | BindingFlags.Public);
			property_keywords = CreateProperty<string[]>("keywords", BindingFlags.Instance | BindingFlags.Public);
			property_author = CreateProperty<AuthorInfo>("author", BindingFlags.Instance | BindingFlags.Public);
			property_hideInEditor = CreateProperty<bool>("hideInEditor", BindingFlags.Instance | BindingFlags.NonPublic);
			property_registry = CreateProperty<RegistryInfo>("registry", BindingFlags.Instance | BindingFlags.Public);
			property_datePublished = CreateProperty<DateTime?>("datePublished", BindingFlags.Instance | BindingFlags.Public);
			method_FindForAssetPath_1 = CreateMethod("FindForAssetPath", BindingFlags.Static | BindingFlags.Public, typeof(string));
			method_FindForAssembly_1 = CreateMethod("FindForAssembly", BindingFlags.Static | BindingFlags.Public, typeof(Assembly));
			method_GetPathForPackageAssemblyName_1 = CreateMethod("GetPathForPackageAssemblyName", BindingFlags.Static | BindingFlags.NonPublic, typeof(string));
			method_GetRelativePathForAssemblyFilePath_1 = CreateMethod("GetRelativePathForAssemblyFilePath", BindingFlags.Static | BindingFlags.NonPublic, typeof(string));
			method_GetForAssemblyFilePaths_1 = CreateMethod("GetForAssemblyFilePaths", BindingFlags.Static | BindingFlags.NonPublic, typeof(List<string>));
			method_GetAll_1 = CreateMethod("GetAll", BindingFlags.Static | BindingFlags.NonPublic, null);
			method_GetPredefinedPackageTypes_1 = CreateMethod("GetPredefinedPackageTypes", BindingFlags.Static | BindingFlags.NonPublic, null);
			method_GetPredefinedHiddenByDefaultPackageTypes_1 = CreateMethod("GetPredefinedHiddenByDefaultPackageTypes", BindingFlags.Static | BindingFlags.NonPublic, null);
			method_TryGetForAssetPath_1 = CreateMethod("TryGetForAssetPath", BindingFlags.Static | BindingFlags.NonPublic, typeof(string),typeof(PackageInfo));
		}
		partial void Initialize();
		public string mPackageId
		{
			get => field_mPackageId.GetValue();
			set => field_mPackageId.SetValue(value);
		}
		public bool mIsDirectDependency
		{
			get => field_mIsDirectDependency.GetValue();
			set => field_mIsDirectDependency.SetValue(value);
		}
		public string mVersion
		{
			get => field_mVersion.GetValue();
			set => field_mVersion.SetValue(value);
		}
		public PackageSource mSource
		{
			get => field_mSource.GetValue();
			set => field_mSource.SetValue(value);
		}
		public string mResolvedPath
		{
			get => field_mResolvedPath.GetValue();
			set => field_mResolvedPath.SetValue(value);
		}
		public string mAssetPath
		{
			get => field_mAssetPath.GetValue();
			set => field_mAssetPath.SetValue(value);
		}
		public string mName
		{
			get => field_mName.GetValue();
			set => field_mName.SetValue(value);
		}
		public string mDisplayName
		{
			get => field_mDisplayName.GetValue();
			set => field_mDisplayName.SetValue(value);
		}
		public string mCategory
		{
			get => field_mCategory.GetValue();
			set => field_mCategory.SetValue(value);
		}
		public string mType
		{
			get => field_mType.GetValue();
			set => field_mType.SetValue(value);
		}
		public string mDescription
		{
			get => field_mDescription.GetValue();
			set => field_mDescription.SetValue(value);
		}
		public PackageStatus mStatus
		{
			get => field_mStatus.GetValue();
			set => field_mStatus.SetValue(value);
		}
		public Error[] mErrors
		{
			get => field_mErrors.GetValue();
			set => field_mErrors.SetValue(value);
		}
		public VersionsInfo mVersions
		{
			get => field_mVersions.GetValue();
			set => field_mVersions.SetValue(value);
		}
		public DependencyInfo[] mDependencies
		{
			get => field_mDependencies.GetValue();
			set => field_mDependencies.SetValue(value);
		}
		public DependencyInfo[] mResolvedDependencies
		{
			get => field_mResolvedDependencies.GetValue();
			set => field_mResolvedDependencies.SetValue(value);
		}
		public string[] mKeywords
		{
			get => field_mKeywords.GetValue();
			set => field_mKeywords.SetValue(value);
		}
		public AuthorInfo mAuthor
		{
			get => field_mAuthor.GetValue();
			set => field_mAuthor.SetValue(value);
		}
		public bool mHasRegistry
		{
			get => field_mHasRegistry.GetValue();
			set => field_mHasRegistry.SetValue(value);
		}
		public RegistryInfo mRegistry
		{
			get => field_mRegistry.GetValue();
			set => field_mRegistry.SetValue(value);
		}
		public bool mHideInEditor
		{
			get => field_mHideInEditor.GetValue();
			set => field_mHideInEditor.SetValue(value);
		}
		public long mDatePublishedTicks
		{
			get => field_mDatePublishedTicks.GetValue();
			set => field_mDatePublishedTicks.SetValue(value);
		}
		public string packageId
		{
			get => property_packageId.GetValue();
		}
		public bool isDirectDependency
		{
			get => property_isDirectDependency.GetValue();
		}
		public string version
		{
			get => property_version.GetValue();
		}
		public PackageSource source
		{
			get => property_source.GetValue();
		}
		public string resolvedPath
		{
			get => property_resolvedPath.GetValue();
		}
		public string assetPath
		{
			get => property_assetPath.GetValue();
		}
		public string name
		{
			get => property_name.GetValue();
		}
		public string displayName
		{
			get => property_displayName.GetValue();
		}
		public string category
		{
			get => property_category.GetValue();
		}
		public string type
		{
			get => property_type.GetValue();
		}
		public string description
		{
			get => property_description.GetValue();
		}
		public PackageStatus status
		{
			get => property_status.GetValue();
		}
		public Error[] errors
		{
			get => property_errors.GetValue();
		}
		public VersionsInfo versions
		{
			get => property_versions.GetValue();
		}
		public DependencyInfo[] dependencies
		{
			get => property_dependencies.GetValue();
		}
		public DependencyInfo[] resolvedDependencies
		{
			get => property_resolvedDependencies.GetValue();
		}
		public string[] keywords
		{
			get => property_keywords.GetValue();
		}
		public AuthorInfo author
		{
			get => property_author.GetValue();
		}
		public bool hideInEditor
		{
			get => property_hideInEditor.GetValue();
		}
		public RegistryInfo registry
		{
			get => property_registry.GetValue();
		}
		public DateTime? datePublished
		{
			get => property_datePublished.GetValue();
		}
		public PackageInfo FindForAssetPath(string assetPath)
		{
			return (PackageInfo) method_FindForAssetPath_1.Invoke(assetPath);
		}
		public PackageInfo FindForAssembly(Assembly assembly)
		{
			return (PackageInfo) method_FindForAssembly_1.Invoke(assembly);
		}
		public string GetPathForPackageAssemblyName(string assemblyPath)
		{
			return (string) method_GetPathForPackageAssemblyName_1.Invoke(assemblyPath);
		}
		public string GetRelativePathForAssemblyFilePath(string fullPath)
		{
			return (string) method_GetRelativePathForAssemblyFilePath_1.Invoke(fullPath);
		}
		public List<PackageInfo> GetForAssemblyFilePaths(List<string> assemblyPaths)
		{
			return (List<PackageInfo>) method_GetForAssemblyFilePaths_1.Invoke(assemblyPaths);
		}
		public PackageInfo[] GetAll()
		{
			return (PackageInfo[]) method_GetAll_1.Invoke();
		}
		public string[] GetPredefinedPackageTypes()
		{
			return (string[]) method_GetPredefinedPackageTypes_1.Invoke();
		}
		public string[] GetPredefinedHiddenByDefaultPackageTypes()
		{
			return (string[]) method_GetPredefinedHiddenByDefaultPackageTypes_1.Invoke();
		}
		public bool TryGetForAssetPath(string assetPath,PackageInfo packageInfo)
		{
			return (bool) method_TryGetForAssetPath_1.Invoke(assetPath,packageInfo);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.PackageInfo, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
