namespace WindowsFormsApplication
{
    partial class SelectMethodToAddNewitem
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
            this.button_one = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_one
            // 
            this.button_one.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_one.Location = new System.Drawing.Point(12, 12);
            this.button_one.Name = "button_one";
            this.button_one.Size = new System.Drawing.Size(366, 90);
            this.button_one.TabIndex = 1;
            this.button_one.Text = "Добавить оду или несколько различных \r\nпозиций в любой учет.";
            this.button_one.UseVisualStyleBackColor = true;
            this.button_one.Click += new System.EventHandler(this.button_one_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(366, 90);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить несколько однотипных позиций в основной учет (с инвентарными номерами по" +
    " порядку).";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(366, 90);
            this.button2.TabIndex = 1;
            this.button2.Text = "Добавить несколько однотипных позиций в железо и расходники на склад (с инвентарн" +
    "ыми номерами по порядку).";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SelectMethodToAddNewitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 354);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_one);
            this.Name = "SelectMethodToAddNewitem";
            this.Text = "SelectMethodToAddNewitem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_one;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}