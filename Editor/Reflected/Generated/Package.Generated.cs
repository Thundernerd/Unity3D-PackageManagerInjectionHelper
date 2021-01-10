// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.Package, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.UI;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class Package : ReflectiveClass
	{
		private ReflectiveField<string> field_packageManagerUIName;
		private ReflectiveField<string> field_packageName;
		private ReflectiveField field_source;
		private ReflectiveField<Action> field_OnAddOperationFinalizedEvent;
		private ReflectiveField<Action> field_OnRemoveOperationFinalizedEvent;
		private ReflectiveProperty<bool> property_ShouldProposeLatestVersions;
		private ReflectiveProperty<bool> property_AddRemoveOperationInProgress;
		private ReflectiveProperty<Error> property_Error;
		private ReflectiveProperty<bool> property_IsDiscoverable;
		private ReflectiveProperty property_Current;
		private ReflectiveProperty property_LatestUpdate;
		private ReflectiveProperty property_LatestPatch;
		private ReflectiveProperty property_Latest;
		private ReflectiveProperty property_VersionToDisplay;
		private ReflectiveProperty property_Versions;
		private ReflectiveProperty property_ReleaseVersions;
		private ReflectiveProperty property_KeyVersions;
		private ReflectiveProperty property_LatestRelease;
		private ReflectiveProperty property_Verified;
		private ReflectiveProperty<bool> property_IsBuiltIn;
		private ReflectiveProperty<string> property_Name;
		private ReflectiveProperty<bool> property_IsPackageManagerUI;
		private ReflectiveMethod method_IsAfterCurrentVersion_1;
		private ReflectiveMethod method_Equals_1;
		private ReflectiveMethod method_GetHashCode_1;
		private ReflectiveMethod method_Add_1;
		private ReflectiveMethod method_Update_1;
		private ReflectiveMethod method_AddFromId_1;
		private ReflectiveMethod method_AddFromLocalDisk_1;
		private ReflectiveMethod method_Remove_1;
		public Package(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public Package(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_packageManagerUIName = CreateField<string>("packageManagerUIName", BindingFlags.Static | BindingFlags.NonPublic);
			field_packageName = CreateField<string>("packageName", BindingFlags.Instance | BindingFlags.NonPublic);
			field_source = CreateField("source", BindingFlags.Instance | BindingFlags.NonPublic);
			field_OnAddOperationFinalizedEvent = CreateField<Action>("OnAddOperationFinalizedEvent", BindingFlags.Instance | BindingFlags.NonPublic);
			field_OnRemoveOperationFinalizedEvent = CreateField<Action>("OnRemoveOperationFinalizedEvent", BindingFlags.Instance | BindingFlags.NonPublic);
			property_ShouldProposeLatestVersions = CreateProperty<bool>("ShouldProposeLatestVersions", BindingFlags.Static | BindingFlags.Public);
			property_AddRemoveOperationInProgress = CreateProperty<bool>("AddRemoveOperationInProgress", BindingFlags.Static | BindingFlags.Public);
			property_Error = CreateProperty<Error>("Error", BindingFlags.Instance | BindingFlags.Public);
			property_IsDiscoverable = CreateProperty<bool>("IsDiscoverable", BindingFlags.Instance | BindingFlags.Public);
			property_Current = CreateProperty("Current", BindingFlags.Instance | BindingFlags.Public);
			property_LatestUpdate = CreateProperty("LatestUpdate", BindingFlags.Instance | BindingFlags.Public);
			property_LatestPatch = CreateProperty("LatestPatch", BindingFlags.Instance | BindingFlags.Public);
			property_Latest = CreateProperty("Latest", BindingFlags.Instance | BindingFlags.NonPublic);
			property_VersionToDisplay = CreateProperty("VersionToDisplay", BindingFlags.Instance | BindingFlags.NonPublic);
			property_Versions = CreateProperty("Versions", BindingFlags.Instance | BindingFlags.NonPublic);
			property_ReleaseVersions = CreateProperty("ReleaseVersions", BindingFlags.Instance | BindingFlags.NonPublic);
			property_KeyVersions = CreateProperty("KeyVersions", BindingFlags.Instance | BindingFlags.NonPublic);
			property_LatestRelease = CreateProperty("LatestRelease", BindingFlags.Instance | BindingFlags.NonPublic);
			property_Verified = CreateProperty("Verified", BindingFlags.Instance | BindingFlags.NonPublic);
			property_IsBuiltIn = CreateProperty<bool>("IsBuiltIn", BindingFlags.Instance | BindingFlags.NonPublic);
			property_Name = CreateProperty<string>("Name", BindingFlags.Instance | BindingFlags.Public);
			property_IsPackageManagerUI = CreateProperty<bool>("IsPackageManagerUI", BindingFlags.Instance | BindingFlags.Public);
			method_IsAfterCurrentVersion_1 = CreateMethod("IsAfterCurrentVersion", BindingFlags.Instance | BindingFlags.NonPublic, typeof(PackageInfo));
			method_Equals_1 = CreateMethod("Equals", BindingFlags.Instance | BindingFlags.Public, typeof(Package));
			method_GetHashCode_1 = CreateMethod("GetHashCode", BindingFlags.Instance | BindingFlags.Public, null);
			method_Add_1 = CreateMethod("Add", BindingFlags.Instance | BindingFlags.NonPublic, typeof(PackageInfo));
			method_Update_1 = CreateMethod("Update", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_AddFromId_1 = CreateMethod("AddFromId", BindingFlags.Static | BindingFlags.NonPublic, typeof(string));
			method_AddFromLocalDisk_1 = CreateMethod("AddFromLocalDisk", BindingFlags.Static | BindingFlags.NonPublic, typeof(string));
			method_Remove_1 = CreateMethod("Remove", BindingFlags.Instance | BindingFlags.Public, null);
		}
		partial void Initialize();
		public string packageManagerUIName
		{
			get => field_packageManagerUIName.GetValue();
			set => field_packageManagerUIName.SetValue(value);
		}
		public string packageName
		{
			get => field_packageName.GetValue();
			set => field_packageName.SetValue(value);
		}
		public IEnumerable<PackageInfo> source
		{
			get
			{
				object _temp = field_source.GetValue();
				return _temp == null ? null : Utilities.GenerateEnumerable<PackageInfo>(_temp);
			}
		}
		public Action OnAddOperationFinalizedEvent
		{
			get => field_OnAddOperationFinalizedEvent.GetValue();
			set => field_OnAddOperationFinalizedEvent.SetValue(value);
		}
		public Action OnRemoveOperationFinalizedEvent
		{
			get => field_OnRemoveOperationFinalizedEvent.GetValue();
			set => field_OnRemoveOperationFinalizedEvent.SetValue(value);
		}
		public bool ShouldProposeLatestVersions
		{
			get => property_ShouldProposeLatestVersions.GetValue();
		}
		public bool AddRemoveOperationInProgress
		{
			get => property_AddRemoveOperationInProgress.GetValue();
		}
		public Error Error
		{
			get => property_Error.GetValue();
			set => property_Error.SetValue(value);
		}
		public bool IsDiscoverable
		{
			get => property_IsDiscoverable.GetValue();
		}
		public PackageInfo Current
		{
			get
			{
				object _temp = property_Current.GetValue();
				return _temp == null ? null : new PackageInfo(_temp);
			}
		}
		public PackageInfo LatestUpdate
		{
			get
			{
				object _temp = property_LatestUpdate.GetValue();
				return _temp == null ? null : new PackageInfo(_temp);
			}
		}
		public PackageInfo LatestPatch
		{
			get
			{
				object _temp = property_LatestPatch.GetValue();
				return _temp == null ? null : new PackageInfo(_temp);
			}
		}
		public PackageInfo Latest
		{
			get
			{
				object _temp = property_Latest.GetValue();
				return _temp == null ? null : new PackageInfo(_temp);
			}
		}
		public PackageInfo VersionToDisplay
		{
			get
			{
				object _temp = property_VersionToDisplay.GetValue();
				return _temp == null ? null : new PackageInfo(_temp);
			}
		}
		public IEnumerable<PackageInfo> Versions
		{
			get
			{
				object _temp = property_Versions.GetValue();
				return _temp == null ? null : Utilities.GenerateEnumerable<PackageInfo>(_temp);
			}
		}
		public IEnumerable<PackageInfo> ReleaseVersions
		{
			get
			{
				object _temp = property_ReleaseVersions.GetValue();
				return _temp == null ? null : Utilities.GenerateEnumerable<PackageInfo>(_temp);
			}
		}
		public IEnumerable<PackageInfo> KeyVersions
		{
			get
			{
				object _temp = property_KeyVersions.GetValue();
				return _temp == null ? null : Utilities.GenerateEnumerable<PackageInfo>(_temp);
			}
		}
		public PackageInfo LatestRelease
		{
			get
			{
				object _temp = property_LatestRelease.GetValue();
				return _temp == null ? null : new PackageInfo(_temp);
			}
		}
		public PackageInfo Verified
		{
			get
			{
				object _temp = property_Verified.GetValue();
				return _temp == null ? null : new PackageInfo(_temp);
			}
		}
		public bool IsBuiltIn
		{
			get => property_IsBuiltIn.GetValue();
		}
		public string Name
		{
			get => property_Name.GetValue();
		}
		public bool IsPackageManagerUI
		{
			get => property_IsPackageManagerUI.GetValue();
		}
		public bool IsAfterCurrentVersion(PackageInfo packageInfo)
		{
			return (bool) method_IsAfterCurrentVersion_1.Invoke(packageInfo);
		}
		public bool Equals(Package other)
		{
			return (bool) method_Equals_1.Invoke(other);
		}
		public int GetHashCode()
		{
			return (int) method_GetHashCode_1.Invoke();
		}
		public void Add(PackageInfo packageInfo)
		{
			method_Add_1.Invoke(packageInfo);
		}
		public void Update()
		{
			method_Update_1.Invoke();
		}
		public void AddFromId(string packageId)
		{
			method_AddFromId_1.Invoke(packageId);
		}
		public void AddFromLocalDisk(string path)
		{
			method_AddFromLocalDisk_1.Invoke(path);
		}
		public void Remove()
		{
			method_Remove_1.Invoke();
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.Package, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
