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
		private ReflectiveProperty property_cache;
		private ReflectiveProperty<VisualElement> property_importStatusContainer;
		private ReflectiveProperty<VisualElement> property_nameLabelContainer;
		private ReflectiveProperty<VisualElement> property_sizeLabelContainer;
		private ReflectiveProperty<VisualElement> property_importButtonContainer;
		private ReflectiveMethod method_SetPackageVersion_1;

		public PackageSampleList(object instance) : base(instance)
		{
			property_cache = CreateProperty("cache", BindingFlags.Instance | BindingFlags.NonPublic);
			property_importStatusContainer = CreateProperty<VisualElement>("importStatusContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_nameLabelContainer = CreateProperty<VisualElement>("nameLabelContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_sizeLabelContainer = CreateProperty<VisualElement>("sizeLabelContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_importButtonContainer = CreateProperty<VisualElement>("importButtonContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			method_SetPackageVersion_1 = CreateMethod("SetPackageVersion", BindingFlags.Instance | BindingFlags.Public, typeof(IPackageVersion));
		}

		public VisualElementCache cache
		{
			get => new VisualElementCache(property_cache.GetValue());
			set => property_cache.SetValue(value.Instance);
		}
		public VisualElement importStatusContainer
		{
			get => property_importStatusContainer.GetValue();
		}
		public VisualElement nameLabelContainer
		{
			get => property_nameLabelContainer.GetValue();
		}
		public VisualElement sizeLabelContainer
		{
			get => property_sizeLabelContainer.GetValue();
		}
		public VisualElement importButtonContainer
		{
			get => property_importButtonContainer.GetValue();
		}
		public void SetPackageVersion(IPackageVersion version)
		{
			method_SetPackageVersion_1.Invoke(version);
		}
	}
}
