// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageVersionItem, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
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
	public sealed partial class PackageVersionItem : ReflectiveClass
	{
		private ReflectiveProperty property_package;
		private ReflectiveProperty property_version;
		private ReflectiveProperty property_targetVersion;
		private ReflectiveProperty<VisualElement> property_element;
		private ReflectiveMethod method_RefreshLabel_1;

		public PackageVersionItem(object instance) : base(instance)
		{
			property_package = CreateProperty("package", BindingFlags.Instance | BindingFlags.Public);
			property_version = CreateProperty("version", BindingFlags.Instance | BindingFlags.Public);
			property_targetVersion = CreateProperty("targetVersion", BindingFlags.Instance | BindingFlags.Public);
			property_element = CreateProperty<VisualElement>("element", BindingFlags.Instance | BindingFlags.Public);
			method_RefreshLabel_1 = CreateMethod("RefreshLabel", BindingFlags.Instance | BindingFlags.NonPublic, null);
		}

		public IPackage package
		{
			get => new IPackage(property_package.GetValue());
			set => property_package.SetValue(value.Instance);
		}
		public IPackageVersion version
		{
			get => new IPackageVersion(property_version.GetValue());
			set => property_version.SetValue(value.Instance);
		}
		public IPackageVersion targetVersion
		{
			get => new IPackageVersion(property_targetVersion.GetValue());
		}
		public VisualElement element
		{
			get => property_element.GetValue();
		}
		public void RefreshLabel()
		{
			method_RefreshLabel_1.Invoke();
		}
	}
}
