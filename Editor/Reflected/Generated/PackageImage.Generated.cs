// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageImage, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager.UI;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageImage : ReflectiveClass
	{
		private ReflectiveField<ImageType> field_type;
		private ReflectiveField<string> field_thumbnailUrl;
		private ReflectiveField<string> field_url;

		public PackageImage(object instance) : base(instance)
		{
			field_type = CreateField<ImageType>("type", BindingFlags.Instance | BindingFlags.Public);
			field_thumbnailUrl = CreateField<string>("thumbnailUrl", BindingFlags.Instance | BindingFlags.Public);
			field_url = CreateField<string>("url", BindingFlags.Instance | BindingFlags.Public);
		}

		public PackageImage.ImageType type
		{
			get => ReflectiveUtilities.GetIntEnum<PackageImage.ImageType>(field_type);
			set => field_type.SetValue((int) value);
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
	}
}
