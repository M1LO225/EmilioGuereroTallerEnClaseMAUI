namespace EmilioGuereroTallerEnClaseMAUI;

public partial class Absolute : ContentPage
{
	public Absolute()
	{
		InitializeComponent();
	}

    private void Boton6_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Gridy());
    }
}