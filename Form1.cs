using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.FolderforModel;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Model1 DB = new Model1();

        List<Table_1> Motorbikes = DB.Table_1.ToList();
        int AccNumber = 0;

        private void Loading()
        {
            userControl11.Fill(Motorbikes[AccNumber]);
            userControl12.Fill(Motorbikes[AccNumber + 1]);
        }
        private void Loading(bool Incr)
        {
            if (Incr == true && Motorbikes.Count > AccNumber + 2)
                AccNumber++;
            else if (Incr == false && 0 <= AccNumber - 1)
                AccNumber--;
            else
                return;

            Loading();
        }


        private void Form1_load(object sender, EventArgs e)
        {
            Loading();
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            Loading(true);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            Loading(false);
        }
    }
}
