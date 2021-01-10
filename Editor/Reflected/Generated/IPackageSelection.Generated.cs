// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.IPackageSelection, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.UI;
using UnityEngine.UIElements;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class IPackageSelection : ReflectiveClass
	{
		private ReflectiveProperty property_TargetVersion;
		private ReflectiveProperty<VisualElement> property_Element;
		private ReflectiveMethod method_RefreshSelection_1;
		public IPackageSelection(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public IPackageSelection(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			property_TargetVersion = CreateProperty("TargetVersion", BindingFlags.Instance | BindingFlags.Public);
			property_Element = CreateProperty<VisualElement>("Element", BindingFlags.Instance | BindingFlags.Public);
			method_RefreshSelection_1 = CreateMethod("RefreshSelection", BindingFlags.Instance | BindingFlags.Public, null);
		}
		partial void Initialize();
		public PackageInfo TargetVersion
		{
			get
			{
				object _temp = property_TargetVersion.GetValue();
				return _temp == null ? null : new PackageInfo(_temp);
			}
		}
		public VisualElement Element
		{
			get => property_Element.GetValue();
		}
		public void RefreshSelection()
		{
			method_RefreshSelection_1.Invoke();
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.IPackageSelection, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
