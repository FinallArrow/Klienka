﻿namespace WindowsFormsApp3
{
    partial class Diagnoz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diagnoz));
            this.аптекаDataSet = new WindowsFormsApp3.АптекаDataSet();
            this.диагнозBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.диагнозTableAdapter = new WindowsFormsApp3.АптекаDataSetTableAdapters.ДиагнозTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.АптекаDataSetTableAdapters.TableAdapterManager();
            this.диагнозBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.диагнозBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.диагнозBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.аптекаDataSet1 = new WindowsFormsApp3.АптекаDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.диагнозTableAdapter1 = new WindowsFormsApp3.АптекаDataSet1TableAdapters.ДиагнозTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApp3.АптекаDataSet1TableAdapters.TableAdapterManager();
            this.диагнозDataGridView = new System.Windows.Forms.DataGridView();
            this.видДиагнозаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.вид_диагнозаTableAdapter = new WindowsFormsApp3.АптекаDataSet1TableAdapters.Вид_диагнозаTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.аптекаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.диагнозBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.диагнозBindingNavigator)).BeginInit();
            this.диагнозBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.диагнозBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекаDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.диагнозDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видДиагнозаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // аптекаDataSet
            // 
            this.аптекаDataSet.DataSetName = "АптекаDataSet";
            this.аптекаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // диагнозBindingSource
            // 
            this.диагнозBindingSource.DataMember = "Диагноз";
            this.диагнозBindingSource.DataSource = this.аптекаDataSet;
            // 
            // диагнозTableAdapter
            // 
            this.диагнозTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3.АптекаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Вид_диагнозаTableAdapter = null;
            this.tableAdapterManager.ВрачTableAdapter = null;
            this.tableAdapterManager.Выдача_лекарстваTableAdapter = null;
            this.tableAdapterManager.ДиагнозTableAdapter = this.диагнозTableAdapter;
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
            this.tableAdapterManager.Статистика_МедикаментовTableAdapter = null;
            this.tableAdapterManager.ТехнологииTableAdapter = null;
            this.tableAdapterManager.Тип_лекарстваTableAdapter = null;
            this.tableAdapterManager.Условия_храненияTableAdapter = null;
            this.tableAdapterManager.Фильтрация_лекарствTableAdapter = null;
            // 
            // диагнозBindingNavigator
            // 
            this.диагнозBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.диагнозBindingNavigator.BindingSource = this.диагнозBindingSource;
            this.диагнозBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.диагнозBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.диагнозBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.диагнозBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.диагнозBindingNavigatorSaveItem});
            this.диагнозBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.диагнозBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.диагнозBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.диагнозBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.диагнозBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.диагнозBindingNavigator.Name = "диагнозBindingNavigator";
            this.диагнозBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.диагнозBindingNavigator.Size = new System.Drawing.Size(627, 27);
            this.диагнозBindingNavigator.TabIndex = 0;
            this.диагнозBindingNavigator.Text = "bindingNavigator1";
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
            // диагнозBindingNavigatorSaveItem
            // 
            this.диагнозBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.диагнозBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("диагнозBindingNavigatorSaveItem.Image")));
            this.диагнозBindingNavigatorSaveItem.Name = "диагнозBindingNavigatorSaveItem";
            this.диагнозBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.диагнозBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.диагнозBindingNavigatorSaveItem.Click += new System.EventHandler(this.диагнозBindingNavigatorSaveItem_Click1);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(497, 264);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 49);
            this.button5.TabIndex = 13;
            this.button5.Text = "СОХРАНИТЬ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(497, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 49);
            this.button4.TabIndex = 12;
            this.button4.Text = "УДАЛИТЬ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(497, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 49);
            this.button3.TabIndex = 11;
            this.button3.Text = "ДОБАВИТЬ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(371, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 71);
            this.button2.TabIndex = 10;
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
            this.button1.Location = new System.Drawing.Point(371, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 68);
            this.button1.TabIndex = 9;
            this.button1.Text = "UP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.диагнозBindingSource1, "Название", true));
            this.textBox1.Location = new System.Drawing.Point(401, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 14;
            // 
            // диагнозBindingSource1
            // 
            this.диагнозBindingSource1.DataMember = "Диагноз";
            this.диагнозBindingSource1.DataSource = this.аптекаDataSet1;
            // 
            // аптекаDataSet1
            // 
            this.аптекаDataSet1.DataSetName = "АптекаDataSet1";
            this.аптекаDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(434, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Название";
            // 
            // диагнозTableAdapter1
            // 
            this.диагнозTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp3.АптекаDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.Вид_диагнозаTableAdapter = null;
            this.tableAdapterManager1.ВрачTableAdapter = null;
            this.tableAdapterManager1.Выдача_лекарстваTableAdapter = null;
            this.tableAdapterManager1.ДиагнозTableAdapter = this.диагнозTableAdapter1;
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
            this.tableAdapterManager1.Статистика_МедикаментовTableAdapter = null;
            this.tableAdapterManager1.ТехнологииTableAdapter = null;
            this.tableAdapterManager1.Тип_лекарстваTableAdapter = null;
            this.tableAdapterManager1.Условия_храненияTableAdapter = null;
            this.tableAdapterManager1.Фильтрация_лекарствTableAdapter = null;
            // 
            // диагнозDataGridView
            // 
            this.диагнозDataGridView.AutoGenerateColumns = false;
            this.диагнозDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.диагнозDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.диагнозDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.диагнозDataGridView.DataSource = this.диагнозBindingSource1;
            this.диагнозDataGridView.Location = new System.Drawing.Point(0, 29);
            this.диагнозDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.диагнозDataGridView.Name = "диагнозDataGridView";
            this.диагнозDataGridView.RowTemplate.Height = 24;
            this.диагнозDataGridView.Size = new System.Drawing.Size(366, 306);
            this.диагнозDataGridView.TabIndex = 15;
            this.диагнозDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.диагнозDataGridView_CellContentClick);
            // 
            // видДиагнозаBindingSource
            // 
            this.видДиагнозаBindingSource.DataMember = "Вид диагноза";
            this.видДиагнозаBindingSource.DataSource = this.аптекаDataSet1;
            // 
            // вид_диагнозаTableAdapter
            // 
            this.вид_диагнозаTableAdapter.ClearBeforeFill = true;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Вид Диагноза";
            this.dataGridViewTextBoxColumn3.DataSource = this.видДиагнозаBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Вид";
            this.dataGridViewTextBoxColumn3.HeaderText = "Вид Диагноза";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "Код";
            // 
            // Diagnoz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(627, 335);
            this.Controls.Add(this.диагнозDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.диагнозBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(643, 374);
            this.MinimumSize = new System.Drawing.Size(643, 374);
            this.Name = "Diagnoz";
            this.Text = "Diagnoz";
            this.Load += new System.EventHandler(this.Diagnoz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.аптекаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.диагнозBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.диагнозBindingNavigator)).EndInit();
            this.диагнозBindingNavigator.ResumeLayout(false);
            this.диагнозBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.диагнозBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекаDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.диагнозDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видДиагнозаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private АптекаDataSet аптекаDataSet;
        private System.Windows.Forms.BindingSource диагнозBindingSource;
        private АптекаDataSetTableAdapters.ДиагнозTableAdapter диагнозTableAdapter;
        private АптекаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator диагнозBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton диагнозBindingNavigatorSaveItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private АптекаDataSet1 аптекаDataSet1;
        private System.Windows.Forms.BindingSource диагнозBindingSource1;
        private АптекаDataSet1TableAdapters.ДиагнозTableAdapter диагнозTableAdapter1;
        private АптекаDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView диагнозDataGridView;
        private System.Windows.Forms.BindingSource видДиагнозаBindingSource;
        private АптекаDataSet1TableAdapters.Вид_диагнозаTableAdapter вид_диагнозаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
    }
}