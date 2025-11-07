// guardar os dados da reserva (quarto, pessoas, datas) e
// calcular o total da estadia (na propriedade "ValorTotal").
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppHotel.Models
{
    public class Hospedagem
    {
        public Quarto QuartoSelecionado { get; set; }
        public int QntAdultos { get; set; }
        public int QntCriancas { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        
        // Propriedade Read-Only (Somente Leitura)
        // Calcula o tempo total da estadia
        public int Estadia
        {
            get => DataCheckOut.Subtract(DataCheckIn).Days;
        }
        // Propriedade Read-Only (Somente Leitura)
        // Calcula o valor total da hospedagem
                public double ValorTotal
        {
            get
            {
                // Valor Adultos
                double valor_adultos = QntAdultos * QuartoSelecionado.ValorDiariaAdulto;
                // Valor Crianças
                double valor_criancas = QntCriancas * QuartoSelecionado.ValorDiariaCrianca;

                double total = (valor_adultos + valor_criancas) * Estadia;

                return total;
            }
        }
    }
}