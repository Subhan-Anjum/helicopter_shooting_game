using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace frmwrk.Core
{
   public class Vertical : IMovements
    {
        private int speed1;
        private Point boundary1;
        private string direction1;
        private int offset1;

        public Vertical(int speed1, Point boundary1, string direction1)
        {
            this.speed1 = speed1;
            this.boundary1 = boundary1;
            this.direction1 = direction1;
            offset1 = 100;
        }

        public int Speed1 { get => speed1; set => speed1 = value; }
        public Point Boundary1 { get => boundary1; set => boundary1 = value; }
        public string Direction1 { get => direction1; set => direction1 = value; }
        public int Offset1 { get => offset1; set => offset1 = value; }

        public Point move(Point Location)
        {
            if (Location.Y <= 0)
            {
                Direction1 = "bottom";
            }
            else if (Location.Y + Offset1 >= Boundary1.Y)
            {
                Direction1 = "top";
            }
            if (Direction1 == "top")
            {
                Location.Y -= Speed1;
            }
            else if (Direction1 == "bottom")
            {
                Location.Y += Speed1;
            }
            return Location;
        }
    }
}
