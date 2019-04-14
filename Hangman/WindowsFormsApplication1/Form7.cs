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
    public partial class Form7 : Form
    {
        
        public Form7()
        {
            InitializeComponent();
        }

        public static string secword;
        public static string secret;
        public static string name;
    public   static int counter = 1;
        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text.Length >= 15)
            {
                MessageBox.Show("So long word !!");
            }
            
            else
            { secret = textBox1.Text;
                secword = secret.ToLower();
                this.Hide();
                Form8 f8 = new Form8();
                f8.Show();
            }
         
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
            textBox1.PasswordChar = '*';
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            counter++;
            if (counter % 2 != 0)
            {
                label2.Text = Form9.name1.ToUpper();
                name = Form9.name1;
            }
            else
            {
                label2.Text = Form9.name2.ToUpper();
                name = Form9.name2;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
          

        }

        private void textbox1(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 65 || e.KeyChar > 90)
                e.Handled = true;

          else  if (e.KeyChar < 96 || e.KeyChar > 122)
                e.Handled = true;



        }
    }
    }
    
