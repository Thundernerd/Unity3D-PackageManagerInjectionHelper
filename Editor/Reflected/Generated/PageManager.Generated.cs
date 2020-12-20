// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PageManager, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager.UI;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PageManager : ReflectiveClass
	{
		private ReflectiveField<string> field_kUnityPackageGroupName;
		private ReflectiveField<string> field_kOtherPackageGroupName;
		private ReflectiveField<string> field_kCustomPackageGroupName;
		private ReflectiveField field_sInstance;
		private ReflectiveField<int> field_kDefaultPageSize;
		private ReflectiveProperty property_instance;

		public PageManager(object instance) : base(instance)
		{
			field_kUnityPackageGroupName = CreateField<string>("kUnityPackageGroupName", BindingFlags.Static | BindingFlags.NonPublic);
			field_kOtherPackageGroupName = CreateField<string>("kOtherPackageGroupName", BindingFlags.Static | BindingFlags.NonPublic);
			field_kCustomPackageGroupName = CreateField<string>("kCustomPackageGroupName", BindingFlags.Static | BindingFlags.NonPublic);
			field_sInstance = CreateField("sInstance", BindingFlags.Static | BindingFlags.NonPublic);
			field_kDefaultPageSize = CreateField<int>("kDefaultPageSize", BindingFlags.Static | BindingFlags.Public);
			property_instance = CreateProperty("instance", BindingFlags.Static | BindingFlags.Public);
		}
		
		public PageManager(Type type) : base(type)
		{
			field_kUnityPackageGroupName = CreateField<string>("kUnityPackageGroupName", BindingFlags.Static | BindingFlags.NonPublic);
			field_kOtherPackageGroupName = CreateField<string>("kOtherPackageGroupName", BindingFlags.Static | BindingFlags.NonPublic);
			field_kCustomPackageGroupName = CreateField<string>("kCustomPackageGroupName", BindingFlags.Static | BindingFlags.NonPublic);
			field_sInstance = CreateField("sInstance", BindingFlags.Static | BindingFlags.NonPublic);
			field_kDefaultPageSize = CreateField<int>("kDefaultPageSize", BindingFlags.Static | BindingFlags.Public);
			property_instance = CreateProperty("instance", BindingFlags.Static | BindingFlags.Public);
		}

		public string kUnityPackageGroupName
		{
			get => field_kUnityPackageGroupName.GetValue();
			set => field_kUnityPackageGroupName.SetValue(value);
		}
		public string kOtherPackageGroupName
		{
			get => field_kOtherPackageGroupName.GetValue();
			set => field_kOtherPackageGroupName.SetValue(value);
		}
		public string kCustomPackageGroupName
		{
			get => field_kCustomPackageGroupName.GetValue();
			set => field_kCustomPackageGroupName.SetValue(value);
		}
		public IPageManager sInstance
		{
			get => new IPageManager(field_sInstance.GetValue());
			set => field_sInstance.SetValue(value.Instance);
		}
		public int kDefaultPageSize
		{
			get => field_kDefaultPageSize.GetValue();
			set => field_kDefaultPageSize.SetValue(value);
		}
		public IPageManager instance
		{
			get => new IPageManager(property_instance.GetValue());
		}
	}
}
