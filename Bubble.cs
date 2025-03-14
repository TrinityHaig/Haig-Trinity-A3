using MohawkGame2D;
//using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
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
            if (atEdgeOfScreen)
            {
                //bounce off top and sides
                if (leftEdge || rightEdge)
                {
                    direction.X = -direction.X;
                }

                if (topEdge || bottomEdge)
                {
                    direction.Y = -direction.Y;
                }

                if (leftEdge)
                {
                    position.X = 0;
                }
                if (rightEdge)
                {
                    position.X = Window.Width;
                }
                if (bottomEdge)
                {
                    position.Y = Window.Height;
                }
                if (topEdge)
                {
                    position.Y = 0;
                }
            }
        }
        public Vector2 GetPosition()
        {
            return position;
        }

        //bubble splits in two
        public Bubble ()
        {
            Bubble split = new Bubble(position,radius,colour);
            Vector2 split1 = Random.Direction() / 3;
            Vector2 split2 = Random.Direction() / 3;
            //following the class lecture for this ;-;
            this.direction = Vector2.Normalize (direction + split1);
            split.direction = Vector2.Normalize(direction + split2);
        }
    }
}
