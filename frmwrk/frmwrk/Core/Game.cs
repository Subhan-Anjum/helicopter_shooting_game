using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using EZInput;

namespace frmwrk.Core
{
   public class Game:IGame
    {
        private List<Fire> fires;
        public event EventHandler FireEvent;
        private List<GameObject> objects;
        public event EventHandler onGameObjectAdded;
        public event EventHandler removeenemy;
        public event EventHandler removefire;
        public event EventHandler collisionmoment;
        private List<CollisionClass> collisionss;
        public event EventHandler OnPlayerDie;
        //int score = 0;

        public List<Fire> Fires { get => fires; set => fires = value; }

        public Game()
        {
            objects = new List<GameObject>();
            Fires = new List<Fire>();
            collisionss = new List<CollisionClass>();
        }
        //public void addGameObject(Image image, int left, int top, IMovements movement)
        //{
        //    GameObject temp = new GameObject(image, left, top, movement);
        //    objects.Add(temp);
        //    onGameObjectAdded?.Invoke(temp.Pb, EventArgs.Empty);
        //}
        public void addGameObject(Image image,PictureBox pb, int left, int top, IMovements movement,ObjectTypes otype)
        {
            GameObject ob = new GameObject(image, pb, otype, left, top, movement);
            objects.Add(ob);
            onGameObjectAdded?.Invoke(ob.Pic, EventArgs.Empty);
        }
        public void addGameFire(Image img, ObjectTypes otype, int left, int top, IMovements movement)
        {
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                
                Fire a = new Fire(img, otype, left, top, movement);
                Fires.Add(a);
                FireEvent?.Invoke(a.Firing, EventArgs.Empty);
            }
        }
        public void addGameFire2(Image img, ObjectTypes otype, int left, int top, IMovements movement)
        {
                Fire a = new Fire(img, otype, left, top, movement);
                Fires.Add(a);
                FireEvent?.Invoke(a.Firing, EventArgs.Empty);
            
        }
        public void moveenemy()
        {
            foreach(GameObject M in objects)
            {
                if (M.Otype1 == ObjectTypes.Enemy)
                {
                    if (M.Pic.Left > 600)
                    {
                        M.Pic.Left = M.Pic.Left - 5;
                    }
                }
            }
        }


        public void update()
        {
            detectCollision();
            for (int go = 0; go < objects.Count; go++)
            {
                objects[go].move();
                if(objects[go].Pic.Left <= 0)
                {
                    removeenemy?.Invoke(objects[go].Pic, EventArgs.Empty);
                    objects.Remove(objects[go]);
                }
                
            }
        }
        public void addCollision(CollisionClass c)
        {
          //  collisionss = new List<CollisionClass>();
            collisionss.Add(c);
        }
        //public void KeyPressed(Keys keycode)
        //{
        //    foreach (GameObject s in objects)
        //    {
        //        if (s.Movement.GetType() == typeof(Keymoves))
        //        {
        //            Keymoves keyboardHandle = (Keymoves)s.Movement;
        //            keyboardHandle.movingkeysforuser(keycode);
        //        }

        //    }
        //}
        public void updatefires()
        {
            foreach (Fire M in Fires)
            {
                M.Firing.Left = M.Firing.Left + 20;
            }
        }
        public void RaisePlayerDieEvent(PictureBox playerGameObject)
        {
            OnPlayerDie?.Invoke(playerGameObject, EventArgs.Empty);

        }
        public void detectCollision()
        {
            for (int x = 0; x < objects.Count; x++)
            {
                for (int y = 0; y < fires.Count; y++)
                {
                    if (objects[x].Pic.Bounds.IntersectsWith(fires[y].Firing.Bounds))
                    {
                        foreach (CollisionClass c in collisionss)
                        {
                            if (objects[x].Otype1 == c.G1 && fires[y].A11 == c.G2)
                            {
                                c.Behaviour.performAction(this, objects[x], fires[y]);
                                
                               
                              
                            }
                        }
                    }
                }
            }
        }
        
        //public void detectCollision()
        //{
        //    for (int x = 0; x < Fires.Count; x++)
        //    {
        //        for (int y = 0; y < objects.Count; y++)
        //        {
        //            if (Fires[x].Firing.Bounds.IntersectsWith(objects[y].Pic.Bounds))
        //            {
        //                foreach (CollisionClass c in collisionss)
        //                {
        //                    if (objects[y].Otype1 == c.G1 && Fires[x].A11 == c.G2)
        //                    {
        //                        c.Behaviour.performAction(this, objects[y],Fires[x]);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        public void KeyPressed(Keys keycode, Image img)
        {
            foreach (GameObject s in objects)
            {
                if (s.Movement.GetType() == typeof(Keymoves))
                {
                    Keymoves keyboardHandle = (Keymoves)s.Movement;
                    keyboardHandle.movingkeysforuser(keycode, img);
                }
            }

        }

    }
}
