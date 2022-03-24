using System;
using System.Collections.Generic;
using System.Text;
using Venta_SLM_App.ViewModels;
namespace Venta_SLM_App.Infrastructure
{
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }
        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
    }
}
