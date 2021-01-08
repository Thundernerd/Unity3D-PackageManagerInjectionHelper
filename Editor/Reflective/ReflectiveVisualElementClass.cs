using JetBrains.Annotations;
using TNRD.Reflectives;
using UnityEngine.UIElements;

namespace TNRD.PackageManager
{
    public class ReflectiveVisualElementClass : ReflectiveClass
    {
        /// <summary>
        /// The original visual element this class wraps around
        /// </summary>
        [PublicAPI]
        public readonly VisualElement Element;

        protected ReflectiveVisualElementClass(object instance) : base(instance)
        {
            Element = (VisualElement) instance;
        }
    }
}