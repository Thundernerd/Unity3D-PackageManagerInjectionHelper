// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageError, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageError : ReflectiveClass
	{
		private ReflectiveField<string> field_PackageName;
		private ReflectiveField<Error> field_Error;
		public PackageError(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageError(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_PackageName = CreateField<string>("PackageName", BindingFlags.Instance | BindingFlags.Public);
			field_Error = CreateField<Error>("Error", BindingFlags.Instance | BindingFlags.Public);
		}
		partial void Initialize();
		public string PackageName
		{
			get => field_PackageName.GetValue();
			set => field_PackageName.SetValue(value);
		}
		public Error Error
		{
			get => field_Error.GetValue();
			set => field_Error.SetValue(value);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageError, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
