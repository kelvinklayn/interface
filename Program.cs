using System;
using Interface;

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


             Console.WriteLine("Game Name: "+gameMoba.GameName+"\n"+"Game Category: "+gameMoba.Category+"\n"+"Game Price: "+gameMoba.Price+"\n\n");
             Console.WriteLine("Game Name: "+gameDmc.GameName+"\n"+"Game Category: "+gameDmc.Category+"\n"+"Game Price: "+gameDmc.Price+"\n\n");
             Console.WriteLine("Game Name: "+gameMmo.GameName+"\n"+"Game Category: "+gameMmo.Category+"\n"+"Game Price: "+gameMmo.Price+"\n\n");
             Console.WriteLine("Game Name: "+gameFps.GameName+"\n"+"Game Category: "+gameFps.Category+"\n"+"Game Price: "+gameFps.Price+"\n\n");
         }
    }
}

