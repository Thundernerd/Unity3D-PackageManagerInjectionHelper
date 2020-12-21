// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageSampleItem, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.UI;
using UnityEngine.UIElements;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageSampleItem : ReflectiveClass
	{
		private ReflectiveField field_mVersion;
		private ReflectiveField<Sample> field_mSample;
		private ReflectiveField<Label> field_mImportStatus;
		private ReflectiveField<Label> field_mNameLabel;
		private ReflectiveField<Label> field_mSizeLabel;
		private ReflectiveField<Button> field_mImportButton;
		private ReflectiveProperty<Label> property_importStatus;
		private ReflectiveProperty<Label> property_nameLabel;
		private ReflectiveProperty<Label> property_sizeLabel;
		private ReflectiveProperty<Button> property_importButton;
		private ReflectiveMethod method_OnImportButtonClicked_1;
		private ReflectiveMethod method_RefreshImportStatus_1;
		public PackageSampleItem(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageSampleItem(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_mVersion = CreateField("mVersion", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mSample = CreateField<Sample>("mSample", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mImportStatus = CreateField<Label>("mImportStatus", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mNameLabel = CreateField<Label>("mNameLabel", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mSizeLabel = CreateField<Label>("mSizeLabel", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mImportButton = CreateField<Button>("mImportButton", BindingFlags.Instance | BindingFlags.NonPublic);
			property_importStatus = CreateProperty<Label>("importStatus", BindingFlags.Instance | BindingFlags.NonPublic);
			property_nameLabel = CreateProperty<Label>("nameLabel", BindingFlags.Instance | BindingFlags.NonPublic);
			property_sizeLabel = CreateProperty<Label>("sizeLabel", BindingFlags.Instance | BindingFlags.NonPublic);
			property_importButton = CreateProperty<Button>("importButton", BindingFlags.Instance | BindingFlags.NonPublic);
			method_OnImportButtonClicked_1 = CreateMethod("OnImportButtonClicked", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_RefreshImportStatus_1 = CreateMethod("RefreshImportStatus", BindingFlags.Instance | BindingFlags.NonPublic, null);
		}
		partial void Initialize();
		public IPackageVersion mVersion
		{
			get
			{
				object _temp = field_mVersion.GetValue();
				return _temp == null ? null : new IPackageVersion(_temp);
			}
			set => field_mVersion.SetValue(value.Instance);
		}
		public Sample mSample
		{
			get => field_mSample.GetValue();
			set => field_mSample.SetValue(value);
		}
		public Label mImportStatus
		{
			get => field_mImportStatus.GetValue();
			set => field_mImportStatus.SetValue(value);
		}
		public Label mNameLabel
		{
			get => field_mNameLabel.GetValue();
			set => field_mNameLabel.SetValue(value);
		}
		public Label mSizeLabel
		{
			get => field_mSizeLabel.GetValue();
			set => field_mSizeLabel.SetValue(value);
		}
		public Button mImportButton
		{
			get => field_mImportButton.GetValue();
			set => field_mImportButton.SetValue(value);
		}
		public Label importStatus
		{
			get => property_importStatus.GetValue();
		}
		public Label nameLabel
		{
			get => property_nameLabel.GetValue();
		}
		public Label sizeLabel
		{
			get => property_sizeLabel.GetValue();
		}
		public Button importButton
		{
			get => property_importButton.GetValue();
		}
		public void OnImportButtonClicked()
		{
			method_OnImportButtonClicked_1.Invoke();
		}
		public void RefreshImportStatus()
		{
			method_RefreshImportStatus_1.Invoke();
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageSampleItem, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
