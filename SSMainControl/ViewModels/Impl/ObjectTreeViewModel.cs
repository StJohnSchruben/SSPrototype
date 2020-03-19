using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using SSMainControl.Model.Enum;
using SSMainControl.Model;

namespace SSMainControl.ViewModels.Impl
{
    public class ObjectTreeViewModel : ViewModelBase, IObjectTreeViewModel
    {
        private bool isExpanded;
        private bool isSelected;
        private ReadOnlyCollection<ISSObjectViewModel> solutionObjects;
        readonly SSObjectViewModel rootItem;
        public ObjectTreeViewModel(SSObject ssObjects)
        {
            rootItem = new SSObjectViewModel(ssObjects);
            this.solutionObjects = new ReadOnlyCollection<ISSObjectViewModel>(
                new SSObjectViewModel[]
                {
                    rootItem
                });
        }

        public bool IsExpanded
        {
            get
            {
                return this.isExpanded;
            }

            set
            {
                this.Set(() => this.IsExpanded, ref this.isExpanded, value);
            }
        }

        public bool IsSelected
        {
            get
            {
                return this.isSelected;
            }

            set
            {
                this.Set(() => this.IsSelected, ref this.isSelected, value);
            }
        }

        public ReadOnlyCollection<ISSObjectViewModel> SolutionObjects
        {
            get
            {
                return this.solutionObjects;
            }
        }
    }
}
