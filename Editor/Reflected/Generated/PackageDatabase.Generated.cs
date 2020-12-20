// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.PackageDatabase, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------

using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager.UI;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class PackageDatabase : ReflectiveClass
	{
		private ReflectiveField field_sInstance;
		private ReflectiveProperty property_instance;
		private ReflectiveMethod method_GetRefreshOptionsFromFilterTab_1;
		public PackageDatabase(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public PackageDatabase(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_sInstance = CreateField("sInstance", BindingFlags.Static | BindingFlags.NonPublic);
			property_instance = CreateProperty("instance", BindingFlags.Static | BindingFlags.Public);
			method_GetRefreshOptionsFromFilterTab_1 = CreateMethod("GetRefreshOptionsFromFilterTab", BindingFlags.Static | BindingFlags.Public, typeof(PackageFilterTab));
		}
		partial void Initialize();
		public IPackageDatabase sInstance
		{
			get
			{
				object _temp = field_sInstance.GetValue();
				return _temp == null ? null : new IPackageDatabase(_temp);
			}
			set => field_sInstance.SetValue(value.Instance);
		}
		public IPackageDatabase instance
		{
			get
			{
				object _temp = property_instance.GetValue();
				return _temp == null ? null : new IPackageDatabase(_temp);
			}
		}
		public RefreshOptions GetRefreshOptionsFromFilterTab(PackageFilterTab tab)
		{
			return (RefreshOptions)(uint)method_GetRefreshOptionsFromFilterTab_1.Invoke((int)tab);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.PackageDatabase, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
