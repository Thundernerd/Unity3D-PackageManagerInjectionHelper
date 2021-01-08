using System;
using JetBrains.Annotations;
using TNRD.Events;
using UnityEditor;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.UIElements;
using PackageInfo = UnityEditor.PackageManager.PackageInfo;

namespace TNRD.PackageManager
{
    /// <summary>
    /// A Package Manager extension that injects an instance of <see cref="InjectedVisualElement"/> into the Package Manager Window
    /// </summary>
    [PublicAPI]
    public class PackageManagerInjectionHelper : IPackageManagerExtension
    {
        private static InjectedVisualElement instance;
        private static bool injectedVisualElementInitialized;
        private static SafeEvent injected;

        /// <summary>
        /// A visual element which gets injected into the Package Manager Window
        /// </summary>
        [PublicAPI]
        public static InjectedVisualElement InjectedVisualElement => instance;

        /// <summary>
        /// Fires when the InjectedVisualElement gets injected into the Package Manager Window
        /// </summary>
        [PublicAPI]
        public static event Action Injected
        {
            add
            {
                if (injectedVisualElementInitialized)
                {
                    value.Invoke();
                }
                else
                {
                    injected += value;
                }
            }
            remove => injected -= value;
        }

        /// <summary>
        /// Is the InjectedVisualElement available for usage
        /// </summary>
        [PublicAPI]
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