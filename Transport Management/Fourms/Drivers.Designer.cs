namespace Transport_Management
{
    partial class Drivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drivers));
            this.label15 = new System.Windows.Forms.Label();
            this.Dphone = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.DWage = new System.Windows.Forms.TextBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.Dname = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DGen = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DLic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DEmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Ddate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(450, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 20);
            this.label15.TabIndex = 35;
            this.label15.Text = "Phone";
            // 
            // Dphone
            // 
            this.Dphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dphone.Location = new System.Drawing.Point(454, 126);
            this.Dphone.Name = "Dphone";
            this.Dphone.Size = new System.Drawing.Size(169, 28);
            this.Dphone.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(523, 175);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 20);
            this.label16.TabIndex = 33;
            this.label16.Text = "Wage";
            // 
            // DWage
            // 
            this.DWage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DWage.Location = new System.Drawing.Point(527, 198);
            this.DWage.Name = "DWage";
            this.DWage.Size = new System.Drawing.Size(220, 28);
            this.DWage.TabIndex = 32;
            // 
            // DGV
            // 
            this.DGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(24, 326);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(1004, 314);
            this.DGV.TabIndex = 31;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(533, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 35);
            this.button4.TabIndex = 30;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Goldenrod;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(366, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 35);
            this.button3.TabIndex = 29;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(213, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 35);
            this.button2.TabIndex = 28;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(258, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "Full Name";
            // 
            // Dname
            // 
            this.Dname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dname.Location = new System.Drawing.Point(262, 126);
            this.Dname.Name = "Dname";
            this.Dname.Size = new System.Drawing.Size(169, 28);
            this.Dname.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(649, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Gender";
            // 
            // DGen
            // 
            this.DGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGen.FormattingEnabled = true;
            this.DGen.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.DGen.Location = new System.Drawing.Point(653, 126);
            this.DGen.Name = "DGen";
            this.DGen.Size = new System.Drawing.Size(150, 28);
            this.DGen.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(822, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Status";
            // 
            // DStatus
            // 
            this.DStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DStatus.FormattingEnabled = true;
            this.DStatus.Items.AddRange(new object[] {
            "Available",
            "In-Trip",
            "In-Leave"});
            this.DStatus.Location = new System.Drawing.Point(826, 128);
            this.DStatus.Name = "DStatus";
            this.DStatus.Size = new System.Drawing.Size(150, 28);
            this.DStatus.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(290, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Address";
            // 
            // DAddress
            // 
            this.DAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DAddress.Location = new System.Drawing.Point(294, 198);
            this.DAddress.Name = "DAddress";
            this.DAddress.Size = new System.Drawing.Size(215, 28);
            this.DAddress.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Licence Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "E-Mail";
            // 
            // DLic
            // 
            this.DLic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DLic.Location = new System.Drawing.Point(74, 200);
            this.DLic.Name = "DLic";
            this.DLic.Size = new System.Drawing.Size(203, 28);
            this.DLic.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Rockwell Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(385, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 41);
            this.label6.TabIndex = 10;
            this.label6.Text = "Manage Drivers";
            // 
            // DEmail
            // 
            this.DEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEmail.Location = new System.Drawing.Point(74, 126);
            this.DEmail.Name = "DEmail";
            this.DEmail.Size = new System.Drawing.Size(167, 28);
            this.DEmail.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.Ddate);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.Dphone);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.DWage);
            this.panel1.Controls.Add(this.DGV);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.Dname);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.DGen);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.DStatus);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.DAddress);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.DLic);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.DEmail);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 663);
            this.panel1.TabIndex = 11;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkCyan;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(713, 258);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 35);
            this.button5.TabIndex = 42;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(771, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "Join Date";
            // 
            // Ddate
            // 
            this.Ddate.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ddate.Location = new System.Drawing.Point(766, 198);
            this.Ddate.Name = "Ddate";
            this.Ddate.Size = new System.Drawing.Size(210, 27);
            this.Ddate.TabIndex = 36;
            // 
            // Drivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 666);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Drivers";
            this.Text = "Drivers";
            this.Load += new System.EventHandler(this.Drivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Dphone;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox DWage;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Dname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox DGen;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox DStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DLic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker Ddate;
        private System.Windows.Forms.Button button5;
    }
}