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
        int real_control_number = 6;
        int tick_number = 1;
        double gravity = 9.81;
        double velocity = 0;
        Random rand = new Random();
        int score, attempt = 0;
        //bool isGameOver;


        private void timer1_Tick(object sender, EventArgs e)
        {
            //will display a trail control on our form on each tick in relation to (t - timer_interval) objectball
            LeaveTrail();
            //doing the physics of horizontal shot and adapting it to pixel grid
            //0.1 is gameTimer interval in seconds
            ObjectBall.Left += (int)(velocity * 0.1 * tick_number);
            ObjectBall.Top += (int)(0.5 * gravity * Math.Pow(0.1 * tick_number, 2));
            tick_number += 1;
            //objectball hitting the target
            if (ObjectBall.Bounds.IntersectsWith(Target.Bounds))
            {
                GameTimer.Stop();
                ObjectBall.Visible = false;
                score += 1;
                Score.Text += " ";

                ResetGame();
            }
            if(ObjectBall.Location.X < ClientRectangle.Size.Width && ObjectBall.Location.Y > ClientRectangle.Size.Height)
            {
                GameTimer.Stop();        
                ResetGame();
            }
            if (ObjectBall.Location.X > ClientRectangle.Size.Width && ObjectBall.Location.Y < ClientRectangle.Size.Height)
            {
                GameTimer.Stop();
                ResetGame();
            }

        }

        private void LeaveTrail()
        {
            //object trajectory consists of tiny little pictureBoxes and will mark object ball position on each timerTick
            PictureBox trail = new PictureBox();
            trail.Name = "trail";
            trail.Height = 3;
            trail.Width = 3;
            trail.BackColor = Color.Black;
            trail.Location = ObjectBall.Location;
            
            this.Controls.Add(trail);
        }

        private void ResetGame()
        {
            //erasing previous attempt trajectory
            while (this.Controls.Count > real_control_number)
            {
                EraseTrail();
            }
            ObjectBall.Location = new Point(10, 10);
            ObjectBall.Visible = true;
            //positioning the target for the next attempt
            int x = rand.Next(20, this.ClientSize.Width - Target.Width);
            int y = rand.Next(20, this.ClientSize.Height - Target.Height);
            Target.Location = new Point(x, y);
            //reseting timestamp
            tick_number = 1;
        }
             
        private void Form1_KeyDown(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.C)
            {
                EraseTrail();
            }
            if (e.KeyCode == Keys.Escape)
            {
                GameOver();
            }
            if (e.KeyCode == Keys.R)
            {
                ResetGame();
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
            textBox1.Enabled = !textBox1.Enabled;
        }

        
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                attempt += 1;
                Attempt.Text += " ";
                try
                {
                    velocity = double.Parse(textBox1.Text);
                }
                catch (Exception) { textBox1.Text = "Invalid input!"; return; }
                GameTimer.Start();
                textBox1.Text += " m/s";
                textBox1.Enabled = false;
            }

        }

        private void EraseTrail()
        {
            //erasing the previous trail
            for (int i = 0; i < this.Controls.Count; ++i)
            {
                if (Controls[i].Name == "trail")
                {
                    Controls[i].Visible = false;
                    Controls.RemoveAt(i);
                }
            }
        }


        private void GameOver()
        {
            GameTimer.Stop();
            this.Close();
        }
    }

}
