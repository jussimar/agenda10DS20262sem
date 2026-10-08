namespace PrimeiroProjeto
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        

        private void calcular_Clicked(object sender, EventArgs e)
        {
            double imc = Double.Parse(peso.Text) / (Double.Parse(altura.Text) * Double.Parse(altura.Text));
            string resp = "Paciente: " + nome.Text + " e seu imc é: " + imc;
            DisplayAlert("Resultado", resp, "Sair");
        }
    }
}
