namespace Robbie;

public partial class MainPage : ContentPage
{
	//int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	//private void OnCounterClicked(object sender, EventArgs e)
	//{
	//	count++;

	//	if (count == 1)
	//		CounterBtn.Text = $"Clicked {count} time";
	//	else
	//		CounterBtn.Text = $"Clicked {count} times";

	//	SemanticScreenReader.Announce(CounterBtn.Text);
	//}

	private void OnMessageClicked(object sender, EventArgs e)
	{
		String msg = "Ooh that feels good, thank you for clicking";
		MessageBtn.Text = msg;

		SemanticScreenReader.Announce(MessageBtn.Text);

		//Label label = new Label();
		//label.Text=msg;

	}
}

