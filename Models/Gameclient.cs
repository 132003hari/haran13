using Gamestore.client.Models;

namespace Gamestore.client;
    public  static class Gameclient
    {
       private static readonly List<Game> games =new()
    {
        new Game()
{Id=1,
Name="street fighting",
Price=19.9M,
ReleaseDate= new DateTime(2003,03,13)


    },
     new Game()
{Id=2,
Name="fighting",
Price=19.9M,
ReleaseDate= new DateTime(2006,03,13)


    },
     new Game()
{Id=3,
Name="street fighting",
Price=19.9M,
ReleaseDate= new DateTime(2007,03,13)
}
    
    
};
 
    public static Game[] GetGames(){
  return games.ToArray();       
    }
    public static void AddGame(Game game) { 
        game.Id=games.Max(game=>game.Id)+1;
        games.Add(game);
    }
public static Game GetGame(int id)
{
    return games.Find(game=> game.Id==id) ?? throw new Exception("Couldnot find game!");
}
public static void UpdateGame( Game updategame)
{
    Game existingGame =GetGame(updategame.Id);
    existingGame.Name=updategame.Name;
    existingGame.Price=updategame.Price;
    existingGame.ReleaseDate=updategame.ReleaseDate;

}
public static void DeleteGame(int id)
{
    Game game=GetGame(id);
    games.Remove(game);
}
    }


