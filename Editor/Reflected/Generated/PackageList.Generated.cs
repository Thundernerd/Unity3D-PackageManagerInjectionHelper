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
		private ReflectiveEvent event_OnLoaded;
		private ReflectiveEvent event_OnFocusChange;
		private ReflectiveField<Action> field_OnLoaded;
		private ReflectiveField<Action> field_OnFocusChange;
		private ReflectiveField<VisualElement> field_root;
		private ReflectiveField field_Groups;
		private ReflectiveField field_Selection;
		private ReflectiveField field_searchFilter;
		private ReflectiveProperty property_SelectedItem;
		private ReflectiveProperty property_Cache;
		private ReflectiveProperty<ScrollView> property_List;
		private ReflectiveProperty<VisualElement> property_Empty;
		private ReflectiveProperty<VisualElement> property_NoResult;
		private ReflectiveProperty<Label> property_NoResultText;
		private ReflectiveMethod method_GrabFocus_1;
		private ReflectiveMethod method_ShowResults_1;
		private ReflectiveMethod method_ShowNoResults_1;
		private ReflectiveMethod method_SetSearchFilter_1;
		private ReflectiveMethod method_SetSelection_1;
		private ReflectiveMethod method_UpdateGroups_1;
		private ReflectiveMethod method_OnEnterPanel_1;
		private ReflectiveMethod method_OnLeavePanel_1;
		private ReflectiveMethod method_ScrollIfNeededDelayed_1;
		private ReflectiveMethod method_ScrollIfNeeded_1;
		private ReflectiveMethod method_SetSelectedExpand_1;
		private ReflectiveMethod method_OnKeyDownShortcut_1;
		private ReflectiveMethod method_OnLatestPackageInfoFetched_1;
		private ReflectiveMethod method_GetSelectionList_1;
		private ReflectiveMethod method_EnsureSelectionIsVisible_1;
		private ReflectiveMethod method_SelectBy_1;
		private ReflectiveMethod method_GetSelectedElement_1;
		private ReflectiveMethod method_ClearAll_1;
		private ReflectiveMethod method_SetPackages_1;
		private ReflectiveMethod method_AddPackage_1;
		private ReflectiveMethod method_GetOrCreateGroup_1;
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
			event_OnLoaded = CreateEvent("OnLoaded", BindingFlags.Instance | BindingFlags.Public);
			event_OnFocusChange = CreateEvent("OnFocusChange", BindingFlags.Instance | BindingFlags.Public);
			field_OnLoaded = CreateField<Action>("OnLoaded", BindingFlags.Instance | BindingFlags.NonPublic);
			field_OnFocusChange = CreateField<Action>("OnFocusChange", BindingFlags.Instance | BindingFlags.NonPublic);
			field_root = CreateField<VisualElement>("root", BindingFlags.Instance | BindingFlags.NonPublic);
			field_Groups = CreateField("Groups", BindingFlags.Instance | BindingFlags.NonPublic);
			field_Selection = CreateField("Selection", BindingFlags.Instance | BindingFlags.NonPublic);
			field_searchFilter = CreateField("searchFilter", BindingFlags.Instance | BindingFlags.NonPublic);
			property_SelectedItem = CreateProperty("SelectedItem", BindingFlags.Instance | BindingFlags.Public);
			property_Cache = CreateProperty("Cache", BindingFlags.Instance | BindingFlags.NonPublic);
			property_List = CreateProperty<ScrollView>("List", BindingFlags.Instance | BindingFlags.NonPublic);
			property_Empty = CreateProperty<VisualElement>("Empty", BindingFlags.Instance | BindingFlags.NonPublic);
			property_NoResult = CreateProperty<VisualElement>("NoResult", BindingFlags.Instance | BindingFlags.NonPublic);
			property_NoResultText = CreateProperty<Label>("NoResultText", BindingFlags.Instance | BindingFlags.NonPublic);
			method_GrabFocus_1 = CreateMethod("GrabFocus", BindingFlags.Instance | BindingFlags.Public, null);
			method_ShowResults_1 = CreateMethod("ShowResults", BindingFlags.Instance | BindingFlags.Public, typeof(PackageItem));
			method_ShowNoResults_1 = CreateMethod("ShowNoResults", BindingFlags.Instance | BindingFlags.Public, null);
			method_SetSearchFilter_1 = CreateMethod("SetSearchFilter", BindingFlags.Instance | BindingFlags.Public, typeof(PackageSearchFilter));
			method_SetSelection_1 = CreateMethod("SetSelection", BindingFlags.Instance | BindingFlags.Public, typeof(Selection));
			method_UpdateGroups_1 = CreateMethod("UpdateGroups", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_OnEnterPanel_1 = CreateMethod("OnEnterPanel", BindingFlags.Instance | BindingFlags.NonPublic, typeof(AttachToPanelEvent));
			method_OnLeavePanel_1 = CreateMethod("OnLeavePanel", BindingFlags.Instance | BindingFlags.NonPublic, typeof(DetachFromPanelEvent));
			method_ScrollIfNeededDelayed_1 = CreateMethod("ScrollIfNeededDelayed", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_ScrollIfNeeded_1 = CreateMethod("ScrollIfNeeded", BindingFlags.Instance | BindingFlags.NonPublic, typeof(VisualElement));
			method_SetSelectedExpand_1 = CreateMethod("SetSelectedExpand", BindingFlags.Instance | BindingFlags.NonPublic, typeof(bool));
			method_OnKeyDownShortcut_1 = CreateMethod("OnKeyDownShortcut", BindingFlags.Instance | BindingFlags.NonPublic, typeof(KeyDownEvent));
			method_OnLatestPackageInfoFetched_1 = CreateMethod("OnLatestPackageInfoFetched", BindingFlags.Instance | BindingFlags.NonPublic, typeof(PackageInfo),typeof(bool));
			method_GetSelectionList_1 = CreateMethod("GetSelectionList", BindingFlags.Instance | BindingFlags.Public, null);
			method_EnsureSelectionIsVisible_1 = CreateMethod("EnsureSelectionIsVisible", BindingFlags.Instance | BindingFlags.Public, null);
			method_SelectBy_1 = CreateMethod("SelectBy", BindingFlags.Instance | BindingFlags.NonPublic, typeof(int));
			method_GetSelectedElement_1 = CreateMethod("GetSelectedElement", BindingFlags.Instance | BindingFlags.NonPublic, typeof(List<IPackageSelection>));
			method_ClearAll_1 = CreateMethod("ClearAll", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_SetPackages_1 = CreateMethod("SetPackages", BindingFlags.Instance | BindingFlags.Public, typeof(PackageFilter),typeof(IEnumerable<Package>));
			method_AddPackage_1 = CreateMethod("AddPackage", BindingFlags.Instance | BindingFlags.NonPublic, typeof(Package));
			method_GetOrCreateGroup_1 = CreateMethod("GetOrCreateGroup", BindingFlags.Instance | BindingFlags.NonPublic, typeof(string));
		}
		partial void Initialize();
		/// <summary>
		/// Event type: System.Action
		/// </summary>
		/// <returns>Delegate to be used for unsubscribing</returns>
		public Delegate SubscribeToOnLoaded(Delegate @delegate)
		{
			return event_OnLoaded.Subscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action
		/// </summary>
		public void UnsubscribeFromOnLoaded(Delegate @delegate)
		{
			event_OnLoaded.Unsubscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action
		/// </summary>
		/// <returns>Delegate to be used for unsubscribing</returns>
		public Delegate SubscribeToOnFocusChange(Delegate @delegate)
		{
			return event_OnFocusChange.Subscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action
		/// </summary>
		public void UnsubscribeFromOnFocusChange(Delegate @delegate)
		{
			event_OnFocusChange.Unsubscribe(@delegate);
		}
		public Action OnLoaded
		{
			get => field_OnLoaded.GetValue();
			set => field_OnLoaded.SetValue(value);
		}
		public Action OnFocusChange
		{
			get => field_OnFocusChange.GetValue();
			set => field_OnFocusChange.SetValue(value);
		}
		public VisualElement root
		{
			get => field_root.GetValue();
			set => field_root.SetValue(value);
		}
		public List<PackageGroup> Groups
		{
			get
			{
				object _temp = field_Groups.GetValue();
				return (List<PackageGroup>) (_temp == null ? null : Utilities.GenerateEnumerable<PackageGroup>(_temp));
			}
		}
		public Selection Selection
		{
			get
			{
				object _temp = field_Selection.GetValue();
				return _temp == null ? null : new Selection(_temp);
			}
			set => field_Selection.SetValue(value.Instance);
		}
		public PackageSearchFilter searchFilter
		{
			get
			{
				object _temp = field_searchFilter.GetValue();
				return _temp == null ? null : new PackageSearchFilter(_temp);
			}
			set => field_searchFilter.SetValue(value.Instance);
		}
		public PackageItem SelectedItem
		{
			get
			{
				object _temp = property_SelectedItem.GetValue();
				return _temp == null ? null : new PackageItem(_temp);
			}
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
		public ScrollView List
		{
			get => property_List.GetValue();
		}
		public VisualElement Empty
		{
			get => property_Empty.GetValue();
		}
		public VisualElement NoResult
		{
			get => property_NoResult.GetValue();
		}
		public Label NoResultText
		{
			get => property_NoResultText.GetValue();
		}
		public void GrabFocus()
		{
			method_GrabFocus_1.Invoke();
		}
		public void ShowResults(PackageItem item)
		{
			method_ShowResults_1.Invoke(item);
		}
		public void ShowNoResults()
		{
			method_ShowNoResults_1.Invoke();
		}
		public void SetSearchFilter(PackageSearchFilter filter)
		{
			method_SetSearchFilter_1.Invoke(filter);
		}
		public void SetSelection(Selection selection)
		{
			method_SetSelection_1.Invoke(selection);
		}
		public void UpdateGroups()
		{
			method_UpdateGroups_1.Invoke();
		}
		public void OnEnterPanel(AttachToPanelEvent e)
		{
			method_OnEnterPanel_1.Invoke(e);
		}
		public void OnLeavePanel(DetachFromPanelEvent e)
		{
			method_OnLeavePanel_1.Invoke(e);
		}
		public void ScrollIfNeededDelayed()
		{
			method_ScrollIfNeededDelayed_1.Invoke();
		}
		public void ScrollIfNeeded(VisualElement target)
		{
			method_ScrollIfNeeded_1.Invoke(target);
		}
		public void SetSelectedExpand(bool value)
		{
			method_SetSelectedExpand_1.Invoke(value);
		}
		public void OnKeyDownShortcut(KeyDownEvent evt)
		{
			method_OnKeyDownShortcut_1.Invoke(evt);
		}
		public void OnLatestPackageInfoFetched(PackageInfo fetched,bool isDefaultVersion)
		{
			method_OnLatestPackageInfoFetched_1.Invoke(fetched,isDefaultVersion);
		}
		public List<IPackageSelection> GetSelectionList()
		{
			return (List<IPackageSelection>) Utilities.GenerateEnumerable<IPackageSelection>(method_GetSelectionList_1.Invoke());
		}
		public void EnsureSelectionIsVisible()
		{
			method_EnsureSelectionIsVisible_1.Invoke();
		}
		public bool SelectBy(int delta)
		{
			return (bool) method_SelectBy_1.Invoke(delta);
		}
		public IPackageSelection GetSelectedElement(List<IPackageSelection> list)
		{
			return new IPackageSelection(method_GetSelectedElement_1.Invoke(list));
		}
		public void ClearAll()
		{
			method_ClearAll_1.Invoke();
		}
		public void SetPackages(PackageFilter filter,IEnumerable<Package> packages)
		{
			method_SetPackages_1.Invoke((int)filter,packages);
		}
		public void AddPackage(Package package)
		{
			method_AddPackage_1.Invoke(package);
		}
		public PackageGroup GetOrCreateGroup(string groupName)
		{
			return new PackageGroup(method_GetOrCreateGroup_1.Invoke(groupName));
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageList, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
