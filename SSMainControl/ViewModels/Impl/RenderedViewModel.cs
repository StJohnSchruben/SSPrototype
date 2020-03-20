using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSMainControl.Model.Enum;
using Lwi;
using GalaSoft.MvvmLight;
using SSMainControl.ViewModels.Messages;
using SSMainControl.Model;
using System.Threading;

namespace SSMainControl.ViewModels.Impl
{
    public class RenderedViewModel : ViewModelBase, IRenderedViewModel
    {
        private DiagramType selectedMode;
        private SSObject ssObjects;
        public RenderedViewModel(SSObject ssObjects)
        {
            this.ssObjects = ssObjects;
            this.MessengerInstance.Register<DiagramModeChanged>(this, this.OnDiagramModeChanged);
        }

        private void OnDiagramModeChanged(DiagramModeChanged message)
        {
            this.SelectedMode = message.DiagramMode;
            if(this.ssObjects != null)
            {
                ;
            }
        }

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
    }
}
