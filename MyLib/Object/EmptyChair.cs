using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    abstract class EmptyChair
    {
        protected Chair template;
        protected Image img;
        protected double weight;
        public abstract void SetTemplateChair(Chair templateChair);
        public abstract Image View();
        public abstract void Put(String path);
    }

    class EmptyModernChair : EmptyChair
    {
        public override void SetTemplateChair(Chair templateChair)
        {
            template = templateChair;
        }
        public override Image View()
        {
            return img;
        }
        public override void Put(String path)
        {
            img = new Bitmap(path);
            weight = img.Height * img.Width;
        }
    }

    class EmptyRococoChair : EmptyChair
    {
        public override void SetTemplateChair(Chair templateChair)
        {
            template = templateChair;
        }
        public override Image View()
        {
            return img;
        }
        public override void Put(String path)
        {
            img = new Bitmap(path);
            weight = img.Height * img.Width;
        }
    }

    class EmptyBaroqueChair : EmptyChair
    {
        public override void SetTemplateChair(Chair templateChair)
        {
            template = templateChair;
        }
        public override Image View()
        {
            return img;
        }
        public override void Put(String path)
        {
            img = new Bitmap(path);
            weight = img.Height * img.Width;
        }
    }
}
