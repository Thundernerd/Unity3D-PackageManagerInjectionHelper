// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.SampleJsonHelper, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
using System.Collections.Generic;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class SampleJsonHelper : ReflectiveClass
	{
		private ReflectiveField<string> field_displayName;
		private ReflectiveField<string> field_description;
		private ReflectiveField<string> field_path;
		private ReflectiveField<string> field_resolvedPath;
		private ReflectiveField<string> field_importPath;
		private ReflectiveField<bool> field_interactiveImport;
		private ReflectiveMethod method_LoadSamplesFromPackageJson_1;
		public SampleJsonHelper(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public SampleJsonHelper(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_displayName = CreateField<string>("displayName", BindingFlags.Instance | BindingFlags.Public);
			field_description = CreateField<string>("description", BindingFlags.Instance | BindingFlags.Public);
			field_path = CreateField<string>("path", BindingFlags.Instance | BindingFlags.Public);
			field_resolvedPath = CreateField<string>("resolvedPath", BindingFlags.Instance | BindingFlags.Public);
			field_importPath = CreateField<string>("importPath", BindingFlags.Instance | BindingFlags.Public);
			field_interactiveImport = CreateField<bool>("interactiveImport", BindingFlags.Instance | BindingFlags.Public);
			method_LoadSamplesFromPackageJson_1 = CreateMethod("LoadSamplesFromPackageJson", BindingFlags.Static | BindingFlags.NonPublic, typeof(string));
		}
		partial void Initialize();
		public string displayName
		{
			get => field_displayName.GetValue();
			set => field_displayName.SetValue(value);
		}
		public string description
		{
			get => field_description.GetValue();
			set => field_description.SetValue(value);
		}
		public string path
		{
			get => field_path.GetValue();
			set => field_path.SetValue(value);
		}
		public string resolvedPath
		{
			get => field_resolvedPath.GetValue();
			set => field_resolvedPath.SetValue(value);
		}
		public string importPath
		{
			get => field_importPath.GetValue();
			set => field_importPath.SetValue(value);
		}
		public bool interactiveImport
		{
			get => field_interactiveImport.GetValue();
			set => field_interactiveImport.SetValue(value);
		}
		public List<SampleJsonHelper> LoadSamplesFromPackageJson(string packagePath)
		{
			return (List<SampleJsonHelper>) Utilities.GenerateEnumerable<SampleJsonHelper>(method_LoadSamplesFromPackageJson_1.Invoke(packagePath));
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.SampleJsonHelper, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
