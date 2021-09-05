
namespace DatePicker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bunifuDatePicker1 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy ";
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(198, 267);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(499, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2021, 7, 17, 0, 0, 0, 0);
            // 
            // bunifuDatePicker1
            // 
            this.bunifuDatePicker1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDatePicker1.BorderRadius = 2;
            this.bunifuDatePicker1.CalendarFont = new System.Drawing.Font("Agenda", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDatePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bunifuDatePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bunifuDatePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bunifuDatePicker1.CalendarTrailingForeColor = System.Drawing.Color.Silver;
            this.bunifuDatePicker1.Color = System.Drawing.SystemColors.Highlight;
            this.bunifuDatePicker1.CustomFormat = "\'Choose date\'";
            this.bunifuDatePicker1.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.bunifuDatePicker1.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Center;
            this.bunifuDatePicker1.DisabledColor = System.Drawing.SystemColors.HighlightText;
            this.bunifuDatePicker1.DisplayWeekNumbers = true;
            this.bunifuDatePicker1.DPHeight = 0;
            this.bunifuDatePicker1.FillDatePicker = false;
            this.bunifuDatePicker1.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDatePicker1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.bunifuDatePicker1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuDatePicker1.Icon")));
            this.bunifuDatePicker1.IconColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuDatePicker1.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.None;
            this.bunifuDatePicker1.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.bunifuDatePicker1.LeftTextMargin = 0;
            this.bunifuDatePicker1.Location = new System.Drawing.Point(198, 175);
            this.bunifuDatePicker1.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.bunifuDatePicker1.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.bunifuDatePicker1.MinimumSize = new System.Drawing.Size(4, 32);
            this.bunifuDatePicker1.Name = "bunifuDatePicker1";
            this.bunifuDatePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuDatePicker1.Size = new System.Drawing.Size(452, 33);
            this.bunifuDatePicker1.TabIndex = 0;
            this.bunifuDatePicker1.Value = new System.DateTime(2021, 8, 1, 11, 16, 0, 0);
            this.bunifuDatePicker1.ValueChanged += new System.EventHandler(this.bunifuDatePicker1_ValueChanged);
            this.bunifuDatePicker1.MouseEnter += new System.EventHandler(this.bunifuDatePicker1_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bunifuDatePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDatePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

