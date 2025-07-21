using MauiGameLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiGameLibrary.Services
{
    public class GameDataService
    {
        public void CreateFakeGameInformation()
        {
            _gameInformation.Add(new GameInformation
            {
                Id = Guid.NewGuid().ToString(),
                Title = "The Legend of Zelda: Breath of the Wild",
                GameType = "Action-Adventure",
                CompanyName = "Nintendo",
                Genre = "Adventure",
                AgeRestriction = "E10+",
                Multiplayer = false,
                Description = "An open-world action-adventure game set in the kingdom of Hyrule.",
                Image = "zelda.jpg",
                YearPublished = new DateTime(2017, 3, 3)
            });
            _gameInformation.Add(new GameInformation
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Super Mario Odyssey",
                GameType = "Platformer",
                CompanyName = "Nintendo",
                Genre = "Platformer",
                AgeRestriction = "E",
                Multiplayer = false,
                Description = "A 3D platformer where Mario travels across various kingdoms to rescue Princess Peach.",
                Image = "mario.jpg",
                YearPublished = new DateTime(2017, 10, 27)
            });
        }

        private List<GameInformation> _gameInformation = new List<GameInformation>();

        public List<GameInformation> GetAllGameInformation()
        {
            return _gameInformation;
        }

        public void UpdateGameInformation(GameInformation gameInformation)
        {
            if (!string.IsNullOrEmpty(gameInformation.Id))
            {
                var uniquGame = GetGameInformationById(gameInformation.Id);
                int position = _gameInformation.IndexOf(uniquGame);
                _gameInformation[position] = gameInformation;
            }
            else
            {
                string id = Guid.NewGuid().ToString();
                gameInformation.Id = id;
                _gameInformation.Add(gameInformation);
            }

        }
        public GameInformation GetGameInformationById(string id)
        {
           var uniqueGame = _gameInformation.Where(gameInfo => gameInfo.Id == id).FirstOrDefault();

            return uniqueGame;
        }
        public List<GameInformation>GetGameInformationByTitle(string title)
        {
            return _gameInformation.Where(gameInfo => gameInfo.Title == title).ToList();
        }
    }
}
