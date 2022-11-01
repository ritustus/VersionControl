using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week06.Abstractions;

namespace Week06.Entities
{
    public class Car : Toy
    {
        protected override void DrawImage(Graphics graphics)
        {
            Image img = Image.FromFile("Images/car.png");
            graphics.DrawImage(img, new Rectangle(0, 0, Width, Height));
        }
    }
}
