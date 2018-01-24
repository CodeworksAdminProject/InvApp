namespace WindowsFormsApplication
{
    partial class Delete
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
            this.textBox_Reason = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.comboBox_invinNumber = new System.Windows.Forms.ComboBox();
            this.label_TypeAccount = new System.Windows.Forms.Label();
            this.label_TypeDevice = new System.Windows.Forms.Label();
            this.label_NumberSN = new System.Windows.Forms.Label();
            this.label_Model = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_TA = new System.Windows.Forms.Label();
            this.label_TD = new System.Windows.Forms.Label();
            this.label_NS = new System.Windows.Forms.Label();
            this.label_M = new System.Windows.Forms.Label();
            this.label_Reason = new System.Windows.Forms.Label();
            this.button_Dell = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Reason
            // 
            this.textBox_Reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Reason.Location = new System.Drawing.Point(216, 242);
            this.textBox_Reason.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Reason.Name = "textBox_Reason";
            this.textBox_Reason.Size = new System.Drawing.Size(513, 29);
            this.textBox_Reason.TabIndex = 2;
            this.textBox_Reason.Text = "акт о списании за №";
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
            this.comboBox_invinNumber.Size = new System.Drawing.Size(451, 32);
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
            // label_TypeDevice
            // 
            this.label_TypeDevice.AutoSize = true;
            this.label_TypeDevice.Location = new System.Drawing.Point(23, 138);
            this.label_TypeDevice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TypeDevice.Name = "label_TypeDevice";
            this.label_TypeDevice.Size = new System.Drawing.Size(126, 20);
            this.label_TypeDevice.TabIndex = 6;
            this.label_TypeDevice.Text = "Тип устройства";
            // 
            // label_NumberSN
            // 
            this.label_NumberSN.AutoSize = true;
            this.label_NumberSN.Location = new System.Drawing.Point(21, 173);
            this.label_NumberSN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NumberSN.Name = "label_NumberSN";
            this.label_NumberSN.Size = new System.Drawing.Size(136, 20);
            this.label_NumberSN.TabIndex = 6;
            this.label_NumberSN.Text = "Серийный номер";
            // 
            // label_Model
            // 
            this.label_Model.AutoSize = true;
            this.label_Model.Location = new System.Drawing.Point(21, 208);
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
            this.groupBox1.Location = new System.Drawing.Point(3, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(731, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(725, 205);
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
            // label_TD
            // 
            this.label_TD.AutoSize = true;
            this.label_TD.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TD.Location = new System.Drawing.Point(214, 138);
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
            this.label_NS.Location = new System.Drawing.Point(212, 173);
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
            this.label_M.Location = new System.Drawing.Point(212, 208);
            this.label_M.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_M.Name = "label_M";
            this.label_M.Size = new System.Drawing.Size(79, 23);
            this.label_M.TabIndex = 6;
            this.label_M.Text = "Модель";
            // 
            // label_Reason
            // 
            this.label_Reason.AutoSize = true;
            this.label_Reason.Location = new System.Drawing.Point(21, 245);
            this.label_Reason.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Reason.Name = "label_Reason";
            this.label_Reason.Size = new System.Drawing.Size(152, 20);
            this.label_Reason.TabIndex = 6;
            this.label_Reason.Text = "Причина удаления";
            // 
            // button_Dell
            // 
            this.button_Dell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Dell.Location = new System.Drawing.Point(569, 25);
            this.button_Dell.Name = "button_Dell";
            this.button_Dell.Size = new System.Drawing.Size(160, 32);
            this.button_Dell.TabIndex = 7;
            this.button_Dell.Text = "Удалить";
            this.button_Dell.UseVisualStyleBackColor = true;
            this.button_Dell.Click += new System.EventHandler(this.button_Dell_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(746, 521);
            this.Controls.Add(this.button_Dell);
            this.Controls.Add(this.textBox_Reason);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_M);
            this.Controls.Add(this.label_Reason);
            this.Controls.Add(this.label_Model);
            this.Controls.Add(this.label_NS);
            this.Controls.Add(this.label_NumberSN);
            this.Controls.Add(this.label_TD);
            this.Controls.Add(this.label_TypeDevice);
            this.Controls.Add(this.label_TA);
            this.Controls.Add(this.label_TypeAccount);
            this.Controls.Add(this.comboBox_invinNumber);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Delete";
            this.Text = "SetNewDate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Delete_FormClosed);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Reason;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox comboBox_invinNumber;
        private System.Windows.Forms.Label label_TypeAccount;
        private System.Windows.Forms.Label label_TypeDevice;
        private System.Windows.Forms.Label label_NumberSN;
        private System.Windows.Forms.Label label_Model;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_TA;
        private System.Windows.Forms.Label label_TD;
        private System.Windows.Forms.Label label_NS;
        private System.Windows.Forms.Label label_M;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_Reason;
        private System.Windows.Forms.Button button_Dell;
    }
}
