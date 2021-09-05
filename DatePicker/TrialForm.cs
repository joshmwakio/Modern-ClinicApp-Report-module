using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatePicker
{
    public partial class TrialForm : Form
    {
        public TrialForm()
        {
            InitializeComponent();
        }

        private void bunifuDatePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TrialForm_Load(object sender, EventArgs e)
        {
            //BunifuDatePicker datePicker = new BunifuDatePicker();
            ////set location for the date picker
            //datePicker.Location = new Point(330, 200);
            ////set the size of the date picker
            //datePicker.Size = new Size(400, 30);
            ////add a border color
            //datePicker.Color = Color.DodgerBlue;
            ////add an icon color
            //datePicker.IconColor = Color.DodgerBlue;
            ////create a curved border edge 
            //datePicker.BorderRadius = 5;
            ////set a thick border
            //datePicker.DateBorderThickness = BunifuDatePicker.BorderThickness.Thick;
            ////add to the control to the form
            //this.Controls.Add(datePicker);
        }

        private void fromDateBunifuDatePicker_ValueChanged(object sender, EventArgs e)
        {
            fromDateBunifuLabel.Text = fromDateBunifuDatePicker.Value.Date.ToString("dd");
            fromMonthYearBunifuLabel.Text = fromDateBunifuDatePicker.Value.ToString("MMMM yyyy");
            toBunifuDatePicker.MinDate = fromDateBunifuDatePicker.Value;
            int selectedDay = fromDateBunifuDatePicker.Value.Date.Day;
            if (selectedDay% 10 == 1 && selectedDay % 100!=11)
            {
                fromDateBunifuLabel.Text = fromDateBunifuLabel.Text+"<sup style='font-size:12px'>st</sup>";
            }
            else if(selectedDay % 10 == 2 && selectedDay % 100 != 12)
            {
                fromDateBunifuLabel.Text = fromDateBunifuLabel.Text + "<sup style='font-size:12px'>nd</sup>";
            }
            else if(selectedDay % 10 == 3 && selectedDay % 100 != 13)
            {
                fromDateBunifuLabel.Text = fromDateBunifuLabel.Text + "<sup style='font-size:12px'>rd</sup>";
            }
            else
            {
                fromDateBunifuLabel.Text = fromDateBunifuLabel.Text + "<sup style='font-size:12px'>th</sup>";
            }
        }

        private void toBunifuDatePicker2_ValueChanged(object sender, EventArgs e)
        {
            toDateBunifuLabel.Text = toBunifuDatePicker.Value.Date.ToString("dd");
            toMonthYearBunifuLabel.Text = toBunifuDatePicker.Value.Date.ToString("MMMM yyyy");
            int selectedDay = toBunifuDatePicker.Value.Date.Day;
            if (selectedDay % 10 == 1 && selectedDay % 100 != 11)
            {
                toDateBunifuLabel.Text = toDateBunifuLabel.Text + "<sup style='font-size:12px'>st</sup>";
            }
            else if (selectedDay % 10 == 2 && selectedDay % 100 != 12)
            {
                toDateBunifuLabel.Text = toDateBunifuLabel.Text + "<sup style='font-size:12px'>nd</sup>";
            }
            else if (selectedDay % 10 == 3 && selectedDay % 100 != 13)
            {
                toDateBunifuLabel.Text = toDateBunifuLabel.Text + "<sup style='font-size:12px'>rd</sup>";
            }
            else
            {
                toDateBunifuLabel.Text = toDateBunifuLabel.Text + "<sup style='font-size:12px'>th</sup>";
            }
        }
    }
}
