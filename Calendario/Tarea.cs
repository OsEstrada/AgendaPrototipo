using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendario
{
    public partial class Tarea : Form
    {
        private AgendaRegistro reg;
        private List<string> rowHours;
        public Tarea(AgendaRegistro registro)
        {
            InitializeComponent();
            this.CenterToScreen();
            rowHours = new List<string>();
            fillHoursStringList();
            reg = registro;
            txtTitulo.Text = registro.registroTitulo;
            txtDetalles.Text = registro.registroDetalles;
            pickerTarea.Value = registro.fechaHoraInicio;
            var index = rowHours.FindIndex(h => h == reg.fechaHoraInicio.ToString("HH:mm"));
            cmbHoraTarea.SelectedIndex = index;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AgendaController.EliminarRegistro(reg.idRegistro);
            Dispose();
        }

        private void fillHoursStringList()
        {
            var date = DateTime.Now;
            var time = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
            for (int i = 0; i < 48; i++)
            {
                rowHours.Add(time.ToString("HH:mm"));
                time = time.AddMinutes(30);
            }
        }

        private void Tarea_Load(object sender, EventArgs e)
        {
           
        }
    }
}
