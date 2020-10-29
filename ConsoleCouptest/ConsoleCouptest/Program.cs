using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ConsoleCouptest;
using CoupCardDeck;

namespace ConsoleCoup
{
    class Program
    {
        

        static void Main()
        {
            Player p = new Player();
            Deck deck = new Deck();
            deck.Shuffle();
            p.player();

        }
    }
}
