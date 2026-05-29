using System;
using Microsoft.Maui.Controls;
using SemanaJuridica.Models;

namespace SemanaJuridica.Views
{
    public partial class CadastroEvento : ContentPage
    {
        public CadastroEvento()
        {
            InitializeComponent();

            DateTime dataLimiteInicio = new DateTime(2026, 06, 22);
            DateTime dataLimiteFim = new DateTime(2026, 06, 28);

            dtpck_inicio.MinimumDate = dataLimiteInicio;
            dtpck_inicio.MaximumDate = dataLimiteFim;
            dtpck_inicio.Date = dataLimiteInicio;

            dtpck_termino.MinimumDate = dataLimiteInicio.AddDays(1);
            dtpck_termino.MaximumDate = dataLimiteFim;
            dtpck_termino.Date = dataLimiteFim;
        }

        private void dtpck_inicio_DateSelected(object sender, DateChangedEventArgs e)
        {
            if (dtpck_termino != null && e.NewDate.HasValue)
            {
                dtpck_termino.MinimumDate = e.NewDate.Value.AddDays(1);
            }
        }

        private async void Concluir_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_nome.Text) || pck_tipo.SelectedIndex == -1)
            {
                await DisplayAlert("Atenção", "Preencha todos os campos.", "OK");
                return;
            }

            try
            {
              
                Evento ev = new Evento
                {
                    NomeEvento = txt_nome.Text,
                    TipoInscricao = pck_tipo.SelectedItem.ToString(),
                    DataInicio = dtpck_inicio.Date.Value,
                    DataTermino = dtpck_termino.Date.Value,
                    NumeroParticipantes = Convert.ToInt32(stp_participantes.Value),
                    
                };

               
                await Navigation.PushAsync(new CadastroRealizado()
                {
                    BindingContext = ev
                });
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "OK");
            }
        }

        private async void Sobre_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SobreEvento());
        }
    }
}