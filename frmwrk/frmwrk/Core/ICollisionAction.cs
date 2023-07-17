using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmwrk.Core
{
   public  interface ICollisionAction
    {
        void performAction(IGame game, GameObject source1, Fire source2);
    }
}
