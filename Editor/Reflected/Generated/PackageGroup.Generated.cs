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
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.StyleSheets;
using UnityEngine.UIElements.UIR;
using UnityEngine.Yoga;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageGroup : ReflectiveClass
	{
		private ReflectiveField<Action<bool>> field_onGroupToggle;
		private ReflectiveField field_mCache;
		private ReflectiveProperty<bool> property_expanded;
		private ReflectiveProperty property_packageItems;
		private ReflectiveProperty<VisualElement> property_groupContainer;
		private ReflectiveProperty<VisualElement> property_headerContainer;
		private ReflectiveProperty<Toggle> property_headerCaret;
		private ReflectiveMethod method_Contains_1;
		private ReflectiveMethod method_RefreshHeaderVisibility_1;
		private ReflectiveMethod method_AddPackageItem_1;
		private ReflectiveMethod method_AddPackageItem_2;
		private ReflectiveMethod method_ClearPackageItems_1;
		private ReflectiveMethod method_RemovePackageItem_1;

		public PackageGroup(object instance) : base(instance)
		{
			field_onGroupToggle = CreateField<Action<bool>>("onGroupToggle", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mCache = CreateField("mCache", BindingFlags.Instance | BindingFlags.NonPublic);
			property_expanded = CreateProperty<bool>("expanded", BindingFlags.Instance | BindingFlags.Public);
			property_packageItems = CreateProperty("packageItems", BindingFlags.Instance | BindingFlags.Public);
			property_groupContainer = CreateProperty<VisualElement>("groupContainer", BindingFlags.Instance | BindingFlags.Public);
			property_headerContainer = CreateProperty<VisualElement>("headerContainer", BindingFlags.Instance | BindingFlags.Public);
			property_headerCaret = CreateProperty<Toggle>("headerCaret", BindingFlags.Instance | BindingFlags.NonPublic);
			method_Contains_1 = CreateMethod("Contains", BindingFlags.Instance | BindingFlags.Public, typeof(ISelectableItem));
			method_RefreshHeaderVisibility_1 = CreateMethod("RefreshHeaderVisibility", BindingFlags.Instance | BindingFlags.Public, null);
			method_AddPackageItem_1 = CreateMethod("AddPackageItem", BindingFlags.Instance | BindingFlags.NonPublic, typeof(IPackage),typeof(VisualState));
			method_AddPackageItem_2 = CreateMethod("AddPackageItem", BindingFlags.Instance | BindingFlags.NonPublic, typeof(PackageItem));
			method_ClearPackageItems_1 = CreateMethod("ClearPackageItems", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_RemovePackageItem_1 = CreateMethod("RemovePackageItem", BindingFlags.Instance | BindingFlags.NonPublic, typeof(PackageItem));
		}

		public Action<bool> onGroupToggle
		{
			get => field_onGroupToggle.GetValue();
			set => field_onGroupToggle.SetValue(value);
		}
		public VisualElementCache mCache
		{
			get => new VisualElementCache(field_mCache.GetValue());
			set => field_mCache.SetValue(value.Instance);
		}
		public bool expanded
		{
			get => property_expanded.GetValue();
		}
		public IEnumerable<PackageItem> packageItems
		{
			get => ReflectiveUtilities.GenerateEnumerable<PackageItem>(property_packageItems);
		}
		public VisualElement groupContainer
		{
			get => property_groupContainer.GetValue();
		}
		public VisualElement headerContainer
		{
			get => property_headerContainer.GetValue();
		}
		public Toggle headerCaret
		{
			get => property_headerCaret.GetValue();
		}
		public Boolean Contains(ISelectableItem item)
		{
			return (Boolean) method_Contains_1.Invoke(item);
		}
		public void RefreshHeaderVisibility()
		{
			method_RefreshHeaderVisibility_1.Invoke();
		}
		public PackageItem AddPackageItem(IPackage package,VisualState state)
		{
			return new PackageItem(method_AddPackageItem_1.Invoke(package,state));
		}
		public void AddPackageItem(PackageItem item)
		{
			method_AddPackageItem_2.Invoke(item);
		}
		public void ClearPackageItems()
		{
			method_ClearPackageItems_1.Invoke();
		}
		public void RemovePackageItem(PackageItem item)
		{
			method_RemovePackageItem_1.Invoke(item);
		}
	}
}
