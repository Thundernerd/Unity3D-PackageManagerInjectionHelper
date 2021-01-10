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
		private ReflectiveField<bool> field_Expanded;
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
			field_Expanded = CreateField<bool>("Expanded", BindingFlags.Instance | BindingFlags.NonPublic);
			method_Toggle_1 = CreateMethod("Toggle", BindingFlags.Instance | BindingFlags.Public, null);
		}
		partial void Initialize();
		public bool Expanded
		{
			get => field_Expanded.GetValue();
			set => field_Expanded.SetValue(value);
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
