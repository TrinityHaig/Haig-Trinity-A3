using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace lastname_firstname_template_v1_3_3
{
    internal class Player
    {
        public Vector2 position;
        public float hitbox = 0;
        public Vector2 size;
        public Player()
        {

        }
        public void Render()
        {
            Draw.FillColor = Color.Black;
            Draw.Circle(position, 15);
            Draw.FillColor = Color.Black;
            Draw.Rectangle(position,size);
        }
    }
}
