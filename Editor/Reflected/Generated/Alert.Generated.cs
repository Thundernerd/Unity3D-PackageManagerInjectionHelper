// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.Alert, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
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
	public sealed partial class Alert : ReflectiveClass
	{
		private ReflectiveField<VisualElement> field_root;
		private ReflectiveField<float> field_originalPositionRight;
		private ReflectiveField<float> field_positionRightWithScroll;
		private ReflectiveField<Action> field_OnCloseError;
		private ReflectiveField<Label> field_AlertMessage;
		private ReflectiveField<Button> field_CloseButton;
		private ReflectiveMethod method_SetError_1;
		private ReflectiveMethod method_ClearError_1;
		private ReflectiveMethod method_AdjustSize_1;
		public Alert(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public Alert(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_root = CreateField<VisualElement>("root", BindingFlags.Instance | BindingFlags.NonPublic);
			field_originalPositionRight = CreateField<float>("originalPositionRight", BindingFlags.Static | BindingFlags.NonPublic);
			field_positionRightWithScroll = CreateField<float>("positionRightWithScroll", BindingFlags.Static | BindingFlags.NonPublic);
			field_OnCloseError = CreateField<Action>("OnCloseError", BindingFlags.Instance | BindingFlags.Public);
			field_AlertMessage = CreateField<Label>("AlertMessage", BindingFlags.Instance | BindingFlags.NonPublic);
			field_CloseButton = CreateField<Button>("CloseButton", BindingFlags.Instance | BindingFlags.NonPublic);
			method_SetError_1 = CreateMethod("SetError", BindingFlags.Instance | BindingFlags.Public, typeof(Error));
			method_ClearError_1 = CreateMethod("ClearError", BindingFlags.Instance | BindingFlags.Public, null);
			method_AdjustSize_1 = CreateMethod("AdjustSize", BindingFlags.Instance | BindingFlags.Public, typeof(bool));
		}
		partial void Initialize();
		public VisualElement root
		{
			get => field_root.GetValue();
			set => field_root.SetValue(value);
		}
		public float originalPositionRight
		{
			get => field_originalPositionRight.GetValue();
			set => field_originalPositionRight.SetValue(value);
		}
		public float positionRightWithScroll
		{
			get => field_positionRightWithScroll.GetValue();
			set => field_positionRightWithScroll.SetValue(value);
		}
		public Action OnCloseError
		{
			get => field_OnCloseError.GetValue();
			set => field_OnCloseError.SetValue(value);
		}
		public Label AlertMessage
		{
			get => field_AlertMessage.GetValue();
			set => field_AlertMessage.SetValue(value);
		}
		public Button CloseButton
		{
			get => field_CloseButton.GetValue();
			set => field_CloseButton.SetValue(value);
		}
		public void SetError(Error error)
		{
			method_SetError_1.Invoke(error);
		}
		public void ClearError()
		{
			method_ClearError_1.Invoke();
		}
		public void AdjustSize(bool verticalScrollerVisible)
		{
			method_AdjustSize_1.Invoke(verticalScrollerVisible);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.Alert, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
