// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageSampleList, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
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
	public sealed partial class PackageSampleList : ReflectiveClass
	{
		private ReflectiveField<VisualElement> field_root;
		private ReflectiveProperty property_Cache;
		private ReflectiveProperty<VisualElement> property_ImportStatusContainer;
		private ReflectiveProperty<VisualElement> property_NameLabelContainer;
		private ReflectiveProperty<VisualElement> property_SizeLabelContainer;
		private ReflectiveProperty<VisualElement> property_ImportButtonContainer;
		private ReflectiveMethod method_SetPackage_1;
		public PackageSampleList(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageSampleList(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_root = CreateField<VisualElement>("root", BindingFlags.Instance | BindingFlags.NonPublic);
			property_Cache = CreateProperty("Cache", BindingFlags.Instance | BindingFlags.NonPublic);
			property_ImportStatusContainer = CreateProperty<VisualElement>("ImportStatusContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_NameLabelContainer = CreateProperty<VisualElement>("NameLabelContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_SizeLabelContainer = CreateProperty<VisualElement>("SizeLabelContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_ImportButtonContainer = CreateProperty<VisualElement>("ImportButtonContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			method_SetPackage_1 = CreateMethod("SetPackage", BindingFlags.Instance | BindingFlags.Public, typeof(PackageInfo));
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
		public VisualElement ImportStatusContainer
		{
			get => property_ImportStatusContainer.GetValue();
		}
		public VisualElement NameLabelContainer
		{
			get => property_NameLabelContainer.GetValue();
		}
		public VisualElement SizeLabelContainer
		{
			get => property_SizeLabelContainer.GetValue();
		}
		public VisualElement ImportButtonContainer
		{
			get => property_ImportButtonContainer.GetValue();
		}
		public void SetPackage(PackageInfo package)
		{
			method_SetPackage_1.Invoke(package);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageSampleList, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
