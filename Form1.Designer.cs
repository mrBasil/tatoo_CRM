namespace tatoo_CRM
{
    partial class Form1
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
            this.date = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materials = new System.Windows.Forms.ToolStripMenuItem();
            this.settings_menue = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_seans = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_save_seans_list = new System.Windows.Forms.Button();
            this.dgw_table = new System.Windows.Forms.DataGridView();
            this.seansBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tp_calculate = new System.Windows.Forms.TabPage();
            this.lb_info = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_count_hour_calc = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save_tpCalculate = new System.Windows.Forms.Button();
            this.dtp_calculate = new System.Windows.Forms.DateTimePicker();
            this.dgw_calculete = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sebesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleenMonyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.seansBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dgw_calculate_materials = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countSeansDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_new_seans = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.seansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sebesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleenMonyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansBindingSource1)).BeginInit();
            this.tp_calculate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_count_hour_calc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_calculete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_calculate_materials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seansBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(5, 33);
            this.date.MaxSelectionCount = 31;
            this.date.Name = "date";
            this.date.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1130, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materials,
            this.settings_menue});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.менюToolStripMenuItem.Text = "меню";
            // 
            // materials
            // 
            this.materials.Name = "materials";
            this.materials.Size = new System.Drawing.Size(139, 22);
            this.materials.Text = "расходники";
            this.materials.Click += new System.EventHandler(this.materials_Click);
            // 
            // settings_menue
            // 
            this.settings_menue.Name = "settings_menue";
            this.settings_menue.Size = new System.Drawing.Size(139, 22);
            this.settings_menue.Text = "настройки";
            this.settings_menue.Click += new System.EventHandler(this.settings_menue_Click);
            // 
            // lb_seans
            // 
            this.lb_seans.AutoSize = true;
            this.lb_seans.Location = new System.Drawing.Point(9, 199);
            this.lb_seans.Name = "lb_seans";
            this.lb_seans.Size = new System.Drawing.Size(41, 13);
            this.lb_seans.TabIndex = 5;
            this.lb_seans.Text = "Сеанс.";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tp_calculate);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(176, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(943, 570);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_save_seans_list);
            this.tabPage1.Controls.Add(this.dgw_table);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(935, 544);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сеансы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_save_seans_list
            // 
            this.btn_save_seans_list.Location = new System.Drawing.Point(6, 515);
            this.btn_save_seans_list.Name = "btn_save_seans_list";
            this.btn_save_seans_list.Size = new System.Drawing.Size(75, 23);
            this.btn_save_seans_list.TabIndex = 8;
            this.btn_save_seans_list.Text = "Save";
            this.btn_save_seans_list.UseVisualStyleBackColor = true;
            this.btn_save_seans_list.Click += new System.EventHandler(this.btn_save_seans_list_Click);
            // 
            // dgw_table
            // 
            this.dgw_table.AllowUserToAddRows = false;
            this.dgw_table.AllowUserToDeleteRows = false;
            this.dgw_table.AutoGenerateColumns = false;
            this.dgw_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.sebesDataGridViewTextBoxColumn,
            this.cleenMonyDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.createDataDataGridViewTextBoxColumn,
            this.descrDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dgw_table.DataSource = this.seansBindingSource1;
            this.dgw_table.Location = new System.Drawing.Point(6, 3);
            this.dgw_table.Name = "dgw_table";
            this.dgw_table.Size = new System.Drawing.Size(923, 507);
            this.dgw_table.TabIndex = 7;
            // 
            // seansBindingSource1
            // 
            this.seansBindingSource1.DataSource = typeof(tatoo_CRM.dataBase.Seans);
            // 
            // tp_calculate
            // 
            this.tp_calculate.Controls.Add(this.lb_info);
            this.tp_calculate.Controls.Add(this.btn_calc);
            this.tp_calculate.Controls.Add(this.label2);
            this.tp_calculate.Controls.Add(this.nud_count_hour_calc);
            this.tp_calculate.Controls.Add(this.label1);
            this.tp_calculate.Controls.Add(this.btn_save_tpCalculate);
            this.tp_calculate.Controls.Add(this.dtp_calculate);
            this.tp_calculate.Controls.Add(this.dgw_calculete);
            this.tp_calculate.Controls.Add(this.dgw_calculate_materials);
            this.tp_calculate.Controls.Add(this.btn_new_seans);
            this.tp_calculate.Location = new System.Drawing.Point(4, 22);
            this.tp_calculate.Name = "tp_calculate";
            this.tp_calculate.Padding = new System.Windows.Forms.Padding(3);
            this.tp_calculate.Size = new System.Drawing.Size(935, 544);
            this.tp_calculate.TabIndex = 1;
            this.tp_calculate.Text = "Расчет";
            // 
            // lb_info
            // 
            this.lb_info.AutoSize = true;
            this.lb_info.Location = new System.Drawing.Point(311, 127);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(109, 13);
            this.lb_info.TabIndex = 9;
            this.lb_info.Text = "Расчет будет здесь!";
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(282, 33);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 8;
            this.btn_calc.Text = "Расчет";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Часов на сеанс";
            // 
            // nud_count_hour_calc
            // 
            this.nud_count_hour_calc.Location = new System.Drawing.Point(372, 6);
            this.nud_count_hour_calc.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_count_hour_calc.Name = "nud_count_hour_calc";
            this.nud_count_hour_calc.Size = new System.Drawing.Size(48, 20);
            this.nud_count_hour_calc.TabIndex = 6;
            this.nud_count_hour_calc.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(691, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выбери дату сеанса";
            // 
            // btn_save_tpCalculate
            // 
            this.btn_save_tpCalculate.Location = new System.Drawing.Point(853, 505);
            this.btn_save_tpCalculate.Name = "btn_save_tpCalculate";
            this.btn_save_tpCalculate.Size = new System.Drawing.Size(75, 23);
            this.btn_save_tpCalculate.TabIndex = 4;
            this.btn_save_tpCalculate.Text = "Сохранить";
            this.btn_save_tpCalculate.UseVisualStyleBackColor = true;
            this.btn_save_tpCalculate.Click += new System.EventHandler(this.btn_save_tpCalculate_Click);
            // 
            // dtp_calculate
            // 
            this.dtp_calculate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_calculate.Location = new System.Drawing.Point(807, 429);
            this.dtp_calculate.Name = "dtp_calculate";
            this.dtp_calculate.RightToLeftLayout = true;
            this.dtp_calculate.Size = new System.Drawing.Size(119, 20);
            this.dtp_calculate.TabIndex = 3;
            // 
            // dgw_calculete
            // 
            this.dgw_calculete.AutoGenerateColumns = false;
            this.dgw_calculete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_calculete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.clientDataGridViewTextBoxColumn1,
            this.sebesDataGridViewTextBoxColumn1,
            this.cleenMonyDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.dataDataGridViewTextBoxColumn1,
            this.descrDataGridViewTextBoxColumn1,
            this.phoneDataGridViewTextBoxColumn1,
            this.statusDataGridViewCheckBoxColumn1});
            this.dgw_calculete.DataSource = this.seansBindingSource2;
            this.dgw_calculete.Location = new System.Drawing.Point(265, 268);
            this.dgw_calculete.Name = "dgw_calculete";
            this.dgw_calculete.Size = new System.Drawing.Size(664, 131);
            this.dgw_calculete.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 40;
            // 
            // clientDataGridViewTextBoxColumn1
            // 
            this.clientDataGridViewTextBoxColumn1.DataPropertyName = "client";
            this.clientDataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.clientDataGridViewTextBoxColumn1.Name = "clientDataGridViewTextBoxColumn1";
            // 
            // sebesDataGridViewTextBoxColumn1
            // 
            this.sebesDataGridViewTextBoxColumn1.DataPropertyName = "sebes";
            this.sebesDataGridViewTextBoxColumn1.HeaderText = "Себес.";
            this.sebesDataGridViewTextBoxColumn1.Name = "sebesDataGridViewTextBoxColumn1";
            this.sebesDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cleenMonyDataGridViewTextBoxColumn1
            // 
            this.cleenMonyDataGridViewTextBoxColumn1.DataPropertyName = "cleenMony";
            this.cleenMonyDataGridViewTextBoxColumn1.HeaderText = "Прибыль";
            this.cleenMonyDataGridViewTextBoxColumn1.Name = "cleenMonyDataGridViewTextBoxColumn1";
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            // 
            // dataDataGridViewTextBoxColumn1
            // 
            this.dataDataGridViewTextBoxColumn1.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn1.HeaderText = "Дата";
            this.dataDataGridViewTextBoxColumn1.Name = "dataDataGridViewTextBoxColumn1";
            // 
            // descrDataGridViewTextBoxColumn1
            // 
            this.descrDataGridViewTextBoxColumn1.DataPropertyName = "descr";
            this.descrDataGridViewTextBoxColumn1.HeaderText = "Описание";
            this.descrDataGridViewTextBoxColumn1.Name = "descrDataGridViewTextBoxColumn1";
            // 
            // phoneDataGridViewTextBoxColumn1
            // 
            this.phoneDataGridViewTextBoxColumn1.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn1.HeaderText = "Номер";
            this.phoneDataGridViewTextBoxColumn1.Name = "phoneDataGridViewTextBoxColumn1";
            // 
            // statusDataGridViewCheckBoxColumn1
            // 
            this.statusDataGridViewCheckBoxColumn1.DataPropertyName = "status";
            this.statusDataGridViewCheckBoxColumn1.HeaderText = "Подтвержден";
            this.statusDataGridViewCheckBoxColumn1.Name = "statusDataGridViewCheckBoxColumn1";
            // 
            // seansBindingSource2
            // 
            this.seansBindingSource2.DataSource = typeof(tatoo_CRM.dataBase.Seans);
            // 
            // dgw_calculate_materials
            // 
            this.dgw_calculate_materials.AllowUserToAddRows = false;
            this.dgw_calculate_materials.AllowUserToDeleteRows = false;
            this.dgw_calculate_materials.AutoGenerateColumns = false;
            this.dgw_calculate_materials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_calculate_materials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.nameDataGridViewTextBoxColumn,
            this.countSeansDataGridViewTextBoxColumn});
            this.dgw_calculate_materials.DataSource = this.materialBindingSource;
            this.dgw_calculate_materials.Location = new System.Drawing.Point(7, 6);
            this.dgw_calculate_materials.Name = "dgw_calculate_materials";
            this.dgw_calculate_materials.Size = new System.Drawing.Size(251, 522);
            this.dgw_calculate_materials.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "№";
            this.Column1.Name = "Column1";
            this.Column1.Width = 40;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Расходники";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // countSeansDataGridViewTextBoxColumn
            // 
            this.countSeansDataGridViewTextBoxColumn.DataPropertyName = "countSeans";
            this.countSeansDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.countSeansDataGridViewTextBoxColumn.Name = "countSeansDataGridViewTextBoxColumn";
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataSource = typeof(tatoo_CRM.dataBase.Material);
            // 
            // btn_new_seans
            // 
            this.btn_new_seans.Location = new System.Drawing.Point(694, 464);
            this.btn_new_seans.Name = "btn_new_seans";
            this.btn_new_seans.Size = new System.Drawing.Size(232, 35);
            this.btn_new_seans.TabIndex = 0;
            this.btn_new_seans.Text = "Добавить сеанс";
            this.btn_new_seans.UseVisualStyleBackColor = true;
            this.btn_new_seans.Click += new System.EventHandler(this.btn_new_seans_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(935, 544);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Финансы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Тут пока нихуя нет, потому что я не совсем понимаю что тут должно быьть";
            // 
            // seansBindingSource
            // 
            this.seansBindingSource.DataSource = typeof(tatoo_CRM.dataBase.Seans);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Статус";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.Width = 50;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            // 
            // sebesDataGridViewTextBoxColumn
            // 
            this.sebesDataGridViewTextBoxColumn.DataPropertyName = "sebes";
            this.sebesDataGridViewTextBoxColumn.HeaderText = "Себес. р.";
            this.sebesDataGridViewTextBoxColumn.Name = "sebesDataGridViewTextBoxColumn";
            this.sebesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cleenMonyDataGridViewTextBoxColumn
            // 
            this.cleenMonyDataGridViewTextBoxColumn.DataPropertyName = "cleenMony";
            this.cleenMonyDataGridViewTextBoxColumn.HeaderText = "Чистыми р.";
            this.cleenMonyDataGridViewTextBoxColumn.Name = "cleenMonyDataGridViewTextBoxColumn";
            this.cleenMonyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена р.";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Дата сеанса";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createDataDataGridViewTextBoxColumn
            // 
            this.createDataDataGridViewTextBoxColumn.DataPropertyName = "createData";
            this.createDataDataGridViewTextBoxColumn.HeaderText = "Дата обр.";
            this.createDataDataGridViewTextBoxColumn.Name = "createDataDataGridViewTextBoxColumn";
            this.createDataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descrDataGridViewTextBoxColumn
            // 
            this.descrDataGridViewTextBoxColumn.DataPropertyName = "descr";
            this.descrDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descrDataGridViewTextBoxColumn.Name = "descrDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 615);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lb_seans);
            this.Controls.Add(this.date);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Расчет сеансов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansBindingSource1)).EndInit();
            this.tp_calculate.ResumeLayout(false);
            this.tp_calculate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_count_hour_calc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_calculete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_calculate_materials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seansBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar date;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materials;
        private System.Windows.Forms.BindingSource seansBindingSource;
        private System.Windows.Forms.Label lb_seans;
        private System.Windows.Forms.BindingSource seansBindingSource1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgw_table;
        private System.Windows.Forms.TabPage tp_calculate;
        private System.Windows.Forms.Button btn_new_seans;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgw_calculate_materials;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private System.Windows.Forms.DateTimePicker dtp_calculate;
        private System.Windows.Forms.DataGridView dgw_calculete;
        private System.Windows.Forms.BindingSource seansBindingSource2;
        private System.Windows.Forms.Button btn_save_tpCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem settings_menue;
        private System.Windows.Forms.NumericUpDown nud_count_hour_calc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_info;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Button btn_save_seans_list;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sebesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cleenMonyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countSeansDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sebesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cleenMonyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
    }
}

