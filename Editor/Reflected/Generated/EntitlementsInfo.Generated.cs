// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.EntitlementsInfo, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class EntitlementsInfo : ReflectiveClass
	{
		private ReflectiveField<bool> field_mIsAllowed;
		private ReflectiveField field_mLicenseType;
		private ReflectiveProperty property_licenseType;
		private ReflectiveProperty<bool> property_isAllowed;
		public EntitlementsInfo(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public EntitlementsInfo(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_mIsAllowed = CreateField<bool>("mIsAllowed", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mLicenseType = CreateField("mLicenseType", BindingFlags.Instance | BindingFlags.NonPublic);
			property_licenseType = CreateProperty("licenseType", BindingFlags.Instance | BindingFlags.Public);
			property_isAllowed = CreateProperty<bool>("isAllowed", BindingFlags.Instance | BindingFlags.Public);
		}
		partial void Initialize();
		public bool mIsAllowed
		{
			get => field_mIsAllowed.GetValue();
			set => field_mIsAllowed.SetValue(value);
		}
		public EntitlementLicenseType mLicenseType
		{
			get
			{
				object _temp = (int)field_mLicenseType.GetValue();
				return (EntitlementLicenseType)_temp;
			}
			set => field_mLicenseType.SetValue((int)value);
		}
		public EntitlementLicenseType licenseType
		{
			get
			{
				object _temp = (int)property_licenseType.GetValue();
				return (EntitlementLicenseType)_temp;
			}
		}
		public bool isAllowed
		{
			get => property_isAllowed.GetValue();
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.EntitlementsInfo, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
