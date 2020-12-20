using System;
using TNRD.Events;
using TNRD.PackageManager.Reflected;
using UnityEditor;
using UnityEngine.UIElements;

namespace TNRD.PackageManager
{
    public class InjectedVisualElement : VisualElement
    {
        private VisualElementCache cache;

        internal bool IsInitialized;
        private SafeEvent initialized;

        public event Action Initialized
        {
            add => initialized += value;
            remove => initialized -= value;
        }

        public VisualElement Root { get; private set; }

        public PackageManagerToolbar PackageManagerToolbar => new PackageManagerToolbar(Root.Q("topMenuToolbar"));//.Get("topMenuToolbar"));
        public PackageList PackageList => new PackageList(Root.Q("packageList"));
        public PackageStatusBar PackageStatusBar => new PackageStatusBar(Root.Q("packageStatusBar"));
        public PackageDetails PackageDetails => new PackageDetails(Root.Q("packageDetails"));
        public PackageToolbar PackageToolbar => new PackageToolbar(Root.Q("packageToolbar"));

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

            cache = new VisualElementCache(Root);

            initialized.Invoke();
            IsInitialized = true;
        }
    }
}