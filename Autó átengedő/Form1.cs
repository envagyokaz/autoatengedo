using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autó_átengedő
{
    public partial class Form1 : Form
    {
        private static Random rnd = new Random();

        private Vehicle_controller vc;
        public Form1()
        {
            InitializeComponent();
            vc = new Vehicle_controller();
        }

        private void sorompo_Click(object sender, EventArgs e)
        {
            vc.Carspawner();
            vc.TrainSpawner();
        }

        private void Train_Tick(object sender, EventArgs e)
        {
            int random = rnd.Next(10, 30);
            
            
        }

        private void Car_Tick(object sender, EventArgs e)
        {
            vc.CarMove();
        }
    }
}
