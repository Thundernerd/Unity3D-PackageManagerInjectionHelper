// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.ProgressBar, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.StyleSheets;
using UnityEngine.UIElements.UIR;
using UnityEngine.Yoga;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class ProgressBar : ReflectiveClass
	{
		private ReflectiveProperty property_cache;
		private ReflectiveProperty<Label> property_currentProgressBar;
		private ReflectiveProperty<Label> property_currentProgressText;
		private ReflectiveMethod method_Show_1;
		private ReflectiveMethod method_Hide_1;
		private ReflectiveMethod method_SetProgress_1;
		public ProgressBar(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public ProgressBar(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			property_cache = CreateProperty("cache", BindingFlags.Instance | BindingFlags.NonPublic);
			property_currentProgressBar = CreateProperty<Label>("currentProgressBar", BindingFlags.Instance | BindingFlags.NonPublic);
			property_currentProgressText = CreateProperty<Label>("currentProgressText", BindingFlags.Instance | BindingFlags.NonPublic);
			method_Show_1 = CreateMethod("Show", BindingFlags.Instance | BindingFlags.Public, null);
			method_Hide_1 = CreateMethod("Hide", BindingFlags.Instance | BindingFlags.Public, null);
			method_SetProgress_1 = CreateMethod("SetProgress", BindingFlags.Instance | BindingFlags.Public, typeof(float));
		}
		partial void Initialize();
		public VisualElementCache cache
		{
			get
			{
				object _temp = property_cache.GetValue();
				return _temp == null ? null : new VisualElementCache(_temp);
			}
		}
		public Label currentProgressBar
		{
			get => property_currentProgressBar.GetValue();
		}
		public Label currentProgressText
		{
			get => property_currentProgressText.GetValue();
		}
		public void Show()
		{
			method_Show_1.Invoke();
		}
		public void Hide()
		{
			method_Hide_1.Invoke();
		}
		public void SetProgress(float percentage)
		{
			method_SetProgress_1.Invoke(percentage);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.ProgressBar, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
