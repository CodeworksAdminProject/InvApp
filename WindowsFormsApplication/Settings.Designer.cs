namespace WindowsFormsApplication
{
    partial class Settings
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
            this.label_SqlServer = new System.Windows.Forms.Label();
            this.label_SqlPort = new System.Windows.Forms.Label();
            this.label_NameDB = new System.Windows.Forms.Label();
            this.textBox_SqlServer = new System.Windows.Forms.TextBox();
            this.textBox_SqlPort = new System.Windows.Forms.TextBox();
            this.textBox_NameDB = new System.Windows.Forms.TextBox();
            this.pictureBox_Image = new System.Windows.Forms.PictureBox();
            this.button_NewImaje = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.label_Logotip = new System.Windows.Forms.Label();
            this.textBox_LogatipPath = new System.Windows.Forms.TextBox();
            this.label_navigation = new System.Windows.Forms.Label();
            this.comboBox_navigation = new System.Windows.Forms.ComboBox();
            this.comboBox__print_BarKod = new System.Windows.Forms.ComboBox();
            this.label_print_BarKod = new System.Windows.Forms.Label();
            this.label_Mail = new System.Windows.Forms.Label();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // label_SqlServer
            // 
            this.label_SqlServer.AutoSize = true;
            this.label_SqlServer.Location = new System.Drawing.Point(15, 30);
            this.label_SqlServer.Name = "label_SqlServer";
            this.label_SqlServer.Size = new System.Drawing.Size(133, 20);
            this.label_SqlServer.TabIndex = 0;
            this.label_SqlServer.Text = "Сервер Sql хост:";
            // 
            // label_SqlPort
            // 
            this.label_SqlPort.AutoSize = true;
            this.label_SqlPort.Location = new System.Drawing.Point(15, 60);
            this.label_SqlPort.Name = "label_SqlPort";
            this.label_SqlPort.Size = new System.Drawing.Size(136, 20);
            this.label_SqlPort.TabIndex = 0;
            this.label_SqlPort.Text = "Сервер Sql порт:";
            // 
            // label_NameDB
            // 
            this.label_NameDB.AutoSize = true;
            this.label_NameDB.Location = new System.Drawing.Point(15, 90);
            this.label_NameDB.Name = "label_NameDB";
            this.label_NameDB.Size = new System.Drawing.Size(71, 20);
            this.label_NameDB.TabIndex = 0;
            this.label_NameDB.Text = "Имя БД:";
            // 
            // textBox_SqlServer
            // 
            this.textBox_SqlServer.Location = new System.Drawing.Point(205, 24);
            this.textBox_SqlServer.Name = "textBox_SqlServer";
            this.textBox_SqlServer.Size = new System.Drawing.Size(195, 26);
            this.textBox_SqlServer.TabIndex = 1;
            // 
            // textBox_SqlPort
            // 
            this.textBox_SqlPort.Location = new System.Drawing.Point(205, 54);
            this.textBox_SqlPort.Name = "textBox_SqlPort";
            this.textBox_SqlPort.Size = new System.Drawing.Size(195, 26);
            this.textBox_SqlPort.TabIndex = 1;
            // 
            // textBox_NameDB
            // 
            this.textBox_NameDB.Location = new System.Drawing.Point(205, 84);
            this.textBox_NameDB.Name = "textBox_NameDB";
            this.textBox_NameDB.Size = new System.Drawing.Size(195, 26);
            this.textBox_NameDB.TabIndex = 1;
            // 
            // pictureBox_Image
            // 
            this.pictureBox_Image.Location = new System.Drawing.Point(19, 394);
            this.pictureBox_Image.Name = "pictureBox_Image";
            this.pictureBox_Image.Size = new System.Drawing.Size(268, 152);
            this.pictureBox_Image.TabIndex = 2;
            this.pictureBox_Image.TabStop = false;
            // 
            // button_NewImaje
            // 
            this.button_NewImaje.ForeColor = System.Drawing.Color.Black;
            this.button_NewImaje.Location = new System.Drawing.Point(312, 394);
            this.button_NewImaje.Name = "button_NewImaje";
            this.button_NewImaje.Size = new System.Drawing.Size(88, 69);
            this.button_NewImaje.TabIndex = 3;
            this.button_NewImaje.Text = "Lode New\r\nImage";
            this.button_NewImaje.UseVisualStyleBackColor = true;
            this.button_NewImaje.Click += new System.EventHandler(this.button_NewImaje_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(312, 574);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(88, 28);
            this.button_Save.TabIndex = 3;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label_Logotip
            // 
            this.label_Logotip.AutoSize = true;
            this.label_Logotip.Location = new System.Drawing.Point(15, 365);
            this.label_Logotip.Name = "label_Logotip";
            this.label_Logotip.Size = new System.Drawing.Size(135, 20);
            this.label_Logotip.TabIndex = 0;
            this.label_Logotip.Text = "Путь к логотипу:";
            // 
            // textBox_LogatipPath
            // 
            this.textBox_LogatipPath.Location = new System.Drawing.Point(205, 359);
            this.textBox_LogatipPath.Name = "textBox_LogatipPath";
            this.textBox_LogatipPath.Size = new System.Drawing.Size(195, 26);
            this.textBox_LogatipPath.TabIndex = 1;
            // 
            // label_navigation
            // 
            this.label_navigation.AutoSize = true;
            this.label_navigation.Location = new System.Drawing.Point(15, 120);
            this.label_navigation.Name = "label_navigation";
            this.label_navigation.Size = new System.Drawing.Size(95, 20);
            this.label_navigation.TabIndex = 4;
            this.label_navigation.Text = "Навигатор:";
            // 
            // comboBox_navigation
            // 
            this.comboBox_navigation.FormattingEnabled = true;
            this.comboBox_navigation.Items.AddRange(new object[] {
            "По именам ПК",
            "По ответственным ",
            "По типу  устройства "});
            this.comboBox_navigation.Location = new System.Drawing.Point(205, 112);
            this.comboBox_navigation.Name = "comboBox_navigation";
            this.comboBox_navigation.Size = new System.Drawing.Size(195, 28);
            this.comboBox_navigation.TabIndex = 5;
            // 
            // comboBox__print_BarKod
            // 
            this.comboBox__print_BarKod.FormattingEnabled = true;
            this.comboBox__print_BarKod.Items.AddRange(new object[] {
            "ID базы ",
            "Инвентарный №"});
            this.comboBox__print_BarKod.Location = new System.Drawing.Point(206, 142);
            this.comboBox__print_BarKod.Name = "comboBox__print_BarKod";
            this.comboBox__print_BarKod.Size = new System.Drawing.Size(194, 28);
            this.comboBox__print_BarKod.TabIndex = 7;
            // 
            // label_print_BarKod
            // 
            this.label_print_BarKod.AutoSize = true;
            this.label_print_BarKod.Location = new System.Drawing.Point(15, 150);
            this.label_print_BarKod.Name = "label_print_BarKod";
            this.label_print_BarKod.Size = new System.Drawing.Size(142, 20);
            this.label_print_BarKod.TabIndex = 6;
            this.label_print_BarKod.Text = "Печать баркода: ";
            // 
            // label_Mail
            // 
            this.label_Mail.AutoSize = true;
            this.label_Mail.Location = new System.Drawing.Point(16, 276);
            this.label_Mail.Name = "label_Mail";
            this.label_Mail.Size = new System.Drawing.Size(152, 20);
            this.label_Mail.TabIndex = 0;
            this.label_Mail.Text = "Email  для  отчета:";
            // 
            // textBox_Mail
            // 
            this.textBox_Mail.Location = new System.Drawing.Point(206, 270);
            this.textBox_Mail.Name = "textBox_Mail";
            this.textBox_Mail.Size = new System.Drawing.Size(195, 26);
            this.textBox_Mail.TabIndex = 1;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 610);
            this.Controls.Add(this.comboBox__print_BarKod);
            this.Controls.Add(this.label_print_BarKod);
            this.Controls.Add(this.comboBox_navigation);
            this.Controls.Add(this.label_navigation);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_NewImaje);
            this.Controls.Add(this.pictureBox_Image);
            this.Controls.Add(this.textBox_LogatipPath);
            this.Controls.Add(this.textBox_Mail);
            this.Controls.Add(this.textBox_NameDB);
            this.Controls.Add(this.textBox_SqlPort);
            this.Controls.Add(this.textBox_SqlServer);
            this.Controls.Add(this.label_Logotip);
            this.Controls.Add(this.label_Mail);
            this.Controls.Add(this.label_NameDB);
            this.Controls.Add(this.label_SqlPort);
            this.Controls.Add(this.label_SqlServer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SqlServer;
        private System.Windows.Forms.Label label_SqlPort;
        private System.Windows.Forms.Label label_NameDB;
        private System.Windows.Forms.TextBox textBox_SqlServer;
        private System.Windows.Forms.TextBox textBox_SqlPort;
        private System.Windows.Forms.TextBox textBox_NameDB;
        private System.Windows.Forms.PictureBox pictureBox_Image;
        private System.Windows.Forms.Button button_NewImaje;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label_Logotip;
        private System.Windows.Forms.TextBox textBox_LogatipPath;
        private System.Windows.Forms.Label label_navigation;
        private System.Windows.Forms.ComboBox comboBox_navigation;
        private System.Windows.Forms.ComboBox comboBox__print_BarKod;
        private System.Windows.Forms.Label label_print_BarKod;
        private System.Windows.Forms.Label label_Mail;
        private System.Windows.Forms.TextBox textBox_Mail;
    }
}