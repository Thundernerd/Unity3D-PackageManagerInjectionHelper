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
		private ReflectiveField<Sample> field_sample;
		private ReflectiveField<Label> field_ImportStatus;
		private ReflectiveField<Label> field_NameLabel;
		private ReflectiveField<Label> field_SizeLabel;
		private ReflectiveField<Button> field_ImportButton;
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
			field_sample = CreateField<Sample>("sample", BindingFlags.Instance | BindingFlags.NonPublic);
			field_ImportStatus = CreateField<Label>("ImportStatus", BindingFlags.Instance | BindingFlags.NonPublic);
			field_NameLabel = CreateField<Label>("NameLabel", BindingFlags.Instance | BindingFlags.NonPublic);
			field_SizeLabel = CreateField<Label>("SizeLabel", BindingFlags.Instance | BindingFlags.NonPublic);
			field_ImportButton = CreateField<Button>("ImportButton", BindingFlags.Instance | BindingFlags.NonPublic);
			method_OnImportButtonClicked_1 = CreateMethod("OnImportButtonClicked", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_RefreshImportStatus_1 = CreateMethod("RefreshImportStatus", BindingFlags.Instance | BindingFlags.NonPublic, null);
		}
		partial void Initialize();
		public Sample sample
		{
			get => field_sample.GetValue();
			set => field_sample.SetValue(value);
		}
		public Label ImportStatus
		{
			get => field_ImportStatus.GetValue();
			set => field_ImportStatus.SetValue(value);
		}
		public Label NameLabel
		{
			get => field_NameLabel.GetValue();
			set => field_NameLabel.SetValue(value);
		}
		public Label SizeLabel
		{
			get => field_SizeLabel.GetValue();
			set => field_SizeLabel.SetValue(value);
		}
		public Button ImportButton
		{
			get => field_ImportButton.GetValue();
			set => field_ImportButton.SetValue(value);
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
