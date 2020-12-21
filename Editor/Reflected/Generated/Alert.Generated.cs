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
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.StyleSheets;
using UnityEngine.UIElements.UIR;
using UnityEngine.Yoga;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class Alert : ReflectiveClass
	{
		private ReflectiveField<float> field_kPositionRightOriginal;
		private ReflectiveField<float> field_kPositionRightWithScroll;
		private ReflectiveField<Action> field_onCloseError;
		private ReflectiveProperty property_cache;
		private ReflectiveProperty<Label> property_alertMessage;
		private ReflectiveProperty<Button> property_closeButton;
		private ReflectiveMethod method_SetError_1;
		private ReflectiveMethod method_ClearError_1;
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
			field_kPositionRightOriginal = CreateField<float>("kPositionRightOriginal", BindingFlags.Static | BindingFlags.NonPublic);
			field_kPositionRightWithScroll = CreateField<float>("kPositionRightWithScroll", BindingFlags.Static | BindingFlags.NonPublic);
			field_onCloseError = CreateField<Action>("onCloseError", BindingFlags.Instance | BindingFlags.Public);
			property_cache = CreateProperty("cache", BindingFlags.Instance | BindingFlags.NonPublic);
			property_alertMessage = CreateProperty<Label>("alertMessage", BindingFlags.Instance | BindingFlags.NonPublic);
			property_closeButton = CreateProperty<Button>("closeButton", BindingFlags.Instance | BindingFlags.NonPublic);
			method_SetError_1 = CreateMethod("SetError", BindingFlags.Instance | BindingFlags.Public, typeof(Error));
			method_ClearError_1 = CreateMethod("ClearError", BindingFlags.Instance | BindingFlags.Public, null);
		}
		partial void Initialize();
		public float kPositionRightOriginal
		{
			get => field_kPositionRightOriginal.GetValue();
			set => field_kPositionRightOriginal.SetValue(value);
		}
		public float kPositionRightWithScroll
		{
			get => field_kPositionRightWithScroll.GetValue();
			set => field_kPositionRightWithScroll.SetValue(value);
		}
		public Action onCloseError
		{
			get => field_onCloseError.GetValue();
			set => field_onCloseError.SetValue(value);
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
		public Label alertMessage
		{
			get => property_alertMessage.GetValue();
		}
		public Button closeButton
		{
			get => property_closeButton.GetValue();
		}
		public void SetError(Error error)
		{
			method_SetError_1.Invoke(error);
		}
		public void ClearError()
		{
			method_ClearError_1.Invoke();
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.Alert, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
