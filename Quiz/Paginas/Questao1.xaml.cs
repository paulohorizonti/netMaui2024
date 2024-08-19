namespace Quiz.Paginas;

public partial class Questao1 : ContentPage
{
    bool marcou = false;
    bool acerto = false;
	public Questao1()
	{
		InitializeComponent();
	}
    protected async override void OnAppearing()
    {
                 base.OnAppearing();

        string nome = await SecureStorage.Default.GetAsync("nome");

       
    }

    private void Verificar(object sender, EventArgs e)
    {
        if (marcou)
        {
            marcou = false;
            
        }
        else
        {
            RadioButton opcao = sender as RadioButton;
            string valor = opcao.Value.ToString();

            if (valor.Contains("certo"))
            {
                acerto = true;

            }
            else
            {
                acerto = false;
            }
            marcou = true;

        }
    }

    private void BtnVerificar_Clicked(object sender, EventArgs e)
    {
        if (acerto)
        {
            DisplayAlert("Resultado", "Você acertou!", "OK");
        }
        else
        {
            DisplayAlert("Resultado", "Você errou, que pena!", "OK");
        }
    }
}