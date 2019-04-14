using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form9 : Form
    {
        public static string name1;
        public static string name2;
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name1 = textBox1.Text;
            name2 = textBox2.Text;

            if (name1 == "" || name2 == "")
            {
                MessageBox.Show("You must enter your name !");

            }
            else
            {
                this.Hide();
                Form7 f7 = new Form7();
                f7.Show();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 65 || e.KeyChar > 90)
            {
                if (e.KeyChar > 122 || e.KeyChar < 97)
                    e.Handled = true; 
            }
            if (e.KeyChar == 8)
                e.Handled = false;


        }
    }
}
