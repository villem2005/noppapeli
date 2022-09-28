using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Dice Luku1 = new Dice();
           
            Luku1.Roll();
            int i = Luku1.Luku1;
            label1.Text = i.ToString();
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dice Luku2 = new Dice();
            Luku2.Roll();
            int i = Luku2.Luku1;
            int a = Luku2.Luku2;
            label2.Text = a.ToString();
            button2.Visible = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
