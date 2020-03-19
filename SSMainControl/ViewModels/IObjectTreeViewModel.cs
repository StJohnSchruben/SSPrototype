using SSMainControl.Model.Enum;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMainControl.ViewModels
{
    public interface IObjectTreeViewModel
    {
        bool IsSelected { get; set; }
        bool IsExpanded { get; set; }

        ReadOnlyCollection<ISSObjectViewModel> SolutionObjects { get; }

        void UpdateSolutionItems();
    }
}
