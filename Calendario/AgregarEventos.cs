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
    public partial class AgregarEventos : Form
    {
        private DateTime day;
        public AgregarEventos(DateTime today)
        {
            InitializeComponent();
            this.CenterToScreen();
            pickerRecordatorio.Value = today;
            pickerTarea.Value = today;
            day = today;
            cmbHoraRecordatorio.SelectedIndex = 0;
            cmbHoraTarea.SelectedIndex = 0;
        }
        public AgregarEventos(DateTime today, int hour)
        {
            InitializeComponent();
            pickerRecordatorio.Value = today;
            pickerTarea.Value = today;
            day = today;
            cmbHoraRecordatorio.SelectedIndex = hour;
            cmbHoraTarea.SelectedIndex = hour;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtRecordatorio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarRecordatorio_Click(object sender, EventArgs e)
        {
            var recordatorio = new AgendaRegistro();
            var fecha = pickerRecordatorio.Value;
            var subs = cmbHoraRecordatorio.Text.Split(':');
            recordatorio.idUsuario = AuthController.usuario.usuarioId;
            recordatorio.idEmpresa = AuthController.usuario.empresaId;
            recordatorio.registroTitulo = String.IsNullOrEmpty(txtRecordatorio.Text)? "Sin titulo" : txtRecordatorio.Text;
            recordatorio.tipoRegistro = 1; //1 = recordatorio, 2 = tarea
            recordatorio.fechaHoraInicio = new DateTime(fecha.Year, fecha.Month, fecha.Day, Convert.ToInt32(subs[0]), Convert.ToInt32(subs[1]), 0);
            AgendaController.GuardarRegistroAgenda(recordatorio);
            Dispose();
        }

        private void btnGuardarTarea_Click(object sender, EventArgs e)
        {
            var tarea = new AgendaRegistro();
            var fecha = pickerTarea.Value;
            var subs = cmbHoraTarea.Text.Split(':');
            tarea.idUsuario = AuthController.usuario.usuarioId;
            tarea.idEmpresa = AuthController.usuario.empresaId;
            tarea.registroTitulo = String.IsNullOrEmpty(txtTarea.Text)? "Sin titulo" : txtTarea.Text;
            tarea.fechaHoraInicio = new DateTime(fecha.Year, fecha.Month, fecha.Day, Convert.ToInt32(subs[0]), Convert.ToInt32(subs[1]), 0);
            tarea.tipoRegistro = 2;
            tarea.registroDetalles = String.IsNullOrEmpty(txtDescripcionTarea.Text) ? "Sin descripcion" : txtDescripcionTarea.Text;
            AgendaController.GuardarRegistroAgenda(tarea);
            Dispose();
        }
    }
}
