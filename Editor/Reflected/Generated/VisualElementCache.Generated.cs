// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.VisualElementCache, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
using UnityEngine.UIElements;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class VisualElementCache : ReflectiveClass
	{
		private ReflectiveField<Dictionary<string, VisualElement>> field_Cache;
		private ReflectiveField<VisualElement> field_Root;
		private ReflectiveMethod method_Create_1;
		private ReflectiveMethod method_Get_1;
		public VisualElementCache(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public VisualElementCache(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_Cache = CreateField<Dictionary<string, VisualElement>>("Cache", BindingFlags.Instance | BindingFlags.NonPublic);
			field_Root = CreateField<VisualElement>("Root", BindingFlags.Instance | BindingFlags.NonPublic);
			method_Create_1 = CreateMethod("Create", BindingFlags.Instance | BindingFlags.Public, typeof(string));
			method_Get_1 = CreateMethod("Get", BindingFlags.Instance | BindingFlags.Public, typeof(string));
		}
		partial void Initialize();
		public Dictionary<string, VisualElement> Cache
		{
			get => field_Cache.GetValue();
			set => field_Cache.SetValue(value);
		}
		public VisualElement Root
		{
			get => field_Root.GetValue();
			set => field_Root.SetValue(value);
		}
		public T Create<T>(string query)
		{
			return (T) method_Create_1.Invoke(query);
		}
		public T Get<T>(string query)
		{
			return (T) method_Get_1.Invoke(query);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.VisualElementCache, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
