using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace lastname_firstname_template_v1_3_3
{
    internal class Bubble
    {
        Vector2 position;
        Vector2 direction;
        float speed = 100;
        float radius;
        Color colour;
        bool atEdgeOfScreen;

       public Bubble(Vector2 pos, float r, Color c)
        {
            position = pos;
            radius = r;
            colour = c;
            //Random direction
            direction = MohawkGame2D.Random.Direction(); 
        }

        public void Render()
        {
            Draw.FillColor = colour;
            Draw.Circle(position, radius);

        }
        //Ball differs a little from the original game, I want the ball to bounce around the sceen instead of just using gravity
        public void Update()
        {
            //edits the balls speed
            speed += Time.DeltaTime * 3;
            position += direction * speed * Time.DeltaTime;

            //Edge of screen checks
            bool leftEdge = position.X <= 0;
            bool rightEdge = position.X >= Window.Width;
            bool topEdge = position.Y <= 0;
            bool bottomEdge = position.Y >= Window.Height;
        }
    }
}
