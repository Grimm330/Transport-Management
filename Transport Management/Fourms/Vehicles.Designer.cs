namespace Transport_Management
{
    partial class Vehicles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehicles));
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.VEtype = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.VName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VLp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.VeGV = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.VStatus = new System.Windows.Forms.ComboBox();
            this.VYear = new System.Windows.Forms.TextBox();
            this.Vmile = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.transportDBDataSet = new Transport_Management.TransportDBDataSet();
            this.bookingTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTBTableAdapter = new Transport_Management.TransportDBDataSetTableAdapters.BookingTBTableAdapter();
            this.bIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vLpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VeGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(26, 438);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 25);
            this.label11.TabIndex = 36;
            this.label11.Text = "Vehicles";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(857, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 23);
            this.label12.TabIndex = 23;
            this.label12.Text = "Vehicle Type";
            // 
            // VEtype
            // 
            this.VEtype.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VEtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VEtype.FormattingEnabled = true;
            this.VEtype.Items.AddRange(new object[] {
            "SUV",
            "Sedan",
            "MPV",
            "Coupe"});
            this.VEtype.Location = new System.Drawing.Point(861, 159);
            this.VEtype.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VEtype.Name = "VEtype";
            this.VEtype.Size = new System.Drawing.Size(197, 33);
            this.VEtype.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(79, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Licence Plate";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(22, 360);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(81, 73);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 37;
            this.pictureBox6.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Rockwell Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(433, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 49);
            this.label6.TabIndex = 10;
            this.label6.Text = "Manage Vehicles";
            // 
            // VName
            // 
            this.VName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VName.Location = new System.Drawing.Point(83, 155);
            this.VName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VName.Name = "VName";
            this.VName.Size = new System.Drawing.Size(228, 32);
            this.VName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 559);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Booking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Customer";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(24, 601);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(80, 80);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 31;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 125);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Drivers";
            // 
            // VLp
            // 
            this.VLp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VLp.Location = new System.Drawing.Point(83, 250);
            this.VLp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VLp.Name = "VLp";
            this.VLp.Size = new System.Drawing.Size(228, 32);
            this.VLp.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 685);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Dashbord";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(22, 242);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(82, 72);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // VeGV
            // 
            this.VeGV.AutoGenerateColumns = false;
            this.VeGV.BackgroundColor = System.Drawing.SystemColors.Info;
            this.VeGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VeGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bIDDataGridViewTextBoxColumn,
            this.cusEmailDataGridViewTextBoxColumn,
            this.vNameDataGridViewTextBoxColumn,
            this.dNameDataGridViewTextBoxColumn,
            this.bAtDataGridViewTextBoxColumn,
            this.pDateDataGridViewTextBoxColumn,
            this.rDateDataGridViewTextBoxColumn,
            this.vLpDataGridViewTextBoxColumn});
            this.VeGV.DataSource = this.bookingTBBindingSource;
            this.VeGV.Location = new System.Drawing.Point(3, 419);
            this.VeGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VeGV.Name = "VeGV";
            this.VeGV.RowHeadersWidth = 51;
            this.VeGV.RowTemplate.Height = 24;
            this.VeGV.Size = new System.Drawing.Size(1156, 381);
            this.VeGV.TabIndex = 31;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(564, 322);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 44);
            this.button4.TabIndex = 30;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Goldenrod;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(398, 322);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 44);
            this.button3.TabIndex = 29;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(243, 322);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 44);
            this.button2.TabIndex = 28;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(326, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 23);
            this.label14.TabIndex = 27;
            this.label14.Text = "Mileage";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.Amount);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.VStatus);
            this.panel1.Controls.Add(this.VYear);
            this.panel1.Controls.Add(this.VeGV);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.Vmile);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.VEtype);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.VLp);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.VName);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(133, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 804);
            this.panel1.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(537, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 23);
            this.label10.TabIndex = 43;
            this.label10.Text = "Amount";
            // 
            // Amount
            // 
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(541, 249);
            this.Amount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(228, 32);
            this.Amount.TabIndex = 42;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkCyan;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(727, 322);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 44);
            this.button5.TabIndex = 41;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(326, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 23);
            this.label9.TabIndex = 40;
            this.label9.Text = "Status";
            // 
            // VStatus
            // 
            this.VStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VStatus.FormattingEnabled = true;
            this.VStatus.Items.AddRange(new object[] {
            "Available",
            "Booked",
            "In-Service"});
            this.VStatus.Location = new System.Drawing.Point(331, 250);
            this.VStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VStatus.Name = "VStatus";
            this.VStatus.Size = new System.Drawing.Size(168, 33);
            this.VStatus.TabIndex = 39;
            // 
            // VYear
            // 
            this.VYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VYear.Location = new System.Drawing.Point(593, 158);
            this.VYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VYear.Name = "VYear";
            this.VYear.Size = new System.Drawing.Size(247, 32);
            this.VYear.TabIndex = 38;
            // 
            // Vmile
            // 
            this.Vmile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vmile.Location = new System.Drawing.Point(331, 158);
            this.Vmile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Vmile.Name = "Vmile";
            this.Vmile.Size = new System.Drawing.Size(241, 32);
            this.Vmile.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(588, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 23);
            this.label13.TabIndex = 25;
            this.label13.Text = "Year";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Brand Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(22, 478);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(81, 77);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 30;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Admin";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 731);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 66);
            this.button1.TabIndex = 24;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // transportDBDataSet
            // 
            this.transportDBDataSet.DataSetName = "TransportDBDataSet";
            this.transportDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingTBBindingSource
            // 
            this.bookingTBBindingSource.DataMember = "BookingTB";
            this.bookingTBBindingSource.DataSource = this.transportDBDataSet;
            // 
            // bookingTBTableAdapter
            // 
            this.bookingTBTableAdapter.ClearBeforeFill = true;
            // 
            // bIDDataGridViewTextBoxColumn
            // 
            this.bIDDataGridViewTextBoxColumn.DataPropertyName = "BID";
            this.bIDDataGridViewTextBoxColumn.HeaderText = "BID";
            this.bIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bIDDataGridViewTextBoxColumn.Name = "bIDDataGridViewTextBoxColumn";
            this.bIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // cusEmailDataGridViewTextBoxColumn
            // 
            this.cusEmailDataGridViewTextBoxColumn.DataPropertyName = "CusEmail";
            this.cusEmailDataGridViewTextBoxColumn.HeaderText = "CusEmail";
            this.cusEmailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cusEmailDataGridViewTextBoxColumn.Name = "cusEmailDataGridViewTextBoxColumn";
            this.cusEmailDataGridViewTextBoxColumn.Width = 150;
            // 
            // vNameDataGridViewTextBoxColumn
            // 
            this.vNameDataGridViewTextBoxColumn.DataPropertyName = "VName";
            this.vNameDataGridViewTextBoxColumn.HeaderText = "VName";
            this.vNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vNameDataGridViewTextBoxColumn.Name = "vNameDataGridViewTextBoxColumn";
            this.vNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // dNameDataGridViewTextBoxColumn
            // 
            this.dNameDataGridViewTextBoxColumn.DataPropertyName = "DName";
            this.dNameDataGridViewTextBoxColumn.HeaderText = "DName";
            this.dNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dNameDataGridViewTextBoxColumn.Name = "dNameDataGridViewTextBoxColumn";
            this.dNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // bAtDataGridViewTextBoxColumn
            // 
            this.bAtDataGridViewTextBoxColumn.DataPropertyName = "BAt";
            this.bAtDataGridViewTextBoxColumn.HeaderText = "BAt";
            this.bAtDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bAtDataGridViewTextBoxColumn.Name = "bAtDataGridViewTextBoxColumn";
            this.bAtDataGridViewTextBoxColumn.Width = 150;
            // 
            // pDateDataGridViewTextBoxColumn
            // 
            this.pDateDataGridViewTextBoxColumn.DataPropertyName = "PDate";
            this.pDateDataGridViewTextBoxColumn.HeaderText = "PDate";
            this.pDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pDateDataGridViewTextBoxColumn.Name = "pDateDataGridViewTextBoxColumn";
            this.pDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // rDateDataGridViewTextBoxColumn
            // 
            this.rDateDataGridViewTextBoxColumn.DataPropertyName = "RDate";
            this.rDateDataGridViewTextBoxColumn.HeaderText = "RDate";
            this.rDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rDateDataGridViewTextBoxColumn.Name = "rDateDataGridViewTextBoxColumn";
            this.rDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // vLpDataGridViewTextBoxColumn
            // 
            this.vLpDataGridViewTextBoxColumn.DataPropertyName = "VLp";
            this.vLpDataGridViewTextBoxColumn.HeaderText = "VLp";
            this.vLpDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vLpDataGridViewTextBoxColumn.Name = "vLpDataGridViewTextBoxColumn";
            this.vLpDataGridViewTextBoxColumn.Width = 150;
            // 
            // Vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 831);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Vehicles";
            this.Text = "Vehicles";
            this.Load += new System.EventHandler(this.Vehicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VeGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox VEtype;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox VName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VLp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView VeGV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Vmile;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox VYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox VStatus;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Amount;
        private TransportDBDataSet transportDBDataSet;
        private System.Windows.Forms.BindingSource bookingTBBindingSource;
        private TransportDBDataSetTableAdapters.BookingTBTableAdapter bookingTBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vLpDataGridViewTextBoxColumn;
    }
}