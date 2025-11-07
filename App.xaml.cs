// **PERSONALIZAÇÃO (MINHA IDEIA):** Mudei os nomes e preços das suítes
// para combinar com o tema "Castelo da Nadjan" (Halloween).

using MauiAppHotel.Models;
using MauiAppHotel.Views;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        // Propriedade global para a lista de quartos
        public List<Quarto> lista_quartos = new List<Quarto>();

        public App()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Sobre), typeof(Sobre));

            // Adicionando quartos temáticos de Halloween
            lista_quartos.Add(new Quarto
            {
                Descricao = "A Cripta do Vampiro",
                ValorDiariaAdulto = 110.0,
                ValorDiariaCrianca = 55.0
            });

            lista_quartos.Add(new Quarto
            {
                Descricao = "Cabana da Bruxa",
                ValorDiariaAdulto = 80.0,
                ValorDiariaCrianca = 40.0
            });

            lista_quartos.Add(new Quarto
            {
                Descricao = "Torre da Masmorra",
                ValorDiariaAdulto = 50.0,
                ValorDiariaCrianca = 25.0
            });
            lista_quartos.Add(new Quarto
            {
                Descricao = "Porão",
                ValorDiariaAdulto = 25.0,
                ValorDiariaCrianca = 2.50
            });


            MainPage = new NavigationPage(new ContratacaoHospedagem());
        }
    }
}