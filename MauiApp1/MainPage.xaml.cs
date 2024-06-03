namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void aventura_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.Aventura());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }


        }

        private void comedia_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.comedia());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void drama_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.drama());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void terror_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.terror());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void ficcao_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.ficcao());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void suspense_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.suspense());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void infantil_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.infantil());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void animacao_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.animacao());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void documentario_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.documentario());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void guerra_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.guerra());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void nacional_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.nacionais());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void romance_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.romance());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}
