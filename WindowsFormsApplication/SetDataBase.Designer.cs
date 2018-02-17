namespace WindowsFormsApplication
{
    partial class setDataBase

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
            this.groupBox_TypeAccоunt = new System.Windows.Forms.GroupBox();
            this.textBox_TypeAccount = new System.Windows.Forms.TextBox();
            this.checkBox_Account = new System.Windows.Forms.CheckBox();
            this.comboBox_TypeAccount = new System.Windows.Forms.ComboBox();
            this.groupBox_Responsible = new System.Windows.Forms.GroupBox();
            this.textBox_Responsible = new System.Windows.Forms.TextBox();
            this.checkBox_Responsible = new System.Windows.Forms.CheckBox();
            this.comboBox_Responsible = new System.Windows.Forms.ComboBox();
            this.groupBox_LanName = new System.Windows.Forms.GroupBox();
            this.textBox_LanName = new System.Windows.Forms.TextBox();
            this.checkBox_LanName = new System.Windows.Forms.CheckBox();
            this.comboBox_LanName = new System.Windows.Forms.ComboBox();
            this.Location = new System.Windows.Forms.GroupBox();
            this.label_LocationRoom = new System.Windows.Forms.Label();
            this.label_LocationFloor = new System.Windows.Forms.Label();
            this.textBox_Room = new System.Windows.Forms.TextBox();
            this.textBox_Floor = new System.Windows.Forms.TextBox();
            this.checkBox_Room = new System.Windows.Forms.CheckBox();
            this.checkBox_Floor = new System.Windows.Forms.CheckBox();
            this.comboBox_Room = new System.Windows.Forms.ComboBox();
            this.comboBox_Floor = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.comboBox_invinNumber = new System.Windows.Forms.ComboBox();
            this.label_TypeAccount = new System.Windows.Forms.Label();
            this.label_NameLan = new System.Windows.Forms.Label();
            this.label_Responsible = new System.Windows.Forms.Label();
            this.label_Floor = new System.Windows.Forms.Label();
            this.label_Room = new System.Windows.Forms.Label();
            this.label_TypeDevice = new System.Windows.Forms.Label();
            this.label_NumberSN = new System.Windows.Forms.Label();
            this.label_Model = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_TA = new System.Windows.Forms.Label();
            this.label_LN = new System.Windows.Forms.Label();
            this.label_RES = new System.Windows.Forms.Label();
            this.label_FL = new System.Windows.Forms.Label();
            this.label_R = new System.Windows.Forms.Label();
            this.label_TD = new System.Windows.Forms.Label();
            this.label_NS = new System.Windows.Forms.Label();
            this.label_M = new System.Windows.Forms.Label();
            this.groupBox_TypeAccоunt.SuspendLayout();
            this.groupBox_Responsible.SuspendLayout();
            this.groupBox_LanName.SuspendLayout();
            this.Location.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_TypeAccоunt
            // 
            this.groupBox_TypeAccоunt.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_TypeAccоunt.Controls.Add(this.textBox_TypeAccount);
            this.groupBox_TypeAccоunt.Controls.Add(this.checkBox_Account);
            this.groupBox_TypeAccоunt.Controls.Add(this.comboBox_TypeAccount);
            this.groupBox_TypeAccоunt.Enabled = false;
            this.groupBox_TypeAccоunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_TypeAccоunt.Location = new System.Drawing.Point(466, 25);
            this.groupBox_TypeAccоunt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_TypeAccоunt.Name = "groupBox_TypeAccоunt";
            this.groupBox_TypeAccоunt.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_TypeAccоunt.Size = new System.Drawing.Size(670, 85);
            this.groupBox_TypeAccоunt.TabIndex = 3;
            this.groupBox_TypeAccоunt.TabStop = false;
            this.groupBox_TypeAccоunt.Text = "Вид учета";
            // 
            // textBox_TypeAccount
            // 
            this.textBox_TypeAccount.Enabled = false;
            this.textBox_TypeAccount.Location = new System.Drawing.Point(318, 49);
            this.textBox_TypeAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_TypeAccount.Name = "textBox_TypeAccount";
            this.textBox_TypeAccount.Size = new System.Drawing.Size(338, 26);
            this.textBox_TypeAccount.TabIndex = 2;
            // 
            // checkBox_Account
            // 
            this.checkBox_Account.AutoSize = true;
            this.checkBox_Account.Location = new System.Drawing.Point(405, 19);
            this.checkBox_Account.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_Account.Name = "checkBox_Account";
            this.checkBox_Account.Size = new System.Drawing.Size(158, 24);
            this.checkBox_Account.TabIndex = 1;
            this.checkBox_Account.Text = "Новый вид учета";
            this.checkBox_Account.UseVisualStyleBackColor = true;
            this.checkBox_Account.CheckedChanged += new System.EventHandler(this.checkBox_Account_CheckedChanged);
            // 
            // comboBox_TypeAccount
            // 
            this.comboBox_TypeAccount.FormattingEnabled = true;
            this.comboBox_TypeAccount.Location = new System.Drawing.Point(8, 29);
            this.comboBox_TypeAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_TypeAccount.Name = "comboBox_TypeAccount";
            this.comboBox_TypeAccount.Size = new System.Drawing.Size(270, 28);
            this.comboBox_TypeAccount.TabIndex = 0;
            // 
            // groupBox_Responsible
            // 
            this.groupBox_Responsible.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_Responsible.Controls.Add(this.textBox_Responsible);
            this.groupBox_Responsible.Controls.Add(this.checkBox_Responsible);
            this.groupBox_Responsible.Controls.Add(this.comboBox_Responsible);
            this.groupBox_Responsible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Responsible.Location = new System.Drawing.Point(466, 120);
            this.groupBox_Responsible.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_Responsible.Name = "groupBox_Responsible";
            this.groupBox_Responsible.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_Responsible.Size = new System.Drawing.Size(670, 85);
            this.groupBox_Responsible.TabIndex = 3;
            this.groupBox_Responsible.TabStop = false;
            this.groupBox_Responsible.Text = "Ответственный";
            // 
            // textBox_Responsible
            // 
            this.textBox_Responsible.Enabled = false;
            this.textBox_Responsible.Location = new System.Drawing.Point(309, 48);
            this.textBox_Responsible.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Responsible.Name = "textBox_Responsible";
            this.textBox_Responsible.Size = new System.Drawing.Size(338, 26);
            this.textBox_Responsible.TabIndex = 5;
            this.textBox_Responsible.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Responsible_KeyUp);
            // 
            // checkBox_Responsible
            // 
            this.checkBox_Responsible.AutoSize = true;
            this.checkBox_Responsible.Location = new System.Drawing.Point(376, 14);
            this.checkBox_Responsible.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_Responsible.Name = "checkBox_Responsible";
            this.checkBox_Responsible.Size = new System.Drawing.Size(237, 24);
            this.checkBox_Responsible.TabIndex = 4;
            this.checkBox_Responsible.Text = "Новое ответственное лицо";
            this.checkBox_Responsible.UseVisualStyleBackColor = true;
            this.checkBox_Responsible.CheckedChanged += new System.EventHandler(this.checkBox_Responsible_CheckedChanged);
            // 
            // comboBox_Responsible
            // 
            this.comboBox_Responsible.FormattingEnabled = true;
            this.comboBox_Responsible.Location = new System.Drawing.Point(9, 32);
            this.comboBox_Responsible.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_Responsible.Name = "comboBox_Responsible";
            this.comboBox_Responsible.Size = new System.Drawing.Size(270, 28);
            this.comboBox_Responsible.TabIndex = 3;
            this.comboBox_Responsible.SelectedIndexChanged += new System.EventHandler(this.comboBox_Responsible_SelectedIndexChanged);
            // 
            // groupBox_LanName
            // 
            this.groupBox_LanName.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_LanName.Controls.Add(this.textBox_LanName);
            this.groupBox_LanName.Controls.Add(this.checkBox_LanName);
            this.groupBox_LanName.Controls.Add(this.comboBox_LanName);
            this.groupBox_LanName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_LanName.Location = new System.Drawing.Point(466, 215);
            this.groupBox_LanName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_LanName.Name = "groupBox_LanName";
            this.groupBox_LanName.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_LanName.Size = new System.Drawing.Size(670, 85);
            this.groupBox_LanName.TabIndex = 3;
            this.groupBox_LanName.TabStop = false;
            this.groupBox_LanName.Text = "Название в сети";
            // 
            // textBox_LanName
            // 
            this.textBox_LanName.Enabled = false;
            this.textBox_LanName.Location = new System.Drawing.Point(309, 49);
            this.textBox_LanName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_LanName.Name = "textBox_LanName";
            this.textBox_LanName.Size = new System.Drawing.Size(338, 26);
            this.textBox_LanName.TabIndex = 5;
            this.textBox_LanName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_LanName_KeyUp);
            // 
            // checkBox_LanName
            // 
            this.checkBox_LanName.AutoSize = true;
            this.checkBox_LanName.Location = new System.Drawing.Point(376, 14);
            this.checkBox_LanName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_LanName.Name = "checkBox_LanName";
            this.checkBox_LanName.Size = new System.Drawing.Size(203, 24);
            this.checkBox_LanName.TabIndex = 4;
            this.checkBox_LanName.Text = "Новое название в сети";
            this.checkBox_LanName.UseVisualStyleBackColor = true;
            this.checkBox_LanName.CheckedChanged += new System.EventHandler(this.checkBox_LanName_CheckedChanged);
            // 
            // comboBox_LanName
            // 
            this.comboBox_LanName.FormattingEnabled = true;
            this.comboBox_LanName.Location = new System.Drawing.Point(9, 32);
            this.comboBox_LanName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_LanName.Name = "comboBox_LanName";
            this.comboBox_LanName.Size = new System.Drawing.Size(270, 28);
            this.comboBox_LanName.TabIndex = 3;
            this.comboBox_LanName.SelectedIndexChanged += new System.EventHandler(this.comboBox_LanName_SelectedIndexChanged);
            // 
            // Location
            // 
            this.Location.BackColor = System.Drawing.SystemColors.Control;
            this.Location.Controls.Add(this.label_LocationRoom);
            this.Location.Controls.Add(this.label_LocationFloor);
            this.Location.Controls.Add(this.textBox_Room);
            this.Location.Controls.Add(this.textBox_Floor);
            this.Location.Controls.Add(this.checkBox_Room);
            this.Location.Controls.Add(this.checkBox_Floor);
            this.Location.Controls.Add(this.comboBox_Room);
            this.Location.Controls.Add(this.comboBox_Floor);
            this.Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Location.Location = new System.Drawing.Point(466, 310);
            this.Location.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Location.Name = "Location";
            this.Location.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Location.Size = new System.Drawing.Size(670, 120);
            this.Location.TabIndex = 3;
            this.Location.TabStop = false;
            this.Location.Text = "Местоположение";
            // 
            // label_LocationRoom
            // 
            this.label_LocationRoom.AutoSize = true;
            this.label_LocationRoom.Location = new System.Drawing.Point(5, 77);
            this.label_LocationRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_LocationRoom.Name = "label_LocationRoom";
            this.label_LocationRoom.Size = new System.Drawing.Size(99, 20);
            this.label_LocationRoom.TabIndex = 6;
            this.label_LocationRoom.Text = "Помещение";
            // 
            // label_LocationFloor
            // 
            this.label_LocationFloor.AutoSize = true;
            this.label_LocationFloor.Location = new System.Drawing.Point(5, 32);
            this.label_LocationFloor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_LocationFloor.Name = "label_LocationFloor";
            this.label_LocationFloor.Size = new System.Drawing.Size(50, 20);
            this.label_LocationFloor.TabIndex = 6;
            this.label_LocationFloor.Text = "Этаж";
            // 
            // textBox_Room
            // 
            this.textBox_Room.Enabled = false;
            this.textBox_Room.Location = new System.Drawing.Point(507, 74);
            this.textBox_Room.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Room.Name = "textBox_Room";
            this.textBox_Room.Size = new System.Drawing.Size(140, 26);
            this.textBox_Room.TabIndex = 5;
            this.textBox_Room.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Room_KeyUp);
            // 
            // textBox_Floor
            // 
            this.textBox_Floor.Enabled = false;
            this.textBox_Floor.Location = new System.Drawing.Point(507, 26);
            this.textBox_Floor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Floor.Name = "textBox_Floor";
            this.textBox_Floor.Size = new System.Drawing.Size(140, 26);
            this.textBox_Floor.TabIndex = 5;
            this.textBox_Floor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Floor_KeyUp);
            // 
            // checkBox_Room
            // 
            this.checkBox_Room.AutoSize = true;
            this.checkBox_Room.Location = new System.Drawing.Point(308, 69);
            this.checkBox_Room.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_Room.Name = "checkBox_Room";
            this.checkBox_Room.Size = new System.Drawing.Size(167, 24);
            this.checkBox_Room.TabIndex = 4;
            this.checkBox_Room.Text = "Новое помещение";
            this.checkBox_Room.UseVisualStyleBackColor = true;
            this.checkBox_Room.CheckedChanged += new System.EventHandler(this.checkBox_Room_CheckedChanged);
            // 
            // checkBox_Floor
            // 
            this.checkBox_Floor.AutoSize = true;
            this.checkBox_Floor.Location = new System.Drawing.Point(308, 26);
            this.checkBox_Floor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_Floor.Name = "checkBox_Floor";
            this.checkBox_Floor.Size = new System.Drawing.Size(120, 24);
            this.checkBox_Floor.TabIndex = 4;
            this.checkBox_Floor.Text = "Новый этаж";
            this.checkBox_Floor.UseVisualStyleBackColor = true;
            this.checkBox_Floor.CheckedChanged += new System.EventHandler(this.checkBox_Floor_CheckedChanged);
            // 
            // comboBox_Room
            // 
            this.comboBox_Room.FormattingEnabled = true;
            this.comboBox_Room.Location = new System.Drawing.Point(119, 67);
            this.comboBox_Room.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_Room.Name = "comboBox_Room";
            this.comboBox_Room.Size = new System.Drawing.Size(160, 28);
            this.comboBox_Room.TabIndex = 3;
            this.comboBox_Room.SelectedIndexChanged += new System.EventHandler(this.comboBox_Room_SelectedIndexChanged);
            // 
            // comboBox_Floor
            // 
            this.comboBox_Floor.FormattingEnabled = true;
            this.comboBox_Floor.Location = new System.Drawing.Point(119, 30);
            this.comboBox_Floor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_Floor.Name = "comboBox_Floor";
            this.comboBox_Floor.Size = new System.Drawing.Size(160, 28);
            this.comboBox_Floor.TabIndex = 3;
            this.comboBox_Floor.SelectedIndexChanged += new System.EventHandler(this.comboBox_Floor_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(501, 1066);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 69);
            this.button1.TabIndex = 4;
            this.button1.Text = "Внести в базу ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(25, 1066);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(261, 69);
            this.button3.TabIndex = 4;
            this.button3.Text = "Отмена";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // comboBox_invinNumber
            // 
            this.comboBox_invinNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_invinNumber.FormattingEnabled = true;
            this.comboBox_invinNumber.Location = new System.Drawing.Point(35, 25);
            this.comboBox_invinNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_invinNumber.Name = "comboBox_invinNumber";
            this.comboBox_invinNumber.Size = new System.Drawing.Size(352, 32);
            this.comboBox_invinNumber.TabIndex = 5;
            // 
            // label_TypeAccount
            // 
            this.label_TypeAccount.AutoSize = true;
            this.label_TypeAccount.Location = new System.Drawing.Point(23, 102);
            this.label_TypeAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TypeAccount.Name = "label_TypeAccount";
            this.label_TypeAccount.Size = new System.Drawing.Size(137, 20);
            this.label_TypeAccount.TabIndex = 6;
            this.label_TypeAccount.Text = "Тип учёта (ОС/М)";
            // 
            // label_NameLan
            // 
            this.label_NameLan.AutoSize = true;
            this.label_NameLan.Location = new System.Drawing.Point(23, 137);
            this.label_NameLan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NameLan.Name = "label_NameLan";
            this.label_NameLan.Size = new System.Drawing.Size(139, 20);
            this.label_NameLan.TabIndex = 6;
            this.label_NameLan.Text = "Название в сети:";
            // 
            // label_Responsible
            // 
            this.label_Responsible.AutoSize = true;
            this.label_Responsible.Location = new System.Drawing.Point(23, 172);
            this.label_Responsible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Responsible.Name = "label_Responsible";
            this.label_Responsible.Size = new System.Drawing.Size(130, 20);
            this.label_Responsible.TabIndex = 6;
            this.label_Responsible.Text = "Ответственный";
            // 
            // label_Floor
            // 
            this.label_Floor.AutoSize = true;
            this.label_Floor.Location = new System.Drawing.Point(23, 207);
            this.label_Floor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Floor.Name = "label_Floor";
            this.label_Floor.Size = new System.Drawing.Size(50, 20);
            this.label_Floor.TabIndex = 6;
            this.label_Floor.Text = "Этаж";
            // 
            // label_Room
            // 
            this.label_Room.AutoSize = true;
            this.label_Room.Location = new System.Drawing.Point(23, 242);
            this.label_Room.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Room.Name = "label_Room";
            this.label_Room.Size = new System.Drawing.Size(103, 20);
            this.label_Room.TabIndex = 6;
            this.label_Room.Text = "Помещение ";
            // 
            // label_TypeDevice
            // 
            this.label_TypeDevice.AutoSize = true;
            this.label_TypeDevice.Location = new System.Drawing.Point(21, 277);
            this.label_TypeDevice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TypeDevice.Name = "label_TypeDevice";
            this.label_TypeDevice.Size = new System.Drawing.Size(126, 20);
            this.label_TypeDevice.TabIndex = 6;
            this.label_TypeDevice.Text = "Тип устройства";
            // 
            // label_NumberSN
            // 
            this.label_NumberSN.AutoSize = true;
            this.label_NumberSN.Location = new System.Drawing.Point(19, 312);
            this.label_NumberSN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NumberSN.Name = "label_NumberSN";
            this.label_NumberSN.Size = new System.Drawing.Size(136, 20);
            this.label_NumberSN.TabIndex = 6;
            this.label_NumberSN.Text = "Серийный номер";
            // 
            // label_Model
            // 
            this.label_Model.AutoSize = true;
            this.label_Model.Location = new System.Drawing.Point(19, 347);
            this.label_Model.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Model.Name = "label_Model";
            this.label_Model.Size = new System.Drawing.Size(70, 20);
            this.label_Model.TabIndex = 6;
            this.label_Model.Text = "Модель";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(3, 429);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(1143, 327);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1137, 302);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // label_TA
            // 
            this.label_TA.AutoSize = true;
            this.label_TA.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TA.Location = new System.Drawing.Point(214, 102);
            this.label_TA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TA.Name = "label_TA";
            this.label_TA.Size = new System.Drawing.Size(173, 23);
            this.label_TA.TabIndex = 6;
            this.label_TA.Text = "Тип учёта (ОС/М)";
            // 
            // label_LN
            // 
            this.label_LN.AutoSize = true;
            this.label_LN.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_LN.Location = new System.Drawing.Point(214, 137);
            this.label_LN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_LN.Name = "label_LN";
            this.label_LN.Size = new System.Drawing.Size(171, 23);
            this.label_LN.TabIndex = 6;
            this.label_LN.Text = "Название в сети:";
            // 
            // label_RES
            // 
            this.label_RES.AutoSize = true;
            this.label_RES.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_RES.Location = new System.Drawing.Point(214, 172);
            this.label_RES.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_RES.Name = "label_RES";
            this.label_RES.Size = new System.Drawing.Size(173, 23);
            this.label_RES.TabIndex = 6;
            this.label_RES.Text = "Ответственный";
            // 
            // label_FL
            // 
            this.label_FL.AutoSize = true;
            this.label_FL.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_FL.Location = new System.Drawing.Point(214, 207);
            this.label_FL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_FL.Name = "label_FL";
            this.label_FL.Size = new System.Drawing.Size(64, 23);
            this.label_FL.TabIndex = 6;
            this.label_FL.Text = "Этаж";
            // 
            // label_R
            // 
            this.label_R.AutoSize = true;
            this.label_R.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_R.Location = new System.Drawing.Point(214, 242);
            this.label_R.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_R.Name = "label_R";
            this.label_R.Size = new System.Drawing.Size(123, 23);
            this.label_R.TabIndex = 6;
            this.label_R.Text = "Помещение ";
            // 
            // label_TD
            // 
            this.label_TD.AutoSize = true;
            this.label_TD.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TD.Location = new System.Drawing.Point(212, 277);
            this.label_TD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TD.Name = "label_TD";
            this.label_TD.Size = new System.Drawing.Size(165, 23);
            this.label_TD.TabIndex = 6;
            this.label_TD.Text = "Тип устройства";
            // 
            // label_NS
            // 
            this.label_NS.AutoSize = true;
            this.label_NS.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_NS.Location = new System.Drawing.Point(210, 312);
            this.label_NS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NS.Name = "label_NS";
            this.label_NS.Size = new System.Drawing.Size(164, 23);
            this.label_NS.TabIndex = 6;
            this.label_NS.Text = "Серийный номер";
            // 
            // label_M
            // 
            this.label_M.AutoSize = true;
            this.label_M.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_M.Location = new System.Drawing.Point(210, 347);
            this.label_M.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_M.Name = "label_M";
            this.label_M.Size = new System.Drawing.Size(79, 23);
            this.label_M.TabIndex = 6;
            this.label_M.Text = "Модель";
            // 
            // setDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1149, 761);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_M);
            this.Controls.Add(this.label_Model);
            this.Controls.Add(this.label_NS);
            this.Controls.Add(this.label_NumberSN);
            this.Controls.Add(this.label_TD);
            this.Controls.Add(this.label_TypeDevice);
            this.Controls.Add(this.label_R);
            this.Controls.Add(this.label_Room);
            this.Controls.Add(this.label_FL);
            this.Controls.Add(this.label_Floor);
            this.Controls.Add(this.label_RES);
            this.Controls.Add(this.label_Responsible);
            this.Controls.Add(this.label_LN);
            this.Controls.Add(this.label_NameLan);
            this.Controls.Add(this.label_TA);
            this.Controls.Add(this.label_TypeAccount);
            this.Controls.Add(this.comboBox_invinNumber);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.groupBox_LanName);
            this.Controls.Add(this.groupBox_Responsible);
            this.Controls.Add(this.groupBox_TypeAccоunt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "setDataBase";
            this.Text = "SetNewDate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.setDataBase_FormClosed);
            this.groupBox_TypeAccоunt.ResumeLayout(false);
            this.groupBox_TypeAccоunt.PerformLayout();
            this.groupBox_Responsible.ResumeLayout(false);
            this.groupBox_Responsible.PerformLayout();
            this.groupBox_LanName.ResumeLayout(false);
            this.groupBox_LanName.PerformLayout();
            this.Location.ResumeLayout(false);
            this.Location.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_TypeAccоunt;
        private System.Windows.Forms.TextBox textBox_TypeAccount;
        private System.Windows.Forms.CheckBox checkBox_Account;
        private System.Windows.Forms.ComboBox comboBox_TypeAccount;
        private System.Windows.Forms.GroupBox groupBox_Responsible;
        private System.Windows.Forms.TextBox textBox_Responsible;
        private System.Windows.Forms.CheckBox checkBox_Responsible;
        private System.Windows.Forms.ComboBox comboBox_Responsible;
        private System.Windows.Forms.GroupBox groupBox_LanName;
        private System.Windows.Forms.TextBox textBox_LanName;
        private System.Windows.Forms.CheckBox checkBox_LanName;
        private System.Windows.Forms.ComboBox comboBox_LanName;
        private System.Windows.Forms.GroupBox Location;
        private System.Windows.Forms.Label label_LocationRoom;
        private System.Windows.Forms.Label label_LocationFloor;
        private System.Windows.Forms.TextBox textBox_Room;
        private System.Windows.Forms.TextBox textBox_Floor;
        private System.Windows.Forms.CheckBox checkBox_Room;
        private System.Windows.Forms.CheckBox checkBox_Floor;
        private System.Windows.Forms.ComboBox comboBox_Room;
        private System.Windows.Forms.ComboBox comboBox_Floor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox comboBox_invinNumber;
        private System.Windows.Forms.Label label_TypeAccount;
        private System.Windows.Forms.Label label_NameLan;
        private System.Windows.Forms.Label label_Responsible;
        private System.Windows.Forms.Label label_Floor;
        private System.Windows.Forms.Label label_Room;
        private System.Windows.Forms.Label label_TypeDevice;
        private System.Windows.Forms.Label label_NumberSN;
        private System.Windows.Forms.Label label_Model;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_TA;
        private System.Windows.Forms.Label label_LN;
        private System.Windows.Forms.Label label_RES;
        private System.Windows.Forms.Label label_FL;
        private System.Windows.Forms.Label label_R;
        private System.Windows.Forms.Label label_TD;
        private System.Windows.Forms.Label label_NS;
        private System.Windows.Forms.Label label_M;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}