using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using SSMainControl.Model.Enum;
using SSMainControl.ViewModels.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SSMainControl.ViewModels.Impl
{
    public class MainControlViewModel : ViewModelBase, IMainControlViewModel
    {
        private DiagramType selectedMode;

        public MainControlViewModel()
        {
            this.selectedMode = DiagramType.Class;
        }

        public ICommand ModeSelectionCommand => new SSMainControl.ViewModels.CustomControls.ParamedRelayCommand(this.ModeSelectionChanged);

        private void ModeSelectionChanged(object parameter)
        {
            if (parameter != null)
            {
                DiagramType mode;
                if (Enum.TryParse(parameter.ToString(), true, out mode))
                {
                    this.SelectedMode = mode;
                }
            }
        }

        public ICommand RenderCommand => new RelayCommand(this.RenderClicked);

        public DiagramType SelectedMode
        {
            get
            {
                return this.selectedMode;
            }

            set
            {
                this.Set(() => this.SelectedMode, ref this.selectedMode, value);
            }
        }

        private void RenderClicked()
        {
            this.MessengerInstance.Send(
                new DiagramModeChanged
                {
                    DiagramMode = this.SelectedMode
                });
        }
    }
}
