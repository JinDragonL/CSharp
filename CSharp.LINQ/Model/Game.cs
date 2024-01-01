namespace CSharp.LINQ.Model
{
    public class Game
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Platforms { get; set; }
        public bool Singleplayer { get; set; }
        public string Rating { get; set; }
        public int Mark { get; set; }

        public static List<Game> GetAllGames()
        {
            return new List<Game>
            {
                new Game { Title = "Naruto", Genre = "Action-Adventure", Platforms = "PC", Singleplayer = true,
                           Rating = "E10+ (Everyone 10 and older)", Mark = 90 },
                new Game { Title = "Devil May Cry", Genre = "RPG", Platforms = "Nintendo", Singleplayer = true,
                           Rating = "T (Teen)", Mark = 85 },
                new Game { Title = "Starcraft", Genre = "Strategy", Platforms = "PC", Singleplayer = true,
                           Rating = "E (Everyone)", Mark = 92 },
                new Game { Title = "Assassin's Creed: Valhalla", Genre = "Action-Adventure", Platforms = "PlayStation", Singleplayer = true,
                           Rating = "M (Mature)", Mark = 50 },
                new Game { Title = "Animal Crossing: New Horizons", Genre = "Life Simulation", Platforms = "Nintendo Switch", Singleplayer = true,
                           Rating = "E (Everyone)", Mark = 95 },
                new Game { Title = "Call of Duty: Warzone", Genre = "Battle Royale", Platforms = "PlayStation", Singleplayer = false,
                           Rating = "M (Mature)", Mark = 87 },
                new Game { Title = "Among Us", Genre = "Party Game, Social Deduction", Platforms = "Nintendo", Singleplayer = false,
                           Rating = "T (Teen)", Mark = 65 },
                new Game { Title = "The Legend of Zelda: Breath of the Wild", Genre = "Action-Adventure", Platforms = "Nintendo", Singleplayer = true,
                           Rating = "E10+ (Everyone 10 and older)", Mark = 93 },
                new Game { Title = "Fortnite", Genre = "Battle Royale", Platforms = "PC", Singleplayer = false,
                           Rating = "T (Teen)", Mark = 32 },
                new Game { Title = "Minecraft", Genre = "Sandbox, Survival", Platforms = "PlayStation", Singleplayer = true,
                           Rating = "E10+ (Everyone 10 and older)", Mark = 94 }
            };
        }
    }
}
