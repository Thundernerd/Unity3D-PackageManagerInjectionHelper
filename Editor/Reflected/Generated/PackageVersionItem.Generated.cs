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
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.StyleSheets;
using UnityEngine.UIElements.UIR;
using UnityEngine.Yoga;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageVersionItem : ReflectiveVisualElementClass
	{
		private ReflectiveProperty property_package;
		private ReflectiveProperty property_version;
		private ReflectiveProperty property_targetVersion;
		private ReflectiveProperty<VisualElement> property_element;
		private ReflectiveMethod method_RefreshLabel_1;
		public PackageVersionItem(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageVersionItem(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			property_package = CreateProperty("package", BindingFlags.Instance | BindingFlags.Public);
			property_version = CreateProperty("version", BindingFlags.Instance | BindingFlags.Public);
			property_targetVersion = CreateProperty("targetVersion", BindingFlags.Instance | BindingFlags.Public);
			property_element = CreateProperty<VisualElement>("element", BindingFlags.Instance | BindingFlags.Public);
			method_RefreshLabel_1 = CreateMethod("RefreshLabel", BindingFlags.Instance | BindingFlags.NonPublic, null);
		}
		partial void Initialize();
		public IPackage package
		{
			get
			{
				object _temp = property_package.GetValue();
				return _temp == null ? null : new IPackage(_temp);
			}
			set => property_package.SetValue(value.Instance);
		}
		public IPackageVersion version
		{
			get
			{
				object _temp = property_version.GetValue();
				return _temp == null ? null : new IPackageVersion(_temp);
			}
			set => property_version.SetValue(value.Instance);
		}
		public IPackageVersion targetVersion
		{
			get
			{
				object _temp = property_targetVersion.GetValue();
				return _temp == null ? null : new IPackageVersion(_temp);
			}
		}
		public VisualElement element
		{
			get => property_element.GetValue();
		}
		public void RefreshLabel()
		{
			method_RefreshLabel_1.Invoke();
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageVersionItem, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
