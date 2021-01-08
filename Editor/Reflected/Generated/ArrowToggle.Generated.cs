// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.ArrowToggle, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
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
	public sealed partial class ArrowToggle : ReflectiveVisualElementClass
	{
		private ReflectiveField<bool> field_mExpanded;
		private ReflectiveProperty<bool> property_expanded;
		private ReflectiveMethod method_Toggle_1;
		public ArrowToggle(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public ArrowToggle(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_mExpanded = CreateField<bool>("mExpanded", BindingFlags.Instance | BindingFlags.NonPublic);
			property_expanded = CreateProperty<bool>("expanded", BindingFlags.Instance | BindingFlags.Public);
			method_Toggle_1 = CreateMethod("Toggle", BindingFlags.Instance | BindingFlags.Public, null);
		}
		partial void Initialize();
		public bool mExpanded
		{
			get => field_mExpanded.GetValue();
			set => field_mExpanded.SetValue(value);
		}
		public bool expanded
		{
			get => property_expanded.GetValue();
			set => property_expanded.SetValue(value);
		}
		public void Toggle()
		{
			method_Toggle_1.Invoke();
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.ArrowToggle, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
