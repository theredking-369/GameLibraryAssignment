
using MauiGameLibrary.Models;
using MauiGameLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MauiGameLibrary.ViewModels
{
    
    public class ListOfGamesViewModel : BaseViewModel
    {
       private GameDataService _gameDataService;

        private List<GameInformation> _games;

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
        }


        public void RefreshGames()
        {
            Games = _gameDataService.GetAllGameInformation();
        }
    }
}
