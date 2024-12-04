using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autó_átengedő
{
    internal class Vehicle_controller
    {
        int carcount = 0;
        Dictionary<int, PictureBox> autok = new Dictionary<int, PictureBox>();
        PictureBox auto;
        Button vonat;


        public void Carspawner()
        {
            auto = new PictureBox(); //autó
            Point p = new Point(-133, 266);
            autok.Add(carcount, auto);
            auto.Location = p;
            auto.Size = new Size(133,35);
            auto.Image = Image.FromFile("sports_car_drawing_tutorial.png");
            auto.SizeMode = PictureBoxSizeMode.StretchImage;
            auto.Visible = true;
            auto.BackColor = Color.Coral;
            Form1.ActiveForm.Controls.Add(auto);
            carcount++;

        }

        public void TrainSpawner()
        {
            vonat = new Button(); //vonat
            Point p = new Point(Form1.ActiveForm.Width / 2 -100 , 420);
            vonat.Location = p;
            vonat.Size = new Size(60, 200);
            vonat.Text = "";
            vonat.Visible = true;
            vonat.Enabled = false;
            vonat.BackColor = Color.Red;
            Form1.ActiveForm.Controls.Add(vonat);
            

        }

        public void TrainMove()
        {
            vonat.Location = new Point(vonat.Location.X, vonat.Location.Y-4 );
            if (vonat.Top == auto.Bottom)
            {
                vonat.Dispose();
            }
        }

        public void CarMove()
        {

            auto.Location = new Point(auto.Location.X+2, auto.Location.Y);
            if (auto.Left >= Form1.ActiveForm.Width)
            {
                auto.Dispose();

            }
        }
    }
}
