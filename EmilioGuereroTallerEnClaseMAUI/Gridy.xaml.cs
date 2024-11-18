namespace EmilioGuereroTallerEnClaseMAUI;

public partial class Gridy : ContentPage
{
	public Gridy()
	{
		InitializeComponent();
	}

    private void Boton2_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Stack());
    }
}