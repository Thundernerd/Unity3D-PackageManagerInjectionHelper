// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.IPackageDatabase, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.UI;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class IPackageDatabase : ReflectiveClass
	{
		private ReflectiveEvent event_onPackagesChanged;
		private ReflectiveEvent event_onInstallSuccess;
		private ReflectiveEvent event_onUninstallSuccess;
		private ReflectiveEvent event_onPackageOperationStart;
		private ReflectiveEvent event_onPackageOperationFinish;
		private ReflectiveEvent event_onRefreshOperationStart;
		private ReflectiveEvent event_onRefreshOperationFinish;
		private ReflectiveEvent event_onRefreshOperationError;
		private ReflectiveEvent event_onDownloadProgress;
		private ReflectiveProperty<bool> property_isEmpty;
		private ReflectiveProperty<bool> property_isInstallOrUninstallInProgress;
		private ReflectiveProperty property_allPackages;
		private ReflectiveProperty property_assetStorePackages;
		private ReflectiveProperty property_upmPackages;
		private ReflectiveProperty property_packagesInError;
		private ReflectiveMethod method_RegisterEvents_1;
		private ReflectiveMethod method_UnregisterEvents_1;
		private ReflectiveMethod method_Reload_1;
		private ReflectiveMethod method_IsUninstallInProgress_1;
		private ReflectiveMethod method_IsInstallInProgress_1;
		private ReflectiveMethod method_FetchExtraInfo_1;
		private ReflectiveMethod method_Install_1;
		private ReflectiveMethod method_InstallFromUrl_1;
		private ReflectiveMethod method_InstallFromPath_1;
		private ReflectiveMethod method_Uninstall_1;
		private ReflectiveMethod method_GetDownloadProgress_1;
		private ReflectiveMethod method_IsDownloadInProgress_1;
		private ReflectiveMethod method_Download_1;
		private ReflectiveMethod method_AbortDownload_1;
		private ReflectiveMethod method_Import_1;
		private ReflectiveMethod method_Embed_1;
		private ReflectiveMethod method_RemoveEmbedded_1;
		private ReflectiveMethod method_AddPackageError_1;
		private ReflectiveMethod method_ClearPackageErrors_1;
		private ReflectiveMethod method_GetPackageByDisplayName_1;
		private ReflectiveMethod method_GetPackage_1;
		private ReflectiveMethod method_GetPackage_2;
		private ReflectiveMethod method_GetPackageVersion_1;
		private ReflectiveMethod method_GetPackageVersion_2;
		private ReflectiveMethod method_GetPackageAndVersion_1;
		private ReflectiveMethod method_GetDependentVersions_1;
		private ReflectiveMethod method_GetRefreshTimestamp_1;
		private ReflectiveMethod method_IsRefreshInProgress_1;
		public IPackageDatabase(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public IPackageDatabase(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			event_onPackagesChanged = CreateEvent("onPackagesChanged", BindingFlags.Instance | BindingFlags.Public);
			event_onInstallSuccess = CreateEvent("onInstallSuccess", BindingFlags.Instance | BindingFlags.Public);
			event_onUninstallSuccess = CreateEvent("onUninstallSuccess", BindingFlags.Instance | BindingFlags.Public);
			event_onPackageOperationStart = CreateEvent("onPackageOperationStart", BindingFlags.Instance | BindingFlags.Public);
			event_onPackageOperationFinish = CreateEvent("onPackageOperationFinish", BindingFlags.Instance | BindingFlags.Public);
			event_onRefreshOperationStart = CreateEvent("onRefreshOperationStart", BindingFlags.Instance | BindingFlags.Public);
			event_onRefreshOperationFinish = CreateEvent("onRefreshOperationFinish", BindingFlags.Instance | BindingFlags.Public);
			event_onRefreshOperationError = CreateEvent("onRefreshOperationError", BindingFlags.Instance | BindingFlags.Public);
			event_onDownloadProgress = CreateEvent("onDownloadProgress", BindingFlags.Instance | BindingFlags.Public);
			property_isEmpty = CreateProperty<bool>("isEmpty", BindingFlags.Instance | BindingFlags.Public);
			property_isInstallOrUninstallInProgress = CreateProperty<bool>("isInstallOrUninstallInProgress", BindingFlags.Instance | BindingFlags.Public);
			property_allPackages = CreateProperty("allPackages", BindingFlags.Instance | BindingFlags.Public);
			property_assetStorePackages = CreateProperty("assetStorePackages", BindingFlags.Instance | BindingFlags.Public);
			property_upmPackages = CreateProperty("upmPackages", BindingFlags.Instance | BindingFlags.Public);
			property_packagesInError = CreateProperty("packagesInError", BindingFlags.Instance | BindingFlags.Public);
			method_RegisterEvents_1 = CreateMethod("RegisterEvents", BindingFlags.Instance | BindingFlags.Public, null);
			method_UnregisterEvents_1 = CreateMethod("UnregisterEvents", BindingFlags.Instance | BindingFlags.Public, null);
			method_Reload_1 = CreateMethod("Reload", BindingFlags.Instance | BindingFlags.Public, null);
			method_IsUninstallInProgress_1 = CreateMethod("IsUninstallInProgress", BindingFlags.Instance | BindingFlags.Public, typeof(IPackage));
			method_IsInstallInProgress_1 = CreateMethod("IsInstallInProgress", BindingFlags.Instance | BindingFlags.Public, typeof(IPackageVersion));
			method_FetchExtraInfo_1 = CreateMethod("FetchExtraInfo", BindingFlags.Instance | BindingFlags.Public, typeof(IPackageVersion));
			method_Install_1 = CreateMethod("Install", BindingFlags.Instance | BindingFlags.Public, typeof(IPackageVersion));
			method_InstallFromUrl_1 = CreateMethod("InstallFromUrl", BindingFlags.Instance | BindingFlags.Public, typeof(string));
			method_InstallFromPath_1 = CreateMethod("InstallFromPath", BindingFlags.Instance | BindingFlags.Public, typeof(string));
			method_Uninstall_1 = CreateMethod("Uninstall", BindingFlags.Instance | BindingFlags.Public, typeof(IPackage));
			method_GetDownloadProgress_1 = CreateMethod("GetDownloadProgress", BindingFlags.Instance | BindingFlags.Public, typeof(IPackageVersion));
			method_IsDownloadInProgress_1 = CreateMethod("IsDownloadInProgress", BindingFlags.Instance | BindingFlags.Public, typeof(IPackageVersion));
			method_Download_1 = CreateMethod("Download", BindingFlags.Instance | BindingFlags.Public, typeof(IPackage));
			method_AbortDownload_1 = CreateMethod("AbortDownload", BindingFlags.Instance | BindingFlags.Public, typeof(IPackage));
			method_Import_1 = CreateMethod("Import", BindingFlags.Instance | BindingFlags.Public, typeof(IPackage));
			method_Embed_1 = CreateMethod("Embed", BindingFlags.Instance | BindingFlags.Public, typeof(IPackageVersion));
			method_RemoveEmbedded_1 = CreateMethod("RemoveEmbedded", BindingFlags.Instance | BindingFlags.Public, typeof(IPackage));
			method_AddPackageError_1 = CreateMethod("AddPackageError", BindingFlags.Instance | BindingFlags.Public, typeof(IPackage),typeof(Error));
			method_ClearPackageErrors_1 = CreateMethod("ClearPackageErrors", BindingFlags.Instance | BindingFlags.Public, typeof(IPackage));
			method_GetPackageByDisplayName_1 = CreateMethod("GetPackageByDisplayName", BindingFlags.Instance | BindingFlags.Public, typeof(string));
			method_GetPackage_1 = CreateMethod("GetPackage", BindingFlags.Instance | BindingFlags.Public, typeof(string));
			method_GetPackage_2 = CreateMethod("GetPackage", BindingFlags.Instance | BindingFlags.Public, typeof(IPackageVersion));
			method_GetPackageVersion_1 = CreateMethod("GetPackageVersion", BindingFlags.Instance | BindingFlags.Public, typeof(string),typeof(string));
			method_GetPackageVersion_2 = CreateMethod("GetPackageVersion", BindingFlags.Instance | BindingFlags.Public, typeof(DependencyInfo));
			method_GetPackageAndVersion_1 = CreateMethod("GetPackageAndVersion", BindingFlags.Instance | BindingFlags.Public, typeof(string),typeof(string),typeof(IPackage),typeof(IPackageVersion));
			method_GetDependentVersions_1 = CreateMethod("GetDependentVersions", BindingFlags.Instance | BindingFlags.Public, typeof(IPackageVersion));
			method_GetRefreshTimestamp_1 = CreateMethod("GetRefreshTimestamp", BindingFlags.Instance | BindingFlags.Public, typeof(PackageFilterTab?));
			method_IsRefreshInProgress_1 = CreateMethod("IsRefreshInProgress", BindingFlags.Instance | BindingFlags.Public, typeof(PackageFilterTab?));
		}
		partial void Initialize();
		/// <summary>
		/// Event type: System.Action<IEnumerable<IPackage>, IEnumerable<IPackage>, IEnumerable<IPackage>, IEnumerable<IPackage>>
		/// </summary>
		/// <returns>Delegate to be used for unsubscribing</returns>
		public Delegate SubscribeToOnPackagesChanged(Delegate @delegate)
		{
			return event_onPackagesChanged.Subscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<IEnumerable<IPackage>, IEnumerable<IPackage>, IEnumerable<IPackage>, IEnumerable<IPackage>>
		/// </summary>
		public void UnsubscribeFromOnPackagesChanged(Delegate @delegate)
		{
			event_onPackagesChanged.Unsubscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<IPackage, IPackageVersion>
		/// </summary>
		/// <returns>Delegate to be used for unsubscribing</returns>
		public Delegate SubscribeToOnInstallSuccess(Delegate @delegate)
		{
			return event_onInstallSuccess.Subscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<IPackage, IPackageVersion>
		/// </summary>
		public void UnsubscribeFromOnInstallSuccess(Delegate @delegate)
		{
			event_onInstallSuccess.Unsubscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<IPackage>
		/// </summary>
		/// <returns>Delegate to be used for unsubscribing</returns>
		public Delegate SubscribeToOnUninstallSuccess(Delegate @delegate)
		{
			return event_onUninstallSuccess.Subscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<IPackage>
		/// </summary>
		public void UnsubscribeFromOnUninstallSuccess(Delegate @delegate)
		{
			event_onUninstallSuccess.Unsubscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<IPackage>
		/// </summary>
		/// <returns>Delegate to be used for unsubscribing</returns>
		public Delegate SubscribeToOnPackageOperationStart(Delegate @delegate)
		{
			return event_onPackageOperationStart.Subscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<IPackage>
		/// </summary>
		public void UnsubscribeFromOnPackageOperationStart(Delegate @delegate)
		{
			event_onPackageOperationStart.Unsubscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<IPackage>
		/// </summary>
		/// <returns>Delegate to be used for unsubscribing</returns>
		public Delegate SubscribeToOnPackageOperationFinish(Delegate @delegate)
		{
			return event_onPackageOperationFinish.Subscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<IPackage>
		/// </summary>
		public void UnsubscribeFromOnPackageOperationFinish(Delegate @delegate)
		{
			event_onPackageOperationFinish.Unsubscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action
		/// </summary>
		/// <returns>Delegate to be used for unsubscribing</returns>
		public Delegate SubscribeToOnRefreshOperationStart(Delegate @delegate)
		{
			return event_onRefreshOperationStart.Subscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action
		/// </summary>
		public void UnsubscribeFromOnRefreshOperationStart(Delegate @delegate)
		{
			event_onRefreshOperationStart.Unsubscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<PackageFilterTab>
		/// </summary>
		/// <returns>Delegate to be used for unsubscribing</returns>
		public Delegate SubscribeToOnRefreshOperationFinish(Delegate @delegate)
		{
			return event_onRefreshOperationFinish.Subscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<PackageFilterTab>
		/// </summary>
		public void UnsubscribeFromOnRefreshOperationFinish(Delegate @delegate)
		{
			event_onRefreshOperationFinish.Unsubscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<Error>
		/// </summary>
		/// <returns>Delegate to be used for unsubscribing</returns>
		public Delegate SubscribeToOnRefreshOperationError(Delegate @delegate)
		{
			return event_onRefreshOperationError.Subscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<Error>
		/// </summary>
		public void UnsubscribeFromOnRefreshOperationError(Delegate @delegate)
		{
			event_onRefreshOperationError.Unsubscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<IPackage, DownloadProgress>
		/// </summary>
		/// <returns>Delegate to be used for unsubscribing</returns>
		public Delegate SubscribeToOnDownloadProgress(Delegate @delegate)
		{
			return event_onDownloadProgress.Subscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<IPackage, DownloadProgress>
		/// </summary>
		public void UnsubscribeFromOnDownloadProgress(Delegate @delegate)
		{
			event_onDownloadProgress.Unsubscribe(@delegate);
		}
		public bool isEmpty
		{
			get => property_isEmpty.GetValue();
		}
		public bool isInstallOrUninstallInProgress
		{
			get => property_isInstallOrUninstallInProgress.GetValue();
		}
		public IEnumerable<IPackage> allPackages
		{
			get
			{
				object _temp = property_allPackages.GetValue();
				return _temp == null ? null : Utilities.GenerateEnumerable<IPackage>(_temp);
			}
		}
		public IEnumerable<IPackage> assetStorePackages
		{
			get
			{
				object _temp = property_assetStorePackages.GetValue();
				return _temp == null ? null : Utilities.GenerateEnumerable<IPackage>(_temp);
			}
		}
		public IEnumerable<IPackage> upmPackages
		{
			get
			{
				object _temp = property_upmPackages.GetValue();
				return _temp == null ? null : Utilities.GenerateEnumerable<IPackage>(_temp);
			}
		}
		public IEnumerable<IPackage> packagesInError
		{
			get
			{
				object _temp = property_packagesInError.GetValue();
				return _temp == null ? null : Utilities.GenerateEnumerable<IPackage>(_temp);
			}
		}
		public void RegisterEvents()
		{
			method_RegisterEvents_1.Invoke();
		}
		public void UnregisterEvents()
		{
			method_UnregisterEvents_1.Invoke();
		}
		public void Reload()
		{
			method_Reload_1.Invoke();
		}
		public bool IsUninstallInProgress(IPackage package)
		{
			return (bool) method_IsUninstallInProgress_1.Invoke(package);
		}
		public bool IsInstallInProgress(IPackageVersion version)
		{
			return (bool) method_IsInstallInProgress_1.Invoke(version);
		}
		public void FetchExtraInfo(IPackageVersion version)
		{
			method_FetchExtraInfo_1.Invoke(version);
		}
		public void Install(IPackageVersion version)
		{
			method_Install_1.Invoke(version);
		}
		public void InstallFromUrl(string url)
		{
			method_InstallFromUrl_1.Invoke(url);
		}
		public void InstallFromPath(string path)
		{
			method_InstallFromPath_1.Invoke(path);
		}
		public void Uninstall(IPackage package)
		{
			method_Uninstall_1.Invoke(package);
		}
		public DownloadProgress GetDownloadProgress(IPackageVersion version)
		{
			return new DownloadProgress(method_GetDownloadProgress_1.Invoke(version));
		}
		public bool IsDownloadInProgress(IPackageVersion version)
		{
			return (bool) method_IsDownloadInProgress_1.Invoke(version);
		}
		public void Download(IPackage package)
		{
			method_Download_1.Invoke(package);
		}
		public void AbortDownload(IPackage package)
		{
			method_AbortDownload_1.Invoke(package);
		}
		public void Import(IPackage package)
		{
			method_Import_1.Invoke(package);
		}
		public void Embed(IPackageVersion package)
		{
			method_Embed_1.Invoke(package);
		}
		public void RemoveEmbedded(IPackage package)
		{
			method_RemoveEmbedded_1.Invoke(package);
		}
		public void AddPackageError(IPackage package,Error error)
		{
			method_AddPackageError_1.Invoke(package,error);
		}
		public void ClearPackageErrors(IPackage package)
		{
			method_ClearPackageErrors_1.Invoke(package);
		}
		public IPackage GetPackageByDisplayName(string displayName)
		{
			return new IPackage(method_GetPackageByDisplayName_1.Invoke(displayName));
		}
		public IPackage GetPackage(string uniqueId)
		{
			return new IPackage(method_GetPackage_1.Invoke(uniqueId));
		}
		public IPackage GetPackage(IPackageVersion version)
		{
			return new IPackage(method_GetPackage_2.Invoke(version));
		}
		public IPackageVersion GetPackageVersion(string packageUniqueId,string versionUniqueId)
		{
			return new IPackageVersion(method_GetPackageVersion_1.Invoke(packageUniqueId,versionUniqueId));
		}
		public IPackageVersion GetPackageVersion(DependencyInfo info)
		{
			return new IPackageVersion(method_GetPackageVersion_2.Invoke(info));
		}
		public void GetPackageAndVersion(string packageUniqueId,string versionUniqueId,ref IPackage package,ref IPackageVersion version)
		{
			method_GetPackageAndVersion_1.Invoke(packageUniqueId,versionUniqueId,package,version);
		}
		public IEnumerable<IPackageVersion> GetDependentVersions(IPackageVersion version)
		{
			return Utilities.GenerateEnumerable<IPackageVersion>(method_GetDependentVersions_1.Invoke(version));
		}
		public long GetRefreshTimestamp(PackageFilterTab? tab)
		{
			return (long) method_GetRefreshTimestamp_1.Invoke(tab);
		}
		public bool IsRefreshInProgress(PackageFilterTab? tab)
		{
			return (bool) method_IsRefreshInProgress_1.Invoke(tab);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.IPackageDatabase, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
