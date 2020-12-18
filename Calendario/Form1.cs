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
        private List<FlowLayoutPanel> listDays;
        private List<DateTime> listDates;
        private DateTime today = DateTime.Now, dateTemp;
        private TableLayoutPanel Days, DaysOfWeek;
        public Form1()
        {
            InitializeComponent();
            Days = tlDays;
            DaysOfWeek = tlDaysOfWeek;
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
                var flowLayout = new FlowLayoutPanel();
                flowLayout.Dock = DockStyle.Fill;
                flowLayout.BorderStyle = BorderStyle.FixedSingle;
                flowLayout.Margin = new Padding(2, 2, 2, 2);
                //Event Handler de cada panel de dia
                flowLayout.DoubleClick += (sender, e) => {
                    var index = listDays.FindIndex(d => d == flowLayout);
                    if (index > 0)
                    {
                        today = listDates[index];
                        bringFrontDayView(listDates[index]);
                    }
                };
                flowLayout.Enabled = false;
                tlDays.Controls.Add(flowLayout);
                listDays.Add(flowLayout);
                listDates.Add(DateTime.Now);
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
            for(int i = start; i < totalDays+start; i++)
            {
                var label = new Label();
                label.AutoSize = false;
                label.Text = $"{i - start + 1}";
                label.Width = listDays[i].Width;
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Dock = DockStyle.Top;
                listDays[i].Controls.Add(label);
                listDays[i].Enabled = true;
                listDates[i] = new DateTime(today.Year, today.Month, i - start + 1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel_month.BringToFront();
            listDays = new List<FlowLayoutPanel>();
            listDates = new List<DateTime>();
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

        private void bringFrontDayView(DateTime date)
        {
            MCal1.SetDate(today);
            lblFechaCompleta.Text = date.ToString("dd, MMMM, yyyy");
            panel_day.BringToFront();
            dateTemp = today;
        }

        private void MCal1_DateSelected(object sender, DateRangeEventArgs e)
        {
            dateTemp = MCal1.SelectionStart;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            panel_month.BringToFront();
        }

        private void panelScroll_Scroll(object sender, ScrollEventArgs e)
        {

            
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(Days);
            this.Controls.Remove(DaysOfWeek);

        }


    }
}
