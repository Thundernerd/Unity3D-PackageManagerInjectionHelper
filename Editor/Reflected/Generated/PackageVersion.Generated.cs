// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageVersion, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.UI;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageVersion : ReflectiveClass
	{
		private ReflectiveField field_Package;
		private ReflectiveField field_Version;
		public PackageVersion(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageVersion(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_Package = CreateField("Package", BindingFlags.Instance | BindingFlags.Public);
			field_Version = CreateField("Version", BindingFlags.Instance | BindingFlags.Public);
		}
		partial void Initialize();
		public Package Package
		{
			get
			{
				object _temp = field_Package.GetValue();
				return _temp == null ? null : new Package(_temp);
			}
			set => field_Package.SetValue(value.Instance);
		}
		public PackageInfo Version
		{
			get
			{
				object _temp = field_Version.GetValue();
				return _temp == null ? null : new PackageInfo(_temp);
			}
			set => field_Version.SetValue(value.Instance);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageVersion, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
