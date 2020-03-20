using GalaSoft.MvvmLight;
using SSMainControl.Model;
using SSMainControl.Model.Enum;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMainControl.ViewModels.Impl
{
    public class SSObjectViewModel : ViewModelBase, ISSObjectViewModel
    {
        private string name;
        private bool isSelected;
        private bool isExpanded;
        private SSObjectType fileType;

        readonly ReadOnlyCollection<SSObjectViewModel> items;
        readonly SSObjectViewModel parent;
        readonly SSObject item;

        public SSObjectViewModel(SSObject file):this(file, null)
        {
        }

        private SSObjectViewModel(SSObject item, SSObjectViewModel parent)
        {
            this.item = item;
            this.parent = parent;

            items = new ReadOnlyCollection<SSObjectViewModel>(
                    (from thing in item.Items
                     select new SSObjectViewModel(thing, this))
                     .ToList<SSObjectViewModel>());

            this.IsExpanded = true;
        }

        public SSObjectType FileType
        {
            get { return item.FileType; }
        }

        public string Name
        {
            get { return item.Name; }
        }

        public ReadOnlyCollection<SSObjectViewModel> Items
        {
            get { return items; }
        }

        public bool IsExpanded
        {
            get { return isExpanded; }
            set
            {
                this.Set(() => this.IsExpanded, ref this.isExpanded, value);
                
                if (isExpanded && parent != null)
                {
                    parent.IsExpanded = true;
                }
            }
        }

        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                var changed  = this.Set(() => this.IsSelected, ref this.isSelected, value); 
                if (changed)
                {
                    this.item.IsSelected = value;
                }
            }
        }

        public bool NameContainsText(string text)
        {
            if (String.IsNullOrEmpty(text) || String.IsNullOrEmpty(this.Name))
                return false;

            return this.Name.IndexOf(text, StringComparison.InvariantCultureIgnoreCase) > -1;
        }

        public SSObjectViewModel Parent
        {
            get { return parent; }
        }
    }
}
