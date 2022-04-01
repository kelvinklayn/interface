namespace Interface
{
    internal static class Program
    {
         static void Main(string[] arg)
         {
             var gameMoba = new LoL();
             var gameFps = new CounterStrike();
             var gameMmo = new WorldOfWarcraft();
             var gameDmc = new DevilMayCry();


             Console.WriteLine("\n\n"+"Game Name: "+gameMoba.GameName+"\n"+"Game Category: "+gameMoba.Category+"\n"+"Game Price: "+gameMoba.Price);
             gameMoba.Multiplayer("y");
             Console.WriteLine("\n\n"+"Game Name: "+gameDmc.GameName+"\n"+"Game Category: "+gameDmc.Category+"\n"+"Game Price: "+gameDmc.Price);
             gameDmc.Multiplayer("n");
             Console.WriteLine("\n\n"+"Game Name: "+gameMmo.GameName+"\n"+"Game Category: "+gameMmo.Category+"\n"+"Game Price: "+gameMmo.Price);
             gameMmo.Multiplayer("y");
             Console.WriteLine("\n\n"+"Game Name: "+gameFps.GameName+"\n"+"Game Category: "+gameFps.Category+"\n"+"Game Price: "+gameFps.Price);
             gameMoba.Multiplayer("y");
         }
    }
}
