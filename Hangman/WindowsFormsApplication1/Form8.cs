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
    public partial class Form8 : Form
    {
        private Bitmap[] images = {WindowsFormsApplication1.Properties.Resources.hang, WindowsFormsApplication1.Properties.Resources.hang1, WindowsFormsApplication1.Properties.Resources.hang2, WindowsFormsApplication1.Properties.Resources.hang3, WindowsFormsApplication1.Properties.Resources.hang4,
               WindowsFormsApplication1.Properties.Resources.hang5, WindowsFormsApplication1.Properties.Resources.hang6, WindowsFormsApplication1.Properties.Resources.hang7 };
        public static StreamWriter txt = new StreamWriter("multiplayerscore.txt");
        private int wordguess = 0;
        private string cpysecword;
        int length = Form7.secword.Length;
        private int hint = 3;
        public static int player1Score = 0, player2Score = 0;
        private int score = 1;
        private bool found = false;
        public Form8()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void Form8_Load_1(object sender, EventArgs e)
        {
            setup();
            label4.Text += "   " + Form7.secword.Length;




        }

        // 7arf l c fyy moshkelaa 
        private void setup()
        {
            wordguess = 0;
            pictureBox2.Image = images[wordguess];

            cpysecword = "";
            for (int i = 0; i < length; i++)
            {
                cpysecword += "_";
            }
            displaycpy();

            button28.Text = "HINT  ( " + hint + " ) ";


            label1.Text = Form9.name2.ToUpper();
            label3.Text = Form9.name1.ToUpper();
            label7.Text = Convert.ToString(player1Score);
            label6.Text = Convert.ToString(player2Score);
            if (Form7.name == Form9.name1)
                label8.Text = Form9.name2 + "  -> Guss";
            else
                label8.Text = Form9.name1 + "  -> Guss";

        }
        private void displaycpy()
        {
            label5.Text = "";
            for (int i = 0; i < length; i++)
            {
                label5.Text += cpysecword.Substring(i, 1);
                label5.Text += " ";

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {


                Button choice = sender as Button;
                char guess = choice.Text.ElementAt(0);
                char[] temp = cpysecword.ToCharArray();
                char[] chick = cpysecword.ToCharArray();
                char[] find = Form7.secword.ToCharArray();
                Random rand1 = new Random();

                int lenth = Form7.secword.Length;
                int computer = rand1.Next(0, lenth);
                if (guess == 'H')
                {
                    hint--;
                    button28.Text = "HINT (" + hint + ")";
                    if (hint == 0)
                    {
                        Button close = sender as Button; //tafal al button b3d 3dad mo3ian
                        close.Enabled = false;
                    }
                    found = false;
                    do
                    {


                        for (int i = 0; i < lenth; i++)
                        {
                            if (computer == i)
                            {
                                temp[i] = find[i];


                                for (int j = 0; j < lenth; j++)
                                {
                                    if (find[j] == temp[i])
                                    {
                                        temp[j] = find[i];
                                    }

                                }
                                if (chick[i] != temp[i])
                                {
                                    cpysecword = new string(temp);
                                    displaycpy();
                                    found = true;
                                }
                                Button[] button = { a, b, C, d, this.e, f, g, h, I, J, kk, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z };
                                string clikbutton = temp[i].ToString();
                                if (clikbutton == "c")
                                {
                                    C.Enabled = false;
                                }
                                else if (clikbutton == "w")
                                {
                                    w.Enabled = false;
                                }
                                else
                                {
                                    for (int k = 0; k >= 0; k++)
                                    {

                                        if (button[k].Text != clikbutton)
                                        {
                                            button[k].Enabled = false;
                                            break;
                                        }
                                    }
                                }
                                if (cpysecword.Equals(Form7.secword))
                                {
                                    if (Form7.counter % 2 == 0)
                                        score = player2Score++;

                                    else
                                        score = player1Score++;

                                    if (Form7.name == Form9.name1)
                                        MessageBox.Show(Form9.name2 + "   WIN <3 ");

                                    else
                                        MessageBox.Show(Form9.name1 + "   WIN <3 ");
                                }
                            }
                        }
                            rand1 = new Random();
                            computer = rand1.Next(0, lenth);
                        
                    } while (found == false);
                }
                else
                {

                    {
                        choice.Enabled = false;

                        if (Form7.secword.Contains(choice.Text))
                        {
                            for (int i = 0; i < find.Length; i++)
                            {
                                if (find[i] == guess)
                                {
                                    temp[i] = guess;
                                }

                            }
                            cpysecword = new string(temp);
                            displaycpy();
                            if (cpysecword.Equals(Form7.secword))
                            {

                                if (Form7.counter % 2 == 0)
                                {
                                    score = player2Score++;

                                }
                                else
                                {

                                    score = player1Score++;

                                }
                                if (Form7.name == Form9.name1)
                                {
                                    MessageBox.Show(Form9.name2 + "   WIN <3 ");

                                }

                                else
                                    MessageBox.Show(Form9.name1 + "   WIN <3 ");
                            }
                        }


                        else
                        {
                            wordguess++;

                        }
                        if (wordguess < 7)
                        {
                            pictureBox2.Image = images[wordguess];
                        }

                        else if (wordguess == 7)
                        {
                            pictureBox2.Image = images[wordguess];
                            if (Form7.name == Form9.name1)
                                MessageBox.Show(Form9.name2 + "  the word is   " + Form7.secword.ToUpper());

                            else
                                MessageBox.Show(Form9.name1 + "  the word is   " + Form7.secword.ToUpper());


                        }


                    }
                }
            }

        }

       
        private void button2_Click(object sender, EventArgs e)
        {

         txt.WriteLine(Form9.name1);
           txt.WriteLine(player1Score);
           txt.WriteLine(Form9.name2);
          txt.WriteLine(player2Score);

            txt.Close();



            Application.Exit();
             }

             private void label1_Click(object sender, EventArgs e)
             {

             }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 F7 = new Form7();
            F7.Show();


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            score sc =new score();
            sc.Show();

        }
    }
      
}