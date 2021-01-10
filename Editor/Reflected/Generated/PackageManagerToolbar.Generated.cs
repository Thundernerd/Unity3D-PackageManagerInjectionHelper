// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageManagerToolbar, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.StyleSheets;
using UnityEngine.UIElements.UIR;
using UnityEngine.Yoga;
using Object = UnityEngine.Object;

namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageManagerToolbar : ReflectiveClass
	{
		private ReflectiveEvent event_OnFilterChange;
		private ReflectiveEvent event_OnTogglePreviewChange;
		private ReflectiveEvent event_OnToggleDependenciesChange;
		private ReflectiveField<VisualElement> field_root;
		private ReflectiveField field_OnFilterChange;
		private ReflectiveField<Action> field_OnTogglePreviewChange;
		private ReflectiveField<Action> field_OnToggleDependenciesChange;
		private ReflectiveField field_selectedFilter;
		private ReflectiveField field_AddFromIdField;
		private ReflectiveProperty property_Cache;
		private ReflectiveProperty<Label> property_AddButton;
		private ReflectiveProperty<Label> property_FilterButton;
		private ReflectiveProperty<Label> property_AdvancedButton;
		private ReflectiveProperty property_SearchToolbar;
		private ReflectiveProperty property_AddFromIdField;
		private ReflectiveMethod method_GrabFocus_1;
		private ReflectiveMethod method_SetEnabled_1;
		private ReflectiveMethod method_GetFilterDisplayName_1;
		private ReflectiveMethod method_SetFilter_1;
		private ReflectiveMethod method_OnAddButtonMouseDown_1;
		private ReflectiveMethod method_OnFilterButtonMouseDown_1;
		private ReflectiveMethod method_OnAdvancedButtonMouseDown_1;
		private ReflectiveMethod method_ToggleDependencies_1;
		private ReflectiveMethod method_TogglePreviewPackages_1;
		public PackageManagerToolbar(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageManagerToolbar(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			event_OnFilterChange = CreateEvent("OnFilterChange", BindingFlags.Instance | BindingFlags.Public);
			event_OnTogglePreviewChange = CreateEvent("OnTogglePreviewChange", BindingFlags.Instance | BindingFlags.Public);
			event_OnToggleDependenciesChange = CreateEvent("OnToggleDependenciesChange", BindingFlags.Static | BindingFlags.Public);
			field_root = CreateField<VisualElement>("root", BindingFlags.Instance | BindingFlags.NonPublic);
			field_OnFilterChange = CreateField("OnFilterChange", BindingFlags.Instance | BindingFlags.NonPublic);
			field_OnTogglePreviewChange = CreateField<Action>("OnTogglePreviewChange", BindingFlags.Instance | BindingFlags.NonPublic);
			field_OnToggleDependenciesChange = CreateField<Action>("OnToggleDependenciesChange", BindingFlags.Static | BindingFlags.NonPublic);
			field_selectedFilter = CreateField("selectedFilter", BindingFlags.Instance | BindingFlags.NonPublic);
			field_AddFromIdField = CreateField("AddFromIdField", BindingFlags.Instance | BindingFlags.NonPublic);
			property_Cache = CreateProperty("Cache", BindingFlags.Instance | BindingFlags.NonPublic);
			property_AddButton = CreateProperty<Label>("AddButton", BindingFlags.Instance | BindingFlags.NonPublic);
			property_FilterButton = CreateProperty<Label>("FilterButton", BindingFlags.Instance | BindingFlags.NonPublic);
			property_AdvancedButton = CreateProperty<Label>("AdvancedButton", BindingFlags.Instance | BindingFlags.NonPublic);
			property_SearchToolbar = CreateProperty("SearchToolbar", BindingFlags.Instance | BindingFlags.NonPublic);
			property_AddFromIdField = CreateProperty("AddFromIdField", BindingFlags.Instance | BindingFlags.NonPublic);
			method_GrabFocus_1 = CreateMethod("GrabFocus", BindingFlags.Instance | BindingFlags.Public, null);
			method_SetEnabled_1 = CreateMethod("SetEnabled", BindingFlags.Instance | BindingFlags.Public, typeof(bool));
			method_GetFilterDisplayName_1 = CreateMethod("GetFilterDisplayName", BindingFlags.Static | BindingFlags.NonPublic, typeof(PackageFilter));
			method_SetFilter_1 = CreateMethod("SetFilter", BindingFlags.Instance | BindingFlags.Public, typeof(Object));
			method_OnAddButtonMouseDown_1 = CreateMethod("OnAddButtonMouseDown", BindingFlags.Instance | BindingFlags.NonPublic, typeof(MouseDownEvent));
			method_OnFilterButtonMouseDown_1 = CreateMethod("OnFilterButtonMouseDown", BindingFlags.Instance | BindingFlags.NonPublic, typeof(MouseDownEvent));
			method_OnAdvancedButtonMouseDown_1 = CreateMethod("OnAdvancedButtonMouseDown", BindingFlags.Instance | BindingFlags.NonPublic, typeof(MouseDownEvent));
			method_ToggleDependencies_1 = CreateMethod("ToggleDependencies", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_TogglePreviewPackages_1 = CreateMethod("TogglePreviewPackages", BindingFlags.Instance | BindingFlags.NonPublic, null);
		}
		partial void Initialize();
		/// <summary>
		/// Event type: System.Action<PackageFilter>
		/// </summary>
		/// <returns>Delegate to be used for unsubscribing</returns>
		public Delegate SubscribeToOnFilterChange(Delegate @delegate)
		{
			return event_OnFilterChange.Subscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<PackageFilter>
		/// </summary>
		public void UnsubscribeFromOnFilterChange(Delegate @delegate)
		{
			event_OnFilterChange.Unsubscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action
		/// </summary>
		/// <returns>Delegate to be used for unsubscribing</returns>
		public Delegate SubscribeToOnTogglePreviewChange(Delegate @delegate)
		{
			return event_OnTogglePreviewChange.Subscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action
		/// </summary>
		public void UnsubscribeFromOnTogglePreviewChange(Delegate @delegate)
		{
			event_OnTogglePreviewChange.Unsubscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action
		/// </summary>
		/// <returns>Delegate to be used for unsubscribing</returns>
		public Delegate SubscribeToOnToggleDependenciesChange(Delegate @delegate)
		{
			return event_OnToggleDependenciesChange.Subscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action
		/// </summary>
		public void UnsubscribeFromOnToggleDependenciesChange(Delegate @delegate)
		{
			event_OnToggleDependenciesChange.Unsubscribe(@delegate);
		}
		public VisualElement root
		{
			get => field_root.GetValue();
			set => field_root.SetValue(value);
		}
		public Action OnTogglePreviewChange
		{
			get => field_OnTogglePreviewChange.GetValue();
			set => field_OnTogglePreviewChange.SetValue(value);
		}
		public Action OnToggleDependenciesChange
		{
			get => field_OnToggleDependenciesChange.GetValue();
			set => field_OnToggleDependenciesChange.SetValue(value);
		}
		public PackageFilter selectedFilter
		{
			get
			{
				object _temp = (int)field_selectedFilter.GetValue();
				return (PackageFilter)_temp;
			}
			set => field_selectedFilter.SetValue((int)value);
		}
		public PackageAddFromIdField AddFromIdField
		{
			get
			{
				object _temp = field_AddFromIdField.GetValue();
				return _temp == null ? null : new PackageAddFromIdField(_temp);
			}
			set => field_AddFromIdField.SetValue(value.Instance);
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
		public Label AddButton
		{
			get => property_AddButton.GetValue();
		}
		public Label FilterButton
		{
			get => property_FilterButton.GetValue();
		}
		public Label AdvancedButton
		{
			get => property_AdvancedButton.GetValue();
		}
		public PackageSearchToolbar SearchToolbar
		{
			get
			{
				object _temp = property_SearchToolbar.GetValue();
				return _temp == null ? null : new PackageSearchToolbar(_temp);
			}
		}
		public void GrabFocus()
		{
			method_GrabFocus_1.Invoke();
		}
		public void SetEnabled(bool enable)
		{
			method_SetEnabled_1.Invoke(enable);
		}
		public string GetFilterDisplayName(PackageFilter filter)
		{
			return (string) method_GetFilterDisplayName_1.Invoke((int)filter);
		}
		public void SetFilter(Object obj)
		{
			method_SetFilter_1.Invoke(obj);
		}
		public void OnAddButtonMouseDown(MouseDownEvent evt)
		{
			method_OnAddButtonMouseDown_1.Invoke(evt);
		}
		public void OnFilterButtonMouseDown(MouseDownEvent evt)
		{
			method_OnFilterButtonMouseDown_1.Invoke(evt);
		}
		public void OnAdvancedButtonMouseDown(MouseDownEvent evt)
		{
			method_OnAdvancedButtonMouseDown_1.Invoke(evt);
		}
		public void ToggleDependencies()
		{
			method_ToggleDependencies_1.Invoke();
		}
		public void TogglePreviewPackages()
		{
			method_TogglePreviewPackages_1.Invoke();
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageManagerToolbar, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
