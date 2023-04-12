using LogicQuestChairsLib.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicQuestChairsLib.Factory
{
    public class ThirdRoom : Room
    {
        public override Treasure CreateTreasure()
        {
            return new Relic();
        }
        public override Chair CreateChair()
        {
            return new BaroqueChair();
        }
        public override EmptyChair CreateEmptyChair()
        {
            return new EmptyBaroqueChair();
        }
    }
}
