// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageToolbar, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
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
	public sealed partial class PackageToolbar : ReflectiveClass
	{
		private ReflectiveField<VisualElement> field_root;
		private ReflectiveProperty property_Cache;
		public PackageToolbar(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageToolbar(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_root = CreateField<VisualElement>("root", BindingFlags.Instance | BindingFlags.NonPublic);
			property_Cache = CreateProperty("Cache", BindingFlags.Instance | BindingFlags.NonPublic);
		}
		partial void Initialize();
		public VisualElement root
		{
			get => field_root.GetValue();
			set => field_root.SetValue(value);
		}
		public VisualElementCache Cache
		{
			get
			{
				object _temp = property_Cache.GetValue();
				return _temp == null ? null : new VisualElementCache(_temp);
			}
			set => property_Cache.SetValue(value.Instance);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageToolbar, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
