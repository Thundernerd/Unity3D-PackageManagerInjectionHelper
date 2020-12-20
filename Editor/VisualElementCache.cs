using System.Collections.Generic;
using UnityEngine.UIElements;

namespace TNRD.PackageManager
{
    public class VisualElementCache
    {
        private readonly VisualElement root;

        private Dictionary<string, VisualElement> cache = new Dictionary<string, VisualElement>();

        public VisualElementCache(VisualElement root)
        {
            this.root = root;
        }

        public VisualElement this[string name]
        {
            get
            {
                if (cache.TryGetValue(name, out VisualElement element))
                {
                    return element;
                }

                cache[name] = root.Q(name);
                return cache[name];
            }
        }

        public VisualElement Get(string name)
        {
            return this[name];
        }

        public T Get<T>(string name) where T : VisualElement
        {
            return this[name] as T;
        }
    }
}