namespace WindowsFormsApplication
{
    partial class WriteOff
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
            this.info = new System.Windows.Forms.Label();
            this.reason = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.Location = new System.Drawing.Point(135, 39);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(262, 45);
            this.info.TabIndex = 0;
            this.info.Text = "Укажите причину списания кратко \r\n(пример: вышло из строя или продан и т.д. )\r\nдо" +
    " 50 символов \r\n";
            // 
            // reason
            // 
            this.reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reason.Location = new System.Drawing.Point(36, 13);
            this.reason.Name = "reason";
            this.reason.Size = new System.Drawing.Size(459, 23);
            this.reason.TabIndex = 2;
            // 
            // button_OK
            // 
            this.button_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_OK.Location = new System.Drawing.Point(402, 7);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(130, 32);
            this.button_OK.TabIndex = 3;
            this.button_OK.Text = "Снять отметку";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Cancel.Location = new System.Drawing.Point(3, 7);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(130, 32);
            this.button_Cancel.TabIndex = 3;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_OK);
            this.panel1.Controls.Add(this.button_Cancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 47);
            this.panel1.TabIndex = 4;
            // 
            // WriteOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 167);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reason);
            this.Controls.Add(this.info);
            this.Name = "WriteOff";
            this.Text = "WriteOff";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label info;
        public System.Windows.Forms.TextBox reason;
        public System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Panel panel1;
    }
}