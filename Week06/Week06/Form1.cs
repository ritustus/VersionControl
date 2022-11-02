using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week06.Abstractions;
using Week06.Entities;

namespace Week06
{
    public partial class Form1 : Form
    {
        List<Toy> _toys = new List<Toy>();

        private IToyFactory _factory;
        public IToyFactory Factory 
        {
            get { return _factory; }

            set { _factory = value; }
        }

        public Form1()
        {
            InitializeComponent();
            Factory = new BallFactory();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var toy = Factory.CreateNew();
            _toys.Add(toy);
            mainPanel.Controls.Add(toy);
            toy.Left = -toy.Width;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var ball in _toys)
            {
                ball.MoveToy();
                if (ball.Left > maxPosition)
                {
                    maxPosition = ball.Left;
                }

                if (maxPosition > 1000)
                {
                    var d = _toys[0];
                    _toys.Remove(d);
                    mainPanel.Controls.Remove(d);
                }
                
            }

        }

        private void btn_car_Click(object sender, EventArgs e)
        {
            Factory = new CarFactory();
        }

        private void btn_ball_Click(object sender, EventArgs e)
        {
            Factory = new BallFactory();
        }
    }
}
