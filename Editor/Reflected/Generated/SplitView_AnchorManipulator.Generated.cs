// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.SplitView+AnchorManipulator, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.UIElements;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class SplitView_AnchorManipulator : ReflectiveClass
	{
		private ReflectiveField<Vector2> field_mStart;
		private ReflectiveField<bool> field_mActive;
		private ReflectiveField field_mSplitView;
		private ReflectiveMethod method_RegisterCallbacksOnTarget_1;
		private ReflectiveMethod method_UnregisterCallbacksFromTarget_1;
		private ReflectiveMethod method_ApplyDelta_1;
		private ReflectiveMethod method_OnMouseDown_1;
		private ReflectiveMethod method_OnMouseMove_1;
		private ReflectiveMethod method_OnMouseUp_1;
		public SplitView_AnchorManipulator(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public SplitView_AnchorManipulator(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_mStart = CreateField<Vector2>("mStart", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mActive = CreateField<bool>("mActive", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mSplitView = CreateField("mSplitView", BindingFlags.Instance | BindingFlags.NonPublic);
			method_RegisterCallbacksOnTarget_1 = CreateMethod("RegisterCallbacksOnTarget", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_UnregisterCallbacksFromTarget_1 = CreateMethod("UnregisterCallbacksFromTarget", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_ApplyDelta_1 = CreateMethod("ApplyDelta", BindingFlags.Instance | BindingFlags.Public, typeof(float));
			method_OnMouseDown_1 = CreateMethod("OnMouseDown", BindingFlags.Instance | BindingFlags.NonPublic, typeof(MouseDownEvent));
			method_OnMouseMove_1 = CreateMethod("OnMouseMove", BindingFlags.Instance | BindingFlags.NonPublic, typeof(MouseMoveEvent));
			method_OnMouseUp_1 = CreateMethod("OnMouseUp", BindingFlags.Instance | BindingFlags.NonPublic, typeof(MouseUpEvent));
		}
		partial void Initialize();
		public Vector2 mStart
		{
			get => field_mStart.GetValue();
			set => field_mStart.SetValue(value);
		}
		public bool mActive
		{
			get => field_mActive.GetValue();
			set => field_mActive.SetValue(value);
		}
		public SplitView mSplitView
		{
			get
			{
				object _temp = field_mSplitView.GetValue();
				return _temp == null ? null : new SplitView(_temp);
			}
			set => field_mSplitView.SetValue(value.Instance);
		}
		public void RegisterCallbacksOnTarget()
		{
			method_RegisterCallbacksOnTarget_1.Invoke();
		}
		public void UnregisterCallbacksFromTarget()
		{
			method_UnregisterCallbacksFromTarget_1.Invoke();
		}
		public void ApplyDelta(float delta)
		{
			method_ApplyDelta_1.Invoke(delta);
		}
		public void OnMouseDown(MouseDownEvent e)
		{
			method_OnMouseDown_1.Invoke(e);
		}
		public void OnMouseMove(MouseMoveEvent e)
		{
			method_OnMouseMove_1.Invoke(e);
		}
		public void OnMouseUp(MouseUpEvent e)
		{
			method_OnMouseUp_1.Invoke(e);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.SplitView+AnchorManipulator, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
