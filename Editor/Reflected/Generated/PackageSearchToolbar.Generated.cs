// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageSearchToolbar, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
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
	public sealed partial class PackageSearchToolbar : ReflectiveVisualElementClass
	{
		private ReflectiveEvent event_OnFocusChange;
		private ReflectiveEvent event_OnSearchChange;
		private ReflectiveField<string> field_kPlaceHolder;
		private ReflectiveField<Action> field_OnFocusChange;
		private ReflectiveField<Action<string>> field_OnSearchChange;
		private ReflectiveField<string> field_searchText;
		private ReflectiveField<bool> field_showingPlaceHolder;
		private ReflectiveField<VisualElement> field_root;
		private ReflectiveProperty property_Cache;
		private ReflectiveProperty<TextField> property_SearchTextField;
		private ReflectiveProperty<Button> property_SearchCancelButton;
		private ReflectiveMethod method_GrabFocus_1;
		private ReflectiveMethod method_SetEnabled_1;
		private ReflectiveMethod method_SetSearchText_1;
		private ReflectiveMethod method_OnSearchTextFieldChange_1;
		private ReflectiveMethod method_OnSearchTextFieldFocus_1;
		private ReflectiveMethod method_OnSearchTextFieldFocusOut_1;
		private ReflectiveMethod method_SearchCancelButtonClick_1;
		private ReflectiveMethod method_OnEnterPanel_1;
		private ReflectiveMethod method_OnLeavePanel_1;
		private ReflectiveMethod method_OnKeyDownShortcut_1;
		public PackageSearchToolbar(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageSearchToolbar(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			event_OnFocusChange = CreateEvent("OnFocusChange", BindingFlags.Instance | BindingFlags.Public);
			event_OnSearchChange = CreateEvent("OnSearchChange", BindingFlags.Instance | BindingFlags.Public);
			field_kPlaceHolder = CreateField<string>("kPlaceHolder", BindingFlags.Static | BindingFlags.NonPublic);
			field_OnFocusChange = CreateField<Action>("OnFocusChange", BindingFlags.Instance | BindingFlags.NonPublic);
			field_OnSearchChange = CreateField<Action<string>>("OnSearchChange", BindingFlags.Instance | BindingFlags.NonPublic);
			field_searchText = CreateField<string>("searchText", BindingFlags.Instance | BindingFlags.NonPublic);
			field_showingPlaceHolder = CreateField<bool>("showingPlaceHolder", BindingFlags.Instance | BindingFlags.NonPublic);
			field_root = CreateField<VisualElement>("root", BindingFlags.Instance | BindingFlags.NonPublic);
			property_Cache = CreateProperty("Cache", BindingFlags.Instance | BindingFlags.NonPublic);
			property_SearchTextField = CreateProperty<TextField>("SearchTextField", BindingFlags.Instance | BindingFlags.NonPublic);
			property_SearchCancelButton = CreateProperty<Button>("SearchCancelButton", BindingFlags.Instance | BindingFlags.NonPublic);
			method_GrabFocus_1 = CreateMethod("GrabFocus", BindingFlags.Instance | BindingFlags.Public, null);
			method_SetEnabled_1 = CreateMethod("SetEnabled", BindingFlags.Instance | BindingFlags.Public, typeof(bool));
			method_SetSearchText_1 = CreateMethod("SetSearchText", BindingFlags.Instance | BindingFlags.Public, typeof(string));
			method_OnSearchTextFieldChange_1 = CreateMethod("OnSearchTextFieldChange", BindingFlags.Instance | BindingFlags.NonPublic, typeof(ChangeEvent<string>));
			method_OnSearchTextFieldFocus_1 = CreateMethod("OnSearchTextFieldFocus", BindingFlags.Instance | BindingFlags.NonPublic, typeof(FocusEvent));
			method_OnSearchTextFieldFocusOut_1 = CreateMethod("OnSearchTextFieldFocusOut", BindingFlags.Instance | BindingFlags.NonPublic, typeof(FocusOutEvent));
			method_SearchCancelButtonClick_1 = CreateMethod("SearchCancelButtonClick", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_OnEnterPanel_1 = CreateMethod("OnEnterPanel", BindingFlags.Instance | BindingFlags.NonPublic, typeof(AttachToPanelEvent));
			method_OnLeavePanel_1 = CreateMethod("OnLeavePanel", BindingFlags.Instance | BindingFlags.NonPublic, typeof(DetachFromPanelEvent));
			method_OnKeyDownShortcut_1 = CreateMethod("OnKeyDownShortcut", BindingFlags.Instance | BindingFlags.NonPublic, typeof(KeyDownEvent));
		}
		partial void Initialize();
		/// <summary>
		/// Event type: System.Action
		/// </summary>
		/// <returns>Delegate to be used for unsubscribing</returns>
		public Delegate SubscribeToOnFocusChange(Delegate @delegate)
		{
			return event_OnFocusChange.Subscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action
		/// </summary>
		public void UnsubscribeFromOnFocusChange(Delegate @delegate)
		{
			event_OnFocusChange.Unsubscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<string>
		/// </summary>
		/// <returns>Delegate to be used for unsubscribing</returns>
		public Delegate SubscribeToOnSearchChange(Delegate @delegate)
		{
			return event_OnSearchChange.Subscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<string>
		/// </summary>
		public void UnsubscribeFromOnSearchChange(Delegate @delegate)
		{
			event_OnSearchChange.Unsubscribe(@delegate);
		}
		public string kPlaceHolder
		{
			get => field_kPlaceHolder.GetValue();
			set => field_kPlaceHolder.SetValue(value);
		}
		public Action OnFocusChange
		{
			get => field_OnFocusChange.GetValue();
			set => field_OnFocusChange.SetValue(value);
		}
		public Action<string> OnSearchChange
		{
			get => field_OnSearchChange.GetValue();
			set => field_OnSearchChange.SetValue(value);
		}
		public string searchText
		{
			get => field_searchText.GetValue();
			set => field_searchText.SetValue(value);
		}
		public bool showingPlaceHolder
		{
			get => field_showingPlaceHolder.GetValue();
			set => field_showingPlaceHolder.SetValue(value);
		}
		public VisualElement root
		{
			get => field_root.GetValue();
			set => field_root.SetValue(value);
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
		public TextField SearchTextField
		{
			get => property_SearchTextField.GetValue();
		}
		public Button SearchCancelButton
		{
			get => property_SearchCancelButton.GetValue();
		}
		public void GrabFocus()
		{
			method_GrabFocus_1.Invoke();
		}
		public void SetEnabled(bool enable)
		{
			method_SetEnabled_1.Invoke(enable);
		}
		public void SetSearchText(string text)
		{
			method_SetSearchText_1.Invoke(text);
		}
		public void OnSearchTextFieldChange(ChangeEvent<string> evt)
		{
			method_OnSearchTextFieldChange_1.Invoke(evt);
		}
		public void OnSearchTextFieldFocus(FocusEvent evt)
		{
			method_OnSearchTextFieldFocus_1.Invoke(evt);
		}
		public void OnSearchTextFieldFocusOut(FocusOutEvent evt)
		{
			method_OnSearchTextFieldFocusOut_1.Invoke(evt);
		}
		public void SearchCancelButtonClick()
		{
			method_SearchCancelButtonClick_1.Invoke();
		}
		public void OnEnterPanel(AttachToPanelEvent evt)
		{
			method_OnEnterPanel_1.Invoke(evt);
		}
		public void OnLeavePanel(DetachFromPanelEvent evt)
		{
			method_OnLeavePanel_1.Invoke(evt);
		}
		public void OnKeyDownShortcut(KeyDownEvent evt)
		{
			method_OnKeyDownShortcut_1.Invoke(evt);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageSearchToolbar, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
