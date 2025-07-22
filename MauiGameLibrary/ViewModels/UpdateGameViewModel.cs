using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiGameLibrary.Models;
using MauiGameLibrary.Services;

namespace MauiGameLibrary.ViewModels
{
    [QueryProperty(nameof(SelectedGame), nameof(SelectedGame))]
    public class UpdateGameViewModel : BaseViewModel
    {
        private GameDataService _gameDataService;

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
        
        public UpdateGameViewModel(GameDataService gameDataservice)
        {
            _gameDataService = gameDataservice;

            
        }
    }
}
