// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageManagerToolbar, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager.UI;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.StyleSheets;
using UnityEngine.UIElements.UIR;
using UnityEngine.Yoga;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageManagerToolbar : ReflectiveClass
	{
		private ReflectiveField<long> field_mSearchTextChangeTimestamp;
		private ReflectiveField<long> field_kSearchEventDelayTicks;
		private ReflectiveProperty<bool> property_HasPackageCustom;
		private ReflectiveProperty<bool> property_HasPackageInScopeRegistries;
		private ReflectiveProperty property_cache;
		private ReflectiveProperty<ToolbarMenu> property_addMenu;
		private ReflectiveProperty<ToolbarMenu> property_filterMenu;
		private ReflectiveProperty<ToolbarMenu> property_advancedMenu;
		private ReflectiveProperty<ToolbarSearchField> property_searchToolbar;
		private ReflectiveMethod method_OnEnable_1;
		private ReflectiveMethod method_OnDisable_1;
		private ReflectiveMethod method_FocusOnSearch_1;
		private ReflectiveMethod method_OnPackagesChanged_1;
		private ReflectiveMethod method_SetCurrentSearch_1;
		private ReflectiveMethod method_OnSearchTextChanged_1;
		private ReflectiveMethod method_DelayedSearchEvent_1;
		private ReflectiveMethod method_GetFilterDisplayName_1;
		private ReflectiveMethod method_SetFilter_1;
		private ReflectiveMethod method_SetFilterFromMenu_1;
		private ReflectiveMethod method_SetupAddMenu_1;
		private ReflectiveMethod method_AddFilterTabToDropdownMenu_1;
		private ReflectiveMethod method_SetupFilterMenu_1;
		private ReflectiveMethod method_SetupAdvancedMenu_1;
		private ReflectiveMethod method_ToggleDependencies_1;
		private ReflectiveMethod method_TogglePreviewPackages_1;
		public PackageManagerToolbar(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageManagerToolbar(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_mSearchTextChangeTimestamp = CreateField<long>("mSearchTextChangeTimestamp", BindingFlags.Instance | BindingFlags.NonPublic);
			field_kSearchEventDelayTicks = CreateField<long>("kSearchEventDelayTicks", BindingFlags.Static | BindingFlags.NonPublic);
			property_HasPackageCustom = CreateProperty<bool>("HasPackageCustom", BindingFlags.Static | BindingFlags.NonPublic);
			property_HasPackageInScopeRegistries = CreateProperty<bool>("HasPackageInScopeRegistries", BindingFlags.Static | BindingFlags.NonPublic);
			property_cache = CreateProperty("cache", BindingFlags.Instance | BindingFlags.NonPublic);
			property_addMenu = CreateProperty<ToolbarMenu>("addMenu", BindingFlags.Instance | BindingFlags.NonPublic);
			property_filterMenu = CreateProperty<ToolbarMenu>("filterMenu", BindingFlags.Instance | BindingFlags.NonPublic);
			property_advancedMenu = CreateProperty<ToolbarMenu>("advancedMenu", BindingFlags.Instance | BindingFlags.NonPublic);
			property_searchToolbar = CreateProperty<ToolbarSearchField>("searchToolbar", BindingFlags.Instance | BindingFlags.NonPublic);
			method_OnEnable_1 = CreateMethod("OnEnable", BindingFlags.Instance | BindingFlags.Public, null);
			method_OnDisable_1 = CreateMethod("OnDisable", BindingFlags.Instance | BindingFlags.Public, null);
			method_FocusOnSearch_1 = CreateMethod("FocusOnSearch", BindingFlags.Instance | BindingFlags.Public, null);
			method_OnPackagesChanged_1 = CreateMethod("OnPackagesChanged", BindingFlags.Instance | BindingFlags.NonPublic, typeof(IEnumerable<IPackage>),typeof(IEnumerable<IPackage>),typeof(IEnumerable<IPackage>),typeof(IEnumerable<IPackage>));
			method_SetCurrentSearch_1 = CreateMethod("SetCurrentSearch", BindingFlags.Instance | BindingFlags.NonPublic, typeof(string));
			method_OnSearchTextChanged_1 = CreateMethod("OnSearchTextChanged", BindingFlags.Instance | BindingFlags.NonPublic, typeof(ChangeEvent<string>));
			method_DelayedSearchEvent_1 = CreateMethod("DelayedSearchEvent", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_GetFilterDisplayName_1 = CreateMethod("GetFilterDisplayName", BindingFlags.Static | BindingFlags.NonPublic, typeof(PackageFilterTab));
			method_SetFilter_1 = CreateMethod("SetFilter", BindingFlags.Instance | BindingFlags.Public, typeof(PackageFilterTab));
			method_SetFilterFromMenu_1 = CreateMethod("SetFilterFromMenu", BindingFlags.Instance | BindingFlags.NonPublic, typeof(PackageFilterTab));
			method_SetupAddMenu_1 = CreateMethod("SetupAddMenu", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_AddFilterTabToDropdownMenu_1 = CreateMethod("AddFilterTabToDropdownMenu", BindingFlags.Instance | BindingFlags.NonPublic, typeof(PackageFilterTab),typeof(Action<DropdownMenuAction>),typeof(Func<DropdownMenuAction, DropdownMenuAction.Status>));
			method_SetupFilterMenu_1 = CreateMethod("SetupFilterMenu", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_SetupAdvancedMenu_1 = CreateMethod("SetupAdvancedMenu", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_ToggleDependencies_1 = CreateMethod("ToggleDependencies", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_TogglePreviewPackages_1 = CreateMethod("TogglePreviewPackages", BindingFlags.Instance | BindingFlags.NonPublic, null);
		}
		partial void Initialize();
		public long mSearchTextChangeTimestamp
		{
			get => field_mSearchTextChangeTimestamp.GetValue();
			set => field_mSearchTextChangeTimestamp.SetValue(value);
		}
		public long kSearchEventDelayTicks
		{
			get => field_kSearchEventDelayTicks.GetValue();
			set => field_kSearchEventDelayTicks.SetValue(value);
		}
		public bool HasPackageCustom
		{
			get => property_HasPackageCustom.GetValue();
		}
		public bool HasPackageInScopeRegistries
		{
			get => property_HasPackageInScopeRegistries.GetValue();
		}
		public VisualElementCache cache
		{
			get
			{
				object _temp = property_cache.GetValue();
				return _temp == null ? null : new VisualElementCache(_temp);
			}
			set => property_cache.SetValue(value.Instance);
		}
		public ToolbarMenu addMenu
		{
			get => property_addMenu.GetValue();
		}
		public ToolbarMenu filterMenu
		{
			get => property_filterMenu.GetValue();
		}
		public ToolbarMenu advancedMenu
		{
			get => property_advancedMenu.GetValue();
		}
		public ToolbarSearchField searchToolbar
		{
			get => property_searchToolbar.GetValue();
		}
		public void OnEnable()
		{
			method_OnEnable_1.Invoke();
		}
		public void OnDisable()
		{
			method_OnDisable_1.Invoke();
		}
		public void FocusOnSearch()
		{
			method_FocusOnSearch_1.Invoke();
		}
		public void OnPackagesChanged(IEnumerable<IPackage> added,IEnumerable<IPackage> removed,IEnumerable<IPackage> preUpdate,IEnumerable<IPackage> postUpdate)
		{
			method_OnPackagesChanged_1.Invoke(added,removed,preUpdate,postUpdate);
		}
		public void SetCurrentSearch(string text)
		{
			method_SetCurrentSearch_1.Invoke(text);
		}
		public void OnSearchTextChanged(ChangeEvent<string> evt)
		{
			method_OnSearchTextChanged_1.Invoke(evt);
		}
		public void DelayedSearchEvent()
		{
			method_DelayedSearchEvent_1.Invoke();
		}
		public string GetFilterDisplayName(PackageFilterTab filter)
		{
			return (string) method_GetFilterDisplayName_1.Invoke((int)filter);
		}
		public void SetFilter(PackageFilterTab filter)
		{
			method_SetFilter_1.Invoke((int)filter);
		}
		public void SetFilterFromMenu(PackageFilterTab filter)
		{
			method_SetFilterFromMenu_1.Invoke((int)filter);
		}
		public void SetupAddMenu()
		{
			method_SetupAddMenu_1.Invoke();
		}
		public void AddFilterTabToDropdownMenu(PackageFilterTab tab,Action<DropdownMenuAction> action,Func<DropdownMenuAction, DropdownMenuAction.Status> actionStatusCallback)
		{
			method_AddFilterTabToDropdownMenu_1.Invoke((int)tab,action,actionStatusCallback);
		}
		public void SetupFilterMenu()
		{
			method_SetupFilterMenu_1.Invoke();
		}
		public void SetupAdvancedMenu()
		{
			method_SetupAdvancedMenu_1.Invoke();
		}
		public void ToggleDependencies()
		{
			method_ToggleDependencies_1.Invoke();
		}
		public void TogglePreviewPackages()
		{
			method_TogglePreviewPackages_1.Invoke();
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageManagerToolbar, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
