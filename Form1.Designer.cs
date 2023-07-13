namespace System_APP
{
    partial class mainScreen
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
            this.dTimeSts = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Download = new System.Windows.Forms.Button();
            this.arduinoPort = new System.IO.Ports.SerialPort(this.components);
            this.siticoneGradientPanel2 = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.siticoneControlBox3 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneGroupBox1 = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeSerial = new Siticone.Desktop.UI.WinForms.SiticoneRadioButton();
            this.siticoneButton3 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.openSerial = new Siticone.Desktop.UI.WinForms.SiticoneRadioButton();
            this.siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lbl_SOI = new System.Windows.Forms.Label();
            this.comboPorts = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.lbl_HUM = new System.Windows.Forms.Label();
            this.lbl_TEMP = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.siticoneGradientPanel2.SuspendLayout();
            this.siticoneGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dTimeSts
            // 
            this.dTimeSts.Location = new System.Drawing.Point(0, 15);
            this.dTimeSts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dTimeSts.Name = "dTimeSts";
            this.dTimeSts.Size = new System.Drawing.Size(320, 22);
            this.dTimeSts.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(376, 106);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(593, 313);
            this.dataGridView1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "FIRE DETECTOR SYSTEM";
            // 
            // Download
            // 
            this.Download.BackColor = System.Drawing.Color.Purple;
            this.Download.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Download.Location = new System.Drawing.Point(772, 58);
            this.Download.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(196, 41);
            this.Download.TabIndex = 10;
            this.Download.Text = "Download";
            this.Download.UseVisualStyleBackColor = false;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // arduinoPort
            // 
            this.arduinoPort.PortName = "COM10";
            this.arduinoPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.arduinoPort_DataReceived);
            // 
            // siticoneGradientPanel2
            // 
            this.siticoneGradientPanel2.Controls.Add(this.siticoneControlBox3);
            this.siticoneGradientPanel2.Controls.Add(this.siticoneControlBox2);
            this.siticoneGradientPanel2.Controls.Add(this.siticoneControlBox1);
            this.siticoneGradientPanel2.Location = new System.Drawing.Point(819, 2);
            this.siticoneGradientPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siticoneGradientPanel2.Name = "siticoneGradientPanel2";
            this.siticoneGradientPanel2.ShadowDecoration.Parent = this.siticoneGradientPanel2;
            this.siticoneGradientPanel2.Size = new System.Drawing.Size(168, 37);
            this.siticoneGradientPanel2.TabIndex = 15;
            // 
            // siticoneControlBox3
            // 
            this.siticoneControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox3.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.siticoneControlBox3.HoverState.Parent = this.siticoneControlBox3;
            this.siticoneControlBox3.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox3.Location = new System.Drawing.Point(-3, 0);
            this.siticoneControlBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siticoneControlBox3.Name = "siticoneControlBox3";
            this.siticoneControlBox3.ShadowDecoration.Parent = this.siticoneControlBox3;
            this.siticoneControlBox3.Size = new System.Drawing.Size(60, 36);
            this.siticoneControlBox3.TabIndex = 2;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.siticoneControlBox2.HoverState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(48, 0);
            this.siticoneControlBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(60, 36);
            this.siticoneControlBox2.TabIndex = 1;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.siticoneControlBox1.Location = new System.Drawing.Point(108, 0);
            this.siticoneControlBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(60, 36);
            this.siticoneControlBox1.TabIndex = 0;
            // 
            // siticoneGroupBox1
            // 
            this.siticoneGroupBox1.Controls.Add(this.label4);
            this.siticoneGroupBox1.Controls.Add(this.label3);
            this.siticoneGroupBox1.Controls.Add(this.label1);
            this.siticoneGroupBox1.Controls.Add(this.closeSerial);
            this.siticoneGroupBox1.Controls.Add(this.siticoneButton3);
            this.siticoneGroupBox1.Controls.Add(this.siticoneButton2);
            this.siticoneGroupBox1.Controls.Add(this.openSerial);
            this.siticoneGroupBox1.Controls.Add(this.siticoneHtmlLabel2);
            this.siticoneGroupBox1.Controls.Add(this.lbl_SOI);
            this.siticoneGroupBox1.Controls.Add(this.comboPorts);
            this.siticoneGroupBox1.Controls.Add(this.lbl_HUM);
            this.siticoneGroupBox1.Controls.Add(this.lbl_TEMP);
            this.siticoneGroupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneGroupBox1.Location = new System.Drawing.Point(16, 466);
            this.siticoneGroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siticoneGroupBox1.Name = "siticoneGroupBox1";
            this.siticoneGroupBox1.ShadowDecoration.Parent = this.siticoneGroupBox1;
            this.siticoneGroupBox1.Size = new System.Drawing.Size(952, 262);
            this.siticoneGroupBox1.TabIndex = 17;
            this.siticoneGroupBox1.Text = "APPICATION CONFIGURATION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 34);
            this.label4.TabIndex = 28;
            this.label4.Text = "SOIL MOISTURE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 34);
            this.label3.TabIndex = 27;
            this.label3.Text = " HUMIDITY";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 34);
            this.label1.TabIndex = 26;
            this.label1.Text = " TEMPARATURE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeSerial
            // 
            this.closeSerial.AutoSize = true;
            this.closeSerial.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.closeSerial.CheckedState.BorderThickness = 0;
            this.closeSerial.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.closeSerial.CheckedState.InnerColor = System.Drawing.Color.White;
            this.closeSerial.CheckedState.InnerOffset = -4;
            this.closeSerial.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.closeSerial.Location = new System.Drawing.Point(0, 202);
            this.closeSerial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeSerial.Name = "closeSerial";
            this.closeSerial.Size = new System.Drawing.Size(217, 38);
            this.closeSerial.TabIndex = 10;
            this.closeSerial.Text = "Close Serial ";
            this.closeSerial.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.closeSerial.UncheckedState.BorderThickness = 2;
            this.closeSerial.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.closeSerial.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.closeSerial.CheckedChanged += new System.EventHandler(this.closeSerial_CheckedChanged);
            // 
            // siticoneButton3
            // 
            this.siticoneButton3.BorderRadius = 10;
            this.siticoneButton3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.siticoneButton3.BorderThickness = 1;
            this.siticoneButton3.CheckedState.Parent = this.siticoneButton3;
            this.siticoneButton3.CustomImages.Parent = this.siticoneButton3;
            this.siticoneButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton3.DisabledState.Parent = this.siticoneButton3;
            this.siticoneButton3.FillColor = System.Drawing.SystemColors.HotTrack;
            this.siticoneButton3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneButton3.HoverState.Parent = this.siticoneButton3;
            this.siticoneButton3.Location = new System.Drawing.Point(243, 121);
            this.siticoneButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.ShadowDecoration.Parent = this.siticoneButton3;
            this.siticoneButton3.Size = new System.Drawing.Size(185, 44);
            this.siticoneButton3.TabIndex = 7;
            this.siticoneButton3.Text = "Pump ON";
            this.siticoneButton3.Click += new System.EventHandler(this.siticoneButton3_Click_1);
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.BorderRadius = 10;
            this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
            this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
            this.siticoneButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton2.DisabledState.Parent = this.siticoneButton2;
            this.siticoneButton2.FillColor = System.Drawing.SystemColors.HotTrack;
            this.siticoneButton2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.HoverState.Parent = this.siticoneButton2;
            this.siticoneButton2.Location = new System.Drawing.Point(243, 194);
            this.siticoneButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
            this.siticoneButton2.Size = new System.Drawing.Size(185, 44);
            this.siticoneButton2.TabIndex = 6;
            this.siticoneButton2.Text = "Pump OFF";
            this.siticoneButton2.Click += new System.EventHandler(this.siticoneButton2_Click_1);
            // 
            // openSerial
            // 
            this.openSerial.AutoSize = true;
            this.openSerial.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.openSerial.CheckedState.BorderThickness = 0;
            this.openSerial.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.openSerial.CheckedState.InnerColor = System.Drawing.Color.White;
            this.openSerial.CheckedState.InnerOffset = -4;
            this.openSerial.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.openSerial.Location = new System.Drawing.Point(0, 128);
            this.openSerial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openSerial.Name = "openSerial";
            this.openSerial.Size = new System.Drawing.Size(215, 38);
            this.openSerial.TabIndex = 4;
            this.openSerial.Text = "Open Serial ";
            this.openSerial.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.openSerial.UncheckedState.BorderThickness = 2;
            this.openSerial.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.openSerial.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.openSerial.CheckedChanged += new System.EventHandler(this.openSerial_CheckedChanged);
            // 
            // siticoneHtmlLabel2
            // 
            this.siticoneHtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel2.Location = new System.Drawing.Point(4, 74);
            this.siticoneHtmlLabel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            this.siticoneHtmlLabel2.Size = new System.Drawing.Size(83, 18);
            this.siticoneHtmlLabel2.TabIndex = 3;
            this.siticoneHtmlLabel2.Text = "COM PORTS";
            // 
            // lbl_SOI
            // 
            this.lbl_SOI.AutoSize = true;
            this.lbl_SOI.Location = new System.Drawing.Point(819, 194);
            this.lbl_SOI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SOI.Name = "lbl_SOI";
            this.lbl_SOI.Size = new System.Drawing.Size(84, 34);
            this.lbl_SOI.TabIndex = 21;
            this.lbl_SOI.Text = "SOIL";
            this.lbl_SOI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboPorts
            // 
            this.comboPorts.BackColor = System.Drawing.Color.Transparent;
            this.comboPorts.BorderRadius = 4;
            this.comboPorts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPorts.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboPorts.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboPorts.FocusedState.Parent = this.comboPorts;
            this.comboPorts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboPorts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboPorts.HoverState.Parent = this.comboPorts;
            this.comboPorts.ItemHeight = 30;
            this.comboPorts.ItemsAppearance.Parent = this.comboPorts;
            this.comboPorts.Location = new System.Drawing.Point(244, 64);
            this.comboPorts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboPorts.Name = "comboPorts";
            this.comboPorts.ShadowDecoration.Parent = this.comboPorts;
            this.comboPorts.Size = new System.Drawing.Size(185, 36);
            this.comboPorts.TabIndex = 1;
            this.comboPorts.DropDown += new System.EventHandler(this.siticoneComboBox2_DropDown);
            // 
            // lbl_HUM
            // 
            this.lbl_HUM.AutoSize = true;
            this.lbl_HUM.Location = new System.Drawing.Point(819, 133);
            this.lbl_HUM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HUM.Name = "lbl_HUM";
            this.lbl_HUM.Size = new System.Drawing.Size(100, 34);
            this.lbl_HUM.TabIndex = 19;
            this.lbl_HUM.Text = "HUMA";
            this.lbl_HUM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TEMP
            // 
            this.lbl_TEMP.AutoSize = true;
            this.lbl_TEMP.Location = new System.Drawing.Point(803, 74);
            this.lbl_TEMP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TEMP.Name = "lbl_TEMP";
            this.lbl_TEMP.Size = new System.Drawing.Size(103, 34);
            this.lbl_TEMP.TabIndex = 20;
            this.lbl_TEMP.Text = " TEMP";
            this.lbl_TEMP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::System_APP.Properties.Resources.FireDetect;
            this.pictureBox1.Location = new System.Drawing.Point(-23, 102);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.DisabledState.Parent = this.siticoneButton1;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoverState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(636, 426);
            this.siticoneButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(240, 32);
            this.siticoneButton1.TabIndex = 27;
            this.siticoneButton1.Text = "InsertToDatabase";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click_1);
            // 
            // mainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 745);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.siticoneGroupBox1);
            this.Controls.Add(this.siticoneGradientPanel2);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dTimeSts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "mainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                             ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.siticoneGradientPanel2.ResumeLayout(false);
            this.siticoneGroupBox1.ResumeLayout(false);
            this.siticoneGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dTimeSts;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Download;
        private System.IO.Ports.SerialPort arduinoPort;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel2;
        private Siticone.Desktop.UI.WinForms.SiticoneGroupBox siticoneGroupBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox comboPorts;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneRadioButton openSerial;
        private Siticone.Desktop.UI.WinForms.SiticoneRadioButton closeSerial;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton3;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox3;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private System.Windows.Forms.Label lbl_HUM;
        private System.Windows.Forms.Label lbl_TEMP;
        private System.Windows.Forms.Label lbl_SOI;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
    }
}

