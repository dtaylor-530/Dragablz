using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Dragablz
{
    public interface IItemsOrganiser
    {
        void Organise(DragablzItem requestor, Size measureBounds, IEnumerable<DragablzItem> items);
        void Organise(DragablzItem requestor, Size measureBounds, IOrderedEnumerable<DragablzItem> items);
        void OrganiseOnMouseDownWithin(DragablzItem requestor, Size measureBounds, List<DragablzItem> siblingItems, DragablzItem dragablzItem);
        void OrganiseOnDragStarted(DragablzItem requestor, Size measureBounds, IEnumerable<DragablzItem> siblingItems, DragablzItem dragItem);
        void OrganiseOnDrag(DragablzItem requestor, Size measureBounds, IEnumerable<DragablzItem> siblingItems, DragablzItem dragItem);
        void OrganiseOnDragCompleted(DragablzItem requestor, Size measureBounds, IEnumerable<DragablzItem> siblingItems, DragablzItem dragItem);        
        Point ConstrainLocation(DragablzItem requestor, Size measureBounds, Point itemCurrentLocation, Size itemCurrentSize, Point itemDesiredLocation, Size itemDesiredSize);
        Size Measure(DragablzItem requestor, Size availableSize, IEnumerable<DragablzItem> items);
        IEnumerable<DragablzItem> Sort(IEnumerable<DragablzItem> items);
    }
}
