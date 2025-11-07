using System;
using System.Windows;

namespace Dragablz
{
    public class NewTabHost<TElement> : INewTabHost<TElement> where TElement : UIElement
    {
        private readonly TElement _container;
        private readonly DragablzItem _tabablzControl;

        public NewTabHost(TElement container, DragablzItem tabablzControl)
        {
            if (container == null) throw new ArgumentNullException("container");
            if (tabablzControl == null) throw new ArgumentNullException("tabablzControl");

            _container = container;
            _tabablzControl = tabablzControl;
        }

        public TElement Container => _container;

        public DragablzItem TabablzControl => _tabablzControl;
    }
}