using System;
using System.Collections.Generic;
using System.Text;

namespace Casino
{
    public abstract class Game
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        public List<Player> Players { get { return _players; } set { _players = value; } }
        
        public int MyProperty { get; set; }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

        //abstract methods state that any class inheriting this one
        //must implement this method
        public abstract void Play(); 

        //virtual methods within abstract class means that
        //this method gets inherited but can be overridden
        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
