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
    public partial class Form1 : Form
    { 
        
        System.Media.SoundPlayer what_a_wonderful = new System.Media.SoundPlayer();
        public Form1()
        {
            InitializeComponent();
            what_a_wonderful.SoundLocation = "LouisArmstrong-WhatAWonderfulWorldLyrics.wav";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form8.txt.WriteLine(Form9.name1);
            Form8.txt.WriteLine(Form8.player1Score);
            Form8.txt.WriteLine(Form9.name2);
           Form8. txt.WriteLine(Form8.player2Score);

            Form8.txt.Close();

            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            levels f2 = new levels();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
              //  what_a_wonderful.Play();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
