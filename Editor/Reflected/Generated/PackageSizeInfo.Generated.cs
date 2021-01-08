// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageSizeInfo, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
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
			Construct();
			Initialize();
		}
		public PackageSizeInfo(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_supportedUnityVersion = CreateField("supportedUnityVersion", BindingFlags.Instance | BindingFlags.Public);
			field_assetCount = CreateField<ulong>("assetCount", BindingFlags.Instance | BindingFlags.Public);
			field_downloadSize = CreateField<ulong>("downloadSize", BindingFlags.Instance | BindingFlags.Public);
		}
		partial void Initialize();
		public SemVersion supportedUnityVersion
		{
			get
			{
				object _temp = field_supportedUnityVersion.GetValue();
				return _temp == null ? null : new SemVersion(_temp);
			}
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
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageSizeInfo, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
