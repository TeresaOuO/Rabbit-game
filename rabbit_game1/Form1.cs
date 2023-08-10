using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rabbit_game1
{
    public partial class Form1 : Form
    {
        Random rnd = new Random(2);
        int number = 0;
        int score = 0;
        int second = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtShow.Text = "Oh!!";
            number = number + 1;
            score = score + 10;
            txtNumber.Text = number.ToString();
            textBox1.Text = score.ToString();
            if (number >= 10) {
                timer1.Enabled = false;
                rabbit.Visible = false;
                MessageBox.Show("恭喜你過關!你一共用了"+second+"秒");
                txtShow.Text = "";
                txtNumber.Text = "";
                textBox1.Text = "";
                comboBox1.Text = "請選擇";
                timer1.Enabled = false;
                rabbit.Visible = false;
                comboBox1.Enabled = true;
                button1.Enabled = false;
                timer1.Enabled = false;
                number = 0;
                score = 0;
                second = 0;
            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtShow.Text = "";
            int x;
            int y;
            x = rnd.Next(1, 1073);
            y = rnd.Next(1, 377);
            rabbit.Location = new Point(x, y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtShow.Text = "";
            txtNumber.Text = "";
            timer1.Enabled = false;
            rabbit.Visible = false;
            button1.Enabled = false;
            timer2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            rabbit.Visible = true;
            comboBox1.Enabled = false;
            button1.Enabled = false;
            timer2.Enabled = true;
            timer2.Interval = 1000;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i;
            i = comboBox1.SelectedIndex;
            switch (i)
            {
                case -1:
                    MessageBox.Show("請選擇難易度");
                    break;
                case 0:
                    timer1.Interval = 1000;
                    
                    break;
                case 1:
                    timer1.Interval = 500;
                    
                    break;
                case 2:
                    timer1.Interval = 200;
                    
                    break;
            }
            button1.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            second = second + 1;
        }
    }
}
