using SSMainControl.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMainControl.ViewModels
{
    public interface IRenderedViewModel 
    {
        DiagramType SelectedMode { get; set; }
    }
}
