// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.ElementSelection, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.UI;
using System.Collections.Generic;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class ElementSelection : ReflectiveClass
	{
		private ReflectiveProperty property_Element;
		private ReflectiveProperty property_Selection;
		private ReflectiveMethod method_OnChanged_1;
		public ElementSelection(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public ElementSelection(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			property_Element = CreateProperty("Element", BindingFlags.Instance | BindingFlags.NonPublic);
			property_Selection = CreateProperty("Selection", BindingFlags.Instance | BindingFlags.NonPublic);
			method_OnChanged_1 = CreateMethod("OnChanged", BindingFlags.Instance | BindingFlags.Public, typeof(IEnumerable<PackageVersion>));
		}
		partial void Initialize();
		public IPackageSelection Element
		{
			get
			{
				object _temp = property_Element.GetValue();
				return _temp == null ? null : new IPackageSelection(_temp);
			}
			set => property_Element.SetValue(value.Instance);
		}
		public Selection Selection
		{
			get
			{
				object _temp = property_Selection.GetValue();
				return _temp == null ? null : new Selection(_temp);
			}
			set => property_Selection.SetValue(value.Instance);
		}
		public void OnChanged(IEnumerable<PackageVersion> selection)
		{
			method_OnChanged_1.Invoke(selection);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.ElementSelection, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
