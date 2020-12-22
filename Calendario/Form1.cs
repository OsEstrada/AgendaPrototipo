using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendario
{
    public partial class Form1 : Form
    {
        private List<FlowLayoutCustom> listDays, listHours;
        private List<DateTime> listDates;
        private List<Label> listLabels, listEventsLabels;
        private List<AgendaRegistro> listEvents;
        private List<string> rowHours;
        private DateTime today = DateTime.Now, dateTemp;
        private TableLayoutPanel Days, DaysOfWeek;
        public Form1()
        {
            InitializeComponent();
            Days = tlDays;
            DaysOfWeek = tlDaysOfWeek;
            AuthController.usuario = AuthController.getUser();
        }

        private string upperFirstLetter(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1);
        }

        private void displayCurrentDay()
        {
            today = DateTime.Now;
            lblDate.Text = upperFirstLetter(today.ToString("MMMM, yyyy", new CultureInfo("es-ES")));
        }

        private void displayPrevMonth()
        {
            today = today.AddMonths(-1);
            lblDate.Text = upperFirstLetter(today.ToString("MMMM, yyyy", new CultureInfo("es-ES")));
        }

        private void displayNextMonth()
        {
            today = today.AddMonths(1);
            lblDate.Text = upperFirstLetter(today.ToString("MMMM, yyyy", new CultureInfo("es-ES")));
        }

        private int firstDayOfMonth()
        {
            var firstDay = new DateTime(today.Year, today.Month, 1).DayOfWeek;
            return Convert.ToInt32(firstDay);
            
        }

        private int totalDays()
        {
            var firstDay = new DateTime(today.Year, today.Month, 1).AddMonths(1).AddDays(-1).Day;
            return firstDay;
        }

        private void setControls(int numDays)
        {
            listDays.Clear();
            listDates.Clear();
            tlDays.Controls.Clear();
            for(int i = 0; i<numDays; i++)
            {
                var flowLayout = new FlowLayoutCustom();
                flowLayout.Dock = DockStyle.Fill;
                flowLayout.BorderStyle = BorderStyle.FixedSingle;
                flowLayout.Margin = new Padding(2, 2, 2, 2);
                //Event Handler de cada panel de dia
                flowLayout.DoubleClick += (sender, e) => {
                    var index = listDays.FindIndex(d => d == flowLayout);
                    if (index > 0)
                    {
                        today = listDates[index];
                        var modal = new AgregarEventos(today);
                        modal.ShowDialog();
                        dropCalendarMonthEvents();
                        setCalendarMonthEvents();
                    }
                };
                flowLayout.Enabled = false;
                tlDays.Controls.Add(flowLayout);
                listDays.Add(flowLayout);
                listDates.Add(DateTime.Now);
            }

            for (int i = 0; i < 48; i++)
            {
                var flowLayout = new FlowLayoutCustom();
                flowLayout.Dock = DockStyle.Fill;
                flowLayout.Margin = new Padding(0, 0, 0, 0);
                //Event Handler de cada panel de dia
                flowLayout.DoubleClick += (sender, e) => {
                    var modal = new AgregarEventos(dateTemp);
                    modal.ShowDialog();
                };
                flowLayout.Enabled = true;
                tlHours.Controls.Add(flowLayout);
                listHours.Add(flowLayout);
            }


            setDay(firstDayOfMonth(), totalDays());
        }

        private void clearDayControls()
        {
            for (int i = 0; i < 42; i++)
            {
                listDays[i].Controls.Clear();
                listDays[i].Enabled = false;
            }
        }

        private void setDay(int start, int totalDays)
        {
            listLabels.Clear();
            for(int i = start; i < totalDays+start; i++)
            {
                var label = new Label();
                label.AutoSize = false;
                label.Text = $"{i - start + 1}";
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Dock = DockStyle.Top;
                label.Width = listDays[i].Width;
                label.Tag = 1;

                //var label2 = new Label();
                //label2.AutoSize = false;
                //label2.Text = "PlaceHolder";
                //label2.BackColor = Color.GreenYellow;
                //label2.TextAlign = ContentAlignment.MiddleLeft;
                //label2.Dock = DockStyle.Top;
                //label2.Width = listDays[i].Width-9;
                //label2.Margin = new Padding(5,3,5,0);
                //label2.Tag = 0;
                //var day = listDays[i];
                //label2.DoubleClick += (sender, e) =>
                //{
                //    day.PerformDoubleClick();
                //};

                listLabels.Add(label);
                //listLabels.Add(label2);

                listDays[i].Controls.Add(label);
                //listDays[i].Controls.Add(label2);
                listDays[i].Enabled = true;
                listDates[i] = new DateTime(today.Year, today.Month, i - start + 1);
            }
            setCalendarMonthEvents();
        }

        private void setCalendarMonthEvents()
        {
            listEventsLabels.Clear();
            listEvents.Clear();
            listEvents = AgendaController.ExtraerRegistrosAgendaMensual(AuthController.usuario.usuarioId, today);
            var totalEvents = listEvents.Count();
            for (int i = 0; i < totalEvents; i++)
            {
                var label = new Label();
                label.Text = listEvents[i].registroTitulo;
                label.AutoSize = false;
                label.Font = new Font(label.Font.FontFamily, (float)7.7);
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Width = listDays[0].Width - 9;
                label.BackColor = listEvents[i].tipoRegistro == 1 ? Color.FromArgb(162, 229, 246) : Color.FromArgb(197, 251, 172);
                var index = listDates.FindIndex(d => DateTime.Compare(d, new DateTime(listEvents[i].fechaHoraInicio.Year, listEvents[i].fechaHoraInicio.Month, listEvents[i].fechaHoraInicio.Day)) == 0);
                listDays[index].Controls.Add(label);
                listEventsLabels.Add(label);
            }
        }

        private void fillHoursStringList ()
        {
            var date = DateTime.Now;
            var time = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
            for(int i = 0; i<48; i++)
            {
                rowHours.Add(time.ToString("HH:mm"));
                time = time.AddMinutes(30);
            }
        }

        private void setCalendarDayEvents()
        {
            listEventsLabels.Clear();
            listEvents.Clear();
            listEvents = AgendaController.ExtraerRegistrosAgendaDiaria(AuthController.usuario.usuarioId, dateTemp);
            var totalEvents = listEvents.Count();
            for (int i = 0; i < totalEvents; i++)
            {
                var numByDate = listEvents.Where(e => e.fechaHoraInicio.ToString("HH:mm").Equals(listEvents[i].fechaHoraInicio.ToString("HH:mm"))).Count();
                var label = new Label();
                label.Text = listEvents[i].registroTitulo;
                label.AutoSize = false;
                label.Margin = new Padding(3,0,0,0);
                label.Font = new Font(label.Font.FontFamily, (float)7.7);
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Width = (listHours[0].Width - (8+numByDate))/numByDate;
                label.BackColor = listEvents[i].tipoRegistro == 1 ? Color.FromArgb(162, 229, 246) : Color.FromArgb(197, 251, 172);
                var index = rowHours.FindIndex(h => h == listEvents[i].fechaHoraInicio.ToString("HH:mm"));
                listHours[index].Controls.Add(label);
                listEventsLabels.Add(label);
            }
        }

        private void dropCalendarMonthEvents()
        {
            var totalEvents = listEventsLabels.Count();
            for (int i = 0; i < totalEvents; i++)
            {
                var index = listDates.FindIndex(d => DateTime.Compare(d, new DateTime(listEvents[i].fechaHoraInicio.Year, listEvents[i].fechaHoraInicio.Month, listEvents[i].fechaHoraInicio.Day)) == 0);
                listDays[index].Controls.Remove(listEventsLabels[i]);
            }
        }

        private void dropCalendarDailyEvents()
        {
            var totalEvents = listEventsLabels.Count();
            for (int i = 0; i < totalEvents; i++)
            {
                var index = rowHours.FindIndex(h => h == listEvents[i].fechaHoraInicio.ToString("HH:mm"));
                listHours[index].Controls.Remove(listEventsLabels[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel_month.BringToFront();
            listDays = new List<FlowLayoutCustom>();
            listHours = new List<FlowLayoutCustom>();
            listDates = new List<DateTime>();
            listLabels = new List<Label>();
            rowHours = new List<string>();
            listEventsLabels = new List<Label>();
            listEvents = new List<AgendaRegistro>();
            fillHoursStringList();
            displayCurrentDay();
            setControls(42);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            displayPrevMonth();
            clearDayControls();
            setDay(firstDayOfMonth(), totalDays());
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            displayNextMonth();
            clearDayControls();
            setDay(firstDayOfMonth(), totalDays());
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            displayCurrentDay();
            clearDayControls();
            setDay(firstDayOfMonth(), totalDays());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Controls.Add(Days);
            this.Controls.Add(DaysOfWeek);
            this.Controls.Add(barra_titulo);
        }


        private void MCal1_DateSelected(object sender, DateRangeEventArgs e)
        {
            dateTemp = MCal1.SelectionStart;
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            dropCalendarMonthEvents();
            if (today.Month != DateTime.Now.Month)
                dateTemp = new DateTime(today.Year, today.Month, 1);
            else
                dateTemp = today;
            setCalendarDayEvents();
            MCal1.SetDate(today);
            lblFechaCompleta.Text = dateTemp.ToString("dd, MMMM, yyyy");
            panel_day.BringToFront();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            dropCalendarDailyEvents();
            setCalendarMonthEvents();
            panel_month.BringToFront();
        }

        private void tlDays_Resize(object sender, EventArgs e)
        {
            foreach(Label label in listLabels)
            {
                label.Width = listDays[0].Width;
            }
            foreach(Label label in listEventsLabels)
            {
                label.Width = listDays[0].Width - 9;
                //label.Font = new Font(label.Font.FontFamily, label.Font.Size + 1);
            }
        }
    }
}
