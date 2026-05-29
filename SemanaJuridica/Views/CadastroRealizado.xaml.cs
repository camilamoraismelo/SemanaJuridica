using System;
using Microsoft.Maui.Controls;

namespace SemanaJuridica.Views
{
    public partial class CadastroRealizado : ContentPage
    {
        public CadastroRealizado()
        {
            InitializeComponent();
        }

        private async void Voltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}