namespace WindowsFormsApplication
{
    partial class Move_Hardware
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button_shearch = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Label();
            this.Hardware = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_Inv_Num = new System.Windows.Forms.GroupBox();
            this.textBox_inv = new System.Windows.Forms.TextBox();
            this.groupBox_Res_Name = new System.Windows.Forms.GroupBox();
            this.textBox_Res = new System.Windows.Forms.TextBox();
            this.groupBox_namePC = new System.Windows.Forms.GroupBox();
            this.textBox_LanNam = new System.Windows.Forms.TextBox();
            this.groupBox_jira = new System.Windows.Forms.GroupBox();
            this.textBox_jira = new System.Windows.Forms.TextBox();
            this.comboBox_jira = new System.Windows.Forms.ComboBox();
            this.checkBox_jira = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel_buttoms = new System.Windows.Forms.FlowLayoutPanel();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_stockroom = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox_Inv_Num.SuspendLayout();
            this.groupBox_Res_Name.SuspendLayout();
            this.groupBox_namePC.SuspendLayout();
            this.groupBox_jira.SuspendLayout();
            this.flowLayoutPanel_buttoms.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Controls.Add(this.button_shearch, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.sum, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.Hardware, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1025, 112);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // button_shearch
            // 
            this.button_shearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_shearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_shearch.Location = new System.Drawing.Point(925, 59);
            this.button_shearch.Name = "button_shearch";
            this.button_shearch.Size = new System.Drawing.Size(97, 50);
            this.button_shearch.TabIndex = 0;
            this.button_shearch.Text = "Поиск ";
            this.button_shearch.UseVisualStyleBackColor = true;
            this.button_shearch.Click += new System.EventHandler(this.button_shearch_Click);
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sum.ForeColor = System.Drawing.Color.Maroon;
            this.sum.Location = new System.Drawing.Point(925, 3);
            this.sum.Margin = new System.Windows.Forms.Padding(3);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(61, 22);
            this.sum.TabIndex = 1;
            this.sum.Text = "label2";
            // 
            // Hardware
            // 
            this.Hardware.AutoSize = true;
            this.Hardware.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hardware.ForeColor = System.Drawing.Color.Maroon;
            this.Hardware.Location = new System.Drawing.Point(3, 3);
            this.Hardware.Margin = new System.Windows.Forms.Padding(3);
            this.Hardware.Name = "Hardware";
            this.Hardware.Size = new System.Drawing.Size(61, 22);
            this.Hardware.TabIndex = 0;
            this.Hardware.Text = "label1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox_Inv_Num, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox_Res_Name, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox_namePC, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 59);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(916, 50);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // groupBox_Inv_Num
            // 
            this.groupBox_Inv_Num.Controls.Add(this.textBox_inv);
            this.groupBox_Inv_Num.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Inv_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Inv_Num.Location = new System.Drawing.Point(3, 3);
            this.groupBox_Inv_Num.Name = "groupBox_Inv_Num";
            this.groupBox_Inv_Num.Size = new System.Drawing.Size(299, 44);
            this.groupBox_Inv_Num.TabIndex = 1;
            this.groupBox_Inv_Num.TabStop = false;
            this.groupBox_Inv_Num.Text = "Инвентарный номер ";
            // 
            // textBox_inv
            // 
            this.textBox_inv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_inv.Location = new System.Drawing.Point(6, 20);
            this.textBox_inv.Name = "textBox_inv";
            this.textBox_inv.Size = new System.Drawing.Size(287, 23);
            this.textBox_inv.TabIndex = 0;
            // 
            // groupBox_Res_Name
            // 
            this.groupBox_Res_Name.Controls.Add(this.textBox_Res);
            this.groupBox_Res_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Res_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Res_Name.Location = new System.Drawing.Point(613, 3);
            this.groupBox_Res_Name.Name = "groupBox_Res_Name";
            this.groupBox_Res_Name.Size = new System.Drawing.Size(300, 44);
            this.groupBox_Res_Name.TabIndex = 1;
            this.groupBox_Res_Name.TabStop = false;
            this.groupBox_Res_Name.Text = "Ответственный";
            // 
            // textBox_Res
            // 
            this.textBox_Res.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Res.Location = new System.Drawing.Point(6, 20);
            this.textBox_Res.Name = "textBox_Res";
            this.textBox_Res.Size = new System.Drawing.Size(287, 23);
            this.textBox_Res.TabIndex = 2;
            // 
            // groupBox_namePC
            // 
            this.groupBox_namePC.Controls.Add(this.textBox_LanNam);
            this.groupBox_namePC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_namePC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_namePC.Location = new System.Drawing.Point(308, 3);
            this.groupBox_namePC.Name = "groupBox_namePC";
            this.groupBox_namePC.Size = new System.Drawing.Size(299, 44);
            this.groupBox_namePC.TabIndex = 1;
            this.groupBox_namePC.TabStop = false;
            this.groupBox_namePC.Text = "Имя ПК";
            // 
            // textBox_LanNam
            // 
            this.textBox_LanNam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_LanNam.Location = new System.Drawing.Point(6, 20);
            this.textBox_LanNam.Name = "textBox_LanNam";
            this.textBox_LanNam.Size = new System.Drawing.Size(287, 23);
            this.textBox_LanNam.TabIndex = 1;
            // 
            // groupBox_jira
            // 
            this.groupBox_jira.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_jira.Controls.Add(this.textBox_jira);
            this.groupBox_jira.Controls.Add(this.comboBox_jira);
            this.groupBox_jira.Controls.Add(this.checkBox_jira);
            this.groupBox_jira.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_jira.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_jira.Location = new System.Drawing.Point(0, 112);
            this.groupBox_jira.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_jira.Name = "groupBox_jira";
            this.groupBox_jira.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_jira.Size = new System.Drawing.Size(1025, 52);
            this.groupBox_jira.TabIndex = 8;
            this.groupBox_jira.TabStop = false;
            this.groupBox_jira.Text = "Задача в JIRA";
            // 
            // textBox_jira
            // 
            this.textBox_jira.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_jira.Enabled = false;
            this.textBox_jira.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_jira.Location = new System.Drawing.Point(451, 19);
            this.textBox_jira.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_jira.Name = "textBox_jira";
            this.textBox_jira.Size = new System.Drawing.Size(222, 23);
            this.textBox_jira.TabIndex = 5;
            // 
            // comboBox_jira
            // 
            this.comboBox_jira.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_jira.FormattingEnabled = true;
            this.comboBox_jira.Location = new System.Drawing.Point(8, 19);
            this.comboBox_jira.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_jira.Name = "comboBox_jira";
            this.comboBox_jira.Size = new System.Drawing.Size(232, 24);
            this.comboBox_jira.TabIndex = 3;
            // 
            // checkBox_jira
            // 
            this.checkBox_jira.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_jira.AutoSize = true;
            this.checkBox_jira.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_jira.Location = new System.Drawing.Point(324, 19);
            this.checkBox_jira.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_jira.Name = "checkBox_jira";
            this.checkBox_jira.Size = new System.Drawing.Size(119, 21);
            this.checkBox_jira.TabIndex = 4;
            this.checkBox_jira.Text = "Новая задача";
            this.checkBox_jira.UseVisualStyleBackColor = true;
            this.checkBox_jira.CheckedChanged += new System.EventHandler(this.checkBox_jira_CheckedChanged);
            // 
            // flowLayoutPanel_buttoms
            // 
            this.flowLayoutPanel_buttoms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel_buttoms.Controls.Add(this.button_OK);
            this.flowLayoutPanel_buttoms.Controls.Add(this.button_stockroom);
            this.flowLayoutPanel_buttoms.Controls.Add(this.button_cancel);
            this.flowLayoutPanel_buttoms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel_buttoms.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel_buttoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayoutPanel_buttoms.Location = new System.Drawing.Point(0, 659);
            this.flowLayoutPanel_buttoms.Name = "flowLayoutPanel_buttoms";
            this.flowLayoutPanel_buttoms.Size = new System.Drawing.Size(1025, 46);
            this.flowLayoutPanel_buttoms.TabIndex = 9;
            // 
            // button_OK
            // 
            this.button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_OK.Location = new System.Drawing.Point(824, 2);
            this.button_OK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(194, 35);
            this.button_OK.TabIndex = 6;
            this.button_OK.Text = "Ok";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.Location = new System.Drawing.Point(557, 2);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 35);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Отмена ";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_stockroom
            // 
            this.button_stockroom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_stockroom.Location = new System.Drawing.Point(663, 2);
            this.button_stockroom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_stockroom.Name = "button_stockroom";
            this.button_stockroom.Size = new System.Drawing.Size(155, 35);
            this.button_stockroom.TabIndex = 8;
            this.button_stockroom.Text = "Вернуть на склад ";
            this.button_stockroom.UseVisualStyleBackColor = true;
            this.button_stockroom.Click += new System.EventHandler(this.button_stockroom_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Location = new System.Drawing.Point(0, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 481);
            this.panel1.TabIndex = 10;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1022, 481);
            this.dataGridView.TabIndex = 0;
            // 
            // Move_Hardware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 705);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel_buttoms);
            this.Controls.Add(this.groupBox_jira);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "Move_Hardware";
            this.Text = "Move_Hardware";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox_Inv_Num.ResumeLayout(false);
            this.groupBox_Inv_Num.PerformLayout();
            this.groupBox_Res_Name.ResumeLayout(false);
            this.groupBox_Res_Name.PerformLayout();
            this.groupBox_namePC.ResumeLayout(false);
            this.groupBox_namePC.PerformLayout();
            this.groupBox_jira.ResumeLayout(false);
            this.groupBox_jira.PerformLayout();
            this.flowLayoutPanel_buttoms.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button button_shearch;
        public System.Windows.Forms.Label sum;
        public System.Windows.Forms.Label Hardware;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox_Inv_Num;
        private System.Windows.Forms.TextBox textBox_inv;
        private System.Windows.Forms.GroupBox groupBox_Res_Name;
        private System.Windows.Forms.TextBox textBox_Res;
        private System.Windows.Forms.GroupBox groupBox_namePC;
        private System.Windows.Forms.TextBox textBox_LanNam;
        private System.Windows.Forms.GroupBox groupBox_jira;
        private System.Windows.Forms.TextBox textBox_jira;
        private System.Windows.Forms.ComboBox comboBox_jira;
        private System.Windows.Forms.CheckBox checkBox_jira;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_buttoms;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_cancel;
        public System.Windows.Forms.Button button_stockroom;
    }
}