using GalaSoft.MvvmLight.Messaging;
using SSMainControl.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMainControl.ViewModels.Messages
{
    public class DiagramModeChanged : MessageBase
    {
        public DiagramType DiagramMode { get; set; }
    }
}
