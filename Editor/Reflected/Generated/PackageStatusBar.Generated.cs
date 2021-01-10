// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageStatusBar, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
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
	public sealed partial class PackageStatusBar : ReflectiveVisualElementClass
	{
		private ReflectiveEvent event_OnCheckInternetReachability;
		private ReflectiveField<VisualElement> field_root;
		private ReflectiveField<string> field_LastErrorMessage;
		private ReflectiveField<string> field_LastUpdateTime;
		private ReflectiveField field_operationsInProgress;
		private ReflectiveField<Action> field_OnCheckInternetReachability;
		private ReflectiveProperty property_Cache;
		private ReflectiveProperty<VisualElement> property_LoadingSpinnerContainer;
		private ReflectiveProperty property_LoadingSpinner;
		private ReflectiveProperty<Label> property_ErrorIcon;
		private ReflectiveProperty<Label> property_StatusLabel;
		private ReflectiveMethod method_Setup_1;
		private ReflectiveMethod method_SetUpdateTimeMessage_1;
		private ReflectiveMethod method_UpdateStatusMessage_1;
		private ReflectiveMethod method_OnOperationError_1;
		private ReflectiveMethod method_CheckInternetReachability_1;
		private ReflectiveMethod method_SetStatusMessage_1;
		public PackageStatusBar(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageStatusBar(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			event_OnCheckInternetReachability = CreateEvent("OnCheckInternetReachability", BindingFlags.Instance | BindingFlags.Public);
			field_root = CreateField<VisualElement>("root", BindingFlags.Instance | BindingFlags.NonPublic);
			field_LastErrorMessage = CreateField<string>("LastErrorMessage", BindingFlags.Instance | BindingFlags.NonPublic);
			field_LastUpdateTime = CreateField<string>("LastUpdateTime", BindingFlags.Instance | BindingFlags.NonPublic);
			field_operationsInProgress = CreateField("operationsInProgress", BindingFlags.Instance | BindingFlags.NonPublic);
			field_OnCheckInternetReachability = CreateField<Action>("OnCheckInternetReachability", BindingFlags.Instance | BindingFlags.NonPublic);
			property_Cache = CreateProperty("Cache", BindingFlags.Instance | BindingFlags.NonPublic);
			property_LoadingSpinnerContainer = CreateProperty<VisualElement>("LoadingSpinnerContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_LoadingSpinner = CreateProperty("LoadingSpinner", BindingFlags.Instance | BindingFlags.NonPublic);
			property_ErrorIcon = CreateProperty<Label>("ErrorIcon", BindingFlags.Instance | BindingFlags.NonPublic);
			property_StatusLabel = CreateProperty<Label>("StatusLabel", BindingFlags.Instance | BindingFlags.NonPublic);
			method_Setup_1 = CreateMethod("Setup", BindingFlags.Instance | BindingFlags.Public, typeof(PackageCollection));
			method_SetUpdateTimeMessage_1 = CreateMethod("SetUpdateTimeMessage", BindingFlags.Instance | BindingFlags.Public, typeof(string));
			method_UpdateStatusMessage_1 = CreateMethod("UpdateStatusMessage", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_OnOperationError_1 = CreateMethod("OnOperationError", BindingFlags.Instance | BindingFlags.NonPublic, typeof(Error));
			method_CheckInternetReachability_1 = CreateMethod("CheckInternetReachability", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_SetStatusMessage_1 = CreateMethod("SetStatusMessage", BindingFlags.Instance | BindingFlags.NonPublic, typeof(PackageStatusBar_StatusType),typeof(string));
		}
		partial void Initialize();
		/// <summary>
		/// Event type: System.Action
		/// </summary>
		/// <returns>Delegate to be used for unsubscribing</returns>
		public Delegate SubscribeToOnCheckInternetReachability(Delegate @delegate)
		{
			return event_OnCheckInternetReachability.Subscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action
		/// </summary>
		public void UnsubscribeFromOnCheckInternetReachability(Delegate @delegate)
		{
			event_OnCheckInternetReachability.Unsubscribe(@delegate);
		}
		public VisualElement root
		{
			get => field_root.GetValue();
			set => field_root.SetValue(value);
		}
		public string LastErrorMessage
		{
			get => field_LastErrorMessage.GetValue();
			set => field_LastErrorMessage.SetValue(value);
		}
		public string LastUpdateTime
		{
			get => field_LastUpdateTime.GetValue();
			set => field_LastUpdateTime.SetValue(value);
		}
		public Action OnCheckInternetReachability
		{
			get => field_OnCheckInternetReachability.GetValue();
			set => field_OnCheckInternetReachability.SetValue(value);
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
		public VisualElement LoadingSpinnerContainer
		{
			get => property_LoadingSpinnerContainer.GetValue();
		}
		public LoadingSpinner LoadingSpinner
		{
			get
			{
				object _temp = property_LoadingSpinner.GetValue();
				return _temp == null ? null : new LoadingSpinner(_temp);
			}
		}
		public Label ErrorIcon
		{
			get => property_ErrorIcon.GetValue();
		}
		public Label StatusLabel
		{
			get => property_StatusLabel.GetValue();
		}
		public void Setup(PackageCollection collection)
		{
			method_Setup_1.Invoke(collection);
		}
		public void SetUpdateTimeMessage(string lastUpdateTime)
		{
			method_SetUpdateTimeMessage_1.Invoke(lastUpdateTime);
		}
		public void UpdateStatusMessage()
		{
			method_UpdateStatusMessage_1.Invoke();
		}
		public void OnOperationError(Error error)
		{
			method_OnOperationError_1.Invoke(error);
		}
		public void CheckInternetReachability()
		{
			method_CheckInternetReachability_1.Invoke();
		}
		public void SetStatusMessage(PackageStatusBar_StatusType status,string message)
		{
			method_SetStatusMessage_1.Invoke((int)status,message);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageStatusBar, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
