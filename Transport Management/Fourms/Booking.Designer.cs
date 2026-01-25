namespace Transport_Management
{
    partial class Booking
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CusBook = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Rdate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.Pdate = new System.Windows.Forms.DateTimePicker();
            this.VeDriver = new System.Windows.Forms.ComboBox();
            this.VeBook = new System.Windows.Forms.ComboBox();
            this.vehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BGV = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(395, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 20);
            this.label15.TabIndex = 35;
            this.label15.Text = "Driver";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.CusBook);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Rdate);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.Pdate);
            this.panel1.Controls.Add(this.VeDriver);
            this.panel1.Controls.Add(this.VeBook);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.BGV);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 666);
            this.panel1.TabIndex = 39;
            // 
            // CusBook
            // 
            this.CusBook.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CusBook.FormattingEnabled = true;
            this.CusBook.Location = new System.Drawing.Point(34, 128);
            this.CusBook.Name = "CusBook";
            this.CusBook.Size = new System.Drawing.Size(161, 28);
            this.CusBook.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(783, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "Return Date";
            // 
            // Rdate
            // 
            this.Rdate.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdate.Location = new System.Drawing.Point(787, 126);
            this.Rdate.Name = "Rdate";
            this.Rdate.Size = new System.Drawing.Size(210, 27);
            this.Rdate.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(555, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 20);
            this.label10.TabIndex = 46;
            this.label10.Text = "Pickup Date";
            // 
            // Pdate
            // 
            this.Pdate.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pdate.Location = new System.Drawing.Point(559, 126);
            this.Pdate.Name = "Pdate";
            this.Pdate.Size = new System.Drawing.Size(210, 27);
            this.Pdate.TabIndex = 45;
            // 
            // VeDriver
            // 
            this.VeDriver.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VeDriver.FormattingEnabled = true;
            this.VeDriver.Location = new System.Drawing.Point(399, 128);
            this.VeDriver.Name = "VeDriver";
            this.VeDriver.Size = new System.Drawing.Size(134, 28);
            this.VeDriver.TabIndex = 44;
            // 
            // VeBook
            // 
            this.VeBook.DataSource = this.vehiclesBindingSource;
            this.VeBook.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VeBook.FormattingEnabled = true;
            this.VeBook.Location = new System.Drawing.Point(230, 128);
            this.VeBook.Name = "VeBook";
            this.VeBook.Size = new System.Drawing.Size(134, 28);
            this.VeBook.TabIndex = 43;
            // 
            // vehiclesBindingSource
            // 
            this.vehiclesBindingSource.DataSource = typeof(Transport_Management.Vehicles);
            // 
            // BGV
            // 
            this.BGV.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.BGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BGV.Location = new System.Drawing.Point(11, 270);
            this.BGV.Name = "BGV";
            this.BGV.RowHeadersWidth = 51;
            this.BGV.RowTemplate.Height = 24;
            this.BGV.Size = new System.Drawing.Size(1031, 384);
            this.BGV.TabIndex = 31;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(612, 212);
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
            this.button3.Location = new System.Drawing.Point(469, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 35);
            this.button3.TabIndex = 29;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(334, 212);
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
            this.label14.Location = new System.Drawing.Point(226, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "Vehicles";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Customer ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Rockwell Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(415, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 41);
            this.label6.TabIndex = 10;
            this.label6.Text = "Manage Booking";
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 666);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Booking";
            this.Text = "Booking";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView BGV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox VeDriver;
        private System.Windows.Forms.ComboBox VeBook;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker Rdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker Pdate;
        private System.Windows.Forms.ComboBox CusBook;
        private System.Windows.Forms.BindingSource vehiclesBindingSource;
    }
}