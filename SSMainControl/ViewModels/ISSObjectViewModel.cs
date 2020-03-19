using SSMainControl.Model;
using SSMainControl.Model.Enum;
using SSMainControl.ViewModels.Impl;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMainControl.ViewModels
{
    public interface ISSObjectViewModel
    {
        SSObjectType FileType { get; set; }
        bool IsSelected { get; set; }
        bool IsExpanded { get; set; }
        SSObjectViewModel Parent { get; }
        ReadOnlyCollection<SSObjectViewModel> Items { get; }
        string Name { get; }
    }
}
