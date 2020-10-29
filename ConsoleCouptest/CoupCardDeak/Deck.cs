using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoupCardDeck
{
    public class Deck
    {
        int TopCard = 0;
        Card[] cards;
        static readonly Random R = new Random();
        List<Card> Cards { get; set; }
        public Deck()
        {
            cards = new Card[15];
            for (int i = 0; i < cards.Length; i++)
            {
                cards[i] = new Card();
            }
            cards[0].name = "duke";
            cards[0].action = Action.CollectTaxesd;
            cards[1].name = "duke";
            cards[1].action = Action.CollectTaxesd;
            cards[2].name = "duke";
            cards[2].action = Action.CollectTaxesd;
            cards[3].name = "Ambassador";
            cards[3].action = Action.Exchange;
            cards[4].name = "Ambassador";
            cards[4].action = Action.Exchange;
            cards[5].name = "Ambassador";
            cards[5].action = Action.Exchange;
            cards[6].name = "Assassin";
            cards[6].action = Action.Assassinate;
            cards[7].name = "Assassin";
            cards[7].action = Action.Assassinate;
            cards[8].name = "Assassin";
            cards[8].action = Action.Assassinate;
            cards[9].name = "Contessa";
            cards[9].action = Action.Investigate;
            cards[10].name = "Contessa";
            cards[10].action = Action.Investigate;
            cards[11].name = "Contessa";
            cards[11].action = Action.Investigate;
            cards[12].name = "Captain";
            cards[12].action = Action.Steal;
            cards[13].name = "Captain";
            cards[13].action = Action.Steal;
            cards[14].name = "Captain";
            cards[14].action = Action.Steal;
            Shuffle();
            TopCard = cards.Length;


        }

        public Card Draw()
        {
            TopCard--;
            return cards[TopCard];

        }

        public void Shuffle()
        {
            for (var i = 0; i < 100; i++)
            {
                Swap(R.Next(cards.Length), R.Next(cards.Length));
            }
        }
        private void Swap(int i, int j)
        {
            var c = cards[i];
            cards[i] = cards[j];
            cards[j] = c;
        }
    }
}
