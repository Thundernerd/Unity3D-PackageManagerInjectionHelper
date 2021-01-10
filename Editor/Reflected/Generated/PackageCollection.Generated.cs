// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.PackageCollection, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageCollection : ReflectiveClass
	{
		private ReflectiveField<PackageInfo[]> field_mPackageList;
		private ReflectiveField<Error> field_mError;
		private ReflectiveField<bool> field_mHasError;
		private ReflectiveProperty<Error> property_error;
		public PackageCollection(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageCollection(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_mPackageList = CreateField<PackageInfo[]>("mPackageList", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mError = CreateField<Error>("mError", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mHasError = CreateField<bool>("mHasError", BindingFlags.Instance | BindingFlags.NonPublic);
			property_error = CreateProperty<Error>("error", BindingFlags.Instance | BindingFlags.Public);
		}
		partial void Initialize();
		public PackageInfo[] mPackageList
		{
			get => field_mPackageList.GetValue();
			set => field_mPackageList.SetValue(value);
		}
		public Error mError
		{
			get => field_mError.GetValue();
			set => field_mError.SetValue(value);
		}
		public bool mHasError
		{
			get => field_mHasError.GetValue();
			set => field_mHasError.SetValue(value);
		}
		public Error error
		{
			get => property_error.GetValue();
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.PackageCollection, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
