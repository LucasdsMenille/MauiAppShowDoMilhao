
namespace MauiAppShowDoMilhao
{
    public partial class MainPage : ContentPage
    {
        double premio = 0;
        int pergunta_count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private async void Button_CLicked_Proxima(object sender, EventArgs e)
        {
            bool acertou = false;
            string resp = "";
            bool valor;

            if (alt0.IsChecked)
            {
                if ((bool)alt0.Value)
                {
                    acertou = true;
                    resp = alt0.Content.ToString();
                }
            }

            if (alt1.IsChecked)
            {
                if ((bool)alt1.Value)
                {
                    acertou = true;
                    resp = alt1.Content.ToString();
                }
            }

            if (alt2.IsChecked)
            {
                if ((bool)alt2.Value)
                {
                    acertou = true;
                    resp = alt2.Content.ToString();
                }
            }

            if (alt3.IsChecked)
            {
                if ((bool)alt3.Value)
                {
                    acertou = true;
                    resp = alt3.Content.ToString();
                }
            }

            if (acertou)
            {
                await DisplayAlert("Acertou!", resp, "OK");
                avanca_Pergunta();

            }
            else
            {
                await DisplayAlert("ERROU!", "Você Perdeu", "OK");
            }
            void avanca_Pergunta()
            {
                if (pergunta_count <= 5)
                {
                    premio = premio + 1000;
                    this.BindingContext = App.getRandomPereguntaFacil();
                }

                if (pergunta_count > 5 && pergunta_count <= 10)
                {
                    premio = premio + 10000;
                    this.BindingContext = App.getRandomPereguntaFacil();
                }

                if (pergunta_count > 10 && pergunta_count < 15)
                {
                    premio = premio + 100000;
                }

            }
        }

        private async Task DisplayAlert(string v1, string resp, string v2)
        {
            throw new NotImplementedException();
        }
    }
}
