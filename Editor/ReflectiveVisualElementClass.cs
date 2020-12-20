using TNRD.Reflectives;
using UnityEngine.UIElements;

namespace TNRD.PackageManager
{
    public class ReflectiveVisualElementClass : ReflectiveClass
    {
        public VisualElement Element;

        protected ReflectiveVisualElementClass(object instance) : base(instance)
        {
            Element = (VisualElement) instance;
        }
    }
}