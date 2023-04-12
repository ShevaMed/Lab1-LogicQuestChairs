using LogicQuestChairsLib.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicQuestChairsLib.Factory
{
    public class FirstRoom : Room
    {
        public override Treasure CreateTreasure()
        {
            return new Diamond();
        }
        public override Chair CreateChair()
        {
            return new ModernChair();
        }
        public override EmptyChair CreateEmptyChair()
        {
            return new EmptyModernChair();
        }
    }
}
