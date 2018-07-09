namespace WindowsFormsApplication
{
    partial class HardWare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HardWare));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_HardWare = new System.Windows.Forms.DataGridView();
            this.button_New_data = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_deleteDataBase = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Repair = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HardWare)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dataGridView_HardWare);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 421);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView_HardWare
            // 
            this.dataGridView_HardWare.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_HardWare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HardWare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_HardWare.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_HardWare.Name = "dataGridView_HardWare";
            this.dataGridView_HardWare.Size = new System.Drawing.Size(479, 421);
            this.dataGridView_HardWare.TabIndex = 0;
            // 
            // button_New_data
            // 
            this.button_New_data.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_New_data.BackgroundImage")));
            this.button_New_data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_New_data.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.button_New_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_New_data.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_New_data.Location = new System.Drawing.Point(15, 3);
            this.button_New_data.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.button_New_data.Name = "button_New_data";
            this.button_New_data.Size = new System.Drawing.Size(64, 64);
            this.button_New_data.TabIndex = 2;
            this.button_New_data.UseVisualStyleBackColor = true;
            this.button_New_data.Click += new System.EventHandler(this.button_New_data_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Update.BackgroundImage")));
            this.button_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Update.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Update.Location = new System.Drawing.Point(114, 3);
            this.button_Update.Margin = new System.Windows.Forms.Padding(20, 3, 10, 3);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(64, 64);
            this.button_Update.TabIndex = 6;
            this.button_Update.UseVisualStyleBackColor = true;
            // 
            // button_deleteDataBase
            // 
            this.button_deleteDataBase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_deleteDataBase.BackgroundImage")));
            this.button_deleteDataBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_deleteDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_deleteDataBase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_deleteDataBase.Location = new System.Drawing.Point(302, 3);
            this.button_deleteDataBase.Margin = new System.Windows.Forms.Padding(20, 3, 10, 3);
            this.button_deleteDataBase.Name = "button_deleteDataBase";
            this.button_deleteDataBase.Size = new System.Drawing.Size(64, 64);
            this.button_deleteDataBase.TabIndex = 5;
            this.button_deleteDataBase.UseVisualStyleBackColor = true;
            this.button_deleteDataBase.Click += new System.EventHandler(this.button_deleteDataBase_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Delete.BackgroundImage")));
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Delete.Location = new System.Drawing.Point(396, 3);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(20, 3, 10, 3);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(64, 64);
            this.button_Delete.TabIndex = 4;
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Repair
            // 
            this.button_Repair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Repair.BackgroundImage")));
            this.button_Repair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Repair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Repair.Location = new System.Drawing.Point(208, 3);
            this.button_Repair.Margin = new System.Windows.Forms.Padding(20, 3, 10, 3);
            this.button_Repair.Name = "button_Repair";
            this.button_Repair.Size = new System.Drawing.Size(64, 64);
            this.button_Repair.TabIndex = 3;
            this.button_Repair.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.button_New_data);
            this.flowLayoutPanel2.Controls.Add(this.button_Update);
            this.flowLayoutPanel2.Controls.Add(this.button_Repair);
            this.flowLayoutPanel2.Controls.Add(this.button_deleteDataBase);
            this.flowLayoutPanel2.Controls.Add(this.button_Delete);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(479, 69);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // HardWare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 499);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel2);
            this.Name = "HardWare";
            this.Text = "HardWare";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HardWare)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_HardWare;
        private System.Windows.Forms.Button button_New_data;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_deleteDataBase;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Repair;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}