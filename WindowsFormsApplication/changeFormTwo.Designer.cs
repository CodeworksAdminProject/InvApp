namespace WindowsFormsApplication
{
    partial class changeFormTwo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_jira = new System.Windows.Forms.GroupBox();
            this.textBox_jira = new System.Windows.Forms.TextBox();
            this.comboBox_jira = new System.Windows.Forms.ComboBox();
            this.checkBox_jira = new System.Windows.Forms.CheckBox();
            this.groupBox_AC = new System.Windows.Forms.GroupBox();
            this.textBox_AC = new System.Windows.Forms.TextBox();
            this.checkBox_AC = new System.Windows.Forms.CheckBox();
            this.comboBox_AC = new System.Windows.Forms.ComboBox();
            this.Devices = new System.Windows.Forms.GroupBox();
            this.textBox_Device = new System.Windows.Forms.TextBox();
            this.checkBox_Device = new System.Windows.Forms.CheckBox();
            this.comboBox_Device = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_cancel = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_writtenoff = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_print_select_str = new System.Windows.Forms.Button();
            this.button_print_all = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_jira.SuspendLayout();
            this.groupBox_AC.SuspendLayout();
            this.Devices.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(1145, 579);
            this.groupBox1.TabIndex = 1;
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
            this.dataGridView.Size = new System.Drawing.Size(1139, 554);
            this.dataGridView.StandardTab = true;
            this.dataGridView.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox_jira, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_AC, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Devices, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1145, 114);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // groupBox_jira
            // 
            this.groupBox_jira.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_jira.Controls.Add(this.textBox_jira);
            this.groupBox_jira.Controls.Add(this.comboBox_jira);
            this.groupBox_jira.Controls.Add(this.checkBox_jira);
            this.groupBox_jira.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_jira.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_jira.Location = new System.Drawing.Point(766, 5);
            this.groupBox_jira.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_jira.Name = "groupBox_jira";
            this.groupBox_jira.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_jira.Size = new System.Drawing.Size(375, 104);
            this.groupBox_jira.TabIndex = 7;
            this.groupBox_jira.TabStop = false;
            this.groupBox_jira.Text = "Задача в JIRA";
            // 
            // textBox_jira
            // 
            this.textBox_jira.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_jira.Enabled = false;
            this.textBox_jira.Location = new System.Drawing.Point(8, 74);
            this.textBox_jira.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_jira.Name = "textBox_jira";
            this.textBox_jira.Size = new System.Drawing.Size(358, 23);
            this.textBox_jira.TabIndex = 5;
            this.textBox_jira.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_jira_KeyUp);
            // 
            // comboBox_jira
            // 
            this.comboBox_jira.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_jira.FormattingEnabled = true;
            this.comboBox_jira.Location = new System.Drawing.Point(8, 19);
            this.comboBox_jira.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_jira.Name = "comboBox_jira";
            this.comboBox_jira.Size = new System.Drawing.Size(359, 24);
            this.comboBox_jira.TabIndex = 3;
            this.comboBox_jira.SelectedIndexChanged += new System.EventHandler(this.comboBox_jira_SelectedIndexChanged);
            // 
            // checkBox_jira
            // 
            this.checkBox_jira.AutoSize = true;
            this.checkBox_jira.Location = new System.Drawing.Point(8, 49);
            this.checkBox_jira.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_jira.Name = "checkBox_jira";
            this.checkBox_jira.Size = new System.Drawing.Size(119, 21);
            this.checkBox_jira.TabIndex = 4;
            this.checkBox_jira.Text = "Новая задача";
            this.checkBox_jira.UseVisualStyleBackColor = true;
            this.checkBox_jira.CheckedChanged += new System.EventHandler(this.checkBox_jira_CheckedChanged);
            // 
            // groupBox_AC
            // 
            this.groupBox_AC.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_AC.Controls.Add(this.textBox_AC);
            this.groupBox_AC.Controls.Add(this.checkBox_AC);
            this.groupBox_AC.Controls.Add(this.comboBox_AC);
            this.groupBox_AC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_AC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_AC.Location = new System.Drawing.Point(4, 5);
            this.groupBox_AC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_AC.Name = "groupBox_AC";
            this.groupBox_AC.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_AC.Size = new System.Drawing.Size(373, 104);
            this.groupBox_AC.TabIndex = 3;
            this.groupBox_AC.TabStop = false;
            this.groupBox_AC.Text = "Тип учёта  ";
            // 
            // textBox_AC
            // 
            this.textBox_AC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_AC.Enabled = false;
            this.textBox_AC.Location = new System.Drawing.Point(9, 74);
            this.textBox_AC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_AC.Name = "textBox_AC";
            this.textBox_AC.Size = new System.Drawing.Size(356, 23);
            this.textBox_AC.TabIndex = 5;
            this.textBox_AC.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_AC_KeyUp);
            // 
            // checkBox_AC
            // 
            this.checkBox_AC.AutoSize = true;
            this.checkBox_AC.Location = new System.Drawing.Point(9, 49);
            this.checkBox_AC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_AC.Name = "checkBox_AC";
            this.checkBox_AC.Size = new System.Drawing.Size(143, 21);
            this.checkBox_AC.TabIndex = 4;
            this.checkBox_AC.Text = "Новый тип учёта ";
            this.checkBox_AC.UseVisualStyleBackColor = true;
            this.checkBox_AC.CheckedChanged += new System.EventHandler(this.checkBox_AC_CheckedChanged);
            // 
            // comboBox_AC
            // 
            this.comboBox_AC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_AC.FormattingEnabled = true;
            this.comboBox_AC.Location = new System.Drawing.Point(9, 19);
            this.comboBox_AC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_AC.Name = "comboBox_AC";
            this.comboBox_AC.Size = new System.Drawing.Size(356, 24);
            this.comboBox_AC.TabIndex = 3;
            this.comboBox_AC.SelectedIndexChanged += new System.EventHandler(this.comboBox_AC_SelectedIndexChanged);
            // 
            // Devices
            // 
            this.Devices.BackColor = System.Drawing.SystemColors.Control;
            this.Devices.Controls.Add(this.textBox_Device);
            this.Devices.Controls.Add(this.checkBox_Device);
            this.Devices.Controls.Add(this.comboBox_Device);
            this.Devices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Devices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Devices.Location = new System.Drawing.Point(385, 5);
            this.Devices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Devices.Name = "Devices";
            this.Devices.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Devices.Size = new System.Drawing.Size(373, 104);
            this.Devices.TabIndex = 3;
            this.Devices.TabStop = false;
            this.Devices.Text = "Тип оборудования";
            // 
            // textBox_Device
            // 
            this.textBox_Device.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Device.Enabled = false;
            this.textBox_Device.Location = new System.Drawing.Point(4, 74);
            this.textBox_Device.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Device.Name = "textBox_Device";
            this.textBox_Device.Size = new System.Drawing.Size(361, 23);
            this.textBox_Device.TabIndex = 5;
            this.textBox_Device.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Device_KeyUp);
            // 
            // checkBox_Device
            // 
            this.checkBox_Device.AutoSize = true;
            this.checkBox_Device.Location = new System.Drawing.Point(8, 49);
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
            this.comboBox_Device.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Device.FormattingEnabled = true;
            this.comboBox_Device.Location = new System.Drawing.Point(4, 19);
            this.comboBox_Device.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_Device.Name = "comboBox_Device";
            this.comboBox_Device.Size = new System.Drawing.Size(361, 24);
            this.comboBox_Device.TabIndex = 3;
            this.comboBox_Device.SelectedIndexChanged += new System.EventHandler(this.comboBox_Device_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.09282F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.90401F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 238F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.91035F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.09282F));
            this.tableLayoutPanel2.Controls.Add(this.button_cancel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_OK, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 114);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1145, 66);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // button_cancel
            // 
            this.button_cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel.Location = new System.Drawing.Point(3, 2);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(339, 62);
            this.button_cancel.TabIndex = 6;
            this.button_cancel.Text = "Отмена ";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.button_writtenoff);
            this.flowLayoutPanel2.Controls.Add(this.button_delete);
            this.flowLayoutPanel2.Controls.Add(this.button_print_select_str);
            this.flowLayoutPanel2.Controls.Add(this.button_print_all);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(455, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(232, 60);
            this.flowLayoutPanel2.TabIndex = 0;
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
            // button_print_select_str
            // 
            this.button_print_select_str.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.Typewriter_With_Screen_48px;
            this.button_print_select_str.Location = new System.Drawing.Point(119, 3);
            this.button_print_select_str.Name = "button_print_select_str";
            this.button_print_select_str.Size = new System.Drawing.Size(52, 52);
            this.button_print_select_str.TabIndex = 0;
            this.button_print_select_str.UseVisualStyleBackColor = true;
            this.button_print_select_str.Click += new System.EventHandler(this.button_print_select_str_Click);
            // 
            // button_print_all
            // 
            this.button_print_all.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.Print_48px;
            this.button_print_all.Location = new System.Drawing.Point(177, 3);
            this.button_print_all.Name = "button_print_all";
            this.button_print_all.Size = new System.Drawing.Size(52, 52);
            this.button_print_all.TabIndex = 0;
            this.button_print_all.UseVisualStyleBackColor = true;
            this.button_print_all.Click += new System.EventHandler(this.button_print_all_Click);
            // 
            // button_OK
            // 
            this.button_OK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_OK.Location = new System.Drawing.Point(801, 2);
            this.button_OK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(341, 62);
            this.button_OK.TabIndex = 5;
            this.button_OK.Text = "Внести  изменения в базу (Ok)";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // changeFormTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 762);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "changeFormTwo";
            this.Text = "changeFormTwo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.changeFormTwo_FormClosed);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox_jira.ResumeLayout(false);
            this.groupBox_jira.PerformLayout();
            this.groupBox_AC.ResumeLayout(false);
            this.groupBox_AC.PerformLayout();
            this.Devices.ResumeLayout(false);
            this.Devices.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox_jira;
        private System.Windows.Forms.TextBox textBox_jira;
        private System.Windows.Forms.ComboBox comboBox_jira;
        private System.Windows.Forms.CheckBox checkBox_jira;
        private System.Windows.Forms.GroupBox groupBox_AC;
        private System.Windows.Forms.TextBox textBox_AC;
        private System.Windows.Forms.CheckBox checkBox_AC;
        private System.Windows.Forms.ComboBox comboBox_AC;
        private System.Windows.Forms.GroupBox Devices;
        private System.Windows.Forms.TextBox textBox_Device;
        private System.Windows.Forms.CheckBox checkBox_Device;
        private System.Windows.Forms.ComboBox comboBox_Device;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_print_all;
        private System.Windows.Forms.Button button_print_select_str;
        private System.Windows.Forms.Button button_writtenoff;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_cancel;
    }
}