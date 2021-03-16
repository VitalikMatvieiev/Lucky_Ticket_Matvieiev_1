using System;

namespace LuckyTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket t1 = new Ticket();
            Game game = new Game();
            game.Start(t1);
        }
    }
}
