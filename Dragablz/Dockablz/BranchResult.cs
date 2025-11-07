using System;

namespace Dragablz.Dockablz
{
    public class BranchResult
    {
        private readonly Branch _branch;
        private readonly DragablzItem _DragablzItem;

        public BranchResult(Branch branch, DragablzItem DragablzItem)
        {
            if (branch == null) throw new ArgumentNullException("branch");
            if (DragablzItem == null) throw new ArgumentNullException("DragablzItem");

            _branch = branch;
            _DragablzItem = DragablzItem;
        }

        /// <summary>
        /// The new branch.
        /// </summary>
        public Branch Branch
        {
            get { return _branch; }
        }

        /// <summary>
        /// The new tab control.
        /// </summary>
        public DragablzItem DragablzItem
        {
            get { return _DragablzItem; }
        }
    }
}