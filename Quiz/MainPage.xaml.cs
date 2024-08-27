using Quiz.Paginas;

namespace Quiz
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            SecureStorage.Default.RemoveAll();
            SecureStorage.Default.SetAsync("parcial", "0");
        }


        private async void BtnIniciar_Clicked(object sender, EventArgs e)
        {
            string pergunta = await DisplayPromptAsync("Pergunta", "Qual é seu nome? ", "OK", "Cancelar");

            await SecureStorage.Default.SetAsync("nome", pergunta);

            await Navigation.PushAsync(new Questao1());
        }
    }

}
