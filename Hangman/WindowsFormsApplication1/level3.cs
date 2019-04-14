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
    public partial class level3 : Form
    {


        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        //to change the images
        private Bitmap[] images = { WindowsFormsApplication1.Properties.Resources.hang,WindowsFormsApplication1.Properties.Resources.hang1, WindowsFormsApplication1.Properties.Resources.hang2, WindowsFormsApplication1.Properties.Resources.hang3, WindowsFormsApplication1.Properties.Resources.hang4,
               WindowsFormsApplication1.Properties.Resources.hang5, WindowsFormsApplication1.Properties.Resources.hang6, WindowsFormsApplication1.Properties.Resources.hang7 };

        private int wordguess = 0;

        //defining the soundtracks
        private bool found = false;
        private int hint = 3;
        private string current = "";
        private string cpycurrent = "";
        //list to store data of file in it
        List<string> list = new List<string>();
        List<string> list1 = new List<string>();
        List<string> list2 = new List<string>();
        List<string> list3 = new List<string>();
        List<string> list4 = new List<string>();
        List<string> list5 = new List<string>();
        List<string> list6 = new List<string>();
        List<string> list7 = new List<string>();
        private string Category;
        private string line;
        private string line1;
        private string line3;
        private string line2;
        private string line4;
        private string line5;
        private string line6;
        private string line7;

        private string[] wordarray;//for countries
        private string[] wordarray1;//for fruits  private string[] wordarray1;//for fruits
        private string[] wordarray2;//for animals
        private string[] wordarray3;//for songs
        private string[] wordarray4;//for movies
        private string[] wordarray5;//for food
        private string[] wordarray6;//for cars
        private string[] wordarray7;//for brands

        public level3()
        {
            InitializeComponent();
            player.SoundLocation = "track1.wav";
        }
        string category()
        {
            string unsortedcategory = "countries,fruits,songs,animals,movies,food,cars,Brands ";
            List<string> sortedcategory = unsortedcategory.Split(',').ToList();
            int index = new Random().Next(sortedcategory.Count);
            string secretword = sortedcategory[index];
            return secretword;
        }
        private void movies()
        {
            StreamReader file4 = new StreamReader("movies(level3).txt");

            while ((line4 = file4.ReadLine()) != null)
            {
                list4.Add(line4);
            }
            //copy the list to array
            wordarray4 = list4.ToArray();

        }
        private void food()
        {
            StreamReader file5 = new StreamReader("food(level3).txt");

            while ((line5 = file5.ReadLine()) != null)
            {
                list5.Add(line5);
            }
            //copy the list to array
            wordarray5 = list5.ToArray();

        }


        private void Fruits()
        {

            StreamReader file = new StreamReader("fruits(level3).txt");
            //store file data in a list
            while ((line = file.ReadLine()) != null)
            {
                list.Add(line);
            }
            //copy the list to array
            wordarray = list.ToArray();
            //3shan atl3 esm l file ll categorie

        }
        private void Countries()
        {

            StreamReader file1 = new StreamReader("Countries(level3).txt");
            //store file data in a list
            while ((line1 = file1.ReadLine()) != null)
            {
                list1.Add(line1);
            }
            //copy the list to array
            wordarray1 = list1.ToArray();
            //3shan atl3 esm l file ll categorie

        }
        private void animals()
        {
            StreamReader file2 = new StreamReader("animals(level3).txt");

            while ((line2 = file2.ReadLine()) != null)
            {
                list2.Add(line2);
            }
            //copy the list to array
            wordarray2 = list2.ToArray();

        }

        private void Songs()
        {
            StreamReader file3 = new StreamReader("songs(level3).txt");

            while ((line3 = file3.ReadLine()) != null)
            {
                list3.Add(line3);
            }
            //copy the list to array
            wordarray3 = list3.ToArray();

        }
        private void cars()
        {
            StreamReader file6 = new StreamReader("cars.txt");

            while ((line6 = file6.ReadLine()) != null)
            {
                list6.Add(line6);
            }
            //copy the list to array
            wordarray6 = list6.ToArray();

        }
        private void brands()
        {
            StreamReader file7 = new StreamReader("brands.txt");

            while ((line7 = file7.ReadLine()) != null)
            {
                list7.Add(line7);
            }
            //copy the list to array
            wordarray7 = list7.ToArray();

        }

       




        private void setup()
        {
            wordguess = 0;
            pictureBox2.Image = images[wordguess];
            //generate random index so we can have random word from the array
            Category = category();
            if (Category == "fruits")
            {
                int wordindex = (new Random()).Next(wordarray.Length);
                //set the chosen word in current 
                current = wordarray[wordindex];
            }
            else if (Category == "countries")
            {
                int wordindex1 = (new Random()).Next(wordarray1.Length);
                //set the chosen word in current 
                current = wordarray1[wordindex1];
            }
            else if (Category == "animals")
            {
                int wordindex2 = (new Random()).Next(wordarray2.Length);
                //set the chosen word in current 
                current = wordarray2[wordindex2];
            }
            else if (Category == "songs")
            {
                int wordindex3 = (new Random()).Next(wordarray3.Length);
                //set the chosen word in current 
                current = wordarray3[wordindex3];
            }
            else if (Category == "movies")
            {
                int wordindex4 = (new Random()).Next(wordarray4.Length);
                //set the chosen word in current 
                current = wordarray4[wordindex4];
            }
            else if (Category == "food")
            {
                int wordindex5= (new Random()).Next(wordarray5.Length);
                //set the chosen word in current 
                current = wordarray5[wordindex5];
            }
            else if (Category == "cars")
            {
                int wordindex6 = (new Random()).Next(wordarray6.Length);
                //set the chosen word in current 
                current = wordarray6[wordindex6];
            }
            else if (Category == "Brands ")
            {
                int wordindex7= (new Random()).Next(wordarray7.Length);
                //set the chosen word in current 
                current = wordarray7[wordindex7];
            }

            //to make underscores..bshof 3dd 7rof l kelma"current" w ba3ml mnha copy bnfs 3dd 7rofha bs b undersores"cpycurrent" 
            cpycurrent = "";
            for (int i = 0; i < current.Length; i++)
            {
                cpycurrent += "_";
            }
            displaycpy();
            label6.Text += "  " + current.Length;
            label4.Text = "category:  " + Category;
            button28.Text = "HINT  ( " + hint + " ) ";
        }


        //method to generate words to play

        //ba7ot l underscores fl label l 3mlto
        private void displaycpy()
        {
            label3.Text = "";
            for (int i = 0; i < cpycurrent.Length; i++)
            {
                label3.Text += cpycurrent.Substring(i, 1);
                label3.Text += " ";
            }
        }


        private void level3_Load(object sender, EventArgs e)
        {
            Countries();
            Fruits();
            Songs();
            animals();
            setup();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button choice = sender as Button;
            char guess = choice.Text.ElementAt(0);
            char[] temp = cpycurrent.ToCharArray();
            char[] chick = cpycurrent.ToCharArray();
            char[] find = current.ToCharArray();
            Random rand1 = new Random();

            int lenth = current.Length;
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
                                cpycurrent = new string(temp);
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

                                    if (button[k].Text == clikbutton)
                                    {
                                        button[k].Enabled = false;
                                        break;
                                    }
                                }
                            }
                            if (cpycurrent.Equals(current))
                            {

                                MessageBox.Show("YOU WIN <3 ");
                                break;
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

                    if (current.Contains(choice.Text))
                    {
                        for (int i = 0; i < find.Length; i++)
                        {
                            if (find[i] == guess)
                            {
                                temp[i] = guess;
                            }

                        }
                        cpycurrent = new string(temp);
                        displaycpy();
                        if (cpycurrent.Equals(current))
                        {
                            MessageBox.Show("YOU WIN <3 ");

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
                        MessageBox.Show("YOU LOST :P" + "  the word is   " + current.ToUpper());
                    }

                }
            }
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private void label6_Click(object sender, EventArgs e)
        {

        }




        private void button28_Click(object sender, EventArgs e)
        {
        
        }

       
   

        private void button1_Click_2(object sender, EventArgs e)
        {  this.Hide();
            level3 f_2 = new level3();
            f_2.ShowDialog();

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();


        }

        private void button29_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            player.Play();
        }

        private void button28_Click_1(object sender, EventArgs e)
        {

        }

        private void button28_Click_2(object sender, EventArgs e)
        {
           
        }
    }
}
