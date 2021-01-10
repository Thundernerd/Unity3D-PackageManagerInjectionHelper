// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageDetails, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
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
	public sealed partial class PackageDetails : ReflectiveClass
	{
		private ReflectiveEvent event_OnCloseError;
		private ReflectiveEvent event_OnOperationError;
		private ReflectiveField field_OnCloseError;
		private ReflectiveField field_OnOperationError;
		private ReflectiveField<VisualElement> field_root;
		private ReflectiveField field_package;
		private ReflectiveField<string> field_emptyDescriptionClass;
		private ReflectiveField field_DisplayPackage;
		private ReflectiveField field_Selection;
		private ReflectiveField field_Collection;
		private ReflectiveField<string[]> field_PackageActionVerbs;
		private ReflectiveField<string[]> field_PackageActionInProgressVerbs;
		private ReflectiveField<int> field_MaxDependentList;
		private ReflectiveProperty property_TargetVersion;
		private ReflectiveProperty property_Cache;
		private ReflectiveProperty<Label> property_DetailDesc;
		private ReflectiveProperty<Button> property_UpdateButton;
		private ReflectiveProperty<Button> property_RemoveButton;
		private ReflectiveProperty<Button> property_ViewDocButton;
		private ReflectiveProperty<VisualElement> property_DocumentationContainer;
		private ReflectiveProperty<Button> property_ViewChangelogButton;
		private ReflectiveProperty<VisualElement> property_ChangelogContainer;
		private ReflectiveProperty<Button> property_ViewLicenses;
		private ReflectiveProperty<VisualElement> property_ViewLicensesContainer;
		private ReflectiveProperty property_DetailError;
		private ReflectiveProperty<ScrollView> property_DetailScrollView;
		private ReflectiveProperty<VisualElement> property_DetailContainer;
		private ReflectiveProperty<Label> property_DetailModuleReference;
		private ReflectiveProperty<Label> property_DetailVersion;
		private ReflectiveProperty<Label> property_DetailAuthor;
		private ReflectiveProperty<Label> property_VerifyLabel;
		private ReflectiveProperty<VisualElement> property_CustomContainer;
		private ReflectiveProperty property_SampleList;
		private ReflectiveProperty property_Dependencies;
		private ReflectiveProperty<VisualElement> property_PackageToolbarContainer;
		private ReflectiveProperty<Button> property_UpdateBuiltIn;
		private ReflectiveMethod method_SetContentVisibility_1;
		private ReflectiveMethod method_SetCollection_1;
		private ReflectiveMethod method_SetSelection_1;
		private ReflectiveMethod method_OnSelectionChanged_1;
		private ReflectiveMethod method_OnEnterPanel_1;
		private ReflectiveMethod method_OnLeavePanel_1;
		private ReflectiveMethod method_ShowDependencies_1;
		private ReflectiveMethod method_SetUpdateVisibility_1;
		private ReflectiveMethod method_SetDisplayPackage_1;
		private ReflectiveMethod method_SetPackage_1;
		private ReflectiveMethod method_OnLatestPackageInfoFetched_1;
		private ReflectiveMethod method_ShowDisplayPackage_1;
		private ReflectiveMethod method_SetError_1;
		private ReflectiveMethod method_OnAddOperation_1;
		private ReflectiveMethod method_OnAddOperationError_1;
		private ReflectiveMethod method_OnAddOperationSuccess_1;
		private ReflectiveMethod method_OnRemoveOperation_1;
		private ReflectiveMethod method_OnRemoveOperationError_1;
		private ReflectiveMethod method_OnRemoveOperationSuccess_1;
		private ReflectiveMethod method_RefreshAddButton_1;
		private ReflectiveMethod method_RefreshRemoveButton_1;
		private ReflectiveMethod method_CheckCompilationStatus_1;
		private ReflectiveMethod method_GetButtonText_1;
		private ReflectiveMethod method_UpdateClick_1;
		private ReflectiveMethod method_CloseAndUpdate_1;
		private ReflectiveMethod method_GetPackageDashList_1;
		private ReflectiveMethod method_GetDependentMessage_1;
		private ReflectiveMethod method_RemoveClick_1;
		private ReflectiveMethod method_ViewOfflineUrl_1;
		private ReflectiveMethod method_ViewUrl_1;
		private ReflectiveMethod method_ViewDocClick_1;
		private ReflectiveMethod method_ViewChangelogClick_1;
		private ReflectiveMethod method_ViewLicensesClick_1;
		private ReflectiveMethod method_GetTag_1;
		public PackageDetails(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageDetails(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			event_OnCloseError = CreateEvent("OnCloseError", BindingFlags.Instance | BindingFlags.Public);
			event_OnOperationError = CreateEvent("OnOperationError", BindingFlags.Instance | BindingFlags.Public);
			field_OnCloseError = CreateField("OnCloseError", BindingFlags.Instance | BindingFlags.NonPublic);
			field_OnOperationError = CreateField("OnOperationError", BindingFlags.Instance | BindingFlags.NonPublic);
			field_root = CreateField<VisualElement>("root", BindingFlags.Instance | BindingFlags.NonPublic);
			field_package = CreateField("package", BindingFlags.Instance | BindingFlags.NonPublic);
			field_emptyDescriptionClass = CreateField<string>("emptyDescriptionClass", BindingFlags.Static | BindingFlags.NonPublic);
			field_DisplayPackage = CreateField("DisplayPackage", BindingFlags.Instance | BindingFlags.NonPublic);
			field_Selection = CreateField("Selection", BindingFlags.Instance | BindingFlags.NonPublic);
			field_Collection = CreateField("Collection", BindingFlags.Instance | BindingFlags.NonPublic);
			field_PackageActionVerbs = CreateField<string[]>("PackageActionVerbs", BindingFlags.Static | BindingFlags.NonPublic);
			field_PackageActionInProgressVerbs = CreateField<string[]>("PackageActionInProgressVerbs", BindingFlags.Static | BindingFlags.NonPublic);
			field_MaxDependentList = CreateField<int>("MaxDependentList", BindingFlags.Static | BindingFlags.NonPublic);
			property_TargetVersion = CreateProperty("TargetVersion", BindingFlags.Instance | BindingFlags.NonPublic);
			property_Cache = CreateProperty("Cache", BindingFlags.Instance | BindingFlags.NonPublic);
			property_DetailDesc = CreateProperty<Label>("DetailDesc", BindingFlags.Instance | BindingFlags.NonPublic);
			property_UpdateButton = CreateProperty<Button>("UpdateButton", BindingFlags.Instance | BindingFlags.NonPublic);
			property_RemoveButton = CreateProperty<Button>("RemoveButton", BindingFlags.Instance | BindingFlags.NonPublic);
			property_ViewDocButton = CreateProperty<Button>("ViewDocButton", BindingFlags.Instance | BindingFlags.NonPublic);
			property_DocumentationContainer = CreateProperty<VisualElement>("DocumentationContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_ViewChangelogButton = CreateProperty<Button>("ViewChangelogButton", BindingFlags.Instance | BindingFlags.NonPublic);
			property_ChangelogContainer = CreateProperty<VisualElement>("ChangelogContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_ViewLicenses = CreateProperty<Button>("ViewLicenses", BindingFlags.Instance | BindingFlags.NonPublic);
			property_ViewLicensesContainer = CreateProperty<VisualElement>("ViewLicensesContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_DetailError = CreateProperty("DetailError", BindingFlags.Instance | BindingFlags.NonPublic);
			property_DetailScrollView = CreateProperty<ScrollView>("DetailScrollView", BindingFlags.Instance | BindingFlags.NonPublic);
			property_DetailContainer = CreateProperty<VisualElement>("DetailContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_DetailModuleReference = CreateProperty<Label>("DetailModuleReference", BindingFlags.Instance | BindingFlags.NonPublic);
			property_DetailVersion = CreateProperty<Label>("DetailVersion", BindingFlags.Instance | BindingFlags.NonPublic);
			property_DetailAuthor = CreateProperty<Label>("DetailAuthor", BindingFlags.Instance | BindingFlags.NonPublic);
			property_VerifyLabel = CreateProperty<Label>("VerifyLabel", BindingFlags.Instance | BindingFlags.NonPublic);
			property_CustomContainer = CreateProperty<VisualElement>("CustomContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_SampleList = CreateProperty("SampleList", BindingFlags.Instance | BindingFlags.NonPublic);
			property_Dependencies = CreateProperty("Dependencies", BindingFlags.Instance | BindingFlags.NonPublic);
			property_PackageToolbarContainer = CreateProperty<VisualElement>("PackageToolbarContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_UpdateBuiltIn = CreateProperty<Button>("UpdateBuiltIn", BindingFlags.Instance | BindingFlags.NonPublic);
			method_SetContentVisibility_1 = CreateMethod("SetContentVisibility", BindingFlags.Instance | BindingFlags.NonPublic, typeof(bool));
			method_SetCollection_1 = CreateMethod("SetCollection", BindingFlags.Instance | BindingFlags.Public, typeof(PackageCollection));
			method_SetSelection_1 = CreateMethod("SetSelection", BindingFlags.Instance | BindingFlags.Public, typeof(Selection));
			method_OnSelectionChanged_1 = CreateMethod("OnSelectionChanged", BindingFlags.Instance | BindingFlags.NonPublic, typeof(IEnumerable<PackageVersion>));
			method_OnEnterPanel_1 = CreateMethod("OnEnterPanel", BindingFlags.Instance | BindingFlags.NonPublic, typeof(AttachToPanelEvent));
			method_OnLeavePanel_1 = CreateMethod("OnLeavePanel", BindingFlags.Instance | BindingFlags.NonPublic, typeof(DetachFromPanelEvent));
			method_ShowDependencies_1 = CreateMethod("ShowDependencies", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_SetUpdateVisibility_1 = CreateMethod("SetUpdateVisibility", BindingFlags.Instance | BindingFlags.NonPublic, typeof(bool));
			method_SetDisplayPackage_1 = CreateMethod("SetDisplayPackage", BindingFlags.Instance | BindingFlags.NonPublic, typeof(PackageInfo),typeof(Error));
			method_SetPackage_1 = CreateMethod("SetPackage", BindingFlags.Instance | BindingFlags.Public, typeof(Package),typeof(PackageInfo));
			method_OnLatestPackageInfoFetched_1 = CreateMethod("OnLatestPackageInfoFetched", BindingFlags.Instance | BindingFlags.NonPublic, typeof(PackageInfo),typeof(bool));
			method_ShowDisplayPackage_1 = CreateMethod("ShowDisplayPackage", BindingFlags.Instance | BindingFlags.NonPublic, typeof(PackageInfo));
			method_SetError_1 = CreateMethod("SetError", BindingFlags.Instance | BindingFlags.NonPublic, typeof(Error));
			method_OnAddOperationError_1 = CreateMethod("OnAddOperationError", BindingFlags.Instance | BindingFlags.NonPublic, typeof(Error));
			method_OnAddOperationSuccess_1 = CreateMethod("OnAddOperationSuccess", BindingFlags.Instance | BindingFlags.NonPublic, typeof(PackageInfo));
			method_OnRemoveOperationError_1 = CreateMethod("OnRemoveOperationError", BindingFlags.Instance | BindingFlags.NonPublic, typeof(Error));
			method_OnRemoveOperationSuccess_1 = CreateMethod("OnRemoveOperationSuccess", BindingFlags.Instance | BindingFlags.NonPublic, typeof(PackageInfo));
			method_RefreshAddButton_1 = CreateMethod("RefreshAddButton", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_RefreshRemoveButton_1 = CreateMethod("RefreshRemoveButton", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_CheckCompilationStatus_1 = CreateMethod("CheckCompilationStatus", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_GetButtonText_1 = CreateMethod("GetButtonText", BindingFlags.Instance | BindingFlags.NonPublic, typeof(PackageAction),typeof(bool),typeof(SemVersion));
			method_UpdateClick_1 = CreateMethod("UpdateClick", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_CloseAndUpdate_1 = CreateMethod("CloseAndUpdate", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_GetPackageDashList_1 = CreateMethod("GetPackageDashList", BindingFlags.Instance | BindingFlags.NonPublic, typeof(IEnumerable<PackageInfo>),typeof(int));
			method_GetDependentMessage_1 = CreateMethod("GetDependentMessage", BindingFlags.Instance | BindingFlags.NonPublic, typeof(PackageInfo),typeof(IEnumerable<PackageInfo>),typeof(int));
			method_RemoveClick_1 = CreateMethod("RemoveClick", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_ViewOfflineUrl_1 = CreateMethod("ViewOfflineUrl", BindingFlags.Static | BindingFlags.NonPublic, typeof(PackageInfo),typeof(Func<bool, string>),typeof(string));
			method_ViewUrl_1 = CreateMethod("ViewUrl", BindingFlags.Static | BindingFlags.NonPublic, typeof(PackageInfo),typeof(Func<bool, string>),typeof(string));
			method_ViewDocClick_1 = CreateMethod("ViewDocClick", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_ViewChangelogClick_1 = CreateMethod("ViewChangelogClick", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_ViewLicensesClick_1 = CreateMethod("ViewLicensesClick", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_GetTag_1 = CreateMethod("GetTag", BindingFlags.Instance | BindingFlags.NonPublic, typeof(PackageTag));
		}
		partial void Initialize();
		/// <summary>
		/// Event type: System.Action<Package>
		/// </summary>
		/// <returns>Delegate to be used for unsubscribing</returns>
		public Delegate SubscribeToOnCloseError(Delegate @delegate)
		{
			return event_OnCloseError.Subscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<Package>
		/// </summary>
		public void UnsubscribeFromOnCloseError(Delegate @delegate)
		{
			event_OnCloseError.Unsubscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<Package, Error>
		/// </summary>
		/// <returns>Delegate to be used for unsubscribing</returns>
		public Delegate SubscribeToOnOperationError(Delegate @delegate)
		{
			return event_OnOperationError.Subscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<Package, Error>
		/// </summary>
		public void UnsubscribeFromOnOperationError(Delegate @delegate)
		{
			event_OnOperationError.Unsubscribe(@delegate);
		}
		public VisualElement root
		{
			get => field_root.GetValue();
			set => field_root.SetValue(value);
		}
		public Package package
		{
			get
			{
				object _temp = field_package.GetValue();
				return _temp == null ? null : new Package(_temp);
			}
			set => field_package.SetValue(value.Instance);
		}
		public string emptyDescriptionClass
		{
			get => field_emptyDescriptionClass.GetValue();
			set => field_emptyDescriptionClass.SetValue(value);
		}
		public PackageInfo DisplayPackage
		{
			get
			{
				object _temp = field_DisplayPackage.GetValue();
				return _temp == null ? null : new PackageInfo(_temp);
			}
			set => field_DisplayPackage.SetValue(value.Instance);
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
		public PackageCollection Collection
		{
			get
			{
				object _temp = field_Collection.GetValue();
				return _temp == null ? null : new PackageCollection(_temp);
			}
			set => field_Collection.SetValue(value.Instance);
		}
		public string[] PackageActionVerbs
		{
			get => field_PackageActionVerbs.GetValue();
			set => field_PackageActionVerbs.SetValue(value);
		}
		public string[] PackageActionInProgressVerbs
		{
			get => field_PackageActionInProgressVerbs.GetValue();
			set => field_PackageActionInProgressVerbs.SetValue(value);
		}
		public int MaxDependentList
		{
			get => field_MaxDependentList.GetValue();
			set => field_MaxDependentList.SetValue(value);
		}
		public PackageInfo TargetVersion
		{
			get
			{
				object _temp = property_TargetVersion.GetValue();
				return _temp == null ? null : new PackageInfo(_temp);
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
		public Label DetailDesc
		{
			get => property_DetailDesc.GetValue();
		}
		public Button UpdateButton
		{
			get => property_UpdateButton.GetValue();
		}
		public Button RemoveButton
		{
			get => property_RemoveButton.GetValue();
		}
		public Button ViewDocButton
		{
			get => property_ViewDocButton.GetValue();
		}
		public VisualElement DocumentationContainer
		{
			get => property_DocumentationContainer.GetValue();
		}
		public Button ViewChangelogButton
		{
			get => property_ViewChangelogButton.GetValue();
		}
		public VisualElement ChangelogContainer
		{
			get => property_ChangelogContainer.GetValue();
		}
		public Button ViewLicenses
		{
			get => property_ViewLicenses.GetValue();
		}
		public VisualElement ViewLicensesContainer
		{
			get => property_ViewLicensesContainer.GetValue();
		}
		public Alert DetailError
		{
			get
			{
				object _temp = property_DetailError.GetValue();
				return _temp == null ? null : new Alert(_temp);
			}
		}
		public ScrollView DetailScrollView
		{
			get => property_DetailScrollView.GetValue();
		}
		public VisualElement DetailContainer
		{
			get => property_DetailContainer.GetValue();
		}
		public Label DetailModuleReference
		{
			get => property_DetailModuleReference.GetValue();
		}
		public Label DetailVersion
		{
			get => property_DetailVersion.GetValue();
		}
		public Label DetailAuthor
		{
			get => property_DetailAuthor.GetValue();
		}
		public Label VerifyLabel
		{
			get => property_VerifyLabel.GetValue();
		}
		public VisualElement CustomContainer
		{
			get => property_CustomContainer.GetValue();
		}
		public PackageSampleList SampleList
		{
			get
			{
				object _temp = property_SampleList.GetValue();
				return _temp == null ? null : new PackageSampleList(_temp);
			}
		}
		public PackageDependencies Dependencies
		{
			get
			{
				object _temp = property_Dependencies.GetValue();
				return _temp == null ? null : new PackageDependencies(_temp);
			}
		}
		public VisualElement PackageToolbarContainer
		{
			get => property_PackageToolbarContainer.GetValue();
		}
		public Button UpdateBuiltIn
		{
			get => property_UpdateBuiltIn.GetValue();
		}
		public void SetContentVisibility(bool visible)
		{
			method_SetContentVisibility_1.Invoke(visible);
		}
		public void SetCollection(PackageCollection collection)
		{
			method_SetCollection_1.Invoke(collection);
		}
		public void SetSelection(Selection selection)
		{
			method_SetSelection_1.Invoke(selection);
		}
		public void OnSelectionChanged(IEnumerable<PackageVersion> selected)
		{
			method_OnSelectionChanged_1.Invoke(selected);
		}
		public void OnEnterPanel(AttachToPanelEvent e)
		{
			method_OnEnterPanel_1.Invoke(e);
		}
		public void OnLeavePanel(DetachFromPanelEvent e)
		{
			method_OnLeavePanel_1.Invoke(e);
		}
		public void ShowDependencies()
		{
			method_ShowDependencies_1.Invoke();
		}
		public void SetUpdateVisibility(bool value)
		{
			method_SetUpdateVisibility_1.Invoke(value);
		}
		public void SetDisplayPackage(PackageInfo packageInfo,Error packageError)
		{
			method_SetDisplayPackage_1.Invoke(packageInfo,packageError);
		}
		public void SetPackage(Package package,PackageInfo displayPackage)
		{
			method_SetPackage_1.Invoke(package,displayPackage);
		}
		public void OnLatestPackageInfoFetched(PackageInfo fetched,bool isDefaultVersion)
		{
			method_OnLatestPackageInfoFetched_1.Invoke(fetched,isDefaultVersion);
		}
		public void ShowDisplayPackage(PackageInfo displayPackage)
		{
			method_ShowDisplayPackage_1.Invoke(displayPackage);
		}
		public void SetError(Error error)
		{
			method_SetError_1.Invoke(error);
		}
		public void OnAddOperationError(Error error)
		{
			method_OnAddOperationError_1.Invoke(error);
		}
		public void OnAddOperationSuccess(PackageInfo packageInfo)
		{
			method_OnAddOperationSuccess_1.Invoke(packageInfo);
		}
		public void OnRemoveOperationError(Error error)
		{
			method_OnRemoveOperationError_1.Invoke(error);
		}
		public void OnRemoveOperationSuccess(PackageInfo packageInfo)
		{
			method_OnRemoveOperationSuccess_1.Invoke(packageInfo);
		}
		public void RefreshAddButton()
		{
			method_RefreshAddButton_1.Invoke();
		}
		public void RefreshRemoveButton()
		{
			method_RefreshRemoveButton_1.Invoke();
		}
		public void CheckCompilationStatus()
		{
			method_CheckCompilationStatus_1.Invoke();
		}
		public string GetButtonText(PackageAction action,bool inProgress,SemVersion version)
		{
			return (string) method_GetButtonText_1.Invoke((int)action,inProgress,version);
		}
		public void UpdateClick()
		{
			method_UpdateClick_1.Invoke();
		}
		public void CloseAndUpdate()
		{
			method_CloseAndUpdate_1.Invoke();
		}
		public string GetPackageDashList(IEnumerable<PackageInfo> packageInfos,int maxListCount)
		{
			return (string) method_GetPackageDashList_1.Invoke(packageInfos,maxListCount);
		}
		public string GetDependentMessage(PackageInfo packageInfo,IEnumerable<PackageInfo> roots,int maxListCount)
		{
			return (string) method_GetDependentMessage_1.Invoke(packageInfo,roots,maxListCount);
		}
		public void RemoveClick()
		{
			method_RemoveClick_1.Invoke();
		}
		public void ViewOfflineUrl(PackageInfo packageInfo,Func<bool, string> getUrl,string messageOnNotFound)
		{
			method_ViewOfflineUrl_1.Invoke(packageInfo,getUrl,messageOnNotFound);
		}
		public void ViewUrl(PackageInfo packageInfo,Func<bool, string> getUrl,string messageOnNotFound)
		{
			method_ViewUrl_1.Invoke(packageInfo,getUrl,messageOnNotFound);
		}
		public void ViewDocClick()
		{
			method_ViewDocClick_1.Invoke();
		}
		public void ViewChangelogClick()
		{
			method_ViewChangelogClick_1.Invoke();
		}
		public void ViewLicensesClick()
		{
			method_ViewLicensesClick_1.Invoke();
		}
		public VisualElement GetTag(PackageTag tag)
		{
			return (VisualElement) method_GetTag_1.Invoke((int)tag);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageDetails, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
