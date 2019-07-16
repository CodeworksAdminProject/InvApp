namespace WindowsFormsApplication
{
    partial class Reports
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
            this.button_exc_file = new System.Windows.Forms.Button();
            this.button_exc_mail = new System.Windows.Forms.Button();
            this.textBox_exc_file = new System.Windows.Forms.TextBox();
            this.label_exc_file = new System.Windows.Forms.Label();
            this.textBox_exc_mail = new System.Windows.Forms.TextBox();
            this.label_exc_mail = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // button_exc_file
            // 
            this.button_exc_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exc_file.Location = new System.Drawing.Point(34, 25);
            this.button_exc_file.Name = "button_exc_file";
            this.button_exc_file.Size = new System.Drawing.Size(153, 57);
            this.button_exc_file.TabIndex = 0;
            this.button_exc_file.Text = "Отчет в excel файл ";
            this.button_exc_file.UseVisualStyleBackColor = true;
            this.button_exc_file.Click += new System.EventHandler(this.button_exc_file_Click);
            // 
            // button_exc_mail
            // 
            this.button_exc_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exc_mail.Location = new System.Drawing.Point(34, 100);
            this.button_exc_mail.Name = "button_exc_mail";
            this.button_exc_mail.Size = new System.Drawing.Size(153, 57);
            this.button_exc_mail.TabIndex = 0;
            this.button_exc_mail.Text = "Отчет в excel  по почте";
            this.button_exc_mail.UseVisualStyleBackColor = true;
            this.button_exc_mail.Click += new System.EventHandler(this.button_exc_mail_Click);
            // 
            // textBox_exc_file
            // 
            this.textBox_exc_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_exc_file.Location = new System.Drawing.Point(229, 25);
            this.textBox_exc_file.Name = "textBox_exc_file";
            this.textBox_exc_file.Size = new System.Drawing.Size(227, 26);
            this.textBox_exc_file.TabIndex = 1;
            // 
            // label_exc_file
            // 
            this.label_exc_file.AutoSize = true;
            this.label_exc_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_exc_file.Location = new System.Drawing.Point(272, 54);
            this.label_exc_file.Name = "label_exc_file";
            this.label_exc_file.Size = new System.Drawing.Size(138, 17);
            this.label_exc_file.TabIndex = 2;
            this.label_exc_file.Text = "полный путь файла";
            // 
            // textBox_exc_mail
            // 
            this.textBox_exc_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_exc_mail.Location = new System.Drawing.Point(229, 100);
            this.textBox_exc_mail.Name = "textBox_exc_mail";
            this.textBox_exc_mail.Size = new System.Drawing.Size(227, 26);
            this.textBox_exc_mail.TabIndex = 1;
            // 
            // label_exc_mail
            // 
            this.label_exc_mail.AutoSize = true;
            this.label_exc_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_exc_mail.Location = new System.Drawing.Point(318, 129);
            this.label_exc_mail.Name = "label_exc_mail";
            this.label_exc_mail.Size = new System.Drawing.Size(41, 17);
            this.label_exc_mail.TabIndex = 2;
            this.label_exc_mail.Text = "email";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(34, 177);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(422, 31);
            this.progressBar1.TabIndex = 3;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 232);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label_exc_mail);
            this.Controls.Add(this.label_exc_file);
            this.Controls.Add(this.textBox_exc_mail);
            this.Controls.Add(this.textBox_exc_file);
            this.Controls.Add(this.button_exc_mail);
            this.Controls.Add(this.button_exc_file);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mn-mssql01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_exc_file;
        private System.Windows.Forms.Button button_exc_mail;
        private System.Windows.Forms.TextBox textBox_exc_file;
        private System.Windows.Forms.Label label_exc_file;
        private System.Windows.Forms.TextBox textBox_exc_mail;
        private System.Windows.Forms.Label label_exc_mail;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}