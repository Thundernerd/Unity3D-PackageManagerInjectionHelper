// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.ISelectableItem, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
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
			property_package = CreateProperty("package", BindingFlags.Instance | BindingFlags.Public);
			property_targetVersion = CreateProperty("targetVersion", BindingFlags.Instance | BindingFlags.Public);
			property_element = CreateProperty<VisualElement>("element", BindingFlags.Instance | BindingFlags.Public);
		}

		public IPackage package
		{
			get => new IPackage(property_package.GetValue());
		}
		public IPackageVersion targetVersion
		{
			get => new IPackageVersion(property_targetVersion.GetValue());
		}
		public VisualElement element
		{
			get => property_element.GetValue();
		}
	}
}
