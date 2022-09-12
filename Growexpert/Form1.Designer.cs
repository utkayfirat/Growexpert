namespace Growexpert
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.appBarLayer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.updateBotButton = new System.Windows.Forms.Button();
            this.getDataButton = new System.Windows.Forms.Button();
            this.autoFarmerType = new System.Windows.Forms.ComboBox();
            this.toggleAutoFarmer = new System.Windows.Forms.Button();
            this.punchTimerssss = new System.Windows.Forms.Timer(this.components);
            this.processListDataGridView = new System.Windows.Forms.DataGridView();
            this.Checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrowtopiaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BotID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.xLocationTextBoxONE = new System.Windows.Forms.NumericUpDown();
            this.yLocationTextBoxONE = new System.Windows.Forms.NumericUpDown();
            this.yLocationTextBoxTWO = new System.Windows.Forms.NumericUpDown();
            this.xLocationTextBoxTWO = new System.Windows.Forms.NumericUpDown();
            this.yLocationTextBoxTHREE = new System.Windows.Forms.NumericUpDown();
            this.xLocationTextBoxTHREE = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.appBarLayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xLocationTextBoxONE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yLocationTextBoxONE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yLocationTextBoxTWO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xLocationTextBoxTWO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yLocationTextBoxTHREE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xLocationTextBoxTHREE)).BeginInit();
            this.SuspendLayout();
            // 
            // appBarLayer
            // 
            this.appBarLayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.appBarLayer.Controls.Add(this.label1);
            this.appBarLayer.Controls.Add(this.closeButton);
            this.appBarLayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.appBarLayer.Location = new System.Drawing.Point(0, 0);
            this.appBarLayer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.appBarLayer.Name = "appBarLayer";
            this.appBarLayer.Size = new System.Drawing.Size(530, 38);
            this.appBarLayer.TabIndex = 2;
            this.appBarLayer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.appBarLayer_MouseDown);
            this.appBarLayer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.appBarLayer_MouseMove);
            this.appBarLayer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.appBarLayer_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Growexpert";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.closeButton.Location = new System.Drawing.Point(472, -6);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(62, 49);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // updateBotButton
            // 
            this.updateBotButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.updateBotButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.updateBotButton.FlatAppearance.BorderSize = 0;
            this.updateBotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBotButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBotButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.updateBotButton.Location = new System.Drawing.Point(417, 49);
            this.updateBotButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.updateBotButton.Name = "updateBotButton";
            this.updateBotButton.Size = new System.Drawing.Size(101, 31);
            this.updateBotButton.TabIndex = 4;
            this.updateBotButton.Text = "Update";
            this.updateBotButton.UseVisualStyleBackColor = false;
            this.updateBotButton.Click += new System.EventHandler(this.updateBotButton_Click);
            // 
            // getDataButton
            // 
            this.getDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.getDataButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.getDataButton.FlatAppearance.BorderSize = 0;
            this.getDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getDataButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getDataButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.getDataButton.Location = new System.Drawing.Point(11, 423);
            this.getDataButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.getDataButton.Name = "getDataButton";
            this.getDataButton.Size = new System.Drawing.Size(382, 32);
            this.getDataButton.TabIndex = 6;
            this.getDataButton.Text = "Get Growtopian\'s";
            this.getDataButton.UseVisualStyleBackColor = false;
            this.getDataButton.Click += new System.EventHandler(this.getDataButton_Click);
            // 
            // autoFarmerType
            // 
            this.autoFarmerType.BackColor = System.Drawing.Color.White;
            this.autoFarmerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.autoFarmerType.FormattingEnabled = true;
            this.autoFarmerType.Items.AddRange(new object[] {
            "None",
            "BFGMod"});
            this.autoFarmerType.Location = new System.Drawing.Point(12, 53);
            this.autoFarmerType.Name = "autoFarmerType";
            this.autoFarmerType.Size = new System.Drawing.Size(400, 21);
            this.autoFarmerType.TabIndex = 7;
            // 
            // toggleAutoFarmer
            // 
            this.toggleAutoFarmer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.toggleAutoFarmer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.toggleAutoFarmer.FlatAppearance.BorderSize = 0;
            this.toggleAutoFarmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleAutoFarmer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleAutoFarmer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.toggleAutoFarmer.Location = new System.Drawing.Point(399, 423);
            this.toggleAutoFarmer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.toggleAutoFarmer.Name = "toggleAutoFarmer";
            this.toggleAutoFarmer.Size = new System.Drawing.Size(120, 32);
            this.toggleAutoFarmer.TabIndex = 8;
            this.toggleAutoFarmer.Text = "Bot: Off";
            this.toggleAutoFarmer.UseVisualStyleBackColor = false;
            this.toggleAutoFarmer.Click += new System.EventHandler(this.toggleAutoFarmer_Click);
            // 
            // punchTimerssss
            // 
            this.punchTimerssss.Interval = 175;
            this.punchTimerssss.Tick += new System.EventHandler(this.punchTimer_Tick);
            // 
            // processListDataGridView
            // 
            this.processListDataGridView.AllowUserToAddRows = false;
            this.processListDataGridView.AllowUserToDeleteRows = false;
            this.processListDataGridView.AllowUserToResizeColumns = false;
            this.processListDataGridView.AllowUserToResizeRows = false;
            this.processListDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(87)))), ((int)(((byte)(143)))));
            this.processListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.processListDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.processListDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.processListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.processListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Checkbox,
            this.Number,
            this.GrowtopiaID,
            this.BotID,
            this.PID,
            this.TimeID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.processListDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.processListDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.processListDataGridView.Location = new System.Drawing.Point(12, 88);
            this.processListDataGridView.Name = "processListDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.processListDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.processListDataGridView.RowHeadersVisible = false;
            this.processListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.processListDataGridView.Size = new System.Drawing.Size(506, 282);
            this.processListDataGridView.TabIndex = 10;
            // 
            // Checkbox
            // 
            this.Checkbox.FillWeight = 40F;
            this.Checkbox.HeaderText = " ";
            this.Checkbox.Name = "Checkbox";
            this.Checkbox.Width = 40;
            // 
            // Number
            // 
            this.Number.FillWeight = 40F;
            this.Number.HeaderText = "#";
            this.Number.Name = "Number";
            this.Number.Width = 40;
            // 
            // GrowtopiaID
            // 
            this.GrowtopiaID.HeaderText = "Growtopia";
            this.GrowtopiaID.Name = "GrowtopiaID";
            // 
            // BotID
            // 
            this.BotID.HeaderText = "Bot";
            this.BotID.Name = "BotID";
            // 
            // PID
            // 
            this.PID.HeaderText = "P.ID";
            this.PID.Name = "PID";
            // 
            // TimeID
            // 
            this.TimeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TimeID.HeaderText = "Time";
            this.TimeID.Name = "TimeID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label2.Location = new System.Drawing.Point(9, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "1 (X,Y)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label3.Location = new System.Drawing.Point(133, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "2 (X,Y)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label4.Location = new System.Drawing.Point(256, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "3 (X,Y)";
            // 
            // xLocationTextBoxONE
            // 
            this.xLocationTextBoxONE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xLocationTextBoxONE.Location = new System.Drawing.Point(12, 394);
            this.xLocationTextBoxONE.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.xLocationTextBoxONE.Name = "xLocationTextBoxONE";
            this.xLocationTextBoxONE.Size = new System.Drawing.Size(51, 20);
            this.xLocationTextBoxONE.TabIndex = 21;
            this.xLocationTextBoxONE.ValueChanged += new System.EventHandler(this.xLocationTextBoxONE_ValueChanged);
            // 
            // yLocationTextBoxONE
            // 
            this.yLocationTextBoxONE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yLocationTextBoxONE.Location = new System.Drawing.Point(69, 394);
            this.yLocationTextBoxONE.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.yLocationTextBoxONE.Name = "yLocationTextBoxONE";
            this.yLocationTextBoxONE.Size = new System.Drawing.Size(51, 20);
            this.yLocationTextBoxONE.TabIndex = 22;
            this.yLocationTextBoxONE.ValueChanged += new System.EventHandler(this.xLocationTextBoxONE_ValueChanged);
            // 
            // yLocationTextBoxTWO
            // 
            this.yLocationTextBoxTWO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yLocationTextBoxTWO.Location = new System.Drawing.Point(193, 394);
            this.yLocationTextBoxTWO.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.yLocationTextBoxTWO.Name = "yLocationTextBoxTWO";
            this.yLocationTextBoxTWO.Size = new System.Drawing.Size(51, 20);
            this.yLocationTextBoxTWO.TabIndex = 24;
            this.yLocationTextBoxTWO.ValueChanged += new System.EventHandler(this.xLocationTextBoxTWO_ValueChanged);
            // 
            // xLocationTextBoxTWO
            // 
            this.xLocationTextBoxTWO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xLocationTextBoxTWO.Location = new System.Drawing.Point(136, 394);
            this.xLocationTextBoxTWO.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.xLocationTextBoxTWO.Name = "xLocationTextBoxTWO";
            this.xLocationTextBoxTWO.Size = new System.Drawing.Size(51, 20);
            this.xLocationTextBoxTWO.TabIndex = 23;
            this.xLocationTextBoxTWO.ValueChanged += new System.EventHandler(this.xLocationTextBoxTWO_ValueChanged);
            // 
            // yLocationTextBoxTHREE
            // 
            this.yLocationTextBoxTHREE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yLocationTextBoxTHREE.Location = new System.Drawing.Point(316, 394);
            this.yLocationTextBoxTHREE.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.yLocationTextBoxTHREE.Name = "yLocationTextBoxTHREE";
            this.yLocationTextBoxTHREE.Size = new System.Drawing.Size(51, 20);
            this.yLocationTextBoxTHREE.TabIndex = 26;
            this.yLocationTextBoxTHREE.ValueChanged += new System.EventHandler(this.xLocationTextBoxTHREE_ValueChanged);
            // 
            // xLocationTextBoxTHREE
            // 
            this.xLocationTextBoxTHREE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xLocationTextBoxTHREE.Location = new System.Drawing.Point(259, 394);
            this.xLocationTextBoxTHREE.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.xLocationTextBoxTHREE.Name = "xLocationTextBoxTHREE";
            this.xLocationTextBoxTHREE.Size = new System.Drawing.Size(51, 20);
            this.xLocationTextBoxTHREE.TabIndex = 25;
            this.xLocationTextBoxTHREE.ValueChanged += new System.EventHandler(this.xLocationTextBoxTHREE_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.button1.Location = new System.Drawing.Point(449, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Perfect";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.button2.Location = new System.Drawing.Point(373, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Normal";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.label5.Location = new System.Drawing.Point(9, 463);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "coded by github.com/utkayfirat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.label6.Location = new System.Drawing.Point(496, 463);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "V1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(530, 487);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yLocationTextBoxTHREE);
            this.Controls.Add(this.xLocationTextBoxTHREE);
            this.Controls.Add(this.yLocationTextBoxTWO);
            this.Controls.Add(this.xLocationTextBoxTWO);
            this.Controls.Add(this.yLocationTextBoxONE);
            this.Controls.Add(this.xLocationTextBoxONE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.processListDataGridView);
            this.Controls.Add(this.toggleAutoFarmer);
            this.Controls.Add(this.autoFarmerType);
            this.Controls.Add(this.getDataButton);
            this.Controls.Add(this.updateBotButton);
            this.Controls.Add(this.appBarLayer);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Growexpert";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.appBarLayer.ResumeLayout(false);
            this.appBarLayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xLocationTextBoxONE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yLocationTextBoxONE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yLocationTextBoxTWO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xLocationTextBoxTWO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yLocationTextBoxTHREE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xLocationTextBoxTHREE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel appBarLayer;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateBotButton;
        private System.Windows.Forms.Button getDataButton;
        private System.Windows.Forms.ComboBox autoFarmerType;
        private System.Windows.Forms.Button toggleAutoFarmer;
        private System.Windows.Forms.Timer punchTimerssss;
        private System.Windows.Forms.DataGridView processListDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrowtopiaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BotID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown xLocationTextBoxONE;
        private System.Windows.Forms.NumericUpDown yLocationTextBoxONE;
        private System.Windows.Forms.NumericUpDown yLocationTextBoxTWO;
        private System.Windows.Forms.NumericUpDown xLocationTextBoxTWO;
        private System.Windows.Forms.NumericUpDown yLocationTextBoxTHREE;
        private System.Windows.Forms.NumericUpDown xLocationTextBoxTHREE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

