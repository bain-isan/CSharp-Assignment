using System.Collections;
using System.Collections.Generic;


namespace Assignment5_6
{
    internal class Team : IEnumerable
    {
        List<Player> players = new List<Player>();

        public List<Player> Players { get { return players; } set { players = value; } }

        public void Add(Player player)
        {
            players.Add(player);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return players.GetEnumerator();
        }
    }
}
