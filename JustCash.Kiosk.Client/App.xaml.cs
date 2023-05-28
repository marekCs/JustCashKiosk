using Autofac;
using Caliburn.Micro;
using JustCash.Kiosk.Client.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace JustCash.Kiosk.Client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IContainer _container;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // vytvoříme kontejner a registrujeme služby a ViewModely
            var builder = new ContainerBuilder();
            builder.RegisterType<ShellViewModel>();
            builder.RegisterType<AmountSelectionViewModel>();
            builder.RegisterType<PinEnterViewModel>();
            builder.RegisterType<ConfirmationViewModel>();
            builder.RegisterType<ReceiptViewModel>();

            // Servisy
            builder.RegisterType<ReceiptViewModel>();

            _container = builder.Build();

            // nastavíme Caliburn.Micro
            PlatformProvider.Current = new XamlPlatformProvider();
            ViewModelLocator.AddNamespaceMapping("JustCash.Kiosk.Client.Views", "JustCash.Kiosk.Client.ViewModels");
            ViewLocator.AddNamespaceMapping("JustCash.Kiosk.Client.ViewModels", "JustCash.Kiosk.Client.Views");

            // spustíme hlavní okno aplikace
            var shellViewModel = _container.Resolve<ShellViewModel>();
            var windowManager = new WindowManager();
            windowManager.ShowWindowAsync(shellViewModel);
        }
    }
}
