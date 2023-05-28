using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustCash.Kiosk.Client.ViewModels
{
    public class ShellViewModel : Conductor<object>.Collection.OneActive
    {
        private readonly INavigationService _navigationService;

        public ShellViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        // Můžeme také vytvořit metody pro navigaci mezi různými Views.
        public void BuyBitcoinCommand()
        {
            _navigationService.NavigateToViewModel<PinEnterViewModel>();
        }
    }
}
