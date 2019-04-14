using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class score : Form
    {
 StreamReader txt=new StreamReader("multiplayerscore.txt");
        List<string> list = new List<string>();
        private string line;
        private string[] wordarray;
        public score()
        {
            InitializeComponent();
        }
        private void Score()
        {
      
            while ((line=txt.ReadLine()) != null)
            {
                list.Add(line);
            }
            //copy the list to array
            wordarray= list.ToArray();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void score_Load(object sender, EventArgs e)
        {
            label1.Text = Form9.name1;
            label3.Text = Form9.name2;
            label2.Text = wordarray[0];
            label4.Text = wordarray[1];


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this. Hide();
        }
    }
}
