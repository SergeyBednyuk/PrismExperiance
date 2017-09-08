using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.ServiceLocation;
using PrismRegionSampleApp.Modules;
using PrismRegionSampleApp.Views;

namespace PrismRegionSampleApp
{
    public class Bootstrapper : UnityBootstrapper
    {
        
        protected override DependencyObject CreateShell()
        {
            var shell = Container.Resolve<Shell>();
            //shell.Show();
           
            return shell;
        }

        protected override void InitializeModules()
        {
            IModule moduleBook = Container.Resolve<BookModule>();
            IModule moduleCustomer = Container.Resolve<CustomerModule>();

            moduleBook.Initialize();
            moduleCustomer.Initialize();
        }
    }
}
