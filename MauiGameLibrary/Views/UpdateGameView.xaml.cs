using MauiGameLibrary.ViewModels;

namespace MauiGameLibrary.Views;

public partial class UpdateGameView : ContentPage
{
	
	public UpdateGameView(UpdateGameViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        UpdateGameViewModel vm = BindingContext as UpdateGameViewModel;

    }
}