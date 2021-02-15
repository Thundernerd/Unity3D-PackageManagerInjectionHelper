using System.IO;
using ICSharpCode.SharpZipLib.Zip;
using TNRD.Utilities;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

namespace TNRD.PackageManager.Injection
{
    internal static class Installer
    {
        private const string SYMBOL = "PACKAGE_MANAGER_INJECTION";

        [InitializeOnLoadMethod, DidReloadScripts, MenuItem("TNRD/Package Manager/Extract Injector")]
        private static void Init()
        {
            string zipPath = GetZipPath(out string unityVersion);
            if (string.IsNullOrEmpty(zipPath))
            {
                ScriptingDefineUtility.Remove(SYMBOL);
                Debug.LogError("This version of Unity is not supported by the Package Manager Injection Helper");
                return;
            }

            string outputPath = Path.Combine(Application.dataPath, "TNRD", "Package Manager", "Injection", unityVersion);

            if (Directory.Exists(outputPath) && Directory.GetFiles(outputPath, "PackageManagerInjectionHelper.cs", SearchOption.AllDirectories).Length == 1)
            {
                if (!ScriptingDefineUtility.Contains(SYMBOL))
                {
                    ScriptingDefineUtility.Add(SYMBOL);
                }

                return;
            }

            RemoveExisting();
            ExtractNew(zipPath, outputPath);
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

        private static void RemoveExisting()
        {
            string injectionDirectoryPath = Path.Combine(Application.dataPath, "TNRD", "Package Manager", "Injection");
            if (Directory.Exists(injectionDirectoryPath))
            {
                string[] directories = Directory.GetDirectories(injectionDirectoryPath);
                foreach (string directory in directories)
                {
                    Directory.Delete(directory, true);
                }
            }
        }

        private static void ExtractNew(string zipPath, string outputPath)
        {
            string fullPath = Path.GetFullPath(zipPath);
            FastZip fastZip = new FastZip();
            fastZip.ExtractZip(fullPath, outputPath, null);
            AssetDatabase.Refresh();
        }

#if TNRD_DEV
        [MenuItem("TNRD/Update Zip")]
        private static void UpdateZip()
        {
            string[] directories = Directory.GetDirectories("Assets/TNRD/Package Manager/Injection", "*", SearchOption.TopDirectoryOnly);
            foreach (string directory in directories)
            {
                string path = directory.Replace("\\", "/");
                string zipName = path.Substring(path.LastIndexOf('/') + 1);
                string zipPath = path;
                FastZip fastZip = new FastZip();
                fastZip.CreateZip($"Packages/net.tnrd.packagemanagerinjectionhelper/Editor/Zips/{zipName}.zip", zipPath, true, null);
            }
        }
#endif
    }
}
