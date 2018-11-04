namespace WindowsFormsApplication
{
    partial class Html_report_form
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
            this.mainForms_mainTB_note = new System.Windows.Forms.CheckBox();
            this.mainForms_mainTB_JiraTask = new System.Windows.Forms.CheckBox();
            this.mainForms_mainTB_TypeAC = new System.Windows.Forms.CheckBox();
            this.mainForms_mainTB_ID = new System.Windows.Forms.CheckBox();
            this.mainForms_mainTB_date = new System.Windows.Forms.CheckBox();
            this.label_mainTB = new System.Windows.Forms.Label();
            this.mainForms_hardware_note = new System.Windows.Forms.CheckBox();
            this.mainForms_hardware_JiraTask = new System.Windows.Forms.CheckBox();
            this.mainForms_hardware_ID = new System.Windows.Forms.CheckBox();
            this.mainForms_hardware_date = new System.Windows.Forms.CheckBox();
            this.label_Hardware = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mainForms_stockroom_WrittenOff = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainForms_mainTB_note
            // 
            this.mainForms_mainTB_note.AutoSize = true;
            this.mainForms_mainTB_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainForms_mainTB_note.Location = new System.Drawing.Point(514, 49);
            this.mainForms_mainTB_note.Name = "mainForms_mainTB_note";
            this.mainForms_mainTB_note.Size = new System.Drawing.Size(114, 21);
            this.mainForms_mainTB_note.TabIndex = 53;
            this.mainForms_mainTB_note.Text = "Примечание ";
            this.mainForms_mainTB_note.UseVisualStyleBackColor = true;
            // 
            // mainForms_mainTB_JiraTask
            // 
            this.mainForms_mainTB_JiraTask.AutoSize = true;
            this.mainForms_mainTB_JiraTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainForms_mainTB_JiraTask.Location = new System.Drawing.Point(341, 49);
            this.mainForms_mainTB_JiraTask.Name = "mainForms_mainTB_JiraTask";
            this.mainForms_mainTB_JiraTask.Size = new System.Drawing.Size(120, 21);
            this.mainForms_mainTB_JiraTask.TabIndex = 54;
            this.mainForms_mainTB_JiraTask.Text = "Задача в JIRA";
            this.mainForms_mainTB_JiraTask.UseVisualStyleBackColor = true;
            // 
            // mainForms_mainTB_TypeAC
            // 
            this.mainForms_mainTB_TypeAC.AutoSize = true;
            this.mainForms_mainTB_TypeAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainForms_mainTB_TypeAC.Location = new System.Drawing.Point(196, 49);
            this.mainForms_mainTB_TypeAC.Name = "mainForms_mainTB_TypeAC";
            this.mainForms_mainTB_TypeAC.Size = new System.Drawing.Size(94, 21);
            this.mainForms_mainTB_TypeAC.TabIndex = 55;
            this.mainForms_mainTB_TypeAC.Text = "Вид учёта";
            this.mainForms_mainTB_TypeAC.UseVisualStyleBackColor = true;
            // 
            // mainForms_mainTB_ID
            // 
            this.mainForms_mainTB_ID.AutoSize = true;
            this.mainForms_mainTB_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainForms_mainTB_ID.Location = new System.Drawing.Point(10, 49);
            this.mainForms_mainTB_ID.Name = "mainForms_mainTB_ID";
            this.mainForms_mainTB_ID.Size = new System.Drawing.Size(40, 21);
            this.mainForms_mainTB_ID.TabIndex = 56;
            this.mainForms_mainTB_ID.Text = "ID";
            this.mainForms_mainTB_ID.UseVisualStyleBackColor = true;
            // 
            // mainForms_mainTB_date
            // 
            this.mainForms_mainTB_date.AutoSize = true;
            this.mainForms_mainTB_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainForms_mainTB_date.Location = new System.Drawing.Point(85, 49);
            this.mainForms_mainTB_date.Name = "mainForms_mainTB_date";
            this.mainForms_mainTB_date.Size = new System.Drawing.Size(65, 21);
            this.mainForms_mainTB_date.TabIndex = 57;
            this.mainForms_mainTB_date.Text = "Дата ";
            this.mainForms_mainTB_date.UseVisualStyleBackColor = true;
            // 
            // label_mainTB
            // 
            this.label_mainTB.AutoSize = true;
            this.label_mainTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_mainTB.Location = new System.Drawing.Point(6, 26);
            this.label_mainTB.Name = "label_mainTB";
            this.label_mainTB.Size = new System.Drawing.Size(206, 20);
            this.label_mainTB.TabIndex = 52;
            this.label_mainTB.Text = "Таблица  основного учета";
            // 
            // mainForms_hardware_note
            // 
            this.mainForms_hardware_note.AutoSize = true;
            this.mainForms_hardware_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainForms_hardware_note.Location = new System.Drawing.Point(514, 107);
            this.mainForms_hardware_note.Name = "mainForms_hardware_note";
            this.mainForms_hardware_note.Size = new System.Drawing.Size(114, 21);
            this.mainForms_hardware_note.TabIndex = 60;
            this.mainForms_hardware_note.Text = "Примечание ";
            this.mainForms_hardware_note.UseVisualStyleBackColor = true;
            // 
            // mainForms_hardware_JiraTask
            // 
            this.mainForms_hardware_JiraTask.AutoSize = true;
            this.mainForms_hardware_JiraTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainForms_hardware_JiraTask.Location = new System.Drawing.Point(341, 107);
            this.mainForms_hardware_JiraTask.Name = "mainForms_hardware_JiraTask";
            this.mainForms_hardware_JiraTask.Size = new System.Drawing.Size(120, 21);
            this.mainForms_hardware_JiraTask.TabIndex = 61;
            this.mainForms_hardware_JiraTask.Text = "Задача в JIRA";
            this.mainForms_hardware_JiraTask.UseVisualStyleBackColor = true;
            this.mainForms_hardware_JiraTask.CheckedChanged += new System.EventHandler(this.mainForms_hardware_JiraTask_CheckedChanged);
            // 
            // mainForms_hardware_ID
            // 
            this.mainForms_hardware_ID.AutoSize = true;
            this.mainForms_hardware_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainForms_hardware_ID.Location = new System.Drawing.Point(10, 107);
            this.mainForms_hardware_ID.Name = "mainForms_hardware_ID";
            this.mainForms_hardware_ID.Size = new System.Drawing.Size(40, 21);
            this.mainForms_hardware_ID.TabIndex = 62;
            this.mainForms_hardware_ID.Text = "ID";
            this.mainForms_hardware_ID.UseVisualStyleBackColor = true;
            this.mainForms_hardware_ID.CheckedChanged += new System.EventHandler(this.mainForms_hardware_ID_CheckedChanged);
            // 
            // mainForms_hardware_date
            // 
            this.mainForms_hardware_date.AutoSize = true;
            this.mainForms_hardware_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainForms_hardware_date.Location = new System.Drawing.Point(85, 112);
            this.mainForms_hardware_date.Name = "mainForms_hardware_date";
            this.mainForms_hardware_date.Size = new System.Drawing.Size(65, 21);
            this.mainForms_hardware_date.TabIndex = 63;
            this.mainForms_hardware_date.Text = "Дата ";
            this.mainForms_hardware_date.UseVisualStyleBackColor = true;
            // 
            // label_Hardware
            // 
            this.label_Hardware.AutoSize = true;
            this.label_Hardware.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Hardware.Location = new System.Drawing.Point(6, 84);
            this.label_Hardware.Name = "label_Hardware";
            this.label_Hardware.Size = new System.Drawing.Size(297, 20);
            this.label_Hardware.TabIndex = 59;
            this.label_Hardware.Text = "Таблица  аппаратные средства на ПК";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mainForms_stockroom_WrittenOff);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_mainTB);
            this.groupBox1.Controls.Add(this.mainForms_hardware_note);
            this.groupBox1.Controls.Add(this.mainForms_mainTB_date);
            this.groupBox1.Controls.Add(this.mainForms_hardware_JiraTask);
            this.groupBox1.Controls.Add(this.mainForms_mainTB_ID);
            this.groupBox1.Controls.Add(this.mainForms_hardware_ID);
            this.groupBox1.Controls.Add(this.mainForms_mainTB_TypeAC);
            this.groupBox1.Controls.Add(this.mainForms_hardware_date);
            this.groupBox1.Controls.Add(this.mainForms_mainTB_JiraTask);
            this.groupBox1.Controls.Add(this.label_Hardware);
            this.groupBox1.Controls.Add(this.mainForms_mainTB_note);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 194);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить столбци в отчет ";
            // 
            // mainForms_stockroom_WrittenOff
            // 
            this.mainForms_stockroom_WrittenOff.AutoSize = true;
            this.mainForms_stockroom_WrittenOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainForms_stockroom_WrittenOff.Location = new System.Drawing.Point(196, 164);
            this.mainForms_stockroom_WrittenOff.Name = "mainForms_stockroom_WrittenOff";
            this.mainForms_stockroom_WrittenOff.Size = new System.Drawing.Size(83, 21);
            this.mainForms_stockroom_WrittenOff.TabIndex = 69;
            this.mainForms_stockroom_WrittenOff.Text = "Списано";
            this.mainForms_stockroom_WrittenOff.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(514, 164);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 21);
            this.checkBox1.TabIndex = 65;
            this.checkBox1.Text = "Примечание ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.Location = new System.Drawing.Point(341, 164);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(120, 21);
            this.checkBox2.TabIndex = 66;
            this.checkBox2.Text = "Задача в JIRA";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox3.Location = new System.Drawing.Point(10, 164);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(40, 21);
            this.checkBox3.TabIndex = 67;
            this.checkBox3.Text = "ID";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox4.Location = new System.Drawing.Point(85, 164);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(65, 21);
            this.checkBox4.TabIndex = 68;
            this.checkBox4.Text = "Дата ";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "Таблица железа и расходники на складе";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox13);
            this.groupBox2.Controls.Add(this.checkBox14);
            this.groupBox2.Controls.Add(this.checkBox16);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(0, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 194);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Как отправить  ";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox6.Location = new System.Drawing.Point(10, 155);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(290, 21);
            this.checkBox6.TabIndex = 70;
            this.checkBox6.Text = "Отправить на почту со всеми файлами ";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox5.Location = new System.Drawing.Point(10, 65);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(257, 21);
            this.checkBox5.TabIndex = 69;
            this.checkBox5.Text = "Создать HTML файл для Confluens";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox13.Location = new System.Drawing.Point(10, 35);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(162, 21);
            this.checkBox13.TabIndex = 56;
            this.checkBox13.Text = "Создать HTML файл";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox14.Location = new System.Drawing.Point(10, 95);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(164, 21);
            this.checkBox14.TabIndex = 62;
            this.checkBox14.Text = "Отправить на почту ";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox16.Location = new System.Drawing.Point(10, 125);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(256, 21);
            this.checkBox16.TabIndex = 63;
            this.checkBox16.Text = "Отправить на почту  с вложением ";
            this.checkBox16.UseVisualStyleBackColor = true;
            this.checkBox16.CheckedChanged += new System.EventHandler(this.checkBox16_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.button_Save);
            this.flowLayoutPanel1.Controls.Add(this.button_cancel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 428);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(656, 42);
            this.flowLayoutPanel1.TabIndex = 66;
            // 
            // button_Save
            // 
            this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save.Location = new System.Drawing.Point(571, 2);
            this.button_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(78, 34);
            this.button_Save.TabIndex = 3;
            this.button_Save.Text = "Ok";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.Location = new System.Drawing.Point(487, 2);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(78, 34);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "Отмена ";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // Html_report_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 470);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Html_report_form";
            this.Text = "Html_report_form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox mainForms_mainTB_note;
        private System.Windows.Forms.CheckBox mainForms_mainTB_JiraTask;
        private System.Windows.Forms.CheckBox mainForms_mainTB_TypeAC;
        private System.Windows.Forms.CheckBox mainForms_mainTB_ID;
        private System.Windows.Forms.CheckBox mainForms_mainTB_date;
        private System.Windows.Forms.Label label_mainTB;
        private System.Windows.Forms.CheckBox mainForms_hardware_note;
        private System.Windows.Forms.CheckBox mainForms_hardware_JiraTask;
        private System.Windows.Forms.CheckBox mainForms_hardware_ID;
        private System.Windows.Forms.CheckBox mainForms_hardware_date;
        private System.Windows.Forms.Label label_Hardware;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox mainForms_stockroom_WrittenOff;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
    }
}