namespace WindowsFormsApplication
{
    partial class setDataBase

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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.model = new System.Windows.Forms.Label();
            this.typeDiv = new System.Windows.Forms.Label();
            this.label_model = new System.Windows.Forms.Label();
            this.label_type_div = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.GroupBox();
            this.textBox_Floor = new System.Windows.Forms.TextBox();
            this.checkBox_Floor = new System.Windows.Forms.CheckBox();
            this.comboBox_Floor = new System.Windows.Forms.ComboBox();
            this.groupBox_LanName = new System.Windows.Forms.GroupBox();
            this.textBox_LanName = new System.Windows.Forms.TextBox();
            this.checkBox_LanName = new System.Windows.Forms.CheckBox();
            this.comboBox_LanName = new System.Windows.Forms.ComboBox();
            this.groupBox_Responsible = new System.Windows.Forms.GroupBox();
            this.textBox_Responsible = new System.Windows.Forms.TextBox();
            this.checkBox_Responsible = new System.Windows.Forms.CheckBox();
            this.comboBox_Responsible = new System.Windows.Forms.ComboBox();
            this.groupBox_room = new System.Windows.Forms.GroupBox();
            this.textBox_Room = new System.Windows.Forms.TextBox();
            this.comboBox_Room = new System.Windows.Forms.ComboBox();
            this.checkBox_Room = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_change = new System.Windows.Forms.Button();
            this.button_writtenoff = new System.Windows.Forms.Button();
            this.button_repairs = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_print_all = new System.Windows.Forms.Button();
            this.button_print_select_str = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.Location.SuspendLayout();
            this.groupBox_LanName.SuspendLayout();
            this.groupBox_Responsible.SuspendLayout();
            this.groupBox_room.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(3, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(1181, 576);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1175, 551);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.model);
            this.panel1.Controls.Add(this.typeDiv);
            this.panel1.Controls.Add(this.label_model);
            this.panel1.Controls.Add(this.label_type_div);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 105);
            this.panel1.TabIndex = 8;
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.model.ForeColor = System.Drawing.Color.Red;
            this.model.Location = new System.Drawing.Point(136, 49);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(79, 20);
            this.model.TabIndex = 6;
            this.model.Text = "модель ";
            // 
            // typeDiv
            // 
            this.typeDiv.AutoSize = true;
            this.typeDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.typeDiv.ForeColor = System.Drawing.Color.Red;
            this.typeDiv.Location = new System.Drawing.Point(136, 6);
            this.typeDiv.Name = "typeDiv";
            this.typeDiv.Size = new System.Drawing.Size(126, 20);
            this.typeDiv.TabIndex = 6;
            this.typeDiv.Text = "тип устройва ";
            // 
            // label_model
            // 
            this.label_model.AutoSize = true;
            this.label_model.Location = new System.Drawing.Point(9, 52);
            this.label_model.Name = "label_model";
            this.label_model.Size = new System.Drawing.Size(78, 20);
            this.label_model.TabIndex = 6;
            this.label_model.Text = "Модель :";
            // 
            // label_type_div
            // 
            this.label_type_div.AutoSize = true;
            this.label_type_div.Location = new System.Drawing.Point(9, 6);
            this.label_type_div.Name = "label_type_div";
            this.label_type_div.Size = new System.Drawing.Size(117, 20);
            this.label_type_div.TabIndex = 6;
            this.label_type_div.Text = "Тип устройва :";
            // 
            // Location
            // 
            this.Location.BackColor = System.Drawing.SystemColors.Control;
            this.Location.Controls.Add(this.textBox_Floor);
            this.Location.Controls.Add(this.checkBox_Floor);
            this.Location.Controls.Add(this.comboBox_Floor);
            this.Location.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Location.Location = new System.Drawing.Point(762, 5);
            this.Location.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Location.Name = "Location";
            this.Location.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Location.Size = new System.Drawing.Size(205, 101);
            this.Location.TabIndex = 3;
            this.Location.TabStop = false;
            this.Location.Text = "Этаж";
            // 
            // textBox_Floor
            // 
            this.textBox_Floor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Floor.Enabled = false;
            this.textBox_Floor.Location = new System.Drawing.Point(4, 74);
            this.textBox_Floor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Floor.Name = "textBox_Floor";
            this.textBox_Floor.Size = new System.Drawing.Size(193, 23);
            this.textBox_Floor.TabIndex = 5;
            this.textBox_Floor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Floor_KeyUp);
            // 
            // checkBox_Floor
            // 
            this.checkBox_Floor.AutoSize = true;
            this.checkBox_Floor.Location = new System.Drawing.Point(8, 49);
            this.checkBox_Floor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_Floor.Name = "checkBox_Floor";
            this.checkBox_Floor.Size = new System.Drawing.Size(105, 21);
            this.checkBox_Floor.TabIndex = 4;
            this.checkBox_Floor.Text = "Новый этаж";
            this.checkBox_Floor.UseVisualStyleBackColor = true;
            this.checkBox_Floor.CheckedChanged += new System.EventHandler(this.checkBox_Floor_CheckedChanged);
            // 
            // comboBox_Floor
            // 
            this.comboBox_Floor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Floor.FormattingEnabled = true;
            this.comboBox_Floor.Location = new System.Drawing.Point(4, 19);
            this.comboBox_Floor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_Floor.Name = "comboBox_Floor";
            this.comboBox_Floor.Size = new System.Drawing.Size(193, 24);
            this.comboBox_Floor.TabIndex = 3;
            this.comboBox_Floor.SelectedIndexChanged += new System.EventHandler(this.comboBox_Floor_SelectedIndexChanged);
            // 
            // groupBox_LanName
            // 
            this.groupBox_LanName.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_LanName.Controls.Add(this.textBox_LanName);
            this.groupBox_LanName.Controls.Add(this.checkBox_LanName);
            this.groupBox_LanName.Controls.Add(this.comboBox_LanName);
            this.groupBox_LanName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_LanName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_LanName.Location = new System.Drawing.Point(549, 5);
            this.groupBox_LanName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_LanName.Name = "groupBox_LanName";
            this.groupBox_LanName.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_LanName.Size = new System.Drawing.Size(205, 101);
            this.groupBox_LanName.TabIndex = 3;
            this.groupBox_LanName.TabStop = false;
            this.groupBox_LanName.Text = "Название в сети";
            // 
            // textBox_LanName
            // 
            this.textBox_LanName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_LanName.Enabled = false;
            this.textBox_LanName.Location = new System.Drawing.Point(9, 74);
            this.textBox_LanName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_LanName.Name = "textBox_LanName";
            this.textBox_LanName.Size = new System.Drawing.Size(188, 23);
            this.textBox_LanName.TabIndex = 5;
            this.textBox_LanName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_LanName_KeyUp);
            // 
            // checkBox_LanName
            // 
            this.checkBox_LanName.AutoSize = true;
            this.checkBox_LanName.Location = new System.Drawing.Point(20, 49);
            this.checkBox_LanName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_LanName.Name = "checkBox_LanName";
            this.checkBox_LanName.Size = new System.Drawing.Size(179, 21);
            this.checkBox_LanName.TabIndex = 4;
            this.checkBox_LanName.Text = "Новое название в сети";
            this.checkBox_LanName.UseVisualStyleBackColor = true;
            this.checkBox_LanName.CheckedChanged += new System.EventHandler(this.checkBox_LanName_CheckedChanged);
            // 
            // comboBox_LanName
            // 
            this.comboBox_LanName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_LanName.FormattingEnabled = true;
            this.comboBox_LanName.Location = new System.Drawing.Point(8, 19);
            this.comboBox_LanName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_LanName.Name = "comboBox_LanName";
            this.comboBox_LanName.Size = new System.Drawing.Size(189, 24);
            this.comboBox_LanName.TabIndex = 3;
            this.comboBox_LanName.SelectedIndexChanged += new System.EventHandler(this.comboBox_LanName_SelectedIndexChanged);
            // 
            // groupBox_Responsible
            // 
            this.groupBox_Responsible.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_Responsible.Controls.Add(this.textBox_Responsible);
            this.groupBox_Responsible.Controls.Add(this.checkBox_Responsible);
            this.groupBox_Responsible.Controls.Add(this.comboBox_Responsible);
            this.groupBox_Responsible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Responsible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Responsible.Location = new System.Drawing.Point(336, 5);
            this.groupBox_Responsible.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_Responsible.Name = "groupBox_Responsible";
            this.groupBox_Responsible.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_Responsible.Size = new System.Drawing.Size(205, 101);
            this.groupBox_Responsible.TabIndex = 3;
            this.groupBox_Responsible.TabStop = false;
            this.groupBox_Responsible.Text = "Ответственный";
            // 
            // textBox_Responsible
            // 
            this.textBox_Responsible.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Responsible.Enabled = false;
            this.textBox_Responsible.Location = new System.Drawing.Point(9, 74);
            this.textBox_Responsible.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Responsible.Name = "textBox_Responsible";
            this.textBox_Responsible.Size = new System.Drawing.Size(190, 23);
            this.textBox_Responsible.TabIndex = 5;
            this.textBox_Responsible.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Responsible_KeyUp);
            // 
            // checkBox_Responsible
            // 
            this.checkBox_Responsible.AutoSize = true;
            this.checkBox_Responsible.Location = new System.Drawing.Point(9, 49);
            this.checkBox_Responsible.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_Responsible.Name = "checkBox_Responsible";
            this.checkBox_Responsible.Size = new System.Drawing.Size(206, 21);
            this.checkBox_Responsible.TabIndex = 4;
            this.checkBox_Responsible.Text = "Новое ответственное лицо";
            this.checkBox_Responsible.UseVisualStyleBackColor = true;
            this.checkBox_Responsible.CheckedChanged += new System.EventHandler(this.checkBox_Responsible_CheckedChanged);
            // 
            // comboBox_Responsible
            // 
            this.comboBox_Responsible.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Responsible.FormattingEnabled = true;
            this.comboBox_Responsible.Location = new System.Drawing.Point(9, 19);
            this.comboBox_Responsible.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_Responsible.Name = "comboBox_Responsible";
            this.comboBox_Responsible.Size = new System.Drawing.Size(188, 24);
            this.comboBox_Responsible.TabIndex = 3;
            this.comboBox_Responsible.SelectedIndexChanged += new System.EventHandler(this.comboBox_Responsible_SelectedIndexChanged);
            // 
            // groupBox_room
            // 
            this.groupBox_room.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_room.Controls.Add(this.textBox_Room);
            this.groupBox_room.Controls.Add(this.comboBox_Room);
            this.groupBox_room.Controls.Add(this.checkBox_Room);
            this.groupBox_room.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_room.Location = new System.Drawing.Point(975, 5);
            this.groupBox_room.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_room.Name = "groupBox_room";
            this.groupBox_room.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_room.Size = new System.Drawing.Size(208, 101);
            this.groupBox_room.TabIndex = 7;
            this.groupBox_room.TabStop = false;
            this.groupBox_room.Text = "Помещение";
            // 
            // textBox_Room
            // 
            this.textBox_Room.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Room.Enabled = false;
            this.textBox_Room.Location = new System.Drawing.Point(8, 74);
            this.textBox_Room.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Room.Name = "textBox_Room";
            this.textBox_Room.Size = new System.Drawing.Size(191, 23);
            this.textBox_Room.TabIndex = 5;
            this.textBox_Room.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Room_KeyUp);
            // 
            // comboBox_Room
            // 
            this.comboBox_Room.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Room.FormattingEnabled = true;
            this.comboBox_Room.Location = new System.Drawing.Point(8, 19);
            this.comboBox_Room.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_Room.Name = "comboBox_Room";
            this.comboBox_Room.Size = new System.Drawing.Size(192, 24);
            this.comboBox_Room.TabIndex = 3;
            this.comboBox_Room.SelectedIndexChanged += new System.EventHandler(this.comboBox_Room_SelectedIndexChanged);
            // 
            // checkBox_Room
            // 
            this.checkBox_Room.AutoSize = true;
            this.checkBox_Room.Location = new System.Drawing.Point(24, 49);
            this.checkBox_Room.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_Room.Name = "checkBox_Room";
            this.checkBox_Room.Size = new System.Drawing.Size(72, 21);
            this.checkBox_Room.TabIndex = 4;
            this.checkBox_Room.Text = "Новое ";
            this.checkBox_Room.UseVisualStyleBackColor = true;
            this.checkBox_Room.CheckedChanged += new System.EventHandler(this.checkBox_Room_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox_room, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_Responsible, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_LanName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Location, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1187, 111);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel3, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 114);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1184, 63);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button_change);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(424, 57);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.button_writtenoff);
            this.flowLayoutPanel2.Controls.Add(this.button_repairs);
            this.flowLayoutPanel2.Controls.Add(this.button_delete);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(433, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(424, 57);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.button_print_all);
            this.flowLayoutPanel3.Controls.Add(this.button_print_select_str);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(863, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(318, 57);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // button_change
            // 
            this.button_change.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.Card_Exchange_48px1;
            this.button_change.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_change.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_change.Location = new System.Drawing.Point(3, 3);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(191, 52);
            this.button_change.TabIndex = 0;
            this.button_change.Text = "            корректировка";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // button_writtenoff
            // 
            this.button_writtenoff.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.Horizontal_Line_48px;
            this.button_writtenoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_writtenoff.Location = new System.Drawing.Point(3, 3);
            this.button_writtenoff.Name = "button_writtenoff";
            this.button_writtenoff.Size = new System.Drawing.Size(52, 52);
            this.button_writtenoff.TabIndex = 0;
            this.button_writtenoff.UseVisualStyleBackColor = true;
            // 
            // button_repairs
            // 
            this.button_repairs.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.Truck_48px;
            this.button_repairs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_repairs.Location = new System.Drawing.Point(61, 3);
            this.button_repairs.Name = "button_repairs";
            this.button_repairs.Size = new System.Drawing.Size(52, 52);
            this.button_repairs.TabIndex = 0;
            this.button_repairs.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            this.button_delete.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.Trash_Can_48px;
            this.button_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_delete.Location = new System.Drawing.Point(119, 3);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(52, 52);
            this.button_delete.TabIndex = 0;
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // button_print_all
            // 
            this.button_print_all.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.Print_48px;
            this.button_print_all.Location = new System.Drawing.Point(263, 3);
            this.button_print_all.Name = "button_print_all";
            this.button_print_all.Size = new System.Drawing.Size(52, 52);
            this.button_print_all.TabIndex = 0;
            this.button_print_all.UseVisualStyleBackColor = true;
            this.button_print_all.Click += new System.EventHandler(this.button_print_all_Click);
            // 
            // button_print_select_str
            // 
            this.button_print_select_str.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.Typewriter_With_Screen_48px;
            this.button_print_select_str.Location = new System.Drawing.Point(205, 3);
            this.button_print_select_str.Name = "button_print_select_str";
            this.button_print_select_str.Size = new System.Drawing.Size(52, 52);
            this.button_print_select_str.TabIndex = 0;
            this.button_print_select_str.UseVisualStyleBackColor = true;
            this.button_print_select_str.Click += new System.EventHandler(this.button_print_select_str_Click);
            // 
            // setDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1187, 761);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "setDataBase";
            this.Text = "SetNewDate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.setDataBase_FormClosed);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Location.ResumeLayout(false);
            this.Location.PerformLayout();
            this.groupBox_LanName.ResumeLayout(false);
            this.groupBox_LanName.PerformLayout();
            this.groupBox_Responsible.ResumeLayout(false);
            this.groupBox_Responsible.PerformLayout();
            this.groupBox_room.ResumeLayout(false);
            this.groupBox_room.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_model;
        private System.Windows.Forms.Label label_type_div;
        private System.Windows.Forms.GroupBox Location;
        private System.Windows.Forms.TextBox textBox_Floor;
        private System.Windows.Forms.CheckBox checkBox_Floor;
        private System.Windows.Forms.ComboBox comboBox_Floor;
        private System.Windows.Forms.GroupBox groupBox_LanName;
        private System.Windows.Forms.TextBox textBox_LanName;
        private System.Windows.Forms.CheckBox checkBox_LanName;
        private System.Windows.Forms.ComboBox comboBox_LanName;
        private System.Windows.Forms.GroupBox groupBox_Responsible;
        private System.Windows.Forms.TextBox textBox_Responsible;
        private System.Windows.Forms.CheckBox checkBox_Responsible;
        private System.Windows.Forms.ComboBox comboBox_Responsible;
        private System.Windows.Forms.GroupBox groupBox_room;
        private System.Windows.Forms.TextBox textBox_Room;
        private System.Windows.Forms.ComboBox comboBox_Room;
        private System.Windows.Forms.CheckBox checkBox_Room;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button_writtenoff;
        private System.Windows.Forms.Button button_repairs;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button button_print_all;
        private System.Windows.Forms.Button button_print_select_str;
        private System.Windows.Forms.Label model;
        private System.Windows.Forms.Label typeDiv;
    }
}