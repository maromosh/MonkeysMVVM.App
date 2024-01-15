using MonkeysMVVM.ViewModels;

namespace MonkeysMVVM.Views;

public partial class ShowMonkeysByLocationView : ContentPage
{
	public ShowMonkeysByLocationView()
	{
		InitializeComponent();
		this.BindingContext = new ShowMonkeysByLocationViewModel();
	}
}