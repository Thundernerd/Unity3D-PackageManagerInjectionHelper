// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageList, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.StyleSheets;
using UnityEngine.UIElements.UIR;
using UnityEngine.Yoga;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageList : ReflectiveClass
	{
		private ReflectiveEvent event_onPackageListLoaded;
		private ReflectiveField<string> field_kUnityPackageGroupDisplayName;
		private ReflectiveField<double> field_kDelayBeforeCheck;
		private ReflectiveField<bool> field_mPackageListLoaded;
		private ReflectiveField<Action> field_onPackageListLoaded;
		private ReflectiveField<bool> field_mRefreshInProgress;
		private ReflectiveField field_mPackageItemsLookup;
		private ReflectiveField<double> field_mTimestamp;
		private ReflectiveProperty property_packageItems;
		private ReflectiveProperty property_packageGroups;
		private ReflectiveProperty property_cache;
		private ReflectiveProperty<ScrollView> property_scrollView;
		private ReflectiveProperty<VisualElement> property_itemsList;
		private ReflectiveProperty<VisualElement> property_loadMoreContainer;
		private ReflectiveProperty<Label> property_loadMoreLabel;
		private ReflectiveProperty<VisualElement> property_emptyArea;
		private ReflectiveProperty<Label> property_noPackagesLabel;
		private ReflectiveProperty<VisualElement> property_loginContainer;
		private ReflectiveProperty<Button> property_loginButton;
		private ReflectiveMethod method_OnEnable_1;
		private ReflectiveMethod method_OnDisable_1;
		private ReflectiveMethod method_OnScrollViewVerticalScrollerValueChanged_1;
		private ReflectiveMethod method_OnScrollViewGeometryChanged_1;
		private ReflectiveMethod method_StartDelayedCheckPackagesItemBecomeVisible_1;
		private ReflectiveMethod method_DelayedCheckPackageItemsBecomeVisible_1;
		private ReflectiveMethod method_CheckPackageItemsBecomeVisible_1;
		private ReflectiveMethod method_GetPackageItem_1;
		private ReflectiveMethod method_GetSelectedItem_1;
		private ReflectiveMethod method_LoadMoreItemsClicked_1;
		private ReflectiveMethod method_UpdateNoPackagesLabel_1;
		private ReflectiveMethod method_ShowEmptyResults_1;
		private ReflectiveMethod method_OnUserLoginStateChange_1;
		private ReflectiveMethod method_SetEmptyAreaDisplay_1;
		private ReflectiveMethod method_OnLoginClicked_1;
		private ReflectiveMethod method_OnEnterPanel_1;
		private ReflectiveMethod method_OnLeavePanel_1;
		private ReflectiveMethod method_OnPackageOperationFinish_1;
		private ReflectiveMethod method_OnPackageOperationStart_1;
		private ReflectiveMethod method_OnRefreshOperationStart_1;
		private ReflectiveMethod method_OnRefreshOperationFinish_1;
		private ReflectiveMethod method_OnDownloadProgress_1;
		private ReflectiveMethod method_ScrollIfNeeded_1;
		private ReflectiveMethod method_SetSelectedItemExpanded_1;
		private ReflectiveMethod method_OnKeyDownShortcut_1;
		private ReflectiveMethod method_AddOrUpdatePackageItem_1;
		private ReflectiveMethod method_GetGroupDisplayName_1;
		private ReflectiveMethod method_GetOrCreateGroup_1;
		private ReflectiveMethod method_RemovePackageItem_1;
		private ReflectiveMethod method_OnVisualStateChange_1;
		private ReflectiveMethod method_ReorderGroups_1;
		private ReflectiveMethod method_OnPageRebuild_1;
		private ReflectiveMethod method_OnPageUpdate_1;
		private ReflectiveMethod method_OnSelectionChanged_1;
		private ReflectiveMethod method_SelectNext_1;
		private ReflectiveMethod method_FindNextVisibleSelectableItem_1;
		private ReflectiveMethod method_OnFilterTabChanged_1;
		private ReflectiveMethod method_FindNextVisiblePackageItem_1;
		private ReflectiveMethod method_ClearAll_1;
		private ReflectiveMethod method_ShowResults_1;
		public PackageList(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageList(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			event_onPackageListLoaded = CreateEvent("onPackageListLoaded", BindingFlags.Instance | BindingFlags.Public);
			field_kUnityPackageGroupDisplayName = CreateField<string>("kUnityPackageGroupDisplayName", BindingFlags.Static | BindingFlags.NonPublic);
			field_kDelayBeforeCheck = CreateField<double>("kDelayBeforeCheck", BindingFlags.Static | BindingFlags.NonPublic);
			field_mPackageListLoaded = CreateField<bool>("mPackageListLoaded", BindingFlags.Instance | BindingFlags.NonPublic);
			field_onPackageListLoaded = CreateField<Action>("onPackageListLoaded", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mRefreshInProgress = CreateField<bool>("mRefreshInProgress", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mPackageItemsLookup = CreateField("mPackageItemsLookup", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mTimestamp = CreateField<double>("mTimestamp", BindingFlags.Instance | BindingFlags.NonPublic);
			property_packageItems = CreateProperty("packageItems", BindingFlags.Instance | BindingFlags.NonPublic);
			property_packageGroups = CreateProperty("packageGroups", BindingFlags.Instance | BindingFlags.NonPublic);
			property_cache = CreateProperty("cache", BindingFlags.Instance | BindingFlags.NonPublic);
			property_scrollView = CreateProperty<ScrollView>("scrollView", BindingFlags.Instance | BindingFlags.NonPublic);
			property_itemsList = CreateProperty<VisualElement>("itemsList", BindingFlags.Instance | BindingFlags.NonPublic);
			property_loadMoreContainer = CreateProperty<VisualElement>("loadMoreContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_loadMoreLabel = CreateProperty<Label>("loadMoreLabel", BindingFlags.Instance | BindingFlags.NonPublic);
			property_emptyArea = CreateProperty<VisualElement>("emptyArea", BindingFlags.Instance | BindingFlags.NonPublic);
			property_noPackagesLabel = CreateProperty<Label>("noPackagesLabel", BindingFlags.Instance | BindingFlags.NonPublic);
			property_loginContainer = CreateProperty<VisualElement>("loginContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_loginButton = CreateProperty<Button>("loginButton", BindingFlags.Instance | BindingFlags.NonPublic);
			method_OnEnable_1 = CreateMethod("OnEnable", BindingFlags.Instance | BindingFlags.Public, null);
			method_OnDisable_1 = CreateMethod("OnDisable", BindingFlags.Instance | BindingFlags.Public, null);
			method_OnScrollViewVerticalScrollerValueChanged_1 = CreateMethod("OnScrollViewVerticalScrollerValueChanged", BindingFlags.Instance | BindingFlags.NonPublic, typeof(float));
			method_OnScrollViewGeometryChanged_1 = CreateMethod("OnScrollViewGeometryChanged", BindingFlags.Instance | BindingFlags.NonPublic, typeof(GeometryChangedEvent));
			method_StartDelayedCheckPackagesItemBecomeVisible_1 = CreateMethod("StartDelayedCheckPackagesItemBecomeVisible", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_DelayedCheckPackageItemsBecomeVisible_1 = CreateMethod("DelayedCheckPackageItemsBecomeVisible", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_CheckPackageItemsBecomeVisible_1 = CreateMethod("CheckPackageItemsBecomeVisible", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_GetPackageItem_1 = CreateMethod("GetPackageItem", BindingFlags.Instance | BindingFlags.NonPublic, typeof(string));
			method_GetSelectedItem_1 = CreateMethod("GetSelectedItem", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_LoadMoreItemsClicked_1 = CreateMethod("LoadMoreItemsClicked", BindingFlags.Instance | BindingFlags.Public, null);
			method_UpdateNoPackagesLabel_1 = CreateMethod("UpdateNoPackagesLabel", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_ShowEmptyResults_1 = CreateMethod("ShowEmptyResults", BindingFlags.Instance | BindingFlags.Public, typeof(bool));
			method_OnUserLoginStateChange_1 = CreateMethod("OnUserLoginStateChange", BindingFlags.Instance | BindingFlags.NonPublic, typeof(bool));
			method_SetEmptyAreaDisplay_1 = CreateMethod("SetEmptyAreaDisplay", BindingFlags.Instance | BindingFlags.NonPublic, typeof(bool));
			method_OnLoginClicked_1 = CreateMethod("OnLoginClicked", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_OnEnterPanel_1 = CreateMethod("OnEnterPanel", BindingFlags.Instance | BindingFlags.NonPublic, typeof(AttachToPanelEvent));
			method_OnLeavePanel_1 = CreateMethod("OnLeavePanel", BindingFlags.Instance | BindingFlags.NonPublic, typeof(DetachFromPanelEvent));
			method_OnPackageOperationFinish_1 = CreateMethod("OnPackageOperationFinish", BindingFlags.Instance | BindingFlags.NonPublic, typeof(IPackage));
			method_OnPackageOperationStart_1 = CreateMethod("OnPackageOperationStart", BindingFlags.Instance | BindingFlags.NonPublic, typeof(IPackage));
			method_OnRefreshOperationStart_1 = CreateMethod("OnRefreshOperationStart", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_OnRefreshOperationFinish_1 = CreateMethod("OnRefreshOperationFinish", BindingFlags.Instance | BindingFlags.NonPublic, typeof(PackageFilterTab));
			method_OnDownloadProgress_1 = CreateMethod("OnDownloadProgress", BindingFlags.Instance | BindingFlags.NonPublic, typeof(IPackage),typeof(DownloadProgress));
			method_ScrollIfNeeded_1 = CreateMethod("ScrollIfNeeded", BindingFlags.Instance | BindingFlags.NonPublic, typeof(ScrollView),typeof(VisualElement));
			method_SetSelectedItemExpanded_1 = CreateMethod("SetSelectedItemExpanded", BindingFlags.Instance | BindingFlags.NonPublic, typeof(bool));
			method_OnKeyDownShortcut_1 = CreateMethod("OnKeyDownShortcut", BindingFlags.Instance | BindingFlags.NonPublic, typeof(KeyDownEvent));
			method_AddOrUpdatePackageItem_1 = CreateMethod("AddOrUpdatePackageItem", BindingFlags.Instance | BindingFlags.NonPublic, typeof(VisualState),typeof(IPackage));
			method_GetGroupDisplayName_1 = CreateMethod("GetGroupDisplayName", BindingFlags.Static | BindingFlags.NonPublic, typeof(string));
			method_GetOrCreateGroup_1 = CreateMethod("GetOrCreateGroup", BindingFlags.Instance | BindingFlags.NonPublic, typeof(string));
			method_RemovePackageItem_1 = CreateMethod("RemovePackageItem", BindingFlags.Instance | BindingFlags.NonPublic, typeof(string));
			method_OnVisualStateChange_1 = CreateMethod("OnVisualStateChange", BindingFlags.Instance | BindingFlags.NonPublic, typeof(IEnumerable<VisualState>));
			method_ReorderGroups_1 = CreateMethod("ReorderGroups", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_OnPageRebuild_1 = CreateMethod("OnPageRebuild", BindingFlags.Instance | BindingFlags.NonPublic, typeof(IPage));
			method_OnPageUpdate_1 = CreateMethod("OnPageUpdate", BindingFlags.Instance | BindingFlags.NonPublic, typeof(IPage),typeof(IEnumerable<IPackage>),typeof(IEnumerable<IPackage>));
			method_OnSelectionChanged_1 = CreateMethod("OnSelectionChanged", BindingFlags.Instance | BindingFlags.NonPublic, typeof(IPackageVersion));
			method_SelectNext_1 = CreateMethod("SelectNext", BindingFlags.Instance | BindingFlags.NonPublic, typeof(bool));
			method_FindNextVisibleSelectableItem_1 = CreateMethod("FindNextVisibleSelectableItem", BindingFlags.Instance | BindingFlags.NonPublic, typeof(bool));
			method_OnFilterTabChanged_1 = CreateMethod("OnFilterTabChanged", BindingFlags.Instance | BindingFlags.NonPublic, typeof(PackageFilterTab));
			method_FindNextVisiblePackageItem_1 = CreateMethod("FindNextVisiblePackageItem", BindingFlags.Static | BindingFlags.NonPublic, typeof(PackageItem),typeof(bool));
			method_ClearAll_1 = CreateMethod("ClearAll", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_ShowResults_1 = CreateMethod("ShowResults", BindingFlags.Instance | BindingFlags.NonPublic, typeof(bool));
		}
		partial void Initialize();
		/// <summary>
		/// Event type: System.Action
		/// </summary>
		/// <returns>Delegate to be used for unsubscribing</returns>
		public Delegate SubscribeToOnPackageListLoaded(Delegate @delegate)
		{
			return event_onPackageListLoaded.Subscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action
		/// </summary>
		public void UnsubscribeFromOnPackageListLoaded(Delegate @delegate)
		{
			event_onPackageListLoaded.Unsubscribe(@delegate);
		}
		public string kUnityPackageGroupDisplayName
		{
			get => field_kUnityPackageGroupDisplayName.GetValue();
			set => field_kUnityPackageGroupDisplayName.SetValue(value);
		}
		public double kDelayBeforeCheck
		{
			get => field_kDelayBeforeCheck.GetValue();
			set => field_kDelayBeforeCheck.SetValue(value);
		}
		public bool mPackageListLoaded
		{
			get => field_mPackageListLoaded.GetValue();
			set => field_mPackageListLoaded.SetValue(value);
		}
		public Action onPackageListLoaded
		{
			get => field_onPackageListLoaded.GetValue();
			set => field_onPackageListLoaded.SetValue(value);
		}
		public bool mRefreshInProgress
		{
			get => field_mRefreshInProgress.GetValue();
			set => field_mRefreshInProgress.SetValue(value);
		}
		public Dictionary<string, PackageItem> mPackageItemsLookup
		{
			get
			{
				object _temp = field_mPackageItemsLookup.GetValue();
				return _temp == null ? null : Utilities.GenerateDictionary<string,PackageItem>(_temp);
			}
		}
		public double mTimestamp
		{
			get => field_mTimestamp.GetValue();
			set => field_mTimestamp.SetValue(value);
		}
		public IEnumerable<PackageItem> packageItems
		{
			get
			{
				object _temp = property_packageItems.GetValue();
				return _temp == null ? null : Utilities.GenerateEnumerable<PackageItem>(_temp);
			}
		}
		public IEnumerable<PackageGroup> packageGroups
		{
			get
			{
				object _temp = property_packageGroups.GetValue();
				return _temp == null ? null : Utilities.GenerateEnumerable<PackageGroup>(_temp);
			}
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
		public ScrollView scrollView
		{
			get => property_scrollView.GetValue();
		}
		public VisualElement itemsList
		{
			get => property_itemsList.GetValue();
		}
		public VisualElement loadMoreContainer
		{
			get => property_loadMoreContainer.GetValue();
		}
		public Label loadMoreLabel
		{
			get => property_loadMoreLabel.GetValue();
		}
		public VisualElement emptyArea
		{
			get => property_emptyArea.GetValue();
		}
		public Label noPackagesLabel
		{
			get => property_noPackagesLabel.GetValue();
		}
		public VisualElement loginContainer
		{
			get => property_loginContainer.GetValue();
		}
		public Button loginButton
		{
			get => property_loginButton.GetValue();
		}
		public void OnEnable()
		{
			method_OnEnable_1.Invoke();
		}
		public void OnDisable()
		{
			method_OnDisable_1.Invoke();
		}
		public void OnScrollViewVerticalScrollerValueChanged(float value)
		{
			method_OnScrollViewVerticalScrollerValueChanged_1.Invoke(value);
		}
		public void OnScrollViewGeometryChanged(GeometryChangedEvent evt)
		{
			method_OnScrollViewGeometryChanged_1.Invoke(evt);
		}
		public void StartDelayedCheckPackagesItemBecomeVisible()
		{
			method_StartDelayedCheckPackagesItemBecomeVisible_1.Invoke();
		}
		public void DelayedCheckPackageItemsBecomeVisible()
		{
			method_DelayedCheckPackageItemsBecomeVisible_1.Invoke();
		}
		public void CheckPackageItemsBecomeVisible()
		{
			method_CheckPackageItemsBecomeVisible_1.Invoke();
		}
		public PackageItem GetPackageItem(string packageUniqueId)
		{
			return new PackageItem(method_GetPackageItem_1.Invoke(packageUniqueId));
		}
		public ISelectableItem GetSelectedItem()
		{
			return new ISelectableItem(method_GetSelectedItem_1.Invoke());
		}
		public void LoadMoreItemsClicked()
		{
			method_LoadMoreItemsClicked_1.Invoke();
		}
		public void UpdateNoPackagesLabel()
		{
			method_UpdateNoPackagesLabel_1.Invoke();
		}
		public void ShowEmptyResults(bool value)
		{
			method_ShowEmptyResults_1.Invoke(value);
		}
		public void OnUserLoginStateChange(bool loggedIn)
		{
			method_OnUserLoginStateChange_1.Invoke(loggedIn);
		}
		public void SetEmptyAreaDisplay(bool value)
		{
			method_SetEmptyAreaDisplay_1.Invoke(value);
		}
		public void OnLoginClicked()
		{
			method_OnLoginClicked_1.Invoke();
		}
		public void OnEnterPanel(AttachToPanelEvent e)
		{
			method_OnEnterPanel_1.Invoke(e);
		}
		public void OnLeavePanel(DetachFromPanelEvent e)
		{
			method_OnLeavePanel_1.Invoke(e);
		}
		public void OnPackageOperationFinish(IPackage package)
		{
			method_OnPackageOperationFinish_1.Invoke(package);
		}
		public void OnPackageOperationStart(IPackage package)
		{
			method_OnPackageOperationStart_1.Invoke(package);
		}
		public void OnRefreshOperationStart()
		{
			method_OnRefreshOperationStart_1.Invoke();
		}
		public void OnRefreshOperationFinish(PackageFilterTab tab)
		{
			method_OnRefreshOperationFinish_1.Invoke((int)tab);
		}
		public void OnDownloadProgress(IPackage package,DownloadProgress progress)
		{
			method_OnDownloadProgress_1.Invoke(package,progress);
		}
		public void ScrollIfNeeded(ScrollView scrollView,VisualElement target)
		{
			method_ScrollIfNeeded_1.Invoke(scrollView,target);
		}
		public void SetSelectedItemExpanded(bool value)
		{
			method_SetSelectedItemExpanded_1.Invoke(value);
		}
		public void OnKeyDownShortcut(KeyDownEvent evt)
		{
			method_OnKeyDownShortcut_1.Invoke(evt);
		}
		public void AddOrUpdatePackageItem(VisualState state,IPackage package)
		{
			method_AddOrUpdatePackageItem_1.Invoke(state,package);
		}
		public string GetGroupDisplayName(string groupName)
		{
			return (string) method_GetGroupDisplayName_1.Invoke(groupName);
		}
		public PackageGroup GetOrCreateGroup(string groupName)
		{
			return new PackageGroup(method_GetOrCreateGroup_1.Invoke(groupName));
		}
		public void RemovePackageItem(string packageUniqueId)
		{
			method_RemovePackageItem_1.Invoke(packageUniqueId);
		}
		public void OnVisualStateChange(IEnumerable<VisualState> visualStates)
		{
			method_OnVisualStateChange_1.Invoke(visualStates);
		}
		public void ReorderGroups()
		{
			method_ReorderGroups_1.Invoke();
		}
		public void OnPageRebuild(IPage page)
		{
			method_OnPageRebuild_1.Invoke(page);
		}
		public void OnPageUpdate(IPage page,IEnumerable<IPackage> addedOrUpdated,IEnumerable<IPackage> removed)
		{
			method_OnPageUpdate_1.Invoke(page,addedOrUpdated,removed);
		}
		public void OnSelectionChanged(IPackageVersion newSelection)
		{
			method_OnSelectionChanged_1.Invoke(newSelection);
		}
		public bool SelectNext(bool reverseOrder)
		{
			return (bool) method_SelectNext_1.Invoke(reverseOrder);
		}
		public ISelectableItem FindNextVisibleSelectableItem(bool reverseOrder)
		{
			return new ISelectableItem(method_FindNextVisibleSelectableItem_1.Invoke(reverseOrder));
		}
		public void OnFilterTabChanged(PackageFilterTab filterTab)
		{
			method_OnFilterTabChanged_1.Invoke((int)filterTab);
		}
		public PackageItem FindNextVisiblePackageItem(PackageItem packageItem,bool reverseOrder)
		{
			return new PackageItem(method_FindNextVisiblePackageItem_1.Invoke(packageItem,reverseOrder));
		}
		public void ClearAll()
		{
			method_ClearAll_1.Invoke();
		}
		public void ShowResults(bool scrollIfNeeded)
		{
			method_ShowResults_1.Invoke(scrollIfNeeded);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageList, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
