namespace TNRD.PackageManager.Reflected
{
    public partial class DownloadProgress
    {
        public enum State
        {
            Started,
            InProgress,
            Completed,
            Decrypting,
            Aborted,
            Error
        }
    }
}