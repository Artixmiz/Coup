using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoupCardDeck
{

    public enum Action
    {
        Income,
        Foreignaid,
        Coup,
        CollectTaxesd,
        Exchange,
        Assassinate,
        Investigate,
        Steal,
        Extortion,
        TargettedAction
    }
    public class Card
    {

        public string name;
        public Action action;

    }

}





