using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace frmwrk.Core
{
   public class Keymoves: IMovements
    {
        private int speed;
        private Point boundry;
        private string direction;

        public int Speed { get => speed; set => speed = value; }
        public Point Boundry { get => boundry; set => boundry = value; }
        public string Direction { get => direction; set => direction = value; }

        public Keymoves(int speed, Point boundry)
        {
            this.Speed = speed;
            this.Boundry = boundry;
            Direction = null;
        }
        public void movingkeysforuser(Keys keycode,Image img)
        {
            if (keycode == Keys.Up)
            {
                Direction = "Up";
            }
            else if (keycode == Keys.Down)
            {
                Direction = "Down";
            }
            else if (keycode == Keys.Left)
            {
                Direction = "Left";
            }

            else if (keycode == Keys.Right)
            {
                Direction = "Right";

            }
        }
        public Point move(Point location)
        {
            if (Direction != null)
            {
                if (Direction == "Up" && location.Y > 0)
                {
                    location.Y -= Speed;
                }
                if (Direction == "Down" && location.Y < Boundry.Y)
                {
                    location.Y += Speed;
                }
                if (Direction == "Left" && location.X > 0)
                {
                    location.X -= Speed;
                }
                if (Direction == "Right" && location.X < Boundry.X)
                {
                    location.X += Speed;
                }
                Direction = null;
            }

            return location;
        }
    }
}
