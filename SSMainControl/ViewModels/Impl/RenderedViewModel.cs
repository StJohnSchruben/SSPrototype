using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSMainControl.Model.Enum;
using Lwi;
using GalaSoft.MvvmLight;
using SSMainControl.ViewModels.Messages;

namespace SSMainControl.ViewModels.Impl
{
    public class RenderedViewModel : ViewModelBase, IRenderedViewModel
    {
        private DiagramTypes selectedMode;

        public RenderedViewModel()
        {
            this.MessengerInstance.Register<DiagramModeChanged>(this, this.OnDiagramModeChanged);
        }

        private void OnDiagramModeChanged(DiagramModeChanged message)
        {
            this.SelectedMode = message.DiagramMode;
        }

        public DiagramTypes SelectedMode
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
    }
}
