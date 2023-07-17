using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace frmwrk.Core
{
    public class GameObject
    {
        //private PictureBox pb;
        //private IMovements movement;
        //private ObjectTypes oType;
        //public GameObject(Image img,PictureBox pb,int left,int top, IMovements movement , ObjectTypes oType)
        //{
        //    Pb1 = new PictureBox();
        //    Pb1.BackgroundImage = img;
        //    Pb1 = Pb;
        //    Pb1.BackColor = Color.Transparent;
        //    Pb1.BackgroundImageLayout = ImageLayout.Stretch;
        //    Pb1.Left = left;
        //    Pb1.Top = top;
        //    pb.Left = Pb1.Left;
        //    pb.Top = Pb1.Top;
        //    this.Movement = movement;
        //}

        //public PictureBox Pb { get => Pb1; set => Pb1 = value; }
        //public IMovements Movement { get => Movement1; set => Movement1 = value; }
        //public PictureBox Pb1 { get => pb; set => pb = value; }
        //public IMovements Movement1 { get => movement; set => movement = value; }
        //public ObjectTypes OType { get => oType; set => oType = value; }

        //public void GameObjectmove()
        //{
        //    Pb1.Location=Movement.move(Pb1.Location);
        //}
        //public void move()
        //{
        //    this.Pb.Location = Movement.move(this.Pb1.Location);
        //}
        private PictureBox pic;
        private IMovements movement;
        private ObjectTypes Otype;
        public GameObject(Image image, PictureBox player, ObjectTypes otype, int left, int top, IMovements movement)
        {
            pic = new PictureBox();
            pic = player;
            pic.Image = image;
            pic.Height = image.Height;
            pic.Width = image.Width;
            pic.BackColor = Color.Transparent;
            //int lefts=pic.Top+(pic.Height/2-)
            pic.Top = top;
            pic.Left = left;
            player.Top = pic.Top;
            player.Left = pic.Left;
            this.Movement = movement;
            this.Otype1 = otype;
        }
        public GameObject(Image img, int left, int top, IMovements movement, ObjectTypes oType)
        {
            Pic = new PictureBox();
            Pic.BackgroundImage = img;
            Pic.BackColor = Color.Transparent;
            Pic.BackgroundImageLayout = ImageLayout.Stretch;
            Pic.Left = left;
            Pic.Top = top;
            this.Movement = movement;
            this.Otype1 = oType;
        }

        internal PictureBox Pic { get => pic; set => pic = value; }
        public IMovements Movement { get => movement; set => movement = value; }
        public ObjectTypes Otype1 { get => Otype; set => Otype = value; }

        public void move()
        {
            this.pic.Location = Movement.move(this.pic.Location);
            
        }
    }
}
