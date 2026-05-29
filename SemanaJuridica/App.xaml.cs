using Microsoft.Maui.Controls;

namespace SemanaJuridica
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            
            MainPage = new NavigationPage(new SemanaJuridica.Views.CadastroEvento());
        }


        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);

            
            window.Width = 400;
            window.Height = 650;

            return window;
        }
    }
}