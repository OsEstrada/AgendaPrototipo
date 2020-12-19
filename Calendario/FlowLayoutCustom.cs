using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendario
{
    public class FlowLayoutCustom : FlowLayoutPanel
    {
        public void PerformDoubleClick()
        {
            OnDoubleClick(new EventArgs());//InvokeOnClick(this,new EventArgs());
        }
    }
}
