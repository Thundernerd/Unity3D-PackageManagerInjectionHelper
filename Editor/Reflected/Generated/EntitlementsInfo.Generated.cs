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
			field_mIsAllowed = CreateField<bool>("mIsAllowed", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mLicenseType = CreateField("mLicenseType", BindingFlags.Instance | BindingFlags.NonPublic);
			property_licenseType = CreateProperty("licenseType", BindingFlags.Instance | BindingFlags.Public);
			property_isAllowed = CreateProperty<bool>("isAllowed", BindingFlags.Instance | BindingFlags.Public);
		}

		public bool mIsAllowed
		{
			get => field_mIsAllowed.GetValue();
			set => field_mIsAllowed.SetValue(value);
		}
		public EntitlementLicenseType mLicenseType
		{
			get => ReflectiveUtilities.GetIntEnum<EntitlementLicenseType>(field_mLicenseType);
			set => field_mLicenseType.SetValue((int) value);
		}
		public EntitlementLicenseType licenseType
		{
			get => ReflectiveUtilities.GetIntEnum<EntitlementLicenseType>(property_licenseType);
		}
		public bool isAllowed
		{
			get => property_isAllowed.GetValue();
		}
	}
}
