namespace WindowsFormsApplication
{
    partial class changeFormOne
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
            this.label_Inv = new System.Windows.Forms.Label();
            this.label_inv_text1 = new System.Windows.Forms.Label();
            this.comboBox_AC = new System.Windows.Forms.ComboBox();
            this.label__inv_text2 = new System.Windows.Forms.Label();
            this.label_inv_old = new System.Windows.Forms.Label();
            this.textBox_inv = new System.Windows.Forms.TextBox();
            this.label_AC = new System.Windows.Forms.Label();
            this.label_AC_text1 = new System.Windows.Forms.Label();
            this.label_AC_text2 = new System.Windows.Forms.Label();
            this.checkBox_AC = new System.Windows.Forms.CheckBox();
            this.label_AC_old = new System.Windows.Forms.Label();
            this.textBox_AC = new System.Windows.Forms.TextBox();
            this.label_SN = new System.Windows.Forms.Label();
            this.label_SN_text1 = new System.Windows.Forms.Label();
            this.label_SN_text2 = new System.Windows.Forms.Label();
            this.label_SN_old = new System.Windows.Forms.Label();
            this.textBox_SN = new System.Windows.Forms.TextBox();
            this.label_model = new System.Windows.Forms.Label();
            this.label_model_text1 = new System.Windows.Forms.Label();
            this.label_model_text2 = new System.Windows.Forms.Label();
            this.label_model_old = new System.Windows.Forms.Label();
            this.textBox_model = new System.Windows.Forms.TextBox();
            this.comboBox_device = new System.Windows.Forms.ComboBox();
            this.label_device = new System.Windows.Forms.Label();
            this.label_device_text1 = new System.Windows.Forms.Label();
            this.label_device_text2 = new System.Windows.Forms.Label();
            this.checkBox_device = new System.Windows.Forms.CheckBox();
            this.label_device_old = new System.Windows.Forms.Label();
            this.textBox_device = new System.Windows.Forms.TextBox();
            this.comboBox_jira = new System.Windows.Forms.ComboBox();
            this.label_Jira = new System.Windows.Forms.Label();
            this.label_Jira_text1 = new System.Windows.Forms.Label();
            this.label_Jira_text2 = new System.Windows.Forms.Label();
            this.checkBox_jira = new System.Windows.Forms.CheckBox();
            this.label_Jira_old = new System.Windows.Forms.Label();
            this.textBox_jira = new System.Windows.Forms.TextBox();
            this.Metka = new System.Windows.Forms.Label();
            this.panel_View = new System.Windows.Forms.Panel();
            this.label_date = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_date_test = new System.Windows.Forms.Label();
            this.label_ID_text = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.panel_View.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Inv
            // 
            this.label_Inv.BackColor = System.Drawing.Color.Silver;
            this.label_Inv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.7F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Inv.Location = new System.Drawing.Point(10, 210);
            this.label_Inv.Name = "label_Inv";
            this.label_Inv.Size = new System.Drawing.Size(449, 22);
            this.label_Inv.TabIndex = 60;
            this.label_Inv.Text = "Инвентарной номер ";
            this.label_Inv.Click += new System.EventHandler(this.label_Inv_Click);
            // 
            // label_inv_text1
            // 
            this.label_inv_text1.AutoSize = true;
            this.label_inv_text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_inv_text1.Location = new System.Drawing.Point(12, 240);
            this.label_inv_text1.Name = "label_inv_text1";
            this.label_inv_text1.Size = new System.Drawing.Size(138, 16);
            this.label_inv_text1.TabIndex = 61;
            this.label_inv_text1.Text = "Текущее значение :";
            this.label_inv_text1.Click += new System.EventHandler(this.label_inv_text1_Click);
            // 
            // comboBox_AC
            // 
            this.comboBox_AC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_AC.FormattingEnabled = true;
            this.comboBox_AC.Location = new System.Drawing.Point(188, 130);
            this.comboBox_AC.Name = "comboBox_AC";
            this.comboBox_AC.Size = new System.Drawing.Size(250, 24);
            this.comboBox_AC.TabIndex = 0;
            this.comboBox_AC.SelectedIndexChanged += new System.EventHandler(this.comboBox_AC_SelectedIndexChanged);
            // 
            // label__inv_text2
            // 
            this.label__inv_text2.AutoSize = true;
            this.label__inv_text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label__inv_text2.Location = new System.Drawing.Point(12, 265);
            this.label__inv_text2.Name = "label__inv_text2";
            this.label__inv_text2.Size = new System.Drawing.Size(95, 16);
            this.label__inv_text2.TabIndex = 62;
            this.label__inv_text2.Text = "Изменить на:";
            this.label__inv_text2.Click += new System.EventHandler(this.label__inv_text2_Click);
            // 
            // label_inv_old
            // 
            this.label_inv_old.AutoSize = true;
            this.label_inv_old.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_inv_old.ForeColor = System.Drawing.Color.Maroon;
            this.label_inv_old.Location = new System.Drawing.Point(188, 240);
            this.label_inv_old.Name = "label_inv_old";
            this.label_inv_old.Size = new System.Drawing.Size(51, 16);
            this.label_inv_old.TabIndex = 63;
            this.label_inv_old.Text = "label1";
            this.label_inv_old.Click += new System.EventHandler(this.label_inv_old_Click);
            // 
            // textBox_inv
            // 
            this.textBox_inv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_inv.Location = new System.Drawing.Point(188, 265);
            this.textBox_inv.Name = "textBox_inv";
            this.textBox_inv.Size = new System.Drawing.Size(250, 22);
            this.textBox_inv.TabIndex = 64;
            this.textBox_inv.TextChanged += new System.EventHandler(this.textBox_inv_TextChanged);
            // 
            // label_AC
            // 
            this.label_AC.BackColor = System.Drawing.Color.Silver;
            this.label_AC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.7F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_AC.Location = new System.Drawing.Point(10, 80);
            this.label_AC.Name = "label_AC";
            this.label_AC.Size = new System.Drawing.Size(449, 22);
            this.label_AC.TabIndex = 65;
            this.label_AC.Text = "Тип учёта  ";
            this.label_AC.Click += new System.EventHandler(this.label_AC_Click);
            // 
            // label_AC_text1
            // 
            this.label_AC_text1.AutoSize = true;
            this.label_AC_text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_AC_text1.Location = new System.Drawing.Point(12, 110);
            this.label_AC_text1.Name = "label_AC_text1";
            this.label_AC_text1.Size = new System.Drawing.Size(138, 16);
            this.label_AC_text1.TabIndex = 66;
            this.label_AC_text1.Text = "Текущее значение :";
            this.label_AC_text1.Click += new System.EventHandler(this.label_AC_text1_Click);
            // 
            // label_AC_text2
            // 
            this.label_AC_text2.AutoSize = true;
            this.label_AC_text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_AC_text2.Location = new System.Drawing.Point(12, 135);
            this.label_AC_text2.Name = "label_AC_text2";
            this.label_AC_text2.Size = new System.Drawing.Size(95, 16);
            this.label_AC_text2.TabIndex = 67;
            this.label_AC_text2.Text = "Изменить на:";
            this.label_AC_text2.Click += new System.EventHandler(this.label_AC_text2_Click);
            // 
            // checkBox_AC
            // 
            this.checkBox_AC.AutoSize = true;
            this.checkBox_AC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_AC.Location = new System.Drawing.Point(12, 160);
            this.checkBox_AC.Name = "checkBox_AC";
            this.checkBox_AC.Size = new System.Drawing.Size(141, 20);
            this.checkBox_AC.TabIndex = 1;
            this.checkBox_AC.Text = "Новый тип учёта ";
            this.checkBox_AC.UseVisualStyleBackColor = true;
            this.checkBox_AC.CheckedChanged += new System.EventHandler(this.checkBox_AC_CheckedChanged);
            // 
            // label_AC_old
            // 
            this.label_AC_old.AutoSize = true;
            this.label_AC_old.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_AC_old.ForeColor = System.Drawing.Color.Maroon;
            this.label_AC_old.Location = new System.Drawing.Point(188, 110);
            this.label_AC_old.Name = "label_AC_old";
            this.label_AC_old.Size = new System.Drawing.Size(51, 16);
            this.label_AC_old.TabIndex = 68;
            this.label_AC_old.Text = "label1";
            this.label_AC_old.Click += new System.EventHandler(this.label_AC_old_Click);
            // 
            // textBox_AC
            // 
            this.textBox_AC.Enabled = false;
            this.textBox_AC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_AC.Location = new System.Drawing.Point(188, 160);
            this.textBox_AC.Name = "textBox_AC";
            this.textBox_AC.Size = new System.Drawing.Size(250, 22);
            this.textBox_AC.TabIndex = 69;
            this.textBox_AC.TextChanged += new System.EventHandler(this.textBox_AC_TextChanged);
            // 
            // label_SN
            // 
            this.label_SN.BackColor = System.Drawing.Color.Silver;
            this.label_SN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.7F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_SN.Location = new System.Drawing.Point(10, 315);
            this.label_SN.Name = "label_SN";
            this.label_SN.Size = new System.Drawing.Size(449, 22);
            this.label_SN.TabIndex = 70;
            this.label_SN.Text = "Серийный номер";
            this.label_SN.Click += new System.EventHandler(this.label_SN_Click);
            // 
            // label_SN_text1
            // 
            this.label_SN_text1.AutoSize = true;
            this.label_SN_text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_SN_text1.Location = new System.Drawing.Point(12, 345);
            this.label_SN_text1.Name = "label_SN_text1";
            this.label_SN_text1.Size = new System.Drawing.Size(138, 16);
            this.label_SN_text1.TabIndex = 71;
            this.label_SN_text1.Text = "Текущее значение :";
            this.label_SN_text1.Click += new System.EventHandler(this.label_SN_text1_Click);
            // 
            // label_SN_text2
            // 
            this.label_SN_text2.AutoSize = true;
            this.label_SN_text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_SN_text2.Location = new System.Drawing.Point(12, 370);
            this.label_SN_text2.Name = "label_SN_text2";
            this.label_SN_text2.Size = new System.Drawing.Size(95, 16);
            this.label_SN_text2.TabIndex = 72;
            this.label_SN_text2.Text = "Изменить на:";
            this.label_SN_text2.Click += new System.EventHandler(this.label_SN_text2_Click);
            // 
            // label_SN_old
            // 
            this.label_SN_old.AutoSize = true;
            this.label_SN_old.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_SN_old.ForeColor = System.Drawing.Color.Maroon;
            this.label_SN_old.Location = new System.Drawing.Point(188, 345);
            this.label_SN_old.Name = "label_SN_old";
            this.label_SN_old.Size = new System.Drawing.Size(51, 16);
            this.label_SN_old.TabIndex = 73;
            this.label_SN_old.Text = "label1";
            this.label_SN_old.Click += new System.EventHandler(this.label_SN_old_Click);
            // 
            // textBox_SN
            // 
            this.textBox_SN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_SN.Location = new System.Drawing.Point(188, 370);
            this.textBox_SN.Name = "textBox_SN";
            this.textBox_SN.Size = new System.Drawing.Size(250, 22);
            this.textBox_SN.TabIndex = 74;
            this.textBox_SN.TextChanged += new System.EventHandler(this.textBox_SN_TextChanged);
            // 
            // label_model
            // 
            this.label_model.BackColor = System.Drawing.Color.Silver;
            this.label_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.7F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_model.Location = new System.Drawing.Point(10, 420);
            this.label_model.Name = "label_model";
            this.label_model.Size = new System.Drawing.Size(449, 22);
            this.label_model.TabIndex = 75;
            this.label_model.Text = "Модель";
            this.label_model.Click += new System.EventHandler(this.label_model_Click);
            // 
            // label_model_text1
            // 
            this.label_model_text1.AutoSize = true;
            this.label_model_text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_model_text1.Location = new System.Drawing.Point(12, 450);
            this.label_model_text1.Name = "label_model_text1";
            this.label_model_text1.Size = new System.Drawing.Size(138, 16);
            this.label_model_text1.TabIndex = 76;
            this.label_model_text1.Text = "Текущее значение :";
            this.label_model_text1.Click += new System.EventHandler(this.label_model_text1_Click);
            // 
            // label_model_text2
            // 
            this.label_model_text2.AutoSize = true;
            this.label_model_text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_model_text2.Location = new System.Drawing.Point(12, 475);
            this.label_model_text2.Name = "label_model_text2";
            this.label_model_text2.Size = new System.Drawing.Size(95, 16);
            this.label_model_text2.TabIndex = 77;
            this.label_model_text2.Text = "Изменить на:";
            this.label_model_text2.Click += new System.EventHandler(this.label_model_text2_Click);
            // 
            // label_model_old
            // 
            this.label_model_old.AutoSize = true;
            this.label_model_old.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_model_old.ForeColor = System.Drawing.Color.Maroon;
            this.label_model_old.Location = new System.Drawing.Point(188, 450);
            this.label_model_old.Name = "label_model_old";
            this.label_model_old.Size = new System.Drawing.Size(51, 16);
            this.label_model_old.TabIndex = 78;
            this.label_model_old.Text = "label1";
            this.label_model_old.Click += new System.EventHandler(this.label_model_old_Click);
            // 
            // textBox_model
            // 
            this.textBox_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_model.Location = new System.Drawing.Point(188, 475);
            this.textBox_model.Name = "textBox_model";
            this.textBox_model.Size = new System.Drawing.Size(250, 22);
            this.textBox_model.TabIndex = 79;
            this.textBox_model.TextChanged += new System.EventHandler(this.textBox_model_TextChanged);
            // 
            // comboBox_device
            // 
            this.comboBox_device.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_device.FormattingEnabled = true;
            this.comboBox_device.Location = new System.Drawing.Point(188, 575);
            this.comboBox_device.Name = "comboBox_device";
            this.comboBox_device.Size = new System.Drawing.Size(250, 24);
            this.comboBox_device.TabIndex = 80;
            this.comboBox_device.SelectedIndexChanged += new System.EventHandler(this.comboBox_device_SelectedIndexChanged);
            // 
            // label_device
            // 
            this.label_device.BackColor = System.Drawing.Color.Silver;
            this.label_device.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.7F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_device.Location = new System.Drawing.Point(10, 525);
            this.label_device.Name = "label_device";
            this.label_device.Size = new System.Drawing.Size(449, 22);
            this.label_device.TabIndex = 82;
            this.label_device.Text = "Тип оборудования";
            this.label_device.Click += new System.EventHandler(this.label_device_Click);
            // 
            // label_device_text1
            // 
            this.label_device_text1.AutoSize = true;
            this.label_device_text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_device_text1.Location = new System.Drawing.Point(12, 555);
            this.label_device_text1.Name = "label_device_text1";
            this.label_device_text1.Size = new System.Drawing.Size(138, 16);
            this.label_device_text1.TabIndex = 83;
            this.label_device_text1.Text = "Текущее значение :";
            this.label_device_text1.Click += new System.EventHandler(this.label_device_text1_Click);
            // 
            // label_device_text2
            // 
            this.label_device_text2.AutoSize = true;
            this.label_device_text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_device_text2.Location = new System.Drawing.Point(12, 580);
            this.label_device_text2.Name = "label_device_text2";
            this.label_device_text2.Size = new System.Drawing.Size(95, 16);
            this.label_device_text2.TabIndex = 84;
            this.label_device_text2.Text = "Изменить на:";
            this.label_device_text2.Click += new System.EventHandler(this.label_device_text2_Click);
            // 
            // checkBox_device
            // 
            this.checkBox_device.AutoSize = true;
            this.checkBox_device.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_device.Location = new System.Drawing.Point(12, 605);
            this.checkBox_device.Name = "checkBox_device";
            this.checkBox_device.Size = new System.Drawing.Size(134, 20);
            this.checkBox_device.TabIndex = 81;
            this.checkBox_device.Text = "Новый тип обор.";
            this.checkBox_device.UseVisualStyleBackColor = true;
            this.checkBox_device.CheckedChanged += new System.EventHandler(this.checkBox_device_CheckedChanged);
            // 
            // label_device_old
            // 
            this.label_device_old.AutoSize = true;
            this.label_device_old.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_device_old.ForeColor = System.Drawing.Color.Maroon;
            this.label_device_old.Location = new System.Drawing.Point(188, 555);
            this.label_device_old.Name = "label_device_old";
            this.label_device_old.Size = new System.Drawing.Size(45, 16);
            this.label_device_old.TabIndex = 85;
            this.label_device_old.Text = "label1";
            this.label_device_old.Click += new System.EventHandler(this.label_device_old_Click);
            // 
            // textBox_device
            // 
            this.textBox_device.Enabled = false;
            this.textBox_device.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_device.Location = new System.Drawing.Point(188, 605);
            this.textBox_device.Name = "textBox_device";
            this.textBox_device.Size = new System.Drawing.Size(250, 22);
            this.textBox_device.TabIndex = 86;
            this.textBox_device.TextChanged += new System.EventHandler(this.textBox_device_TextChanged);
            // 
            // comboBox_jira
            // 
            this.comboBox_jira.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_jira.FormattingEnabled = true;
            this.comboBox_jira.Location = new System.Drawing.Point(188, 705);
            this.comboBox_jira.Name = "comboBox_jira";
            this.comboBox_jira.Size = new System.Drawing.Size(250, 24);
            this.comboBox_jira.TabIndex = 87;
            this.comboBox_jira.SelectedIndexChanged += new System.EventHandler(this.comboBox_jira_SelectedIndexChanged);
            // 
            // label_Jira
            // 
            this.label_Jira.BackColor = System.Drawing.Color.Silver;
            this.label_Jira.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.7F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Jira.Location = new System.Drawing.Point(10, 655);
            this.label_Jira.Name = "label_Jira";
            this.label_Jira.Size = new System.Drawing.Size(449, 22);
            this.label_Jira.TabIndex = 89;
            this.label_Jira.Text = "Задача в JIRA";
            this.label_Jira.Click += new System.EventHandler(this.label_Jira_Click);
            // 
            // label_Jira_text1
            // 
            this.label_Jira_text1.AutoSize = true;
            this.label_Jira_text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Jira_text1.Location = new System.Drawing.Point(12, 685);
            this.label_Jira_text1.Name = "label_Jira_text1";
            this.label_Jira_text1.Size = new System.Drawing.Size(138, 16);
            this.label_Jira_text1.TabIndex = 90;
            this.label_Jira_text1.Text = "Текущее значение :";
            this.label_Jira_text1.Click += new System.EventHandler(this.label_Jira_text1_Click);
            // 
            // label_Jira_text2
            // 
            this.label_Jira_text2.AutoSize = true;
            this.label_Jira_text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Jira_text2.Location = new System.Drawing.Point(12, 710);
            this.label_Jira_text2.Name = "label_Jira_text2";
            this.label_Jira_text2.Size = new System.Drawing.Size(95, 16);
            this.label_Jira_text2.TabIndex = 91;
            this.label_Jira_text2.Text = "Изменить на:";
            this.label_Jira_text2.Click += new System.EventHandler(this.label_Jira_text2_Click);
            // 
            // checkBox_jira
            // 
            this.checkBox_jira.AutoSize = true;
            this.checkBox_jira.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_jira.Location = new System.Drawing.Point(12, 735);
            this.checkBox_jira.Name = "checkBox_jira";
            this.checkBox_jira.Size = new System.Drawing.Size(119, 20);
            this.checkBox_jira.TabIndex = 88;
            this.checkBox_jira.Text = "Новая задача";
            this.checkBox_jira.UseVisualStyleBackColor = true;
            this.checkBox_jira.CheckedChanged += new System.EventHandler(this.checkBox_jira_CheckedChanged);
            // 
            // label_Jira_old
            // 
            this.label_Jira_old.AutoSize = true;
            this.label_Jira_old.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Jira_old.ForeColor = System.Drawing.Color.Maroon;
            this.label_Jira_old.Location = new System.Drawing.Point(188, 685);
            this.label_Jira_old.Name = "label_Jira_old";
            this.label_Jira_old.Size = new System.Drawing.Size(45, 16);
            this.label_Jira_old.TabIndex = 92;
            this.label_Jira_old.Text = "label1";
            this.label_Jira_old.Click += new System.EventHandler(this.label_Jira_old_Click);
            // 
            // textBox_jira
            // 
            this.textBox_jira.Enabled = false;
            this.textBox_jira.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_jira.Location = new System.Drawing.Point(188, 735);
            this.textBox_jira.Name = "textBox_jira";
            this.textBox_jira.Size = new System.Drawing.Size(250, 22);
            this.textBox_jira.TabIndex = 93;
            this.textBox_jira.TextChanged += new System.EventHandler(this.textBox_jira_TextChanged);
            // 
            // Metka
            // 
            this.Metka.AutoSize = true;
            this.Metka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Metka.Location = new System.Drawing.Point(167, 735);
            this.Metka.Name = "Metka";
            this.Metka.Size = new System.Drawing.Size(0, 20);
            this.Metka.TabIndex = 94;
            this.Metka.Click += new System.EventHandler(this.Metka_Click);
            // 
            // panel_View
            // 
            this.panel_View.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_View.AutoScroll = true;
            this.panel_View.BackColor = System.Drawing.SystemColors.Control;
            this.panel_View.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_View.Controls.Add(this.label_date);
            this.panel_View.Controls.Add(this.label_ID);
            this.panel_View.Controls.Add(this.label_date_test);
            this.panel_View.Controls.Add(this.label_ID_text);
            this.panel_View.Controls.Add(this.Metka);
            this.panel_View.Controls.Add(this.textBox_jira);
            this.panel_View.Controls.Add(this.label_Jira_old);
            this.panel_View.Controls.Add(this.checkBox_jira);
            this.panel_View.Controls.Add(this.label_Jira_text2);
            this.panel_View.Controls.Add(this.label_Jira_text1);
            this.panel_View.Controls.Add(this.label_Jira);
            this.panel_View.Controls.Add(this.comboBox_jira);
            this.panel_View.Controls.Add(this.textBox_device);
            this.panel_View.Controls.Add(this.label_device_old);
            this.panel_View.Controls.Add(this.checkBox_device);
            this.panel_View.Controls.Add(this.label_device_text2);
            this.panel_View.Controls.Add(this.label_device_text1);
            this.panel_View.Controls.Add(this.label_device);
            this.panel_View.Controls.Add(this.comboBox_device);
            this.panel_View.Controls.Add(this.textBox_model);
            this.panel_View.Controls.Add(this.label_model_old);
            this.panel_View.Controls.Add(this.label_model_text2);
            this.panel_View.Controls.Add(this.label_model_text1);
            this.panel_View.Controls.Add(this.label_model);
            this.panel_View.Controls.Add(this.textBox_SN);
            this.panel_View.Controls.Add(this.label_SN_old);
            this.panel_View.Controls.Add(this.label_SN_text2);
            this.panel_View.Controls.Add(this.label_SN_text1);
            this.panel_View.Controls.Add(this.label_SN);
            this.panel_View.Controls.Add(this.textBox_AC);
            this.panel_View.Controls.Add(this.label_AC_old);
            this.panel_View.Controls.Add(this.checkBox_AC);
            this.panel_View.Controls.Add(this.label_AC_text2);
            this.panel_View.Controls.Add(this.label_AC_text1);
            this.panel_View.Controls.Add(this.label_AC);
            this.panel_View.Controls.Add(this.textBox_inv);
            this.panel_View.Controls.Add(this.label_inv_old);
            this.panel_View.Controls.Add(this.label__inv_text2);
            this.panel_View.Controls.Add(this.comboBox_AC);
            this.panel_View.Controls.Add(this.label_inv_text1);
            this.panel_View.Controls.Add(this.label_Inv);
            this.panel_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_View.Location = new System.Drawing.Point(0, 0);
            this.panel_View.MinimumSize = new System.Drawing.Size(400, 71);
            this.panel_View.Name = "panel_View";
            this.panel_View.Padding = new System.Windows.Forms.Padding(5);
            this.panel_View.Size = new System.Drawing.Size(491, 767);
            this.panel_View.TabIndex = 55;
            this.panel_View.TabStop = true;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_date.ForeColor = System.Drawing.Color.Maroon;
            this.label_date.Location = new System.Drawing.Point(160, 45);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(66, 24);
            this.label_date.TabIndex = 96;
            this.label_date.Text = "label1";
            this.label_date.Click += new System.EventHandler(this.label_date_Click);
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ID.ForeColor = System.Drawing.Color.Maroon;
            this.label_ID.Location = new System.Drawing.Point(160, 11);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(66, 24);
            this.label_ID.TabIndex = 96;
            this.label_ID.Text = "label1";
            this.label_ID.Click += new System.EventHandler(this.label_ID_Click);
            // 
            // label_date_test
            // 
            this.label_date_test.AutoSize = true;
            this.label_date_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_date_test.Location = new System.Drawing.Point(8, 42);
            this.label_date_test.Name = "label_date_test";
            this.label_date_test.Size = new System.Drawing.Size(122, 24);
            this.label_date_test.TabIndex = 95;
            this.label_date_test.Text = "Дата в базе:";
            this.label_date_test.Click += new System.EventHandler(this.label_date_test_Click);
            // 
            // label_ID_text
            // 
            this.label_ID_text.AutoSize = true;
            this.label_ID_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ID_text.Location = new System.Drawing.Point(8, 7);
            this.label_ID_text.Name = "label_ID_text";
            this.label_ID_text.Size = new System.Drawing.Size(105, 24);
            this.label_ID_text.TabIndex = 95;
            this.label_ID_text.Text = "ID  в базе :";
            this.label_ID_text.Click += new System.EventHandler(this.label_ID_text_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.button_OK);
            this.flowLayoutPanel1.Controls.Add(this.button_cancel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 773);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(491, 55);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // button_OK
            // 
            this.button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_OK.Location = new System.Drawing.Point(378, 5);
            this.button_OK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(100, 35);
            this.button_OK.TabIndex = 4;
            this.button_OK.Text = "Ok";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.Location = new System.Drawing.Point(272, 5);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 35);
            this.button_cancel.TabIndex = 5;
            this.button_cancel.Text = "Отмена ";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // changeFormOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 828);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel_View);
            this.Name = "changeFormOne";
            this.Text = "change";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.changeFormOne_FormClosed);
            this.panel_View.ResumeLayout(false);
            this.panel_View.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_Inv;
        private System.Windows.Forms.Label label_inv_text1;
        private System.Windows.Forms.ComboBox comboBox_AC;
        private System.Windows.Forms.Label label__inv_text2;
        private System.Windows.Forms.Label label_inv_old;
        private System.Windows.Forms.TextBox textBox_inv;
        private System.Windows.Forms.Label label_AC;
        private System.Windows.Forms.Label label_AC_text1;
        private System.Windows.Forms.Label label_AC_text2;
        private System.Windows.Forms.CheckBox checkBox_AC;
        private System.Windows.Forms.Label label_AC_old;
        private System.Windows.Forms.TextBox textBox_AC;
        private System.Windows.Forms.Label label_SN;
        private System.Windows.Forms.Label label_SN_text1;
        private System.Windows.Forms.Label label_SN_text2;
        private System.Windows.Forms.Label label_SN_old;
        private System.Windows.Forms.TextBox textBox_SN;
        private System.Windows.Forms.Label label_model;
        private System.Windows.Forms.Label label_model_text1;
        private System.Windows.Forms.Label label_model_text2;
        private System.Windows.Forms.Label label_model_old;
        private System.Windows.Forms.TextBox textBox_model;
        private System.Windows.Forms.ComboBox comboBox_device;
        private System.Windows.Forms.Label label_device;
        private System.Windows.Forms.Label label_device_text1;
        private System.Windows.Forms.Label label_device_text2;
        private System.Windows.Forms.CheckBox checkBox_device;
        private System.Windows.Forms.Label label_device_old;
        private System.Windows.Forms.TextBox textBox_device;
        private System.Windows.Forms.ComboBox comboBox_jira;
        private System.Windows.Forms.Label label_Jira;
        private System.Windows.Forms.Label label_Jira_text1;
        private System.Windows.Forms.Label label_Jira_text2;
        private System.Windows.Forms.CheckBox checkBox_jira;
        private System.Windows.Forms.Label label_Jira_old;
        private System.Windows.Forms.TextBox textBox_jira;
        private System.Windows.Forms.Label Metka;
        private System.Windows.Forms.Panel panel_View;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_date_test;
        private System.Windows.Forms.Label label_ID_text;
    }
}