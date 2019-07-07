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
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.PRINT_LABEL_ALL = new System.Windows.Forms.Button();
            this.PRINT_LABELS = new System.Windows.Forms.Button();
            this.groupBox_Set_Data = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_New_data = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Repair = new System.Windows.Forms.Button();
            this.button_deleteDataBase = new System.Windows.Forms.Button();
            this.button_WriteOffTable = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_ExcelOpenFullReport = new System.Windows.Forms.Button();
            this.button_HTMLOpenFullReport = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Info_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_sentDef = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_PartExcelReport = new System.Windows.Forms.Button();
            this.button_PartHtmlReport = new System.Windows.Forms.Button();
            this.dataGridViewPC_Name = new System.Windows.Forms.DataGridView();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_change = new System.Windows.Forms.Button();
            this.button_note = new System.Windows.Forms.Button();
            this.dataGridViewMT = new System.Windows.Forms.DataGridView();
            this.groupBox_MegaFiltr = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox_DATA = new System.Windows.Forms.GroupBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_sum = new System.Windows.Forms.GroupBox();
            this.label_sum = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_Hardware_Stockroom = new System.Windows.Forms.Button();
            this.button_hardwarePC = new System.Windows.Forms.Button();
            this.button_MainTB = new System.Windows.Forms.Button();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grubBoxUnloading.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.groupBox_Set_Data.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPC_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMT)).BeginInit();
            this.groupBox_MegaFiltr.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox_DATA.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_sum.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
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
            this.grubBoxUnloading.Size = new System.Drawing.Size(743, 103);
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
            this.label_Number.Location = new System.Drawing.Point(372, 29);
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
            this.label_PC.Location = new System.Drawing.Point(588, 29);
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
            this.label_Responsible.Location = new System.Drawing.Point(195, 28);
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
            this.label_Room.Location = new System.Drawing.Point(33, 28);
            this.label_Room.Name = "label_Room";
            this.label_Room.Size = new System.Drawing.Size(109, 20);
            this.label_Room.TabIndex = 4;
            this.label_Room.Text = "По комнатам";
            // 
            // textBox_Number
            // 
            this.textBox_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Number.Location = new System.Drawing.Point(375, 53);
            this.textBox_Number.Name = "textBox_Number";
            this.textBox_Number.Size = new System.Drawing.Size(169, 24);
            this.textBox_Number.TabIndex = 3;
            this.textBox_Number.TextChanged += new System.EventHandler(this.textBox_Number_TextChanged);
            this.textBox_Number.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Number_KeyUp);
            // 
            // comboBox_Responsible
            // 
            this.comboBox_Responsible.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Responsible.FormattingEnabled = true;
            this.comboBox_Responsible.Location = new System.Drawing.Point(189, 51);
            this.comboBox_Responsible.Name = "comboBox_Responsible";
            this.comboBox_Responsible.Size = new System.Drawing.Size(169, 26);
            this.comboBox_Responsible.TabIndex = 2;
            this.comboBox_Responsible.SelectedIndexChanged += new System.EventHandler(this.comboBox_Responsible_SelectedIndexChanged);
            // 
            // textBox_PC
            // 
            this.textBox_PC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_PC.Location = new System.Drawing.Point(561, 53);
            this.textBox_PC.Name = "textBox_PC";
            this.textBox_PC.Size = new System.Drawing.Size(169, 24);
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
            this.comboBox_Room.Size = new System.Drawing.Size(169, 26);
            this.comboBox_Room.TabIndex = 2;
            this.comboBox_Room.SelectedIndexChanged += new System.EventHandler(this.comboBox_Room_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.flowLayoutPanel4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(1198, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(161, 93);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Печать";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.PRINT_LABEL_ALL);
            this.flowLayoutPanel4.Controls.Add(this.PRINT_LABELS);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(155, 71);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // PRINT_LABEL_ALL
            // 
            this.PRINT_LABEL_ALL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PRINT_LABEL_ALL.BackgroundImage")));
            this.PRINT_LABEL_ALL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PRINT_LABEL_ALL.Location = new System.Drawing.Point(3, 3);
            this.PRINT_LABEL_ALL.Name = "PRINT_LABEL_ALL";
            this.PRINT_LABEL_ALL.Size = new System.Drawing.Size(63, 64);
            this.PRINT_LABEL_ALL.TabIndex = 0;
            this.toolTip1.SetToolTip(this.PRINT_LABEL_ALL, " Печать наклейки (всего)");
            this.PRINT_LABEL_ALL.UseVisualStyleBackColor = true;
            this.PRINT_LABEL_ALL.Click += new System.EventHandler(this.PRINT_Click);
            // 
            // PRINT_LABELS
            // 
            this.PRINT_LABELS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PRINT_LABELS.BackgroundImage")));
            this.PRINT_LABELS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PRINT_LABELS.Location = new System.Drawing.Point(72, 3);
            this.PRINT_LABELS.Name = "PRINT_LABELS";
            this.PRINT_LABELS.Size = new System.Drawing.Size(63, 64);
            this.PRINT_LABELS.TabIndex = 0;
            this.toolTip1.SetToolTip(this.PRINT_LABELS, "Печать наклеек  \r\n(выделенный диапазон)");
            this.PRINT_LABELS.UseVisualStyleBackColor = true;
            this.PRINT_LABELS.Click += new System.EventHandler(this.PRINT_LABELS_Click);
            // 
            // groupBox_Set_Data
            // 
            this.groupBox_Set_Data.AutoSize = true;
            this.groupBox_Set_Data.Controls.Add(this.flowLayoutPanel1);
            this.groupBox_Set_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Set_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Set_Data.Location = new System.Drawing.Point(437, 3);
            this.groupBox_Set_Data.Name = "groupBox_Set_Data";
            this.groupBox_Set_Data.Size = new System.Drawing.Size(429, 93);
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(423, 71);
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
            this.button_New_data.Size = new System.Drawing.Size(63, 64);
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
            this.button_Delete.Location = new System.Drawing.Point(72, 3);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(63, 64);
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
            this.button_Update.Location = new System.Drawing.Point(141, 3);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(63, 64);
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
            this.button_Repair.Location = new System.Drawing.Point(210, 3);
            this.button_Repair.Name = "button_Repair";
            this.button_Repair.Size = new System.Drawing.Size(63, 64);
            this.button_Repair.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button_Repair, "Отправить в ремонт  ");
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
            this.button_deleteDataBase.Location = new System.Drawing.Point(279, 3);
            this.button_deleteDataBase.Name = "button_deleteDataBase";
            this.button_deleteDataBase.Size = new System.Drawing.Size(63, 64);
            this.button_deleteDataBase.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button_deleteDataBase, "Удалить из базы");
            this.button_deleteDataBase.UseVisualStyleBackColor = true;
            this.button_deleteDataBase.Click += new System.EventHandler(this.button_deleteDataBase_Click);
            // 
            // button_WriteOffTable
            // 
            this.button_WriteOffTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_WriteOffTable.BackgroundImage")));
            this.button_WriteOffTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_WriteOffTable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_WriteOffTable.Location = new System.Drawing.Point(348, 3);
            this.button_WriteOffTable.Name = "button_WriteOffTable";
            this.button_WriteOffTable.Size = new System.Drawing.Size(63, 64);
            this.button_WriteOffTable.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button_WriteOffTable, "Таблица  списаных ");
            this.button_WriteOffTable.UseVisualStyleBackColor = true;
            this.button_WriteOffTable.Click += new System.EventHandler(this.button_WriteOffTable_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(111, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 93);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "полные отчеты";
            this.toolTip1.SetToolTip(this.groupBox1, "Полные отчеты  в формате EXCEL или  HTML");
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.button_ExcelOpenFullReport);
            this.flowLayoutPanel2.Controls.Add(this.button_HTMLOpenFullReport);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(151, 71);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // button_ExcelOpenFullReport
            // 
            this.button_ExcelOpenFullReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ExcelOpenFullReport.BackgroundImage")));
            this.button_ExcelOpenFullReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_ExcelOpenFullReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ExcelOpenFullReport.Location = new System.Drawing.Point(3, 3);
            this.button_ExcelOpenFullReport.Name = "button_ExcelOpenFullReport";
            this.button_ExcelOpenFullReport.Size = new System.Drawing.Size(63, 64);
            this.button_ExcelOpenFullReport.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button_ExcelOpenFullReport, "Открыть в excel (полный отчет)");
            this.button_ExcelOpenFullReport.UseVisualStyleBackColor = true;
            this.button_ExcelOpenFullReport.Click += new System.EventHandler(this.button_ExcelOpen_Click);
            // 
            // button_HTMLOpenFullReport
            // 
            this.button_HTMLOpenFullReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_HTMLOpenFullReport.BackgroundImage")));
            this.button_HTMLOpenFullReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_HTMLOpenFullReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_HTMLOpenFullReport.Location = new System.Drawing.Point(72, 3);
            this.button_HTMLOpenFullReport.Name = "button_HTMLOpenFullReport";
            this.button_HTMLOpenFullReport.Size = new System.Drawing.Size(63, 64);
            this.button_HTMLOpenFullReport.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button_HTMLOpenFullReport, "открыть в браузере (полный  отчет )\r\nвсе  еще в разработке ");
            this.button_HTMLOpenFullReport.UseVisualStyleBackColor = true;
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
            this.menuStrip1.Size = new System.Drawing.Size(1362, 38);
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
            this.groupBox2.Controls.Add(this.flowLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(274, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 93);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "частичные отчеты";
            this.toolTip1.SetToolTip(this.groupBox2, "частичные отчеты");
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.button_PartExcelReport);
            this.flowLayoutPanel3.Controls.Add(this.button_PartHtmlReport);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(151, 71);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // button_PartExcelReport
            // 
            this.button_PartExcelReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_PartExcelReport.BackgroundImage")));
            this.button_PartExcelReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_PartExcelReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_PartExcelReport.Location = new System.Drawing.Point(3, 3);
            this.button_PartExcelReport.Name = "button_PartExcelReport";
            this.button_PartExcelReport.Size = new System.Drawing.Size(63, 64);
            this.button_PartExcelReport.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button_PartExcelReport, "Открыть в excel,  только то что выгружено \r\n(еще  в разработке )\r\n");
            this.button_PartExcelReport.UseVisualStyleBackColor = true;
            // 
            // button_PartHtmlReport
            // 
            this.button_PartHtmlReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_PartHtmlReport.BackgroundImage")));
            this.button_PartHtmlReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_PartHtmlReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_PartHtmlReport.Location = new System.Drawing.Point(72, 3);
            this.button_PartHtmlReport.Name = "button_PartHtmlReport";
            this.button_PartHtmlReport.Size = new System.Drawing.Size(63, 64);
            this.button_PartHtmlReport.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button_PartHtmlReport, "Открыть в  формате  html, только то что выгружено\r\n(еще  в разработке )");
            this.button_PartHtmlReport.UseVisualStyleBackColor = true;
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
            this.dataGridViewPC_Name.Size = new System.Drawing.Size(167, 463);
            this.dataGridViewPC_Name.TabIndex = 4;
            this.toolTip1.SetToolTip(this.dataGridViewPC_Name, "частичные отчеты ");
            this.dataGridViewPC_Name.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPC_Name_CellEnter);
            this.dataGridViewPC_Name.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPC_Name_CellMouseClick);
            // 
            // button_Search
            // 
            this.button_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Search.BackgroundImage")));
            this.button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Search.Location = new System.Drawing.Point(3, 3);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(63, 64);
            this.button_Search.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button_Search, "Расширенный поиск ");
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_change
            // 
            this.button_change.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.Card_Exchange_48px1;
            this.button_change.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_change.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_change.Location = new System.Drawing.Point(3, 3);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(63, 64);
            this.button_change.TabIndex = 13;
            this.toolTip1.SetToolTip(this.button_change, "Изменение уникальных значений");
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // button_note
            // 
            this.button_note.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.Pencil_64px;
            this.button_note.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_note.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_note.Location = new System.Drawing.Point(72, 3);
            this.button_note.Name = "button_note";
            this.button_note.Size = new System.Drawing.Size(63, 64);
            this.button_note.TabIndex = 13;
            this.toolTip1.SetToolTip(this.button_note, "Записать примечание ");
            this.button_note.UseVisualStyleBackColor = true;
            this.button_note.Click += new System.EventHandler(this.button_note_Click);
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
            this.dataGridViewMT.Size = new System.Drawing.Size(1183, 463);
            this.dataGridViewMT.TabIndex = 3;
            this.dataGridViewMT.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMT_CellContentDoubleClick);
            this.dataGridViewMT.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewMT_CellFormatting);
            this.dataGridViewMT.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMT_CellContentDoubleClick);
            // 
            // groupBox_MegaFiltr
            // 
            this.groupBox_MegaFiltr.AutoSize = true;
            this.groupBox_MegaFiltr.Controls.Add(this.flowLayoutPanel5);
            this.groupBox_MegaFiltr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_MegaFiltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_MegaFiltr.Location = new System.Drawing.Point(872, 3);
            this.groupBox_MegaFiltr.Name = "groupBox_MegaFiltr";
            this.groupBox_MegaFiltr.Size = new System.Drawing.Size(157, 93);
            this.groupBox_MegaFiltr.TabIndex = 4;
            this.groupBox_MegaFiltr.TabStop = false;
            this.groupBox_MegaFiltr.Text = "Расширенный поиск";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.button_Search);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(151, 71);
            this.flowLayoutPanel5.TabIndex = 2;
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
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewMT);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(1353, 463);
            this.splitContainer1.SplitterDistance = 167;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox_DATA
            // 
            this.groupBox_DATA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_DATA.Controls.Add(this.splitContainer1);
            this.groupBox_DATA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_DATA.Location = new System.Drawing.Point(0, 252);
            this.groupBox_DATA.Name = "groupBox_DATA";
            this.groupBox_DATA.Size = new System.Drawing.Size(1359, 488);
            this.groupBox_DATA.TabIndex = 1;
            this.groupBox_DATA.TabStop = false;
            this.groupBox_DATA.Text = "Данные  по вашему запросу";
            this.groupBox_DATA.Enter += new System.EventHandler(this.groupBox_DATA_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox_sum, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_Set_Data, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_MegaFiltr, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 147);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1362, 99);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // groupBox_sum
            // 
            this.groupBox_sum.Controls.Add(this.label_sum);
            this.groupBox_sum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_sum.Location = new System.Drawing.Point(3, 3);
            this.groupBox_sum.Name = "groupBox_sum";
            this.groupBox_sum.Size = new System.Drawing.Size(102, 93);
            this.groupBox_sum.TabIndex = 11;
            this.groupBox_sum.TabStop = false;
            this.groupBox_sum.Text = "Сумма";
            // 
            // label_sum
            // 
            this.label_sum.AutoSize = true;
            this.label_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_sum.Location = new System.Drawing.Point(9, 42);
            this.label_sum.Name = "label_sum";
            this.label_sum.Size = new System.Drawing.Size(0, 39);
            this.label_sum.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.flowLayoutPanel6);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(1035, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(157, 93);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Редактирование";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.button_change);
            this.flowLayoutPanel6.Controls.Add(this.button_note);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(151, 71);
            this.flowLayoutPanel6.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.button_Hardware_Stockroom, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_hardwarePC, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_MainTB, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.grubBoxUnloading, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 38);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1362, 109);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // button_Hardware_Stockroom
            // 
            this.button_Hardware_Stockroom.BackColor = System.Drawing.SystemColors.Window;
            this.button_Hardware_Stockroom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Hardware_Stockroom.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Hardware_Stockroom.FlatAppearance.BorderSize = 0;
            this.button_Hardware_Stockroom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_Hardware_Stockroom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_Hardware_Stockroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Hardware_Stockroom.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_Hardware_Stockroom.Location = new System.Drawing.Point(1160, 2);
            this.button_Hardware_Stockroom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Hardware_Stockroom.Name = "button_Hardware_Stockroom";
            this.button_Hardware_Stockroom.Size = new System.Drawing.Size(199, 105);
            this.button_Hardware_Stockroom.TabIndex = 5;
            this.button_Hardware_Stockroom.Text = "Таблица железа и расходники на складе";
            this.button_Hardware_Stockroom.UseVisualStyleBackColor = false;
            this.button_Hardware_Stockroom.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_hardwarePC
            // 
            this.button_hardwarePC.BackColor = System.Drawing.SystemColors.Window;
            this.button_hardwarePC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_hardwarePC.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_hardwarePC.FlatAppearance.BorderSize = 0;
            this.button_hardwarePC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_hardwarePC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_hardwarePC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_hardwarePC.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_hardwarePC.Location = new System.Drawing.Point(956, 2);
            this.button_hardwarePC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_hardwarePC.Name = "button_hardwarePC";
            this.button_hardwarePC.Size = new System.Drawing.Size(198, 105);
            this.button_hardwarePC.TabIndex = 4;
            this.button_hardwarePC.Text = "Таблица железа и расходники на ПК";
            this.button_hardwarePC.UseVisualStyleBackColor = false;
            this.button_hardwarePC.Click += new System.EventHandler(this.button_hardwarePC_Click);
            // 
            // button_MainTB
            // 
            this.button_MainTB.BackColor = System.Drawing.SystemColors.Window;
            this.button_MainTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_MainTB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_MainTB.FlatAppearance.BorderSize = 0;
            this.button_MainTB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_MainTB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_MainTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_MainTB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_MainTB.Location = new System.Drawing.Point(752, 2);
            this.button_MainTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_MainTB.Name = "button_MainTB";
            this.button_MainTB.Size = new System.Drawing.Size(198, 105);
            this.button_MainTB.TabIndex = 2;
            this.button_MainTB.Text = "Таблица основного учета";
            this.button_MainTB.UseVisualStyleBackColor = false;
            this.button_MainTB.Click += new System.EventHandler(this.button_MainTB_Click);
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            // 
            // MainFrorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 738);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.groupBox_DATA);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrorm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFrorm_FormClosed);
            this.grubBoxUnloading.ResumeLayout(false);
            this.grubBoxUnloading.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.groupBox_Set_Data.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPC_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMT)).EndInit();
            this.groupBox_MegaFiltr.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox_DATA.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox_sum.ResumeLayout(false);
            this.groupBox_sum.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
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
        private System.Windows.Forms.Button button_New_data;
        private System.Windows.Forms.Button button_deleteDataBase;
        private System.Windows.Forms.Button button_HTMLOpenFullReport;
        private System.Windows.Forms.Button button_ExcelOpenFullReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox_sum;
        private System.Windows.Forms.Label label_sum;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Button button_Hardware_Stockroom;
        private System.Windows.Forms.Button button_hardwarePC;
        private System.Windows.Forms.Button button_MainTB;
        private System.Windows.Forms.Button button_note;
    }
}

