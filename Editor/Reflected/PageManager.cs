namespace TNRD.PackageManager.Reflected
{
    public sealed partial class PageManager
    {
        public static IPageManager GetInstance()
        {
            PageManager pageManager = new PageManager(GetOriginalType());
            return pageManager.instance;
        }
    }
}