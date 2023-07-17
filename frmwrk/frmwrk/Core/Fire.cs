using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace frmwrk.Core
{
   public class Fire
    {
        private PictureBox firing;
        private IMovements fMovements;
        private ObjectTypes A1;

        public PictureBox Firing { get => firing; set => firing = value; }
        public IMovements FMovements { get => fMovements; set => fMovements = value; }
        public ObjectTypes A11 { get => A1; set => A1 = value; }
        public Fire(Image firepic, ObjectTypes A1, int left, int top, IMovements fMovements)
        {
            firing = new PictureBox();
            firing.BackColor = Color.Transparent;
            firing.BackgroundImage = firepic;
            firing.BackgroundImageLayout = ImageLayout.Stretch;
            firing.Height = 12;
            firing.Width = 12;
            firing.Top = top;
            firing.Left = left;
            this.FMovements = FMovements;
            this.A11 = A1;
        }
     
        public void move()
        {
            Firing.Left = Firing.Left + 40;
        }

    }
}
