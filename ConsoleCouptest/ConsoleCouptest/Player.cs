using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoupCardDeck;

namespace ConsoleCouptest
{
    public class Player

    {
        public readonly List<Card> card1;
        public readonly List<Card> card2;
        public void player()
        {
            foreach (var value in Enum.GetValues(typeof(CoupCardDeck.Action)))
            {
                Console.WriteLine((CoupCardDeck.Action)value);
            }
        }


    }
        
}
