using System;
using TNRD.Events;
using UnityEditor;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.UIElements;
using PackageInfo = UnityEditor.PackageManager.PackageInfo;

namespace TNRD.PackageManager
{
    public class PackageManagerInjectionHelper : IPackageManagerExtension
    {
        private static InjectedVisualElement instance;
        private static bool injectedVisualElementInitialized;
        private static SafeEvent injected;

        /// <summary>
        /// A visual element which gets injected into the Package Manager Window
        /// </summary>
        public static InjectedVisualElement InjectedVisualElement => instance;

        /// <summary>
        /// Fires when the InjectedVisualElement gets injected into the Package Manager Window
        /// </summary>
        public static event Action Injected
        {
            add => injected += value;
            remove => injected -= value;
        }

        /// <summary>
        /// Is the InjectedVisualElement available for usage
        /// </summary>
        public static bool IsAvailable => instance != null && injectedVisualElementInitialized;

        [InitializeOnLoadMethod]
        private static void RegisterExtension()
        {
            PackageManagerExtensions.RegisterExtension(new PackageManagerInjectionHelper());
        }

        VisualElement IPackageManagerExtension.CreateExtensionUI()
        {
            instance = new InjectedVisualElement();
            instance.Initialized += InjectedVisualElementInitialized;
            return instance;
        }

        private void InjectedVisualElementInitialized()
        {
            injectedVisualElementInitialized = true;
            injected.Invoke();
        }

        void IPackageManagerExtension.OnPackageSelectionChange(PackageInfo packageInfo)
        {
        }

        void IPackageManagerExtension.OnPackageAddedOrUpdated(PackageInfo packageInfo)
        {
        }

        void IPackageManagerExtension.OnPackageRemoved(PackageInfo packageInfo)
        {
        }
    }
}