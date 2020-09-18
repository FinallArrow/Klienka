namespace WindowsFormsApp3
{
    partial class Kryticheskaya_norma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kryticheskaya_norma));
            this.аптекаDataSet = new WindowsFormsApp3.АптекаDataSet();
            this.критическая_нормаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.критическая_нормаTableAdapter = new WindowsFormsApp3.АптекаDataSetTableAdapters.Критическая_нормаTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.АптекаDataSetTableAdapters.TableAdapterManager();
            this.критическая_нормаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.критическая_нормаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.складBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.критическаяНормаBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.критическаяНормаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.критическаяНормаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.складTableAdapter = new WindowsFormsApp3.АптекаDataSetTableAdapters.СкладTableAdapter();
            this.аптекаDataSet1 = new WindowsFormsApp3.АптекаDataSet1();
            this.критическая_нормаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.критическая_нормаTableAdapter1 = new WindowsFormsApp3.АптекаDataSet1TableAdapters.Критическая_нормаTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApp3.АптекаDataSet1TableAdapters.TableAdapterManager();
            this.лекарстваTableAdapter = new WindowsFormsApp3.АптекаDataSet1TableAdapters.ЛекарстваTableAdapter();
            this.критическая_нормаDataGridView = new System.Windows.Forms.DataGridView();
            this.лекарстваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.аптекаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.критическая_нормаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.критическая_нормаBindingNavigator)).BeginInit();
            this.критическая_нормаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.критическаяНормаBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.критическаяНормаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.критическаяНормаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекаDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.критическая_нормаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.критическая_нормаDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // аптекаDataSet
            // 
            this.аптекаDataSet.DataSetName = "АптекаDataSet";
            this.аптекаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // критическая_нормаBindingSource
            // 
            this.критическая_нормаBindingSource.DataMember = "Критическая норма";
            this.критическая_нормаBindingSource.DataSource = this.аптекаDataSet;
            // 
            // критическая_нормаTableAdapter
            // 
            this.критическая_нормаTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Критическая_нормаTableAdapter = this.критическая_нормаTableAdapter;
            this.tableAdapterManager.ЛекарстваTableAdapter = null;
            this.tableAdapterManager.ПациентTableAdapter = null;
            this.tableAdapterManager.РегистратураTableAdapter = null;
            this.tableAdapterManager.РецептTableAdapter = null;
            this.tableAdapterManager.СкладTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Способ_приготовленияTableAdapter = null;
            this.tableAdapterManager.Справочник_заказовTableAdapter = null;
            this.tableAdapterManager.Справочник_технологийTableAdapter = null;
            this.tableAdapterManager.Статистика_МедикаментовTableAdapter = null;
            this.tableAdapterManager.ТехнологииTableAdapter = null;
            this.tableAdapterManager.Тип_лекарстваTableAdapter = null;
            this.tableAdapterManager.Условия_храненияTableAdapter = null;
            this.tableAdapterManager.Фильтрация_лекарствTableAdapter = null;
            // 
            // критическая_нормаBindingNavigator
            // 
            this.критическая_нормаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.критическая_нормаBindingNavigator.BindingSource = this.критическая_нормаBindingSource;
            this.критическая_нормаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.критическая_нормаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.критическая_нормаBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.критическая_нормаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.критическая_нормаBindingNavigatorSaveItem});
            this.критическая_нормаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.критическая_нормаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.критическая_нормаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.критическая_нормаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.критическая_нормаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.критическая_нормаBindingNavigator.Name = "критическая_нормаBindingNavigator";
            this.критическая_нормаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.критическая_нормаBindingNavigator.Size = new System.Drawing.Size(522, 27);
            this.критическая_нормаBindingNavigator.TabIndex = 0;
            this.критическая_нормаBindingNavigator.Text = "bindingNavigator1";
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
            // критическая_нормаBindingNavigatorSaveItem
            // 
            this.критическая_нормаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.критическая_нормаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("критическая_нормаBindingNavigatorSaveItem.Image")));
            this.критическая_нормаBindingNavigatorSaveItem.Name = "критическая_нормаBindingNavigatorSaveItem";
            this.критическая_нормаBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.критическая_нормаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.критическая_нормаBindingNavigatorSaveItem.Click += new System.EventHandler(this.критическая_нормаBindingNavigatorSaveItem_Click);
            // 
            // складBindingSource
            // 
            this.складBindingSource.DataMember = "Склад";
            this.складBindingSource.DataSource = this.аптекаDataSet;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(295, 168);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 67);
            this.button2.TabIndex = 24;
            this.button2.Text = "DOWN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(295, 86);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 67);
            this.button1.TabIndex = 23;
            this.button1.Text = "UP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // критическаяНормаBindingSource2
            // 
            this.критическаяНормаBindingSource2.DataMember = "Критическая норма";
            this.критическаяНормаBindingSource2.DataSource = this.аптекаDataSet;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(399, 136);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 55);
            this.button3.TabIndex = 25;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(399, 196);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 55);
            this.button5.TabIndex = 27;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(399, 76);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 55);
            this.button4.TabIndex = 26;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // критическаяНормаBindingSource
            // 
            this.критическаяНормаBindingSource.DataMember = "Критическая норма";
            this.критическаяНормаBindingSource.DataSource = this.аптекаDataSet;
            // 
            // критическаяНормаBindingSource1
            // 
            this.критическаяНормаBindingSource1.DataMember = "Критическая норма";
            this.критическаяНормаBindingSource1.DataSource = this.аптекаDataSet;
            // 
            // складTableAdapter
            // 
            this.складTableAdapter.ClearBeforeFill = true;
            // 
            // аптекаDataSet1
            // 
            this.аптекаDataSet1.DataSetName = "АптекаDataSet1";
            this.аптекаDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // критическая_нормаBindingSource1
            // 
            this.критическая_нормаBindingSource1.DataMember = "Критическая норма";
            this.критическая_нормаBindingSource1.DataSource = this.аптекаDataSet1;
            // 
            // критическая_нормаTableAdapter1
            // 
            this.критическая_нормаTableAdapter1.ClearBeforeFill = true;
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
            this.tableAdapterManager1.Критическая_нормаTableAdapter = this.критическая_нормаTableAdapter1;
            this.tableAdapterManager1.ЛекарстваTableAdapter = this.лекарстваTableAdapter;
            this.tableAdapterManager1.ПациентTableAdapter = null;
            this.tableAdapterManager1.РегистратураTableAdapter = null;
            this.tableAdapterManager1.РецептTableAdapter = null;
            this.tableAdapterManager1.СкладTableAdapter = null;
            this.tableAdapterManager1.СотрудникиTableAdapter = null;
            this.tableAdapterManager1.Способ_приготовленияTableAdapter = null;
            this.tableAdapterManager1.Справочник_заказовTableAdapter = null;
            this.tableAdapterManager1.Справочник_технологийTableAdapter = null;
            this.tableAdapterManager1.Статистика_МедикаментовTableAdapter = null;
            this.tableAdapterManager1.ТехнологииTableAdapter = null;
            this.tableAdapterManager1.Тип_лекарстваTableAdapter = null;
            this.tableAdapterManager1.Условия_храненияTableAdapter = null;
            this.tableAdapterManager1.Фильтрация_лекарствTableAdapter = null;
            // 
            // лекарстваTableAdapter
            // 
            this.лекарстваTableAdapter.ClearBeforeFill = true;
            // 
            // критическая_нормаDataGridView
            // 
            this.критическая_нормаDataGridView.AutoGenerateColumns = false;
            this.критическая_нормаDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.критическая_нормаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.критическая_нормаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.критическая_нормаDataGridView.DataSource = this.критическая_нормаBindingSource1;
            this.критическая_нормаDataGridView.Location = new System.Drawing.Point(0, 24);
            this.критическая_нормаDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.критическая_нормаDataGridView.Name = "критическая_нормаDataGridView";
            this.критическая_нормаDataGridView.RowTemplate.Height = 24;
            this.критическая_нормаDataGridView.Size = new System.Drawing.Size(268, 293);
            this.критическая_нормаDataGridView.TabIndex = 28;
            // 
            // лекарстваBindingSource
            // 
            this.лекарстваBindingSource.DataMember = "Лекарства";
            this.лекарстваBindingSource.DataSource = this.аптекаDataSet1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Название Лекарства";
            this.dataGridViewTextBoxColumn2.DataSource = this.лекарстваBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Название";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название Лекарства";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "Код";
            // 
            // Kryticheskaya_norma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(522, 317);
            this.Controls.Add(this.критическая_нормаDataGridView);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.критическая_нормаBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(538, 356);
            this.MinimumSize = new System.Drawing.Size(538, 356);
            this.Name = "Kryticheskaya_norma";
            this.Text = "Kryticheskaya_norma";
            this.Load += new System.EventHandler(this.Kryticheskaya_norma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.аптекаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.критическая_нормаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.критическая_нормаBindingNavigator)).EndInit();
            this.критическая_нормаBindingNavigator.ResumeLayout(false);
            this.критическая_нормаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.критическаяНормаBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.критическаяНормаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.критическаяНормаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекаDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.критическая_нормаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.критическая_нормаDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private АптекаDataSet аптекаDataSet;
        private System.Windows.Forms.BindingSource критическая_нормаBindingSource;
        private АптекаDataSetTableAdapters.Критическая_нормаTableAdapter критическая_нормаTableAdapter;
        private АптекаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator критическая_нормаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton критическая_нормаBindingNavigatorSaveItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource критическаяНормаBindingSource;
        private System.Windows.Forms.BindingSource критическаяНормаBindingSource1;
        private System.Windows.Forms.BindingSource складBindingSource;
        private АптекаDataSetTableAdapters.СкладTableAdapter складTableAdapter;
        private System.Windows.Forms.BindingSource критическаяНормаBindingSource2;
        private АптекаDataSet1 аптекаDataSet1;
        private System.Windows.Forms.BindingSource критическая_нормаBindingSource1;
        private АптекаDataSet1TableAdapters.Критическая_нормаTableAdapter критическая_нормаTableAdapter1;
        private АптекаDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView критическая_нормаDataGridView;
        private АптекаDataSet1TableAdapters.ЛекарстваTableAdapter лекарстваTableAdapter;
        private System.Windows.Forms.BindingSource лекарстваBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
    }
}