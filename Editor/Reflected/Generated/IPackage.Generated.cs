// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.IPackage, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.UI;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class IPackage : ReflectiveClass
	{
		private ReflectiveProperty<string> property_uniqueId;
		private ReflectiveProperty<string> property_name;
		private ReflectiveProperty<string> property_displayName;
		private ReflectiveProperty property_versionList;
		private ReflectiveProperty property_versions;
		private ReflectiveProperty property_keyVersions;
		private ReflectiveProperty property_installedVersion;
		private ReflectiveProperty property_latestVersion;
		private ReflectiveProperty property_latestPatch;
		private ReflectiveProperty property_recommendedVersion;
		private ReflectiveProperty property_primaryVersion;
		private ReflectiveProperty property_progress;
		private ReflectiveProperty property_images;
		private ReflectiveProperty property_links;
		private ReflectiveProperty<bool> property_isDiscoverable;
		private ReflectiveProperty<IEnumerable<Error>> property_errors;
		private ReflectiveMethod method_Is_1;
		private ReflectiveMethod method_AddError_1;
		private ReflectiveMethod method_ClearErrors_1;
		private ReflectiveMethod method_Clone_1;
		public IPackage(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public IPackage(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			property_uniqueId = CreateProperty<string>("uniqueId", BindingFlags.Instance | BindingFlags.Public);
			property_name = CreateProperty<string>("name", BindingFlags.Instance | BindingFlags.Public);
			property_displayName = CreateProperty<string>("displayName", BindingFlags.Instance | BindingFlags.Public);
			property_versionList = CreateProperty("versionList", BindingFlags.Instance | BindingFlags.Public);
			property_versions = CreateProperty("versions", BindingFlags.Instance | BindingFlags.Public);
			property_keyVersions = CreateProperty("keyVersions", BindingFlags.Instance | BindingFlags.Public);
			property_installedVersion = CreateProperty("installedVersion", BindingFlags.Instance | BindingFlags.Public);
			property_latestVersion = CreateProperty("latestVersion", BindingFlags.Instance | BindingFlags.Public);
			property_latestPatch = CreateProperty("latestPatch", BindingFlags.Instance | BindingFlags.Public);
			property_recommendedVersion = CreateProperty("recommendedVersion", BindingFlags.Instance | BindingFlags.Public);
			property_primaryVersion = CreateProperty("primaryVersion", BindingFlags.Instance | BindingFlags.Public);
			property_progress = CreateProperty("progress", BindingFlags.Instance | BindingFlags.Public);
			property_images = CreateProperty("images", BindingFlags.Instance | BindingFlags.Public);
			property_links = CreateProperty("links", BindingFlags.Instance | BindingFlags.Public);
			property_isDiscoverable = CreateProperty<bool>("isDiscoverable", BindingFlags.Instance | BindingFlags.Public);
			property_errors = CreateProperty<IEnumerable<Error>>("errors", BindingFlags.Instance | BindingFlags.Public);
			method_Is_1 = CreateMethod("Is", BindingFlags.Instance | BindingFlags.Public, typeof(PackageType));
			method_AddError_1 = CreateMethod("AddError", BindingFlags.Instance | BindingFlags.Public, typeof(Error));
			method_ClearErrors_1 = CreateMethod("ClearErrors", BindingFlags.Instance | BindingFlags.Public, null);
			method_Clone_1 = CreateMethod("Clone", BindingFlags.Instance | BindingFlags.Public, null);
		}
		partial void Initialize();
		public string uniqueId
		{
			get => property_uniqueId.GetValue();
		}
		public string name
		{
			get => property_name.GetValue();
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
		public PackageProgress progress
		{
			get
			{
				object _temp = (int)property_progress.GetValue();
				return (PackageProgress)_temp;
			}
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
		public bool isDiscoverable
		{
			get => property_isDiscoverable.GetValue();
		}
		public IEnumerable<Error> errors
		{
			get => property_errors.GetValue();
		}
		public bool Is(PackageType type)
		{
			return (bool) method_Is_1.Invoke((int)type);
		}
		public void AddError(Error error)
		{
			method_AddError_1.Invoke(error);
		}
		public void ClearErrors()
		{
			method_ClearErrors_1.Invoke();
		}
		public IPackage Clone()
		{
			return new IPackage(method_Clone_1.Invoke());
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.IPackage, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
