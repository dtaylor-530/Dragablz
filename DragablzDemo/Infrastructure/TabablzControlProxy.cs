using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;
using Dragablz;
using Dragablz.Dockablz;

namespace DragablzDemo
{
    public class DragablzItemProxy : INotifyPropertyChanged
    {
        private readonly DragablzItem _DragablzItem;
        private readonly ICommand _splitHorizontallyCommand;
        private readonly ICommand _splitVerticallyCommand;
        private double _splitRatio;

        public DragablzItemProxy(DragablzItem DragablzItem)
        {
            _DragablzItem = DragablzItem;

            _splitHorizontallyCommand = new AnotherCommandImplementation(_ => Branch(Orientation.Horizontal));
            _splitVerticallyCommand = new AnotherCommandImplementation(_ => Branch(Orientation.Vertical));
            SplitRatio = 5;
        }

        public ICommand SplitHorizontallyCommand
        {
            get { return _splitHorizontallyCommand; }
        }

        public ICommand SplitVerticallyCommand
        {
            get { return _splitVerticallyCommand; }
        }

        public double SplitRatio
        {
            get { return _splitRatio; }
            set
            {
                _splitRatio = value;
                OnPropertyChanged("SplitRatio");
            }
        }

        private void Branch(Orientation orientation)
        {
            var branchResult = Layout.Branch(_DragablzItem, orientation, false, SplitRatio / 10);

            var newItem = new HeaderedItemViewModel
            {
                Header = "Code-Wise",
                Content = "This item was added in via code, using Layout.Branch, and DragablzItem.AddToSource"
            };

            branchResult.DragablzItem.AddToSource(newItem);
            branchResult.DragablzItem.SelectedItem = newItem;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}