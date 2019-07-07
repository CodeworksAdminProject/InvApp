namespace WindowsFormsApplication
{
    partial class ChangeHardWare
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
            this.button_writtenoff = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.groupBox_jira = new System.Windows.Forms.GroupBox();
            this.textBox_jira = new System.Windows.Forms.TextBox();
            this.comboBox_jira = new System.Windows.Forms.ComboBox();
            this.checkBox_jira = new System.Windows.Forms.CheckBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_OK = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Device = new System.Windows.Forms.TextBox();
            this.checkBox_Device = new System.Windows.Forms.CheckBox();
            this.comboBox_Device = new System.Windows.Forms.ComboBox();
            this.Devices = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox_jira.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Devices.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button_writtenoff
            // 
            this.button_writtenoff.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.Horizontal_Line_48px;
            this.button_writtenoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_writtenoff.Location = new System.Drawing.Point(3, 3);
            this.button_writtenoff.Name = "button_writtenoff";
            this.button_writtenoff.Size = new System.Drawing.Size(52, 52);
            this.button_writtenoff.TabIndex = 0;
            this.button_writtenoff.UseVisualStyleBackColor = true;
            this.button_writtenoff.Click += new System.EventHandler(this.button_writtenoff_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.Trash_Can_48px;
            this.button_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_delete.Location = new System.Drawing.Point(61, 3);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(52, 52);
            this.button_delete.TabIndex = 0;
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // groupBox_jira
            // 
            this.groupBox_jira.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_jira.Controls.Add(this.textBox_jira);
            this.groupBox_jira.Controls.Add(this.comboBox_jira);
            this.groupBox_jira.Controls.Add(this.checkBox_jira);
            this.groupBox_jira.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_jira.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_jira.Location = new System.Drawing.Point(561, 5);
            this.groupBox_jira.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_jira.Name = "groupBox_jira";
            this.groupBox_jira.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_jira.Size = new System.Drawing.Size(549, 53);
            this.groupBox_jira.TabIndex = 7;
            this.groupBox_jira.TabStop = false;
            this.groupBox_jira.Text = "Задача в JIRA";
            // 
            // textBox_jira
            // 
            this.textBox_jira.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_jira.Enabled = false;
            this.textBox_jira.Location = new System.Drawing.Point(379, 20);
            this.textBox_jira.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_jira.Name = "textBox_jira";
            this.textBox_jira.Size = new System.Drawing.Size(161, 23);
            this.textBox_jira.TabIndex = 5;
            this.textBox_jira.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_jira_KeyUp);
            // 
            // comboBox_jira
            // 
            this.comboBox_jira.FormattingEnabled = true;
            this.comboBox_jira.Location = new System.Drawing.Point(8, 19);
            this.comboBox_jira.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_jira.Name = "comboBox_jira";
            this.comboBox_jira.Size = new System.Drawing.Size(161, 24);
            this.comboBox_jira.TabIndex = 3;
            this.comboBox_jira.SelectedIndexChanged += new System.EventHandler(this.comboBox_jira_SelectedIndexChanged);
            // 
            // checkBox_jira
            // 
            this.checkBox_jira.AutoSize = true;
            this.checkBox_jira.Location = new System.Drawing.Point(223, 22);
            this.checkBox_jira.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_jira.Name = "checkBox_jira";
            this.checkBox_jira.Size = new System.Drawing.Size(119, 21);
            this.checkBox_jira.TabIndex = 4;
            this.checkBox_jira.Text = "Новая задача";
            this.checkBox_jira.UseVisualStyleBackColor = true;
            this.checkBox_jira.CheckedChanged += new System.EventHandler(this.checkBox_jira_CheckedChanged);
            // 
            // button_cancel
            // 
            this.button_cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel.Location = new System.Drawing.Point(3, 2);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(371, 62);
            this.button_cancel.TabIndex = 6;
            this.button_cancel.Text = "Отмена ";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.button_writtenoff);
            this.flowLayoutPanel2.Controls.Add(this.button_delete);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(497, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(118, 60);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // button_OK
            // 
            this.button_OK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_OK.Location = new System.Drawing.Point(738, 2);
            this.button_OK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(373, 62);
            this.button_OK.TabIndex = 5;
            this.button_OK.Text = "Внести  изменения в базу (Ok)";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.09282F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.90401F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.91035F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.09282F));
            this.tableLayoutPanel2.Controls.Add(this.button_cancel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_OK, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 63);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1114, 66);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // textBox_Device
            // 
            this.textBox_Device.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Device.Enabled = false;
            this.textBox_Device.Location = new System.Drawing.Point(379, 20);
            this.textBox_Device.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Device.Name = "textBox_Device";
            this.textBox_Device.Size = new System.Drawing.Size(162, 23);
            this.textBox_Device.TabIndex = 5;
            // 
            // checkBox_Device
            // 
            this.checkBox_Device.AutoSize = true;
            this.checkBox_Device.Location = new System.Drawing.Point(182, 19);
            this.checkBox_Device.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_Device.Name = "checkBox_Device";
            this.checkBox_Device.Size = new System.Drawing.Size(195, 21);
            this.checkBox_Device.TabIndex = 4;
            this.checkBox_Device.Text = "Новый тип оборудования";
            this.checkBox_Device.UseVisualStyleBackColor = true;
            this.checkBox_Device.CheckedChanged += new System.EventHandler(this.checkBox_Device_CheckedChanged);
            // 
            // comboBox_Device
            // 
            this.comboBox_Device.FormattingEnabled = true;
            this.comboBox_Device.Location = new System.Drawing.Point(4, 19);
            this.comboBox_Device.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_Device.Name = "comboBox_Device";
            this.comboBox_Device.Size = new System.Drawing.Size(162, 24);
            this.comboBox_Device.TabIndex = 3;
            this.comboBox_Device.SelectedIndexChanged += new System.EventHandler(this.comboBox_Device_SelectedIndexChanged);
            this.comboBox_Device.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBox_Device_KeyUp);
            // 
            // Devices
            // 
            this.Devices.BackColor = System.Drawing.SystemColors.Control;
            this.Devices.Controls.Add(this.textBox_Device);
            this.Devices.Controls.Add(this.checkBox_Device);
            this.Devices.Controls.Add(this.comboBox_Device);
            this.Devices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Devices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Devices.Location = new System.Drawing.Point(4, 5);
            this.Devices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Devices.Name = "Devices";
            this.Devices.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Devices.Size = new System.Drawing.Size(549, 53);
            this.Devices.TabIndex = 3;
            this.Devices.TabStop = false;
            this.Devices.Text = "Тип оборудования";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox_jira, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Devices, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1114, 63);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(1114, 454);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные ";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowDrop = true;
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 22);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1108, 429);
            this.dataGridView.StandardTab = true;
            this.dataGridView.TabIndex = 0;
            // 
            // ChangeHardWare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 589);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChangeHardWare";
            this.Text = "ChangeHardWare";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChangeHardWare_FormClosed);
            this.groupBox_jira.ResumeLayout(false);
            this.groupBox_jira.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.Devices.ResumeLayout(false);
            this.Devices.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_writtenoff;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.GroupBox groupBox_jira;
        private System.Windows.Forms.TextBox textBox_jira;
        private System.Windows.Forms.ComboBox comboBox_jira;
        private System.Windows.Forms.CheckBox checkBox_jira;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox_Device;
        private System.Windows.Forms.CheckBox checkBox_Device;
        private System.Windows.Forms.ComboBox comboBox_Device;
        private System.Windows.Forms.GroupBox Devices;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}