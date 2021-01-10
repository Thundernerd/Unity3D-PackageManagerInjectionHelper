// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.AuthorInfo, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class AuthorInfo : ReflectiveClass
	{
		private ReflectiveField<string> field_mName;
		private ReflectiveField<string> field_mEmail;
		private ReflectiveField<string> field_mUrl;
		private ReflectiveProperty<string> property_name;
		private ReflectiveProperty<string> property_email;
		private ReflectiveProperty<string> property_url;
		public AuthorInfo(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public AuthorInfo(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_mName = CreateField<string>("mName", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mEmail = CreateField<string>("mEmail", BindingFlags.Instance | BindingFlags.NonPublic);
			field_mUrl = CreateField<string>("mUrl", BindingFlags.Instance | BindingFlags.NonPublic);
			property_name = CreateProperty<string>("name", BindingFlags.Instance | BindingFlags.Public);
			property_email = CreateProperty<string>("email", BindingFlags.Instance | BindingFlags.Public);
			property_url = CreateProperty<string>("url", BindingFlags.Instance | BindingFlags.Public);
		}
		partial void Initialize();
		public string mName
		{
			get => field_mName.GetValue();
			set => field_mName.SetValue(value);
		}
		public string mEmail
		{
			get => field_mEmail.GetValue();
			set => field_mEmail.SetValue(value);
		}
		public string mUrl
		{
			get => field_mUrl.GetValue();
			set => field_mUrl.SetValue(value);
		}
		public string name
		{
			get => property_name.GetValue();
		}
		public string email
		{
			get => property_email.GetValue();
		}
		public string url
		{
			get => property_url.GetValue();
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.AuthorInfo, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
