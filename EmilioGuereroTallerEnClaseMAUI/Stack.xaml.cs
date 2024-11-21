namespace EmilioGuereroTallerEnClaseMAUI;

public partial class Stack : ContentPage
{
	public Stack()
	{
		InitializeComponent();
	}

    private void Boton3_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Flex());
    }
}