// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.IPackageVersion, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.UI;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class IPackageVersion : ReflectiveClass
	{
		private ReflectiveProperty<string> property_name;
		private ReflectiveProperty<string> property_displayName;
		private ReflectiveProperty<string> property_author;
		private ReflectiveProperty<string> property_authorLink;
		private ReflectiveProperty<string> property_description;
		private ReflectiveProperty<string> property_category;
		private ReflectiveProperty<IDictionary<string, string>> property_categoryLinks;
		private ReflectiveProperty<string> property_packageUniqueId;
		private ReflectiveProperty<string> property_uniqueId;
		private ReflectiveProperty<IEnumerable<Error>> property_errors;
		private ReflectiveProperty<IEnumerable<Sample>> property_samples;
		private ReflectiveProperty property_version;
		private ReflectiveProperty<DateTime?> property_publishedDate;
		private ReflectiveProperty<string> property_publisherId;
		private ReflectiveProperty<DependencyInfo[]> property_dependencies;
		private ReflectiveProperty<DependencyInfo[]> property_resolvedDependencies;
		private ReflectiveProperty<PackageInfo> property_packageInfo;
		private ReflectiveProperty<bool> property_isInstalled;
		private ReflectiveProperty<bool> property_isFullyFetched;
		private ReflectiveProperty<bool> property_isAvailableOnDisk;
		private ReflectiveProperty<bool> property_isVersionLocked;
		private ReflectiveProperty<bool> property_canBeRemoved;
		private ReflectiveProperty<bool> property_canBeEmbedded;
		private ReflectiveProperty<bool> property_isDirectDependency;
		private ReflectiveProperty<string> property_localPath;
		private ReflectiveProperty<string> property_versionString;
		private ReflectiveProperty<string> property_versionId;
		private ReflectiveProperty property_supportedVersion;
		private ReflectiveProperty property_supportedVersions;
		private ReflectiveProperty property_sizes;
		private ReflectiveProperty property_entitlements;
		private ReflectiveMethod method_HasTag_1;
		public IPackageVersion(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public IPackageVersion(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			property_name = CreateProperty<string>("name", BindingFlags.Instance | BindingFlags.Public);
			property_displayName = CreateProperty<string>("displayName", BindingFlags.Instance | BindingFlags.Public);
			property_author = CreateProperty<string>("author", BindingFlags.Instance | BindingFlags.Public);
			property_authorLink = CreateProperty<string>("authorLink", BindingFlags.Instance | BindingFlags.Public);
			property_description = CreateProperty<string>("description", BindingFlags.Instance | BindingFlags.Public);
			property_category = CreateProperty<string>("category", BindingFlags.Instance | BindingFlags.Public);
			property_categoryLinks = CreateProperty<IDictionary<string, string>>("categoryLinks", BindingFlags.Instance | BindingFlags.Public);
			property_packageUniqueId = CreateProperty<string>("packageUniqueId", BindingFlags.Instance | BindingFlags.Public);
			property_uniqueId = CreateProperty<string>("uniqueId", BindingFlags.Instance | BindingFlags.Public);
			property_errors = CreateProperty<IEnumerable<Error>>("errors", BindingFlags.Instance | BindingFlags.Public);
			property_samples = CreateProperty<IEnumerable<Sample>>("samples", BindingFlags.Instance | BindingFlags.Public);
			property_version = CreateProperty("version", BindingFlags.Instance | BindingFlags.Public);
			property_publishedDate = CreateProperty<DateTime?>("publishedDate", BindingFlags.Instance | BindingFlags.Public);
			property_publisherId = CreateProperty<string>("publisherId", BindingFlags.Instance | BindingFlags.Public);
			property_dependencies = CreateProperty<DependencyInfo[]>("dependencies", BindingFlags.Instance | BindingFlags.Public);
			property_resolvedDependencies = CreateProperty<DependencyInfo[]>("resolvedDependencies", BindingFlags.Instance | BindingFlags.Public);
			property_packageInfo = CreateProperty<PackageInfo>("packageInfo", BindingFlags.Instance | BindingFlags.Public);
			property_isInstalled = CreateProperty<bool>("isInstalled", BindingFlags.Instance | BindingFlags.Public);
			property_isFullyFetched = CreateProperty<bool>("isFullyFetched", BindingFlags.Instance | BindingFlags.Public);
			property_isAvailableOnDisk = CreateProperty<bool>("isAvailableOnDisk", BindingFlags.Instance | BindingFlags.Public);
			property_isVersionLocked = CreateProperty<bool>("isVersionLocked", BindingFlags.Instance | BindingFlags.Public);
			property_canBeRemoved = CreateProperty<bool>("canBeRemoved", BindingFlags.Instance | BindingFlags.Public);
			property_canBeEmbedded = CreateProperty<bool>("canBeEmbedded", BindingFlags.Instance | BindingFlags.Public);
			property_isDirectDependency = CreateProperty<bool>("isDirectDependency", BindingFlags.Instance | BindingFlags.Public);
			property_localPath = CreateProperty<string>("localPath", BindingFlags.Instance | BindingFlags.Public);
			property_versionString = CreateProperty<string>("versionString", BindingFlags.Instance | BindingFlags.Public);
			property_versionId = CreateProperty<string>("versionId", BindingFlags.Instance | BindingFlags.Public);
			property_supportedVersion = CreateProperty("supportedVersion", BindingFlags.Instance | BindingFlags.Public);
			property_supportedVersions = CreateProperty("supportedVersions", BindingFlags.Instance | BindingFlags.Public);
			property_sizes = CreateProperty("sizes", BindingFlags.Instance | BindingFlags.Public);
			property_entitlements = CreateProperty("entitlements", BindingFlags.Instance | BindingFlags.Public);
			method_HasTag_1 = CreateMethod("HasTag", BindingFlags.Instance | BindingFlags.Public, typeof(PackageTag));
		}
		partial void Initialize();
		public string name
		{
			get => property_name.GetValue();
		}
		public string displayName
		{
			get => property_displayName.GetValue();
		}
		public string author
		{
			get => property_author.GetValue();
		}
		public string authorLink
		{
			get => property_authorLink.GetValue();
		}
		public string description
		{
			get => property_description.GetValue();
		}
		public string category
		{
			get => property_category.GetValue();
		}
		public IDictionary<string, string> categoryLinks
		{
			get => property_categoryLinks.GetValue();
		}
		public string packageUniqueId
		{
			get => property_packageUniqueId.GetValue();
		}
		public string uniqueId
		{
			get => property_uniqueId.GetValue();
		}
		public IEnumerable<Error> errors
		{
			get => property_errors.GetValue();
		}
		public IEnumerable<Sample> samples
		{
			get => property_samples.GetValue();
		}
		public SemVersion version
		{
			get
			{
				object _temp = property_version.GetValue();
				return _temp == null ? null : new SemVersion(_temp);
			}
		}
		public DateTime? publishedDate
		{
			get => property_publishedDate.GetValue();
		}
		public string publisherId
		{
			get => property_publisherId.GetValue();
		}
		public DependencyInfo[] dependencies
		{
			get => property_dependencies.GetValue();
		}
		public DependencyInfo[] resolvedDependencies
		{
			get => property_resolvedDependencies.GetValue();
		}
		public PackageInfo packageInfo
		{
			get => property_packageInfo.GetValue();
		}
		public bool isInstalled
		{
			get => property_isInstalled.GetValue();
		}
		public bool isFullyFetched
		{
			get => property_isFullyFetched.GetValue();
		}
		public bool isAvailableOnDisk
		{
			get => property_isAvailableOnDisk.GetValue();
		}
		public bool isVersionLocked
		{
			get => property_isVersionLocked.GetValue();
		}
		public bool canBeRemoved
		{
			get => property_canBeRemoved.GetValue();
		}
		public bool canBeEmbedded
		{
			get => property_canBeEmbedded.GetValue();
		}
		public bool isDirectDependency
		{
			get => property_isDirectDependency.GetValue();
		}
		public string localPath
		{
			get => property_localPath.GetValue();
		}
		public string versionString
		{
			get => property_versionString.GetValue();
		}
		public string versionId
		{
			get => property_versionId.GetValue();
		}
		public SemVersion supportedVersion
		{
			get
			{
				object _temp = property_supportedVersion.GetValue();
				return _temp == null ? null : new SemVersion(_temp);
			}
		}
		public IEnumerable<SemVersion> supportedVersions
		{
			get
			{
				object _temp = property_supportedVersions.GetValue();
				return _temp == null ? null : Utilities.GenerateEnumerable<SemVersion>(_temp);
			}
		}
		public IEnumerable<PackageSizeInfo> sizes
		{
			get
			{
				object _temp = property_sizes.GetValue();
				return _temp == null ? null : Utilities.GenerateEnumerable<PackageSizeInfo>(_temp);
			}
		}
		public EntitlementsInfo entitlements
		{
			get
			{
				object _temp = property_entitlements.GetValue();
				return _temp == null ? null : new EntitlementsInfo(_temp);
			}
		}
		public bool HasTag(PackageTag tag)
		{
			return (bool) method_HasTag_1.Invoke((uint)tag);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.IPackageVersion, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
