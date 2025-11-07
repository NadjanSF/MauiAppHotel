using MauiAppHotel.Views;

namespace MauiAppHotel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HospedagemContratada : ContentPage
    {
        public HospedagemContratada()
        {
            InitializeComponent();
        }

        private async void Voltar_Clicked(object sender, EventArgs e)
        {
            // PopToRootAsync limpa a pilha e volta para a página inicial (root)
            await Navigation.PopToRootAsync();
        }
    }
}