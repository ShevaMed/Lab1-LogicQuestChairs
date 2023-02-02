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
