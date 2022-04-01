namespace Interface
{
    public interface IGames
    {
        string GameName { get; }
        string Category { get; }
        string Price { get; }
        void Multiplayer(string option);
    }
}

