namespace WindowsFormsApp3
{
    partial class Spravochnik_tehnologiy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spravochnik_tehnologiy));
            this.аптекаDataSet = new WindowsFormsApp3.АптекаDataSet();
            this.справочник_технологийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.справочник_технологийTableAdapter = new WindowsFormsApp3.АптекаDataSetTableAdapters.Справочник_технологийTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.АптекаDataSetTableAdapters.TableAdapterManager();
            this.справочник_технологийBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.справочник_технологийBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.аптекаDataSet1 = new WindowsFormsApp3.АптекаDataSet1();
            this.справочник_технологийBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.справочник_технологийTableAdapter1 = new WindowsFormsApp3.АптекаDataSet1TableAdapters.Справочник_технологийTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApp3.АптекаDataSet1TableAdapters.TableAdapterManager();
            this.способ_приготовленияTableAdapter = new WindowsFormsApp3.АптекаDataSet1TableAdapters.Способ_приготовленияTableAdapter();
            this.технологииTableAdapter = new WindowsFormsApp3.АптекаDataSet1TableAdapters.ТехнологииTableAdapter();
            this.справочник_технологийDataGridView = new System.Windows.Forms.DataGridView();
            this.способПриготовленияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.технологииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.аптекаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочник_технологийBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочник_технологийBindingNavigator)).BeginInit();
            this.справочник_технологийBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.аптекаDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочник_технологийBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочник_технологийDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.способПриготовленияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.технологииBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // аптекаDataSet
            // 
            this.аптекаDataSet.DataSetName = "АптекаDataSet";
            this.аптекаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // справочник_технологийBindingSource
            // 
            this.справочник_технологийBindingSource.DataMember = "Справочник технологий";
            this.справочник_технологийBindingSource.DataSource = this.аптекаDataSet;
            // 
            // справочник_технологийTableAdapter
            // 
            this.справочник_технологийTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Справочник_технологийTableAdapter = this.справочник_технологийTableAdapter;
            this.tableAdapterManager.Статистика_МедикаментовTableAdapter = null;
            this.tableAdapterManager.ТехнологииTableAdapter = null;
            this.tableAdapterManager.Тип_лекарстваTableAdapter = null;
            this.tableAdapterManager.Условия_храненияTableAdapter = null;
            this.tableAdapterManager.Фильтрация_лекарствTableAdapter = null;
            // 
            // справочник_технологийBindingNavigator
            // 
            this.справочник_технологийBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.справочник_технологийBindingNavigator.BindingSource = this.справочник_технологийBindingSource;
            this.справочник_технологийBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.справочник_технологийBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.справочник_технологийBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.справочник_технологийBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.справочник_технологийBindingNavigatorSaveItem});
            this.справочник_технологийBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.справочник_технологийBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.справочник_технологийBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.справочник_технологийBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.справочник_технологийBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.справочник_технологийBindingNavigator.Name = "справочник_технологийBindingNavigator";
            this.справочник_технологийBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.справочник_технологийBindingNavigator.Size = new System.Drawing.Size(717, 27);
            this.справочник_технологийBindingNavigator.TabIndex = 0;
            this.справочник_технологийBindingNavigator.Text = "bindingNavigator1";
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
            // справочник_технологийBindingNavigatorSaveItem
            // 
            this.справочник_технологийBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.справочник_технологийBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("справочник_технологийBindingNavigatorSaveItem.Image")));
            this.справочник_технологийBindingNavigatorSaveItem.Name = "справочник_технологийBindingNavigatorSaveItem";
            this.справочник_технологийBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.справочник_технологийBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.справочник_технологийBindingNavigatorSaveItem.Click += new System.EventHandler(this.справочник_технологийBindingNavigatorSaveItem_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(532, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 19);
            this.label4.TabIndex = 58;
            this.label4.Text = "Название лекарств";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.справочник_технологийBindingSource1, "Название лекарств", true));
            this.textBox4.Location = new System.Drawing.Point(532, 92);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(159, 20);
            this.textBox4.TabIndex = 57;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(608, 279);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 55);
            this.button5.TabIndex = 56;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(608, 159);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 55);
            this.button4.TabIndex = 55;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(608, 218);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 55);
            this.button3.TabIndex = 54;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(517, 250);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 67);
            this.button2.TabIndex = 53;
            this.button2.Text = "DOWN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(517, 169);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 67);
            this.button1.TabIndex = 52;
            this.button1.Text = "UP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // аптекаDataSet1
            // 
            this.аптекаDataSet1.DataSetName = "АптекаDataSet1";
            this.аптекаDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // справочник_технологийBindingSource1
            // 
            this.справочник_технологийBindingSource1.DataMember = "Справочник технологий";
            this.справочник_технологийBindingSource1.DataSource = this.аптекаDataSet1;
            // 
            // справочник_технологийTableAdapter1
            // 
            this.справочник_технологийTableAdapter1.ClearBeforeFill = true;
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
            this.tableAdapterManager1.Способ_приготовленияTableAdapter = this.способ_приготовленияTableAdapter;
            this.tableAdapterManager1.Справочник_заказовTableAdapter = null;
            this.tableAdapterManager1.Справочник_технологийTableAdapter = this.справочник_технологийTableAdapter1;
            this.tableAdapterManager1.Статистика_МедикаментовTableAdapter = null;
            this.tableAdapterManager1.ТехнологииTableAdapter = this.технологииTableAdapter;
            this.tableAdapterManager1.Тип_лекарстваTableAdapter = null;
            this.tableAdapterManager1.Условия_храненияTableAdapter = null;
            this.tableAdapterManager1.Фильтрация_лекарствTableAdapter = null;
            // 
            // способ_приготовленияTableAdapter
            // 
            this.способ_приготовленияTableAdapter.ClearBeforeFill = true;
            // 
            // технологииTableAdapter
            // 
            this.технологииTableAdapter.ClearBeforeFill = true;
            // 
            // справочник_технологийDataGridView
            // 
            this.справочник_технологийDataGridView.AutoGenerateColumns = false;
            this.справочник_технологийDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.справочник_технологийDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.справочник_технологийDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.справочник_технологийDataGridView.DataSource = this.справочник_технологийBindingSource1;
            this.справочник_технологийDataGridView.Location = new System.Drawing.Point(0, 29);
            this.справочник_технологийDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.справочник_технологийDataGridView.Name = "справочник_технологийDataGridView";
            this.справочник_технологийDataGridView.RowTemplate.Height = 24;
            this.справочник_технологийDataGridView.Size = new System.Drawing.Size(486, 310);
            this.справочник_технологийDataGridView.TabIndex = 58;
            // 
            // способПриготовленияBindingSource
            // 
            this.способПриготовленияBindingSource.DataMember = "Способ приготовления";
            this.способПриготовленияBindingSource.DataSource = this.аптекаDataSet1;
            // 
            // технологииBindingSource
            // 
            this.технологииBindingSource.DataMember = "Технологии";
            this.технологииBindingSource.DataSource = this.аптекаDataSet1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Название лекарств";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название лекарств";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Способ приготовления";
            this.dataGridViewTextBoxColumn3.DataSource = this.способПриготовленияBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Способ";
            this.dataGridViewTextBoxColumn3.HeaderText = "Способ приготовления";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "Код";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Технология";
            this.dataGridViewTextBoxColumn4.DataSource = this.технологииBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Название";
            this.dataGridViewTextBoxColumn4.HeaderText = "Технология";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "Код";
            // 
            // Spravochnik_tehnologiy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(717, 340);
            this.Controls.Add(this.справочник_технологийDataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.справочник_технологийBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(733, 379);
            this.MinimumSize = new System.Drawing.Size(733, 379);
            this.Name = "Spravochnik_tehnologiy";
            this.Text = "Spravochnik_tehnologiy";
            this.Load += new System.EventHandler(this.Spravochnik_tehnologiy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.аптекаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочник_технологийBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочник_технологийBindingNavigator)).EndInit();
            this.справочник_технологийBindingNavigator.ResumeLayout(false);
            this.справочник_технологийBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.аптекаDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочник_технологийBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочник_технологийDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.способПриготовленияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.технологииBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private АптекаDataSet аптекаDataSet;
        private System.Windows.Forms.BindingSource справочник_технологийBindingSource;
        private АптекаDataSetTableAdapters.Справочник_технологийTableAdapter справочник_технологийTableAdapter;
        private АптекаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator справочник_технологийBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton справочник_технологийBindingNavigatorSaveItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private АптекаDataSet1 аптекаDataSet1;
        private System.Windows.Forms.BindingSource справочник_технологийBindingSource1;
        private АптекаDataSet1TableAdapters.Справочник_технологийTableAdapter справочник_технологийTableAdapter1;
        private АптекаDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView справочник_технологийDataGridView;
        private АптекаDataSet1TableAdapters.Способ_приготовленияTableAdapter способ_приготовленияTableAdapter;
        private System.Windows.Forms.BindingSource способПриготовленияBindingSource;
        private АптекаDataSet1TableAdapters.ТехнологииTableAdapter технологииTableAdapter;
        private System.Windows.Forms.BindingSource технологииBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
    }
}