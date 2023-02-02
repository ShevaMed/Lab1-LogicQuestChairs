using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    abstract class Chair
    {
        protected Treasure treasure;
        protected Image img;
        protected double weight;
        public abstract Image View();
        public abstract void SetTreasure(Treasure inTreasure);
        public abstract void Put(String path);
    }

    class ModernChair : Chair
    {
        public override Image View()
        {
            return img;
        }
        public override void SetTreasure(Treasure inTreasure)
        {
            treasure = inTreasure;
        }
        public override void Put(String path)
        {
            img = new Bitmap(path);
            weight = img.Height * img.Width;
        }
    }

    class RococoChair : Chair
    {
        public override Image View()
        {
            return img;
        }
        public override void SetTreasure(Treasure inTreasure)
        {
            treasure = inTreasure;
        }
        public override void Put(String path)
        {
            img = new Bitmap(path);
            weight = img.Height * img.Width;
        }
    }

    class BaroqueChair : Chair
    {
        public override Image View()
        {
            return img;
        }
        public override void SetTreasure(Treasure inTreasure)
        {
            treasure = inTreasure;
        }
        public override void Put(String path)
        {
            img = new Bitmap(path);
            weight = img.Height * img.Width;
        }
    }
}
