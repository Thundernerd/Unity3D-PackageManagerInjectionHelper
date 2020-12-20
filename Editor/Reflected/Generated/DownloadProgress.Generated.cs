// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.DownloadProgress, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using TNRD.Reflectives;
using UnityEditor.PackageManager.UI;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class DownloadProgress : ReflectiveClass
	{
		private ReflectiveField<string> field_packageId;
		private ReflectiveField field_state;
		private ReflectiveField<ulong> field_current;
		private ReflectiveField<ulong> field_total;
		private ReflectiveField<string> field_message;

		public DownloadProgress(object instance) : base(instance)
		{
			field_packageId = CreateField<string>("packageId", BindingFlags.Instance | BindingFlags.Public);
			field_state = CreateField("state", BindingFlags.Instance | BindingFlags.Public);
			field_current = CreateField<ulong>("current", BindingFlags.Instance | BindingFlags.Public);
			field_total = CreateField<ulong>("total", BindingFlags.Instance | BindingFlags.Public);
			field_message = CreateField<string>("message", BindingFlags.Instance | BindingFlags.Public);
		}

		public string packageId
		{
			get => field_packageId.GetValue();
			set => field_packageId.SetValue(value);
		}
		public DownloadProgress.State state
		{
			get => ReflectiveUtilities.GetIntEnum<DownloadProgress.State>(field_state);
			set => field_state.SetValue((int) value);
		}
		public ulong current
		{
			get => field_current.GetValue();
			set => field_current.SetValue(value);
		}
		public ulong total
		{
			get => field_total.GetValue();
			set => field_total.SetValue(value);
		}
		public string message
		{
			get => field_message.GetValue();
			set => field_message.SetValue(value);
		}
	}
}
