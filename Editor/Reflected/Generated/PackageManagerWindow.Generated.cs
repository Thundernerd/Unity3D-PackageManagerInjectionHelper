// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageManagerWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.UI;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageManagerWindow : ReflectiveClass
	{
		private ReflectiveField field_Collection;
		private ReflectiveField field_SearchFilter;
		private ReflectiveField field_SelectionManager;
		private ReflectiveField<VisualElement> field_root;
		private ReflectiveField<string> field_PackageToSelectAfterLoad;
		private ReflectiveField<bool> field_SkipFetchCacheForAllWindows;
		private ReflectiveProperty property_Cache;
		private ReflectiveProperty property_PackageList;
		private ReflectiveProperty property_PackageDetails;
		private ReflectiveProperty property_PackageManagerToolbar;
		private ReflectiveProperty property_PackageStatusbar;
		private ReflectiveMethod method_OnEnable_1;
		private ReflectiveMethod method_OnDisable_1;
		private ReflectiveMethod method_SetupCollection_1;
		private ReflectiveMethod method_SetupStatusbar_1;
		private ReflectiveMethod method_SetupToolbar_1;
		private ReflectiveMethod method_SetupSearchToolbar_1;
		private ReflectiveMethod method_SetupPackageList_1;
		private ReflectiveMethod method_SetupPackageDetails_1;
		private ReflectiveMethod method_SetupSelection_1;
		private ReflectiveMethod method_OnCloseError_1;
		private ReflectiveMethod method_OnOperationError_1;
		private ReflectiveMethod method_OnTogglePreviewChange_1;
		private ReflectiveMethod method_OnFilterChange_1;
		private ReflectiveMethod method_OnCheckInternetReachability_1;
		private ReflectiveMethod method_OnListFocusChange_1;
		private ReflectiveMethod method_OnToolbarFocusChange_1;
		private ReflectiveMethod method_OnSearchChange_1;
		private ReflectiveMethod method_OnPackagesLoaded_1;
		private ReflectiveMethod method_FetchListOfflineCacheForAllWindows_1;
		private ReflectiveMethod method_ShowPackageManagerWindow_1;
		public PackageManagerWindow(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageManagerWindow(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_Collection = CreateField("Collection", BindingFlags.Instance | BindingFlags.NonPublic);
			field_SearchFilter = CreateField("SearchFilter", BindingFlags.Instance | BindingFlags.NonPublic);
			field_SelectionManager = CreateField("SelectionManager", BindingFlags.Instance | BindingFlags.NonPublic);
			field_root = CreateField<VisualElement>("root", BindingFlags.Instance | BindingFlags.NonPublic);
			field_PackageToSelectAfterLoad = CreateField<string>("PackageToSelectAfterLoad", BindingFlags.Instance | BindingFlags.NonPublic);
			field_SkipFetchCacheForAllWindows = CreateField<bool>("SkipFetchCacheForAllWindows", BindingFlags.Static | BindingFlags.NonPublic);
			property_Cache = CreateProperty("Cache", BindingFlags.Instance | BindingFlags.NonPublic);
			property_PackageList = CreateProperty("PackageList", BindingFlags.Instance | BindingFlags.NonPublic);
			property_PackageDetails = CreateProperty("PackageDetails", BindingFlags.Instance | BindingFlags.NonPublic);
			property_PackageManagerToolbar = CreateProperty("PackageManagerToolbar", BindingFlags.Instance | BindingFlags.NonPublic);
			property_PackageStatusbar = CreateProperty("PackageStatusbar", BindingFlags.Instance | BindingFlags.NonPublic);
			method_OnEnable_1 = CreateMethod("OnEnable", BindingFlags.Instance | BindingFlags.Public, null);
			method_OnDisable_1 = CreateMethod("OnDisable", BindingFlags.Instance | BindingFlags.Public, null);
			method_SetupCollection_1 = CreateMethod("SetupCollection", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_SetupStatusbar_1 = CreateMethod("SetupStatusbar", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_SetupToolbar_1 = CreateMethod("SetupToolbar", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_SetupSearchToolbar_1 = CreateMethod("SetupSearchToolbar", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_SetupPackageList_1 = CreateMethod("SetupPackageList", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_SetupPackageDetails_1 = CreateMethod("SetupPackageDetails", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_SetupSelection_1 = CreateMethod("SetupSelection", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_OnCloseError_1 = CreateMethod("OnCloseError", BindingFlags.Instance | BindingFlags.NonPublic, typeof(Package));
			method_OnOperationError_1 = CreateMethod("OnOperationError", BindingFlags.Instance | BindingFlags.NonPublic, typeof(Package),typeof(Error));
			method_OnTogglePreviewChange_1 = CreateMethod("OnTogglePreviewChange", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_OnFilterChange_1 = CreateMethod("OnFilterChange", BindingFlags.Instance | BindingFlags.NonPublic, typeof(PackageFilter));
			method_OnCheckInternetReachability_1 = CreateMethod("OnCheckInternetReachability", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_OnListFocusChange_1 = CreateMethod("OnListFocusChange", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_OnToolbarFocusChange_1 = CreateMethod("OnToolbarFocusChange", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_OnSearchChange_1 = CreateMethod("OnSearchChange", BindingFlags.Instance | BindingFlags.NonPublic, typeof(string));
			method_OnPackagesLoaded_1 = CreateMethod("OnPackagesLoaded", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_FetchListOfflineCacheForAllWindows_1 = CreateMethod("FetchListOfflineCacheForAllWindows", BindingFlags.Static | BindingFlags.NonPublic, null);
			method_ShowPackageManagerWindow_1 = CreateMethod("ShowPackageManagerWindow", BindingFlags.Static | BindingFlags.NonPublic, typeof(MenuCommand));
		}
		partial void Initialize();
		public PackageCollection Collection
		{
			get
			{
				object _temp = field_Collection.GetValue();
				return _temp == null ? null : new PackageCollection(_temp);
			}
			set => field_Collection.SetValue(value.Instance);
		}
		public PackageSearchFilter SearchFilter
		{
			get
			{
				object _temp = field_SearchFilter.GetValue();
				return _temp == null ? null : new PackageSearchFilter(_temp);
			}
			set => field_SearchFilter.SetValue(value.Instance);
		}
		public SelectionManager SelectionManager
		{
			get
			{
				object _temp = field_SelectionManager.GetValue();
				return _temp == null ? null : new SelectionManager(_temp);
			}
			set => field_SelectionManager.SetValue(value.Instance);
		}
		public VisualElement root
		{
			get => field_root.GetValue();
			set => field_root.SetValue(value);
		}
		public string PackageToSelectAfterLoad
		{
			get => field_PackageToSelectAfterLoad.GetValue();
			set => field_PackageToSelectAfterLoad.SetValue(value);
		}
		public bool SkipFetchCacheForAllWindows
		{
			get => field_SkipFetchCacheForAllWindows.GetValue();
			set => field_SkipFetchCacheForAllWindows.SetValue(value);
		}
		public VisualElementCache Cache
		{
			get
			{
				object _temp = property_Cache.GetValue();
				return _temp == null ? null : new VisualElementCache(_temp);
			}
			set => property_Cache.SetValue(value.Instance);
		}
		public PackageList PackageList
		{
			get
			{
				object _temp = property_PackageList.GetValue();
				return _temp == null ? null : new PackageList(_temp);
			}
		}
		public PackageDetails PackageDetails
		{
			get
			{
				object _temp = property_PackageDetails.GetValue();
				return _temp == null ? null : new PackageDetails(_temp);
			}
		}
		public PackageManagerToolbar PackageManagerToolbar
		{
			get
			{
				object _temp = property_PackageManagerToolbar.GetValue();
				return _temp == null ? null : new PackageManagerToolbar(_temp);
			}
		}
		public PackageStatusBar PackageStatusbar
		{
			get
			{
				object _temp = property_PackageStatusbar.GetValue();
				return _temp == null ? null : new PackageStatusBar(_temp);
			}
		}
		public void OnEnable()
		{
			method_OnEnable_1.Invoke();
		}
		public void OnDisable()
		{
			method_OnDisable_1.Invoke();
		}
		public void SetupCollection()
		{
			method_SetupCollection_1.Invoke();
		}
		public void SetupStatusbar()
		{
			method_SetupStatusbar_1.Invoke();
		}
		public void SetupToolbar()
		{
			method_SetupToolbar_1.Invoke();
		}
		public void SetupSearchToolbar()
		{
			method_SetupSearchToolbar_1.Invoke();
		}
		public void SetupPackageList()
		{
			method_SetupPackageList_1.Invoke();
		}
		public void SetupPackageDetails()
		{
			method_SetupPackageDetails_1.Invoke();
		}
		public void SetupSelection()
		{
			method_SetupSelection_1.Invoke();
		}
		public void OnCloseError(Package package)
		{
			method_OnCloseError_1.Invoke(package);
		}
		public void OnOperationError(Package package,Error error)
		{
			method_OnOperationError_1.Invoke(package,error);
		}
		public void OnTogglePreviewChange()
		{
			method_OnTogglePreviewChange_1.Invoke();
		}
		public void OnFilterChange(PackageFilter filter)
		{
			method_OnFilterChange_1.Invoke((int)filter);
		}
		public void OnCheckInternetReachability()
		{
			method_OnCheckInternetReachability_1.Invoke();
		}
		public void OnListFocusChange()
		{
			method_OnListFocusChange_1.Invoke();
		}
		public void OnToolbarFocusChange()
		{
			method_OnToolbarFocusChange_1.Invoke();
		}
		public void OnSearchChange(string searchText)
		{
			method_OnSearchChange_1.Invoke(searchText);
		}
		public void OnPackagesLoaded()
		{
			method_OnPackagesLoaded_1.Invoke();
		}
		public void FetchListOfflineCacheForAllWindows()
		{
			method_FetchListOfflineCacheForAllWindows_1.Invoke();
		}
		public void ShowPackageManagerWindow(MenuCommand item)
		{
			method_ShowPackageManagerWindow_1.Invoke(item);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageManagerWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
