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
using Object = UnityEngine.Object;

namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageDetails : ReflectiveClass
	{
		private ReflectiveField field_mPackage;
		private ReflectiveField field_mVersion;
		private ReflectiveField<string> field_kEmptyDescriptionClass;
		private ReflectiveField<string[]> field_kPackageActionVerbs;
		private ReflectiveField<string[]> field_kPackageActionInProgressVerbs;
		private ReflectiveField<PackageTag[]> field_kVisibleTags;
		private ReflectiveField<Texture2D> field_sLoadingTexture;
		private ReflectiveField<int> field_MaxDependentList;
		private ReflectiveField<bool> field_mDescriptionExpanded;
		private ReflectiveProperty property_package;
		private ReflectiveProperty property_displayVersion;
		private ReflectiveProperty property_targetVersion;
		private ReflectiveProperty property_cache;
		private ReflectiveProperty<VisualElement> property_detailDescContainer;
		private ReflectiveProperty<VisualElement> property_detailNameContainer;
		private ReflectiveProperty<Label> property_detailName;
		private ReflectiveProperty<Label> property_detailDesc;
		private ReflectiveProperty<Button> property_detailDescMore;
		private ReflectiveProperty<Button> property_detailDescLess;
		private ReflectiveProperty<VisualElement> property_detailLinksContainer;
		private ReflectiveProperty<VisualElement> property_detailLinks;
		private ReflectiveProperty property_detailError;
		private ReflectiveProperty<ScrollView> property_detailScrollView;
		private ReflectiveProperty<VisualElement> property_detailContainer;
		private ReflectiveProperty<Label> property_detailTitle;
		private ReflectiveProperty<Label> property_detailVersion;
		private ReflectiveProperty<VisualElement> property_detailDateContainer;
		private ReflectiveProperty<Label> property_detailDate;
		private ReflectiveProperty<VisualElement> property_detailAuthorContainer;
		private ReflectiveProperty<Label> property_detailAuthorText;
		private ReflectiveProperty<Button> property_detailAuthorLink;
		private ReflectiveProperty<VisualElement> property_detailRegistryContainer;
		private ReflectiveProperty<VisualElement> property_detailRegistryWarning;
		private ReflectiveProperty<Button> property_detailWarningLink;
		private ReflectiveProperty<Label> property_detailRegistryName;
		private ReflectiveProperty<VisualElement> property_customContainer;
		private ReflectiveProperty property_sampleList;
		private ReflectiveProperty property_dependencies;
		private ReflectiveProperty<VisualElement> property_packageToolbarContainer;
		private ReflectiveProperty<VisualElement> property_packageToolbarLeftArea;
		private ReflectiveProperty<Button> property_updateButton;
		private ReflectiveProperty<Button> property_removeButton;
		private ReflectiveProperty<Button> property_importButton;
		private ReflectiveProperty<Button> property_downloadButton;
		private ReflectiveProperty<Button> property_editButton;
		private ReflectiveProperty property_downloadProgress;
		private ReflectiveProperty<VisualElement> property_detailCategories;
		private ReflectiveProperty<VisualElement> property_detailUnityVersionsContainer;
		private ReflectiveProperty<Label> property_detailUnityVersions;
		private ReflectiveProperty<VisualElement> property_detailSizesContainer;
		private ReflectiveProperty<VisualElement> property_detailSizes;
		private ReflectiveProperty<VisualElement> property_detailImagesContainer;
		private ReflectiveProperty<VisualElement> property_detailImages;
		private ReflectiveMethod method_OnEditorSelectionChanged_1;
		private ReflectiveMethod method_GetDisplayPackageManifestAsset_1;
		private ReflectiveMethod method_EditPackageManifestClick_1;
		private ReflectiveMethod method_OnEnable_1;
		private ReflectiveMethod method_OnDisable_1;
		private ReflectiveMethod method_OnDownloadProgress_1;
		private ReflectiveMethod method_SetContentVisibility_1;
		private ReflectiveMethod method_OnSelectionChanged_1;
		private ReflectiveMethod method_RefreshDependencies_1;
		private ReflectiveMethod method_SetUpdateVisibility_1;
		private ReflectiveMethod method_RefreshExtensions_1;
		private ReflectiveMethod method_SetDisplayVersion_1;
		private ReflectiveMethod method_DescriptionGeometryChangeEvent_1;
		private ReflectiveMethod method_RefreshDescription_1;
		private ReflectiveMethod method_RefreshAuthor_1;
		private ReflectiveMethod method_RefreshRegistry_1;
		private ReflectiveMethod method_RefreshPublishedDate_1;
		private ReflectiveMethod method_RefreshCategories_1;
		private ReflectiveMethod method_RefreshLinks_1;
		private ReflectiveMethod method_RefreshSupportedUnityVersions_1;
		private ReflectiveMethod method_RefreshSizeInfo_1;
		private ReflectiveMethod method_ClearSupportingImages_1;
		private ReflectiveMethod method_RefreshSupportingImages_1;
		private ReflectiveMethod method_SetPackage_1;
		private ReflectiveMethod method_OnPackagesUpdated_1;
		private ReflectiveMethod method_RefreshErrorDisplay_1;
		private ReflectiveMethod method_OnOperationStartOrFinish_1;
		private ReflectiveMethod method_RefreshPackageActionButtons_1;
		private ReflectiveMethod method_RefreshAddButton_1;
		private ReflectiveMethod method_RefreshRemoveButton_1;
		private ReflectiveMethod method_RefreshImportAndDownloadButtons_1;
		private ReflectiveMethod method_GetButtonText_1;
		private ReflectiveMethod method_WarningLinkClick_1;
		private ReflectiveMethod method_DescMoreClick_1;
		private ReflectiveMethod method_DescLessClick_1;
		private ReflectiveMethod method_AuthorClick_1;
		private ReflectiveMethod method_UpdateClick_1;
		private ReflectiveMethod method_GetPackageDashList_1;
		private ReflectiveMethod method_GetDependentMessage_1;
		private ReflectiveMethod method_RemoveClick_1;
		private ReflectiveMethod method_ViewOfflineUrl_1;
		private ReflectiveMethod method_ViewUrl_1;
		private ReflectiveMethod method_ViewDocClick_1;
		private ReflectiveMethod method_ViewChangelogClick_1;
		private ReflectiveMethod method_ViewLicensesClick_1;
		private ReflectiveMethod method_ImportClick_1;
		private ReflectiveMethod method_DownloadOrCancelClick_1;
		private ReflectiveMethod method_GetTagLabel_1;
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
			field_mPackage = CreateField("mPackage", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mVersion = CreateField("mVersion", BindingFlags.Instance | BindingFlags.NonPublic);
			field_kEmptyDescriptionClass = CreateField<string>("kEmptyDescriptionClass", BindingFlags.Static | BindingFlags.NonPublic);
			field_kPackageActionVerbs = CreateField<string[]>("kPackageActionVerbs", BindingFlags.Static | BindingFlags.NonPublic);
			field_kPackageActionInProgressVerbs = CreateField<string[]>("kPackageActionInProgressVerbs", BindingFlags.Static | BindingFlags.NonPublic);
			field_kVisibleTags = CreateField<PackageTag[]>("kVisibleTags", BindingFlags.Static | BindingFlags.NonPublic);
			field_sLoadingTexture = CreateField<Texture2D>("sLoadingTexture", BindingFlags.Static | BindingFlags.NonPublic);
			field_MaxDependentList = CreateField<int>("MaxDependentList", BindingFlags.Static | BindingFlags.NonPublic);
			field_mDescriptionExpanded = CreateField<bool>("mDescriptionExpanded", BindingFlags.Instance | BindingFlags.NonPublic);
			property_package = CreateProperty("package", BindingFlags.Instance | BindingFlags.NonPublic);
			property_displayVersion = CreateProperty("displayVersion", BindingFlags.Instance | BindingFlags.NonPublic);
			property_targetVersion = CreateProperty("targetVersion", BindingFlags.Instance | BindingFlags.NonPublic);
			property_cache = CreateProperty("cache", BindingFlags.Instance | BindingFlags.NonPublic);
			property_detailDescContainer = CreateProperty<VisualElement>("detailDescContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_detailNameContainer = CreateProperty<VisualElement>("detailNameContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_detailName = CreateProperty<Label>("detailName", BindingFlags.Instance | BindingFlags.NonPublic);
			property_detailDesc = CreateProperty<Label>("detailDesc", BindingFlags.Instance | BindingFlags.NonPublic);
			property_detailDescMore = CreateProperty<Button>("detailDescMore", BindingFlags.Instance | BindingFlags.NonPublic);
			property_detailDescLess = CreateProperty<Button>("detailDescLess", BindingFlags.Instance | BindingFlags.NonPublic);
			property_detailLinksContainer = CreateProperty<VisualElement>("detailLinksContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_detailLinks = CreateProperty<VisualElement>("detailLinks", BindingFlags.Instance | BindingFlags.NonPublic);
			property_detailError = CreateProperty("detailError", BindingFlags.Instance | BindingFlags.NonPublic);
			property_detailScrollView = CreateProperty<ScrollView>("detailScrollView", BindingFlags.Instance | BindingFlags.NonPublic);
			property_detailContainer = CreateProperty<VisualElement>("detailContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_detailTitle = CreateProperty<Label>("detailTitle", BindingFlags.Instance | BindingFlags.NonPublic);
			property_detailVersion = CreateProperty<Label>("detailVersion", BindingFlags.Instance | BindingFlags.NonPublic);
			property_detailDateContainer = CreateProperty<VisualElement>("detailDateContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_detailDate = CreateProperty<Label>("detailDate", BindingFlags.Instance | BindingFlags.NonPublic);
			property_detailAuthorContainer = CreateProperty<VisualElement>("detailAuthorContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_detailAuthorText = CreateProperty<Label>("detailAuthorText", BindingFlags.Instance | BindingFlags.NonPublic);
			property_detailAuthorLink = CreateProperty<Button>("detailAuthorLink", BindingFlags.Instance | BindingFlags.NonPublic);
			property_detailRegistryContainer = CreateProperty<VisualElement>("detailRegistryContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_detailRegistryWarning = CreateProperty<VisualElement>("detailRegistryWarning", BindingFlags.Instance | BindingFlags.NonPublic);
			property_detailWarningLink = CreateProperty<Button>("detailWarningLink", BindingFlags.Instance | BindingFlags.NonPublic);
			property_detailRegistryName = CreateProperty<Label>("detailRegistryName", BindingFlags.Instance | BindingFlags.NonPublic);
			property_customContainer = CreateProperty<VisualElement>("customContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_sampleList = CreateProperty("sampleList", BindingFlags.Instance | BindingFlags.NonPublic);
			property_dependencies = CreateProperty("dependencies", BindingFlags.Instance | BindingFlags.NonPublic);
			property_packageToolbarContainer = CreateProperty<VisualElement>("packageToolbarContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_packageToolbarLeftArea = CreateProperty<VisualElement>("packageToolbarLeftArea", BindingFlags.Instance | BindingFlags.NonPublic);
			property_updateButton = CreateProperty<Button>("updateButton", BindingFlags.Instance | BindingFlags.NonPublic);
			property_removeButton = CreateProperty<Button>("removeButton", BindingFlags.Instance | BindingFlags.NonPublic);
			property_importButton = CreateProperty<Button>("importButton", BindingFlags.Instance | BindingFlags.NonPublic);
			property_downloadButton = CreateProperty<Button>("downloadButton", BindingFlags.Instance | BindingFlags.NonPublic);
			property_editButton = CreateProperty<Button>("editButton", BindingFlags.Instance | BindingFlags.NonPublic);
			property_downloadProgress = CreateProperty("downloadProgress", BindingFlags.Instance | BindingFlags.NonPublic);
			property_detailCategories = CreateProperty<VisualElement>("detailCategories", BindingFlags.Instance | BindingFlags.NonPublic);
			property_detailUnityVersionsContainer = CreateProperty<VisualElement>("detailUnityVersionsContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_detailUnityVersions = CreateProperty<Label>("detailUnityVersions", BindingFlags.Instance | BindingFlags.NonPublic);
			property_detailSizesContainer = CreateProperty<VisualElement>("detailSizesContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_detailSizes = CreateProperty<VisualElement>("detailSizes", BindingFlags.Instance | BindingFlags.NonPublic);
			property_detailImagesContainer = CreateProperty<VisualElement>("detailImagesContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_detailImages = CreateProperty<VisualElement>("detailImages", BindingFlags.Instance | BindingFlags.NonPublic);
			method_OnEditorSelectionChanged_1 = CreateMethod("OnEditorSelectionChanged", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_GetDisplayPackageManifestAsset_1 = CreateMethod("GetDisplayPackageManifestAsset", BindingFlags.Instance | BindingFlags.Public, null);
			method_EditPackageManifestClick_1 = CreateMethod("EditPackageManifestClick", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_OnEnable_1 = CreateMethod("OnEnable", BindingFlags.Instance | BindingFlags.Public, null);
			method_OnDisable_1 = CreateMethod("OnDisable", BindingFlags.Instance | BindingFlags.Public, null);
			method_OnDownloadProgress_1 = CreateMethod("OnDownloadProgress", BindingFlags.Instance | BindingFlags.NonPublic, typeof(IPackage),typeof(DownloadProgress));
			method_SetContentVisibility_1 = CreateMethod("SetContentVisibility", BindingFlags.Instance | BindingFlags.NonPublic, typeof(bool));
			method_OnSelectionChanged_1 = CreateMethod("OnSelectionChanged", BindingFlags.Instance | BindingFlags.NonPublic, typeof(IPackageVersion));
			method_RefreshDependencies_1 = CreateMethod("RefreshDependencies", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_SetUpdateVisibility_1 = CreateMethod("SetUpdateVisibility", BindingFlags.Instance | BindingFlags.NonPublic, typeof(bool));
			method_RefreshExtensions_1 = CreateMethod("RefreshExtensions", BindingFlags.Instance | BindingFlags.NonPublic, typeof(IPackageVersion));
			method_SetDisplayVersion_1 = CreateMethod("SetDisplayVersion", BindingFlags.Instance | BindingFlags.NonPublic, typeof(IPackageVersion));
			method_DescriptionGeometryChangeEvent_1 = CreateMethod("DescriptionGeometryChangeEvent", BindingFlags.Instance | BindingFlags.NonPublic, typeof(GeometryChangedEvent));
			method_RefreshDescription_1 = CreateMethod("RefreshDescription", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_RefreshAuthor_1 = CreateMethod("RefreshAuthor", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_RefreshRegistry_1 = CreateMethod("RefreshRegistry", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_RefreshPublishedDate_1 = CreateMethod("RefreshPublishedDate", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_RefreshCategories_1 = CreateMethod("RefreshCategories", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_RefreshLinks_1 = CreateMethod("RefreshLinks", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_RefreshSupportedUnityVersions_1 = CreateMethod("RefreshSupportedUnityVersions", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_RefreshSizeInfo_1 = CreateMethod("RefreshSizeInfo", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_ClearSupportingImages_1 = CreateMethod("ClearSupportingImages", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_RefreshSupportingImages_1 = CreateMethod("RefreshSupportingImages", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_SetPackage_1 = CreateMethod("SetPackage", BindingFlags.Instance | BindingFlags.Public, typeof(IPackage),typeof(IPackageVersion));
			method_OnPackagesUpdated_1 = CreateMethod("OnPackagesUpdated", BindingFlags.Instance | BindingFlags.NonPublic, typeof(IEnumerable<IPackage>));
			method_RefreshErrorDisplay_1 = CreateMethod("RefreshErrorDisplay", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_OnOperationStartOrFinish_1 = CreateMethod("OnOperationStartOrFinish", BindingFlags.Instance | BindingFlags.NonPublic, typeof(IPackage));
			method_RefreshPackageActionButtons_1 = CreateMethod("RefreshPackageActionButtons", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_RefreshAddButton_1 = CreateMethod("RefreshAddButton", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_RefreshRemoveButton_1 = CreateMethod("RefreshRemoveButton", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_RefreshImportAndDownloadButtons_1 = CreateMethod("RefreshImportAndDownloadButtons", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_GetButtonText_1 = CreateMethod("GetButtonText", BindingFlags.Instance | BindingFlags.NonPublic, typeof(PackageDetails_PackageAction),typeof(bool),typeof(SemVersion));
			method_WarningLinkClick_1 = CreateMethod("WarningLinkClick", BindingFlags.Static | BindingFlags.NonPublic, null);
			method_DescMoreClick_1 = CreateMethod("DescMoreClick", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_DescLessClick_1 = CreateMethod("DescLessClick", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_AuthorClick_1 = CreateMethod("AuthorClick", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_UpdateClick_1 = CreateMethod("UpdateClick", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_GetPackageDashList_1 = CreateMethod("GetPackageDashList", BindingFlags.Instance | BindingFlags.NonPublic, typeof(IEnumerable<IPackageVersion>),typeof(int));
			method_GetDependentMessage_1 = CreateMethod("GetDependentMessage", BindingFlags.Instance | BindingFlags.NonPublic, typeof(IPackageVersion),typeof(IEnumerable<IPackageVersion>),typeof(int));
			method_RemoveClick_1 = CreateMethod("RemoveClick", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_ViewOfflineUrl_1 = CreateMethod("ViewOfflineUrl", BindingFlags.Static | BindingFlags.NonPublic, typeof(IPackageVersion),typeof(Func<IPackageVersion, bool, string>),typeof(string));
			method_ViewUrl_1 = CreateMethod("ViewUrl", BindingFlags.Static | BindingFlags.NonPublic, typeof(IPackageVersion),typeof(Func<IPackageVersion, bool, string>),typeof(string));
			method_ViewDocClick_1 = CreateMethod("ViewDocClick", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_ViewChangelogClick_1 = CreateMethod("ViewChangelogClick", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_ViewLicensesClick_1 = CreateMethod("ViewLicensesClick", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_ImportClick_1 = CreateMethod("ImportClick", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_DownloadOrCancelClick_1 = CreateMethod("DownloadOrCancelClick", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_GetTagLabel_1 = CreateMethod("GetTagLabel", BindingFlags.Instance | BindingFlags.NonPublic, typeof(string));
		}
		partial void Initialize();
		public IPackage mPackage
		{
			get
			{
				object _temp = field_mPackage.GetValue();
				return _temp == null ? null : new IPackage(_temp);
			}
			set => field_mPackage.SetValue(value.Instance);
		}
		public IPackageVersion mVersion
		{
			get
			{
				object _temp = field_mVersion.GetValue();
				return _temp == null ? null : new IPackageVersion(_temp);
			}
			set => field_mVersion.SetValue(value.Instance);
		}
		public string kEmptyDescriptionClass
		{
			get => field_kEmptyDescriptionClass.GetValue();
			set => field_kEmptyDescriptionClass.SetValue(value);
		}
		public string[] kPackageActionVerbs
		{
			get => field_kPackageActionVerbs.GetValue();
			set => field_kPackageActionVerbs.SetValue(value);
		}
		public string[] kPackageActionInProgressVerbs
		{
			get => field_kPackageActionInProgressVerbs.GetValue();
			set => field_kPackageActionInProgressVerbs.SetValue(value);
		}
		public PackageTag[] kVisibleTags
		{
			get => field_kVisibleTags.GetValue();
			set => field_kVisibleTags.SetValue(value);
		}
		public Texture2D sLoadingTexture
		{
			get => field_sLoadingTexture.GetValue();
			set => field_sLoadingTexture.SetValue(value);
		}
		public int MaxDependentList
		{
			get => field_MaxDependentList.GetValue();
			set => field_MaxDependentList.SetValue(value);
		}
		public bool mDescriptionExpanded
		{
			get => field_mDescriptionExpanded.GetValue();
			set => field_mDescriptionExpanded.SetValue(value);
		}
		public IPackage package
		{
			get
			{
				object _temp = property_package.GetValue();
				return _temp == null ? null : new IPackage(_temp);
			}
			set => property_package.SetValue(value.Instance);
		}
		public IPackageVersion displayVersion
		{
			get
			{
				object _temp = property_displayVersion.GetValue();
				return _temp == null ? null : new IPackageVersion(_temp);
			}
			set => property_displayVersion.SetValue(value.Instance);
		}
		public IPackageVersion targetVersion
		{
			get
			{
				object _temp = property_targetVersion.GetValue();
				return _temp == null ? null : new IPackageVersion(_temp);
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
		public VisualElement detailDescContainer
		{
			get => property_detailDescContainer.GetValue();
		}
		public VisualElement detailNameContainer
		{
			get => property_detailNameContainer.GetValue();
		}
		public Label detailName
		{
			get => property_detailName.GetValue();
		}
		public Label detailDesc
		{
			get => property_detailDesc.GetValue();
		}
		public Button detailDescMore
		{
			get => property_detailDescMore.GetValue();
		}
		public Button detailDescLess
		{
			get => property_detailDescLess.GetValue();
		}
		public VisualElement detailLinksContainer
		{
			get => property_detailLinksContainer.GetValue();
		}
		public VisualElement detailLinks
		{
			get => property_detailLinks.GetValue();
		}
		public Alert detailError
		{
			get
			{
				object _temp = property_detailError.GetValue();
				return _temp == null ? null : new Alert(_temp);
			}
		}
		public ScrollView detailScrollView
		{
			get => property_detailScrollView.GetValue();
		}
		public VisualElement detailContainer
		{
			get => property_detailContainer.GetValue();
		}
		public Label detailTitle
		{
			get => property_detailTitle.GetValue();
		}
		public Label detailVersion
		{
			get => property_detailVersion.GetValue();
		}
		public VisualElement detailDateContainer
		{
			get => property_detailDateContainer.GetValue();
		}
		public Label detailDate
		{
			get => property_detailDate.GetValue();
		}
		public VisualElement detailAuthorContainer
		{
			get => property_detailAuthorContainer.GetValue();
		}
		public Label detailAuthorText
		{
			get => property_detailAuthorText.GetValue();
		}
		public Button detailAuthorLink
		{
			get => property_detailAuthorLink.GetValue();
		}
		public VisualElement detailRegistryContainer
		{
			get => property_detailRegistryContainer.GetValue();
		}
		public VisualElement detailRegistryWarning
		{
			get => property_detailRegistryWarning.GetValue();
		}
		public Button detailWarningLink
		{
			get => property_detailWarningLink.GetValue();
		}
		public Label detailRegistryName
		{
			get => property_detailRegistryName.GetValue();
		}
		public VisualElement customContainer
		{
			get => property_customContainer.GetValue();
		}
		public PackageSampleList sampleList
		{
			get
			{
				object _temp = property_sampleList.GetValue();
				return _temp == null ? null : new PackageSampleList(_temp);
			}
		}
		public PackageDependencies dependencies
		{
			get
			{
				object _temp = property_dependencies.GetValue();
				return _temp == null ? null : new PackageDependencies(_temp);
			}
		}
		public VisualElement packageToolbarContainer
		{
			get => property_packageToolbarContainer.GetValue();
		}
		public VisualElement packageToolbarLeftArea
		{
			get => property_packageToolbarLeftArea.GetValue();
		}
		public Button updateButton
		{
			get => property_updateButton.GetValue();
		}
		public Button removeButton
		{
			get => property_removeButton.GetValue();
		}
		public Button importButton
		{
			get => property_importButton.GetValue();
		}
		public Button downloadButton
		{
			get => property_downloadButton.GetValue();
		}
		public Button editButton
		{
			get => property_editButton.GetValue();
		}
		public ProgressBar downloadProgress
		{
			get
			{
				object _temp = property_downloadProgress.GetValue();
				return _temp == null ? null : new ProgressBar(_temp);
			}
		}
		public VisualElement detailCategories
		{
			get => property_detailCategories.GetValue();
		}
		public VisualElement detailUnityVersionsContainer
		{
			get => property_detailUnityVersionsContainer.GetValue();
		}
		public Label detailUnityVersions
		{
			get => property_detailUnityVersions.GetValue();
		}
		public VisualElement detailSizesContainer
		{
			get => property_detailSizesContainer.GetValue();
		}
		public VisualElement detailSizes
		{
			get => property_detailSizes.GetValue();
		}
		public VisualElement detailImagesContainer
		{
			get => property_detailImagesContainer.GetValue();
		}
		public VisualElement detailImages
		{
			get => property_detailImages.GetValue();
		}
		public void OnEditorSelectionChanged()
		{
			method_OnEditorSelectionChanged_1.Invoke();
		}
		public Object GetDisplayPackageManifestAsset()
		{
			return (Object) method_GetDisplayPackageManifestAsset_1.Invoke();
		}
		public void EditPackageManifestClick()
		{
			method_EditPackageManifestClick_1.Invoke();
		}
		public void OnEnable()
		{
			method_OnEnable_1.Invoke();
		}
		public void OnDisable()
		{
			method_OnDisable_1.Invoke();
		}
		public void OnDownloadProgress(IPackage package,DownloadProgress progress)
		{
			method_OnDownloadProgress_1.Invoke(package,progress);
		}
		public void SetContentVisibility(bool visible)
		{
			method_SetContentVisibility_1.Invoke(visible);
		}
		public void OnSelectionChanged(IPackageVersion version)
		{
			method_OnSelectionChanged_1.Invoke(version);
		}
		public void RefreshDependencies()
		{
			method_RefreshDependencies_1.Invoke();
		}
		public void SetUpdateVisibility(bool value)
		{
			method_SetUpdateVisibility_1.Invoke(value);
		}
		public void RefreshExtensions(IPackageVersion version)
		{
			method_RefreshExtensions_1.Invoke(version);
		}
		public void SetDisplayVersion(IPackageVersion version)
		{
			method_SetDisplayVersion_1.Invoke(version);
		}
		public void DescriptionGeometryChangeEvent(GeometryChangedEvent evt)
		{
			method_DescriptionGeometryChangeEvent_1.Invoke(evt);
		}
		public void RefreshDescription()
		{
			method_RefreshDescription_1.Invoke();
		}
		public void RefreshAuthor()
		{
			method_RefreshAuthor_1.Invoke();
		}
		public void RefreshRegistry()
		{
			method_RefreshRegistry_1.Invoke();
		}
		public void RefreshPublishedDate()
		{
			method_RefreshPublishedDate_1.Invoke();
		}
		public void RefreshCategories()
		{
			method_RefreshCategories_1.Invoke();
		}
		public void RefreshLinks()
		{
			method_RefreshLinks_1.Invoke();
		}
		public void RefreshSupportedUnityVersions()
		{
			method_RefreshSupportedUnityVersions_1.Invoke();
		}
		public void RefreshSizeInfo()
		{
			method_RefreshSizeInfo_1.Invoke();
		}
		public void ClearSupportingImages()
		{
			method_ClearSupportingImages_1.Invoke();
		}
		public void RefreshSupportingImages()
		{
			method_RefreshSupportingImages_1.Invoke();
		}
		public void SetPackage(IPackage package,IPackageVersion version)
		{
			method_SetPackage_1.Invoke(package,version);
		}
		public void OnPackagesUpdated(IEnumerable<IPackage> updatedPackages)
		{
			method_OnPackagesUpdated_1.Invoke(updatedPackages);
		}
		public void RefreshErrorDisplay()
		{
			method_RefreshErrorDisplay_1.Invoke();
		}
		public void OnOperationStartOrFinish(IPackage package)
		{
			method_OnOperationStartOrFinish_1.Invoke(package);
		}
		public void RefreshPackageActionButtons()
		{
			method_RefreshPackageActionButtons_1.Invoke();
		}
		public void RefreshAddButton()
		{
			method_RefreshAddButton_1.Invoke();
		}
		public void RefreshRemoveButton()
		{
			method_RefreshRemoveButton_1.Invoke();
		}
		public void RefreshImportAndDownloadButtons()
		{
			method_RefreshImportAndDownloadButtons_1.Invoke();
		}
		public string GetButtonText(PackageDetails_PackageAction action,bool inProgress,SemVersion version)
		{
			return (string) method_GetButtonText_1.Invoke((int)action,inProgress,version);
		}
		public void WarningLinkClick()
		{
			method_WarningLinkClick_1.Invoke();
		}
		public void DescMoreClick()
		{
			method_DescMoreClick_1.Invoke();
		}
		public void DescLessClick()
		{
			method_DescLessClick_1.Invoke();
		}
		public void AuthorClick()
		{
			method_AuthorClick_1.Invoke();
		}
		public void UpdateClick()
		{
			method_UpdateClick_1.Invoke();
		}
		public string GetPackageDashList(IEnumerable<IPackageVersion> versions,int maxListCount)
		{
			return (string) method_GetPackageDashList_1.Invoke(versions,maxListCount);
		}
		public string GetDependentMessage(IPackageVersion version,IEnumerable<IPackageVersion> roots,int maxListCount)
		{
			return (string) method_GetDependentMessage_1.Invoke(version,roots,maxListCount);
		}
		public void RemoveClick()
		{
			method_RemoveClick_1.Invoke();
		}
		public void ViewOfflineUrl(IPackageVersion version,Func<IPackageVersion, bool, string> getUrl,string messageOnNotFound)
		{
			method_ViewOfflineUrl_1.Invoke(version,getUrl,messageOnNotFound);
		}
		public void ViewUrl(IPackageVersion version,Func<IPackageVersion, bool, string> getUrl,string messageOnNotFound)
		{
			method_ViewUrl_1.Invoke(version,getUrl,messageOnNotFound);
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
		public void ImportClick()
		{
			method_ImportClick_1.Invoke();
		}
		public void DownloadOrCancelClick()
		{
			method_DownloadOrCancelClick_1.Invoke();
		}
		public Label GetTagLabel(string tag)
		{
			return (Label) method_GetTagLabel_1.Invoke(tag);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageDetails, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
