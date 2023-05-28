using Caliburn.Micro;
using System.Windows;

namespace JustCash.Kiosk.Client.ViewModels
{
    public class PinEnterViewModel : Screen
    {
        private string _pin;
        private string _statusMessage;

        public string Pin
        {
            get => _pin;
            set => Set(ref _pin, value);
        }

        public string StatusMessage
        {
            get => _statusMessage;
            set => Set(ref _statusMessage, value);
        }

        public void Back()
        {
            // Implement logic to go back
        }

        public void NumberCommand(string number)
        {
            Pin += number;
        }

        public void VerifyCommand()
        {
            // Implement logic to verify the PIN
            if (Pin == "1234")
            {
                StatusMessage = "PIN verified successfully!";
            }
            else
            {
                StatusMessage = "Wrong PIN!";
            }
        }
    }
}
