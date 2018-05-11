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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrorm));
            this.grubBoxUnloading = new System.Windows.Forms.GroupBox();
            this.label_Number = new System.Windows.Forms.Label();
            this.label_PC = new System.Windows.Forms.Label();
            this.label_Responsible = new System.Windows.Forms.Label();
            this.label_Room = new System.Windows.Forms.Label();
            this.textBox_Number = new System.Windows.Forms.TextBox();
            this.comboBox_Responsible = new System.Windows.Forms.ComboBox();
            this.textBox_PC = new System.Windows.Forms.TextBox();
            this.comboBox_Room = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PRINT_LABELS = new System.Windows.Forms.Button();
            this.PRINT_LABEL_ALL = new System.Windows.Forms.Button();
            this.groupBox_Set_Data = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_New_data = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Repair = new System.Windows.Forms.Button();
            this.button_deleteDataBase = new System.Windows.Forms.Button();
            this.button_WriteOffTable = new System.Windows.Forms.Button();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_HTMLOpenFullReport = new System.Windows.Forms.Button();
            this.button_ExcelOpenFullReport = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Info_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_sentDef = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_PartHtmlReport = new System.Windows.Forms.Button();
            this.button_PartExcelReport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewMT = new System.Windows.Forms.DataGridView();
            this.dataGridViewPC_Name = new System.Windows.Forms.DataGridView();
            this.button_Hardware_StockRoom = new System.Windows.Forms.Button();
            this.button_Hardware_PS = new System.Windows.Forms.Button();
            this.groupBox_1С = new System.Windows.Forms.GroupBox();
            this.groupBox_MegaFiltr = new System.Windows.Forms.GroupBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox_DATA = new System.Windows.Forms.GroupBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.groupBox_Hardware = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_sum = new System.Windows.Forms.GroupBox();
            this.label_sum = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grubBoxUnloading.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox_Set_Data.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPC_Name)).BeginInit();
            this.groupBox_1С.SuspendLayout();
            this.groupBox_MegaFiltr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox_DATA.SuspendLayout();
            this.groupBox_Hardware.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_sum.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.grubBoxUnloading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grubBoxUnloading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grubBoxUnloading.Location = new System.Drawing.Point(3, 3);
            this.grubBoxUnloading.Name = "grubBoxUnloading";
            this.grubBoxUnloading.Size = new System.Drawing.Size(375, 180);
            this.grubBoxUnloading.TabIndex = 0;
            this.grubBoxUnloading.TabStop = false;
            this.grubBoxUnloading.Text = "Виды  выгрузок  (быстрый поиск )";
            this.grubBoxUnloading.Enter += new System.EventHandler(this.grubBoxUnloading_Enter);
            // 
            // label_Number
            // 
            this.label_Number.AutoSize = true;
            this.label_Number.BackColor = System.Drawing.SystemColors.Control;
            this.label_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Number.Location = new System.Drawing.Point(199, 95);
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
            this.label_PC.Location = new System.Drawing.Point(232, 30);
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
            this.textBox_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Number.Location = new System.Drawing.Point(203, 118);
            this.textBox_Number.Name = "textBox_Number";
            this.textBox_Number.Size = new System.Drawing.Size(160, 24);
            this.textBox_Number.TabIndex = 3;
            this.textBox_Number.TextChanged += new System.EventHandler(this.textBox_Number_TextChanged);
            this.textBox_Number.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Number_KeyUp);
            // 
            // comboBox_Responsible
            // 
            this.comboBox_Responsible.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Responsible.FormattingEnabled = true;
            this.comboBox_Responsible.Location = new System.Drawing.Point(6, 116);
            this.comboBox_Responsible.Name = "comboBox_Responsible";
            this.comboBox_Responsible.Size = new System.Drawing.Size(158, 26);
            this.comboBox_Responsible.TabIndex = 2;
            this.comboBox_Responsible.SelectedIndexChanged += new System.EventHandler(this.comboBox_Responsible_SelectedIndexChanged);
            // 
            // textBox_PC
            // 
            this.textBox_PC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_PC.Location = new System.Drawing.Point(203, 53);
            this.textBox_PC.Name = "textBox_PC";
            this.textBox_PC.Size = new System.Drawing.Size(160, 24);
            this.textBox_PC.TabIndex = 3;
            this.textBox_PC.TextChanged += new System.EventHandler(this.textBox_PC_TextChanged);
            this.textBox_PC.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_PC_KeyUp);
            // 
            // comboBox_Room
            // 
            this.comboBox_Room.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Room.FormattingEnabled = true;
            this.comboBox_Room.Location = new System.Drawing.Point(6, 51);
            this.comboBox_Room.Name = "comboBox_Room";
            this.comboBox_Room.Size = new System.Drawing.Size(158, 26);
            this.comboBox_Room.TabIndex = 2;
            this.comboBox_Room.SelectedIndexChanged += new System.EventHandler(this.comboBox_Room_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.PRINT_LABELS);
            this.groupBox3.Controls.Add(this.PRINT_LABEL_ALL);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(1146, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(103, 180);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Печать";
            // 
            // PRINT_LABELS
            // 
            this.PRINT_LABELS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PRINT_LABELS.BackgroundImage")));
            this.PRINT_LABELS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PRINT_LABELS.Location = new System.Drawing.Point(6, 111);
            this.PRINT_LABELS.Name = "PRINT_LABELS";
            this.PRINT_LABELS.Size = new System.Drawing.Size(64, 64);
            this.PRINT_LABELS.TabIndex = 0;
            this.toolTip1.SetToolTip(this.PRINT_LABELS, "Печать наклеек  \r\n(выделенный диапазон)");
            this.PRINT_LABELS.UseVisualStyleBackColor = true;
            this.PRINT_LABELS.Click += new System.EventHandler(this.PRINT_LABELS_Click);
            // 
            // PRINT_LABEL_ALL
            // 
            this.PRINT_LABEL_ALL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PRINT_LABEL_ALL.BackgroundImage")));
            this.PRINT_LABEL_ALL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PRINT_LABEL_ALL.Location = new System.Drawing.Point(6, 40);
            this.PRINT_LABEL_ALL.Name = "PRINT_LABEL_ALL";
            this.PRINT_LABEL_ALL.Size = new System.Drawing.Size(64, 64);
            this.PRINT_LABEL_ALL.TabIndex = 0;
            this.toolTip1.SetToolTip(this.PRINT_LABEL_ALL, " Печать наклейки (всего)");
            this.PRINT_LABEL_ALL.UseVisualStyleBackColor = true;
            this.PRINT_LABEL_ALL.Click += new System.EventHandler(this.PRINT_Click);
            // 
            // groupBox_Set_Data
            // 
            this.groupBox_Set_Data.AutoSize = true;
            this.groupBox_Set_Data.Controls.Add(this.flowLayoutPanel1);
            this.groupBox_Set_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Set_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Set_Data.Location = new System.Drawing.Point(656, 3);
            this.groupBox_Set_Data.Name = "groupBox_Set_Data";
            this.groupBox_Set_Data.Size = new System.Drawing.Size(266, 180);
            this.groupBox_Set_Data.TabIndex = 3;
            this.groupBox_Set_Data.TabStop = false;
            this.groupBox_Set_Data.Text = "Корректировка  данных ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button_New_data);
            this.flowLayoutPanel1.Controls.Add(this.button_Delete);
            this.flowLayoutPanel1.Controls.Add(this.button_Update);
            this.flowLayoutPanel1.Controls.Add(this.button_Repair);
            this.flowLayoutPanel1.Controls.Add(this.button_deleteDataBase);
            this.flowLayoutPanel1.Controls.Add(this.button_WriteOffTable);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(260, 158);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button_New_data
            // 
            this.button_New_data.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_New_data.BackgroundImage")));
            this.button_New_data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_New_data.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.button_New_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_New_data.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_New_data.Location = new System.Drawing.Point(3, 3);
            this.button_New_data.Name = "button_New_data";
            this.button_New_data.Size = new System.Drawing.Size(64, 64);
            this.button_New_data.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button_New_data, "Добавить новую  позицию");
            this.button_New_data.UseVisualStyleBackColor = true;
            this.button_New_data.Click += new System.EventHandler(this.button_New_data_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Delete.BackgroundImage")));
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Delete.Location = new System.Drawing.Point(73, 3);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(64, 64);
            this.button_Delete.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button_Delete, "Списать ");
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Update.BackgroundImage")));
            this.button_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Update.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Update.Location = new System.Drawing.Point(143, 3);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(64, 64);
            this.button_Update.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button_Update, "Изменить выделенную позицию");
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Repair
            // 
            this.button_Repair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Repair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Repair.BackgroundImage")));
            this.button_Repair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Repair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Repair.Location = new System.Drawing.Point(3, 73);
            this.button_Repair.Name = "button_Repair";
            this.button_Repair.Size = new System.Drawing.Size(64, 64);
            this.button_Repair.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button_Repair, "Отправить в ремонт ");
            this.button_Repair.UseVisualStyleBackColor = true;
            this.button_Repair.Click += new System.EventHandler(this.button_Repair_Click);
            // 
            // button_deleteDataBase
            // 
            this.button_deleteDataBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_deleteDataBase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_deleteDataBase.BackgroundImage")));
            this.button_deleteDataBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_deleteDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_deleteDataBase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_deleteDataBase.Location = new System.Drawing.Point(73, 73);
            this.button_deleteDataBase.Name = "button_deleteDataBase";
            this.button_deleteDataBase.Size = new System.Drawing.Size(64, 64);
            this.button_deleteDataBase.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button_deleteDataBase, "Удалить из базы");
            this.button_deleteDataBase.UseVisualStyleBackColor = true;
            this.button_deleteDataBase.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_WriteOffTable
            // 
            this.button_WriteOffTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_WriteOffTable.BackgroundImage")));
            this.button_WriteOffTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_WriteOffTable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_WriteOffTable.Location = new System.Drawing.Point(143, 73);
            this.button_WriteOffTable.Name = "button_WriteOffTable";
            this.button_WriteOffTable.Size = new System.Drawing.Size(64, 64);
            this.button_WriteOffTable.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button_WriteOffTable, "Таблица  списаных ");
            this.button_WriteOffTable.UseVisualStyleBackColor = true;
            this.button_WriteOffTable.Click += new System.EventHandler(this.button_WriteOffTable_Click);
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_HTMLOpenFullReport);
            this.groupBox1.Controls.Add(this.button_ExcelOpenFullReport);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 84);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "полные отчеты";
            this.toolTip1.SetToolTip(this.groupBox1, "Полные отчеты  в формате EXCEL или  HTML");
            // 
            // button_HTMLOpenFullReport
            // 
            this.button_HTMLOpenFullReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_HTMLOpenFullReport.BackgroundImage")));
            this.button_HTMLOpenFullReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_HTMLOpenFullReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_HTMLOpenFullReport.Location = new System.Drawing.Point(79, 19);
            this.button_HTMLOpenFullReport.Name = "button_HTMLOpenFullReport";
            this.button_HTMLOpenFullReport.Size = new System.Drawing.Size(64, 64);
            this.button_HTMLOpenFullReport.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button_HTMLOpenFullReport, "открыть в браузере (полный  отчет )\r\nвсе  еще в разработке ");
            this.button_HTMLOpenFullReport.UseVisualStyleBackColor = true;
            // 
            // button_ExcelOpenFullReport
            // 
            this.button_ExcelOpenFullReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ExcelOpenFullReport.BackgroundImage")));
            this.button_ExcelOpenFullReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_ExcelOpenFullReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ExcelOpenFullReport.Location = new System.Drawing.Point(9, 18);
            this.button_ExcelOpenFullReport.Name = "button_ExcelOpenFullReport";
            this.button_ExcelOpenFullReport.Size = new System.Drawing.Size(64, 64);
            this.button_ExcelOpenFullReport.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button_ExcelOpenFullReport, "Открыть в excel (полный отчет)");
            this.button_ExcelOpenFullReport.UseVisualStyleBackColor = true;
            this.button_ExcelOpenFullReport.Click += new System.EventHandler(this.button_ExcelOpen_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_ToolStripMenuItem,
            this.Settings_ToolStripMenuItem,
            this.Info_ToolStripMenuItem,
            this.toolStripMenuItem_sentDef});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1363, 38);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File_ToolStripMenuItem
            // 
            this.File_ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("File_ToolStripMenuItem.BackgroundImage")));
            this.File_ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.File_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.JBDToolStripMenuItem});
            this.File_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.File_ToolStripMenuItem.Name = "File_ToolStripMenuItem";
            this.File_ToolStripMenuItem.Size = new System.Drawing.Size(87, 34);
            this.File_ToolStripMenuItem.Text = "   Файл";
            this.File_ToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // JBDToolStripMenuItem
            // 
            this.JBDToolStripMenuItem.Name = "JBDToolStripMenuItem";
            this.JBDToolStripMenuItem.Size = new System.Drawing.Size(126, 32);
            this.JBDToolStripMenuItem.Text = "ЖБД";
            this.JBDToolStripMenuItem.Click += new System.EventHandler(this.JBDToolStripMenuItem_Click);
            // 
            // Settings_ToolStripMenuItem
            // 
            this.Settings_ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Settings_ToolStripMenuItem.BackgroundImage")));
            this.Settings_ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Settings_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.Settings_ToolStripMenuItem.Name = "Settings_ToolStripMenuItem";
            this.Settings_ToolStripMenuItem.Size = new System.Drawing.Size(170, 34);
            this.Settings_ToolStripMenuItem.Text = "    Настройки  ";
            this.Settings_ToolStripMenuItem.Click += new System.EventHandler(this.Settings_ToolStripMenuItem_Click);
            // 
            // Info_ToolStripMenuItem
            // 
            this.Info_ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Info_ToolStripMenuItem.BackgroundImage")));
            this.Info_ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Info_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.Info_ToolStripMenuItem.Name = "Info_ToolStripMenuItem";
            this.Info_ToolStripMenuItem.Size = new System.Drawing.Size(185, 34);
            this.Info_ToolStripMenuItem.Text = "   О программе ";
            this.Info_ToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Info_ToolStripMenuItem.Click += new System.EventHandler(this.Info_ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem_sentDef
            // 
            this.toolStripMenuItem_sentDef.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem_sentDef.BackgroundImage")));
            this.toolStripMenuItem_sentDef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMenuItem_sentDef.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.toolStripMenuItem_sentDef.Name = "toolStripMenuItem_sentDef";
            this.toolStripMenuItem_sentDef.Size = new System.Drawing.Size(201, 34);
            this.toolStripMenuItem_sentDef.Text = "   Обратная связь";
            this.toolStripMenuItem_sentDef.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripMenuItem_sentDef.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 1000;
            this.toolTip1.ToolTipTitle = "Подсказка :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_PartHtmlReport);
            this.groupBox2.Controls.Add(this.button_PartExcelReport);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(3, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 84);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "частичные отчеты";
            this.toolTip1.SetToolTip(this.groupBox2, "частичные отчеты");
            // 
            // button_PartHtmlReport
            // 
            this.button_PartHtmlReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_PartHtmlReport.BackgroundImage")));
            this.button_PartHtmlReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_PartHtmlReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_PartHtmlReport.Location = new System.Drawing.Point(79, 17);
            this.button_PartHtmlReport.Name = "button_PartHtmlReport";
            this.button_PartHtmlReport.Size = new System.Drawing.Size(64, 64);
            this.button_PartHtmlReport.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button_PartHtmlReport, "Открыть в  формате  html, только то что выгружено\r\n(еще  в разработке )");
            this.button_PartHtmlReport.UseVisualStyleBackColor = true;
            // 
            // button_PartExcelReport
            // 
            this.button_PartExcelReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_PartExcelReport.BackgroundImage")));
            this.button_PartExcelReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_PartExcelReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_PartExcelReport.Location = new System.Drawing.Point(9, 18);
            this.button_PartExcelReport.Name = "button_PartExcelReport";
            this.button_PartExcelReport.Size = new System.Drawing.Size(64, 64);
            this.button_PartExcelReport.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button_PartExcelReport, "Открыть в excel,  только то что выгружено \r\n(еще  в разработке )\r\n");
            this.button_PartExcelReport.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(6, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 64);
            this.button1.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button1, "Работа с  данными 1С ");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMT
            // 
            this.dataGridViewMT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMT.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridViewMT.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMT.Name = "dataGridViewMT";
            this.dataGridViewMT.RowTemplate.DividerHeight = 2;
            this.dataGridViewMT.RowTemplate.Height = 25;
            this.dataGridViewMT.Size = new System.Drawing.Size(1173, 485);
            this.dataGridViewMT.TabIndex = 3;
            this.toolTip1.SetToolTip(this.dataGridViewMT, "частичные отчеты ");
            this.dataGridViewMT.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMT_CellContentDoubleClick);
            this.dataGridViewMT.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewMT_CellFormatting);
            // 
            // dataGridViewPC_Name
            // 
            this.dataGridViewPC_Name.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPC_Name.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPC_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPC_Name.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridViewPC_Name.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPC_Name.Name = "dataGridViewPC_Name";
            this.dataGridViewPC_Name.RowTemplate.DividerHeight = 2;
            this.dataGridViewPC_Name.RowTemplate.Height = 25;
            this.dataGridViewPC_Name.Size = new System.Drawing.Size(172, 485);
            this.dataGridViewPC_Name.TabIndex = 4;
            this.toolTip1.SetToolTip(this.dataGridViewPC_Name, "частичные отчеты ");
            this.dataGridViewPC_Name.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPC_Name_CellEnter);
            this.dataGridViewPC_Name.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPC_Name_CellMouseClick);
            // 
            // button_Hardware_StockRoom
            // 
            this.button_Hardware_StockRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Hardware_StockRoom.BackgroundImage")));
            this.button_Hardware_StockRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Hardware_StockRoom.Location = new System.Drawing.Point(6, 40);
            this.button_Hardware_StockRoom.Name = "button_Hardware_StockRoom";
            this.button_Hardware_StockRoom.Size = new System.Drawing.Size(64, 64);
            this.button_Hardware_StockRoom.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button_Hardware_StockRoom, "Железо и расходники на складе ");
            this.button_Hardware_StockRoom.UseVisualStyleBackColor = true;
            this.button_Hardware_StockRoom.Click += new System.EventHandler(this.button_Hardware_StockRoom_Click);
            // 
            // button_Hardware_PS
            // 
            this.button_Hardware_PS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Hardware_PS.BackgroundImage")));
            this.button_Hardware_PS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Hardware_PS.Location = new System.Drawing.Point(6, 111);
            this.button_Hardware_PS.Name = "button_Hardware_PS";
            this.button_Hardware_PS.Size = new System.Drawing.Size(64, 64);
            this.button_Hardware_PS.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button_Hardware_PS, "Железо и расходники  на  ПК ");
            this.button_Hardware_PS.UseVisualStyleBackColor = true;
            this.button_Hardware_PS.Click += new System.EventHandler(this.button_Hardware_PS_Click);
            // 
            // groupBox_1С
            // 
            this.groupBox_1С.AutoSize = true;
            this.groupBox_1С.Controls.Add(this.button1);
            this.groupBox_1С.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_1С.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_1С.Location = new System.Drawing.Point(1037, 3);
            this.groupBox_1С.Name = "groupBox_1С";
            this.groupBox_1С.Size = new System.Drawing.Size(103, 180);
            this.groupBox_1С.TabIndex = 4;
            this.groupBox_1С.TabStop = false;
            this.groupBox_1С.Text = "Работа  с данами из 1С";
            // 
            // groupBox_MegaFiltr
            // 
            this.groupBox_MegaFiltr.AutoSize = true;
            this.groupBox_MegaFiltr.Controls.Add(this.button_Search);
            this.groupBox_MegaFiltr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_MegaFiltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_MegaFiltr.Location = new System.Drawing.Point(928, 3);
            this.groupBox_MegaFiltr.Name = "groupBox_MegaFiltr";
            this.groupBox_MegaFiltr.Size = new System.Drawing.Size(103, 180);
            this.groupBox_MegaFiltr.TabIndex = 4;
            this.groupBox_MegaFiltr.TabStop = false;
            this.groupBox_MegaFiltr.Text = "Расширенный поиск ";
            // 
            // button_Search
            // 
            this.button_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Search.BackgroundImage")));
            this.button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Search.Location = new System.Drawing.Point(6, 60);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(64, 64);
            this.button_Search.TabIndex = 1;
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 22);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewPC_Name);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewMT);
            this.splitContainer1.Size = new System.Drawing.Size(1349, 485);
            this.splitContainer1.SplitterDistance = 172;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox_DATA
            // 
            this.groupBox_DATA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_DATA.Controls.Add(this.splitContainer1);
            this.groupBox_DATA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_DATA.Location = new System.Drawing.Point(8, 230);
            this.groupBox_DATA.Name = "groupBox_DATA";
            this.groupBox_DATA.Size = new System.Drawing.Size(1355, 510);
            this.groupBox_DATA.TabIndex = 1;
            this.groupBox_DATA.TabStop = false;
            this.groupBox_DATA.Text = "Данные  по вашему запросу";
            this.groupBox_DATA.Enter += new System.EventHandler(this.groupBox_DATA_Enter);
            // 
            // groupBox_Hardware
            // 
            this.groupBox_Hardware.AutoSize = true;
            this.groupBox_Hardware.Controls.Add(this.button_Hardware_PS);
            this.groupBox_Hardware.Controls.Add(this.button_Hardware_StockRoom);
            this.groupBox_Hardware.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Hardware.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Hardware.Location = new System.Drawing.Point(1255, 3);
            this.groupBox_Hardware.Name = "groupBox_Hardware";
            this.groupBox_Hardware.Size = new System.Drawing.Size(105, 180);
            this.groupBox_Hardware.TabIndex = 3;
            this.groupBox_Hardware.TabStop = false;
            this.groupBox_Hardware.Text = "Железо и расходники ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox_sum, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grubBoxUnloading, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_MegaFiltr, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_Hardware, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_1С, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_Set_Data, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1363, 186);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // groupBox_sum
            // 
            this.groupBox_sum.Controls.Add(this.label_sum);
            this.groupBox_sum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_sum.Location = new System.Drawing.Point(384, 3);
            this.groupBox_sum.Name = "groupBox_sum";
            this.groupBox_sum.Size = new System.Drawing.Size(89, 180);
            this.groupBox_sum.TabIndex = 11;
            this.groupBox_sum.TabStop = false;
            this.groupBox_sum.Text = "Количество элементов";
            // 
            // label_sum
            // 
            this.label_sum.AutoSize = true;
            this.label_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_sum.Location = new System.Drawing.Point(6, 66);
            this.label_sum.Name = "label_sum";
            this.label_sum.Size = new System.Drawing.Size(0, 39);
            this.label_sum.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(479, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(171, 180);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainFrorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 739);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox_DATA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrorm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFrorm_FormClosed);
            this.grubBoxUnloading.ResumeLayout(false);
            this.grubBoxUnloading.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox_Set_Data.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPC_Name)).EndInit();
            this.groupBox_1С.ResumeLayout(false);
            this.groupBox_MegaFiltr.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox_DATA.ResumeLayout(false);
            this.groupBox_Hardware.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox_sum.ResumeLayout(false);
            this.groupBox_sum.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grubBoxUnloading;
        private System.Windows.Forms.TextBox textBox_PC;
        private System.Windows.Forms.ComboBox comboBox_Room;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button PRINT_LABEL_ALL;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.Button PRINT_LABELS;
        private System.Windows.Forms.Label label_Room;
        private System.Windows.Forms.Label label_Responsible;
        private System.Windows.Forms.ComboBox comboBox_Responsible;
        private System.Windows.Forms.Label label_PC;
        private System.Windows.Forms.Label label_Number;
        private System.Windows.Forms.TextBox textBox_Number;
        private System.Windows.Forms.GroupBox groupBox_Set_Data;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Repair;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Settings_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Info_ToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_PartExcelReport;
        private System.Windows.Forms.Button button_PartHtmlReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox_1С;
        private System.Windows.Forms.GroupBox groupBox_MegaFiltr;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_sentDef;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox_DATA;
        private System.Windows.Forms.DataGridView dataGridViewPC_Name;
        private System.Windows.Forms.DataGridView dataGridViewMT;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button button_WriteOffTable;
        private System.Windows.Forms.ToolStripMenuItem JBDToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_Hardware;
        private System.Windows.Forms.Button button_Hardware_PS;
        private System.Windows.Forms.Button button_Hardware_StockRoom;
        private System.Windows.Forms.Button button_New_data;
        private System.Windows.Forms.Button button_deleteDataBase;
        private System.Windows.Forms.Button button_HTMLOpenFullReport;
        private System.Windows.Forms.Button button_ExcelOpenFullReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox_sum;
        private System.Windows.Forms.Label label_sum;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

