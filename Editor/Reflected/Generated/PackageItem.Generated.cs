// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageItem, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
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
	public sealed partial class PackageItem : ReflectiveClass
	{
		private ReflectiveField<int> field_ListItemSpacing;
		private ReflectiveField<int> field_ListItemMaxHeight;
		private ReflectiveField field_Selection;
		private ReflectiveField<VisualElement> field_root;
		private ReflectiveField<string> field_currentStateClass;
		private ReflectiveProperty property_package;
		private ReflectiveProperty property_Versions;
		private ReflectiveProperty property_SelectionManager;
		private ReflectiveProperty property_AdditionalVersions;
		private ReflectiveProperty<bool> property_IsExpanded;
		private ReflectiveProperty property_TargetVersion;
		private ReflectiveProperty<VisualElement> property_Element;
		private ReflectiveProperty property_Cache;
		private ReflectiveProperty<Label> property_NameLabel;
		private ReflectiveProperty<Label> property_StateLabel;
		private ReflectiveProperty<Label> property_VersionLabel;
		private ReflectiveProperty<Label> property_SeeAllVersions;
		private ReflectiveProperty<Label> property_NoVersions;
		private ReflectiveProperty<VisualElement> property_VersionToolbar;
		private ReflectiveProperty<VisualElement> property_PackageContainer;
		private ReflectiveProperty<VisualElement> property_ItemLabel;
		private ReflectiveProperty property_Spinner;
		private ReflectiveProperty<VisualElement> property_SpinnerContainer;
		private ReflectiveProperty property_Expander;
		private ReflectiveProperty<Label> property_ExpanderHidden;
		private ReflectiveProperty<VisualElement> property_ItemVersions;
		private ReflectiveProperty<ScrollView> property_VersionList;
		private ReflectiveMethod method_SelectMainItem_1;
		private ReflectiveMethod method_SetExpandInternal_1;
		private ReflectiveMethod method_SetExpand_1;
		private ReflectiveMethod method_ExpandToggle_1;
		private ReflectiveMethod method_SetSelected_1;
		private ReflectiveMethod method_SetItem_1;
		private ReflectiveMethod method_SetDisplayName_1;
		private ReflectiveMethod method_OnPackageChanged_1;
		private ReflectiveMethod method_RefreshVersions_1;
		private ReflectiveMethod method_IsKeyVersion_1;
		private ReflectiveMethod method_RefreshSelection_1;
		private ReflectiveMethod method_SeeAllVersionsClick_1;
		private ReflectiveMethod method_SetSeeAllVersions_1;
		private ReflectiveMethod method_OnPackageUpdate_1;
		private ReflectiveMethod method_StartSpinner_1;
		private ReflectiveMethod method_StopSpinner_1;
		private ReflectiveMethod method_GetSelectionList_1;
		private ReflectiveMethod method_GetIconStateId_1;
		private ReflectiveMethod method_GetIconStateId_2;
		public PackageItem(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageItem(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_ListItemSpacing = CreateField<int>("ListItemSpacing", BindingFlags.Static | BindingFlags.Public);
			field_ListItemMaxHeight = CreateField<int>("ListItemMaxHeight", BindingFlags.Static | BindingFlags.Public);
			field_Selection = CreateField("Selection", BindingFlags.Instance | BindingFlags.NonPublic);
			field_root = CreateField<VisualElement>("root", BindingFlags.Instance | BindingFlags.NonPublic);
			field_currentStateClass = CreateField<string>("currentStateClass", BindingFlags.Instance | BindingFlags.NonPublic);
			property_package = CreateProperty("package", BindingFlags.Instance | BindingFlags.Public);
			property_Versions = CreateProperty("Versions", BindingFlags.Instance | BindingFlags.NonPublic);
			property_SelectionManager = CreateProperty("SelectionManager", BindingFlags.Instance | BindingFlags.NonPublic);
			property_AdditionalVersions = CreateProperty("AdditionalVersions", BindingFlags.Instance | BindingFlags.NonPublic);
			property_IsExpanded = CreateProperty<bool>("IsExpanded", BindingFlags.Instance | BindingFlags.NonPublic);
			property_TargetVersion = CreateProperty("TargetVersion", BindingFlags.Instance | BindingFlags.Public);
			property_Element = CreateProperty<VisualElement>("Element", BindingFlags.Instance | BindingFlags.Public);
			property_Cache = CreateProperty("Cache", BindingFlags.Instance | BindingFlags.NonPublic);
			property_NameLabel = CreateProperty<Label>("NameLabel", BindingFlags.Instance | BindingFlags.Public);
			property_StateLabel = CreateProperty<Label>("StateLabel", BindingFlags.Instance | BindingFlags.NonPublic);
			property_VersionLabel = CreateProperty<Label>("VersionLabel", BindingFlags.Instance | BindingFlags.NonPublic);
			property_SeeAllVersions = CreateProperty<Label>("SeeAllVersions", BindingFlags.Instance | BindingFlags.NonPublic);
			property_NoVersions = CreateProperty<Label>("NoVersions", BindingFlags.Instance | BindingFlags.NonPublic);
			property_VersionToolbar = CreateProperty<VisualElement>("VersionToolbar", BindingFlags.Instance | BindingFlags.NonPublic);
			property_PackageContainer = CreateProperty<VisualElement>("PackageContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_ItemLabel = CreateProperty<VisualElement>("ItemLabel", BindingFlags.Instance | BindingFlags.NonPublic);
			property_Spinner = CreateProperty("Spinner", BindingFlags.Instance | BindingFlags.NonPublic);
			property_SpinnerContainer = CreateProperty<VisualElement>("SpinnerContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_Expander = CreateProperty("Expander", BindingFlags.Instance | BindingFlags.NonPublic);
			property_ExpanderHidden = CreateProperty<Label>("ExpanderHidden", BindingFlags.Instance | BindingFlags.NonPublic);
			property_ItemVersions = CreateProperty<VisualElement>("ItemVersions", BindingFlags.Instance | BindingFlags.NonPublic);
			property_VersionList = CreateProperty<ScrollView>("VersionList", BindingFlags.Instance | BindingFlags.NonPublic);
			method_SelectMainItem_1 = CreateMethod("SelectMainItem", BindingFlags.Instance | BindingFlags.Public, null);
			method_SetExpandInternal_1 = CreateMethod("SetExpandInternal", BindingFlags.Instance | BindingFlags.NonPublic, typeof(bool));
			method_SetExpand_1 = CreateMethod("SetExpand", BindingFlags.Instance | BindingFlags.Public, typeof(bool));
			method_ExpandToggle_1 = CreateMethod("ExpandToggle", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_SetSelected_1 = CreateMethod("SetSelected", BindingFlags.Instance | BindingFlags.NonPublic, typeof(bool));
			method_SetItem_1 = CreateMethod("SetItem", BindingFlags.Instance | BindingFlags.NonPublic, typeof(Package));
			method_SetDisplayName_1 = CreateMethod("SetDisplayName", BindingFlags.Instance | BindingFlags.NonPublic, typeof(string));
			method_OnPackageChanged_1 = CreateMethod("OnPackageChanged", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_RefreshVersions_1 = CreateMethod("RefreshVersions", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_IsKeyVersion_1 = CreateMethod("IsKeyVersion", BindingFlags.Instance | BindingFlags.NonPublic, typeof(PackageInfo));
			method_RefreshSelection_1 = CreateMethod("RefreshSelection", BindingFlags.Instance | BindingFlags.Public, null);
			method_SeeAllVersionsClick_1 = CreateMethod("SeeAllVersionsClick", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_SetSeeAllVersions_1 = CreateMethod("SetSeeAllVersions", BindingFlags.Instance | BindingFlags.NonPublic, typeof(bool));
			method_OnPackageUpdate_1 = CreateMethod("OnPackageUpdate", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_StartSpinner_1 = CreateMethod("StartSpinner", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_StopSpinner_1 = CreateMethod("StopSpinner", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_GetSelectionList_1 = CreateMethod("GetSelectionList", BindingFlags.Instance | BindingFlags.Public, null);
			method_GetIconStateId_1 = CreateMethod("GetIconStateId", BindingFlags.Static | BindingFlags.Public, typeof(PackageInfo));
			method_GetIconStateId_2 = CreateMethod("GetIconStateId", BindingFlags.Static | BindingFlags.Public, typeof(PackageState));
		}
		partial void Initialize();
		public int ListItemSpacing
		{
			get => field_ListItemSpacing.GetValue();
			set => field_ListItemSpacing.SetValue(value);
		}
		public int ListItemMaxHeight
		{
			get => field_ListItemMaxHeight.GetValue();
			set => field_ListItemMaxHeight.SetValue(value);
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
		public VisualElement root
		{
			get => field_root.GetValue();
			set => field_root.SetValue(value);
		}
		public string currentStateClass
		{
			get => field_currentStateClass.GetValue();
			set => field_currentStateClass.SetValue(value);
		}
		public Package package
		{
			get
			{
				object _temp = property_package.GetValue();
				return _temp == null ? null : new Package(_temp);
			}
			set => property_package.SetValue(value.Instance);
		}
		public IEnumerable<PackageVersionLabel> Versions
		{
			get
			{
				object _temp = property_Versions.GetValue();
				return _temp == null ? null : Utilities.GenerateEnumerable<PackageVersionLabel>(_temp);
			}
		}
		public ElementSelection SelectionManager
		{
			get
			{
				object _temp = property_SelectionManager.GetValue();
				return _temp == null ? null : new ElementSelection(_temp);
			}
			set => property_SelectionManager.SetValue(value.Instance);
		}
		public IEnumerable<PackageInfo> AdditionalVersions
		{
			get
			{
				object _temp = property_AdditionalVersions.GetValue();
				return _temp == null ? null : Utilities.GenerateEnumerable<PackageInfo>(_temp);
			}
		}
		public bool IsExpanded
		{
			get => property_IsExpanded.GetValue();
		}
		public PackageInfo TargetVersion
		{
			get
			{
				object _temp = property_TargetVersion.GetValue();
				return _temp == null ? null : new PackageInfo(_temp);
			}
		}
		public VisualElement Element
		{
			get => property_Element.GetValue();
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
		public Label NameLabel
		{
			get => property_NameLabel.GetValue();
		}
		public Label StateLabel
		{
			get => property_StateLabel.GetValue();
		}
		public Label VersionLabel
		{
			get => property_VersionLabel.GetValue();
		}
		public Label SeeAllVersions
		{
			get => property_SeeAllVersions.GetValue();
		}
		public Label NoVersions
		{
			get => property_NoVersions.GetValue();
		}
		public VisualElement VersionToolbar
		{
			get => property_VersionToolbar.GetValue();
		}
		public VisualElement PackageContainer
		{
			get => property_PackageContainer.GetValue();
		}
		public VisualElement ItemLabel
		{
			get => property_ItemLabel.GetValue();
		}
		public LoadingSpinner Spinner
		{
			get
			{
				object _temp = property_Spinner.GetValue();
				return _temp == null ? null : new LoadingSpinner(_temp);
			}
		}
		public VisualElement SpinnerContainer
		{
			get => property_SpinnerContainer.GetValue();
		}
		public ArrowToggle Expander
		{
			get
			{
				object _temp = property_Expander.GetValue();
				return _temp == null ? null : new ArrowToggle(_temp);
			}
		}
		public Label ExpanderHidden
		{
			get => property_ExpanderHidden.GetValue();
		}
		public VisualElement ItemVersions
		{
			get => property_ItemVersions.GetValue();
		}
		public ScrollView VersionList
		{
			get => property_VersionList.GetValue();
		}
		public void SelectMainItem()
		{
			method_SelectMainItem_1.Invoke();
		}
		public void SetExpandInternal(bool value)
		{
			method_SetExpandInternal_1.Invoke(value);
		}
		public void SetExpand(bool value)
		{
			method_SetExpand_1.Invoke(value);
		}
		public void ExpandToggle()
		{
			method_ExpandToggle_1.Invoke();
		}
		public void SetSelected(bool value)
		{
			method_SetSelected_1.Invoke(value);
		}
		public void SetItem(Package package)
		{
			method_SetItem_1.Invoke(package);
		}
		public void SetDisplayName(string displayName)
		{
			method_SetDisplayName_1.Invoke(displayName);
		}
		public void OnPackageChanged()
		{
			method_OnPackageChanged_1.Invoke();
		}
		public void RefreshVersions()
		{
			method_RefreshVersions_1.Invoke();
		}
		public bool IsKeyVersion(PackageInfo packageInfo)
		{
			return (bool) method_IsKeyVersion_1.Invoke(packageInfo);
		}
		public void RefreshSelection()
		{
			method_RefreshSelection_1.Invoke();
		}
		public void SeeAllVersionsClick()
		{
			method_SeeAllVersionsClick_1.Invoke();
		}
		public void SetSeeAllVersions(bool value)
		{
			method_SetSeeAllVersions_1.Invoke(value);
		}
		public void OnPackageUpdate()
		{
			method_OnPackageUpdate_1.Invoke();
		}
		public void StartSpinner()
		{
			method_StartSpinner_1.Invoke();
		}
		public void StopSpinner()
		{
			method_StopSpinner_1.Invoke();
		}
		public IEnumerable<IPackageSelection> GetSelectionList()
		{
			return Utilities.GenerateEnumerable<IPackageSelection>(method_GetSelectionList_1.Invoke());
		}
		public string GetIconStateId(PackageInfo packageInfo)
		{
			return (string) method_GetIconStateId_1.Invoke(packageInfo);
		}
		public string GetIconStateId(PackageState state)
		{
			return (string) method_GetIconStateId_2.Invoke((int)state);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageItem, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
