using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HorizontalShotGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }

        double gravity = 9.81;
        double velocity;
        Random rand = new Random();
        int score, attempt;

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            int tick_number = 1;
            LeaveTrail();
            ObjectBall.Left += (int)(velocity * 0.5 * tick_number);
            ObjectBall.Top += (int)(0.5 * gravity * Math.Pow(0.5 * tick_number, 2));
            tick_number += 1;

            if (ObjectBall.Bounds.IntersectsWith(Target.Bounds))
            {
                score += 1;
                ObjectBall.Visible = false;
                Score.Text += score.ToString();
            }
        }

        private void LeaveTrail()
        {
            PictureBox trail = new PictureBox();
            trail.Height = 2;
            trail.Width = 2;
            trail.BackColor = Color.Black;
            trail.Location = ObjectBall.Location;
            this.Controls.Add(trail);
        }

        private void ResetGame()
        {
            GameTimer.Start();
            score = 0;
            attempt = 0;
            ObjectBall.Location = new Point(10, 10);
            int x = rand.Next(20, this.ClientSize.Width - Target.Width);
            int y = rand.Next(20, this.ClientSize.Height - Target.Height);
            Target.Location = new Point(x, y);
            Score.Text += score.ToString();
            Attempt.Text += attempt.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            velocity = double.Parse(textBox1.Text);
            attempt += 1;
            Attempt.Text += attempt.ToString();
            //textBox1.di
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                ResetGame();
            }
            if (e.KeyCode == Keys.Escape)
            {
                GameOver();
            }
        }

      
        private void GameOver()
        {
            GameTimer.Stop();
            this.Close();
        }
    }

}
