namespace WindowsFormsApplication
{
    partial class Send_mail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Send_mail));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_AddFile = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.button_sentEmail = new System.Windows.Forms.Button();
            this.groupBox_Contact = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_Contact.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(91, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "fedorov.i@codeworks.by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(91, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zimbos85";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(9, 123);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(469, 138);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // button_AddFile
            // 
            this.button_AddFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_AddFile.BackgroundImage")));
            this.button_AddFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_AddFile.Location = new System.Drawing.Point(9, 267);
            this.button_AddFile.Name = "button_AddFile";
            this.button_AddFile.Size = new System.Drawing.Size(67, 64);
            this.button_AddFile.TabIndex = 3;
            this.toolTip.SetToolTip(this.button_AddFile, "Подкрипить скрин ");
            this.button_AddFile.UseVisualStyleBackColor = true;
            this.button_AddFile.Click += new System.EventHandler(this.button_AddFile_Click);
            // 
            // button_sentEmail
            // 
            this.button_sentEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_sentEmail.BackgroundImage")));
            this.button_sentEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_sentEmail.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_sentEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_sentEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_sentEmail.Location = new System.Drawing.Point(6, 334);
            this.button_sentEmail.Margin = new System.Windows.Forms.Padding(0);
            this.button_sentEmail.Name = "button_sentEmail";
            this.button_sentEmail.Size = new System.Drawing.Size(67, 64);
            this.button_sentEmail.TabIndex = 5;
            this.toolTip.SetToolTip(this.button_sentEmail, "Отправить письмо сейчас");
            this.button_sentEmail.UseVisualStyleBackColor = true;
            this.button_sentEmail.Click += new System.EventHandler(this.button_sentEmail_Click);
            // 
            // groupBox_Contact
            // 
            this.groupBox_Contact.Controls.Add(this.label2);
            this.groupBox_Contact.Controls.Add(this.label1);
            this.groupBox_Contact.Controls.Add(this.pictureBox2);
            this.groupBox_Contact.Controls.Add(this.pictureBox1);
            this.groupBox_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Contact.Location = new System.Drawing.Point(3, 10);
            this.groupBox_Contact.Name = "groupBox_Contact";
            this.groupBox_Contact.Size = new System.Drawing.Size(481, 188);
            this.groupBox_Contact.TabIndex = 4;
            this.groupBox_Contact.TabStop = false;
            this.groupBox_Contact.Text = "Контакты:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button_sentEmail);
            this.groupBox2.Controls.Add(this.pictureBox_Image);
            this.groupBox2.Controls.Add(this.button_AddFile);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(3, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 405);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Отправить письмо прямо сейчас ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(392, 29);
            this.textBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Текст письма:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Тема: ";
            // 
            // pictureBox_Image
            // 
            this.pictureBox_Image.Location = new System.Drawing.Point(82, 267);
            this.pictureBox_Image.Name = "pictureBox_Image";
            this.pictureBox_Image.Size = new System.Drawing.Size(393, 64);
            this.pictureBox_Image.TabIndex = 4;
            this.pictureBox_Image.TabStop = false;
            // 
            // Send_mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 630);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_Contact);
            this.Name = "Send_mail";
            this.Text = "Обратная связь";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_Contact.ResumeLayout(false);
            this.groupBox_Contact.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_AddFile;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBox_Contact;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_sentEmail;
        private System.Windows.Forms.PictureBox pictureBox_Image;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}