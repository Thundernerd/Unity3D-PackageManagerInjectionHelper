// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.Sample, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class Sample : ReflectiveClass
	{
		private ReflectiveProperty<string> property_displayName;
		private ReflectiveProperty<string> property_description;
		private ReflectiveProperty<string> property_resolvedPath;
		private ReflectiveProperty<string> property_importPath;
		private ReflectiveProperty<bool> property_interactiveImport;
		private ReflectiveProperty<bool> property_isImported;
		private ReflectiveProperty<List<string>> property_PreviousImports;
		private ReflectiveProperty<string> property_Size;
		private ReflectiveMethod method_FindByPackage_1;
		private ReflectiveMethod method_Import_1;
		public Sample(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public Sample(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			property_displayName = CreateProperty<string>("displayName", BindingFlags.Instance | BindingFlags.Public);
			property_description = CreateProperty<string>("description", BindingFlags.Instance | BindingFlags.Public);
			property_resolvedPath = CreateProperty<string>("resolvedPath", BindingFlags.Instance | BindingFlags.Public);
			property_importPath = CreateProperty<string>("importPath", BindingFlags.Instance | BindingFlags.Public);
			property_interactiveImport = CreateProperty<bool>("interactiveImport", BindingFlags.Instance | BindingFlags.Public);
			property_isImported = CreateProperty<bool>("isImported", BindingFlags.Instance | BindingFlags.Public);
			property_PreviousImports = CreateProperty<List<string>>("PreviousImports", BindingFlags.Instance | BindingFlags.NonPublic);
			property_Size = CreateProperty<string>("Size", BindingFlags.Instance | BindingFlags.NonPublic);
			method_FindByPackage_1 = CreateMethod("FindByPackage", BindingFlags.Static | BindingFlags.Public, typeof(string),typeof(string));
			method_Import_1 = CreateMethod("Import", BindingFlags.Instance | BindingFlags.Public, typeof(Sample_ImportOptions));
		}
		partial void Initialize();
		public string displayName
		{
			get => property_displayName.GetValue();
			set => property_displayName.SetValue(value);
		}
		public string description
		{
			get => property_description.GetValue();
			set => property_description.SetValue(value);
		}
		public string resolvedPath
		{
			get => property_resolvedPath.GetValue();
			set => property_resolvedPath.SetValue(value);
		}
		public string importPath
		{
			get => property_importPath.GetValue();
			set => property_importPath.SetValue(value);
		}
		public bool interactiveImport
		{
			get => property_interactiveImport.GetValue();
			set => property_interactiveImport.SetValue(value);
		}
		public bool isImported
		{
			get => property_isImported.GetValue();
		}
		public List<string> PreviousImports
		{
			get => property_PreviousImports.GetValue();
		}
		public string Size
		{
			get => property_Size.GetValue();
		}
		public IEnumerable<Sample> FindByPackage(string packageName,string packageVersion)
		{
			return (IEnumerable<Sample>) method_FindByPackage_1.Invoke(packageName,packageVersion);
		}
		public bool Import(Sample_ImportOptions options)
		{
			return (bool) method_Import_1.Invoke((int)options);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.Sample, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
