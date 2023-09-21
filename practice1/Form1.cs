using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int var1 = -1;
        private void button1_Click(object sender, EventArgs e)
        {
          
         timer1.Start();
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (var1 < textBox1.Text.Length)
                {
                    var1++;
                    if (Convert.ToInt32(textBox1.Text[var1]) % 2 == 0)
                    {
                        listView2.Items.Add(" " + textBox1.Text[var1]);

                    }
                    else if (Convert.ToInt32(textBox1.Text[var1]) % 1 == 0)
                    {
                        listView1.Items.Add(" " + textBox1.Text[var1]);

                    }
                    else
                    {
                        timer1.Stop();
                    }
                }
                else
                {
                    timer1.Stop();
                }
            }catch (Exception r)
            {
                if(textBox1.Text == "")
                {
                    MessageBox.Show("Enter a numbers in textbox");
                }
                else
                {
                    MessageBox.Show("The numbers you input in textbox is reached!");
                    textBox1.Clear();
                    
                }
            }

        }
    }
}
