using MauiAppShowDoMilhao;
using Plugin.Maui.Audio;

namespace MauiAppShowDoMilhao
{
    public partial class MainPage : ContentPage
    {
        double premio = 1000;
        int pergunta_count = 1;

        public MainPage()
        {
            InitializeComponent();
            this.BindingContent = App.getRandomPerguntaFacil();

            lbl_nivel.Text = "Fácil";
            lbl_premio.Text = premio.ToString("C");
            lbl_pergunta_numero.Text = pergunta_count.ToString();

            //Adiciona som
            Stream track = FileSystem.OpenAppPackageFileAsync("0.mp3").Result;
            AudioManager.Current.CreatePlayer(track).Play();
        }

        private void toca_som()
        {
            string track = "";
            switch (pergunta_count) 
            {
                case 1:
                    track = "1000.wav";
                    break;
                case 2:
                    track = "2000.wav";
                    break;
                case 3:
                    track = "3000.wav";
                    break;
                case 4:
                    track = "4000.wav";
                    break;
                case 5:
                    track = "5000.wav";
                    break;
                case 6:
                    track = "10000.wav";
                    break;
                case 7:
                    track = "20000.wav";
                    break;
                case 8:
                    track = "30000.wav";
                    break;
                case 9:
                    track = "40000.wav";
                    break;
                case 10:
                    track = "50000.wav";
                    break;
                case 11:
                    track = "100000.wav";
                    break;
                case 12:
                    track = "200000.wav";
                    break;
                case 13:
                    track = "300000.wav";
                    break;
                case 14:
                    track = "400000.wav";
                    break;
                case 15:
                    track = "500000.wav";
                    break;

            }

            AudioManager.Current.CreatePlayer(FileSystem.OpenAppPackageFileAsync(track).Result).Play();


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
                if (pergunta_count <= 4)
                {
                    premio = premio + 1000;
                    this.BindingContext = App.getRandomPereguntaFacil();            
                }

                if (pergunta_count > 5 && pergunta_count <= 10)
                {
                    premio = premio + 10000;
                    this.BindingContext = App.getRandomPereguntaMedia();
                }

                if (pergunta_count > 10 && pergunta_count < 15)
                {
                    premio = premio + 100000;
                    this.BindingContext = App.getRandomPereguntaDificil();
                }

            }
        }

        private async Task DisplayAlert(string v1, string resp, string v2)
        {
            throw new NotImplementedException();
        }
    }
}
