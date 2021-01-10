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
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.StyleSheets;
using UnityEngine.UIElements.UIR;
using UnityEngine.Yoga;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageDependencies : ReflectiveClass
	{
		private ReflectiveField<VisualElement> field_root;
		private ReflectiveField field_Collection;
		private ReflectiveProperty property_Cache;
		private ReflectiveProperty<VisualElement> property_DependenciesContainer;
		private ReflectiveProperty<Label> property_NoDependencies;
		private ReflectiveProperty<VisualElement> property_DependenciesNames;
		private ReflectiveProperty<VisualElement> property_DependenciesVersions;
		private ReflectiveProperty<VisualElement> property_DependenciesStatuses;
		private ReflectiveMethod method_BuildLabel_1;
		private ReflectiveMethod method_BuildNameText_1;
		private ReflectiveMethod method_BuildStatusText_1;
		private ReflectiveMethod method_SetCollection_1;
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
			field_root = CreateField<VisualElement>("root", BindingFlags.Instance | BindingFlags.NonPublic);
			field_Collection = CreateField("Collection", BindingFlags.Instance | BindingFlags.NonPublic);
			property_Cache = CreateProperty("Cache", BindingFlags.Instance | BindingFlags.NonPublic);
			property_DependenciesContainer = CreateProperty<VisualElement>("DependenciesContainer", BindingFlags.Instance | BindingFlags.NonPublic);
			property_NoDependencies = CreateProperty<Label>("NoDependencies", BindingFlags.Instance | BindingFlags.NonPublic);
			property_DependenciesNames = CreateProperty<VisualElement>("DependenciesNames", BindingFlags.Instance | BindingFlags.NonPublic);
			property_DependenciesVersions = CreateProperty<VisualElement>("DependenciesVersions", BindingFlags.Instance | BindingFlags.NonPublic);
			property_DependenciesStatuses = CreateProperty<VisualElement>("DependenciesStatuses", BindingFlags.Instance | BindingFlags.NonPublic);
			method_BuildLabel_1 = CreateMethod("BuildLabel", BindingFlags.Static | BindingFlags.NonPublic, typeof(string),typeof(string));
			method_BuildNameText_1 = CreateMethod("BuildNameText", BindingFlags.Instance | BindingFlags.NonPublic, typeof(DependencyInfo));
			method_BuildStatusText_1 = CreateMethod("BuildStatusText", BindingFlags.Instance | BindingFlags.NonPublic, typeof(DependencyInfo));
			method_SetCollection_1 = CreateMethod("SetCollection", BindingFlags.Instance | BindingFlags.Public, typeof(PackageCollection));
			method_SetDependencies_1 = CreateMethod("SetDependencies", BindingFlags.Instance | BindingFlags.Public, typeof(DependencyInfo[]));
			method_ClearDependencies_1 = CreateMethod("ClearDependencies", BindingFlags.Instance | BindingFlags.NonPublic, null);
		}
		partial void Initialize();
		public VisualElement root
		{
			get => field_root.GetValue();
			set => field_root.SetValue(value);
		}
		public PackageCollection Collection
		{
			get
			{
				object _temp = field_Collection.GetValue();
				return _temp == null ? null : new PackageCollection(_temp);
			}
			set => field_Collection.SetValue(value.Instance);
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
		public VisualElement DependenciesContainer
		{
			get => property_DependenciesContainer.GetValue();
		}
		public Label NoDependencies
		{
			get => property_NoDependencies.GetValue();
		}
		public VisualElement DependenciesNames
		{
			get => property_DependenciesNames.GetValue();
		}
		public VisualElement DependenciesVersions
		{
			get => property_DependenciesVersions.GetValue();
		}
		public VisualElement DependenciesStatuses
		{
			get => property_DependenciesStatuses.GetValue();
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
		public void SetCollection(PackageCollection collection)
		{
			method_SetCollection_1.Invoke(collection);
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
