// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.IPage, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.UI;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class IPage : ReflectiveClass
	{
		private ReflectiveProperty property_tab;
		private ReflectiveProperty<bool> property_isLoading;
		private ReflectiveProperty<bool> property_morePackagesToFetch;
		private ReflectiveProperty property_packageVisualStates;
		private ReflectiveMethod method_GetVisualState_1;
		private ReflectiveMethod method_GetSelectedVisualState_1;
		private ReflectiveMethod method_LoadMore_1;
		private ReflectiveMethod method_Load_1;
		private ReflectiveMethod method_GetGroupName_1;
		public IPage(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public IPage(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			property_tab = CreateProperty("tab", BindingFlags.Instance | BindingFlags.Public);
			property_isLoading = CreateProperty<bool>("isLoading", BindingFlags.Instance | BindingFlags.Public);
			property_morePackagesToFetch = CreateProperty<bool>("morePackagesToFetch", BindingFlags.Instance | BindingFlags.Public);
			property_packageVisualStates = CreateProperty("packageVisualStates", BindingFlags.Instance | BindingFlags.Public);
			method_GetVisualState_1 = CreateMethod("GetVisualState", BindingFlags.Instance | BindingFlags.Public, typeof(string));
			method_GetSelectedVisualState_1 = CreateMethod("GetSelectedVisualState", BindingFlags.Instance | BindingFlags.Public, null);
			method_LoadMore_1 = CreateMethod("LoadMore", BindingFlags.Instance | BindingFlags.Public, null);
			method_Load_1 = CreateMethod("Load", BindingFlags.Instance | BindingFlags.Public, typeof(IPackage),typeof(IPackageVersion));
			method_GetGroupName_1 = CreateMethod("GetGroupName", BindingFlags.Instance | BindingFlags.Public, typeof(IPackage));
		}
		partial void Initialize();
		public PackageFilterTab tab
		{
			get
			{
				object _temp = (int)property_tab.GetValue();
				return (PackageFilterTab)_temp;
			}
		}
		public bool isLoading
		{
			get => property_isLoading.GetValue();
		}
		public bool morePackagesToFetch
		{
			get => property_morePackagesToFetch.GetValue();
		}
		public List<VisualState> packageVisualStates
		{
			get
			{
				object _temp = property_packageVisualStates.GetValue();
				return _temp == null ? null : Utilities.GenerateEnumerable<VisualState>(_temp).ToList();
			}
		}
		public VisualState GetVisualState(string packageUniqueId)
		{
			return new VisualState(method_GetVisualState_1.Invoke(packageUniqueId));
		}
		public VisualState GetSelectedVisualState()
		{
			return new VisualState(method_GetSelectedVisualState_1.Invoke());
		}
		public void LoadMore()
		{
			method_LoadMore_1.Invoke();
		}
		public void Load(IPackage package,IPackageVersion version)
		{
			method_Load_1.Invoke(package,version);
		}
		public string GetGroupName(IPackage package)
		{
			return (string) method_GetGroupName_1.Invoke(package);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.IPage, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
