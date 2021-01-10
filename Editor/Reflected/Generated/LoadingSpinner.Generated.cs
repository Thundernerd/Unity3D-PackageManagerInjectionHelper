// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.LoadingSpinner, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
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
	public sealed partial class LoadingSpinner : ReflectiveClass
	{
		private ReflectiveField<int> field_rotation;
		private ReflectiveProperty<bool> property_InvertColor;
		private ReflectiveProperty<bool> property_Started;
		private ReflectiveMethod method_UpdateProgress_1;
		private ReflectiveMethod method_Start_1;
		private ReflectiveMethod method_Stop_1;
		public LoadingSpinner(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public LoadingSpinner(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_rotation = CreateField<int>("rotation", BindingFlags.Instance | BindingFlags.NonPublic);
			property_InvertColor = CreateProperty<bool>("InvertColor", BindingFlags.Instance | BindingFlags.Public);
			property_Started = CreateProperty<bool>("Started", BindingFlags.Instance | BindingFlags.Public);
			method_UpdateProgress_1 = CreateMethod("UpdateProgress", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_Start_1 = CreateMethod("Start", BindingFlags.Instance | BindingFlags.Public, null);
			method_Stop_1 = CreateMethod("Stop", BindingFlags.Instance | BindingFlags.Public, null);
		}
		partial void Initialize();
		public int rotation
		{
			get => field_rotation.GetValue();
			set => field_rotation.SetValue(value);
		}
		public bool InvertColor
		{
			get => property_InvertColor.GetValue();
			set => property_InvertColor.SetValue(value);
		}
		public bool Started
		{
			get => property_Started.GetValue();
			set => property_Started.SetValue(value);
		}
		public void UpdateProgress()
		{
			method_UpdateProgress_1.Invoke();
		}
		public void Start()
		{
			method_Start_1.Invoke();
		}
		public void Stop()
		{
			method_Stop_1.Invoke();
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.LoadingSpinner, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
