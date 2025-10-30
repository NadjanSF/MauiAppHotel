namespace MauiAppHotel
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        //linha adicionada para registrar a rota da nova página Sobre//
            Routing.RegisterRoute(nameof(Sobre), typeof(Sobre));
        }
    }
}
