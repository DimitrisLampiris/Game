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

namespace Game1
{
    public partial class Form1 : Form
    {
        PictureBox b;
        bool first=true,start=false;
        int pb,count=0,time=0,zeugaria=0;
        string user;
        Random rdm = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                user = textBox1.Text;
                count = 0;
                time = 0;
                zeugaria = 0;

                timer1.Enabled = true;
                foreach (PictureBox p in panel1.Controls)
                {

                    int picture = rdm.Next(1, 21);
                    start = true;
                    if (picture == 1)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox1.Location;
                        pictureBox1.Location = tempBox.Location;
                    }
                    else if (picture == 2)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox2.Location;
                        pictureBox2.Location = tempBox.Location;
                    }
                    else if (picture == 3)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox3.Location;
                        pictureBox3.Location = tempBox.Location;
                    }
                    else if (picture == 4)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox4.Location;
                        pictureBox4.Location = tempBox.Location;
                    }
                    else if (picture == 5)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox5.Location;
                        pictureBox5.Location = tempBox.Location;
                    }
                    else if (picture == 6)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox6.Location;
                        pictureBox6.Location = tempBox.Location;

                    }
                    else if (picture == 7)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox7.Location;
                        pictureBox7.Location = tempBox.Location;

                    }
                    else if (picture == 8)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox8.Location;
                        pictureBox8.Location = tempBox.Location;
                    }
                    else if (picture == 9)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox9.Location;
                        pictureBox9.Location = tempBox.Location;
                    }
                    else if (picture == 10)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox10.Location;
                        pictureBox10.Location = tempBox.Location;
                    }
                    else if (picture == 11)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox11.Location;
                        pictureBox11.Location = tempBox.Location;
                    }
                    else if (picture == 12)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox12.Location;
                        pictureBox12.Location = tempBox.Location;
                    }
                    else if (picture == 13)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox13.Location;
                        pictureBox13.Location = tempBox.Location;
                    }
                    else if (picture == 14)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox14.Location;
                        pictureBox14.Location = tempBox.Location;
                    }
                    else if (picture == 15)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox15.Location;
                        pictureBox15.Location = tempBox.Location;
                    }
                    else if (picture == 16)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox16.Location;
                        pictureBox16.Location = tempBox.Location;
                    }
                    else if (picture == 17)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox17.Location;
                        pictureBox17.Location = tempBox.Location;
                    }
                    else if (picture == 18)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox18.Location;
                        pictureBox18.Location = tempBox.Location;
                    }
                    else if (picture == 19)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox19.Location;
                        pictureBox19.Location = tempBox.Location;
                    }
                    else
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox20.Location;
                        pictureBox20.Location = tempBox.Location;
                    }
                }
                button1.Enabled = false;
            }
            else MessageBox.Show("give a username");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (start)
            {
              
                pictureBox2.Image = b1.Image;
                MessageBox.Show("Click For Next(Enter or Click Ok)");
                if (!first)
                {
                    count++;
                    if (pb == 1)
                    {
                        zeugaria++;
                        pictureBox1.Visible = pictureBox2.Visible = false;
                    }
                    else

                        pictureBox2.Image = b.Image = tempBox.Image;

                }
                else
                {
                    b = pictureBox2;
                    pb = 2;
                }
                if (first)
                {
                    first = false;
                }
                else first = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (start)
            {
              
                pictureBox3.Image = b2.Image;
                MessageBox.Show("Click For Next(Enter or Click Ok)");
                if (!first)
                {
                    count++;
                    if (pb == 4)
                    {
                        zeugaria++;
                        pictureBox3.Visible = pictureBox4.Visible = false;
                    }
                    else

                        pictureBox3.Image = b.Image = tempBox.Image;

                }
                else
                {
                    b = pictureBox3;
                    pb = 3;
                }
                if (first)
                {
                    first = false;
                }
                else first = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (start)
            {
               
                pictureBox4.Image = b2.Image;
                MessageBox.Show("Click For Next(Enter or Click Ok)");
                if (!first)
                {
                    count++;
                    if (pb == 3)
                    {
                        zeugaria++;
                        pictureBox4.Visible = pictureBox3.Visible = false;
                    }
                    else

                        pictureBox4.Image = b.Image = tempBox.Image;

                }
                else
                {
                    b = pictureBox4;
                    pb = 4;
                }
                if (first)
                {
                    first = false;
                }
                else first = true;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (start)
            {
              
                pictureBox5.Image = b3.Image;
                MessageBox.Show("Click For Next(Enter or Click Ok)");
                if (!first)
                {
                    count++;
                    if (pb == 6)
                    {
                        zeugaria++;
                        pictureBox5.Visible = pictureBox6.Visible = false;
                    }
                    else

                        pictureBox5.Image = b.Image = tempBox.Image;

                }
                else
                {
                    b = pictureBox5;
                    pb = 5;
                }
                if (first)
                {
                    first = false;
                }
                else first = true;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (start)
            {
                
                pictureBox6.Image = b3.Image;
                MessageBox.Show("Click For Next(Enter or Click Ok)");
                if (!first)
                {
                    count++;
                    if (pb == 5)
                    {
                        zeugaria++;
                        pictureBox6.Visible = pictureBox5.Visible = false;
                    }
                    else

                        pictureBox6.Image = b.Image = tempBox.Image;

                }
                else
                {
                    b = pictureBox6;
                    pb = 6;
                }
                if (first)
                {
                    first = false;
                }
                else first = true;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (start)
            {
               
                pictureBox7.Image = b4.Image;
                MessageBox.Show("Click For Next(Enter or Click Ok)");
                if (!first)
                {
                    count++;
                    if (pb == 8)
                    {
                        zeugaria++;
                        pictureBox7.Visible = pictureBox8.Visible = false;
                    }
                    else

                        pictureBox7.Image = b.Image = tempBox.Image;

                }
                else
                {
                    b = pictureBox7;
                    pb = 7;
                }
                if (first)
                {
                    first = false;
                }
                else first = true;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (start)
            {
               
                pictureBox8.Image = b4.Image;
               MessageBox.Show("Click For Next(Enter or Click Ok)");
                if (!first)
                {
                    count++;
                    if (pb == 7)
                    {
                        zeugaria++;
                        pictureBox8.Visible = pictureBox7.Visible = false;
                    }
                    else

                        pictureBox8.Image = b.Image = tempBox.Image;

                }
                else
                {
                    b = pictureBox8;
                    pb = 8;
                }
                if (first)
                {
                    first = false;
                }
                else first = true;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (start)
            {
               
                pictureBox9.Image = b5.Image;
                MessageBox.Show("Click For Next(Enter or Click Ok)");
                if (!first)
                {
                    count++;
                    if (pb == 10)
                    {
                        zeugaria++;
                        pictureBox9.Visible = pictureBox10.Visible = false;
                    }
                    else

                        pictureBox9.Image = b.Image = tempBox.Image;

                }
                else {
                    b = pictureBox9;
                    pb = 9;
                }
                if (first)
                {
                    first = false;
                }
                else first = true;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (start)
            {
               
                pictureBox10.Image = b5.Image;
                MessageBox.Show("Click For Next(Enter or Click Ok)");
                if (!first)
                {
                    count++;
                    if (pb == 9)
                    {
                        zeugaria++;
                        pictureBox10.Visible = pictureBox9.Visible = false;
                    }
                    else

                        pictureBox10.Image = b.Image = tempBox.Image;

                }
                else
                {
                    b = pictureBox10;
                    pb = 10;
                }
                if (first)
                {
                    first = false;
                }
                else first = true;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (start)
            {
                
                pictureBox11.Image = b6.Image;
                MessageBox.Show("Click For Next(Enter or Click Ok)");
                if (!first)
                {
                    count++;
                    if (pb == 12)
                    {
                        zeugaria++;
                        pictureBox11.Visible = pictureBox12.Visible = false;
                    }
                    else

                        pictureBox11.Image = b.Image = tempBox.Image;

                }
                else
                {
                    b = pictureBox11;
                    pb = 11;
                }
                if (first)
                {
                    first = false;
                }
                else first = true;
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (start)
            {
                
                pictureBox12.Image = b6.Image;
                MessageBox.Show("Click For Next(Enter or Click Ok)");
                if (!first)
                {
                    count++;
                    if (pb == 11)
                    {
                        zeugaria++;
                        pictureBox12.Visible = pictureBox11.Visible = false;
                    }
                    else

                        pictureBox12.Image = b.Image = tempBox.Image;

                }
                else
                {
                    b = pictureBox12;
                    pb = 12;
                }
                if (first)
                {
                    first = false;
                }
                else first = true;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (start)
            {
                
                pictureBox13.Image = b7.Image;
                MessageBox.Show("Click For Next(Enter or Click Ok)");
                if (!first)
                {
                    count++;
                    if (pb == 14)
                    {
                        zeugaria++;
                        pictureBox13.Visible = pictureBox14.Visible = false;
                    }
                    else

                        pictureBox13.Image = b.Image = tempBox.Image;

                }
                else { b = pictureBox13;
                    pb = 13;
                }
                if (first)
                {
                    first = false;
                }
                else first = true;
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (start)
            {
                
                pictureBox14.Image = b7.Image;
                MessageBox.Show("Click For Next(Enter or Click Ok)");
                if (!first)
                {
                    count++;
                    if (pb == 13)
                    {
                        zeugaria++;
                        pictureBox14.Visible = pictureBox13.Visible = false;
                    }
                    else

                        pictureBox14.Image = b.Image = tempBox.Image;

                }
                else
                {
                    b = pictureBox14;
                    pb = 14;
                }
                if (first)
                {
                    first = false;
                }
                else first = true;
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (start)
            {
               
                pictureBox15.Image = b8.Image;
                MessageBox.Show("Click For Next(Enter or Click Ok)");
                if (!first)
                {
                    count++;
                    if (pb == 16)
                    {
                        zeugaria++;
                        pictureBox15.Visible = pictureBox16.Visible = false;
                    }
                    else

                        pictureBox15.Image = b.Image = tempBox.Image;

                }
                else
                {
                    b = pictureBox15;
                    pb = 15;
                }
                if (first)
                {
                    first = false;
                }
                else first = true;
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (start)
            {
                
                pictureBox16.Image = b8.Image;
                MessageBox.Show("Click For Next(Enter or Click Ok)");
                if (!first)
                {
                    count++;
                    if (pb == 15)
                    {
                        zeugaria++;
                        pictureBox16.Visible = pictureBox15.Visible = false;
                    }
                    else

                        pictureBox16.Image = b.Image = tempBox.Image;

                }
                else
                {
                    b = pictureBox16;
                    pb = 16;
                }
                if (first)
                {
                    first = false;
                }
                else first = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if (zeugaria == 10)
            {
                timer1.Enabled = false;
                MessageBox.Show("teleiwses se " + time.ToString() +" kai se "+  count.ToString()+ " prospathies");
                File.AppendAllText("scores.txt",user + " " + time.ToString() + Environment.NewLine, Encoding.UTF8);
                zeugaria = 0;
                count = 0;
                button1.Enabled = true;
                foreach(PictureBox p in panel1.Controls)
                {
                    p.Visible = true;
                    p.Image = tempBox.Image;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            foreach(PictureBox p in panel2.Controls)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                string imagelocation = "";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)

                {
                    imagelocation = dialog.FileName;
                    p.ImageLocation = imagelocation;
                }

            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {if (start)
            {
               
                pictureBox17.Image = b9.Image;
                MessageBox.Show("Click For Next(Enter or Click Ok)");
                if (!first)
                {
                    count++;
                    if (pb == 18)
                    {
                        zeugaria++;
                        pictureBox17.Visible = pictureBox18.Visible = false;
                    }
                    else

                        pictureBox17.Image = b.Image = tempBox.Image;

                }
                else
                {
                    b = pictureBox17;
                    pb = 17;
                }
                if (first)
                {
                    first = false;
                }
                else first = true;
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                user = textBox1.Text;
                count = 0;
                time = 0;
                zeugaria = 0;

                timer1.Enabled = true;
                foreach (PictureBox p in panel1.Controls)
                {

                    int picture = rdm.Next(1, 21);
                    start = true;
                    if (picture == 1)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox1.Location;
                        pictureBox1.Location = tempBox.Location;
                    }
                    else if (picture == 2)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox2.Location;
                        pictureBox2.Location = tempBox.Location;
                    }
                    else if (picture == 3)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox3.Location;
                        pictureBox3.Location = tempBox.Location;
                    }
                    else if (picture == 4)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox4.Location;
                        pictureBox4.Location = tempBox.Location;
                    }
                    else if (picture == 5)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox5.Location;
                        pictureBox5.Location = tempBox.Location;
                    }
                    else if (picture == 6)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox6.Location;
                        pictureBox6.Location = tempBox.Location;

                    }
                    else if (picture == 7)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox7.Location;
                        pictureBox7.Location = tempBox.Location;

                    }
                    else if (picture == 8)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox8.Location;
                        pictureBox8.Location = tempBox.Location;
                    }
                    else if (picture == 9)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox9.Location;
                        pictureBox9.Location = tempBox.Location;
                    }
                    else if (picture == 10)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox10.Location;
                        pictureBox10.Location = tempBox.Location;
                    }
                    else if (picture == 11)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox11.Location;
                        pictureBox11.Location = tempBox.Location;
                    }
                    else if (picture == 12)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox12.Location;
                        pictureBox12.Location = tempBox.Location;
                    }
                    else if (picture == 13)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox13.Location;
                        pictureBox13.Location = tempBox.Location;
                    }
                    else if (picture == 14)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox14.Location;
                        pictureBox14.Location = tempBox.Location;
                    }
                    else if (picture == 15)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox15.Location;
                        pictureBox15.Location = tempBox.Location;
                    }
                    else if (picture == 16)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox16.Location;
                        pictureBox16.Location = tempBox.Location;
                    }
                    else if (picture == 17)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox17.Location;
                        pictureBox17.Location = tempBox.Location;
                    }
                    else if (picture == 18)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox18.Location;
                        pictureBox18.Location = tempBox.Location;
                    }
                    else if (picture == 19)
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox19.Location;
                        pictureBox19.Location = tempBox.Location;
                    }
                    else
                    {
                        tempBox.Location = p.Location;
                        p.Location = pictureBox20.Location;
                        pictureBox20.Location = tempBox.Location;
                    }
                }
                button1.Enabled = false;
            }
            else MessageBox.Show("give a username");

        }

        private void highScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 form = new Form2();
            form.Show();
            this.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closaapp close = new closaapp();
            close.endapp();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            if (start)
            {
                
                pictureBox18.Image = b9.Image;
                MessageBox.Show("Click For Next(Enter or Click Ok)");
                if (!first)
                {
                    count++;
                    if (pb == 17)
                    {
                        zeugaria++;
                        pictureBox18.Visible = pictureBox17.Visible = false;
                    }
                    else

                        pictureBox18.Image = b.Image = tempBox.Image;

                }
                else
                {
                    b = pictureBox18;
                    pb = 18;
                }
                if (first)
                {
                    first = false;
                }
                else first = true;
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (start)
            {
                
                pictureBox19.Image = b10.Image;
                MessageBox.Show("Click For Next(Enter or Click Ok)");
                if (!first)
                {
                    count++;
                    if (pb == 20)
                    {
                        zeugaria++;
                        pictureBox19.Visible = pictureBox20.Visible = false;
                    }
                    else

                        pictureBox19.Image = b.Image = tempBox.Image;

                }
                else
                {
                    b = pictureBox19;
                    pb = 19;
                }
                if (first)
                {
                    first = false;
                }
                else first = true;
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (start)
            {
                
                pictureBox20.Image = b10.Image;
                MessageBox.Show("Click For Next(Enter or Click Ok)");
                if (!first)
                {
                    count++;
                    if (pb == 19)
                    {
                        zeugaria++;
                        pictureBox20.Visible = pictureBox19.Visible = false;
                    }
                    else

                        pictureBox20.Image = b.Image = tempBox.Image;

                }
                else
                {
                    b = pictureBox20;
                    pb = 20;
                }
                if (first)
                {
                    first = false;
                }
                else first = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (start)
            {
                
                pictureBox1.Image = b1.Image;
                MessageBox.Show("Click For Next(Enter or Click Ok)");
                if (!first)
                {
                    count++;
                    if (pb == 2)
                    {
                        zeugaria++;
                        pictureBox1.Visible = pictureBox2.Visible = false;
                    }
                    else

                        pictureBox1.Image = b.Image = tempBox.Image;

                }
                else
                {
                    b = pictureBox1;
                    pb = 1;
                }
                if (first)
                {
                    first = false;
                }
                else first = true;
            }
        }
    }

    class closaapp
    {
        public void endapp()
        {
            Application.Exit();
        }
    }





}
    

