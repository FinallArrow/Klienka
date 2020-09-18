namespace WindowsFormsApp3
{
    partial class Spravochniky_zakazov
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spravochniky_zakazov));
            this.аптекаDataSet = new WindowsFormsApp3.АптекаDataSet();
            this.справочник_заказовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.справочник_заказовTableAdapter = new WindowsFormsApp3.АптекаDataSetTableAdapters.Справочник_заказовTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.АптекаDataSetTableAdapters.TableAdapterManager();
            this.справочник_заказовBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.справочник_заказовBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.лекарстваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.лекарстваTableAdapter = new WindowsFormsApp3.АптекаDataSetTableAdapters.ЛекарстваTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.аптекаDataSet1 = new WindowsFormsApp3.АптекаDataSet1();
            this.справочник_заказовBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.справочник_заказовTableAdapter1 = new WindowsFormsApp3.АптекаDataSet1TableAdapters.Справочник_заказовTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApp3.АптекаDataSet1TableAdapters.TableAdapterManager();
            this.лекарстваTableAdapter1 = new WindowsFormsApp3.АптекаDataSet1TableAdapters.ЛекарстваTableAdapter();
            this.справочник_заказовDataGridView = new System.Windows.Forms.DataGridView();
            this.лекарстваBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.аптекаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочник_заказовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочник_заказовBindingNavigator)).BeginInit();
            this.справочник_заказовBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекаDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочник_заказовBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочник_заказовDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // аптекаDataSet
            // 
            this.аптекаDataSet.DataSetName = "АптекаDataSet";
            this.аптекаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // справочник_заказовBindingSource
            // 
            this.справочник_заказовBindingSource.DataMember = "Справочник заказов";
            this.справочник_заказовBindingSource.DataSource = this.аптекаDataSet;
            // 
            // справочник_заказовTableAdapter
            // 
            this.справочник_заказовTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Справочник_заказовTableAdapter = this.справочник_заказовTableAdapter;
            this.tableAdapterManager.Справочник_технологийTableAdapter = null;
            this.tableAdapterManager.Статистика_МедикаментовTableAdapter = null;
            this.tableAdapterManager.ТехнологииTableAdapter = null;
            this.tableAdapterManager.Тип_лекарстваTableAdapter = null;
            this.tableAdapterManager.Условия_храненияTableAdapter = null;
            this.tableAdapterManager.Фильтрация_лекарствTableAdapter = null;
            // 
            // справочник_заказовBindingNavigator
            // 
            this.справочник_заказовBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.справочник_заказовBindingNavigator.BindingSource = this.справочник_заказовBindingSource;
            this.справочник_заказовBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.справочник_заказовBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.справочник_заказовBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.справочник_заказовBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.справочник_заказовBindingNavigatorSaveItem});
            this.справочник_заказовBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.справочник_заказовBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.справочник_заказовBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.справочник_заказовBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.справочник_заказовBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.справочник_заказовBindingNavigator.Name = "справочник_заказовBindingNavigator";
            this.справочник_заказовBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.справочник_заказовBindingNavigator.Size = new System.Drawing.Size(507, 27);
            this.справочник_заказовBindingNavigator.TabIndex = 0;
            this.справочник_заказовBindingNavigator.Text = "bindingNavigator1";
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
            // справочник_заказовBindingNavigatorSaveItem
            // 
            this.справочник_заказовBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.справочник_заказовBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("справочник_заказовBindingNavigatorSaveItem.Image")));
            this.справочник_заказовBindingNavigatorSaveItem.Name = "справочник_заказовBindingNavigatorSaveItem";
            this.справочник_заказовBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.справочник_заказовBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.справочник_заказовBindingNavigatorSaveItem.Click += new System.EventHandler(this.справочник_заказовBindingNavigatorSaveItem_Click);
            // 
            // лекарстваBindingSource
            // 
            this.лекарстваBindingSource.DataMember = "Лекарства";
            this.лекарстваBindingSource.DataSource = this.аптекаDataSet;
            // 
            // лекарстваTableAdapter
            // 
            this.лекарстваTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(294, 182);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 67);
            this.button2.TabIndex = 55;
            this.button2.Text = "DOWN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(294, 101);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 67);
            this.button1.TabIndex = 54;
            this.button1.Text = "UP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(398, 208);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 55);
            this.button5.TabIndex = 78;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(398, 88);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 55);
            this.button4.TabIndex = 77;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(398, 148);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 55);
            this.button3.TabIndex = 76;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // аптекаDataSet1
            // 
            this.аптекаDataSet1.DataSetName = "АптекаDataSet1";
            this.аптекаDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // справочник_заказовBindingSource1
            // 
            this.справочник_заказовBindingSource1.DataMember = "Справочник заказов";
            this.справочник_заказовBindingSource1.DataSource = this.аптекаDataSet1;
            // 
            // справочник_заказовTableAdapter1
            // 
            this.справочник_заказовTableAdapter1.ClearBeforeFill = true;
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
            this.tableAdapterManager1.ЛекарстваTableAdapter = this.лекарстваTableAdapter1;
            this.tableAdapterManager1.ПациентTableAdapter = null;
            this.tableAdapterManager1.РегистратураTableAdapter = null;
            this.tableAdapterManager1.РецептTableAdapter = null;
            this.tableAdapterManager1.СкладTableAdapter = null;
            this.tableAdapterManager1.СотрудникиTableAdapter = null;
            this.tableAdapterManager1.Способ_приготовленияTableAdapter = null;
            this.tableAdapterManager1.Справочник_заказовTableAdapter = this.справочник_заказовTableAdapter1;
            this.tableAdapterManager1.Справочник_технологийTableAdapter = null;
            this.tableAdapterManager1.Статистика_МедикаментовTableAdapter = null;
            this.tableAdapterManager1.ТехнологииTableAdapter = null;
            this.tableAdapterManager1.Тип_лекарстваTableAdapter = null;
            this.tableAdapterManager1.Условия_храненияTableAdapter = null;
            this.tableAdapterManager1.Фильтрация_лекарствTableAdapter = null;
            // 
            // лекарстваTableAdapter1
            // 
            this.лекарстваTableAdapter1.ClearBeforeFill = true;
            // 
            // справочник_заказовDataGridView
            // 
            this.справочник_заказовDataGridView.AutoGenerateColumns = false;
            this.справочник_заказовDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.справочник_заказовDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.справочник_заказовDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.справочник_заказовDataGridView.DataSource = this.справочник_заказовBindingSource1;
            this.справочник_заказовDataGridView.Location = new System.Drawing.Point(0, 29);
            this.справочник_заказовDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.справочник_заказовDataGridView.Name = "справочник_заказовDataGridView";
            this.справочник_заказовDataGridView.RowTemplate.Height = 24;
            this.справочник_заказовDataGridView.Size = new System.Drawing.Size(268, 272);
            this.справочник_заказовDataGridView.TabIndex = 80;
            // 
            // лекарстваBindingSource1
            // 
            this.лекарстваBindingSource1.DataMember = "Лекарства";
            this.лекарстваBindingSource1.DataSource = this.аптекаDataSet1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Категория лекарства";
            this.dataGridViewTextBoxColumn2.DataSource = this.лекарстваBindingSource1;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Название";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название лекарства";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "Код";
            // 
            // Spravochniky_zakazov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(507, 301);
            this.Controls.Add(this.справочник_заказовDataGridView);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.справочник_заказовBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(523, 340);
            this.MinimumSize = new System.Drawing.Size(523, 340);
            this.Name = "Spravochniky_zakazov";
            this.Text = "Spravochniky_zakazov";
            this.Load += new System.EventHandler(this.Spravochniky_zakazov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.аптекаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочник_заказовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочник_заказовBindingNavigator)).EndInit();
            this.справочник_заказовBindingNavigator.ResumeLayout(false);
            this.справочник_заказовBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекаDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочник_заказовBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочник_заказовDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private АптекаDataSet аптекаDataSet;
        private System.Windows.Forms.BindingSource справочник_заказовBindingSource;
        private АптекаDataSetTableAdapters.Справочник_заказовTableAdapter справочник_заказовTableAdapter;
        private АптекаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator справочник_заказовBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton справочник_заказовBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource лекарстваBindingSource;
        private АптекаDataSetTableAdapters.ЛекарстваTableAdapter лекарстваTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private АптекаDataSet1 аптекаDataSet1;
        private System.Windows.Forms.BindingSource справочник_заказовBindingSource1;
        private АптекаDataSet1TableAdapters.Справочник_заказовTableAdapter справочник_заказовTableAdapter1;
        private АптекаDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView справочник_заказовDataGridView;
        private АптекаDataSet1TableAdapters.ЛекарстваTableAdapter лекарстваTableAdapter1;
        private System.Windows.Forms.BindingSource лекарстваBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
    }
}