using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendario
{
    public class customLabel : Label
    {
        public bool name  
        {
            get { return name; }   
            set { name = value; }  
        }
        public customLabel()
        {
        }
    }
}
