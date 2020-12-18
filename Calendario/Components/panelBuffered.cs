using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendario.Components
{
    public partial class panelBuffered : Panel
    {
        public new bool DoubleBuffered
        {
            get { return base.DoubleBuffered; }
            set { base.DoubleBuffered = value; }
        }

        public panelBuffered()
        {
            DoubleBuffered = true;
            InitializeComponent();

        }
    }
}
