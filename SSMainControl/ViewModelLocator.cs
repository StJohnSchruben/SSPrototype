using Microsoft.Practices.Unity;
using SSMainControl.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMainControl
{
    public class ViewModelLocator
    {
        private IUnityContainer container;

        public ViewModelLocator()
        {
            this.container = new UnityContainer();
            this.container.AddExtension(new SSMainContainerExtension());
        }

        public IMainControlViewModel MainControl => this.container.Resolve<IMainControlViewModel>();
        public IRenderedViewModel RenderedView => this.container.Resolve<IRenderedViewModel>();
    }
}
