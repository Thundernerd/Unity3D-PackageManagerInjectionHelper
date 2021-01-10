// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.Selection, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.UI;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class Selection : ReflectiveClass
	{
		private ReflectiveEvent event_OnChanged;
		private ReflectiveField field_States;
		private ReflectiveField field_Cache;
		private ReflectiveField field_Collection;
		private ReflectiveField field_OnChanged;
		private ReflectiveProperty property_Selected;
		private ReflectiveProperty property_SelectedVersions;
		private ReflectiveProperty property_FirstSelected;
		private ReflectiveMethod method_GetVersion_1;
		private ReflectiveMethod method_ClearSelection_1;
		private ReflectiveMethod method_ClearSelectionInternal_1;
		private ReflectiveMethod method_ClearEmpty_1;
		private ReflectiveMethod method_SetCollection_1;
		private ReflectiveMethod method_AddSelection_1;
		private ReflectiveMethod method_TriggerNewSelection_1;
		private ReflectiveMethod method_SetSelection_1;
		private ReflectiveMethod method_SetSelection_2;
		private ReflectiveMethod method_IsSelected_1;
		private ReflectiveMethod method_ByVersion_1;
		private ReflectiveMethod method_State_1;
		private ReflectiveMethod method_SetSeeAllVersions_1;
		private ReflectiveMethod method_IsSeeAllVersions_1;
		private ReflectiveMethod method_SetExpanded_1;
		private ReflectiveMethod method_IsExpanded_1;
		public Selection(object instance) : base(instance)
		{
			Construct();
			Initialize();
		}
		public Selection(Type type) : base(type)
		{
			Construct();
			Initialize();
		}
		private void Construct()
		{
			event_OnChanged = CreateEvent("OnChanged", BindingFlags.Instance | BindingFlags.Public);
			field_States = CreateField("States", BindingFlags.Instance | BindingFlags.Public);
			field_Cache = CreateField("Cache", BindingFlags.Instance | BindingFlags.NonPublic);
			field_Collection = CreateField("Collection", BindingFlags.Instance | BindingFlags.NonPublic);
			field_OnChanged = CreateField("OnChanged", BindingFlags.Instance | BindingFlags.NonPublic);
			property_Selected = CreateProperty("Selected", BindingFlags.Instance | BindingFlags.Public);
			property_SelectedVersions = CreateProperty("SelectedVersions", BindingFlags.Instance | BindingFlags.Public);
			property_FirstSelected = CreateProperty("FirstSelected", BindingFlags.Instance | BindingFlags.Public);
			method_GetVersion_1 = CreateMethod("GetVersion", BindingFlags.Instance | BindingFlags.NonPublic, typeof(ItemState));
			method_ClearSelection_1 = CreateMethod("ClearSelection", BindingFlags.Instance | BindingFlags.Public, null);
			method_ClearSelectionInternal_1 = CreateMethod("ClearSelectionInternal", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_ClearEmpty_1 = CreateMethod("ClearEmpty", BindingFlags.Instance | BindingFlags.NonPublic, null);
			method_SetCollection_1 = CreateMethod("SetCollection", BindingFlags.Instance | BindingFlags.Public, typeof(PackageCollection));
			method_AddSelection_1 = CreateMethod("AddSelection", BindingFlags.Instance | BindingFlags.Public, typeof(PackageInfo));
			method_TriggerNewSelection_1 = CreateMethod("TriggerNewSelection", BindingFlags.Instance | BindingFlags.Public, null);
			method_SetSelection_1 = CreateMethod("SetSelection", BindingFlags.Instance | BindingFlags.Public, typeof(PackageInfo));
			method_SetSelection_2 = CreateMethod("SetSelection", BindingFlags.Instance | BindingFlags.Public, typeof(Package));
			method_IsSelected_1 = CreateMethod("IsSelected", BindingFlags.Instance | BindingFlags.Public, typeof(PackageInfo));
			method_ByVersion_1 = CreateMethod("ByVersion", BindingFlags.Instance | BindingFlags.NonPublic, typeof(PackageInfo));
			method_State_1 = CreateMethod("State", BindingFlags.Instance | BindingFlags.NonPublic, typeof(PackageInfo));
			method_SetSeeAllVersions_1 = CreateMethod("SetSeeAllVersions", BindingFlags.Instance | BindingFlags.Public, typeof(PackageInfo),typeof(bool));
			method_IsSeeAllVersions_1 = CreateMethod("IsSeeAllVersions", BindingFlags.Instance | BindingFlags.Public, typeof(PackageInfo));
			method_SetExpanded_1 = CreateMethod("SetExpanded", BindingFlags.Instance | BindingFlags.Public, typeof(PackageInfo),typeof(bool));
			method_IsExpanded_1 = CreateMethod("IsExpanded", BindingFlags.Instance | BindingFlags.Public, typeof(PackageInfo));
		}
		partial void Initialize();
		/// <summary>
		/// Event type: System.Action<IEnumerable<PackageVersion>>
		/// </summary>
		/// <returns>Delegate to be used for unsubscribing</returns>
		public Delegate SubscribeToOnChanged(Delegate @delegate)
		{
			return event_OnChanged.Subscribe(@delegate);
		}
		/// <summary>
		/// Event type: System.Action<IEnumerable<PackageVersion>>
		/// </summary>
		public void UnsubscribeFromOnChanged(Delegate @delegate)
		{
			event_OnChanged.Unsubscribe(@delegate);
		}
		public List<ItemState> States
		{
			get
			{
				object _temp = field_States.GetValue();
				return (List<ItemState>) (_temp == null ? null : Utilities.GenerateEnumerable<ItemState>(_temp));
			}
		}
		public IEnumerable<PackageVersion> Cache
		{
			get
			{
				object _temp = field_Cache.GetValue();
				return _temp == null ? null : Utilities.GenerateEnumerable<PackageVersion>(_temp);
			}
		}
		public PackageCollection Collection
		{
			get
			{
				object _temp = field_Collection.GetValue();
				return _temp == null ? null : new PackageCollection(_temp);
			}
			set => field_Collection.SetValue(value.Instance);
		}
		public IEnumerable<PackageInfo> Selected
		{
			get
			{
				object _temp = property_Selected.GetValue();
				return _temp == null ? null : Utilities.GenerateEnumerable<PackageInfo>(_temp);
			}
		}
		public IEnumerable<PackageVersion> SelectedVersions
		{
			get
			{
				object _temp = property_SelectedVersions.GetValue();
				return _temp == null ? null : Utilities.GenerateEnumerable<PackageVersion>(_temp);
			}
		}
		public PackageVersion FirstSelected
		{
			get
			{
				object _temp = property_FirstSelected.GetValue();
				return _temp == null ? null : new PackageVersion(_temp);
			}
		}
		public PackageVersion GetVersion(ItemState state)
		{
			return new PackageVersion(method_GetVersion_1.Invoke(state));
		}
		public void ClearSelection()
		{
			method_ClearSelection_1.Invoke();
		}
		public void ClearSelectionInternal()
		{
			method_ClearSelectionInternal_1.Invoke();
		}
		public void ClearEmpty()
		{
			method_ClearEmpty_1.Invoke();
		}
		public void SetCollection(PackageCollection collection)
		{
			method_SetCollection_1.Invoke(collection);
		}
		public void AddSelection(PackageInfo version)
		{
			method_AddSelection_1.Invoke(version);
		}
		public void TriggerNewSelection()
		{
			method_TriggerNewSelection_1.Invoke();
		}
		public void SetSelection(PackageInfo version)
		{
			method_SetSelection_1.Invoke(version);
		}
		public void SetSelection(Package package)
		{
			method_SetSelection_2.Invoke(package);
		}
		public bool IsSelected(PackageInfo version)
		{
			return (bool) method_IsSelected_1.Invoke(version);
		}
		public IEnumerable<ItemState> ByVersion(PackageInfo version)
		{
			return Utilities.GenerateEnumerable<ItemState>(method_ByVersion_1.Invoke(version));
		}
		public ItemState State(PackageInfo version)
		{
			return new ItemState(method_State_1.Invoke(version));
		}
		public void SetSeeAllVersions(PackageInfo version,bool value)
		{
			method_SetSeeAllVersions_1.Invoke(version,value);
		}
		public bool IsSeeAllVersions(PackageInfo version)
		{
			return (bool) method_IsSeeAllVersions_1.Invoke(version);
		}
		public void SetExpanded(PackageInfo version,bool value)
		{
			method_SetExpanded_1.Invoke(version,value);
		}
		public bool IsExpanded(PackageInfo version)
		{
			return (bool) method_IsExpanded_1.Invoke(version);
		}
		public static Type GetOriginalType()
		{
			return System.Type.GetType("UnityEditor.PackageManager.UI.Selection, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
		}
	}
}
