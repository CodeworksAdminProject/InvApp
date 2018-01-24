namespace WindowsFormsApplication
{
    partial class MainFrorm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grubBoxUnloading = new System.Windows.Forms.GroupBox();
            this.label_Number = new System.Windows.Forms.Label();
            this.label_PC = new System.Windows.Forms.Label();
            this.label_Responsible = new System.Windows.Forms.Label();
            this.label_Room = new System.Windows.Forms.Label();
            this.textBox_Number = new System.Windows.Forms.TextBox();
            this.comboBox_Responsible = new System.Windows.Forms.ComboBox();
            this.textBox_PC = new System.Windows.Forms.TextBox();
            this.comboBox_Room = new System.Windows.Forms.ComboBox();
            this.button_Number = new System.Windows.Forms.Button();
            this.button_Responsible = new System.Windows.Forms.Button();
            this.button_PC = new System.Windows.Forms.Button();
            this.button_Room = new System.Windows.Forms.Button();
            this.groupBox_DATA = new System.Windows.Forms.GroupBox();
            this.dataGridViewMT = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PRINT_REPORT = new System.Windows.Forms.Button();
            this.PRINT_LABELS = new System.Windows.Forms.Button();
            this.PRINT_LABEL_ALL = new System.Windows.Forms.Button();
            this.groupBox_Set_Data = new System.Windows.Forms.GroupBox();
            this.button_Repair = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_New_data = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.groupBox_1С = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_ExcelSentMail = new System.Windows.Forms.Button();
            this.button_ExcelOpen = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Info_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grubBoxUnloading.SuspendLayout();
            this.groupBox_DATA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMT)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox_Set_Data.SuspendLayout();
            this.groupBox_1С.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grubBoxUnloading
            // 
            this.grubBoxUnloading.AutoSize = true;
            this.grubBoxUnloading.Controls.Add(this.label_Number);
            this.grubBoxUnloading.Controls.Add(this.label_PC);
            this.grubBoxUnloading.Controls.Add(this.label_Responsible);
            this.grubBoxUnloading.Controls.Add(this.label_Room);
            this.grubBoxUnloading.Controls.Add(this.textBox_Number);
            this.grubBoxUnloading.Controls.Add(this.comboBox_Responsible);
            this.grubBoxUnloading.Controls.Add(this.textBox_PC);
            this.grubBoxUnloading.Controls.Add(this.comboBox_Room);
            this.grubBoxUnloading.Controls.Add(this.button_Number);
            this.grubBoxUnloading.Controls.Add(this.button_Responsible);
            this.grubBoxUnloading.Controls.Add(this.button_PC);
            this.grubBoxUnloading.Controls.Add(this.button_Room);
            this.grubBoxUnloading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grubBoxUnloading.Location = new System.Drawing.Point(8, 33);
            this.grubBoxUnloading.Name = "grubBoxUnloading";
            this.grubBoxUnloading.Size = new System.Drawing.Size(613, 198);
            this.grubBoxUnloading.TabIndex = 0;
            this.grubBoxUnloading.TabStop = false;
            this.grubBoxUnloading.Text = "Виды  выгрузок ";
            // 
            // label_Number
            // 
            this.label_Number.AutoSize = true;
            this.label_Number.BackColor = System.Drawing.SystemColors.Control;
            this.label_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Number.Location = new System.Drawing.Point(326, 93);
            this.label_Number.Name = "label_Number";
            this.label_Number.Size = new System.Drawing.Size(165, 20);
            this.label_Number.TabIndex = 4;
            this.label_Number.Text = "По инвентарному  №";
            // 
            // label_PC
            // 
            this.label_PC.AutoSize = true;
            this.label_PC.BackColor = System.Drawing.SystemColors.Control;
            this.label_PC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_PC.Location = new System.Drawing.Point(351, 28);
            this.label_PC.Name = "label_PC";
            this.label_PC.Size = new System.Drawing.Size(107, 20);
            this.label_PC.TabIndex = 4;
            this.label_PC.Text = "По имени ПК";
            // 
            // label_Responsible
            // 
            this.label_Responsible.AutoSize = true;
            this.label_Responsible.BackColor = System.Drawing.SystemColors.Control;
            this.label_Responsible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Responsible.Location = new System.Drawing.Point(10, 93);
            this.label_Responsible.Name = "label_Responsible";
            this.label_Responsible.Size = new System.Drawing.Size(154, 20);
            this.label_Responsible.TabIndex = 4;
            this.label_Responsible.Text = "По ответственным";
            // 
            // label_Room
            // 
            this.label_Room.AutoSize = true;
            this.label_Room.BackColor = System.Drawing.SystemColors.Control;
            this.label_Room.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Room.Location = new System.Drawing.Point(34, 28);
            this.label_Room.Name = "label_Room";
            this.label_Room.Size = new System.Drawing.Size(109, 20);
            this.label_Room.TabIndex = 4;
            this.label_Room.Text = "По комнатам";
            // 
            // textBox_Number
            // 
            this.textBox_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Number.Location = new System.Drawing.Point(310, 116);
            this.textBox_Number.Name = "textBox_Number";
            this.textBox_Number.Size = new System.Drawing.Size(187, 29);
            this.textBox_Number.TabIndex = 3;
            this.textBox_Number.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Number_KeyUp);
            // 
            // comboBox_Responsible
            // 
            this.comboBox_Responsible.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Responsible.FormattingEnabled = true;
            this.comboBox_Responsible.Location = new System.Drawing.Point(6, 116);
            this.comboBox_Responsible.Name = "comboBox_Responsible";
            this.comboBox_Responsible.Size = new System.Drawing.Size(171, 28);
            this.comboBox_Responsible.TabIndex = 2;
            // 
            // textBox_PC
            // 
            this.textBox_PC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_PC.Location = new System.Drawing.Point(310, 50);
            this.textBox_PC.Name = "textBox_PC";
            this.textBox_PC.Size = new System.Drawing.Size(187, 27);
            this.textBox_PC.TabIndex = 3;
            this.textBox_PC.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_PC_KeyUp);
            // 
            // comboBox_Room
            // 
            this.comboBox_Room.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Room.FormattingEnabled = true;
            this.comboBox_Room.Location = new System.Drawing.Point(6, 51);
            this.comboBox_Room.Name = "comboBox_Room";
            this.comboBox_Room.Size = new System.Drawing.Size(171, 28);
            this.comboBox_Room.TabIndex = 2;
            // 
            // button_Number
            // 
            this.button_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Number.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Number.Location = new System.Drawing.Point(503, 116);
            this.button_Number.Name = "button_Number";
            this.button_Number.Size = new System.Drawing.Size(100, 30);
            this.button_Number.TabIndex = 1;
            this.button_Number.Text = "Выгрузка";
            this.button_Number.UseVisualStyleBackColor = true;
            this.button_Number.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // button_Responsible
            // 
            this.button_Responsible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Responsible.Location = new System.Drawing.Point(183, 116);
            this.button_Responsible.Name = "button_Responsible";
            this.button_Responsible.Size = new System.Drawing.Size(100, 30);
            this.button_Responsible.TabIndex = 0;
            this.button_Responsible.Text = "Выгрузка";
            this.button_Responsible.UseVisualStyleBackColor = true;
            this.button_Responsible.Click += new System.EventHandler(this.button_Responsible_Click);
            // 
            // button_PC
            // 
            this.button_PC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_PC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_PC.Location = new System.Drawing.Point(503, 48);
            this.button_PC.Name = "button_PC";
            this.button_PC.Size = new System.Drawing.Size(100, 30);
            this.button_PC.TabIndex = 1;
            this.button_PC.Text = "Выгрузка";
            this.button_PC.UseVisualStyleBackColor = true;
            this.button_PC.Click += new System.EventHandler(this.button_PC_Click);
            // 
            // button_Room
            // 
            this.button_Room.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Room.Location = new System.Drawing.Point(183, 49);
            this.button_Room.Name = "button_Room";
            this.button_Room.Size = new System.Drawing.Size(100, 30);
            this.button_Room.TabIndex = 0;
            this.button_Room.Text = "Выгрузка";
            this.button_Room.UseVisualStyleBackColor = true;
            this.button_Room.Click += new System.EventHandler(this.button_Room_Click);
            // 
            // groupBox_DATA
            // 
            this.groupBox_DATA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_DATA.AutoSize = true;
            this.groupBox_DATA.Controls.Add(this.dataGridViewMT);
            this.groupBox_DATA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_DATA.Location = new System.Drawing.Point(8, 230);
            this.groupBox_DATA.Name = "groupBox_DATA";
            this.groupBox_DATA.Size = new System.Drawing.Size(1403, 339);
            this.groupBox_DATA.TabIndex = 1;
            this.groupBox_DATA.TabStop = false;
            this.groupBox_DATA.Text = "Данные  по вашему запросу";
            // 
            // dataGridViewMT
            // 
            this.dataGridViewMT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMT.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewMT.Name = "dataGridViewMT";
            this.dataGridViewMT.RowTemplate.DividerHeight = 2;
            this.dataGridViewMT.RowTemplate.Height = 25;
            this.dataGridViewMT.Size = new System.Drawing.Size(1397, 314);
            this.dataGridViewMT.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.PRINT_REPORT);
            this.groupBox3.Controls.Add(this.PRINT_LABELS);
            this.groupBox3.Controls.Add(this.PRINT_LABEL_ALL);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(1208, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1030, 198);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Печать";
            // 
            // PRINT_REPORT
            // 
            this.PRINT_REPORT.AutoSize = true;
            this.PRINT_REPORT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PRINT_REPORT.Location = new System.Drawing.Point(6, 123);
            this.PRINT_REPORT.Name = "PRINT_REPORT";
            this.PRINT_REPORT.Size = new System.Drawing.Size(204, 41);
            this.PRINT_REPORT.TabIndex = 0;
            this.PRINT_REPORT.Text = "Печать отчета";
            this.PRINT_REPORT.UseVisualStyleBackColor = true;
            // 
            // PRINT_LABELS
            // 
            this.PRINT_LABELS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PRINT_LABELS.Location = new System.Drawing.Point(6, 65);
            this.PRINT_LABELS.Name = "PRINT_LABELS";
            this.PRINT_LABELS.Size = new System.Drawing.Size(201, 52);
            this.PRINT_LABELS.TabIndex = 0;
            this.PRINT_LABELS.Text = "Печать наклеек  \r\n(выделенный диапазон)";
            this.PRINT_LABELS.UseVisualStyleBackColor = true;
            this.PRINT_LABELS.Click += new System.EventHandler(this.PRINT_LABELS_Click);
            // 
            // PRINT_LABEL_ALL
            // 
            this.PRINT_LABEL_ALL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PRINT_LABEL_ALL.Location = new System.Drawing.Point(5, 18);
            this.PRINT_LABEL_ALL.Name = "PRINT_LABEL_ALL";
            this.PRINT_LABEL_ALL.Size = new System.Drawing.Size(202, 41);
            this.PRINT_LABEL_ALL.TabIndex = 0;
            this.PRINT_LABEL_ALL.Text = " Печать наклейки";
            this.PRINT_LABEL_ALL.UseVisualStyleBackColor = true;
            this.PRINT_LABEL_ALL.Click += new System.EventHandler(this.PRINT_Click);
            // 
            // groupBox_Set_Data
            // 
            this.groupBox_Set_Data.AutoSize = true;
            this.groupBox_Set_Data.Controls.Add(this.button_Repair);
            this.groupBox_Set_Data.Controls.Add(this.button_Delete);
            this.groupBox_Set_Data.Controls.Add(this.button_New_data);
            this.groupBox_Set_Data.Controls.Add(this.button_Update);
            this.groupBox_Set_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Set_Data.Location = new System.Drawing.Point(790, 33);
            this.groupBox_Set_Data.Name = "groupBox_Set_Data";
            this.groupBox_Set_Data.Size = new System.Drawing.Size(1079, 198);
            this.groupBox_Set_Data.TabIndex = 3;
            this.groupBox_Set_Data.TabStop = false;
            this.groupBox_Set_Data.Text = "Корректировка  данных ";
            // 
            // button_Repair
            // 
            this.button_Repair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Repair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Repair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Repair.Location = new System.Drawing.Point(146, 110);
            this.button_Repair.Name = "button_Repair";
            this.button_Repair.Size = new System.Drawing.Size(125, 50);
            this.button_Repair.TabIndex = 1;
            this.button_Repair.Text = "В ремонт";
            this.button_Repair.UseVisualStyleBackColor = true;
            // 
            // button_Delete
            // 
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Delete.Location = new System.Drawing.Point(6, 110);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(125, 50);
            this.button_Delete.TabIndex = 1;
            this.button_Delete.Text = "Удалить позицию";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_New_data
            // 
            this.button_New_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_New_data.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_New_data.Location = new System.Drawing.Point(6, 22);
            this.button_New_data.Name = "button_New_data";
            this.button_New_data.Size = new System.Drawing.Size(125, 70);
            this.button_New_data.TabIndex = 1;
            this.button_New_data.Text = "Добавить новую\r\n позицию";
            this.button_New_data.UseVisualStyleBackColor = true;
            this.button_New_data.Click += new System.EventHandler(this.button_New_data_Click);
            // 
            // button_Update
            // 
            this.button_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Update.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Update.Location = new System.Drawing.Point(146, 18);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(125, 70);
            this.button_Update.TabIndex = 1;
            this.button_Update.Text = "Изменить\r\nвыделенную \r\nпозицию";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // groupBox_1С
            // 
            this.groupBox_1С.AutoSize = true;
            this.groupBox_1С.Controls.Add(this.button1);
            this.groupBox_1С.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_1С.Location = new System.Drawing.Point(1067, 33);
            this.groupBox_1С.Name = "groupBox_1С";
            this.groupBox_1С.Size = new System.Drawing.Size(135, 198);
            this.groupBox_1С.TabIndex = 4;
            this.groupBox_1С.TabStop = false;
            this.groupBox_1С.Text = "Работа  с данами из 1С";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(6, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 110);
            this.button1.TabIndex = 1;
            this.button1.Text = "Работа с \r\nданными 1С ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_ExcelSentMail);
            this.groupBox1.Controls.Add(this.button_ExcelOpen);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(627, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 198);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Excel";
            // 
            // button_ExcelSentMail
            // 
            this.button_ExcelSentMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ExcelSentMail.Location = new System.Drawing.Point(6, 90);
            this.button_ExcelSentMail.Name = "button_ExcelSentMail";
            this.button_ExcelSentMail.Size = new System.Drawing.Size(145, 50);
            this.button_ExcelSentMail.TabIndex = 0;
            this.button_ExcelSentMail.Text = "Excel отправить на почту";
            this.button_ExcelSentMail.UseVisualStyleBackColor = true;
            // 
            // button_ExcelOpen
            // 
            this.button_ExcelOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ExcelOpen.Location = new System.Drawing.Point(6, 22);
            this.button_ExcelOpen.Name = "button_ExcelOpen";
            this.button_ExcelOpen.Size = new System.Drawing.Size(145, 50);
            this.button_ExcelOpen.TabIndex = 0;
            this.button_ExcelOpen.Text = "Открыть в excel ";
            this.button_ExcelOpen.UseVisualStyleBackColor = true;
            this.button_ExcelOpen.Click += new System.EventHandler(this.button_ExcelOpen_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_ToolStripMenuItem,
            this.Settings_ToolStripMenuItem,
            this.Info_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1420, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File_ToolStripMenuItem
            // 
            this.File_ToolStripMenuItem.Name = "File_ToolStripMenuItem";
            this.File_ToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.File_ToolStripMenuItem.Text = "Файл";
            // 
            // Settings_ToolStripMenuItem
            // 
            this.Settings_ToolStripMenuItem.Name = "Settings_ToolStripMenuItem";
            this.Settings_ToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.Settings_ToolStripMenuItem.Text = "Настройки  ";
            this.Settings_ToolStripMenuItem.Click += new System.EventHandler(this.Settings_ToolStripMenuItem_Click);
            // 
            // Info_ToolStripMenuItem
            // 
            this.Info_ToolStripMenuItem.Name = "Info_ToolStripMenuItem";
            this.Info_ToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.Info_ToolStripMenuItem.Text = "О программе ";
            this.Info_ToolStripMenuItem.Click += new System.EventHandler(this.Info_ToolStripMenuItem_Click);
            // 
            // MainFrorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 568);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_1С);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox_Set_Data);
            this.Controls.Add(this.groupBox_DATA);
            this.Controls.Add(this.grubBoxUnloading);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrorm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFrorm_FormClosed);
            this.grubBoxUnloading.ResumeLayout(false);
            this.grubBoxUnloading.PerformLayout();
            this.groupBox_DATA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMT)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox_Set_Data.ResumeLayout(false);
            this.groupBox_1С.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grubBoxUnloading;
        private System.Windows.Forms.TextBox textBox_PC;
        private System.Windows.Forms.ComboBox comboBox_Room;
        private System.Windows.Forms.Button button_PC;
        private System.Windows.Forms.Button button_Room;
        private System.Windows.Forms.GroupBox groupBox_DATA;
        private System.Windows.Forms.DataGridView dataGridViewMT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button PRINT_LABEL_ALL;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.Button PRINT_LABELS;
        private System.Windows.Forms.Label label_Room;
        private System.Windows.Forms.Label label_Responsible;
        private System.Windows.Forms.ComboBox comboBox_Responsible;
        private System.Windows.Forms.Button button_Responsible;
        private System.Windows.Forms.Label label_PC;
        private System.Windows.Forms.Label label_Number;
        private System.Windows.Forms.TextBox textBox_Number;
        private System.Windows.Forms.Button button_Number;
        private System.Windows.Forms.GroupBox groupBox_Set_Data;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Repair;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_New_data;
        private System.Windows.Forms.Button PRINT_REPORT;
        private System.Windows.Forms.GroupBox groupBox_1С;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_ExcelSentMail;
        private System.Windows.Forms.Button button_ExcelOpen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Settings_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Info_ToolStripMenuItem;
    }
}

