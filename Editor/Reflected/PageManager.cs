namespace TNRD.PackageManager.Reflected
{
    public sealed partial class PageManager
    {
        /// <summary>
        /// Creates a static instance of the Page Manager
        /// </summary>
        /// <returns></returns>
        public static IPageManager GetInstance()
        {
            PageManager pageManager = new PageManager(GetOriginalType());
            return pageManager.instance;
        }
    }
}