using System.Windows;
using Dragablz;

namespace DragablzDemo
{
    public class BoundExampleInterTabClient : IInterTabClient
    {
        public INewTabHost<Window> GetNewHost(IInterTabClient interTabClient, object partition, DragablzItem source)
        {
            var view = new BoundExampleWindow();
            var model = new BoundExampleModel();
            view.DataContext = model;
            return new NewTabHost<Window>(view, view.InitialDragablzItem);
        }

        public TabEmptiedResponse TabEmptiedHandler(DragablzItem tabControl, Window window)
        {
            return TabEmptiedResponse.CloseWindowOrLayoutBranch;
        }
    }
}