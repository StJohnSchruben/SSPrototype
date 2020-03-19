using Microsoft.Practices.Unity;
using SSMainControl.Model;
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
            this.Container.RegisterType<ISSObjectViewModel, SSObjectViewModel>();
            this.Container.RegisterType<IObjectTreeViewModel, ObjectTreeViewModel>(new InjectionFactory(c => new ObjectTreeViewModel(TestModel.GetSolutionItems())));
        }
    }
}
