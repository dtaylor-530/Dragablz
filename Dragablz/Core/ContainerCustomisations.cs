using System;
using System.Windows;

namespace Dragablz
{
    internal class ContainerCustomisations(Func<DragablzItem> getContainerForItemOverride = null, Action<DependencyObject, object> prepareContainerForItemOverride = null, Action<DependencyObject, object> clearingContainerForItemOverride = null)
    {
        public DragablzItem? GetContainerForItemOverride()
        {
            return getContainerForItemOverride?.Invoke();
        }

        public void PrepareContainerForItemOverride(DependencyObject dObj, object obj)
        {
            prepareContainerForItemOverride?.Invoke(dObj, obj);
        }

        public void ClearingContainerForItemOverride(DependencyObject dObj, object obj)
        {
            clearingContainerForItemOverride?.Invoke(dObj, obj);
        }
    }
}