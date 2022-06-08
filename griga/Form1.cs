using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace griga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void passbut1_Click(object sender, EventArgs e)
        {
            string passworld ="" ;
            Random rnd = new Random();
            if (checkBox1.CheckedItems.Count == 0) 
            return;
            
            for (int i = 0; i < lengh.Value; i++)
            {
                int whatchecked = rnd.Next(0, checkBox1.CheckedItems.Count);
                string choosen = checkBox1.CheckedItems[whatchecked].ToString();
                switch (choosen)
                {
                    case "Цифры":
                        passworld += Convert.ToChar(rnd.Next(48, 57));
                        break;
                    case "Буквы и специальные символы":
                        passworld += Convert.ToChar(rnd.Next(65, 122));
                        
                        break;
                }
                passlb1.Text = passworld.ToString();
            }

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(passlb1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            passlb1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }
    }
    
}








