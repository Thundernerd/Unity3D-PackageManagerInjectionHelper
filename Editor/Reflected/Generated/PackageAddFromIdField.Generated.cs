// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageAddFromIdField, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.StyleSheets;
using UnityEngine.UIElements.UIR;
using UnityEngine.Yoga;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageAddFromIdField : ReflectiveClass
	{
		private ReflectiveField<string> field_idText;
		private ReflectiveField<VisualElement> field_root;
		private ReflectiveField<VisualElement> field_AddFromIdFieldContainer;
		private ReflectiveField<TextField> field_IdTextField;
		private ReflectiveField<Label> field_AddButton;
		private ReflectiveProperty<VisualElement> property_AddFromIdFieldContainer;
		private ReflectiveProperty<TextField> property_idTextField;
		private ReflectiveProperty<Label> property_AddButton;
		private ReflectiveMethod method_OnidTextFieldChange_1;
		private ReflectiveMethod method_Refocus_1;
		private ReflectiveMethod method_OnidTextFieldFocusOut_1;
		private ReflectiveMethod method_OnContainerMouseDown_1;
		private ReflectiveMethod method_OnEnterPanel_1;
		private ReflectiveMethod method_OnLeavePanel_1;
		private ReflectiveMethod method_OnKeyDownShortcut_1;
		private ReflectiveMethod method_OnAddButtonClick_1;
		private ReflectiveMethod method_Hide_1;
		private ReflectiveMethod method_Show_1;
		private ReflectiveMethod method_Reset_1;
		public PackageAddFromIdField(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageAddFromIdField(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_idText = CreateField<string>("idText", BindingFlags.Instance | BindingFlags.NonPublic);
			field_root = CreateField<VisualElement>("root", BindingFlags.Instance | BindingFlags.NonPublic);
			field_AddFromIdFieldContainer = CreateField<VisualElement>("AddFromIdFieldContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			field_IdTextField = CreateField<TextField>("IdTextField", BindingFlags.Instance | BindingFlags.NonPublic);
			field_AddButton = CreateField<Label>("AddButton", BindingFlags.Instance | BindingFlags.NonPublic);
			property_AddFromIdFieldContainer = CreateProperty<VisualElement>("AddFromIdFieldContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_idTextField = CreateProperty<TextField>("idTextField", BindingFlags.Instance | BindingFlags.NonPublic);
			property_AddButton = CreateProperty<Label>("AddButton", BindingFlags.Instance | BindingFlags.NonPublic);
			method_OnidTextFieldChange_1 = CreateMethod("OnidTextFieldChange", BindingFlags.Instance | BindingFlags.NonPublic, typeof(ChangeEvent<string>));
			method_Refocus_1 = CreateMethod("Refocus", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_OnidTextFieldFocusOut_1 = CreateMethod("OnidTextFieldFocusOut", BindingFlags.Instance | BindingFlags.NonPublic, typeof(FocusOutEvent));
			method_OnContainerMouseDown_1 = CreateMethod("OnContainerMouseDown", BindingFlags.Instance | BindingFlags.NonPublic, typeof(MouseDownEvent));
			method_OnEnterPanel_1 = CreateMethod("OnEnterPanel", BindingFlags.Instance | BindingFlags.NonPublic, typeof(AttachToPanelEvent));
			method_OnLeavePanel_1 = CreateMethod("OnLeavePanel", BindingFlags.Instance | BindingFlags.NonPublic, typeof(DetachFromPanelEvent));
			method_OnKeyDownShortcut_1 = CreateMethod("OnKeyDownShortcut", BindingFlags.Instance | BindingFlags.NonPublic, typeof(KeyDownEvent));
			method_OnAddButtonClick_1 = CreateMethod("OnAddButtonClick", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_Hide_1 = CreateMethod("Hide", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_Show_1 = CreateMethod("Show", BindingFlags.Instance | BindingFlags.NonPublic, typeof(bool));
			method_Reset_1 = CreateMethod("Reset", BindingFlags.Instance | BindingFlags.NonPublic, null);
		}
		partial void Initialize();
		public string idText
		{
			get => field_idText.GetValue();
			set => field_idText.SetValue(value);
		}
		public VisualElement root
		{
			get => field_root.GetValue();
			set => field_root.SetValue(value);
		}
		public VisualElement AddFromIdFieldContainer
		{
			get => field_AddFromIdFieldContainer.GetValue();
			set => field_AddFromIdFieldContainer.SetValue(value);
		}
		public TextField IdTextField
		{
			get => field_IdTextField.GetValue();
			set => field_IdTextField.SetValue(value);
		}
		public Label AddButton
		{
			get => field_AddButton.GetValue();
			set => field_AddButton.SetValue(value);
		}
		public void OnidTextFieldChange(ChangeEvent<string> evt)
		{
			method_OnidTextFieldChange_1.Invoke(evt);
		}
		public void Refocus()
		{
			method_Refocus_1.Invoke();
		}
		public void OnidTextFieldFocusOut(FocusOutEvent evt)
		{
			method_OnidTextFieldFocusOut_1.Invoke(evt);
		}
		public void OnContainerMouseDown(MouseDownEvent evt)
		{
			method_OnContainerMouseDown_1.Invoke(evt);
		}
		public void OnEnterPanel(AttachToPanelEvent evt)
		{
			method_OnEnterPanel_1.Invoke(evt);
		}
		public void OnLeavePanel(DetachFromPanelEvent evt)
		{
			method_OnLeavePanel_1.Invoke(evt);
		}
		public void OnKeyDownShortcut(KeyDownEvent evt)
		{
			method_OnKeyDownShortcut_1.Invoke(evt);
		}
		public void OnAddButtonClick()
		{
			method_OnAddButtonClick_1.Invoke();
		}
		public void Hide()
		{
			method_Hide_1.Invoke();
		}
		public void Show(bool reset)
		{
			method_Show_1.Invoke(reset);
		}
		public void Reset()
		{
			method_Reset_1.Invoke();
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageAddFromIdField, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
