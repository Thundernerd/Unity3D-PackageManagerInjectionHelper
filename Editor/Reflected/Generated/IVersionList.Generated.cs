// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.IVersionList, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System.Collections.Generic;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager.UI;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class IVersionList : ReflectiveClass
	{
		private ReflectiveProperty property_all;
		private ReflectiveProperty property_key;
		private ReflectiveProperty property_installed;
		private ReflectiveProperty property_latest;
		private ReflectiveProperty property_latestPatch;
		private ReflectiveProperty property_importAvailable;
		private ReflectiveProperty property_recommended;
		private ReflectiveProperty property_primary;

		public IVersionList(object instance) : base(instance)
		{
			property_all = CreateProperty("all", BindingFlags.Instance | BindingFlags.Public);
			property_key = CreateProperty("key", BindingFlags.Instance | BindingFlags.Public);
			property_installed = CreateProperty("installed", BindingFlags.Instance | BindingFlags.Public);
			property_latest = CreateProperty("latest", BindingFlags.Instance | BindingFlags.Public);
			property_latestPatch = CreateProperty("latestPatch", BindingFlags.Instance | BindingFlags.Public);
			property_importAvailable = CreateProperty("importAvailable", BindingFlags.Instance | BindingFlags.Public);
			property_recommended = CreateProperty("recommended", BindingFlags.Instance | BindingFlags.Public);
			property_primary = CreateProperty("primary", BindingFlags.Instance | BindingFlags.Public);
		}

		public IEnumerable<IPackageVersion> all
		{
			get => ReflectiveUtilities.GenerateEnumerable<IPackageVersion>(property_all);
		}
		public IEnumerable<IPackageVersion> key
		{
			get => ReflectiveUtilities.GenerateEnumerable<IPackageVersion>(property_key);
		}
		public IPackageVersion installed
		{
			get => new IPackageVersion(property_installed.GetValue());
		}
		public IPackageVersion latest
		{
			get => new IPackageVersion(property_latest.GetValue());
		}
		public IPackageVersion latestPatch
		{
			get => new IPackageVersion(property_latestPatch.GetValue());
		}
		public IPackageVersion importAvailable
		{
			get => new IPackageVersion(property_importAvailable.GetValue());
		}
		public IPackageVersion recommended
		{
			get => new IPackageVersion(property_recommended.GetValue());
		}
		public IPackageVersion primary
		{
			get => new IPackageVersion(property_primary.GetValue());
		}
	}
}
