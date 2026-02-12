// See https://aka.ms/new-console-template for more information

// Create a list of objects from a custom class of ours


List<Player> players = new List<Player>();

// Creating the objects
Player player1 = new Player("Chad");
Player player2 = new Player("Steve");
Player player3 = new Player("Karen");

// Adding the objects to the list 
players.Add(player1);
players.Add(player2);
players.Add(player3);

// Let's display the list

foreach (Player player in players)
// If you don't want to use "player.username" then ToString() it(Line :- 37)
{
    Console.WriteLine(player.username);
}

class Player
{
    public string username;

    public Player(string username)
    {
        this.username = username;
    }

    public override string ToString()
    {
        return username;
    }
}