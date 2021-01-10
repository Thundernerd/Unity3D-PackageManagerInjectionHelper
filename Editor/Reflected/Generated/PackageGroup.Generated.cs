// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageGroup, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
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
	public sealed partial class PackageGroup : ReflectiveVisualElementClass
	{
		private ReflectiveField<VisualElement> field_root;
		private ReflectiveField field_Origin;
		private ReflectiveField field_Selection;
		private ReflectiveField field_previousGroup;
		private ReflectiveField field_nextGroup;
		private ReflectiveField field_firstPackage;
		private ReflectiveField field_lastPackage;
		private ReflectiveProperty property_PackageItems;
		private ReflectiveProperty property_Cache;
		private ReflectiveProperty<VisualElement> property_List;
		private ReflectiveProperty<Label> property_HeaderTitle;
		private ReflectiveMethod method_GetSelectionList_1;
		private ReflectiveMethod method_AddPackage_1;
		private ReflectiveMethod method_ReorderPackageItems_1;
		public PackageGroup(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageGroup(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_root = CreateField<VisualElement>("root", BindingFlags.Instance | BindingFlags.NonPublic);
			field_Origin = CreateField("Origin", BindingFlags.Instance | BindingFlags.NonPublic);
			field_Selection = CreateField("Selection", BindingFlags.Instance | BindingFlags.NonPublic);
			field_previousGroup = CreateField("previousGroup", BindingFlags.Instance | BindingFlags.Public);
			field_nextGroup = CreateField("nextGroup", BindingFlags.Instance | BindingFlags.Public);
			field_firstPackage = CreateField("firstPackage", BindingFlags.Instance | BindingFlags.Public);
			field_lastPackage = CreateField("lastPackage", BindingFlags.Instance | BindingFlags.Public);
			property_PackageItems = CreateProperty("PackageItems", BindingFlags.Instance | BindingFlags.NonPublic);
			property_Cache = CreateProperty("Cache", BindingFlags.Instance | BindingFlags.NonPublic);
			property_List = CreateProperty<VisualElement>("List", BindingFlags.Instance | BindingFlags.NonPublic);
			property_HeaderTitle = CreateProperty<Label>("HeaderTitle", BindingFlags.Instance | BindingFlags.NonPublic);
			method_GetSelectionList_1 = CreateMethod("GetSelectionList", BindingFlags.Instance | BindingFlags.Public, null);
			method_AddPackage_1 = CreateMethod("AddPackage", BindingFlags.Instance | BindingFlags.NonPublic, typeof(Package));
			method_ReorderPackageItems_1 = CreateMethod("ReorderPackageItems", BindingFlags.Instance | BindingFlags.NonPublic, null);
		}
		partial void Initialize();
		public VisualElement root
		{
			get => field_root.GetValue();
			set => field_root.SetValue(value);
		}
		public PackageGroupOrigins Origin
		{
			get
			{
				object _temp = (int)field_Origin.GetValue();
				return (PackageGroupOrigins)_temp;
			}
			set => field_Origin.SetValue((int)value);
		}
		public Selection Selection
		{
			get
			{
				object _temp = field_Selection.GetValue();
				return _temp == null ? null : new Selection(_temp);
			}
			set => field_Selection.SetValue(value.Instance);
		}
		public PackageGroup previousGroup
		{
			get
			{
				object _temp = field_previousGroup.GetValue();
				return _temp == null ? null : new PackageGroup(_temp);
			}
			set => field_previousGroup.SetValue(value.Instance);
		}
		public PackageGroup nextGroup
		{
			get
			{
				object _temp = field_nextGroup.GetValue();
				return _temp == null ? null : new PackageGroup(_temp);
			}
			set => field_nextGroup.SetValue(value.Instance);
		}
		public PackageItem firstPackage
		{
			get
			{
				object _temp = field_firstPackage.GetValue();
				return _temp == null ? null : new PackageItem(_temp);
			}
			set => field_firstPackage.SetValue(value.Instance);
		}
		public PackageItem lastPackage
		{
			get
			{
				object _temp = field_lastPackage.GetValue();
				return _temp == null ? null : new PackageItem(_temp);
			}
			set => field_lastPackage.SetValue(value.Instance);
		}
		public IEnumerable<PackageItem> PackageItems
		{
			get
			{
				object _temp = property_PackageItems.GetValue();
				return _temp == null ? null : Utilities.GenerateEnumerable<PackageItem>(_temp);
			}
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
		public VisualElement List
		{
			get => property_List.GetValue();
		}
		public Label HeaderTitle
		{
			get => property_HeaderTitle.GetValue();
		}
		public IEnumerable<IPackageSelection> GetSelectionList()
		{
			return Utilities.GenerateEnumerable<IPackageSelection>(method_GetSelectionList_1.Invoke());
		}
		public PackageItem AddPackage(Package package)
		{
			return new PackageItem(method_AddPackage_1.Invoke(package));
		}
		public void ReorderPackageItems()
		{
			method_ReorderPackageItems_1.Invoke();
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageGroup, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
