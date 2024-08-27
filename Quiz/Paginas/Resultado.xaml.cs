namespace Quiz.Paginas;

public partial class Resultado : ContentPage
{
	public Resultado()
	{
		InitializeComponent();
	}
    protected async override void OnAppearing()
    {
        base.OnAppearing();

        string nome = await SecureStorage.Default.GetAsync("nome");
        string parcial = await SecureStorage.Default.GetAsync("parcial");
        double final = double.Parse(parcial) / 2 * 100;

        LblSaudacao.Text = "Olá,  " + nome + "!";
        LblResultado.Text = "Você acertou " + final + "% das respostas";
    }
}