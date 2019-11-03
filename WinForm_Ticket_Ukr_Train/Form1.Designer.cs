namespace WinForm_Ticket_Ukr_Train
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSerName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonSV = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonPlacKart = new System.Windows.Forms.RadioButton();
            this.radioButtonCupe = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownVagon = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonPrice = new System.Windows.Forms.Button();
            this.textBoxPriceBase = new System.Windows.Forms.TextBox();
            this.textBoxFullPrice = new System.Windows.Forms.TextBox();
            this.buttonFullPrice = new System.Windows.Forms.Button();
            this.progressBarSaveToFile = new System.Windows.Forms.ProgressBar();
            this.linkLabelUKRZAL = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.buttonClearAllItem = new System.Windows.Forms.Button();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.buttunSaveAllTickets = new System.Windows.Forms.Button();
            this.textBoxSeeAllTickets = new System.Windows.Forms.TextBox();
            this.buttonSeeAllTickets = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxForOpeningTickets = new System.Windows.Forms.TextBox();
            this.buttonForOpening = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVagon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Train";
            this.notifyIcon.Visible = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Імя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Прізвище";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер поїзда";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(135, 30);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(179, 20);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.TextChanged += new System.EventHandler(this.fullNameChange);
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RightSymbols);
            // 
            // textBoxSerName
            // 
            this.textBoxSerName.Location = new System.Drawing.Point(135, 70);
            this.textBoxSerName.Name = "textBoxSerName";
            this.textBoxSerName.Size = new System.Drawing.Size(179, 20);
            this.textBoxSerName.TabIndex = 4;
            this.textBoxSerName.TextChanged += new System.EventHandler(this.fullNameChange);
            this.textBoxSerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RightSymbols);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(154, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Звідки";
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.Enabled = false;
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Items.AddRange(new object[] {
            "Рівне",
            "Здолбунів",
            "Львів"});
            this.comboBoxFrom.Location = new System.Drawing.Point(135, 149);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(179, 21);
            this.comboBoxFrom.TabIndex = 7;
            this.comboBoxFrom.SelectedIndexChanged += new System.EventHandler(this.AllInfoHadGot);
            this.comboBoxFrom.SelectedValueChanged += new System.EventHandler(this.comboBoxTo_SelectedValueChanged);
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.Enabled = false;
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Items.AddRange(new object[] {
            "Львів",
            "Київ",
            "Варшава",
            "Лодзь"});
            this.comboBoxTo.Location = new System.Drawing.Point(135, 194);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(179, 21);
            this.comboBoxTo.TabIndex = 8;
            this.comboBoxTo.SelectedIndexChanged += new System.EventHandler(this.AllInfoHadGot);
            this.comboBoxTo.SelectedValueChanged += new System.EventHandler(this.comboBoxTo_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Куди";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 239);
            this.dateTimePicker1.MinDate = new System.DateTime(2019, 10, 27, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Дата";
            // 
            // radioButtonSV
            // 
            this.radioButtonSV.AutoSize = true;
            this.radioButtonSV.Location = new System.Drawing.Point(6, 19);
            this.radioButtonSV.Name = "radioButtonSV";
            this.radioButtonSV.Size = new System.Drawing.Size(44, 20);
            this.radioButtonSV.TabIndex = 12;
            this.radioButtonSV.TabStop = true;
            this.radioButtonSV.Text = "СВ";
            this.radioButtonSV.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonPlacKart);
            this.groupBox1.Controls.Add(this.radioButtonCupe);
            this.groupBox1.Controls.Add(this.radioButtonSV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(139, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип вагону";
            // 
            // radioButtonPlacKart
            // 
            this.radioButtonPlacKart.AutoSize = true;
            this.radioButtonPlacKart.Location = new System.Drawing.Point(6, 67);
            this.radioButtonPlacKart.Name = "radioButtonPlacKart";
            this.radioButtonPlacKart.Size = new System.Drawing.Size(90, 20);
            this.radioButtonPlacKart.TabIndex = 14;
            this.radioButtonPlacKart.TabStop = true;
            this.radioButtonPlacKart.Text = "Плацкарт";
            this.radioButtonPlacKart.UseVisualStyleBackColor = true;
            // 
            // radioButtonCupe
            // 
            this.radioButtonCupe.AutoSize = true;
            this.radioButtonCupe.Location = new System.Drawing.Point(6, 42);
            this.radioButtonCupe.Name = "radioButtonCupe";
            this.radioButtonCupe.Size = new System.Drawing.Size(58, 20);
            this.radioButtonCupe.TabIndex = 13;
            this.radioButtonCupe.TabStop = true;
            this.radioButtonCupe.Text = "Купе";
            this.radioButtonCupe.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Тип вагону";
            // 
            // numericUpDownVagon
            // 
            this.numericUpDownVagon.Location = new System.Drawing.Point(139, 386);
            this.numericUpDownVagon.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownVagon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownVagon.Name = "numericUpDownVagon";
            this.numericUpDownVagon.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownVagon.TabIndex = 15;
            this.numericUpDownVagon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Номер вагону";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 466);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Додаткові сервіси";
            // 
            // buttonPrice
            // 
            this.buttonPrice.Enabled = false;
            this.buttonPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrice.Location = new System.Drawing.Point(384, 31);
            this.buttonPrice.Name = "buttonPrice";
            this.buttonPrice.Size = new System.Drawing.Size(245, 60);
            this.buttonPrice.TabIndex = 19;
            this.buttonPrice.Text = "Розрахувати базову вартість";
            this.buttonPrice.UseVisualStyleBackColor = true;
            this.buttonPrice.Click += new System.EventHandler(this.buttonPrice_Click);
            // 
            // textBoxPriceBase
            // 
            this.textBoxPriceBase.Enabled = false;
            this.textBoxPriceBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPriceBase.Location = new System.Drawing.Point(452, 115);
            this.textBoxPriceBase.Name = "textBoxPriceBase";
            this.textBoxPriceBase.ReadOnly = true;
            this.textBoxPriceBase.Size = new System.Drawing.Size(102, 31);
            this.textBoxPriceBase.TabIndex = 20;
            // 
            // textBoxFullPrice
            // 
            this.textBoxFullPrice.Enabled = false;
            this.textBoxFullPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFullPrice.Location = new System.Drawing.Point(454, 241);
            this.textBoxFullPrice.Name = "textBoxFullPrice";
            this.textBoxFullPrice.ReadOnly = true;
            this.textBoxFullPrice.Size = new System.Drawing.Size(100, 31);
            this.textBoxFullPrice.TabIndex = 21;
            // 
            // buttonFullPrice
            // 
            this.buttonFullPrice.Enabled = false;
            this.buttonFullPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFullPrice.Location = new System.Drawing.Point(384, 162);
            this.buttonFullPrice.Name = "buttonFullPrice";
            this.buttonFullPrice.Size = new System.Drawing.Size(245, 55);
            this.buttonFullPrice.TabIndex = 22;
            this.buttonFullPrice.Text = "Розрахувати повну вартість";
            this.buttonFullPrice.UseVisualStyleBackColor = true;
            this.buttonFullPrice.Click += new System.EventHandler(this.buttonFullPrice_Click);
            // 
            // progressBarSaveToFile
            // 
            this.progressBarSaveToFile.Location = new System.Drawing.Point(419, 547);
            this.progressBarSaveToFile.Name = "progressBarSaveToFile";
            this.progressBarSaveToFile.Size = new System.Drawing.Size(210, 20);
            this.progressBarSaveToFile.Step = 1;
            this.progressBarSaveToFile.TabIndex = 1;
            // 
            // linkLabelUKRZAL
            // 
            this.linkLabelUKRZAL.AutoSize = true;
            this.linkLabelUKRZAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelUKRZAL.Location = new System.Drawing.Point(379, 472);
            this.linkLabelUKRZAL.Name = "linkLabelUKRZAL";
            this.linkLabelUKRZAL.Size = new System.Drawing.Size(127, 25);
            this.linkLabelUKRZAL.TabIndex = 24;
            this.linkLabelUKRZAL.TabStop = true;
            this.linkLabelUKRZAL.Text = "UZ.GOV.UA";
            this.linkLabelUKRZAL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelUKRZAL_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(380, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(238, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Перейти на сайт УкрЗалізниці";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Enabled = false;
            this.buttonSaveToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveToFile.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonSaveToFile.Location = new System.Drawing.Point(384, 292);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(210, 35);
            this.buttonSaveToFile.TabIndex = 26;
            this.buttonSaveToFile.Text = "Зберегти квиток";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // buttonClearAllItem
            // 
            this.buttonClearAllItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearAllItem.Location = new System.Drawing.Point(80, 537);
            this.buttonClearAllItem.Name = "buttonClearAllItem";
            this.buttonClearAllItem.Size = new System.Drawing.Size(139, 43);
            this.buttonClearAllItem.TabIndex = 27;
            this.buttonClearAllItem.Text = "Очистити заповнені поля";
            this.buttonClearAllItem.UseVisualStyleBackColor = true;
            this.buttonClearAllItem.Click += new System.EventHandler(this.buttonClearAllItem_Click);
            // 
            // checkedListBox
            // 
            this.checkedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Items.AddRange(new object[] {
            "Чай ",
            "Постіль",
            "Інше"});
            this.checkedListBox.Location = new System.Drawing.Point(158, 448);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(101, 55);
            this.checkedListBox.TabIndex = 18;
            // 
            // buttunSaveAllTickets
            // 
            this.buttunSaveAllTickets.BackColor = System.Drawing.Color.SeaGreen;
            this.buttunSaveAllTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttunSaveAllTickets.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttunSaveAllTickets.Location = new System.Drawing.Point(384, 358);
            this.buttunSaveAllTickets.Name = "buttunSaveAllTickets";
            this.buttunSaveAllTickets.Size = new System.Drawing.Size(210, 49);
            this.buttunSaveAllTickets.TabIndex = 28;
            this.buttunSaveAllTickets.Text = "Зберегти всі квитки, що були зроблені";
            this.buttunSaveAllTickets.UseVisualStyleBackColor = false;
            this.buttunSaveAllTickets.Click += new System.EventHandler(this.buttunSaveAllTickets_Click);
            // 
            // textBoxSeeAllTickets
            // 
            this.textBoxSeeAllTickets.Location = new System.Drawing.Point(677, 76);
            this.textBoxSeeAllTickets.Multiline = true;
            this.textBoxSeeAllTickets.Name = "textBoxSeeAllTickets";
            this.textBoxSeeAllTickets.Size = new System.Drawing.Size(211, 173);
            this.textBoxSeeAllTickets.TabIndex = 29;
            // 
            // buttonSeeAllTickets
            // 
            this.buttonSeeAllTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeeAllTickets.Location = new System.Drawing.Point(677, 30);
            this.buttonSeeAllTickets.Name = "buttonSeeAllTickets";
            this.buttonSeeAllTickets.Size = new System.Drawing.Size(211, 40);
            this.buttonSeeAllTickets.TabIndex = 30;
            this.buttonSeeAllTickets.Text = "Переглянути всі квитки";
            this.buttonSeeAllTickets.UseVisualStyleBackColor = true;
            this.buttonSeeAllTickets.Click += new System.EventHandler(this.buttonSeeAllTickets_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // textBoxForOpeningTickets
            // 
            this.textBoxForOpeningTickets.Location = new System.Drawing.Point(677, 317);
            this.textBoxForOpeningTickets.Multiline = true;
            this.textBoxForOpeningTickets.Name = "textBoxForOpeningTickets";
            this.textBoxForOpeningTickets.Size = new System.Drawing.Size(458, 211);
            this.textBoxForOpeningTickets.TabIndex = 31;
            // 
            // buttonForOpening
            // 
            this.buttonForOpening.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonForOpening.Location = new System.Drawing.Point(906, 241);
            this.buttonForOpening.Name = "buttonForOpening";
            this.buttonForOpening.Size = new System.Drawing.Size(229, 59);
            this.buttonForOpening.TabIndex = 32;
            this.buttonForOpening.Text = "Відкрити квитки, що є збережені";
            this.buttonForOpening.UseVisualStyleBackColor = true;
            this.buttonForOpening.Click += new System.EventHandler(this.buttonForOpening_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 634);
            this.Controls.Add(this.buttonForOpening);
            this.Controls.Add(this.textBoxForOpeningTickets);
            this.Controls.Add(this.buttonSeeAllTickets);
            this.Controls.Add(this.textBoxSeeAllTickets);
            this.Controls.Add(this.buttunSaveAllTickets);
            this.Controls.Add(this.buttonClearAllItem);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.linkLabelUKRZAL);
            this.Controls.Add(this.progressBarSaveToFile);
            this.Controls.Add(this.buttonFullPrice);
            this.Controls.Add(this.textBoxFullPrice);
            this.Controls.Add(this.textBoxPriceBase);
            this.Controls.Add(this.buttonPrice);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDownVagon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxTo);
            this.Controls.Add(this.comboBoxFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxSerName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ticket";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVagon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSerName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonPlacKart;
        private System.Windows.Forms.RadioButton radioButtonCupe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownVagon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonPrice;
        private System.Windows.Forms.TextBox textBoxPriceBase;
        private System.Windows.Forms.TextBox textBoxFullPrice;
        private System.Windows.Forms.Button buttonFullPrice;
        private System.Windows.Forms.ProgressBar progressBarSaveToFile;
        private System.Windows.Forms.LinkLabel linkLabelUKRZAL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.Button buttonClearAllItem;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Button buttunSaveAllTickets;
        private System.Windows.Forms.TextBox textBoxSeeAllTickets;
        private System.Windows.Forms.Button buttonSeeAllTickets;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button buttonForOpening;
        private System.Windows.Forms.TextBox textBoxForOpeningTickets;
    }
}

