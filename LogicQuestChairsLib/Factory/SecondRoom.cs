using LogicQuestChairsLib.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicQuestChairsLib.Factory
{
    public class SecondRoom : Room
    {
        public override Treasure CreateTreasure()
        {
            return new Amulet();
        }
        public override Chair CreateChair()
        {
            return new RococoChair();
        }
        public override EmptyChair CreateEmptyChair()
        {
            return new EmptyRococoChair();
        }
    }
}
