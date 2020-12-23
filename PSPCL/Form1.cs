using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSPCL
{
    public partial class PSPCL : Form
    {
        // AFTER 4 APRIL 1908
        string[] shiftaOn4April2020 = { "M1", "M2", "M3", "M4", "M5", "Rest", "N1", "N2", "N3", "N4", "N5", "Rest", "General", "E1", "E2", "E3", "E4", "E5", "Rest", "General" };
       
        public PSPCL()
        {
            InitializeComponent();
            DateTime initialdate = new DateTime(1900, 01, 01);
            TimeSpan days = dateTimePicker1.Value - initialdate;
            determineShifts(days.Days.ToString());

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime initialdate = new DateTime(1900, 01, 01);
            TimeSpan days = dateTimePicker1.Value - initialdate;
            determineShifts(days.Days.ToString());
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void info_button_Click(object sender, EventArgs e)
        {
            string message = "Made by: Gurkirat Singh Khaira\nContact: 777gurkirat@gmail.com";
            string title = "Info";
            MessageBox.Show(message, title);
        }

        public void setValues(string a, string b, string c, string d)
        {
            ashift.Text = a;
            bshift.Text = b;
            cshift.Text = c;
            dshift.Text = d;
        }

        public void determineShifts(string days)
        {
            Int32 total = Int32.Parse(days);
            if (total < 0)
            {
                total *= -1;
            }
            int index = total % 20;
            setValues(shiftaOn4April2020[index % 20], shiftaOn4April2020[(index + 15) % 20], shiftaOn4April2020[(index + 10) % 20], shiftaOn4April2020[(index + 5) % 20]);
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(-1);
        }
    }
}
