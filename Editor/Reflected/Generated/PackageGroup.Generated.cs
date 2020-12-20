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
		private ReflectiveEvent event_onGroupToggle;
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
			event_onGroupToggle = CreateEvent("onGroupToggle", BindingFlags.Instance | BindingFlags.Public);
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
		partial void Initialize();
		/// <summary>
		/// Event type: System.Action<bool>
		/// </summary>
		/// <returns>Delegate to be used for unsubscribing</returns>
		public Delegate SubscribeToOnGroupToggle(Delegate @delegate)
		{
			return event_onGroupToggle.Subscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<bool>
		/// </summary>
		public void UnsubscribeFromOnGroupToggle(Delegate @delegate)
		{
			event_onGroupToggle.Unsubscribe(@delegate);
		}
		public Action<bool> onGroupToggle
		{
			get => field_onGroupToggle.GetValue();
			set => field_onGroupToggle.SetValue(value);
		}
		public VisualElementCache mCache
		{
			get
			{
				object _temp = field_mCache.GetValue();
				return _temp == null ? null : new VisualElementCache(_temp);
			}
			set => field_mCache.SetValue(value.Instance);
		}
		public bool expanded
		{
			get => property_expanded.GetValue();
		}
		public IEnumerable<PackageItem> packageItems
		{
			get
			{
				object _temp = property_packageItems.GetValue();
				return _temp == null ? null : Utilities.GenerateEnumerable<PackageItem>(_temp);
			}
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
		public bool Contains(ISelectableItem item)
		{
			return (bool) method_Contains_1.Invoke(item);
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
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageGroup, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
