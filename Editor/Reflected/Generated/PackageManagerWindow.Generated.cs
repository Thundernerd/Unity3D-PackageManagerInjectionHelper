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
		private ReflectiveField<string> field_mPackageToSelectOnLoaded;
		private ReflectiveField field_mFilterToSelectAfterLoad;
		private ReflectiveField<float> field_mSplitPaneLeftWidth;
		private ReflectiveField field_sWindow;
		private ReflectiveField field_cache;
		private ReflectiveProperty property_packageList;
		private ReflectiveProperty property_packageDetails;
		private ReflectiveProperty property_packageManagerToolbar;
		private ReflectiveProperty property_packageStatusbar;
		private ReflectiveProperty property_mainContainer;
		private ReflectiveMethod method_OnEnable_1;
		private ReflectiveMethod method_OnAttachToPanel_1;
		private ReflectiveMethod method_OnDetachFromPanel_1;
		private ReflectiveMethod method_OnValidateCommandEvent_1;
		private ReflectiveMethod method_OnExecuteCommandEvent_1;
		private ReflectiveMethod method_OnFocusChanged_1;
		private ReflectiveMethod method_OnDisable_1;
		private ReflectiveMethod method_OnDestroy_1;
		private ReflectiveMethod method_OnRefreshOperationFinish_1;
		private ReflectiveMethod method_OnRefreshOperationStart_1;
		private ReflectiveMethod method_DisableToolbarIfRefreshInProgress_1;
		private ReflectiveMethod method_OnRefreshOperationError_1;
		private ReflectiveMethod method_OpenURL_1;
		private ReflectiveMethod method_OpenPackageManager_1;
		private ReflectiveMethod method_OnPackageManagerResolve_1;
		private ReflectiveMethod method_SelectPackageAndFilter_1;
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
			field_mPackageToSelectOnLoaded = CreateField<string>("mPackageToSelectOnLoaded", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mFilterToSelectAfterLoad = CreateField("mFilterToSelectAfterLoad", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mSplitPaneLeftWidth = CreateField<float>("mSplitPaneLeftWidth", BindingFlags.Instance | BindingFlags.NonPublic);
			field_sWindow = CreateField("sWindow", BindingFlags.Static | BindingFlags.NonPublic);
			field_cache = CreateField("cache", BindingFlags.Instance | BindingFlags.NonPublic);
			property_packageList = CreateProperty("packageList", BindingFlags.Instance | BindingFlags.NonPublic);
			property_packageDetails = CreateProperty("packageDetails", BindingFlags.Instance | BindingFlags.NonPublic);
			property_packageManagerToolbar = CreateProperty("packageManagerToolbar", BindingFlags.Instance | BindingFlags.NonPublic);
			property_packageStatusbar = CreateProperty("packageStatusbar", BindingFlags.Instance | BindingFlags.NonPublic);
			property_mainContainer = CreateProperty("mainContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			method_OnEnable_1 = CreateMethod("OnEnable", BindingFlags.Instance | BindingFlags.Public, null);
			method_OnAttachToPanel_1 = CreateMethod("OnAttachToPanel", BindingFlags.Instance | BindingFlags.NonPublic, typeof(AttachToPanelEvent));
			method_OnDetachFromPanel_1 = CreateMethod("OnDetachFromPanel", BindingFlags.Instance | BindingFlags.NonPublic, typeof(DetachFromPanelEvent));
			method_OnValidateCommandEvent_1 = CreateMethod("OnValidateCommandEvent", BindingFlags.Instance | BindingFlags.NonPublic, typeof(ValidateCommandEvent));
			method_OnExecuteCommandEvent_1 = CreateMethod("OnExecuteCommandEvent", BindingFlags.Instance | BindingFlags.NonPublic, typeof(ExecuteCommandEvent));
			method_OnFocusChanged_1 = CreateMethod("OnFocusChanged", BindingFlags.Instance | BindingFlags.NonPublic, typeof(bool));
			method_OnDisable_1 = CreateMethod("OnDisable", BindingFlags.Instance | BindingFlags.Public, null);
			method_OnDestroy_1 = CreateMethod("OnDestroy", BindingFlags.Instance | BindingFlags.Public, null);
			method_OnRefreshOperationFinish_1 = CreateMethod("OnRefreshOperationFinish", BindingFlags.Instance | BindingFlags.NonPublic, typeof(PackageFilterTab));
			method_OnRefreshOperationStart_1 = CreateMethod("OnRefreshOperationStart", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_DisableToolbarIfRefreshInProgress_1 = CreateMethod("DisableToolbarIfRefreshInProgress", BindingFlags.Instance | BindingFlags.NonPublic, typeof(PackageFilterTab?));
			method_OnRefreshOperationError_1 = CreateMethod("OnRefreshOperationError", BindingFlags.Instance | BindingFlags.NonPublic, typeof(Error));
			method_OpenURL_1 = CreateMethod("OpenURL", BindingFlags.Static | BindingFlags.NonPublic, typeof(string));
			method_OpenPackageManager_1 = CreateMethod("OpenPackageManager", BindingFlags.Static | BindingFlags.NonPublic, typeof(string));
			method_OnPackageManagerResolve_1 = CreateMethod("OnPackageManagerResolve", BindingFlags.Static | BindingFlags.NonPublic, null);
			method_SelectPackageAndFilter_1 = CreateMethod("SelectPackageAndFilter", BindingFlags.Static | BindingFlags.NonPublic, typeof(string),typeof(PackageFilterTab?),typeof(bool),typeof(string));
		}
		partial void Initialize();
		public string mPackageToSelectOnLoaded
		{
			get => field_mPackageToSelectOnLoaded.GetValue();
			set => field_mPackageToSelectOnLoaded.SetValue(value);
		}
		public PackageFilterTab mFilterToSelectAfterLoad
		{
			get
			{
				object _temp = (int)field_mFilterToSelectAfterLoad.GetValue();
				return (PackageFilterTab) _temp;
			}
			set => field_mFilterToSelectAfterLoad.SetValue((int)value);
		}
		public float mSplitPaneLeftWidth
		{
			get => field_mSplitPaneLeftWidth.GetValue();
			set => field_mSplitPaneLeftWidth.SetValue(value);
		}
		public PackageManagerWindow sWindow
		{
			get
			{
				object _temp = field_sWindow.GetValue();
				return _temp == null ? null : new PackageManagerWindow(_temp);
			}
			set => field_sWindow.SetValue(value.Instance);
		}
		public VisualElementCache cache
		{
			get
			{
				object _temp = field_cache.GetValue();
				return _temp == null ? null : new VisualElementCache(_temp);
			}
			set => field_cache.SetValue(value.Instance);
		}
		public PackageList packageList
		{
			get
			{
				object _temp = property_packageList.GetValue();
				return _temp == null ? null : new PackageList(_temp);
			}
		}
		public PackageDetails packageDetails
		{
			get
			{
				object _temp = property_packageDetails.GetValue();
				return _temp == null ? null : new PackageDetails(_temp);
			}
		}
		public PackageManagerToolbar packageManagerToolbar
		{
			get
			{
				object _temp = property_packageManagerToolbar.GetValue();
				return _temp == null ? null : new PackageManagerToolbar(_temp);
			}
		}
		public PackageStatusBar packageStatusbar
		{
			get
			{
				object _temp = property_packageStatusbar.GetValue();
				return _temp == null ? null : new PackageStatusBar(_temp);
			}
		}
		public SplitView mainContainer
		{
			get
			{
				object _temp = property_mainContainer.GetValue();
				return _temp == null ? null : new SplitView(_temp);
			}
		}
		public void OnEnable()
		{
			method_OnEnable_1.Invoke();
		}
		public void OnAttachToPanel(AttachToPanelEvent evt)
		{
			method_OnAttachToPanel_1.Invoke(evt);
		}
		public void OnDetachFromPanel(DetachFromPanelEvent evt)
		{
			method_OnDetachFromPanel_1.Invoke(evt);
		}
		public void OnValidateCommandEvent(ValidateCommandEvent evt)
		{
			method_OnValidateCommandEvent_1.Invoke(evt);
		}
		public void OnExecuteCommandEvent(ExecuteCommandEvent evt)
		{
			method_OnExecuteCommandEvent_1.Invoke(evt);
		}
		public void OnFocusChanged(bool focus)
		{
			method_OnFocusChanged_1.Invoke(focus);
		}
		public void OnDisable()
		{
			method_OnDisable_1.Invoke();
		}
		public void OnDestroy()
		{
			method_OnDestroy_1.Invoke();
		}
		public void OnRefreshOperationFinish(PackageFilterTab tab)
		{
			method_OnRefreshOperationFinish_1.Invoke((int)tab);
		}
		public void OnRefreshOperationStart()
		{
			method_OnRefreshOperationStart_1.Invoke();
		}
		public void DisableToolbarIfRefreshInProgress(PackageFilterTab? tab)
		{
			method_DisableToolbarIfRefreshInProgress_1.Invoke(tab);
		}
		public void OnRefreshOperationError(Error error)
		{
			method_OnRefreshOperationError_1.Invoke(error);
		}
		public void OpenURL(string url)
		{
			method_OpenURL_1.Invoke(url);
		}
		public void OpenPackageManager(string packageNameOrDisplayName)
		{
			method_OpenPackageManager_1.Invoke(packageNameOrDisplayName);
		}
		public void OnPackageManagerResolve()
		{
			method_OnPackageManagerResolve_1.Invoke();
		}
		public void SelectPackageAndFilter(string packageIdOrDisplayName,PackageFilterTab? filterTab,bool refresh,string searchText)
		{
			method_SelectPackageAndFilter_1.Invoke(packageIdOrDisplayName,filterTab,refresh,searchText);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageManagerWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
