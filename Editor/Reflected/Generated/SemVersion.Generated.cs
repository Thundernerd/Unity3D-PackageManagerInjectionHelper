// -------------------------------------------------------------------
// 			AUTO-GENERATED
//
// 	Original:
// 	UnityEditor.PackageManager.UI.SemVersion, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// -------------------------------------------------------------------
using System;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Runtime.Serialization;
using TNRD.Reflectives;
namespace TNRD.PackageManager.Reflected
{
	public sealed partial class SemVersion : ReflectiveClass
	{
		private ReflectiveField<Regex> field_parseEx;
		private ReflectiveProperty<int> property_Major;
		private ReflectiveProperty<int> property_Minor;
		private ReflectiveProperty<int> property_Patch;
		private ReflectiveProperty<string> property_Prerelease;
		private ReflectiveProperty<string> property_Build;
		private ReflectiveMethod method_Parse_1;
		private ReflectiveMethod method_TryParse_1;
		private ReflectiveMethod method_Equals_1;
		private ReflectiveMethod method_Compare_1;
		private ReflectiveMethod method_Change_1;
		private ReflectiveMethod method_ToString_1;
		private ReflectiveMethod method_CompareTo_1;
		private ReflectiveMethod method_CompareTo_2;
		private ReflectiveMethod method_PrecedenceMatches_1;
		private ReflectiveMethod method_CompareByPrecedence_1;
		private ReflectiveMethod method_CompareComponent_1;
		private ReflectiveMethod method_Equals_2;
		private ReflectiveMethod method_GetHashCode_1;
		private ReflectiveMethod method_GetObjectData_1;
		private ReflectiveMethod method_op_Implicit_1;
		private ReflectiveMethod method_op_Equality_1;
		private ReflectiveMethod method_op_Inequality_1;
		private ReflectiveMethod method_op_GreaterThan_1;
		private ReflectiveMethod method_op_GreaterThanOrEqual_1;
		private ReflectiveMethod method_op_LessThan_1;
		private ReflectiveMethod method_op_LessThanOrEqual_1;

		public SemVersion(object instance) : base(instance)
		{
			field_parseEx = CreateField<Regex>("parseEx", BindingFlags.Static | BindingFlags.NonPublic);
			property_Major = CreateProperty<int>("Major", BindingFlags.Instance | BindingFlags.Public);
			property_Minor = CreateProperty<int>("Minor", BindingFlags.Instance | BindingFlags.Public);
			property_Patch = CreateProperty<int>("Patch", BindingFlags.Instance | BindingFlags.Public);
			property_Prerelease = CreateProperty<string>("Prerelease", BindingFlags.Instance | BindingFlags.Public);
			property_Build = CreateProperty<string>("Build", BindingFlags.Instance | BindingFlags.Public);
			method_Parse_1 = CreateMethod("Parse", BindingFlags.Static | BindingFlags.Public, typeof(string),typeof(bool));
			method_TryParse_1 = CreateMethod("TryParse", BindingFlags.Static | BindingFlags.Public, typeof(string),typeof(SemVersion),typeof(bool));
			method_Equals_1 = CreateMethod("Equals", BindingFlags.Static | BindingFlags.Public, typeof(SemVersion),typeof(SemVersion));
			method_Compare_1 = CreateMethod("Compare", BindingFlags.Static | BindingFlags.Public, typeof(SemVersion),typeof(SemVersion));
			method_Change_1 = CreateMethod("Change", BindingFlags.Instance | BindingFlags.Public, typeof(int?),typeof(int?),typeof(int?),typeof(string),typeof(string));
			method_ToString_1 = CreateMethod("ToString", BindingFlags.Instance | BindingFlags.Public, null);
			method_CompareTo_1 = CreateMethod("CompareTo", BindingFlags.Instance | BindingFlags.Public, typeof(Object));
			method_CompareTo_2 = CreateMethod("CompareTo", BindingFlags.Instance | BindingFlags.Public, typeof(SemVersion));
			method_PrecedenceMatches_1 = CreateMethod("PrecedenceMatches", BindingFlags.Instance | BindingFlags.Public, typeof(SemVersion));
			method_CompareByPrecedence_1 = CreateMethod("CompareByPrecedence", BindingFlags.Instance | BindingFlags.Public, typeof(SemVersion));
			method_CompareComponent_1 = CreateMethod("CompareComponent", BindingFlags.Static | BindingFlags.NonPublic, typeof(string),typeof(string),typeof(bool));
			method_Equals_2 = CreateMethod("Equals", BindingFlags.Instance | BindingFlags.Public, typeof(Object));
			method_GetHashCode_1 = CreateMethod("GetHashCode", BindingFlags.Instance | BindingFlags.Public, null);
			method_GetObjectData_1 = CreateMethod("GetObjectData", BindingFlags.Instance | BindingFlags.Public, typeof(SerializationInfo),typeof(StreamingContext));
			method_op_Implicit_1 = CreateMethod("op_Implicit", BindingFlags.Static | BindingFlags.Public, typeof(string));
			method_op_Equality_1 = CreateMethod("op_Equality", BindingFlags.Static | BindingFlags.Public, typeof(SemVersion),typeof(SemVersion));
			method_op_Inequality_1 = CreateMethod("op_Inequality", BindingFlags.Static | BindingFlags.Public, typeof(SemVersion),typeof(SemVersion));
			method_op_GreaterThan_1 = CreateMethod("op_GreaterThan", BindingFlags.Static | BindingFlags.Public, typeof(SemVersion),typeof(SemVersion));
			method_op_GreaterThanOrEqual_1 = CreateMethod("op_GreaterThanOrEqual", BindingFlags.Static | BindingFlags.Public, typeof(SemVersion),typeof(SemVersion));
			method_op_LessThan_1 = CreateMethod("op_LessThan", BindingFlags.Static | BindingFlags.Public, typeof(SemVersion),typeof(SemVersion));
			method_op_LessThanOrEqual_1 = CreateMethod("op_LessThanOrEqual", BindingFlags.Static | BindingFlags.Public, typeof(SemVersion),typeof(SemVersion));
		}

		public Regex parseEx
		{
			get => field_parseEx.GetValue();
			set => field_parseEx.SetValue(value);
		}
		public int Major
		{
			get => property_Major.GetValue();
			set => property_Major.SetValue(value);
		}
		public int Minor
		{
			get => property_Minor.GetValue();
			set => property_Minor.SetValue(value);
		}
		public int Patch
		{
			get => property_Patch.GetValue();
			set => property_Patch.SetValue(value);
		}
		public string Prerelease
		{
			get => property_Prerelease.GetValue();
			set => property_Prerelease.SetValue(value);
		}
		public string Build
		{
			get => property_Build.GetValue();
			set => property_Build.SetValue(value);
		}
		public SemVersion Parse(string version,bool strict)
		{
			return new SemVersion(method_Parse_1.Invoke(version,strict));
		}
		public Boolean TryParse(string version,ref SemVersion semver,bool strict)
		{
			return (Boolean) method_TryParse_1.Invoke(version,semver,strict);
		}
		public Boolean Equals(SemVersion versionA,SemVersion versionB)
		{
			return (Boolean) method_Equals_1.Invoke(versionA,versionB);
		}
		public Int32 Compare(SemVersion versionA,SemVersion versionB)
		{
			return (Int32) method_Compare_1.Invoke(versionA,versionB);
		}
		public SemVersion Change(int? major,int? minor,int? patch,string prerelease,string build)
		{
			return new SemVersion(method_Change_1.Invoke(major,minor,patch,prerelease,build));
		}
		public String ToString()
		{
			return (String) method_ToString_1.Invoke();
		}
		public Int32 CompareTo(Object obj)
		{
			return (Int32) method_CompareTo_1.Invoke(obj);
		}
		public Int32 CompareTo(SemVersion other)
		{
			return (Int32) method_CompareTo_2.Invoke(other);
		}
		public Boolean PrecedenceMatches(SemVersion other)
		{
			return (Boolean) method_PrecedenceMatches_1.Invoke(other);
		}
		public Int32 CompareByPrecedence(SemVersion other)
		{
			return (Int32) method_CompareByPrecedence_1.Invoke(other);
		}
		public Int32 CompareComponent(string a,string b,bool lower)
		{
			return (Int32) method_CompareComponent_1.Invoke(a,b,lower);
		}
		public Boolean Equals(Object obj)
		{
			return (Boolean) method_Equals_2.Invoke(obj);
		}
		public Int32 GetHashCode()
		{
			return (Int32) method_GetHashCode_1.Invoke();
		}
		public void GetObjectData(SerializationInfo info,StreamingContext context)
		{
			method_GetObjectData_1.Invoke(info,context);
		}
		public SemVersion op_Implicit(string version)
		{
			return new SemVersion(method_op_Implicit_1.Invoke(version));
		}
		public Boolean op_Equality(SemVersion left,SemVersion right)
		{
			return (Boolean) method_op_Equality_1.Invoke(left,right);
		}
		public Boolean op_Inequality(SemVersion left,SemVersion right)
		{
			return (Boolean) method_op_Inequality_1.Invoke(left,right);
		}
		public Boolean op_GreaterThan(SemVersion left,SemVersion right)
		{
			return (Boolean) method_op_GreaterThan_1.Invoke(left,right);
		}
		public Boolean op_GreaterThanOrEqual(SemVersion left,SemVersion right)
		{
			return (Boolean) method_op_GreaterThanOrEqual_1.Invoke(left,right);
		}
		public Boolean op_LessThan(SemVersion left,SemVersion right)
		{
			return (Boolean) method_op_LessThan_1.Invoke(left,right);
		}
		public Boolean op_LessThanOrEqual(SemVersion left,SemVersion right)
		{
			return (Boolean) method_op_LessThanOrEqual_1.Invoke(left,right);
		}
	}
}
