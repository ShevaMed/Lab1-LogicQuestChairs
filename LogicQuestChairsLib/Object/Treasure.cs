using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicQuestChairsLib.Object
{
    public abstract class Treasure
    {
        protected Image img;
        protected int cost;
        public abstract Image View();
        public abstract void Put(String path);
        public abstract void SetCost(int inCost);
    }

    public class Diamond : Treasure
    {
        public override Image View()
        {
            return img;
        }
        public override void Put(String path)
        {
            img = new Bitmap(path);
        }
        public override void SetCost(int inCost)
        {
            cost = inCost;
        }
    }

    public class Amulet : Treasure
    {
        public override Image View()
        {
            return img;
        }
        public override void Put(String path)
        {
            img = new Bitmap(path);
        }
        public override void SetCost(int inCost)
        {
            cost = inCost;
        }
    }

    public class Relic : Treasure
    {
        public override Image View()
        {
            return img;
        }
        public override void Put(String path)
        {
            img = new Bitmap(path);
        }
        public override void SetCost(int inCost)
        {
            cost = inCost;
        }
    }
}
