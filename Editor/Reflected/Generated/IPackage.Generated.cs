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
			get => new IVersionList(property_versionList.GetValue());
		}
		public IEnumerable<IPackageVersion> versions
		{
			get => ReflectiveUtilities.GenerateEnumerable<IPackageVersion>(property_versions.GetValue());
		}
		public IEnumerable<IPackageVersion> keyVersions
		{
			get => ReflectiveUtilities.GenerateEnumerable<IPackageVersion>(property_keyVersions.GetValue());
		}
		public IPackageVersion installedVersion
		{
			get
			{
				object value = property_installedVersion.GetValue();
				return value == null ? null : new IPackageVersion(value);
			}
		}
		public IPackageVersion latestVersion
		{
			get => new IPackageVersion(property_latestVersion.GetValue());
		}
		public IPackageVersion latestPatch
		{
			get => new IPackageVersion(property_latestPatch.GetValue());
		}
		public IPackageVersion recommendedVersion
		{
			get => new IPackageVersion(property_recommendedVersion.GetValue());
		}
		public IPackageVersion primaryVersion
		{
			get => new IPackageVersion(property_primaryVersion.GetValue());
		}
		public PackageProgress progress
		{
			get => new PackageProgress(property_progress.GetValue());
		}
		public IEnumerable<PackageImage> images
		{
			get => ReflectiveUtilities.GenerateEnumerable<PackageImage>(property_images.GetValue());
		}
		public IEnumerable<PackageLink> links
		{
			get => ReflectiveUtilities.GenerateEnumerable<PackageLink>(property_links.GetValue());
		}
		public bool isDiscoverable
		{
			get => property_isDiscoverable.GetValue();
		}
		public IEnumerable<Error> errors
		{
			get => property_errors.GetValue();
		}
		public Boolean Is(PackageType type)
		{
			return (Boolean) method_Is_1.Invoke((int)type);
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
	}
}
