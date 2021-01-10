using System;
using JetBrains.Annotations;
using TNRD.Events;
using TNRD.PackageManager.Reflected;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace TNRD.PackageManager
{
    /// <summary>
    /// A visual element that gets added to the Package Manager Window through an IPackageManagerExtension
    /// </summary>
    [PublicAPI]
    public class InjectedVisualElement : VisualElement
    {
        internal bool IsInitialized;
        private SafeEvent initialized;

        internal event Action Initialized
        {
            add => initialized += value;
            remove => initialized -= value;
        }

        /// <summary>
        /// The root Visual Element of the Package Manager Window
        /// </summary>
        [PublicAPI]
        public VisualElement Root { get; private set; }

        /// <summary>
        /// Reflected Package Manager Toolbar section of the Package Manager Window
        /// </summary>
        [PublicAPI]
        public PackageManagerToolbar PackageManagerToolbar => Root == null ? null : new PackageManagerToolbar(Root.Q("toolbarContainer"));
        
        /// <summary>
        /// Reflected Package List section of the Package Manager Window
        /// </summary>
        [PublicAPI]
        public PackageList PackageList => Root == null ? null : new PackageList(Root.Q("packageList"));
        
        /// <summary>
        /// Reflected Package Status Bar section of the Package Manager Window
        /// </summary>
        [PublicAPI]
        public PackageStatusBar PackageStatusBar => Root == null ? null : new PackageStatusBar(Root.Q("packageStatusBar"));
        
        /// <summary>
        /// Reflected Package Details section of the Package Manager Window
        /// </summary>
        [PublicAPI]
        public PackageDetails PackageDetails => Root == null ? null : new PackageDetails(Root.Q("detailsGroup"));
        
        /// <summary>
        /// Reflected Package Toolbar section of the Package Manager Window
        /// </summary>
        [PublicAPI]
        public PackageToolbar PackageToolbar => Root == null ? null : new PackageToolbar(Root.Q("packageToolBar"));

        public InjectedVisualElement()
        {
            EditorApplication.delayCall += Initialize;
        }

        private void Initialize()
        {
            Root = this;

            while (Root.parent != null)
            {
                Root = Root.parent;
            }

            initialized.Invoke();
            IsInitialized = true;
        }
    }
}