// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageImage, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.UI;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageImage : ReflectiveClass
	{
		private ReflectiveField field_type;
		private ReflectiveField<string> field_thumbnailUrl;
		private ReflectiveField<string> field_url;
		public PackageImage(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageImage(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_type = CreateField("type", BindingFlags.Instance | BindingFlags.Public);
			field_thumbnailUrl = CreateField<string>("thumbnailUrl", BindingFlags.Instance | BindingFlags.Public);
			field_url = CreateField<string>("url", BindingFlags.Instance | BindingFlags.Public);
		}
		partial void Initialize();
		public PackageImage_ImageType type
		{
			get
			{
				object _temp = (int)field_type.GetValue();
				return (PackageImage_ImageType)_temp;
			}
			set => field_type.SetValue((int)value);
		}
		public string thumbnailUrl
		{
			get => field_thumbnailUrl.GetValue();
			set => field_thumbnailUrl.SetValue(value);
		}
		public string url
		{
			get => field_url.GetValue();
			set => field_url.SetValue(value);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageImage, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
