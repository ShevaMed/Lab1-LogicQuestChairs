using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    abstract class Room
    {
        public abstract Treasure CreateTreasure();
        public abstract Chair CreateChair();
        public abstract EmptyChair CreateEmptyChair();
    }

    class FirstRoom : Room
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

    class SecondRoom : Room
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

    class ThirdRoom : Room
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
