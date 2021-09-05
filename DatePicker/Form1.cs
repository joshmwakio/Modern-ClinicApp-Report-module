using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DatePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void bunifuDatePicker1_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("f");
        }

        private void bunifuDatePicker1_MouseEnter(object sender, EventArgs e)
        {
         
        }

        private void bunifuDatePicker1_ValueChanged(object sender, EventArgs e)
        {
            bunifuDatePicker1.CustomFormat = "dd/MM/yyyy";
           
        }
    }
}
