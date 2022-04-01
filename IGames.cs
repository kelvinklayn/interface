namespace Interface
{
    public interface IGames
    {
        string GameName { get; }
        string Category { get; }
        string Price { get; }

        public void Multiplayer(string option)
        {
            if (option == "s")
            {
                Console.WriteLine("Playable with Friend");
            }
            else
            {
                Console.WriteLine("Not Playable with Friend");
            }
        }
    }
}

