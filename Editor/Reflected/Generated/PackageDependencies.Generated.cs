// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageDependencies, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
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
using UnityEditor.PackageManager;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageDependencies : ReflectiveClass
	{
		private ReflectiveProperty property_cache;
		private ReflectiveProperty<VisualElement> property_dependenciesContainer;
		private ReflectiveProperty<Label> property_noDependencies;
		private ReflectiveProperty<VisualElement> property_dependenciesNames;
		private ReflectiveProperty<VisualElement> property_dependenciesVersions;
		private ReflectiveProperty<VisualElement> property_dependenciesStatuses;
		private ReflectiveMethod method_BuildLabel_1;
		private ReflectiveMethod method_BuildNameText_1;
		private ReflectiveMethod method_BuildStatusText_1;
		private ReflectiveMethod method_SetDependencies_1;
		private ReflectiveMethod method_ClearDependencies_1;
		public PackageDependencies(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageDependencies(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			property_cache = CreateProperty("cache", BindingFlags.Instance | BindingFlags.NonPublic);
			property_dependenciesContainer = CreateProperty<VisualElement>("dependenciesContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_noDependencies = CreateProperty<Label>("noDependencies", BindingFlags.Instance | BindingFlags.NonPublic);
			property_dependenciesNames = CreateProperty<VisualElement>("dependenciesNames", BindingFlags.Instance | BindingFlags.NonPublic);
			property_dependenciesVersions = CreateProperty<VisualElement>("dependenciesVersions", BindingFlags.Instance | BindingFlags.NonPublic);
			property_dependenciesStatuses = CreateProperty<VisualElement>("dependenciesStatuses", BindingFlags.Instance | BindingFlags.NonPublic);
			method_BuildLabel_1 = CreateMethod("BuildLabel", BindingFlags.Static | BindingFlags.NonPublic, typeof(string),typeof(string));
			method_BuildNameText_1 = CreateMethod("BuildNameText", BindingFlags.Instance | BindingFlags.NonPublic, typeof(DependencyInfo));
			method_BuildStatusText_1 = CreateMethod("BuildStatusText", BindingFlags.Instance | BindingFlags.NonPublic, typeof(DependencyInfo));
			method_SetDependencies_1 = CreateMethod("SetDependencies", BindingFlags.Instance | BindingFlags.Public, typeof(DependencyInfo[]));
			method_ClearDependencies_1 = CreateMethod("ClearDependencies", BindingFlags.Instance | BindingFlags.NonPublic, null);
		}
		partial void Initialize();
		public VisualElementCache cache
		{
			get
			{
				object _temp = property_cache.GetValue();
				return _temp == null ? null : new VisualElementCache(_temp);
			}
			set => property_cache.SetValue(value.Instance);
		}
		public VisualElement dependenciesContainer
		{
			get => property_dependenciesContainer.GetValue();
		}
		public Label noDependencies
		{
			get => property_noDependencies.GetValue();
		}
		public VisualElement dependenciesNames
		{
			get => property_dependenciesNames.GetValue();
		}
		public VisualElement dependenciesVersions
		{
			get => property_dependenciesVersions.GetValue();
		}
		public VisualElement dependenciesStatuses
		{
			get => property_dependenciesStatuses.GetValue();
		}
		public Label BuildLabel(string text,string clazz)
		{
			return (Label) method_BuildLabel_1.Invoke(text,clazz);
		}
		public string BuildNameText(DependencyInfo dependency)
		{
			return (string) method_BuildNameText_1.Invoke(dependency);
		}
		public string BuildStatusText(DependencyInfo dependency)
		{
			return (string) method_BuildStatusText_1.Invoke(dependency);
		}
		public void SetDependencies(DependencyInfo[] dependencies)
		{
			method_SetDependencies_1.Invoke(dependencies);
		}
		public void ClearDependencies()
		{
			method_ClearDependencies_1.Invoke();
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageDependencies, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
