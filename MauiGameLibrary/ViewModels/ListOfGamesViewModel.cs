
using MauiGameLibrary.Models;
using MauiGameLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace MauiGameLibrary.ViewModels
{
    
    public class ListOfGamesViewModel : BaseViewModel
    {
       private GameDataService _gameDataService;

        private List<GameInformation> _games;

        private GameInformation _selectedGame;

        public GameInformation SelectedGame
        {
            get { return _selectedGame; }
            set
            {
                _selectedGame = value;
                OnPropertyChanged();
            }
        }

        public ICommand GameSelectedCommand { get; set; }

        public List<GameInformation> Games
        {
            get { return _games; }
            set { 
                _games = value;
                OnPropertyChanged();
            }
        }


        public ListOfGamesViewModel(GameDataService service)
        {
            _gameDataService = service;

            GameSelectedCommand = new Command(GameSelected);
        }

        private async void GameSelected(object obj)
        {
            var param = new ShellNavigationQueryParameters()
            {
                {"SelectedGame", SelectedGame }
            };
            await AppShell.Current.GoToAsync("updategameroute", param);
        }

        public void RefreshGames()
        {
            Games = _gameDataService.GetAllGameInformation();
        }
    }
}
