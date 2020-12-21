// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.SplitView, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
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
	public sealed partial class SplitView : ReflectiveClass
	{
		private ReflectiveEvent event_onSizeChanged;
		private ReflectiveField<string> field_sClassName;
		private ReflectiveField<string> field_sContentContainerClassName;
		private ReflectiveField<string> field_sHandleDragLineClassName;
		private ReflectiveField<string> field_sHandleDragLineAnchorClassName;
		private ReflectiveField<Action<float>> field_onSizeChanged;
		private ReflectiveField<VisualElement> field_mLeftPane;
		private ReflectiveField<VisualElement> field_mRightPane;
		private ReflectiveField<VisualElement> field_mDragLine;
		private ReflectiveField<VisualElement> field_mDragLineAnchor;
		private ReflectiveField<VisualElement> field_mContent;
		private ReflectiveField<float> field_mMinLeftWidth;
		private ReflectiveField<float> field_mMaxLeftWidth;
		private ReflectiveField<float> field_mMinRightWidth;
		private ReflectiveField<float> field_mInitialLeftWidth;
		private ReflectiveField field_mAnchorManipulator;
		private ReflectiveField<float> field_mLeftWidth;
		private ReflectiveProperty<float> property_leftWidth;
		private ReflectiveProperty<VisualElement> property_contentContainer;
		private ReflectiveMethod method_Init_1;
		private ReflectiveMethod method_OnPostDisplaySetup_1;
		private ReflectiveMethod method_PostDisplaySetup_1;
		private ReflectiveMethod method_OnSizeChange_1;
		public SplitView(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public SplitView(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			event_onSizeChanged = CreateEvent("onSizeChanged", BindingFlags.Instance | BindingFlags.Public);
			field_sClassName = CreateField<string>("sClassName", BindingFlags.Static | BindingFlags.NonPublic);
			field_sContentContainerClassName = CreateField<string>("sContentContainerClassName", BindingFlags.Static | BindingFlags.NonPublic);
			field_sHandleDragLineClassName = CreateField<string>("sHandleDragLineClassName", BindingFlags.Static | BindingFlags.NonPublic);
			field_sHandleDragLineAnchorClassName = CreateField<string>("sHandleDragLineAnchorClassName", BindingFlags.Static | BindingFlags.NonPublic);
			field_onSizeChanged = CreateField<Action<float>>("onSizeChanged", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mLeftPane = CreateField<VisualElement>("mLeftPane", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mRightPane = CreateField<VisualElement>("mRightPane", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mDragLine = CreateField<VisualElement>("mDragLine", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mDragLineAnchor = CreateField<VisualElement>("mDragLineAnchor", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mContent = CreateField<VisualElement>("mContent", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mMinLeftWidth = CreateField<float>("mMinLeftWidth", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mMaxLeftWidth = CreateField<float>("mMaxLeftWidth", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mMinRightWidth = CreateField<float>("mMinRightWidth", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mInitialLeftWidth = CreateField<float>("mInitialLeftWidth", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mAnchorManipulator = CreateField("mAnchorManipulator", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mLeftWidth = CreateField<float>("mLeftWidth", BindingFlags.Instance | BindingFlags.NonPublic);
			property_leftWidth = CreateProperty<float>("leftWidth", BindingFlags.Instance | BindingFlags.Public);
			property_contentContainer = CreateProperty<VisualElement>("contentContainer", BindingFlags.Instance | BindingFlags.Public);
			method_Init_1 = CreateMethod("Init", BindingFlags.Instance | BindingFlags.NonPublic, typeof(float));
			method_OnPostDisplaySetup_1 = CreateMethod("OnPostDisplaySetup", BindingFlags.Instance | BindingFlags.NonPublic, typeof(GeometryChangedEvent));
			method_PostDisplaySetup_1 = CreateMethod("PostDisplaySetup", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_OnSizeChange_1 = CreateMethod("OnSizeChange", BindingFlags.Instance | BindingFlags.NonPublic, typeof(GeometryChangedEvent));
		}
		partial void Initialize();
		/// <summary>
		/// Event type: System.Action<float>
		/// </summary>
		/// <returns>Delegate to be used for unsubscribing</returns>
		public Delegate SubscribeToOnSizeChanged(Delegate @delegate)
		{
			return event_onSizeChanged.Subscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<float>
		/// </summary>
		public void UnsubscribeFromOnSizeChanged(Delegate @delegate)
		{
			event_onSizeChanged.Unsubscribe(@delegate);
		}
		public string sClassName
		{
			get => field_sClassName.GetValue();
			set => field_sClassName.SetValue(value);
		}
		public string sContentContainerClassName
		{
			get => field_sContentContainerClassName.GetValue();
			set => field_sContentContainerClassName.SetValue(value);
		}
		public string sHandleDragLineClassName
		{
			get => field_sHandleDragLineClassName.GetValue();
			set => field_sHandleDragLineClassName.SetValue(value);
		}
		public string sHandleDragLineAnchorClassName
		{
			get => field_sHandleDragLineAnchorClassName.GetValue();
			set => field_sHandleDragLineAnchorClassName.SetValue(value);
		}
		public Action<float> onSizeChanged
		{
			get => field_onSizeChanged.GetValue();
			set => field_onSizeChanged.SetValue(value);
		}
		public VisualElement mLeftPane
		{
			get => field_mLeftPane.GetValue();
			set => field_mLeftPane.SetValue(value);
		}
		public VisualElement mRightPane
		{
			get => field_mRightPane.GetValue();
			set => field_mRightPane.SetValue(value);
		}
		public VisualElement mDragLine
		{
			get => field_mDragLine.GetValue();
			set => field_mDragLine.SetValue(value);
		}
		public VisualElement mDragLineAnchor
		{
			get => field_mDragLineAnchor.GetValue();
			set => field_mDragLineAnchor.SetValue(value);
		}
		public VisualElement mContent
		{
			get => field_mContent.GetValue();
			set => field_mContent.SetValue(value);
		}
		public float mMinLeftWidth
		{
			get => field_mMinLeftWidth.GetValue();
			set => field_mMinLeftWidth.SetValue(value);
		}
		public float mMaxLeftWidth
		{
			get => field_mMaxLeftWidth.GetValue();
			set => field_mMaxLeftWidth.SetValue(value);
		}
		public float mMinRightWidth
		{
			get => field_mMinRightWidth.GetValue();
			set => field_mMinRightWidth.SetValue(value);
		}
		public float mInitialLeftWidth
		{
			get => field_mInitialLeftWidth.GetValue();
			set => field_mInitialLeftWidth.SetValue(value);
		}
		public SplitView_AnchorManipulator mAnchorManipulator
		{
			get
			{
				object _temp = field_mAnchorManipulator.GetValue();
				return _temp == null ? null : new SplitView_AnchorManipulator(_temp);
			}
			set => field_mAnchorManipulator.SetValue(value.Instance);
		}
		public float mLeftWidth
		{
			get => field_mLeftWidth.GetValue();
			set => field_mLeftWidth.SetValue(value);
		}
		public float leftWidth
		{
			get => property_leftWidth.GetValue();
			set => property_leftWidth.SetValue(value);
		}
		public VisualElement contentContainer
		{
			get => property_contentContainer.GetValue();
		}
		public void Init(float fixedPaneInitialDimension)
		{
			method_Init_1.Invoke(fixedPaneInitialDimension);
		}
		public void OnPostDisplaySetup(GeometryChangedEvent evt)
		{
			method_OnPostDisplaySetup_1.Invoke(evt);
		}
		public void PostDisplaySetup()
		{
			method_PostDisplaySetup_1.Invoke();
		}
		public void OnSizeChange(GeometryChangedEvent evt)
		{
			method_OnSizeChange_1.Invoke(evt);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.SplitView, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
