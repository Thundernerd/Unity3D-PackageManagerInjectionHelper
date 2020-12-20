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
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.StyleSheets;
using UnityEngine.UIElements.UIR;
using UnityEngine.Yoga;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageStatusBar : ReflectiveClass
	{
		private ReflectiveField<string> field_kOfflineErrorMessage;
		private ReflectiveField<string[]> field_mLastErrorMessages;
		private ReflectiveProperty property_cache;
		private ReflectiveProperty<Label> property_errorIcon;
		private ReflectiveProperty<Label> property_statusLabel;
		private ReflectiveProperty<Button> property_refreshButton;
		private ReflectiveMethod method_OnEnable_1;
		private ReflectiveMethod method_OnDisable_1;
		private ReflectiveMethod method_OnInternetReachabilityChange_1;
		private ReflectiveMethod method_GetUpdateTimeLabel_1;
		private ReflectiveMethod method_SetUpdateTimeLabel_1;
		private ReflectiveMethod method_UpdateStatusMessage_1;
		private ReflectiveMethod method_SetStatusMessage_1;

		public PackageStatusBar(object instance) : base(instance)
		{
			field_kOfflineErrorMessage = CreateField<string>("kOfflineErrorMessage", BindingFlags.Static | BindingFlags.NonPublic);
			field_mLastErrorMessages = CreateField<string[]>("mLastErrorMessages", BindingFlags.Instance | BindingFlags.NonPublic);
			property_cache = CreateProperty("cache", BindingFlags.Instance | BindingFlags.NonPublic);
			property_errorIcon = CreateProperty<Label>("errorIcon", BindingFlags.Instance | BindingFlags.NonPublic);
			property_statusLabel = CreateProperty<Label>("statusLabel", BindingFlags.Instance | BindingFlags.NonPublic);
			property_refreshButton = CreateProperty<Button>("refreshButton", BindingFlags.Instance | BindingFlags.NonPublic);
			method_OnEnable_1 = CreateMethod("OnEnable", BindingFlags.Instance | BindingFlags.Public, null);
			method_OnDisable_1 = CreateMethod("OnDisable", BindingFlags.Instance | BindingFlags.Public, null);
			method_OnInternetReachabilityChange_1 = CreateMethod("OnInternetReachabilityChange", BindingFlags.Instance | BindingFlags.NonPublic, typeof(bool));
			method_GetUpdateTimeLabel_1 = CreateMethod("GetUpdateTimeLabel", BindingFlags.Static | BindingFlags.NonPublic, typeof(long));
			method_SetUpdateTimeLabel_1 = CreateMethod("SetUpdateTimeLabel", BindingFlags.Instance | BindingFlags.NonPublic, typeof(string));
			method_UpdateStatusMessage_1 = CreateMethod("UpdateStatusMessage", BindingFlags.Instance | BindingFlags.NonPublic, typeof(PackageFilterTab));
			method_SetStatusMessage_1 = CreateMethod("SetStatusMessage", BindingFlags.Instance | BindingFlags.NonPublic, typeof(PackageStatusBar.StatusType),typeof(string));
		}

		public string kOfflineErrorMessage
		{
			get => field_kOfflineErrorMessage.GetValue();
			set => field_kOfflineErrorMessage.SetValue(value);
		}
		public string[] mLastErrorMessages
		{
			get => field_mLastErrorMessages.GetValue();
			set => field_mLastErrorMessages.SetValue(value);
		}
		public VisualElementCache cache
		{
			get => new VisualElementCache(property_cache.GetValue());
			set => property_cache.SetValue(value.Instance);
		}
		public Label errorIcon
		{
			get => property_errorIcon.GetValue();
		}
		public Label statusLabel
		{
			get => property_statusLabel.GetValue();
		}
		public Button refreshButton
		{
			get => property_refreshButton.GetValue();
		}
		public void OnEnable()
		{
			method_OnEnable_1.Invoke();
		}
		public void OnDisable()
		{
			method_OnDisable_1.Invoke();
		}
		public void OnInternetReachabilityChange(bool value)
		{
			method_OnInternetReachabilityChange_1.Invoke(value);
		}
		public String GetUpdateTimeLabel(long timestamp)
		{
			return (String) method_GetUpdateTimeLabel_1.Invoke(timestamp);
		}
		public void SetUpdateTimeLabel(string lastUpdateTime)
		{
			method_SetUpdateTimeLabel_1.Invoke(lastUpdateTime);
		}
		public void UpdateStatusMessage(PackageFilterTab tab)
		{
			method_UpdateStatusMessage_1.Invoke((int)tab);
		}
		public void SetStatusMessage(PackageStatusBar.StatusType status,string message)
		{
			method_SetStatusMessage_1.Invoke((int)status,message);
		}
	}
}
