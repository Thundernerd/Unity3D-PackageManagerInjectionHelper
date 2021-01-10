// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.SelectionManager, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.UI;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class SelectionManager : ReflectiveClass
	{
		private ReflectiveField field_ListSelection;
		private ReflectiveField field_SearchSelection;
		private ReflectiveField field_BuiltInSelection;
		private ReflectiveProperty property_Collection;
		private ReflectiveProperty property_Selection;
		private ReflectiveMethod method_SetCollection_1;
		private ReflectiveMethod method_ClearAll_1;
		private ReflectiveMethod method_SetSelection_1;
		public SelectionManager(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public SelectionManager(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			field_ListSelection = CreateField("ListSelection", BindingFlags.Instance | BindingFlags.NonPublic);
			field_SearchSelection = CreateField("SearchSelection", BindingFlags.Instance | BindingFlags.NonPublic);
			field_BuiltInSelection = CreateField("BuiltInSelection", BindingFlags.Instance | BindingFlags.NonPublic);
			property_Collection = CreateProperty("Collection", BindingFlags.Instance | BindingFlags.NonPublic);
			property_Selection = CreateProperty("Selection", BindingFlags.Instance | BindingFlags.Public);
			method_SetCollection_1 = CreateMethod("SetCollection", BindingFlags.Instance | BindingFlags.Public, typeof(PackageCollection));
			method_ClearAll_1 = CreateMethod("ClearAll", BindingFlags.Instance | BindingFlags.Public, null);
			method_SetSelection_1 = CreateMethod("SetSelection", BindingFlags.Instance | BindingFlags.Public, typeof(string));
		}
		partial void Initialize();
		public Selection ListSelection
		{
			get
			{
				object _temp = field_ListSelection.GetValue();
				return _temp == null ? null : new Selection(_temp);
			}
			set => field_ListSelection.SetValue(value.Instance);
		}
		public Selection SearchSelection
		{
			get
			{
				object _temp = field_SearchSelection.GetValue();
				return _temp == null ? null : new Selection(_temp);
			}
			set => field_SearchSelection.SetValue(value.Instance);
		}
		public Selection BuiltInSelection
		{
			get
			{
				object _temp = field_BuiltInSelection.GetValue();
				return _temp == null ? null : new Selection(_temp);
			}
			set => field_BuiltInSelection.SetValue(value.Instance);
		}
		public PackageCollection Collection
		{
			get
			{
				object _temp = property_Collection.GetValue();
				return _temp == null ? null : new PackageCollection(_temp);
			}
			set => property_Collection.SetValue(value.Instance);
		}
		public Selection Selection
		{
			get
			{
				object _temp = property_Selection.GetValue();
				return _temp == null ? null : new Selection(_temp);
			}
		}
		public void SetCollection(PackageCollection collection)
		{
			method_SetCollection_1.Invoke(collection);
		}
		public void ClearAll()
		{
			method_ClearAll_1.Invoke();
		}
		public void SetSelection(string packageName)
		{
			method_SetSelection_1.Invoke(packageName);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.SelectionManager, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
