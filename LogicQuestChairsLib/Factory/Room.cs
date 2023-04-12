using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicQuestChairsLib.Object;

namespace LogicQuestChairsLib.Factory
{
    public abstract class Room
    {
        public abstract Treasure CreateTreasure();
        public abstract Chair CreateChair();
        public abstract EmptyChair CreateEmptyChair();
    }
}
