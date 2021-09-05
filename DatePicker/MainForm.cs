using Bunifu.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatePicker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
    
        private void Form2_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();

            bunifuDataGridView1.DataSource = medilDataSetBindingSource;
         
            bunifuDatePickerFromDate.MinDate = DateTime.Parse("29/05/2021");
            this.DoubleBuffered = true;
            Bunifu.Utils.ScrollbarBinder.BindDatagridView(bunifuDataGridView1, bunifuVScrollBar1);
        }
        public void modifyColumns()
        {
            bunifuDataGridView1.Columns[0].HeaderText = "";
            bunifuDataGridView1.Columns[2].HeaderText = "Date Of Creation";
            bunifuDataGridView1.Columns[2].FillWeight = 150;
            bunifuDataGridView1.Columns[4].FillWeight = 150;
            bunifuDataGridView1.Columns[6].FillWeight = 50;
            bunifuDataGridView1.Columns[7].FillWeight = 50;
            bunifuDataGridView1.Columns[8].FillWeight = 50;
            bunifuDataGridView1.Columns[9].FillWeight = 50;
            bunifuDataGridView1.Columns[6].HeaderText = "";
            bunifuDataGridView1.Columns[7].HeaderText = "";
            bunifuDataGridView1.Columns[8].HeaderText = "";
            bunifuDataGridView1.Columns[9].HeaderText = "";
            bunifuDataGridView1.Columns[1].HeaderText = "Report ID";
            bunifuDataGridView1.Columns[3].HeaderText = "Patient ID";
            bunifuDataGridView1.Columns[4].HeaderText = "Patient Name";
        }
       
        public void LoadToBindingList()
        {
            BindingList<ReportSum> reportSums = new BindingList<ReportSum>();
            foreach (var md in medilDataSet.Reports)
            {
                reportSums.Add(new ReportSum()
                {
                    ChekmarkImage = imageListCheckbox.Images[0],
                    ReportID = md.Id,
                    Date_of_Creation = md.Date_of_Creation.Date,
                    Patient_ID = md.Patient_Id,
                    Patient_Name = md.Patient_Name,
                    Age = md.Age,
                    InfoImage = imageListActionItems.Images[0],
                    ChatImage = imageListActionItems.Images[1],
                    EmailImage = imageListActionItems.Images[2],
                    DeleteImage = imageListActionItems.Images[3]

                });
            }

            medilDataSetBindingSource.DataSource = reportSums;
            
        }
        DateTime maxQueryParameter;
        DateTime minQueryParameter;
        private async void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            while (true)
            {
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                  //  reportsTableAdapter1.FillByPatient(medilDataSet.Reports, queryParameter);
                    if (bunifuDataGridView1.InvokeRequired)
                    {
                        bunifuDataGridView1.Invoke(new Action(() =>
                        {
                            var bindingSource = (BindingSource)bunifuDataGridView1.DataSource;
                           
                            BindingList<ReportSum> listreport = (BindingList<ReportSum>)bindingSource.DataSource;
                           
                            var list = listreport.Where(r =>(r.Date_of_Creation>=minQueryParameter && 
                            r.Date_of_Creation<=maxQueryParameter));
                            medilDataSetBindingSource.DataSource = list;
                        }));
                    }
                    break;
                }
                else
                {
                    await Task.Delay(2000);
                   
                    medilDataSet.Reports.Clear();

                    reportsTableAdapter1.Fill(medilDataSet.Reports);

                    if (bunifuDataGridView1.InvokeRequired)
                    {
                        bunifuDataGridView1.Invoke(new Action(() =>
                        {
                            LoadToBindingList();
                            modifyColumns();
                            pictureBox13.Visible = false;
                            bunifuDataGridView1.FirstDisplayedScrollingRowIndex = bunifuVScrollBar1.Value;
                        }));
                    }
                }
            }

        }

        private void bunifuDataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Console.WriteLine(e.Exception.Message);
        }

        private void bunifuDatePickerFromDate_ValueChanged(object sender, EventArgs e)
        {
            bunifuDatePickerToDate.MinDate = bunifuDatePickerFromDate.Value;
        }

        private void bunifuDatePickerToDate_ValueChanged(object sender, EventArgs e)
        {
            minQueryParameter = bunifuDatePickerFromDate.Value;
            maxQueryParameter = bunifuDatePickerToDate.Value;
            backgroundWorker1.CancelAsync();
            bunifuButton1.Visible = true;
            bunifuTransition1.ShowSync(bunifuButton1, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Scale);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            pictureBox13.Visible = true;
            bunifuTransition1.HideSync(bunifuButton1, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Particles);
        }
    }
}
