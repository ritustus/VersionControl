using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week06.Entities
{
    class Ball : Label
    {
        public Ball()
        {
            AutoSize = false;
            Height = 50;
            Width = 50;
            Paint += Ball_Paint;
           
        }

        private void Ball_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DrawImage(Graphics graphics)
        {

        }

        public void MoveBall() 
        {
            Left += 1;
        }
    }
}
