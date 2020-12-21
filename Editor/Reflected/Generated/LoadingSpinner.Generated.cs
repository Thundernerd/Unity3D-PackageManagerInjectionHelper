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
		private ReflectiveField<int> field_kRotationSpeed;
		private ReflectiveField<int> field_mRotation;
		private ReflectiveField<double> field_mLastRotationTime;
		private ReflectiveProperty<bool> property_started;
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
			field_kRotationSpeed = CreateField<int>("kRotationSpeed", BindingFlags.Static | BindingFlags.NonPublic);
			field_mRotation = CreateField<int>("mRotation", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mLastRotationTime = CreateField<double>("mLastRotationTime", BindingFlags.Instance | BindingFlags.NonPublic);
			property_started = CreateProperty<bool>("started", BindingFlags.Instance | BindingFlags.Public);
			method_UpdateProgress_1 = CreateMethod("UpdateProgress", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_Start_1 = CreateMethod("Start", BindingFlags.Instance | BindingFlags.Public, null);
			method_Stop_1 = CreateMethod("Stop", BindingFlags.Instance | BindingFlags.Public, null);
		}
		partial void Initialize();
		public int kRotationSpeed
		{
			get => field_kRotationSpeed.GetValue();
			set => field_kRotationSpeed.SetValue(value);
		}
		public int mRotation
		{
			get => field_mRotation.GetValue();
			set => field_mRotation.SetValue(value);
		}
		public double mLastRotationTime
		{
			get => field_mLastRotationTime.GetValue();
			set => field_mLastRotationTime.SetValue(value);
		}
		public bool started
		{
			get => property_started.GetValue();
			set => property_started.SetValue(value);
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
