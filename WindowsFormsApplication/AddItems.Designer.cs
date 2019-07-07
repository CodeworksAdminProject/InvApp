namespace WindowsFormsApplication
{
    partial class AddItems
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
            this.checkBox_SN = new System.Windows.Forms.CheckBox();
            this.textBox_Sum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_NumberInv = new System.Windows.Forms.TextBox();
            this.label_NumberInv = new System.Windows.Forms.Label();
            this.groupBox_TypeAccоunt = new System.Windows.Forms.GroupBox();
            this.textBox_TypeAccount = new System.Windows.Forms.TextBox();
            this.checkBox_Account = new System.Windows.Forms.CheckBox();
            this.comboBox_TypeAccount = new System.Windows.Forms.ComboBox();
            this.groupBox_TypeDevice = new System.Windows.Forms.GroupBox();
            this.textBox_TypeDevice = new System.Windows.Forms.TextBox();
            this.checkBox_TypeDevice = new System.Windows.Forms.CheckBox();
            this.comboBox_TypeDevice = new System.Windows.Forms.ComboBox();
            this.groupBox_LanName = new System.Windows.Forms.GroupBox();
            this.textBox_LanName = new System.Windows.Forms.TextBox();
            this.checkBox_LanName = new System.Windows.Forms.CheckBox();
            this.comboBox_LanName = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.groupBox_Model = new System.Windows.Forms.GroupBox();
            this.textBox_Model = new System.Windows.Forms.TextBox();
            this.groupBox_NuberSN = new System.Windows.Forms.GroupBox();
            this.textBox_NumberSN = new System.Windows.Forms.TextBox();
            this.groupBox_Responsible = new System.Windows.Forms.GroupBox();
            this.textBox_Responsible = new System.Windows.Forms.TextBox();
            this.checkBox_Responsible = new System.Windows.Forms.CheckBox();
            this.comboBox_Responsible = new System.Windows.Forms.ComboBox();
            this.groupBox_Jira = new System.Windows.Forms.GroupBox();
            this.textBox_jira = new System.Windows.Forms.TextBox();
            this.checkBox_Jira = new System.Windows.Forms.CheckBox();
            this.comboBox_Jira = new System.Windows.Forms.ComboBox();
            this.Location = new System.Windows.Forms.GroupBox();
            this.textBox_Room = new System.Windows.Forms.TextBox();
            this.textBox_Floor = new System.Windows.Forms.TextBox();
            this.checkBox_Room = new System.Windows.Forms.CheckBox();
            this.checkBox_Floor = new System.Windows.Forms.CheckBox();
            this.comboBox_Room = new System.Windows.Forms.ComboBox();
            this.comboBox_Floor = new System.Windows.Forms.ComboBox();
            this.groupBox_room = new System.Windows.Forms.GroupBox();
            this.groupBox_TypeAccоunt.SuspendLayout();
            this.groupBox_TypeDevice.SuspendLayout();
            this.groupBox_LanName.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_Model.SuspendLayout();
            this.groupBox_NuberSN.SuspendLayout();
            this.groupBox_Responsible.SuspendLayout();
            this.groupBox_Jira.SuspendLayout();
            this.Location.SuspendLayout();
            this.groupBox_room.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_SN
            // 
            this.checkBox_SN.AutoSize = true;
            this.checkBox_SN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_SN.Location = new System.Drawing.Point(756, 5);
            this.checkBox_SN.Name = "checkBox_SN";
            this.checkBox_SN.Size = new System.Drawing.Size(114, 24);
            this.checkBox_SN.TabIndex = 18;
            this.checkBox_SN.Text = "Разные S/N";
            this.checkBox_SN.UseVisualStyleBackColor = true;
            this.checkBox_SN.CheckedChanged += new System.EventHandler(this.checkBox_SN_CheckedChanged);
            // 
            // textBox_Sum
            // 
            this.textBox_Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Sum.Location = new System.Drawing.Point(655, 3);
            this.textBox_Sum.Name = "textBox_Sum";
            this.textBox_Sum.Size = new System.Drawing.Size(55, 26);
            this.textBox_Sum.TabIndex = 17;
            this.textBox_Sum.Text = "1";
            this.textBox_Sum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NumberInv_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(481, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Количество элементов :";
            // 
            // textBox_NumberInv
            // 
            this.textBox_NumberInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_NumberInv.Location = new System.Drawing.Point(247, 3);
            this.textBox_NumberInv.Name = "textBox_NumberInv";
            this.textBox_NumberInv.Size = new System.Drawing.Size(209, 26);
            this.textBox_NumberInv.TabIndex = 15;
            this.textBox_NumberInv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NumberInv_KeyPress);
            // 
            // label_NumberInv
            // 
            this.label_NumberInv.AutoSize = true;
            this.label_NumberInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_NumberInv.Location = new System.Drawing.Point(12, 9);
            this.label_NumberInv.Name = "label_NumberInv";
            this.label_NumberInv.Size = new System.Drawing.Size(229, 17);
            this.label_NumberInv.TabIndex = 14;
            this.label_NumberInv.Text = "Начиная с инвентарного номера:";
            // 
            // groupBox_TypeAccоunt
            // 
            this.groupBox_TypeAccоunt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_TypeAccоunt.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_TypeAccоunt.Controls.Add(this.textBox_TypeAccount);
            this.groupBox_TypeAccоunt.Controls.Add(this.checkBox_Account);
            this.groupBox_TypeAccоunt.Controls.Add(this.comboBox_TypeAccount);
            this.groupBox_TypeAccоunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_TypeAccоunt.Location = new System.Drawing.Point(12, 45);
            this.groupBox_TypeAccоunt.Name = "groupBox_TypeAccоunt";
            this.groupBox_TypeAccоunt.Size = new System.Drawing.Size(270, 110);
            this.groupBox_TypeAccоunt.TabIndex = 19;
            this.groupBox_TypeAccоunt.TabStop = false;
            this.groupBox_TypeAccоunt.Text = "Вид учета";
            // 
            // textBox_TypeAccount
            // 
            this.textBox_TypeAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_TypeAccount.Enabled = false;
            this.textBox_TypeAccount.Location = new System.Drawing.Point(5, 82);
            this.textBox_TypeAccount.Name = "textBox_TypeAccount";
            this.textBox_TypeAccount.Size = new System.Drawing.Size(259, 23);
            this.textBox_TypeAccount.TabIndex = 2;
            // 
            // checkBox_Account
            // 
            this.checkBox_Account.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Account.AutoSize = true;
            this.checkBox_Account.Location = new System.Drawing.Point(67, 55);
            this.checkBox_Account.Name = "checkBox_Account";
            this.checkBox_Account.Size = new System.Drawing.Size(139, 21);
            this.checkBox_Account.TabIndex = 1;
            this.checkBox_Account.Text = "Новый вид учета";
            this.checkBox_Account.UseVisualStyleBackColor = true;
            this.checkBox_Account.CheckedChanged += new System.EventHandler(this.checkBox_Account_CheckedChanged);
            // 
            // comboBox_TypeAccount
            // 
            this.comboBox_TypeAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_TypeAccount.FormattingEnabled = true;
            this.comboBox_TypeAccount.Location = new System.Drawing.Point(5, 25);
            this.comboBox_TypeAccount.Name = "comboBox_TypeAccount";
            this.comboBox_TypeAccount.Size = new System.Drawing.Size(259, 24);
            this.comboBox_TypeAccount.TabIndex = 0;
            // 
            // groupBox_TypeDevice
            // 
            this.groupBox_TypeDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_TypeDevice.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_TypeDevice.Controls.Add(this.textBox_TypeDevice);
            this.groupBox_TypeDevice.Controls.Add(this.checkBox_TypeDevice);
            this.groupBox_TypeDevice.Controls.Add(this.comboBox_TypeDevice);
            this.groupBox_TypeDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_TypeDevice.Location = new System.Drawing.Point(299, 161);
            this.groupBox_TypeDevice.Name = "groupBox_TypeDevice";
            this.groupBox_TypeDevice.Size = new System.Drawing.Size(270, 110);
            this.groupBox_TypeDevice.TabIndex = 20;
            this.groupBox_TypeDevice.TabStop = false;
            this.groupBox_TypeDevice.Text = "Вид оборудования ";
            // 
            // textBox_TypeDevice
            // 
            this.textBox_TypeDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_TypeDevice.Enabled = false;
            this.textBox_TypeDevice.Location = new System.Drawing.Point(6, 81);
            this.textBox_TypeDevice.Name = "textBox_TypeDevice";
            this.textBox_TypeDevice.Size = new System.Drawing.Size(258, 23);
            this.textBox_TypeDevice.TabIndex = 2;
            // 
            // checkBox_TypeDevice
            // 
            this.checkBox_TypeDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_TypeDevice.AutoSize = true;
            this.checkBox_TypeDevice.Location = new System.Drawing.Point(36, 54);
            this.checkBox_TypeDevice.Name = "checkBox_TypeDevice";
            this.checkBox_TypeDevice.Size = new System.Drawing.Size(203, 21);
            this.checkBox_TypeDevice.TabIndex = 1;
            this.checkBox_TypeDevice.Text = "Новый вид оборудования  ";
            this.checkBox_TypeDevice.UseVisualStyleBackColor = true;
            this.checkBox_TypeDevice.CheckedChanged += new System.EventHandler(this.checkBox_TypeDevice_CheckedChanged);
            // 
            // comboBox_TypeDevice
            // 
            this.comboBox_TypeDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_TypeDevice.FormattingEnabled = true;
            this.comboBox_TypeDevice.Location = new System.Drawing.Point(6, 22);
            this.comboBox_TypeDevice.Name = "comboBox_TypeDevice";
            this.comboBox_TypeDevice.Size = new System.Drawing.Size(258, 24);
            this.comboBox_TypeDevice.TabIndex = 0;
            // 
            // groupBox_LanName
            // 
            this.groupBox_LanName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_LanName.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_LanName.Controls.Add(this.textBox_LanName);
            this.groupBox_LanName.Controls.Add(this.checkBox_LanName);
            this.groupBox_LanName.Controls.Add(this.comboBox_LanName);
            this.groupBox_LanName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_LanName.Location = new System.Drawing.Point(586, 161);
            this.groupBox_LanName.Name = "groupBox_LanName";
            this.groupBox_LanName.Size = new System.Drawing.Size(270, 110);
            this.groupBox_LanName.TabIndex = 21;
            this.groupBox_LanName.TabStop = false;
            this.groupBox_LanName.Text = "Название в сети";
            // 
            // textBox_LanName
            // 
            this.textBox_LanName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_LanName.Enabled = false;
            this.textBox_LanName.Location = new System.Drawing.Point(6, 81);
            this.textBox_LanName.Name = "textBox_LanName";
            this.textBox_LanName.Size = new System.Drawing.Size(258, 23);
            this.textBox_LanName.TabIndex = 5;
            // 
            // checkBox_LanName
            // 
            this.checkBox_LanName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_LanName.AutoSize = true;
            this.checkBox_LanName.Location = new System.Drawing.Point(40, 52);
            this.checkBox_LanName.Name = "checkBox_LanName";
            this.checkBox_LanName.Size = new System.Drawing.Size(179, 21);
            this.checkBox_LanName.TabIndex = 4;
            this.checkBox_LanName.Text = "Новое название в сети";
            this.checkBox_LanName.UseVisualStyleBackColor = true;
            this.checkBox_LanName.CheckedChanged += new System.EventHandler(this.checkBox_LanName_CheckedChanged);
            // 
            // comboBox_LanName
            // 
            this.comboBox_LanName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_LanName.FormattingEnabled = true;
            this.comboBox_LanName.Location = new System.Drawing.Point(6, 22);
            this.comboBox_LanName.Name = "comboBox_LanName";
            this.comboBox_LanName.Size = new System.Drawing.Size(258, 24);
            this.comboBox_LanName.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button_OK, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_Cancel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 345);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(874, 53);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // button_OK
            // 
            this.button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_OK.Location = new System.Drawing.Point(670, 3);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(201, 45);
            this.button_OK.TabIndex = 6;
            this.button_OK.Text = "Внести в базу ";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Cancel.Location = new System.Drawing.Point(3, 3);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(174, 45);
            this.button_Cancel.TabIndex = 5;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // groupBox_Model
            // 
            this.groupBox_Model.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Model.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_Model.Controls.Add(this.textBox_Model);
            this.groupBox_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Model.Location = new System.Drawing.Point(451, 277);
            this.groupBox_Model.Name = "groupBox_Model";
            this.groupBox_Model.Size = new System.Drawing.Size(405, 50);
            this.groupBox_Model.TabIndex = 23;
            this.groupBox_Model.TabStop = false;
            this.groupBox_Model.Text = "Модель";
            // 
            // textBox_Model
            // 
            this.textBox_Model.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Model.Location = new System.Drawing.Point(7, 17);
            this.textBox_Model.Name = "textBox_Model";
            this.textBox_Model.Size = new System.Drawing.Size(392, 26);
            this.textBox_Model.TabIndex = 2;
            // 
            // groupBox_NuberSN
            // 
            this.groupBox_NuberSN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_NuberSN.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_NuberSN.Controls.Add(this.textBox_NumberSN);
            this.groupBox_NuberSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_NuberSN.Location = new System.Drawing.Point(12, 277);
            this.groupBox_NuberSN.Name = "groupBox_NuberSN";
            this.groupBox_NuberSN.Size = new System.Drawing.Size(405, 50);
            this.groupBox_NuberSN.TabIndex = 24;
            this.groupBox_NuberSN.TabStop = false;
            this.groupBox_NuberSN.Text = "Серийный номер";
            // 
            // textBox_NumberSN
            // 
            this.textBox_NumberSN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_NumberSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_NumberSN.Location = new System.Drawing.Point(5, 20);
            this.textBox_NumberSN.Name = "textBox_NumberSN";
            this.textBox_NumberSN.Size = new System.Drawing.Size(394, 26);
            this.textBox_NumberSN.TabIndex = 2;
            // 
            // groupBox_Responsible
            // 
            this.groupBox_Responsible.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Responsible.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_Responsible.Controls.Add(this.textBox_Responsible);
            this.groupBox_Responsible.Controls.Add(this.checkBox_Responsible);
            this.groupBox_Responsible.Controls.Add(this.comboBox_Responsible);
            this.groupBox_Responsible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Responsible.Location = new System.Drawing.Point(12, 161);
            this.groupBox_Responsible.Name = "groupBox_Responsible";
            this.groupBox_Responsible.Size = new System.Drawing.Size(270, 110);
            this.groupBox_Responsible.TabIndex = 25;
            this.groupBox_Responsible.TabStop = false;
            this.groupBox_Responsible.Text = "Ответственный";
            // 
            // textBox_Responsible
            // 
            this.textBox_Responsible.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Responsible.Enabled = false;
            this.textBox_Responsible.Location = new System.Drawing.Point(6, 81);
            this.textBox_Responsible.Name = "textBox_Responsible";
            this.textBox_Responsible.Size = new System.Drawing.Size(258, 23);
            this.textBox_Responsible.TabIndex = 5;
            // 
            // checkBox_Responsible
            // 
            this.checkBox_Responsible.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Responsible.AutoSize = true;
            this.checkBox_Responsible.Location = new System.Drawing.Point(38, 51);
            this.checkBox_Responsible.Name = "checkBox_Responsible";
            this.checkBox_Responsible.Size = new System.Drawing.Size(206, 21);
            this.checkBox_Responsible.TabIndex = 4;
            this.checkBox_Responsible.Text = "Новое ответственное лицо";
            this.checkBox_Responsible.UseVisualStyleBackColor = true;
            this.checkBox_Responsible.CheckedChanged += new System.EventHandler(this.checkBox_Responsible_CheckedChanged);
            // 
            // comboBox_Responsible
            // 
            this.comboBox_Responsible.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Responsible.FormattingEnabled = true;
            this.comboBox_Responsible.Location = new System.Drawing.Point(6, 21);
            this.comboBox_Responsible.Name = "comboBox_Responsible";
            this.comboBox_Responsible.Size = new System.Drawing.Size(258, 24);
            this.comboBox_Responsible.TabIndex = 3;
            // 
            // groupBox_Jira
            // 
            this.groupBox_Jira.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Jira.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_Jira.Controls.Add(this.textBox_jira);
            this.groupBox_Jira.Controls.Add(this.checkBox_Jira);
            this.groupBox_Jira.Controls.Add(this.comboBox_Jira);
            this.groupBox_Jira.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Jira.Location = new System.Drawing.Point(299, 45);
            this.groupBox_Jira.Name = "groupBox_Jira";
            this.groupBox_Jira.Size = new System.Drawing.Size(270, 110);
            this.groupBox_Jira.TabIndex = 26;
            this.groupBox_Jira.TabStop = false;
            this.groupBox_Jira.Text = "JIRA";
            // 
            // textBox_jira
            // 
            this.textBox_jira.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_jira.Enabled = false;
            this.textBox_jira.Location = new System.Drawing.Point(6, 81);
            this.textBox_jira.Name = "textBox_jira";
            this.textBox_jira.Size = new System.Drawing.Size(258, 23);
            this.textBox_jira.TabIndex = 5;
            // 
            // checkBox_Jira
            // 
            this.checkBox_Jira.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Jira.AutoSize = true;
            this.checkBox_Jira.Location = new System.Drawing.Point(61, 52);
            this.checkBox_Jira.Name = "checkBox_Jira";
            this.checkBox_Jira.Size = new System.Drawing.Size(152, 21);
            this.checkBox_Jira.TabIndex = 4;
            this.checkBox_Jira.Text = "Новая задача JIRA";
            this.checkBox_Jira.UseVisualStyleBackColor = true;
            this.checkBox_Jira.CheckedChanged += new System.EventHandler(this.checkBox_Jira_CheckedChanged);
            // 
            // comboBox_Jira
            // 
            this.comboBox_Jira.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Jira.FormattingEnabled = true;
            this.comboBox_Jira.Location = new System.Drawing.Point(6, 22);
            this.comboBox_Jira.Name = "comboBox_Jira";
            this.comboBox_Jira.Size = new System.Drawing.Size(258, 24);
            this.comboBox_Jira.TabIndex = 3;
            // 
            // Location
            // 
            this.Location.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Location.BackColor = System.Drawing.SystemColors.Control;
            this.Location.Controls.Add(this.textBox_Floor);
            this.Location.Controls.Add(this.checkBox_Floor);
            this.Location.Controls.Add(this.comboBox_Floor);
            this.Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Location.Location = new System.Drawing.Point(586, 45);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(130, 110);
            this.Location.TabIndex = 27;
            this.Location.TabStop = false;
            this.Location.Text = "Этаж";
            // 
            // textBox_Room
            // 
            this.textBox_Room.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Room.Enabled = false;
            this.textBox_Room.Location = new System.Drawing.Point(6, 79);
            this.textBox_Room.Name = "textBox_Room";
            this.textBox_Room.Size = new System.Drawing.Size(118, 23);
            this.textBox_Room.TabIndex = 5;
            // 
            // textBox_Floor
            // 
            this.textBox_Floor.Enabled = false;
            this.textBox_Floor.Location = new System.Drawing.Point(6, 81);
            this.textBox_Floor.Name = "textBox_Floor";
            this.textBox_Floor.Size = new System.Drawing.Size(118, 23);
            this.textBox_Floor.TabIndex = 5;
            // 
            // checkBox_Room
            // 
            this.checkBox_Room.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Room.AutoSize = true;
            this.checkBox_Room.Location = new System.Drawing.Point(3, 52);
            this.checkBox_Room.Name = "checkBox_Room";
            this.checkBox_Room.Size = new System.Drawing.Size(127, 21);
            this.checkBox_Room.TabIndex = 4;
            this.checkBox_Room.Text = "Новая комната";
            this.checkBox_Room.UseVisualStyleBackColor = true;
            this.checkBox_Room.CheckedChanged += new System.EventHandler(this.checkBox_Room_CheckedChanged);
            // 
            // checkBox_Floor
            // 
            this.checkBox_Floor.AutoSize = true;
            this.checkBox_Floor.Location = new System.Drawing.Point(13, 52);
            this.checkBox_Floor.Name = "checkBox_Floor";
            this.checkBox_Floor.Size = new System.Drawing.Size(105, 21);
            this.checkBox_Floor.TabIndex = 4;
            this.checkBox_Floor.Text = "Новый этаж";
            this.checkBox_Floor.UseVisualStyleBackColor = true;
            this.checkBox_Floor.CheckedChanged += new System.EventHandler(this.checkBox_Floor_CheckedChanged);
            // 
            // comboBox_Room
            // 
            this.comboBox_Room.FormattingEnabled = true;
            this.comboBox_Room.Location = new System.Drawing.Point(6, 22);
            this.comboBox_Room.Name = "comboBox_Room";
            this.comboBox_Room.Size = new System.Drawing.Size(118, 24);
            this.comboBox_Room.TabIndex = 3;
            // 
            // comboBox_Floor
            // 
            this.comboBox_Floor.FormattingEnabled = true;
            this.comboBox_Floor.Location = new System.Drawing.Point(6, 21);
            this.comboBox_Floor.Name = "comboBox_Floor";
            this.comboBox_Floor.Size = new System.Drawing.Size(118, 24);
            this.comboBox_Floor.TabIndex = 3;
            // 
            // groupBox_room
            // 
            this.groupBox_room.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_room.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_room.Controls.Add(this.comboBox_Room);
            this.groupBox_room.Controls.Add(this.textBox_Room);
            this.groupBox_room.Controls.Add(this.checkBox_Room);
            this.groupBox_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_room.Location = new System.Drawing.Point(726, 45);
            this.groupBox_room.Name = "groupBox_room";
            this.groupBox_room.Size = new System.Drawing.Size(130, 110);
            this.groupBox_room.TabIndex = 28;
            this.groupBox_room.TabStop = false;
            this.groupBox_room.Text = "Комната";
            // 
            // AddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 398);
            this.Controls.Add(this.groupBox_room);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.groupBox_Jira);
            this.Controls.Add(this.groupBox_Responsible);
            this.Controls.Add(this.groupBox_NuberSN);
            this.Controls.Add(this.groupBox_Model);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox_LanName);
            this.Controls.Add(this.groupBox_TypeDevice);
            this.Controls.Add(this.groupBox_TypeAccоunt);
            this.Controls.Add(this.checkBox_SN);
            this.Controls.Add(this.textBox_Sum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_NumberInv);
            this.Controls.Add(this.label_NumberInv);
            this.Name = "AddItems";
            this.Text = "AddItems";
            this.groupBox_TypeAccоunt.ResumeLayout(false);
            this.groupBox_TypeAccоunt.PerformLayout();
            this.groupBox_TypeDevice.ResumeLayout(false);
            this.groupBox_TypeDevice.PerformLayout();
            this.groupBox_LanName.ResumeLayout(false);
            this.groupBox_LanName.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox_Model.ResumeLayout(false);
            this.groupBox_Model.PerformLayout();
            this.groupBox_NuberSN.ResumeLayout(false);
            this.groupBox_NuberSN.PerformLayout();
            this.groupBox_Responsible.ResumeLayout(false);
            this.groupBox_Responsible.PerformLayout();
            this.groupBox_Jira.ResumeLayout(false);
            this.groupBox_Jira.PerformLayout();
            this.Location.ResumeLayout(false);
            this.Location.PerformLayout();
            this.groupBox_room.ResumeLayout(false);
            this.groupBox_room.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_SN;
        private System.Windows.Forms.TextBox textBox_Sum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_NumberInv;
        private System.Windows.Forms.Label label_NumberInv;
        private System.Windows.Forms.GroupBox groupBox_TypeAccоunt;
        private System.Windows.Forms.TextBox textBox_TypeAccount;
        private System.Windows.Forms.CheckBox checkBox_Account;
        private System.Windows.Forms.ComboBox comboBox_TypeAccount;
        private System.Windows.Forms.GroupBox groupBox_TypeDevice;
        private System.Windows.Forms.TextBox textBox_TypeDevice;
        private System.Windows.Forms.CheckBox checkBox_TypeDevice;
        private System.Windows.Forms.ComboBox comboBox_TypeDevice;
        private System.Windows.Forms.GroupBox groupBox_LanName;
        private System.Windows.Forms.TextBox textBox_LanName;
        private System.Windows.Forms.CheckBox checkBox_LanName;
        private System.Windows.Forms.ComboBox comboBox_LanName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.GroupBox groupBox_Model;
        private System.Windows.Forms.TextBox textBox_Model;
        private System.Windows.Forms.GroupBox groupBox_NuberSN;
        private System.Windows.Forms.TextBox textBox_NumberSN;
        private System.Windows.Forms.GroupBox groupBox_Responsible;
        private System.Windows.Forms.TextBox textBox_Responsible;
        private System.Windows.Forms.CheckBox checkBox_Responsible;
        private System.Windows.Forms.ComboBox comboBox_Responsible;
        private System.Windows.Forms.GroupBox groupBox_Jira;
        private System.Windows.Forms.TextBox textBox_jira;
        private System.Windows.Forms.CheckBox checkBox_Jira;
        private System.Windows.Forms.ComboBox comboBox_Jira;
        private System.Windows.Forms.GroupBox Location;
        private System.Windows.Forms.TextBox textBox_Floor;
        private System.Windows.Forms.CheckBox checkBox_Floor;
        private System.Windows.Forms.ComboBox comboBox_Floor;
        private System.Windows.Forms.TextBox textBox_Room;
        private System.Windows.Forms.CheckBox checkBox_Room;
        private System.Windows.Forms.ComboBox comboBox_Room;
        private System.Windows.Forms.GroupBox groupBox_room;
    }
}