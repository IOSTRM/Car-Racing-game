using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingGame
{
    public partial class Form1 : Form
    {
        int score;
        int gamespeed = 10;
        bool lose = false;
        
        public Form1()
        {
            InitializeComponent();

            over.Visible = false;
            restart.Visible = false;
            button1.Visible = false;
            KeyPreview = true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void change_gamespeed(int sc)
        {
            if(sc >= 500 && sc <= 1000)
            {
                gamespeed = 15;
            }
            if (sc >= 1000 && sc <= 2000)
            {
                gamespeed = 20;
            }
            if (sc >= 2000 && sc <= 3000)
            {
                gamespeed = 25;
            }
            if (sc >= 3000)
            {
                gamespeed = 30;
            }
        }

        private void show_message1(int sc)
        {
            mess.Text = "You have finished lavel 1 \n free game";
        }
        private void show_message2(int sc)
        {
            mess.Text = "You have finished lavel 2";
        }
        private void show_message3(int sc)
        {
            mess.Text = "You have finished lavel 3";
        }
        private void show_message4(int sc)
        {
            mess.Text = "You have finished lavel 4 \n Free game";        
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            txtScore.Text = "Score: " + score;
            score ++;
            change_gamespeed(score);
            if(score >= 500 && score <= 550)
            {
                show_message1(score);
                mess.Visible = true;
            }
            else if (score >= 1000 && score <= 1050)
            {
                show_message2(score);
                mess.Visible = true;
            }
            else if (score >= 2000 && score <= 2050)
            {
                show_message3(score);
                mess.Visible = true;
            }
            else if (score >= 3000 && score <= 3050)
            {
                show_message4(score);
                mess.Visible = true;
            }
            else
            {
                mess.Visible = false;
            }

            int carSpeed = 7;
            enemy1.Top += gamespeed;
            enemy3.Top += gamespeed;

            if(enemy1.Top >= 650)
            {
                enemy1.Top = -200;
                Random rand = new Random();
                enemy1.Left = rand.Next(100, 350);
            }
            if (enemy3.Top >= 650)
            {
                enemy3.Top = -400;
                Random rand = new Random();
                enemy3.Left = rand.Next(350, 600);
            }

            if (car.Bounds.IntersectsWith(enemy1.Bounds) || car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer.Enabled = false;
                over.Visible = true;
                restart.Visible = true;
                button1.Visible = true;
                lose = true;
            }
        }


        private void moveline(int speed)
        {
            if(pictureBox3.Top >= 650)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }
            if (pictureBox4.Top >= 650)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }
            if (pictureBox5.Top >= 650)
            {
                pictureBox5.Top = 0;
            }
            else
            {
                pictureBox5.Top += speed;
            }
            if (pictureBox6.Top >= 650)
            {
                pictureBox6.Top = 0;
            }
            else
            {
                pictureBox6.Top += speed;
            }
            if (pictureBox7.Top >= 650)
            {
                pictureBox7.Top = 0;
            }
            else
            {
                pictureBox7.Top += speed;
            }
        }

        private void pb1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)

        {
            if (lose) return;

            if(e.KeyCode == Keys.A)
            {
                if(car.Left > 40)
                {
                    car.Left -= 10;
                }
            }
            if(e.KeyCode == Keys.D)
            {
                if(car.Left < 710)
                {
                    car.Left += 10;
                }
            }
            if(e.KeyCode == Keys.W)
            {
                if(car.Top > 25)
                {
                    car.Top -= 5;
                }
            }
            if(e.KeyCode == Keys.S)
            {
                if(car.Top < 470)
                {
                    car.Top += 5;
                }
            }
        }

        private void restart_Click(object sender, EventArgs e)
        {
            enemy1.Top = -200;
            enemy3.Top = -400;
            over.Visible = false;
            restart.Visible = false;
            timer.Enabled = true;
            lose = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
