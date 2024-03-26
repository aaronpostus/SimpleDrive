using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDriveApp
{
    // This class would be an interface, but Windows Forms doesn't allow for that
    public class View : UserControl
    {
        public virtual void SwitchToView() { }
    }
}
