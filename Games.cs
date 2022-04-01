namespace Interface
{
    public class LoL : IGames
        {
            public string GameName => "League Of Legends";
            public string Category => "Moba";
            public string Price => "FreeToPlay";
        }

        public class DevilMayCry : IGames
        {
            public string GameName => "Devil May Cry";
            public string Category => "HackNSlash";
            public string Price => "BuyToPlay";
        }

        public class CounterStrike : IGames
        {
            public string GameName => "Counter-Strike";
            public string Category => "FPS";
            public string Price => "Free2Play";
        }

        public class WorldOfWarcraft : IGames
        {
            public string GameName => "World Of Warcraft";
            public string Category => "MMORPG";
            public string Price => "PayToPlay";
        }
}

