// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.ISelectableItem, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------

using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager.UI;
using UnityEngine.UIElements;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class ISelectableItem : ReflectiveClass
	{
		private ReflectiveProperty property_package;
		private ReflectiveProperty property_targetVersion;
		private ReflectiveProperty<VisualElement> property_element;
		public ISelectableItem(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public ISelectableItem(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			property_package = CreateProperty("package", BindingFlags.Instance | BindingFlags.Public);
			property_targetVersion = CreateProperty("targetVersion", BindingFlags.Instance | BindingFlags.Public);
			property_element = CreateProperty<VisualElement>("element", BindingFlags.Instance | BindingFlags.Public);
		}
		partial void Initialize();
		public IPackage package
		{
			get
			{
				object _temp = property_package.GetValue();
				return _temp == null ? null : new IPackage(_temp);
			}
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
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.ISelectableItem, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
