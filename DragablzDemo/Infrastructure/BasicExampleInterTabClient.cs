using System.Windows;
using Dragablz;

namespace DragablzDemo
{
    public class BasicExampleInterTabClient : IInterTabClient
    {
        public INewTabHost<Window> GetNewHost(IInterTabClient interTabClient, object partition, DragablzItem source)
        {
            var view = new BasicExampleTemplateWindow();
            var model = new BasicExampleTemplateModel(interTabClient, partition);
            view.DataContext = model;
            return new NewTabHost<Window>(view, view.DragablzItem);
        }

        public TabEmptiedResponse TabEmptiedHandler(DragablzItem tabControl, Window window)
        {
            return TabEmptiedResponse.CloseWindowOrLayoutBranch;
        }
    }
}