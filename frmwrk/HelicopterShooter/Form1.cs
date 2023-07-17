using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frmwrk.Core;
//using EZInput;
namespace HelicopterShooter
{
    public partial class Form1 : Form
    {
        bool gameover=false;
        public static int score = 0;
        int speed = 8;
        PictureBox pb;
        PictureBox pb3;
        PictureBox pb2;
        private Game game;

        PictureBox temp;
        int index = 0;
        Random rand = new Random();
        private PictureBox ufo = new PictureBox();
        
        //int left = 0;
        //int top = 0;
        public Form1()
        {
            InitializeComponent();
            temp = new PictureBox();
            pb = new PictureBox();
            pb3 = new PictureBox();
            pb2 = new PictureBox();
        }
        Point Boundry;

        private void Form1_Load(object sender, EventArgs e)
        {
            //  ufo.Image = Properties.Resources.alien1;
            game = new Game();
            game.onGameObjectAdded += new EventHandler(onGameObjectAdded_Game);
            game.FireEvent += new EventHandler(onGameObjectAdded_fires);
            game.removeenemy += new EventHandler(removeenemyfromform);
            game.OnPlayerDie += new EventHandler(removeplayer);
            Boundry = new Point(Width, Height);
            pb.Image = Properties.Resources.Halicopter;
            temp.Image = Properties.Resources.alien2;
            game.addGameObject(pb.Image, pb, 10, 250, new Keymoves(10, Boundry), ObjectTypes.player);
            makeenemyhorizontal();
            // makeenemyvertical();
            makeenemyhorizontal();
            makeenemyhorizontal();
            CollisionClass c = new CollisionClass(ObjectTypes.Enemy, ObjectTypes.Fire, new PlayerCollision());
            game.addCollision(c);
        } 
        private void removeplayer(object sender,EventArgs e)
        {
            this.Controls.Remove((PictureBox)sender);
        }

        private void removeenemyfromform(object sender, EventArgs e)
        {
            PictureBox temp = (PictureBox)sender;
            this.Controls.Remove(temp);
            makeenemyhorizontal();
            
            
        }
        public void plusscore()
        {
            score += 1;
        }
        //private void MoveRoad()
        //{
        //    DoubleBuffered = true;
        //    BackgroundImageLayout = ImageLayout.Stretch;
        //    if (roadNo == 1)
        //    {
        //        this.BackgroundImage = Properties.Resources.download__1_;
        //        roadNo += 0.25;
        //    }
        //    else if (roadNo == 2)
        //    {
        //        this.BackgroundImage = Properties.Resources.download__1_;
        //        roadNo += 0.25;
        //    }
        //    else if (roadNo == 3)
        //    {
        //        this.BackgroundImage = Properties.Resources.download__1_;
        //        roadNo = .75;
        //    }
        //    roadNo += 0.25;
        //}
        private void makeenemyhorizontal()
        {
            //if (index % 3 == 0)
            //{
            //    temp.Image = Properties.Resources.alien2;
            //}
            //if (index % 3 == 1)
            //{
            //    temp.Image = Properties.Resources.alien3;
            //}
            //if (index % 3 == 2)
            //{
            //    temp.Image = Properties.Resources.alien1;
            //}
            //index++;
            if (index > 3)
            {
                index = 1;
            }
            else
            {
                index += 1;
            }
            switch (index)
            {
                case 1:
                    temp.Image = Properties.Resources.alien1;
                    break;
                case 2:
                    temp.Image = Properties.Resources.alien2;
                    break;
                case 3:
                    temp.Image = Properties.Resources.alien3;
                    break;
            }
            index++;
            temp.Left = 1000;
            game.addGameObject(temp.Image, temp, rand.Next(900,963), rand.Next(20, this.ClientSize.Height - ufo.Height), new Horizontal(2, Boundry), ObjectTypes.Enemy);
        }
        private void makeenemyvertical()
        {
            PictureBox temp1 = new PictureBox();
            temp1.Image = Properties.Resources.alien2;
            game.addGameObject(temp1.Image, temp1, 700, 250, new Vertical(10, Boundry, "top"), ObjectTypes.Enemy);
        }
        private void onGameObjectAdded_Game(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            this.Controls.Add(pb);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            game.KeyPressed(e.KeyCode,Properties.Resources.fire4);
        }
  
        private void TimerforGame_Tick(object sender, EventArgs e)
        {

            game.addGameFire(pb.Image, ObjectTypes.Fire,pb.Left,pb.Top,new Keymoves(10, Boundry ));
           // game.addGameFire2(temp.Image, ObjectTypes.Fire, temp.Left, temp.Top, new Horizontal(10, Boundry, "left"));

            game.update();
            game.updatefires();
          
            txtScore.Text = "Score: " + score;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "pillar")
                {
                    x.Left -= speed;


                    if (x.Left < -200)
                    {
                        x.Left = 1000;
                    }

                    if (pb.Bounds.IntersectsWith(x.Bounds))
                    {

                        if (phealth.Value > 0)
                        {
                            phealth.Value = phealth.Value - 2;
                        }
                        if (phealth.Value < 2)
                        {
                            phealth.Value = 0;
                        }
                    }
                }

                //if (pb.Bounds.IntersectsWith(ufo.Bounds))
                //{
                    
                //    if (phealth.Value > 0)
                //    {
                //        phealth.Value = phealth.Value - 2;
                //    }

                //}
            }
            if (phealth.Value == 0)
            {
                TimerforGame.Stop();
                GameOver();
            }

        }
        private void GameOver()
        {
            gameover = true;
            this.Hide();
            TimerforGame.Stop();
            frmgameover a = new frmgameover();
            a.Show();
            //  txtScore.Text = "Score: " + score + " Game over, press enter to retry!";
            //gameOver = true; 
        }
        public void onGameObjectAdded_fires(object sender, EventArgs e)
        {
            PictureBox temp = (PictureBox)sender;
            this.Controls.Add(temp);
        }

        private void pausepicturebox_Click(object sender, EventArgs e)
        {
            TimerforGame.Stop();
            panelmenu.Visible = true;
            pbhome.Visible = true;
            pbresume.Visible = true;
            lblpause.Visible = true;
            btnrestart.Visible = true;
        }

        private void pbhome_Click(object sender, EventArgs e)
        {
            TimerforGame.Stop();
            this.Hide();
            frmstarting a = new frmstarting();
            a.Show();
        }

        private void pbresume_Click(object sender, EventArgs e)
        {
            TimerforGame.Start();
            pbresume.Visible = false;
            pbhome.Visible = false;
            panelmenu.Visible = false;
            lblpause.Visible = false;
        }

        private void btnrestart_Click(object sender, EventArgs e)
        {
           // RestartGame();
            pbresume.Visible = false;
            pbhome.Visible = false;
            panelmenu.Visible = false;
            lblpause.Visible = false;
        }
    }
}
