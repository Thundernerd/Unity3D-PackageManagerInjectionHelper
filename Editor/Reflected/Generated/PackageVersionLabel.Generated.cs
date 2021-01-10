// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageVersionLabel, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
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
	public sealed partial class PackageVersionLabel : ReflectiveClass
	{
		private ReflectiveProperty property_Version;
		private ReflectiveProperty property_SelectionManager;
		private ReflectiveProperty property_Selection;
		private ReflectiveProperty property_TargetVersion;
		private ReflectiveProperty<VisualElement> property_Element;
		private ReflectiveMethod method_RefreshSelection_1;
		private ReflectiveMethod method_RefreshLabel_1;
		public PackageVersionLabel(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageVersionLabel(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			property_Version = CreateProperty("Version", BindingFlags.Instance | BindingFlags.Public);
			property_SelectionManager = CreateProperty("SelectionManager", BindingFlags.Instance | BindingFlags.NonPublic);
			property_Selection = CreateProperty("Selection", BindingFlags.Instance | BindingFlags.NonPublic);
			property_TargetVersion = CreateProperty("TargetVersion", BindingFlags.Instance | BindingFlags.Public);
			property_Element = CreateProperty<VisualElement>("Element", BindingFlags.Instance | BindingFlags.Public);
			method_RefreshSelection_1 = CreateMethod("RefreshSelection", BindingFlags.Instance | BindingFlags.Public, null);
			method_RefreshLabel_1 = CreateMethod("RefreshLabel", BindingFlags.Instance | BindingFlags.NonPublic, null);
		}
		partial void Initialize();
		public PackageInfo Version
		{
			get
			{
				object _temp = property_Version.GetValue();
				return _temp == null ? null : new PackageInfo(_temp);
			}
			set => property_Version.SetValue(value.Instance);
		}
		public ElementSelection SelectionManager
		{
			get
			{
				object _temp = property_SelectionManager.GetValue();
				return _temp == null ? null : new ElementSelection(_temp);
			}
			set => property_SelectionManager.SetValue(value.Instance);
		}
		public Selection Selection
		{
			get
			{
				object _temp = property_Selection.GetValue();
				return _temp == null ? null : new Selection(_temp);
			}
			set => property_Selection.SetValue(value.Instance);
		}
		public PackageInfo TargetVersion
		{
			get
			{
				object _temp = property_TargetVersion.GetValue();
				return _temp == null ? null : new PackageInfo(_temp);
			}
		}
		public VisualElement Element
		{
			get => property_Element.GetValue();
		}
		public void RefreshSelection()
		{
			method_RefreshSelection_1.Invoke();
		}
		public void RefreshLabel()
		{
			method_RefreshLabel_1.Invoke();
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageVersionLabel, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
