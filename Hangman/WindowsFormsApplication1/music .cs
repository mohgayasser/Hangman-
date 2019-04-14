using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{ 
   
    public partial class Form5 : Form
    {
       System.Media.SoundPlayer player = new System.Media.SoundPlayer();
       System.Media.SoundPlayer player2 = new System.Media.SoundPlayer();
       System.Media.SoundPlayer player3 = new System.Media.SoundPlayer();
      
        public Form5()
        {
            InitializeComponent();
            player.SoundLocation = "track1.wav";
            player2.SoundLocation = "track2.wav";
            player3.SoundLocation = "track3.wav";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player2.Play();   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            player.Stop();
            player2.Stop();
            player3.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player3.Play();
        }
    }
}
