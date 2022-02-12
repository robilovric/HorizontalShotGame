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
        double velocity = 0;
        Random rand = new Random();
        int score, attempt = 0;

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            //will display a trail control on our form on each tick in relation to (t - timer_interval) objectball
            LeaveTrail();
            //doing the physics of horizontal shot and adapting it to pixel grid
            int tick_number = 1;
            ObjectBall.Left += (int)(velocity * 0.5 * tick_number);
            ObjectBall.Top += (int)(0.5 * gravity * Math.Pow(0.5 * tick_number, 2));
            tick_number += 1;
            //objectball hitting the target
            if (ObjectBall.Bounds.IntersectsWith(Target.Bounds))
            {
                
                ObjectBall.Visible = false;
                score += 1;
                Score.Text += " ";
                //erasing the previous trail
                for (int i = 0; i < this.Controls.Count; ++i)
                {
                    if (Controls[i].Name == "trail")
                    {
                        Controls[i].Visible = false;
                        Controls.RemoveAt(i);
                    }
                }
                GameTimer.Stop();
                ResetGame();
            }
        }

        private void LeaveTrail()
        {
            //object trajectory consists of tiny little pictureBoxex and will mark object ball position on each timerTick
            PictureBox trail = new PictureBox();
            trail.Name = "trail";
            trail.Height = 1;
            trail.Width = 1;
            trail.BackColor = Color.Black;
            trail.Location = ObjectBall.Location;
            
            this.Controls.Add(trail);
        }

        private void ResetGame()
        {         
            ObjectBall.Location = new Point(10, 10);
            if (ObjectBall.Visible == false) { ObjectBall.Visible = true; }
            int x = rand.Next(20, this.ClientSize.Width - Target.Width);
            int y = rand.Next(20, this.ClientSize.Height - Target.Height);
            Target.Location = new Point(x, y);
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

        private void Score_TextChanged(object sender, EventArgs e)
        {
            Score.Text = "Score: " + score.ToString();
        }

        private void Attempt_TextChanged(object sender, EventArgs e)
        {
            Attempt.Text = "Attempts: " + attempt.ToString();
        }


        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GameTimer.Start();
                try
                {
                    velocity = double.Parse(textBox1.Text);
                }
                catch (Exception) { textBox1.Text = "Invalid input!"; textBox1.Enabled = false; GameTimer.Stop(); return; }
                attempt += 1;
                Attempt.Text += " ";

                textBox1.Text = velocity.ToString() + " m/s";
            }

        }

        private void GameOver()
        {
            GameTimer.Stop();
            this.Close();
        }
    }

}
