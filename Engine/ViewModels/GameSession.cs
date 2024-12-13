using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer {  get; set; }
        public Location CurrentLocation { get; set; }


        // This is the constructor for the GameSession class
        public GameSession()
        {
            CurrentPlayer = new Player();

            CurrentPlayer.Name = "Alihan";
            CurrentPlayer.Gold = 10;
            CurrentPlayer.CharacterClass = "Barbarian";
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;
            CurrentPlayer.HitPoints = 10;

            CurrentLocation = new Location();
            CurrentLocation.Name = "Home";
            CurrentLocation.XCoordiante = 0;
            CurrentLocation.YCoordiante = -1;
            CurrentLocation.ImageName = "C:\\Users\\15417\\source\\repos\\WPFRPG\\Engine\\Images\\Locations\\TownSquare.png";
            CurrentLocation.Description = "This is your home.";
        }
    }
}
