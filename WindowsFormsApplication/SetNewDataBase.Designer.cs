namespace WindowsFormsApplication
{
    partial class SetNewDataBase
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
            this.label_date = new System.Windows.Forms.Label();
            this.label_NumberInv = new System.Windows.Forms.Label();
            this.textBox_NumberInv = new System.Windows.Forms.TextBox();
            this.groupBox_TypeAccоunt = new System.Windows.Forms.GroupBox();
            this.textBox_TypeAccount = new System.Windows.Forms.TextBox();
            this.checkBox_Account = new System.Windows.Forms.CheckBox();
            this.comboBox_TypeAccount = new System.Windows.Forms.ComboBox();
            this.groupBox_TypeDevice = new System.Windows.Forms.GroupBox();
            this.textBox_TypeDevice = new System.Windows.Forms.TextBox();
            this.checkBox_TypeDevice = new System.Windows.Forms.CheckBox();
            this.comboBox_TypeDevice = new System.Windows.Forms.ComboBox();
            this.groupBox_Model = new System.Windows.Forms.GroupBox();
            this.textBox_Model = new System.Windows.Forms.TextBox();
            this.groupBox_NuberSN = new System.Windows.Forms.GroupBox();
            this.textBox_NumberSN = new System.Windows.Forms.TextBox();
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.groupBox_TypeAccоunt.SuspendLayout();
            this.groupBox_TypeDevice.SuspendLayout();
            this.groupBox_Model.SuspendLayout();
            this.groupBox_NuberSN.SuspendLayout();
            this.groupBox_Responsible.SuspendLayout();
            this.groupBox_LanName.SuspendLayout();
            this.Location.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_date.Location = new System.Drawing.Point(8, 9);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(96, 24);
            this.label_date.TabIndex = 0;
            this.label_date.Text = "label_date";
            // 
            // label_NumberInv
            // 
            this.label_NumberInv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_NumberInv.AutoSize = true;
            this.label_NumberInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_NumberInv.Location = new System.Drawing.Point(8, 48);
            this.label_NumberInv.Name = "label_NumberInv";
            this.label_NumberInv.Size = new System.Drawing.Size(288, 24);
            this.label_NumberInv.TabIndex = 0;
            this.label_NumberInv.Text = "Впишите инвентарный  номер ";
            // 
            // textBox_NumberInv
            // 
            this.textBox_NumberInv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_NumberInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_NumberInv.Location = new System.Drawing.Point(302, 48);
            this.textBox_NumberInv.Name = "textBox_NumberInv";
            this.textBox_NumberInv.Size = new System.Drawing.Size(228, 35);
            this.textBox_NumberInv.TabIndex = 2;
            this.textBox_NumberInv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NumberInv_KeyPress);
            // 
            // groupBox_TypeAccоunt
            // 
            this.groupBox_TypeAccоunt.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_TypeAccоunt.Controls.Add(this.textBox_TypeAccount);
            this.groupBox_TypeAccоunt.Controls.Add(this.checkBox_Account);
            this.groupBox_TypeAccоunt.Controls.Add(this.comboBox_TypeAccount);
            this.groupBox_TypeAccоunt.Enabled = false;
            this.groupBox_TypeAccоunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_TypeAccоunt.Location = new System.Drawing.Point(12, 89);
            this.groupBox_TypeAccоunt.Name = "groupBox_TypeAccоunt";
            this.groupBox_TypeAccоunt.Size = new System.Drawing.Size(518, 75);
            this.groupBox_TypeAccоunt.TabIndex = 3;
            this.groupBox_TypeAccоunt.TabStop = false;
            this.groupBox_TypeAccоunt.Text = "Вид учета";
            // 
            // textBox_TypeAccount
            // 
            this.textBox_TypeAccount.Enabled = false;
            this.textBox_TypeAccount.Location = new System.Drawing.Point(270, 43);
            this.textBox_TypeAccount.Name = "textBox_TypeAccount";
            this.textBox_TypeAccount.Size = new System.Drawing.Size(227, 26);
            this.textBox_TypeAccount.TabIndex = 2;
            // 
            // checkBox_Account
            // 
            this.checkBox_Account.AutoSize = true;
            this.checkBox_Account.Location = new System.Drawing.Point(270, 13);
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
            this.comboBox_TypeAccount.Location = new System.Drawing.Point(5, 25);
            this.comboBox_TypeAccount.Name = "comboBox_TypeAccount";
            this.comboBox_TypeAccount.Size = new System.Drawing.Size(181, 28);
            this.comboBox_TypeAccount.TabIndex = 0;
            // 
            // groupBox_TypeDevice
            // 
            this.groupBox_TypeDevice.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_TypeDevice.Controls.Add(this.textBox_TypeDevice);
            this.groupBox_TypeDevice.Controls.Add(this.checkBox_TypeDevice);
            this.groupBox_TypeDevice.Controls.Add(this.comboBox_TypeDevice);
            this.groupBox_TypeDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_TypeDevice.Location = new System.Drawing.Point(12, 170);
            this.groupBox_TypeDevice.Name = "groupBox_TypeDevice";
            this.groupBox_TypeDevice.Size = new System.Drawing.Size(518, 75);
            this.groupBox_TypeDevice.TabIndex = 3;
            this.groupBox_TypeDevice.TabStop = false;
            this.groupBox_TypeDevice.Text = "Вид оборудования ";
            // 
            // textBox_TypeDevice
            // 
            this.textBox_TypeDevice.Enabled = false;
            this.textBox_TypeDevice.Location = new System.Drawing.Point(270, 45);
            this.textBox_TypeDevice.Name = "textBox_TypeDevice";
            this.textBox_TypeDevice.Size = new System.Drawing.Size(227, 26);
            this.textBox_TypeDevice.TabIndex = 2;
            // 
            // checkBox_TypeDevice
            // 
            this.checkBox_TypeDevice.AutoSize = true;
            this.checkBox_TypeDevice.Location = new System.Drawing.Point(270, 14);
            this.checkBox_TypeDevice.Name = "checkBox_TypeDevice";
            this.checkBox_TypeDevice.Size = new System.Drawing.Size(231, 24);
            this.checkBox_TypeDevice.TabIndex = 1;
            this.checkBox_TypeDevice.Text = "Новый вид оборудования  ";
            this.checkBox_TypeDevice.UseVisualStyleBackColor = true;
            this.checkBox_TypeDevice.CheckedChanged += new System.EventHandler(this.checkBox_TypeDevice_CheckedChanged);
            // 
            // comboBox_TypeDevice
            // 
            this.comboBox_TypeDevice.FormattingEnabled = true;
            this.comboBox_TypeDevice.Location = new System.Drawing.Point(10, 26);
            this.comboBox_TypeDevice.Name = "comboBox_TypeDevice";
            this.comboBox_TypeDevice.Size = new System.Drawing.Size(176, 28);
            this.comboBox_TypeDevice.TabIndex = 0;
            // 
            // groupBox_Model
            // 
            this.groupBox_Model.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_Model.Controls.Add(this.textBox_Model);
            this.groupBox_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Model.Location = new System.Drawing.Point(12, 251);
            this.groupBox_Model.Name = "groupBox_Model";
            this.groupBox_Model.Size = new System.Drawing.Size(518, 74);
            this.groupBox_Model.TabIndex = 3;
            this.groupBox_Model.TabStop = false;
            this.groupBox_Model.Text = "Модель";
            // 
            // textBox_Model
            // 
            this.textBox_Model.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Model.Location = new System.Drawing.Point(40, 25);
            this.textBox_Model.Name = "textBox_Model";
            this.textBox_Model.Size = new System.Drawing.Size(419, 35);
            this.textBox_Model.TabIndex = 2;
            this.textBox_Model.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NumberSN_KeyPress);
            // 
            // groupBox_NuberSN
            // 
            this.groupBox_NuberSN.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_NuberSN.Controls.Add(this.textBox_NumberSN);
            this.groupBox_NuberSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_NuberSN.Location = new System.Drawing.Point(12, 331);
            this.groupBox_NuberSN.Name = "groupBox_NuberSN";
            this.groupBox_NuberSN.Size = new System.Drawing.Size(518, 74);
            this.groupBox_NuberSN.TabIndex = 3;
            this.groupBox_NuberSN.TabStop = false;
            this.groupBox_NuberSN.Text = "Серийный номер";
            // 
            // textBox_NumberSN
            // 
            this.textBox_NumberSN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_NumberSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_NumberSN.Location = new System.Drawing.Point(40, 25);
            this.textBox_NumberSN.Name = "textBox_NumberSN";
            this.textBox_NumberSN.Size = new System.Drawing.Size(419, 35);
            this.textBox_NumberSN.TabIndex = 2;
            this.textBox_NumberSN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NumberSN_KeyPress);
            // 
            // groupBox_Responsible
            // 
            this.groupBox_Responsible.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_Responsible.Controls.Add(this.textBox_Responsible);
            this.groupBox_Responsible.Controls.Add(this.checkBox_Responsible);
            this.groupBox_Responsible.Controls.Add(this.comboBox_Responsible);
            this.groupBox_Responsible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Responsible.Location = new System.Drawing.Point(12, 411);
            this.groupBox_Responsible.Name = "groupBox_Responsible";
            this.groupBox_Responsible.Size = new System.Drawing.Size(518, 74);
            this.groupBox_Responsible.TabIndex = 3;
            this.groupBox_Responsible.TabStop = false;
            this.groupBox_Responsible.Text = "Ответственный";
            // 
            // textBox_Responsible
            // 
            this.textBox_Responsible.Enabled = false;
            this.textBox_Responsible.Location = new System.Drawing.Point(270, 39);
            this.textBox_Responsible.Name = "textBox_Responsible";
            this.textBox_Responsible.Size = new System.Drawing.Size(227, 26);
            this.textBox_Responsible.TabIndex = 5;
            // 
            // checkBox_Responsible
            // 
            this.checkBox_Responsible.AutoSize = true;
            this.checkBox_Responsible.Location = new System.Drawing.Point(270, 9);
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
            this.comboBox_Responsible.Location = new System.Drawing.Point(6, 21);
            this.comboBox_Responsible.Name = "comboBox_Responsible";
            this.comboBox_Responsible.Size = new System.Drawing.Size(181, 28);
            this.comboBox_Responsible.TabIndex = 3;
            // 
            // groupBox_LanName
            // 
            this.groupBox_LanName.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_LanName.Controls.Add(this.textBox_LanName);
            this.groupBox_LanName.Controls.Add(this.checkBox_LanName);
            this.groupBox_LanName.Controls.Add(this.comboBox_LanName);
            this.groupBox_LanName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_LanName.Location = new System.Drawing.Point(12, 491);
            this.groupBox_LanName.Name = "groupBox_LanName";
            this.groupBox_LanName.Size = new System.Drawing.Size(518, 74);
            this.groupBox_LanName.TabIndex = 3;
            this.groupBox_LanName.TabStop = false;
            this.groupBox_LanName.Text = "Название в сети";
            // 
            // textBox_LanName
            // 
            this.textBox_LanName.Enabled = false;
            this.textBox_LanName.Location = new System.Drawing.Point(270, 39);
            this.textBox_LanName.Name = "textBox_LanName";
            this.textBox_LanName.Size = new System.Drawing.Size(227, 26);
            this.textBox_LanName.TabIndex = 5;
            // 
            // checkBox_LanName
            // 
            this.checkBox_LanName.AutoSize = true;
            this.checkBox_LanName.Location = new System.Drawing.Point(270, 9);
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
            this.comboBox_LanName.Location = new System.Drawing.Point(6, 21);
            this.comboBox_LanName.Name = "comboBox_LanName";
            this.comboBox_LanName.Size = new System.Drawing.Size(181, 28);
            this.comboBox_LanName.TabIndex = 3;
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
            this.Location.Location = new System.Drawing.Point(12, 571);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(518, 157);
            this.Location.TabIndex = 3;
            this.Location.TabStop = false;
            this.Location.Text = "Местоположение";
            // 
            // label_LocationRoom
            // 
            this.label_LocationRoom.AutoSize = true;
            this.label_LocationRoom.Location = new System.Drawing.Point(19, 91);
            this.label_LocationRoom.Name = "label_LocationRoom";
            this.label_LocationRoom.Size = new System.Drawing.Size(99, 20);
            this.label_LocationRoom.TabIndex = 6;
            this.label_LocationRoom.Text = "Помещение";
            // 
            // label_LocationFloor
            // 
            this.label_LocationFloor.AutoSize = true;
            this.label_LocationFloor.Location = new System.Drawing.Point(36, 25);
            this.label_LocationFloor.Name = "label_LocationFloor";
            this.label_LocationFloor.Size = new System.Drawing.Size(50, 20);
            this.label_LocationFloor.TabIndex = 6;
            this.label_LocationFloor.Text = "Этаж";
            // 
            // textBox_Room
            // 
            this.textBox_Room.Enabled = false;
            this.textBox_Room.Location = new System.Drawing.Point(295, 117);
            this.textBox_Room.Name = "textBox_Room";
            this.textBox_Room.Size = new System.Drawing.Size(188, 26);
            this.textBox_Room.TabIndex = 5;
            // 
            // textBox_Floor
            // 
            this.textBox_Floor.Enabled = false;
            this.textBox_Floor.Location = new System.Drawing.Point(350, 48);
            this.textBox_Floor.Name = "textBox_Floor";
            this.textBox_Floor.Size = new System.Drawing.Size(95, 26);
            this.textBox_Floor.TabIndex = 5;
            // 
            // checkBox_Room
            // 
            this.checkBox_Room.AutoSize = true;
            this.checkBox_Room.Location = new System.Drawing.Point(306, 87);
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
            this.checkBox_Floor.Location = new System.Drawing.Point(339, 21);
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
            this.comboBox_Room.Location = new System.Drawing.Point(10, 111);
            this.comboBox_Room.Name = "comboBox_Room";
            this.comboBox_Room.Size = new System.Drawing.Size(108, 28);
            this.comboBox_Room.TabIndex = 3;
            // 
            // comboBox_Floor
            // 
            this.comboBox_Floor.FormattingEnabled = true;
            this.comboBox_Floor.Location = new System.Drawing.Point(10, 48);
            this.comboBox_Floor.Name = "comboBox_Floor";
            this.comboBox_Floor.Size = new System.Drawing.Size(108, 28);
            this.comboBox_Floor.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Cancel);
            this.panel1.Controls.Add(this.button_OK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 734);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 57);
            this.panel1.TabIndex = 4;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Cancel.Location = new System.Drawing.Point(11, 6);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(174, 45);
            this.button_Cancel.TabIndex = 5;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_OK
            // 
            this.button_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_OK.Location = new System.Drawing.Point(328, 6);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(201, 45);
            this.button_OK.TabIndex = 6;
            this.button_OK.Text = "Внести в базу ";
            this.button_OK.UseVisualStyleBackColor = true;
            // 
            // SetNewDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(540, 791);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox_NuberSN);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.groupBox_LanName);
            this.Controls.Add(this.groupBox_Responsible);
            this.Controls.Add(this.groupBox_Model);
            this.Controls.Add(this.groupBox_TypeDevice);
            this.Controls.Add(this.groupBox_TypeAccоunt);
            this.Controls.Add(this.textBox_NumberInv);
            this.Controls.Add(this.label_NumberInv);
            this.Controls.Add(this.label_date);
            this.Name = "SetNewDataBase";
            this.Text = "SetNewDate";
            this.groupBox_TypeAccоunt.ResumeLayout(false);
            this.groupBox_TypeAccоunt.PerformLayout();
            this.groupBox_TypeDevice.ResumeLayout(false);
            this.groupBox_TypeDevice.PerformLayout();
            this.groupBox_Model.ResumeLayout(false);
            this.groupBox_Model.PerformLayout();
            this.groupBox_NuberSN.ResumeLayout(false);
            this.groupBox_NuberSN.PerformLayout();
            this.groupBox_Responsible.ResumeLayout(false);
            this.groupBox_Responsible.PerformLayout();
            this.groupBox_LanName.ResumeLayout(false);
            this.groupBox_LanName.PerformLayout();
            this.Location.ResumeLayout(false);
            this.Location.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_NumberInv;
        private System.Windows.Forms.TextBox textBox_NumberInv;
        private System.Windows.Forms.GroupBox groupBox_TypeAccоunt;
        private System.Windows.Forms.TextBox textBox_TypeAccount;
        private System.Windows.Forms.CheckBox checkBox_Account;
        private System.Windows.Forms.ComboBox comboBox_TypeAccount;
        private System.Windows.Forms.GroupBox groupBox_TypeDevice;
        private System.Windows.Forms.GroupBox groupBox_Model;
        private System.Windows.Forms.GroupBox groupBox_NuberSN;
        private System.Windows.Forms.TextBox textBox_NumberSN;
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
        private System.Windows.Forms.TextBox textBox_Model;
        private System.Windows.Forms.TextBox textBox_TypeDevice;
        private System.Windows.Forms.CheckBox checkBox_TypeDevice;
        private System.Windows.Forms.ComboBox comboBox_TypeDevice;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
    }
}