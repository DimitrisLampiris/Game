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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int c=0;
      
        private void Form2_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "PLAYER   (TIME) \n";
            try
            {

                richTextBox2.LoadFile("scores.txt", RichTextBoxStreamType.PlainText);
                foreach (string s in richTextBox2.Lines)
                {
                    try
                    {

                       
                        c++;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        break;
                    }
                }
            }
            catch (FileNotFoundException)
            {

            }
            int i = 0;
            String[] names = new String[c];
            int[] scores = new int[c];
            try
            {
                richTextBox2.LoadFile("scores.txt", RichTextBoxStreamType.PlainText);
                foreach (string s in richTextBox2.Lines)
                {
                    try
                    {

                        String[] tmp = s.Split(' ');
                     
                        names[i] = tmp[0];
                        scores[i] = int.Parse(tmp[1]);
                        i++;

                    }
                    catch (IndexOutOfRangeException)
                    {
                        break;
                    }
                }
                for (int j = 0; j < i; j++)
                {
                    for (int k = i - 1; k > j; k--)
                    {
                        if (scores[k - 1] > scores[k])
                        {
                            int temp = scores[k - 1];
                            scores[k - 1] = scores[k];
                            scores[k] = temp;
                            String temp1 = names[k - 1];
                            names[k - 1] = names[k];
                            names[k] = temp1;

                        }
                    }
                }
               
                for (int j = 0; j < 10; j++)
                {
                    try
                    {
                        int p = j + 1;
                        richTextBox1.Text += p.ToString() + ") " + names[j] + "  (" + scores[j].ToString() + ") \n";
                    }
                    catch (IndexOutOfRangeException)
                    {

                    }
                }

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("there are no records");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gotogame obj = new gotogame();
            
            obj.goback();
            this.Visible = false;
        }
    }
    class gotogame
    {
        public void goback()
        {
            Form1 form1 = new Form1();
            form1.Visible = true;
           
      
        }
    }


}
