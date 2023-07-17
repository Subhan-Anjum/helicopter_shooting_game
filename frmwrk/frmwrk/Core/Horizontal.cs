using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace frmwrk.Core
{
   public class Horizontal : IMovements
    {
        private int speed;
        private Point boundary;
        private string direction;
        private int offset;
        public Horizontal(int speed, Point boundary, string direction)
        {
            this.boundary = boundary;
            this.direction = direction;
            this.speed = speed;
            offset = 100;
        }
        public Horizontal(int speed, Point boundary)
        {
            this.boundary = boundary;
            this.speed = speed;
            offset = 100;
        }

        public Point move(Point Location)
        {
            if (direction == null)
            {

                Location.X -= speed;
            }
            if (direction == "left")
            {
                Location.X -= speed;
            }
            return Location;
        }
        public Point move1(Point location)
        {
            if (direction == "left")
            {
                location.X -= speed;
            }
            //if (direction == "up")
            //{
            //    location.Y -= speed;
            //}
            return location;
        }
        //public Point move1(Point Location)
        //{
        //    if (Location.X <= 0)
        //    {
        //        direction = "right";
        //    }
        //    else if (Location.X + offset >= boundary.X)
        //    {
        //        direction = "left";
        //    }
        //    if (direction == "left")
        //    {
        //        Location.X -= speed;
        //    }
        //    else if (direction == "right")
        //    {
        //        Location.X += speed;
        //    }
        //    return Location;
        //}
    }
}
