using System;

namespace TNRD.PackageManager.Reflected
{
    public sealed partial class PageManager
    {
        public static IPageManager GetInstance()
        {
            Type type = Type.GetType("UnityEditor.PackageManager.UI.PageManager, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
            PageManager pageManager = new PageManager(type);
            return pageManager.instance;
        }
    }
}