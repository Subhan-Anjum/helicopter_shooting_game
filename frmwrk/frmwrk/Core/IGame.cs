using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace frmwrk.Core
{
   public interface IGame
    {
        void RaisePlayerDieEvent(PictureBox pb);

    }
}
