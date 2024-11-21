namespace EmilioGuereroTallerEnClaseMAUI;

public partial class Flex : ContentPage
{
	public Flex()
	{
		InitializeComponent();
	}

    private void Boton4_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Absolute());
    }
}