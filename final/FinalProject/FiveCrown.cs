public class FiveCrown : Game
{
    int _round;
    public FiveCrown(string name) : base(name)
    {
        _round = 1;
    }
    public override void End()
    {
        throw new NotImplementedException();
    }
    public override void Score()
    {
        foreach(User player in base.getPlayers())
        {
            Console.WriteLine($"How many points did {player.GetName()} earn?");
            player.AddPoints(int.Parse(Console.ReadLine()));
            Console.Clear();
        }
    }
    public override void Start()
    {
        base.Start();
        while(true)
        {
            if(_round <= 11)
            {
                Score();
                Console.WriteLine($"Current totals:");
                int n = 1;
                foreach(User player in base.getPlayers())
                {
                    Console.WriteLine($"{n}. {player.GetName()} {player.GetPoints()}");
                }
                Console.WriteLine("\nPress Enter to continue");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                End();
            }
        }
    }
}