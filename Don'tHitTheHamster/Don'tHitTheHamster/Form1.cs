using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Don_tHitTheHamster
{
    public partial class Form1 : Form
    {
        private int _score;
        private int[] _locationX1 = { 160, 370, 590 };
        private int[] _locationX2 = { 120, 370, 620 };
        private int[] _locationX3 = { 110, 370, 630 };
        private int[] _locationY = { 85, 225, 395 };

        public Form1()
        {
            InitializeComponent();

            Start();
        }

        private void Start()
        {
            timer1.Enabled = true;
            timer1.Interval = 1500;

            btnRestart.Enabled = false;
            btnRestart.Visible = false;

            Hamster.Visible = false;
            Enemy.Visible = false;

            lblScore.Text = "Счёт: 0";
            _score = 0;
        }

        private void Lose()
        {
            timer1.Enabled = false;

            btnRestart.Enabled = true;
            btnRestart.Visible = true;
        }

        private void ObjectStatus(Button object1, Random rand)
        {
            int y = _locationY[rand.Next(0, 3)];
            int x = 0;

            if (y == _locationY[0])
            {
                x = _locationX1[rand.Next(0, 3)];
            }
            else if (y == _locationY[1])
            {
                x = _locationX2[rand.Next(0, 3)];
            }
            else if (y == _locationY[2])
            {
                x = _locationX3[rand.Next(0, 3)];
            }

            //switch (y)
            //{
            //    case 85:
            //        x = _locationX1[rand.Next(0, 3)];
            //        break;
            //    case 225:
            //        x = _locationX2[rand.Next(0, 3)];
            //        break;
            //    case 395:
            //        x = _locationX3[rand.Next(0, 3)];
            //        break;
            //}

            object1.Location = new Point(x, y);
            
            object1.Visible = Convert.ToBoolean(rand.Next(0, 2));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();

            Hamster.Visible = false;
            Enemy.Visible = false;

            ObjectStatus(Enemy, rand);
            if (Enemy.Visible == false)
            {
                ObjectStatus(Hamster, rand);
            }
        }

        private void Enemy_Click(object sender, EventArgs e)
        {
            if (Enemy.Visible == true)
            {
                _score += 1;
                lblScore.Text = $"Счёт: {_score}";
                Enemy.Visible = false;
            }
        }

        private void Hamster_Click(object sender, EventArgs e)
        {
            if (Hamster.Visible == true)
            {
                Lose();
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
