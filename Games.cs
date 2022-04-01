namespace Interface
{
    public class LoL : IGames
        {
            public string GameName => "League Of Legends";
            public string Category => "Moba";
            public string Price => "FreeToPlay";
            public void Multiplayer(string option)
            {
                if (option == "y")
                {
                    Console.WriteLine("This game can be played with friends");
                }
                else
                {
                    Console.WriteLine("This game cannot be played with friends");
                }
            }
        }

        public class DevilMayCry : IGames
        {
            public string GameName => "Devil May Cry";
            public string Category => "HackNSlash";
            public string Price => "BuyToPlay";
            public void Multiplayer(string option)
            {
                if (option == "y")
                {
                    Console.WriteLine("This game can be played with friends");
                }
                else
                {
                    Console.WriteLine("This game cannot be played with friends");
                }
            }
        }

        public class CounterStrike : IGames
        {
            public string GameName => "Counter-Strike";
            public string Category => "FPS";
            public string Price => "Free2Play";
            public void Multiplayer(string option)
            {
                if (option == "y")
                {
                    Console.WriteLine("This game can be played with friends");
                }
                else
                {
                    Console.WriteLine("This game cannot be played with friends");
                }
            }
        }

        public class WorldOfWarcraft : IGames
        {
            public string GameName => "World Of Warcraft";
            public string Category => "MMORPG";
            public string Price => "PayToPlay";
            public void Multiplayer(string option)
            {
                if (option == "y")
                {
                    Console.WriteLine("This game can be played with friends");
                }
                else
                {
                    Console.WriteLine("This game cannot be played with friends");
                }
            }
        }
}
