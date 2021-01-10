using System.IO;
using ICSharpCode.SharpZipLib.Zip;
using UnityEditor;
using UnityEngine;

namespace TNRD.PackageManager.Injection
{
    internal static class Installer
    {
        [InitializeOnLoadMethod]
        [MenuItem("TNRD/Package Manager/Extract Injector")]
        private static void Init()
        {
            string zipPath = GetZipPath(out string unityVersion);
            if (string.IsNullOrEmpty(zipPath))
            {
                Debug.LogError("This version of Unity is not supported by the Package Manager Injection Helper");
                return;
            }

            string outputPath = Path.Combine(Application.dataPath, "TNRD", "Package Manager", "Injection", unityVersion);

            if (Directory.Exists(outputPath) && File.Exists(Path.Combine(outputPath, "PackageManagerInjectionHelper.cs")))
            {
                return;
            }

            string injectionDirectoryPath = Path.Combine(Application.dataPath, "TNRD", "Package Manager", "Injection");
            string[] directories = Directory.GetDirectories(injectionDirectoryPath);
            foreach (string directory in directories)
            {
                Directory.Delete(directory, true);
            }

            string fullPath = Path.GetFullPath(zipPath);
            FastZip fastZip = new FastZip();
            fastZip.ExtractZip(fullPath, outputPath, null);
            AssetDatabase.Refresh();
        }

        private static string GetZipPath(out string unityVersion)
        {
            unityVersion = Application.unityVersion;
            string path = $"Packages/net.tnrd.packagemanagerinjection/Editor/Zips/{unityVersion}.zip";
            while (!File.Exists(path))
            {
                if (!unityVersion.Contains("."))
                {
                    return string.Empty;
                }

                unityVersion = unityVersion.Substring(0, unityVersion.LastIndexOf('.'));
                path = $"Packages/net.tnrd.packagemanagerinjection/Editor/Zips/{unityVersion}.zip";
            }

            return path;
        }
    }
}