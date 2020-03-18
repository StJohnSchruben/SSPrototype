using Microsoft.Practices.Unity;
using SSMainControl.ViewModels;
using SSMainControl.ViewModels.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMainControl
{
    public class SSMainContainerExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {
            this.Container.RegisterType<IRenderedViewModel, RenderedViewModel>();
            this.Container.RegisterType<IMainControlViewModel, MainControlViewModel>();
        }
    }
}
