namespace ExprecionAB4838081
{

    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
           if (!string.IsNullOrEmpty(entry1.Text)&& !string.IsNullOrEmpty(entry2.Text)) 
           {
                double resultado, A, B;
                A = Convert.ToDouble(entry1.Text);
                B = Convert.ToDouble(entry1.Text);
                resultado = Math.Pow((A + B),2)/2;
                entryr.Text = resultado.ToString();
            }
           else
            {
                DisplayAlert("Error","Introduce todos los numeros", "ok");
            }
        }
    }

}
