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
        public float speed = 100;
        public void Render()
        {
            Draw.FillColor = Color.Black;
            Draw.Circle(position, 15);
            Draw.FillColor = Color.Black;
            Draw.Rectangle(position,size);
        }
        //player will use similar collision checks to bubble but only for the left and right.
        public void Update()
        {
            movement();
            collision();
        }

        private void collision()
        {
            bool leftScreen = position.X + hitbox <= 0;
            bool rightSceen = position.X + hitbox >= Window.Width;
            //up anddown collision issnt needed
            if (leftScreen)
            {
                position.X = 0 + hitbox;
            }
            if (rightSceen)
            {
                position.X = 0 - hitbox;
            }
        }

        private void movement()
        {
            Vector2 move = Vector2.Zero; // input vector

            //keyboard inputs (only need left and right movement)
            float horizontalKey = Input.GetAxis(KeyboardInput.A, KeyboardInput.D);

            move *= speed * Time.DeltaTime;
            position += move;

        }
    }
}
