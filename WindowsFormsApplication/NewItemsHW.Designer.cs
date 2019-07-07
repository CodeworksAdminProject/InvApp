namespace WindowsFormsApplication
{
    partial class NewItemsHW
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
            this.label_NumberInv = new System.Windows.Forms.Label();
            this.textBox_NumberInv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Sum = new System.Windows.Forms.TextBox();
            this.checkBox_SN = new System.Windows.Forms.CheckBox();
            this.groupBox_Note = new System.Windows.Forms.GroupBox();
            this.textBox_Note = new System.Windows.Forms.TextBox();
            this.groupBox_Hardware_jira = new System.Windows.Forms.GroupBox();
            this.textBox_Hardware_jira = new System.Windows.Forms.TextBox();
            this.checkBox_Hardware_jira = new System.Windows.Forms.CheckBox();
            this.comboBox_Hardware_jira = new System.Windows.Forms.ComboBox();
            this.groupBox_Hardware_TypeDevice = new System.Windows.Forms.GroupBox();
            this.textBox_Hardware_TypeDevice = new System.Windows.Forms.TextBox();
            this.checkBox_Hardware_TypeDevice = new System.Windows.Forms.CheckBox();
            this.comboBox_Hardware_TypeDevice = new System.Windows.Forms.ComboBox();
            this.groupBox_Hardware_Model = new System.Windows.Forms.GroupBox();
            this.textBox_Hardware_Model = new System.Windows.Forms.TextBox();
            this.groupBox_Hardware_SN = new System.Windows.Forms.GroupBox();
            this.textBox_Hardware_SN = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.groupBox_Note.SuspendLayout();
            this.groupBox_Hardware_jira.SuspendLayout();
            this.groupBox_Hardware_TypeDevice.SuspendLayout();
            this.groupBox_Hardware_Model.SuspendLayout();
            this.groupBox_Hardware_SN.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_NumberInv
            // 
            this.label_NumberInv.AutoSize = true;
            this.label_NumberInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_NumberInv.Location = new System.Drawing.Point(5, 18);
            this.label_NumberInv.Name = "label_NumberInv";
            this.label_NumberInv.Size = new System.Drawing.Size(229, 17);
            this.label_NumberInv.TabIndex = 0;
            this.label_NumberInv.Text = "Начиная с инвентарного номера:";
            // 
            // textBox_NumberInv
            // 
            this.textBox_NumberInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_NumberInv.Location = new System.Drawing.Point(240, 12);
            this.textBox_NumberInv.Name = "textBox_NumberInv";
            this.textBox_NumberInv.Size = new System.Drawing.Size(209, 26);
            this.textBox_NumberInv.TabIndex = 2;
            this.textBox_NumberInv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NumberInv_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(474, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество элементов :";
            // 
            // textBox_Sum
            // 
            this.textBox_Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Sum.Location = new System.Drawing.Point(648, 12);
            this.textBox_Sum.Name = "textBox_Sum";
            this.textBox_Sum.Size = new System.Drawing.Size(55, 26);
            this.textBox_Sum.TabIndex = 4;
            this.textBox_Sum.Text = "1";
            this.textBox_Sum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NumberInv_KeyPress);
            // 
            // checkBox_SN
            // 
            this.checkBox_SN.AutoSize = true;
            this.checkBox_SN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_SN.Location = new System.Drawing.Point(749, 14);
            this.checkBox_SN.Name = "checkBox_SN";
            this.checkBox_SN.Size = new System.Drawing.Size(114, 24);
            this.checkBox_SN.TabIndex = 13;
            this.checkBox_SN.Text = "Разные S/N";
            this.checkBox_SN.UseVisualStyleBackColor = true;
            this.checkBox_SN.CheckedChanged += new System.EventHandler(this.checkBox_SN_CheckedChanged);
            // 
            // groupBox_Note
            // 
            this.groupBox_Note.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Note.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_Note.Controls.Add(this.textBox_Note);
            this.groupBox_Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Note.Location = new System.Drawing.Point(8, 228);
            this.groupBox_Note.Name = "groupBox_Note";
            this.groupBox_Note.Size = new System.Drawing.Size(400, 50);
            this.groupBox_Note.TabIndex = 19;
            this.groupBox_Note.TabStop = false;
            this.groupBox_Note.Text = "Примеание ";
            // 
            // textBox_Note
            // 
            this.textBox_Note.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Note.Location = new System.Drawing.Point(7, 17);
            this.textBox_Note.Name = "textBox_Note";
            this.textBox_Note.Size = new System.Drawing.Size(387, 26);
            this.textBox_Note.TabIndex = 2;
            // 
            // groupBox_Hardware_jira
            // 
            this.groupBox_Hardware_jira.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Hardware_jira.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_Hardware_jira.Controls.Add(this.textBox_Hardware_jira);
            this.groupBox_Hardware_jira.Controls.Add(this.checkBox_Hardware_jira);
            this.groupBox_Hardware_jira.Controls.Add(this.comboBox_Hardware_jira);
            this.groupBox_Hardware_jira.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Hardware_jira.Location = new System.Drawing.Point(463, 108);
            this.groupBox_Hardware_jira.Name = "groupBox_Hardware_jira";
            this.groupBox_Hardware_jira.Size = new System.Drawing.Size(400, 110);
            this.groupBox_Hardware_jira.TabIndex = 18;
            this.groupBox_Hardware_jira.TabStop = false;
            this.groupBox_Hardware_jira.Text = "JIRA";
            // 
            // textBox_Hardware_jira
            // 
            this.textBox_Hardware_jira.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Hardware_jira.Enabled = false;
            this.textBox_Hardware_jira.Location = new System.Drawing.Point(7, 79);
            this.textBox_Hardware_jira.Name = "textBox_Hardware_jira";
            this.textBox_Hardware_jira.Size = new System.Drawing.Size(382, 23);
            this.textBox_Hardware_jira.TabIndex = 5;
            // 
            // checkBox_Hardware_jira
            // 
            this.checkBox_Hardware_jira.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Hardware_jira.AutoSize = true;
            this.checkBox_Hardware_jira.Location = new System.Drawing.Point(18, 52);
            this.checkBox_Hardware_jira.Name = "checkBox_Hardware_jira";
            this.checkBox_Hardware_jira.Size = new System.Drawing.Size(152, 21);
            this.checkBox_Hardware_jira.TabIndex = 4;
            this.checkBox_Hardware_jira.Text = "Новая задача JIRA";
            this.checkBox_Hardware_jira.UseVisualStyleBackColor = true;
            this.checkBox_Hardware_jira.CheckedChanged += new System.EventHandler(this.checkBox_Hardware_jira_CheckedChanged);
            // 
            // comboBox_Hardware_jira
            // 
            this.comboBox_Hardware_jira.FormattingEnabled = true;
            this.comboBox_Hardware_jira.Location = new System.Drawing.Point(7, 22);
            this.comboBox_Hardware_jira.Name = "comboBox_Hardware_jira";
            this.comboBox_Hardware_jira.Size = new System.Drawing.Size(382, 24);
            this.comboBox_Hardware_jira.TabIndex = 3;
            // 
            // groupBox_Hardware_TypeDevice
            // 
            this.groupBox_Hardware_TypeDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Hardware_TypeDevice.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_Hardware_TypeDevice.Controls.Add(this.textBox_Hardware_TypeDevice);
            this.groupBox_Hardware_TypeDevice.Controls.Add(this.checkBox_Hardware_TypeDevice);
            this.groupBox_Hardware_TypeDevice.Controls.Add(this.comboBox_Hardware_TypeDevice);
            this.groupBox_Hardware_TypeDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Hardware_TypeDevice.Location = new System.Drawing.Point(8, 112);
            this.groupBox_Hardware_TypeDevice.Name = "groupBox_Hardware_TypeDevice";
            this.groupBox_Hardware_TypeDevice.Size = new System.Drawing.Size(400, 110);
            this.groupBox_Hardware_TypeDevice.TabIndex = 14;
            this.groupBox_Hardware_TypeDevice.TabStop = false;
            this.groupBox_Hardware_TypeDevice.Text = "Вид оборудования ";
            // 
            // textBox_Hardware_TypeDevice
            // 
            this.textBox_Hardware_TypeDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Hardware_TypeDevice.Enabled = false;
            this.textBox_Hardware_TypeDevice.Location = new System.Drawing.Point(7, 79);
            this.textBox_Hardware_TypeDevice.Name = "textBox_Hardware_TypeDevice";
            this.textBox_Hardware_TypeDevice.Size = new System.Drawing.Size(387, 23);
            this.textBox_Hardware_TypeDevice.TabIndex = 2;
            // 
            // checkBox_Hardware_TypeDevice
            // 
            this.checkBox_Hardware_TypeDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Hardware_TypeDevice.AutoSize = true;
            this.checkBox_Hardware_TypeDevice.Location = new System.Drawing.Point(7, 52);
            this.checkBox_Hardware_TypeDevice.Name = "checkBox_Hardware_TypeDevice";
            this.checkBox_Hardware_TypeDevice.Size = new System.Drawing.Size(203, 21);
            this.checkBox_Hardware_TypeDevice.TabIndex = 1;
            this.checkBox_Hardware_TypeDevice.Text = "Новый вид оборудования  ";
            this.checkBox_Hardware_TypeDevice.UseVisualStyleBackColor = true;
            this.checkBox_Hardware_TypeDevice.CheckedChanged += new System.EventHandler(this.checkBox_Hardware_TypeDevice_CheckedChanged);
            // 
            // comboBox_Hardware_TypeDevice
            // 
            this.comboBox_Hardware_TypeDevice.FormattingEnabled = true;
            this.comboBox_Hardware_TypeDevice.Location = new System.Drawing.Point(7, 22);
            this.comboBox_Hardware_TypeDevice.Name = "comboBox_Hardware_TypeDevice";
            this.comboBox_Hardware_TypeDevice.Size = new System.Drawing.Size(387, 24);
            this.comboBox_Hardware_TypeDevice.TabIndex = 0;
            // 
            // groupBox_Hardware_Model
            // 
            this.groupBox_Hardware_Model.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Hardware_Model.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_Hardware_Model.Controls.Add(this.textBox_Hardware_Model);
            this.groupBox_Hardware_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Hardware_Model.Location = new System.Drawing.Point(8, 56);
            this.groupBox_Hardware_Model.Name = "groupBox_Hardware_Model";
            this.groupBox_Hardware_Model.Size = new System.Drawing.Size(400, 50);
            this.groupBox_Hardware_Model.TabIndex = 15;
            this.groupBox_Hardware_Model.TabStop = false;
            this.groupBox_Hardware_Model.Text = "Модель";
            // 
            // textBox_Hardware_Model
            // 
            this.textBox_Hardware_Model.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Hardware_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Hardware_Model.Location = new System.Drawing.Point(7, 17);
            this.textBox_Hardware_Model.Name = "textBox_Hardware_Model";
            this.textBox_Hardware_Model.Size = new System.Drawing.Size(384, 26);
            this.textBox_Hardware_Model.TabIndex = 2;
            // 
            // groupBox_Hardware_SN
            // 
            this.groupBox_Hardware_SN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Hardware_SN.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_Hardware_SN.Controls.Add(this.textBox_Hardware_SN);
            this.groupBox_Hardware_SN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Hardware_SN.Location = new System.Drawing.Point(463, 56);
            this.groupBox_Hardware_SN.Name = "groupBox_Hardware_SN";
            this.groupBox_Hardware_SN.Size = new System.Drawing.Size(400, 50);
            this.groupBox_Hardware_SN.TabIndex = 16;
            this.groupBox_Hardware_SN.TabStop = false;
            this.groupBox_Hardware_SN.Text = "Серийный номер";
            // 
            // textBox_Hardware_SN
            // 
            this.textBox_Hardware_SN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Hardware_SN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Hardware_SN.Location = new System.Drawing.Point(7, 20);
            this.textBox_Hardware_SN.Name = "textBox_Hardware_SN";
            this.textBox_Hardware_SN.Size = new System.Drawing.Size(382, 26);
            this.textBox_Hardware_SN.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button_OK, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_Cancel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 313);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(874, 53);
            this.tableLayoutPanel1.TabIndex = 20;
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
            // NewItemsHW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 366);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox_Note);
            this.Controls.Add(this.groupBox_Hardware_jira);
            this.Controls.Add(this.groupBox_Hardware_TypeDevice);
            this.Controls.Add(this.groupBox_Hardware_Model);
            this.Controls.Add(this.groupBox_Hardware_SN);
            this.Controls.Add(this.checkBox_SN);
            this.Controls.Add(this.textBox_Sum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_NumberInv);
            this.Controls.Add(this.label_NumberInv);
            this.Name = "NewItemsHW";
            this.Text = "NewItemsHW";
            this.groupBox_Note.ResumeLayout(false);
            this.groupBox_Note.PerformLayout();
            this.groupBox_Hardware_jira.ResumeLayout(false);
            this.groupBox_Hardware_jira.PerformLayout();
            this.groupBox_Hardware_TypeDevice.ResumeLayout(false);
            this.groupBox_Hardware_TypeDevice.PerformLayout();
            this.groupBox_Hardware_Model.ResumeLayout(false);
            this.groupBox_Hardware_Model.PerformLayout();
            this.groupBox_Hardware_SN.ResumeLayout(false);
            this.groupBox_Hardware_SN.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_NumberInv;
        private System.Windows.Forms.TextBox textBox_NumberInv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Sum;
        private System.Windows.Forms.CheckBox checkBox_SN;
        private System.Windows.Forms.GroupBox groupBox_Note;
        private System.Windows.Forms.TextBox textBox_Note;
        private System.Windows.Forms.GroupBox groupBox_Hardware_jira;
        private System.Windows.Forms.TextBox textBox_Hardware_jira;
        private System.Windows.Forms.CheckBox checkBox_Hardware_jira;
        private System.Windows.Forms.ComboBox comboBox_Hardware_jira;
        private System.Windows.Forms.GroupBox groupBox_Hardware_TypeDevice;
        private System.Windows.Forms.TextBox textBox_Hardware_TypeDevice;
        private System.Windows.Forms.CheckBox checkBox_Hardware_TypeDevice;
        private System.Windows.Forms.ComboBox comboBox_Hardware_TypeDevice;
        private System.Windows.Forms.GroupBox groupBox_Hardware_Model;
        private System.Windows.Forms.TextBox textBox_Hardware_Model;
        private System.Windows.Forms.GroupBox groupBox_Hardware_SN;
        private System.Windows.Forms.TextBox textBox_Hardware_SN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
    }
}