// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageSizeInfo, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager.UI;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageSizeInfo : ReflectiveClass
	{
		private ReflectiveField field_supportedUnityVersion;
		private ReflectiveField<ulong> field_assetCount;
		private ReflectiveField<ulong> field_downloadSize;

		public PackageSizeInfo(object instance) : base(instance)
		{
			field_supportedUnityVersion = CreateField("supportedUnityVersion", BindingFlags.Instance | BindingFlags.Public);
			field_assetCount = CreateField<ulong>("assetCount", BindingFlags.Instance | BindingFlags.Public);
			field_downloadSize = CreateField<ulong>("downloadSize", BindingFlags.Instance | BindingFlags.Public);
		}

		public SemVersion supportedUnityVersion
		{
			get => new SemVersion(field_supportedUnityVersion.GetValue());
			set => field_supportedUnityVersion.SetValue(value.Instance);
		}
		public ulong assetCount
		{
			get => field_assetCount.GetValue();
			set => field_assetCount.SetValue(value);
		}
		public ulong downloadSize
		{
			get => field_downloadSize.GetValue();
			set => field_downloadSize.SetValue(value);
		}
	}
}
