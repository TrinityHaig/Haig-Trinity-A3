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
        float speed;
        float radius;
        Color colour;
        bool atEdgeOfScreen;

       public Bubble(Vector2 pos, float r, Color c)
        {
            position = pos;
            radius = r;
            colour = c;
            //Random direction
            direction = Random.Direction; //why am i getting an error.
        }
    }
}
