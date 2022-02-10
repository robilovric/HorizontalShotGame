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

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            int tick_number = 1;
            LeaveTrail();
            ObjectBall.Left += (int)(velocity * 1 * tick_number);
            ObjectBall.Top += (int)(0.5 * gravity * Math.Pow(1 * tick_number, 2));
            tick_number += 1;
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
            int x = rand.Next(20, this.ClientSize.Width - Target.Width);
            int y = rand.Next(20, this.ClientSize.Height - Target.Height);
            Target.Location = new Point(x, y);
        }
    }

}
