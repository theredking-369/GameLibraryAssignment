namespace MauiGameLibrary.Views;
using ViewModels;

public partial class ListOfGamesView : ContentPage
{
	public ListOfGamesView(ListOfGamesViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;	
	}

}