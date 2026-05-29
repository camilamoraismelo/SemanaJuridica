using System;
using Microsoft.Maui.Controls;

namespace SemanaJuridica.Views
{
    public partial class SobreEvento : ContentPage
    {
        public SobreEvento()
        {
            InitializeComponent();
        }

        private async void Fechar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}