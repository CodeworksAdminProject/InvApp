namespace WindowsFormsApplication
{
    partial class SN
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(8, 13);
            this.textBox.Margin = new System.Windows.Forms.Padding(4);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(388, 23);
            this.textBox.TabIndex = 0;
            this.textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(296, 44);
            this.button.Margin = new System.Windows.Forms.Padding(4);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(100, 28);
            this.button.TabIndex = 1;
            this.button.Text = "button";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // SN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 84);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SN";
            this.Text = "SN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox;
        public System.Windows.Forms.Button button;
    }
}