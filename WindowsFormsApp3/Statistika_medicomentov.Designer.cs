namespace WindowsFormsApp3
{
    partial class Statistika_medicomentov
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistika_medicomentov));
            this.аптекаDataSet = new WindowsFormsApp3.АптекаDataSet();
            this.статистика_МедикаментовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.статистика_МедикаментовTableAdapter = new WindowsFormsApp3.АптекаDataSetTableAdapters.Статистика_МедикаментовTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.АптекаDataSetTableAdapters.TableAdapterManager();
            this.статистика_МедикаментовBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.статистика_МедикаментовBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.статистика_МедикаментовBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.аптекаDataSet1 = new WindowsFormsApp3.АптекаDataSet1();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.статистика_МедикаментовTableAdapter1 = new WindowsFormsApp3.АптекаDataSet1TableAdapters.Статистика_МедикаментовTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApp3.АптекаDataSet1TableAdapters.TableAdapterManager();
            this.статистика_МедикаментовDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.аптекаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.статистика_МедикаментовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.статистика_МедикаментовBindingNavigator)).BeginInit();
            this.статистика_МедикаментовBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.статистика_МедикаментовBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекаDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.статистика_МедикаментовDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // аптекаDataSet
            // 
            this.аптекаDataSet.DataSetName = "АптекаDataSet";
            this.аптекаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // статистика_МедикаментовBindingSource
            // 
            this.статистика_МедикаментовBindingSource.DataMember = "Статистика Медикаментов";
            this.статистика_МедикаментовBindingSource.DataSource = this.аптекаDataSet;
            // 
            // статистика_МедикаментовTableAdapter
            // 
            this.статистика_МедикаментовTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3.АптекаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Вид_диагнозаTableAdapter = null;
            this.tableAdapterManager.ВрачTableAdapter = null;
            this.tableAdapterManager.Выдача_лекарстваTableAdapter = null;
            this.tableAdapterManager.ДиагнозTableAdapter = null;
            this.tableAdapterManager.Заказы_лекарствTableAdapter = null;
            this.tableAdapterManager.ЗаявкаTableAdapter = null;
            this.tableAdapterManager.ИнгридиентыTableAdapter = null;
            this.tableAdapterManager.Критическая_нормаTableAdapter = null;
            this.tableAdapterManager.ЛекарстваTableAdapter = null;
            this.tableAdapterManager.ПациентTableAdapter = null;
            this.tableAdapterManager.РегистратураTableAdapter = null;
            this.tableAdapterManager.РецептTableAdapter = null;
            this.tableAdapterManager.СкладTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Способ_приготовленияTableAdapter = null;
            this.tableAdapterManager.Справочник_заказовTableAdapter = null;
            this.tableAdapterManager.Справочник_технологийTableAdapter = null;
            this.tableAdapterManager.Статистика_МедикаментовTableAdapter = this.статистика_МедикаментовTableAdapter;
            this.tableAdapterManager.ТехнологииTableAdapter = null;
            this.tableAdapterManager.Тип_лекарстваTableAdapter = null;
            this.tableAdapterManager.Условия_храненияTableAdapter = null;
            this.tableAdapterManager.Фильтрация_лекарствTableAdapter = null;
            // 
            // статистика_МедикаментовBindingNavigator
            // 
            this.статистика_МедикаментовBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.статистика_МедикаментовBindingNavigator.BindingSource = this.статистика_МедикаментовBindingSource;
            this.статистика_МедикаментовBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.статистика_МедикаментовBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.статистика_МедикаментовBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.статистика_МедикаментовBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.статистика_МедикаментовBindingNavigatorSaveItem});
            this.статистика_МедикаментовBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.статистика_МедикаментовBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.статистика_МедикаментовBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.статистика_МедикаментовBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.статистика_МедикаментовBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.статистика_МедикаментовBindingNavigator.Name = "статистика_МедикаментовBindingNavigator";
            this.статистика_МедикаментовBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.статистика_МедикаментовBindingNavigator.Size = new System.Drawing.Size(544, 27);
            this.статистика_МедикаментовBindingNavigator.TabIndex = 0;
            this.статистика_МедикаментовBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // статистика_МедикаментовBindingNavigatorSaveItem
            // 
            this.статистика_МедикаментовBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.статистика_МедикаментовBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("статистика_МедикаментовBindingNavigatorSaveItem.Image")));
            this.статистика_МедикаментовBindingNavigatorSaveItem.Name = "статистика_МедикаментовBindingNavigatorSaveItem";
            this.статистика_МедикаментовBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.статистика_МедикаментовBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.статистика_МедикаментовBindingNavigatorSaveItem.Click += new System.EventHandler(this.статистика_МедикаментовBindingNavigatorSaveItem_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(309, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 19);
            this.label4.TabIndex = 65;
            this.label4.Text = "Статистика";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.статистика_МедикаментовBindingSource1, "Статистика", true));
            this.textBox4.Location = new System.Drawing.Point(313, 76);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(159, 20);
            this.textBox4.TabIndex = 64;
            // 
            // статистика_МедикаментовBindingSource1
            // 
            this.статистика_МедикаментовBindingSource1.DataMember = "Статистика Медикаментов";
            this.статистика_МедикаментовBindingSource1.DataSource = this.аптекаDataSet1;
            // 
            // аптекаDataSet1
            // 
            this.аптекаDataSet1.DataSetName = "АптекаDataSet1";
            this.аптекаDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button5
            // 
            this.button5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.статистика_МедикаментовBindingSource, "Статистика", true));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(391, 272);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 55);
            this.button5.TabIndex = 63;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(391, 154);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 55);
            this.button4.TabIndex = 62;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(391, 214);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 55);
            this.button3.TabIndex = 61;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(299, 244);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 67);
            this.button2.TabIndex = 60;
            this.button2.Text = "DOWN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(299, 162);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 67);
            this.button1.TabIndex = 59;
            this.button1.Text = "UP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // статистика_МедикаментовTableAdapter1
            // 
            this.статистика_МедикаментовTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp3.АптекаDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.Вид_диагнозаTableAdapter = null;
            this.tableAdapterManager1.ВрачTableAdapter = null;
            this.tableAdapterManager1.Выдача_лекарстваTableAdapter = null;
            this.tableAdapterManager1.ДиагнозTableAdapter = null;
            this.tableAdapterManager1.Заказы_лекарствTableAdapter = null;
            this.tableAdapterManager1.ЗаявкаTableAdapter = null;
            this.tableAdapterManager1.Изготовление_лекарствTableAdapter = null;
            this.tableAdapterManager1.ИнгридиентыTableAdapter = null;
            this.tableAdapterManager1.Критическая_нормаTableAdapter = null;
            this.tableAdapterManager1.ЛекарстваTableAdapter = null;
            this.tableAdapterManager1.ПациентTableAdapter = null;
            this.tableAdapterManager1.РегистратураTableAdapter = null;
            this.tableAdapterManager1.РецептTableAdapter = null;
            this.tableAdapterManager1.СкладTableAdapter = null;
            this.tableAdapterManager1.СотрудникиTableAdapter = null;
            this.tableAdapterManager1.Способ_приготовленияTableAdapter = null;
            this.tableAdapterManager1.Справочник_заказовTableAdapter = null;
            this.tableAdapterManager1.Справочник_технологийTableAdapter = null;
            this.tableAdapterManager1.Статистика_МедикаментовTableAdapter = this.статистика_МедикаментовTableAdapter1;
            this.tableAdapterManager1.ТехнологииTableAdapter = null;
            this.tableAdapterManager1.Тип_лекарстваTableAdapter = null;
            this.tableAdapterManager1.Условия_храненияTableAdapter = null;
            this.tableAdapterManager1.Фильтрация_лекарствTableAdapter = null;
            // 
            // статистика_МедикаментовDataGridView
            // 
            this.статистика_МедикаментовDataGridView.AutoGenerateColumns = false;
            this.статистика_МедикаментовDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.статистика_МедикаментовDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.статистика_МедикаментовDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.статистика_МедикаментовDataGridView.DataSource = this.статистика_МедикаментовBindingSource1;
            this.статистика_МедикаментовDataGridView.Location = new System.Drawing.Point(0, 29);
            this.статистика_МедикаментовDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.статистика_МедикаментовDataGridView.Name = "статистика_МедикаментовDataGridView";
            this.статистика_МедикаментовDataGridView.ReadOnly = true;
            this.статистика_МедикаментовDataGridView.RowTemplate.Height = 24;
            this.статистика_МедикаментовDataGridView.Size = new System.Drawing.Size(250, 322);
            this.статистика_МедикаментовDataGridView.TabIndex = 65;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Статистика";
            this.dataGridViewTextBoxColumn2.HeaderText = "Статистика";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Statistika_medicomentov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(544, 352);
            this.Controls.Add(this.статистика_МедикаментовDataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.статистика_МедикаментовBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(560, 391);
            this.MinimumSize = new System.Drawing.Size(560, 391);
            this.Name = "Statistika_medicomentov";
            this.Text = "Statistika_medicomentov";
            this.Load += new System.EventHandler(this.Statistika_medicomentov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.аптекаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.статистика_МедикаментовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.статистика_МедикаментовBindingNavigator)).EndInit();
            this.статистика_МедикаментовBindingNavigator.ResumeLayout(false);
            this.статистика_МедикаментовBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.статистика_МедикаментовBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекаDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.статистика_МедикаментовDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private АптекаDataSet аптекаDataSet;
        private System.Windows.Forms.BindingSource статистика_МедикаментовBindingSource;
        private АптекаDataSetTableAdapters.Статистика_МедикаментовTableAdapter статистика_МедикаментовTableAdapter;
        private АптекаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator статистика_МедикаментовBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton статистика_МедикаментовBindingNavigatorSaveItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private АптекаDataSet1 аптекаDataSet1;
        private System.Windows.Forms.BindingSource статистика_МедикаментовBindingSource1;
        private АптекаDataSet1TableAdapters.Статистика_МедикаментовTableAdapter статистика_МедикаментовTableAdapter1;
        private АптекаDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView статистика_МедикаментовDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}