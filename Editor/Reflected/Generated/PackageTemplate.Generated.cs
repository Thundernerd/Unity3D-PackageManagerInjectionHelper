// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.PackageTemplate, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
using System.Collections.Generic;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageTemplate : ReflectiveClass
	{
		private ReflectiveField<string> field_kDefaultTemplateName;
		private ReflectiveField<string> field_kPackageManifestFileName;
		private ReflectiveField<string> field_PackageTemplatesRootFolder;
		private ReflectiveMethod method_ReplaceVariablesInString_1;
		private ReflectiveMethod method_ReplaceVariablesInFile_1;
		private ReflectiveMethod method_RenameFileWithVariables_1;
		private ReflectiveMethod method_GetPackageTemplateFiles_1;
		private ReflectiveMethod method_CreatePackageFromTemplateFolder_1;
		private ReflectiveMethod method_ValidateRootNamespace_1;
		private ReflectiveMethod method_ValidateOptions_1;
		private ReflectiveMethod method_CreateTemplateVariables_1;
		private ReflectiveMethod method_CreatePackage_1;
		public PackageTemplate(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageTemplate(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_kDefaultTemplateName = CreateField<string>("kDefaultTemplateName", BindingFlags.Static | BindingFlags.NonPublic);
			field_kPackageManifestFileName = CreateField<string>("kPackageManifestFileName", BindingFlags.Static | BindingFlags.NonPublic);
			field_PackageTemplatesRootFolder = CreateField<string>("PackageTemplatesRootFolder", BindingFlags.Static | BindingFlags.NonPublic);
			method_ReplaceVariablesInString_1 = CreateMethod("ReplaceVariablesInString", BindingFlags.Static | BindingFlags.NonPublic, typeof(Dictionary<string, string>),typeof(string));
			method_ReplaceVariablesInFile_1 = CreateMethod("ReplaceVariablesInFile", BindingFlags.Static | BindingFlags.NonPublic, typeof(Dictionary<string, string>),typeof(string));
			method_RenameFileWithVariables_1 = CreateMethod("RenameFileWithVariables", BindingFlags.Static | BindingFlags.NonPublic, typeof(Dictionary<string, string>),typeof(string));
			method_GetPackageTemplateFiles_1 = CreateMethod("GetPackageTemplateFiles", BindingFlags.Static | BindingFlags.NonPublic, typeof(string));
			method_CreatePackageFromTemplateFolder_1 = CreateMethod("CreatePackageFromTemplateFolder", BindingFlags.Static | BindingFlags.NonPublic, typeof(Dictionary<string, string>),typeof(string),typeof(string));
			method_ValidateRootNamespace_1 = CreateMethod("ValidateRootNamespace", BindingFlags.Static | BindingFlags.NonPublic, typeof(string));
			method_ValidateOptions_1 = CreateMethod("ValidateOptions", BindingFlags.Static | BindingFlags.NonPublic, typeof(PackageTemplateOptions));
			method_CreateTemplateVariables_1 = CreateMethod("CreateTemplateVariables", BindingFlags.Static | BindingFlags.NonPublic, typeof(PackageTemplateOptions));
			method_CreatePackage_1 = CreateMethod("CreatePackage", BindingFlags.Static | BindingFlags.Public, typeof(PackageTemplateOptions));
		}
		partial void Initialize();
		public string kDefaultTemplateName
		{
			get => field_kDefaultTemplateName.GetValue();
			set => field_kDefaultTemplateName.SetValue(value);
		}
		public string kPackageManifestFileName
		{
			get => field_kPackageManifestFileName.GetValue();
			set => field_kPackageManifestFileName.SetValue(value);
		}
		public string PackageTemplatesRootFolder
		{
			get => field_PackageTemplatesRootFolder.GetValue();
			set => field_PackageTemplatesRootFolder.SetValue(value);
		}
		public string ReplaceVariablesInString(Dictionary<string, string> variables,string txt)
		{
			return (string) method_ReplaceVariablesInString_1.Invoke(variables,txt);
		}
		public void ReplaceVariablesInFile(Dictionary<string, string> variables,string file)
		{
			method_ReplaceVariablesInFile_1.Invoke(variables,file);
		}
		public void RenameFileWithVariables(Dictionary<string, string> variables,string file)
		{
			method_RenameFileWithVariables_1.Invoke(variables,file);
		}
		public IEnumerable<string> GetPackageTemplateFiles(string templateFolder)
		{
			return (IEnumerable<string>) method_GetPackageTemplateFiles_1.Invoke(templateFolder);
		}
		public void CreatePackageFromTemplateFolder(Dictionary<string, string> variables,string templateFolder,string targetFolder)
		{
			method_CreatePackageFromTemplateFolder_1.Invoke(variables,templateFolder,targetFolder);
		}
		public bool ValidateRootNamespace(string rootNamespace)
		{
			return (bool) method_ValidateRootNamespace_1.Invoke(rootNamespace);
		}
		public void ValidateOptions(PackageTemplateOptions options)
		{
			method_ValidateOptions_1.Invoke(options);
		}
		public Dictionary<string, string> CreateTemplateVariables(PackageTemplateOptions options)
		{
			return (Dictionary<string, string>) method_CreateTemplateVariables_1.Invoke(options);
		}
		public string CreatePackage(PackageTemplateOptions options)
		{
			return (string) method_CreatePackage_1.Invoke(options);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.PackageTemplate, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
