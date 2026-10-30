using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.FolderforModel;

namespace WindowsFormsApp6
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public void Fill (Table_1 Motorbike)
        {
            label8.Text = Motorbike.ID.ToString();
            label10.Text = Motorbike.Model;
            label15.Text = Motorbike.Brand;
            label16.Text = Motorbike.Price.ToString();
            label17.Text = Motorbike.Horsepower.ToString();
            label18.Text = Motorbike.Milearge.ToString();
            pictureBox2.Image = Image.FromFile($@"Pictures\{Motorbike.Picture}");

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
