using MauiAppHotel.Models;

namespace MauiAppHotel.Views
{
    public partial class ContratacaoHospedagem : ContentPage
    {
        App PropriedadesApp;

        public ContratacaoHospedagem()
        {
            InitializeComponent();
            PropriedadesApp = (App)Application.Current;

            // Define a fonte de dados do Picker para a lista global de quartos
            pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

            // Define as datas mínimas e máximas dos DatePickers
            dtpck_checkin.MinimumDate = DateTime.Now;
            dtpck_checkin.MaximumDate = DateTime.Now.AddMonths(6);

            dtpck_checkout.MinimumDate = DateTime.Now.AddDays(1);
            dtpck_checkout.MaximumDate = DateTime.Now.AddMonths(6).AddDays(1);
        }

        // Este é o método do botão "Avançar"
        private async void Button_Clicked(object sender, EventArgs e)
        {
            // Validação para o Quarto (Picker)
            if (pck_quarto.SelectedItem == null)
            {
                await DisplayAlert("Ops!", "Por favor, selecione uma de nossas suítes assombradas.", "OK");
                return; // Para a execução do método aqui
            }
            // Validação para garantir que a data de check-out
            // seja maior que a data de check-in.
            if (dtpck_checkout.Date <= dtpck_checkin.Date)
            {
                await DisplayAlert("Ops!", "A data de Check-out deve ser pelo menos um dia *depois* da data de Check-in.", "OK");
                return; // Para a execução do método aqui
            }


            // Se o "if" for falso (ou seja, uma suíte foi selecionada),
            // o código continua para o "try"
            try
            {
                // Cria o objeto hospedagem com os dados da tela
                Hospedagem h = new Hospedagem
                {
                    QuartoSelecionado = (Quarto)pck_quarto.SelectedItem, // Agora é seguro
                    QntAdultos = Convert.ToInt32(stp_adultos.Value),
                    QntCriancas = Convert.ToInt32(stp_criancas.Value),
                    DataCheckIn = dtpck_checkin.Date,
                    DataCheckOut = dtpck_checkout.Date,
                };

                // Navega para a próxima tela (Resumo)
                // Enviando o objeto 'h' como BindingContext
                await Navigation.PushAsync(new HospedagemContratada()
                {
                    BindingContext = h
                });
            }
            catch (Exception ex)
            {
                // Mostra um alerta em caso de erro
                await DisplayAlert("Ops, ocorreu um erro!", ex.Message, "OK");
            }
        }

        // Esta é a validação de datas.
        // Quando o Check-in muda, ele força o Check-out a ser
        // no mínimo 1 dia depois.
        private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
        {
            DatePicker elemento = sender as DatePicker;

            DateTime data_selecionada_checkin = elemento.Date;

            dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
            dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);

            // Se o usuário mudar o check-in para *depois* do check-out atual,
            // força o check-out a ser 1 dia depois do novo check-in.
            // Isso evita um erro de data inválida!
            if (dtpck_checkout.Date <= data_selecionada_checkin)
            {
                dtpck_checkout.Date = data_selecionada_checkin.AddDays(1);
            }
        }

        // Esta é a função personalizada para o botão "Sobre"
        // que abre a página do "Castelo da Nadjan".
        private async void OnSobreClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sobre());
        }
    }
}