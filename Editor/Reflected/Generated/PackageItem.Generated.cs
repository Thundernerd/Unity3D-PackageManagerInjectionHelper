// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageItem, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.Experimental.GraphView;
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
		private ReflectiveField<string> field_mCurrentStateClass;
		private ReflectiveField<bool> field_mFetchingDetail;
		private ReflectiveProperty property_package;
		private ReflectiveProperty property_visualState;
		private ReflectiveProperty property_targetVersion;
		private ReflectiveProperty<VisualElement> property_element;
		private ReflectiveProperty property_packageGroup;
		private ReflectiveProperty property_selectedVersion;
		private ReflectiveProperty property_versionItems;
		private ReflectiveProperty property_cache;
		private ReflectiveProperty<Label> property_nameLabel;
		private ReflectiveProperty<Label> property_stateLabel;
		private ReflectiveProperty<Label> property_versionLabel;
		private ReflectiveProperty<Label> property_seeAllVersionsLabel;
		private ReflectiveProperty<VisualElement> property_versionToolbar;
		private ReflectiveProperty<VisualElement> property_itemLabel;
		private ReflectiveProperty property_spinner;
		private ReflectiveProperty property_expander;
		private ReflectiveProperty<Label> property_expanderHidden;
		private ReflectiveProperty<VisualElement> property_versionsContainer;
		private ReflectiveProperty<ScrollView> property_versionList;
		private ReflectiveMethod method_BecomesVisible_1;
		private ReflectiveMethod method_UpdateVisualState_1;
		private ReflectiveMethod method_SetPackage_1;
		private ReflectiveMethod method_UpdateStatusIcon_1;
		private ReflectiveMethod method_RefreshVersions_1;
		private ReflectiveMethod method_FixVersionListStyle_1;
		private ReflectiveMethod method_RefreshSelection_1;
		private ReflectiveMethod method_SelectMainItem_1;
		private ReflectiveMethod method_ToggleExpansion_1;
		private ReflectiveMethod method_SetExpanded_1;
		private ReflectiveMethod method_UpdateExpanderUI_1;
		private ReflectiveMethod method_SeeAllVersionsClick_1;
		private ReflectiveMethod method_StartSpinner_1;
		private ReflectiveMethod method_StopSpinner_1;
		private ReflectiveMethod method_GetSelectableItems_1;
		private ReflectiveMethod method_GetVersionText_1;

		public PackageItem(object instance) : base(instance)
		{
			field_mCurrentStateClass = CreateField<string>("mCurrentStateClass", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mFetchingDetail = CreateField<bool>("mFetchingDetail", BindingFlags.Instance | BindingFlags.NonPublic);
			property_package = CreateProperty("package", BindingFlags.Instance | BindingFlags.Public);
			property_visualState = CreateProperty("visualState", BindingFlags.Instance | BindingFlags.Public);
			property_targetVersion = CreateProperty("targetVersion", BindingFlags.Instance | BindingFlags.Public);
			property_element = CreateProperty<VisualElement>("element", BindingFlags.Instance | BindingFlags.Public);
			property_packageGroup = CreateProperty("packageGroup", BindingFlags.Instance | BindingFlags.NonPublic);
			property_selectedVersion = CreateProperty("selectedVersion", BindingFlags.Instance | BindingFlags.NonPublic);
			property_versionItems = CreateProperty("versionItems", BindingFlags.Instance | BindingFlags.NonPublic);
			property_cache = CreateProperty("cache", BindingFlags.Instance | BindingFlags.NonPublic);
			property_nameLabel = CreateProperty<Label>("nameLabel", BindingFlags.Instance | BindingFlags.NonPublic);
			property_stateLabel = CreateProperty<Label>("stateLabel", BindingFlags.Instance | BindingFlags.NonPublic);
			property_versionLabel = CreateProperty<Label>("versionLabel", BindingFlags.Instance | BindingFlags.NonPublic);
			property_seeAllVersionsLabel = CreateProperty<Label>("seeAllVersionsLabel", BindingFlags.Instance | BindingFlags.NonPublic);
			property_versionToolbar = CreateProperty<VisualElement>("versionToolbar", BindingFlags.Instance | BindingFlags.NonPublic);
			property_itemLabel = CreateProperty<VisualElement>("itemLabel", BindingFlags.Instance | BindingFlags.NonPublic);
			property_spinner = CreateProperty("spinner", BindingFlags.Instance | BindingFlags.NonPublic);
			property_expander = CreateProperty("expander", BindingFlags.Instance | BindingFlags.NonPublic);
			property_expanderHidden = CreateProperty<Label>("expanderHidden", BindingFlags.Instance | BindingFlags.NonPublic);
			property_versionsContainer = CreateProperty<VisualElement>("versionsContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_versionList = CreateProperty<ScrollView>("versionList", BindingFlags.Instance | BindingFlags.NonPublic);
			method_BecomesVisible_1 = CreateMethod("BecomesVisible", BindingFlags.Instance | BindingFlags.Public, null);
			method_UpdateVisualState_1 = CreateMethod("UpdateVisualState", BindingFlags.Instance | BindingFlags.Public, typeof(VisualState));
			method_SetPackage_1 = CreateMethod("SetPackage", BindingFlags.Instance | BindingFlags.NonPublic, typeof(IPackage));
			method_UpdateStatusIcon_1 = CreateMethod("UpdateStatusIcon", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_RefreshVersions_1 = CreateMethod("RefreshVersions", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_FixVersionListStyle_1 = CreateMethod("FixVersionListStyle", BindingFlags.Instance | BindingFlags.NonPublic, typeof(List<IPackageVersion>));
			method_RefreshSelection_1 = CreateMethod("RefreshSelection", BindingFlags.Instance | BindingFlags.Public, null);
			method_SelectMainItem_1 = CreateMethod("SelectMainItem", BindingFlags.Instance | BindingFlags.Public, null);
			method_ToggleExpansion_1 = CreateMethod("ToggleExpansion", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_SetExpanded_1 = CreateMethod("SetExpanded", BindingFlags.Instance | BindingFlags.NonPublic, typeof(bool));
			method_UpdateExpanderUI_1 = CreateMethod("UpdateExpanderUI", BindingFlags.Instance | BindingFlags.NonPublic, typeof(bool));
			method_SeeAllVersionsClick_1 = CreateMethod("SeeAllVersionsClick", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_StartSpinner_1 = CreateMethod("StartSpinner", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_StopSpinner_1 = CreateMethod("StopSpinner", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_GetSelectableItems_1 = CreateMethod("GetSelectableItems", BindingFlags.Instance | BindingFlags.Public, null);
			method_GetVersionText_1 = CreateMethod("GetVersionText", BindingFlags.Static | BindingFlags.Public, typeof(IPackageVersion),typeof(bool));
		}

		public string mCurrentStateClass
		{
			get => field_mCurrentStateClass.GetValue();
			set => field_mCurrentStateClass.SetValue(value);
		}
		public bool mFetchingDetail
		{
			get => field_mFetchingDetail.GetValue();
			set => field_mFetchingDetail.SetValue(value);
		}
		public IPackage package
		{
			get => new IPackage(property_package.GetValue());
			set => property_package.SetValue(value.Instance);
		}
		public VisualState visualState
		{
			get => new VisualState(property_visualState.GetValue());
			set => property_visualState.SetValue(value.Instance);
		}
		public IPackageVersion targetVersion
		{
			get => new IPackageVersion(property_targetVersion.GetValue());
		}
		public VisualElement element
		{
			get => property_element.GetValue();
		}
		public PackageGroup packageGroup
		{
			get => new PackageGroup(property_packageGroup.GetValue());
			set => property_packageGroup.SetValue(value.Instance);
		}
		public IPackageVersion selectedVersion
		{
			get => new IPackageVersion(property_selectedVersion.GetValue());
		}
		public IEnumerable<PackageVersionItem> versionItems
		{
			get => ReflectiveUtilities.GenerateEnumerable<PackageVersionItem>(property_versionItems);
		}
		public VisualElementCache cache
		{
			get => new VisualElementCache(property_cache.GetValue());
			set => property_cache.SetValue(value.Instance);
		}
		public Label nameLabel
		{
			get => property_nameLabel.GetValue();
		}
		public Label stateLabel
		{
			get => property_stateLabel.GetValue();
		}
		public Label versionLabel
		{
			get => property_versionLabel.GetValue();
		}
		public Label seeAllVersionsLabel
		{
			get => property_seeAllVersionsLabel.GetValue();
		}
		public VisualElement versionToolbar
		{
			get => property_versionToolbar.GetValue();
		}
		public VisualElement itemLabel
		{
			get => property_itemLabel.GetValue();
		}
		public LoadingSpinner spinner
		{
			get => new LoadingSpinner(property_spinner.GetValue());
		}
		public ArrowToggle expander
		{
			get => new ArrowToggle(property_expander.GetValue());
		}
		public Label expanderHidden
		{
			get => property_expanderHidden.GetValue();
		}
		public VisualElement versionsContainer
		{
			get => property_versionsContainer.GetValue();
		}
		public ScrollView versionList
		{
			get => property_versionList.GetValue();
		}
		public void BecomesVisible()
		{
			method_BecomesVisible_1.Invoke();
		}
		public void UpdateVisualState(VisualState newVisualState)
		{
			method_UpdateVisualState_1.Invoke(newVisualState);
		}
		public void SetPackage(IPackage package)
		{
			method_SetPackage_1.Invoke(package);
		}
		public void UpdateStatusIcon()
		{
			method_UpdateStatusIcon_1.Invoke();
		}
		public void RefreshVersions()
		{
			method_RefreshVersions_1.Invoke();
		}
		public void FixVersionListStyle(List<IPackageVersion> versions)
		{
			method_FixVersionListStyle_1.Invoke(versions);
		}
		public void RefreshSelection()
		{
			method_RefreshSelection_1.Invoke();
		}
		public void SelectMainItem()
		{
			method_SelectMainItem_1.Invoke();
		}
		public void ToggleExpansion()
		{
			method_ToggleExpansion_1.Invoke();
		}
		public void SetExpanded(bool value)
		{
			method_SetExpanded_1.Invoke(value);
		}
		public void UpdateExpanderUI(bool expanded)
		{
			method_UpdateExpanderUI_1.Invoke(expanded);
		}
		public void SeeAllVersionsClick()
		{
			method_SeeAllVersionsClick_1.Invoke();
		}
		public void StartSpinner()
		{
			method_StartSpinner_1.Invoke();
		}
		public void StopSpinner()
		{
			method_StopSpinner_1.Invoke();
		}
		public IEnumerable<ISelectableItem> GetSelectableItems()
		{
			return ReflectiveUtilities.GenerateEnumerable<ISelectableItem>(method_GetSelectableItems_1.Invoke());
		}
		public String GetVersionText(IPackageVersion version,bool simplified)
		{
			return (String) method_GetVersionText_1.Invoke(version,simplified);
		}
	}
}
