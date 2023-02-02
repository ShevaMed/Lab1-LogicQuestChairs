using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicQuestChairsLib.Object;
using LogicQuestChairsLib.Factory;


namespace Lab1___LogicQuestChairs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
        private void CreateFactory(Room room, int cost, String fileTreasure, String fileChair, String fileEmptyChair)
        {
            Treasure treasure = room.CreateTreasure();
            Chair chair = room.CreateChair();
            EmptyChair emptyChair = room.CreateEmptyChair();

            treasure.SetCost(cost);
            treasure.Put(@"..\..\images\" + fileTreasure);
            pictureBox1.Image = treasure.View();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            chair.SetTreasure(treasure);
            chair.Put(@"..\..\images\" + fileChair);
            pictureBox2.Image = chair.View();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            emptyChair.SetTemplateChair(chair);
            emptyChair.Put(@"..\..\images\" + fileEmptyChair);
            pictureBox3.Image = emptyChair.View();
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateFactory(new FirstRoom(), 1000000, "Diamond.jpg", "ModernChair.jpg", "EmptyModernChairs.jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateFactory(new SecondRoom(), 500000, "Amulet.jpg", "RococoChair.jpg", "EmptyRococoChairs.jpg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateFactory(new ThirdRoom(), 3000000, "Relic.jpg", "BaroqueChair.jpeg", "EmptyBaroqueChairs.jpg");           
        }
    }
}
