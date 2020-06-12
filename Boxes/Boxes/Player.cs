using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    class Player: IComparable<Player>
    {
        public string Name { get; set; }
        public CardSet PlayerCards { get; set; }
        public virtual int Point { get; set; }
        public Player(string name)
        {
            Name = name;
        }

        public Player(string name, CardSet cardSet) : this(name)
        {
            PlayerCards = cardSet;
        }

        public int CompareTo(Player other)
        {
            return Point.CompareTo(other.Point);
        }
    }
}
