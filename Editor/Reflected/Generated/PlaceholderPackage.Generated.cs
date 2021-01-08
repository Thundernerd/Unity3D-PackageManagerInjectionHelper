// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PlaceholderPackage, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.UI;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PlaceholderPackage : ReflectiveClass
	{
		private ReflectiveField<string> field_mUniqueId;
		private ReflectiveField field_mVersionList;
		private ReflectiveField field_mProgress;
		private ReflectiveField field_mType;
		private ReflectiveProperty<string> property_name;
		private ReflectiveProperty<string> property_uniqueId;
		private ReflectiveProperty<string> property_displayName;
		private ReflectiveProperty property_versionList;
		private ReflectiveProperty property_progress;
		private ReflectiveProperty<bool> property_isDiscoverable;
		private ReflectiveProperty<IEnumerable<Error>> property_errors;
		private ReflectiveProperty property_images;
		private ReflectiveProperty property_links;
		private ReflectiveProperty property_versions;
		private ReflectiveProperty property_keyVersions;
		private ReflectiveProperty property_installedVersion;
		private ReflectiveProperty property_latestVersion;
		private ReflectiveProperty property_latestPatch;
		private ReflectiveProperty property_recommendedVersion;
		private ReflectiveProperty property_primaryVersion;
		private ReflectiveMethod method_AddError_1;
		private ReflectiveMethod method_ClearErrors_1;
		private ReflectiveMethod method_Is_1;
		private ReflectiveMethod method_Clone_1;
		public PlaceholderPackage(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PlaceholderPackage(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_mUniqueId = CreateField<string>("mUniqueId", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mVersionList = CreateField("mVersionList", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mProgress = CreateField("mProgress", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mType = CreateField("mType", BindingFlags.Instance | BindingFlags.NonPublic);
			property_name = CreateProperty<string>("name", BindingFlags.Instance | BindingFlags.Public);
			property_uniqueId = CreateProperty<string>("uniqueId", BindingFlags.Instance | BindingFlags.Public);
			property_displayName = CreateProperty<string>("displayName", BindingFlags.Instance | BindingFlags.Public);
			property_versionList = CreateProperty("versionList", BindingFlags.Instance | BindingFlags.Public);
			property_progress = CreateProperty("progress", BindingFlags.Instance | BindingFlags.Public);
			property_isDiscoverable = CreateProperty<bool>("isDiscoverable", BindingFlags.Instance | BindingFlags.Public);
			property_errors = CreateProperty<IEnumerable<Error>>("errors", BindingFlags.Instance | BindingFlags.Public);
			property_images = CreateProperty("images", BindingFlags.Instance | BindingFlags.Public);
			property_links = CreateProperty("links", BindingFlags.Instance | BindingFlags.Public);
			property_versions = CreateProperty("versions", BindingFlags.Instance | BindingFlags.Public);
			property_keyVersions = CreateProperty("keyVersions", BindingFlags.Instance | BindingFlags.Public);
			property_installedVersion = CreateProperty("installedVersion", BindingFlags.Instance | BindingFlags.Public);
			property_latestVersion = CreateProperty("latestVersion", BindingFlags.Instance | BindingFlags.Public);
			property_latestPatch = CreateProperty("latestPatch", BindingFlags.Instance | BindingFlags.Public);
			property_recommendedVersion = CreateProperty("recommendedVersion", BindingFlags.Instance | BindingFlags.Public);
			property_primaryVersion = CreateProperty("primaryVersion", BindingFlags.Instance | BindingFlags.Public);
			method_AddError_1 = CreateMethod("AddError", BindingFlags.Instance | BindingFlags.Public, typeof(Error));
			method_ClearErrors_1 = CreateMethod("ClearErrors", BindingFlags.Instance | BindingFlags.Public, null);
			method_Is_1 = CreateMethod("Is", BindingFlags.Instance | BindingFlags.Public, typeof(PackageType));
			method_Clone_1 = CreateMethod("Clone", BindingFlags.Instance | BindingFlags.Public, null);
		}
		partial void Initialize();
		public string mUniqueId
		{
			get => field_mUniqueId.GetValue();
			set => field_mUniqueId.SetValue(value);
		}
		public PlaceholderVersionList mVersionList
		{
			get
			{
				object _temp = field_mVersionList.GetValue();
				return _temp == null ? null : new PlaceholderVersionList(_temp);
			}
			set => field_mVersionList.SetValue(value.Instance);
		}
		public PackageProgress mProgress
		{
			get
			{
				object _temp = (int)field_mProgress.GetValue();
				return (PackageProgress)_temp;
			}
			set => field_mProgress.SetValue((int)value);
		}
		public PackageType mType
		{
			get
			{
				object _temp = (int)field_mType.GetValue();
				return (PackageType)_temp;
			}
			set => field_mType.SetValue((int)value);
		}
		public string name
		{
			get => property_name.GetValue();
		}
		public string uniqueId
		{
			get => property_uniqueId.GetValue();
		}
		public string displayName
		{
			get => property_displayName.GetValue();
		}
		public IVersionList versionList
		{
			get
			{
				object _temp = property_versionList.GetValue();
				return _temp == null ? null : new IVersionList(_temp);
			}
		}
		public PackageProgress progress
		{
			get
			{
				object _temp = (int)property_progress.GetValue();
				return (PackageProgress)_temp;
			}
		}
		public bool isDiscoverable
		{
			get => property_isDiscoverable.GetValue();
		}
		public IEnumerable<Error> errors
		{
			get => property_errors.GetValue();
		}
		public IEnumerable<PackageImage> images
		{
			get
			{
				object _temp = property_images.GetValue();
				return _temp == null ? null : Utilities.GenerateEnumerable<PackageImage>(_temp);
			}
		}
		public IEnumerable<PackageLink> links
		{
			get
			{
				object _temp = property_links.GetValue();
				return _temp == null ? null : Utilities.GenerateEnumerable<PackageLink>(_temp);
			}
		}
		public IEnumerable<IPackageVersion> versions
		{
			get
			{
				object _temp = property_versions.GetValue();
				return _temp == null ? null : Utilities.GenerateEnumerable<IPackageVersion>(_temp);
			}
		}
		public IEnumerable<IPackageVersion> keyVersions
		{
			get
			{
				object _temp = property_keyVersions.GetValue();
				return _temp == null ? null : Utilities.GenerateEnumerable<IPackageVersion>(_temp);
			}
		}
		public IPackageVersion installedVersion
		{
			get
			{
				object _temp = property_installedVersion.GetValue();
				return _temp == null ? null : new IPackageVersion(_temp);
			}
		}
		public IPackageVersion latestVersion
		{
			get
			{
				object _temp = property_latestVersion.GetValue();
				return _temp == null ? null : new IPackageVersion(_temp);
			}
		}
		public IPackageVersion latestPatch
		{
			get
			{
				object _temp = property_latestPatch.GetValue();
				return _temp == null ? null : new IPackageVersion(_temp);
			}
		}
		public IPackageVersion recommendedVersion
		{
			get
			{
				object _temp = property_recommendedVersion.GetValue();
				return _temp == null ? null : new IPackageVersion(_temp);
			}
		}
		public IPackageVersion primaryVersion
		{
			get
			{
				object _temp = property_primaryVersion.GetValue();
				return _temp == null ? null : new IPackageVersion(_temp);
			}
		}
		public void AddError(Error error)
		{
			method_AddError_1.Invoke(error);
		}
		public void ClearErrors()
		{
			method_ClearErrors_1.Invoke();
		}
		public bool Is(PackageType type)
		{
			return (bool) method_Is_1.Invoke((int)type);
		}
		public IPackage Clone()
		{
			return new IPackage(method_Clone_1.Invoke());
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PlaceholderPackage, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
