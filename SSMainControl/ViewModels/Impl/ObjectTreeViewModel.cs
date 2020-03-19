using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using SSMainControl.Model.Enum;
using SSMainControl.Model;
using SSMainControl.ViewModels.Messages;

namespace SSMainControl.ViewModels.Impl
{
    public class ObjectTreeViewModel : ViewModelBase, IObjectTreeViewModel
    {
        private bool isExpanded;
        private bool isSelected;
        private ReadOnlyCollection<ISSObjectViewModel> solutionObjects;
        SSObjectViewModel rootItem;
        public ObjectTreeViewModel(SSObject ssObjects)
        {
            rootItem = new SSObjectViewModel(ssObjects);
            this.solutionObjects = new ReadOnlyCollection<ISSObjectViewModel>(
                new SSObjectViewModel[]
                {
                    rootItem
                });

            this.MessengerInstance.Register<ObjectTreeUpdated>(this, this.ObjectTreeUpdated);
        }

        private void ObjectTreeUpdated(ObjectTreeUpdated obj)
        {
            this.UpdateSolutionItems();
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

        public void UpdateSolutionItems()
        {
            SSObject ssObjects = SolutionObjectData.GetSolutionItems();
            rootItem = new SSObjectViewModel(ssObjects);
            this.solutionObjects = new ReadOnlyCollection<ISSObjectViewModel>(
                new SSObjectViewModel[]
                {
                    rootItem
                }); 
        }
    }
}
