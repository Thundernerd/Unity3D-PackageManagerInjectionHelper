// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PlaceholderVersionList, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.UI;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PlaceholderVersionList : ReflectiveClass
	{
		private ReflectiveField<PlaceholderPackageVersion[]> field_mVersions;
		private ReflectiveProperty property_all;
		private ReflectiveProperty property_key;
		private ReflectiveProperty property_installed;
		private ReflectiveProperty property_latest;
		private ReflectiveProperty property_latestPatch;
		private ReflectiveProperty property_importAvailable;
		private ReflectiveProperty property_recommended;
		private ReflectiveProperty property_primary;
		public PlaceholderVersionList(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PlaceholderVersionList(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_mVersions = CreateField<PlaceholderPackageVersion[]>("mVersions", BindingFlags.Instance | BindingFlags.NonPublic);
			property_all = CreateProperty("all", BindingFlags.Instance | BindingFlags.Public);
			property_key = CreateProperty("key", BindingFlags.Instance | BindingFlags.Public);
			property_installed = CreateProperty("installed", BindingFlags.Instance | BindingFlags.Public);
			property_latest = CreateProperty("latest", BindingFlags.Instance | BindingFlags.Public);
			property_latestPatch = CreateProperty("latestPatch", BindingFlags.Instance | BindingFlags.Public);
			property_importAvailable = CreateProperty("importAvailable", BindingFlags.Instance | BindingFlags.Public);
			property_recommended = CreateProperty("recommended", BindingFlags.Instance | BindingFlags.Public);
			property_primary = CreateProperty("primary", BindingFlags.Instance | BindingFlags.Public);
		}
		partial void Initialize();
		public PlaceholderPackageVersion[] mVersions
		{
			get => field_mVersions.GetValue();
			set => field_mVersions.SetValue(value);
		}
		public IEnumerable<IPackageVersion> all
		{
			get
			{
				object _temp = property_all.GetValue();
				return _temp == null ? null : Utilities.GenerateEnumerable<IPackageVersion>(_temp);
			}
		}
		public IEnumerable<IPackageVersion> key
		{
			get
			{
				object _temp = property_key.GetValue();
				return _temp == null ? null : Utilities.GenerateEnumerable<IPackageVersion>(_temp);
			}
		}
		public IPackageVersion installed
		{
			get
			{
				object _temp = property_installed.GetValue();
				return _temp == null ? null : new IPackageVersion(_temp);
			}
		}
		public IPackageVersion latest
		{
			get
			{
				object _temp = property_latest.GetValue();
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
		public IPackageVersion importAvailable
		{
			get
			{
				object _temp = property_importAvailable.GetValue();
				return _temp == null ? null : new IPackageVersion(_temp);
			}
		}
		public IPackageVersion recommended
		{
			get
			{
				object _temp = property_recommended.GetValue();
				return _temp == null ? null : new IPackageVersion(_temp);
			}
		}
		public IPackageVersion primary
		{
			get
			{
				object _temp = property_primary.GetValue();
				return _temp == null ? null : new IPackageVersion(_temp);
			}
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PlaceholderVersionList, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
