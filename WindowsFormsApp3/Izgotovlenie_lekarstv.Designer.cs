namespace WindowsFormsApp3
{
    partial class Izgotovlenie_lekarstv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Izgotovlenie_lekarstv));
            this.аптекаDataSet1 = new WindowsFormsApp3.АптекаDataSet1();
            this.изготовление_лекарствBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.изготовление_лекарствTableAdapter = new WindowsFormsApp3.АптекаDataSet1TableAdapters.Изготовление_лекарствTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.АптекаDataSet1TableAdapters.TableAdapterManager();
            this.технологииTableAdapter = new WindowsFormsApp3.АптекаDataSet1TableAdapters.ТехнологииTableAdapter();
            this.фильтрация_лекарствTableAdapter = new WindowsFormsApp3.АптекаDataSet1TableAdapters.Фильтрация_лекарствTableAdapter();
            this.изготовление_лекарствBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.изготовление_лекарствBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.изготовление_лекарствDataGridView = new System.Windows.Forms.DataGridView();
            this.фильтрацияЛекарствBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.технологииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.аптекаDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.изготовление_лекарствBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.изготовление_лекарствBindingNavigator)).BeginInit();
            this.изготовление_лекарствBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.изготовление_лекарствDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильтрацияЛекарствBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.технологииBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // аптекаDataSet1
            // 
            this.аптекаDataSet1.DataSetName = "АптекаDataSet1";
            this.аптекаDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // изготовление_лекарствBindingSource
            // 
            this.изготовление_лекарствBindingSource.DataMember = "Изготовление лекарств";
            this.изготовление_лекарствBindingSource.DataSource = this.аптекаDataSet1;
            // 
            // изготовление_лекарствTableAdapter
            // 
            this.изготовление_лекарствTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3.АптекаDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Вид_диагнозаTableAdapter = null;
            this.tableAdapterManager.ВрачTableAdapter = null;
            this.tableAdapterManager.Выдача_лекарстваTableAdapter = null;
            this.tableAdapterManager.ДиагнозTableAdapter = null;
            this.tableAdapterManager.Заказы_лекарствTableAdapter = null;
            this.tableAdapterManager.ЗаявкаTableAdapter = null;
            this.tableAdapterManager.Изготовление_лекарствTableAdapter = this.изготовление_лекарствTableAdapter;
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
            this.tableAdapterManager.Статистика_МедикаментовTableAdapter = null;
            this.tableAdapterManager.ТехнологииTableAdapter = this.технологииTableAdapter;
            this.tableAdapterManager.Тип_лекарстваTableAdapter = null;
            this.tableAdapterManager.Условия_храненияTableAdapter = null;
            this.tableAdapterManager.Фильтрация_лекарствTableAdapter = this.фильтрация_лекарствTableAdapter;
            // 
            // технологииTableAdapter
            // 
            this.технологииTableAdapter.ClearBeforeFill = true;
            // 
            // фильтрация_лекарствTableAdapter
            // 
            this.фильтрация_лекарствTableAdapter.ClearBeforeFill = true;
            // 
            // изготовление_лекарствBindingNavigator
            // 
            this.изготовление_лекарствBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.изготовление_лекарствBindingNavigator.BindingSource = this.изготовление_лекарствBindingSource;
            this.изготовление_лекарствBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.изготовление_лекарствBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.изготовление_лекарствBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.изготовление_лекарствBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.изготовление_лекарствBindingNavigatorSaveItem});
            this.изготовление_лекарствBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.изготовление_лекарствBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.изготовление_лекарствBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.изготовление_лекарствBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.изготовление_лекарствBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.изготовление_лекарствBindingNavigator.Name = "изготовление_лекарствBindingNavigator";
            this.изготовление_лекарствBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.изготовление_лекарствBindingNavigator.Size = new System.Drawing.Size(729, 27);
            this.изготовление_лекарствBindingNavigator.TabIndex = 0;
            this.изготовление_лекарствBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
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
            // изготовление_лекарствBindingNavigatorSaveItem
            // 
            this.изготовление_лекарствBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.изготовление_лекарствBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("изготовление_лекарствBindingNavigatorSaveItem.Image")));
            this.изготовление_лекарствBindingNavigatorSaveItem.Name = "изготовление_лекарствBindingNavigatorSaveItem";
            this.изготовление_лекарствBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.изготовление_лекарствBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.изготовление_лекарствBindingNavigatorSaveItem.Click += new System.EventHandler(this.изготовление_лекарствBindingNavigatorSaveItem_Click);
            // 
            // изготовление_лекарствDataGridView
            // 
            this.изготовление_лекарствDataGridView.AutoGenerateColumns = false;
            this.изготовление_лекарствDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.изготовление_лекарствDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.изготовление_лекарствDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.изготовление_лекарствDataGridView.DataSource = this.изготовление_лекарствBindingSource;
            this.изготовление_лекарствDataGridView.Location = new System.Drawing.Point(0, 26);
            this.изготовление_лекарствDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.изготовление_лекарствDataGridView.Name = "изготовление_лекарствDataGridView";
            this.изготовление_лекарствDataGridView.RowTemplate.Height = 24;
            this.изготовление_лекарствDataGridView.Size = new System.Drawing.Size(464, 338);
            this.изготовление_лекарствDataGridView.TabIndex = 1;
            // 
            // фильтрацияЛекарствBindingSource
            // 
            this.фильтрацияЛекарствBindingSource.DataMember = "Фильтрация лекарств";
            this.фильтрацияЛекарствBindingSource.DataSource = this.аптекаDataSet1;
            // 
            // технологииBindingSource
            // 
            this.технологииBindingSource.DataMember = "Технологии";
            this.технологииBindingSource.DataSource = this.аптекаDataSet1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(541, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Изготовление";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.изготовление_лекарствBindingSource, "Изготовление", true));
            this.textBox1.Location = new System.Drawing.Point(515, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 26;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(589, 309);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 49);
            this.button5.TabIndex = 25;
            this.button5.Text = "СОХРАНИТЬ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(589, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 49);
            this.button4.TabIndex = 24;
            this.button4.Text = "УДАЛИТЬ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(589, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 49);
            this.button3.TabIndex = 23;
            this.button3.Text = "ДОБАВИТЬ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(481, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 71);
            this.button2.TabIndex = 22;
            this.button2.Text = "DOWN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(481, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 68);
            this.button1.TabIndex = 21;
            this.button1.Text = "UP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Фильтр";
            this.dataGridViewTextBoxColumn2.DataSource = this.фильтрацияЛекарствBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Время изготовления";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фильтр";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "Код";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Изготовление";
            this.dataGridViewTextBoxColumn3.HeaderText = "Изготовление";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
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
            // Izgotovlenie_lekarstv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(729, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.изготовление_лекарствDataGridView);
            this.Controls.Add(this.изготовление_лекарствBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(745, 405);
            this.MinimumSize = new System.Drawing.Size(745, 405);
            this.Name = "Izgotovlenie_lekarstv";
            this.Text = "Izgotovlenie_lekarstv";
            this.Load += new System.EventHandler(this.Izgotovlenie_lekarstv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.аптекаDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.изготовление_лекарствBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.изготовление_лекарствBindingNavigator)).EndInit();
            this.изготовление_лекарствBindingNavigator.ResumeLayout(false);
            this.изготовление_лекарствBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.изготовление_лекарствDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильтрацияЛекарствBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.технологииBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private АптекаDataSet1 аптекаDataSet1;
        private System.Windows.Forms.BindingSource изготовление_лекарствBindingSource;
        private АптекаDataSet1TableAdapters.Изготовление_лекарствTableAdapter изготовление_лекарствTableAdapter;
        private АптекаDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator изготовление_лекарствBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton изготовление_лекарствBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView изготовление_лекарствDataGridView;
        private АптекаDataSet1TableAdapters.Фильтрация_лекарствTableAdapter фильтрация_лекарствTableAdapter;
        private System.Windows.Forms.BindingSource фильтрацияЛекарствBindingSource;
        private АптекаDataSet1TableAdapters.ТехнологииTableAdapter технологииTableAdapter;
        private System.Windows.Forms.BindingSource технологииBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
    }
}