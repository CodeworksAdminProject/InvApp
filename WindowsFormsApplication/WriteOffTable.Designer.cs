namespace WindowsFormsApplication
{
    partial class WriteOffTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WriteOffTable));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button_hardwarePC = new System.Windows.Forms.Button();
            this.button_Hardware_Stockroom = new System.Windows.Forms.Button();
            this.button_MainTB = new System.Windows.Forms.Button();
            this.button_New_data = new System.Windows.Forms.Button();
            this.button_deleteDataBase = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_WriteOffTable = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_WriteOffTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.button_New_data);
            this.panel1.Controls.Add(this.button_deleteDataBase);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 126);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.button_hardwarePC, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_Hardware_Stockroom, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_MainTB, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(899, 54);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // button_hardwarePC
            // 
            this.button_hardwarePC.BackColor = System.Drawing.SystemColors.Window;
            this.button_hardwarePC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_hardwarePC.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_hardwarePC.FlatAppearance.BorderSize = 0;
            this.button_hardwarePC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_hardwarePC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_hardwarePC.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_hardwarePC.Location = new System.Drawing.Point(601, 2);
            this.button_hardwarePC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_hardwarePC.Name = "button_hardwarePC";
            this.button_hardwarePC.Size = new System.Drawing.Size(295, 50);
            this.button_hardwarePC.TabIndex = 3;
            this.button_hardwarePC.Text = "Таблица железа и расходники на ПК";
            this.button_hardwarePC.UseVisualStyleBackColor = false;
            this.button_hardwarePC.Click += new System.EventHandler(this.button_hardwarePC_Click);
            this.button_hardwarePC.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_hardwarePC.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button_Hardware_Stockroom
            // 
            this.button_Hardware_Stockroom.BackColor = System.Drawing.SystemColors.Window;
            this.button_Hardware_Stockroom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Hardware_Stockroom.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Hardware_Stockroom.FlatAppearance.BorderSize = 0;
            this.button_Hardware_Stockroom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_Hardware_Stockroom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_Hardware_Stockroom.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_Hardware_Stockroom.Location = new System.Drawing.Point(302, 2);
            this.button_Hardware_Stockroom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Hardware_Stockroom.Name = "button_Hardware_Stockroom";
            this.button_Hardware_Stockroom.Size = new System.Drawing.Size(293, 50);
            this.button_Hardware_Stockroom.TabIndex = 2;
            this.button_Hardware_Stockroom.Text = "Таблица железа и расходники на складе";
            this.button_Hardware_Stockroom.UseVisualStyleBackColor = false;
            this.button_Hardware_Stockroom.Click += new System.EventHandler(this.button_Hardware_Stockroom_Click);
            this.button_Hardware_Stockroom.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_Hardware_Stockroom.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button_MainTB
            // 
            this.button_MainTB.BackColor = System.Drawing.SystemColors.Window;
            this.button_MainTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_MainTB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_MainTB.FlatAppearance.BorderSize = 0;
            this.button_MainTB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_MainTB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_MainTB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_MainTB.Location = new System.Drawing.Point(3, 2);
            this.button_MainTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_MainTB.Name = "button_MainTB";
            this.button_MainTB.Size = new System.Drawing.Size(293, 50);
            this.button_MainTB.TabIndex = 1;
            this.button_MainTB.Text = "Таблица основного учета";
            this.button_MainTB.UseVisualStyleBackColor = false;
            this.button_MainTB.Click += new System.EventHandler(this.button_MainTB_Click);
            this.button_MainTB.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_MainTB.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button_New_data
            // 
            this.button_New_data.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_New_data.BackgroundImage")));
            this.button_New_data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_New_data.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.button_New_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_New_data.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_New_data.Location = new System.Drawing.Point(3, 57);
            this.button_New_data.Name = "button_New_data";
            this.button_New_data.Size = new System.Drawing.Size(64, 64);
            this.button_New_data.TabIndex = 2;
            this.button_New_data.UseVisualStyleBackColor = true;
            this.button_New_data.Click += new System.EventHandler(this.button_New_data_Click);
            // 
            // button_deleteDataBase
            // 
            this.button_deleteDataBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_deleteDataBase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_deleteDataBase.BackgroundImage")));
            this.button_deleteDataBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_deleteDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_deleteDataBase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_deleteDataBase.Location = new System.Drawing.Point(823, 57);
            this.button_deleteDataBase.Name = "button_deleteDataBase";
            this.button_deleteDataBase.Size = new System.Drawing.Size(64, 64);
            this.button_deleteDataBase.TabIndex = 3;
            this.button_deleteDataBase.UseVisualStyleBackColor = true;
            this.button_deleteDataBase.Click += new System.EventHandler(this.button_deleteDataBase_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dataGridView_WriteOffTable);
            this.panel2.Location = new System.Drawing.Point(0, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(899, 441);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView_WriteOffTable
            // 
            this.dataGridView_WriteOffTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_WriteOffTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_WriteOffTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_WriteOffTable.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_WriteOffTable.Name = "dataGridView_WriteOffTable";
            this.dataGridView_WriteOffTable.Size = new System.Drawing.Size(899, 441);
            this.dataGridView_WriteOffTable.TabIndex = 0;
            // 
            // WriteOffTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 573);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "WriteOffTable";
            this.Text = "WriteOffTable";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_WriteOffTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_WriteOffTable;
        private System.Windows.Forms.Button button_New_data;
        private System.Windows.Forms.Button button_deleteDataBase;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button_hardwarePC;
        private System.Windows.Forms.Button button_Hardware_Stockroom;
        private System.Windows.Forms.Button button_MainTB;
    }
}