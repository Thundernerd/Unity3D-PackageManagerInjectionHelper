// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.IPageManager, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class IPageManager : ReflectiveClass
	{
		private ReflectiveEvent event_onSelectionChanged;
		private ReflectiveEvent event_onPageUpdate;
		private ReflectiveEvent event_onPageRebuild;
		private ReflectiveEvent event_onVisualStateChange;
		private ReflectiveProperty<bool> property_isInitialized;
		private ReflectiveMethod method_GetSelectedVersion_1;
		private ReflectiveMethod method_ClearSelection_1;
		private ReflectiveMethod method_SetSelected_1;
		private ReflectiveMethod method_SetSeeAllVersions_1;
		private ReflectiveMethod method_SetExpanded_1;
		private ReflectiveMethod method_GetVisualState_1;
		private ReflectiveMethod method_IsGroupExpanded_1;
		private ReflectiveMethod method_SetGroupExpanded_1;
		private ReflectiveMethod method_Setup_1;
		private ReflectiveMethod method_RegisterEvents_1;
		private ReflectiveMethod method_UnregisterEvents_1;
		private ReflectiveMethod method_Refresh_1;
		private ReflectiveMethod method_Refresh_2;
		private ReflectiveMethod method_Fetch_1;
		private ReflectiveMethod method_GetCurrentPage_1;
		private ReflectiveMethod method_HasFetchedPageForFilterTab_1;
		private ReflectiveMethod method_LoadMore_1;
		public IPageManager(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public IPageManager(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			event_onSelectionChanged = CreateEvent("onSelectionChanged", BindingFlags.Instance | BindingFlags.Public);
			event_onPageUpdate = CreateEvent("onPageUpdate", BindingFlags.Instance | BindingFlags.Public);
			event_onPageRebuild = CreateEvent("onPageRebuild", BindingFlags.Instance | BindingFlags.Public);
			event_onVisualStateChange = CreateEvent("onVisualStateChange", BindingFlags.Instance | BindingFlags.Public);
			property_isInitialized = CreateProperty<bool>("isInitialized", BindingFlags.Instance | BindingFlags.Public);
			method_GetSelectedVersion_1 = CreateMethod("GetSelectedVersion", BindingFlags.Instance | BindingFlags.Public, null);
			method_ClearSelection_1 = CreateMethod("ClearSelection", BindingFlags.Instance | BindingFlags.Public, null);
			method_SetSelected_1 = CreateMethod("SetSelected", BindingFlags.Instance | BindingFlags.Public, typeof(IPackage),typeof(IPackageVersion));
			method_SetSeeAllVersions_1 = CreateMethod("SetSeeAllVersions", BindingFlags.Instance | BindingFlags.Public, typeof(IPackage),typeof(bool));
			method_SetExpanded_1 = CreateMethod("SetExpanded", BindingFlags.Instance | BindingFlags.Public, typeof(IPackage),typeof(bool));
			method_GetVisualState_1 = CreateMethod("GetVisualState", BindingFlags.Instance | BindingFlags.Public, typeof(IPackage));
			method_IsGroupExpanded_1 = CreateMethod("IsGroupExpanded", BindingFlags.Instance | BindingFlags.Public, typeof(string));
			method_SetGroupExpanded_1 = CreateMethod("SetGroupExpanded", BindingFlags.Instance | BindingFlags.Public, typeof(string),typeof(bool));
			method_Setup_1 = CreateMethod("Setup", BindingFlags.Instance | BindingFlags.Public, null);
			method_RegisterEvents_1 = CreateMethod("RegisterEvents", BindingFlags.Instance | BindingFlags.Public, null);
			method_UnregisterEvents_1 = CreateMethod("UnregisterEvents", BindingFlags.Instance | BindingFlags.Public, null);
			method_Refresh_1 = CreateMethod("Refresh", BindingFlags.Instance | BindingFlags.Public, typeof(PackageFilterTab));
			method_Refresh_2 = CreateMethod("Refresh", BindingFlags.Instance | BindingFlags.Public, typeof(RefreshOptions));
			method_Fetch_1 = CreateMethod("Fetch", BindingFlags.Instance | BindingFlags.Public, typeof(string));
			method_GetCurrentPage_1 = CreateMethod("GetCurrentPage", BindingFlags.Instance | BindingFlags.Public, null);
			method_HasFetchedPageForFilterTab_1 = CreateMethod("HasFetchedPageForFilterTab", BindingFlags.Instance | BindingFlags.Public, typeof(PackageFilterTab?));
			method_LoadMore_1 = CreateMethod("LoadMore", BindingFlags.Instance | BindingFlags.Public, null);
		}
		partial void Initialize();
		/// <summary>
		/// Event type: System.Action<IPackageVersion>
		/// </summary>
		/// <returns>Delegate to be used for unsubscribing</returns>
		public Delegate SubscribeToOnSelectionChanged(Delegate @delegate)
		{
			return event_onSelectionChanged.Subscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<IPackageVersion>
		/// </summary>
		public void UnsubscribeFromOnSelectionChanged(Delegate @delegate)
		{
			event_onSelectionChanged.Unsubscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<IPage, IEnumerable<IPackage>, IEnumerable<IPackage>>
		/// </summary>
		/// <returns>Delegate to be used for unsubscribing</returns>
		public Delegate SubscribeToOnPageUpdate(Delegate @delegate)
		{
			return event_onPageUpdate.Subscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<IPage, IEnumerable<IPackage>, IEnumerable<IPackage>>
		/// </summary>
		public void UnsubscribeFromOnPageUpdate(Delegate @delegate)
		{
			event_onPageUpdate.Unsubscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<IPage>
		/// </summary>
		/// <returns>Delegate to be used for unsubscribing</returns>
		public Delegate SubscribeToOnPageRebuild(Delegate @delegate)
		{
			return event_onPageRebuild.Subscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<IPage>
		/// </summary>
		public void UnsubscribeFromOnPageRebuild(Delegate @delegate)
		{
			event_onPageRebuild.Unsubscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<IEnumerable<VisualState>>
		/// </summary>
		/// <returns>Delegate to be used for unsubscribing</returns>
		public Delegate SubscribeToOnVisualStateChange(Delegate @delegate)
		{
			return event_onVisualStateChange.Subscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<IEnumerable<VisualState>>
		/// </summary>
		public void UnsubscribeFromOnVisualStateChange(Delegate @delegate)
		{
			event_onVisualStateChange.Unsubscribe(@delegate);
		}
		public bool isInitialized
		{
			get => property_isInitialized.GetValue();
		}
		public IPackageVersion GetSelectedVersion()
		{
			return new IPackageVersion(method_GetSelectedVersion_1.Invoke());
		}
		public void ClearSelection()
		{
			method_ClearSelection_1.Invoke();
		}
		public void SetSelected(IPackage package,IPackageVersion version)
		{
			method_SetSelected_1.Invoke(package,version);
		}
		public void SetSeeAllVersions(IPackage package,bool value)
		{
			method_SetSeeAllVersions_1.Invoke(package,value);
		}
		public void SetExpanded(IPackage package,bool value)
		{
			method_SetExpanded_1.Invoke(package,value);
		}
		public VisualState GetVisualState(IPackage package)
		{
			return new VisualState(method_GetVisualState_1.Invoke(package));
		}
		public bool IsGroupExpanded(string groupName)
		{
			return (bool) method_IsGroupExpanded_1.Invoke(groupName);
		}
		public void SetGroupExpanded(string groupName,bool value)
		{
			method_SetGroupExpanded_1.Invoke(groupName,value);
		}
		public void Setup()
		{
			method_Setup_1.Invoke();
		}
		public void RegisterEvents()
		{
			method_RegisterEvents_1.Invoke();
		}
		public void UnregisterEvents()
		{
			method_UnregisterEvents_1.Invoke();
		}
		public void Refresh(PackageFilterTab tab)
		{
			method_Refresh_1.Invoke((int)tab);
		}
		public void Refresh(RefreshOptions options)
		{
			method_Refresh_2.Invoke((uint)options);
		}
		public void Fetch(string uniqueId)
		{
			method_Fetch_1.Invoke(uniqueId);
		}
		public IPage GetCurrentPage()
		{
			return new IPage(method_GetCurrentPage_1.Invoke());
		}
		public bool HasFetchedPageForFilterTab(PackageFilterTab? tab)
		{
			return (bool) method_HasFetchedPageForFilterTab_1.Invoke(tab);
		}
		public void LoadMore()
		{
			method_LoadMore_1.Invoke();
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.IPageManager, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
