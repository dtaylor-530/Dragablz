using System;

namespace Dragablz.Dockablz
{
    internal class FloatTransfer
    {
        private readonly double _width;
        private readonly double _height;
        private readonly object _content;

        public FloatTransfer(double width, double height, object content)
        {
            if (content == null) throw new ArgumentNullException("content");

            _width = width;
            _height = height;
            _content = content;
        }

        public static FloatTransfer TakeSnapshot(DragablzItem dragablzItem, DragablzItem sourceTabControl)
        {
            if (dragablzItem == null) throw new ArgumentNullException("dragablzItem");

            return new FloatTransfer(sourceTabControl.ActualWidth, sourceTabControl.ActualHeight, dragablzItem.UnderlyingContent ?? dragablzItem.Header ?? dragablzItem);
        }

        [Obsolete]
        public double Width
        {
            get { return _width; }
        }

        [Obsolete]
        public double Height
        {
            get { return _height; }
        }

        public object Content
        {
            get { return _content; }
        }
    }
}