using System;

namespace SemanaJuridica.Models
{
    public class Evento
    {
        public string NomeEvento { get; set; }
        public string TipoInscricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public string LocalEvento { get; set; }

        
        public double ValorDiaria
        {
            get
            {
                if (TipoInscricao != null && TipoInscricao.Contains("Cursos"))
                    return TipoInscricao.Contains("Palestras") ? 300.0 : 200.0;
                return 150.0; 
            }
        }

        
        public int DuracaoDias
        {
            get
            {
                TimeSpan diferenca = DataTermino.Subtract(DataInicio);
                return diferenca.Days == 0 ? 1 : diferenca.Days;
            }
        }

        
        public double CustoTotal
        {
            get
            {
                return NumeroParticipantes * ValorDiaria * DuracaoDias;
            }
        }
    }
}