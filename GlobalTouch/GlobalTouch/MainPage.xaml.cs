using Custom;
using Xamarin.Forms;

namespace GlobalTouch
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SetupActionButton();
            SetGlobalTouch();
        }

        private void SetGlobalTouch()
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                var global = DependencyService.Get<IGlobalTouch>();
                global.TapScreen((sender, e) =>
                {
                    //SOME ACTION HERE - 
                    //For iOS, if there is an Alert or DisplayAlert in this block, it will block the call of what actually was clicked.
                });
            });
        }

        private void SetupActionButton()
        {
            button.Command = new Command(() =>
            {
                //SOME ACTION HERE
            });
        }
    }
}
