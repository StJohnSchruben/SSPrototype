using SSMainControl.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SSMainControl.ViewModels
{
    public interface IMainControlViewModel
    {
        ICommand RenderCommand { get; }
        ICommand ModeSelectionCommand { get; }
        ICommand UpdateTreeCommand { get; }
        DiagramType SelectedMode { get; set; }
    }
}
