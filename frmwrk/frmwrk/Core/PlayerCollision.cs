using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace frmwrk.Core
{
   public class PlayerCollision : ICollisionAction
    {
       public void performAction(IGame game, GameObject source1, Fire source2)
        {
            GameObject player;
            if (source1.Otype1 == ObjectTypes.Enemy)
            {
                player = source1;
                game.RaisePlayerDieEvent(player.Pic);
            }

        }
    }
}
