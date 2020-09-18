namespace Klientka
{
    partial class Изделия
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Изделия));
            this.automobPredpDataSet = new Klientka.AutomobPredpDataSet();
            this.изделияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.изделияTableAdapter = new Klientka.AutomobPredpDataSetTableAdapters.ИзделияTableAdapter();
            this.tableAdapterManager = new Klientka.AutomobPredpDataSetTableAdapters.TableAdapterManager();
            this.изделияBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.изделияBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.изделияDataGridView = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.испытательныеЛабораторииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.испытательные_лабораторииTableAdapter = new Klientka.AutomobPredpDataSetTableAdapters.Испытательные_лабораторииTableAdapter();
            this.работыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.работыTableAdapter = new Klientka.AutomobPredpDataSetTableAdapters.РаботыTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.automobPredpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.изделияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.изделияBindingNavigator)).BeginInit();
            this.изделияBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.изделияDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.испытательныеЛабораторииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.работыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // automobPredpDataSet
            // 
            this.automobPredpDataSet.DataSetName = "AutomobPredpDataSet";
            this.automobPredpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // изделияBindingSource
            // 
            this.изделияBindingSource.DataMember = "Изделия";
            this.изделияBindingSource.DataSource = this.automobPredpDataSet;
            // 
            // изделияTableAdapter
            // 
            this.изделияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Klientka.AutomobPredpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БригадыTableAdapter = null;
            this.tableAdapterManager.ДолжностьTableAdapter = null;
            this.tableAdapterManager.ИзделияTableAdapter = this.изделияTableAdapter;
            this.tableAdapterManager.Инженерно_технический_персоналTableAdapter = null;
            this.tableAdapterManager.ИспытанияTableAdapter = null;
            this.tableAdapterManager.Испытательные_лабораторииTableAdapter = null;
            this.tableAdapterManager.Категории_изделияTableAdapter = null;
            this.tableAdapterManager.Назначение_в_бригадуTableAdapter = null;
            this.tableAdapterManager.ОборудованиеTableAdapter = null;
            this.tableAdapterManager.ОтделTableAdapter = null;
            this.tableAdapterManager.ПоставкаTableAdapter = null;
            this.tableAdapterManager.ПоставщикTableAdapter = null;
            this.tableAdapterManager.Приём_на_работуTableAdapter = null;
            this.tableAdapterManager.ПродажаTableAdapter = null;
            this.tableAdapterManager.РаботникиTableAdapter = null;
            this.tableAdapterManager.РаботыTableAdapter = null;
            this.tableAdapterManager.СкладTableAdapter = null;
            this.tableAdapterManager.Тип_изделияTableAdapter = null;
            this.tableAdapterManager.УчасткиTableAdapter = null;
            this.tableAdapterManager.ЦехаTableAdapter = null;
            // 
            // изделияBindingNavigator
            // 
            this.изделияBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.изделияBindingNavigator.BindingSource = this.изделияBindingSource;
            this.изделияBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.изделияBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.изделияBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.изделияBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.изделияBindingNavigatorSaveItem});
            this.изделияBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.изделияBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.изделияBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.изделияBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.изделияBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.изделияBindingNavigator.Name = "изделияBindingNavigator";
            this.изделияBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.изделияBindingNavigator.Size = new System.Drawing.Size(938, 27);
            this.изделияBindingNavigator.TabIndex = 0;
            this.изделияBindingNavigator.Text = "bindingNavigator1";
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
            // изделияBindingNavigatorSaveItem
            // 
            this.изделияBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.изделияBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("изделияBindingNavigatorSaveItem.Image")));
            this.изделияBindingNavigatorSaveItem.Name = "изделияBindingNavigatorSaveItem";
            this.изделияBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.изделияBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.изделияBindingNavigatorSaveItem.Click += new System.EventHandler(this.изделияBindingNavigatorSaveItem_Click);
            // 
            // изделияDataGridView
            // 
            this.изделияDataGridView.AutoGenerateColumns = false;
            this.изделияDataGridView.BackgroundColor = System.Drawing.Color.Gold;
            this.изделияDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.изделияDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.изделияDataGridView.DataSource = this.изделияBindingSource;
            this.изделияDataGridView.GridColor = System.Drawing.Color.Red;
            this.изделияDataGridView.Location = new System.Drawing.Point(66, 207);
            this.изделияDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.изделияDataGridView.Name = "изделияDataGridView";
            this.изделияDataGridView.RowTemplate.Height = 24;
            this.изделияDataGridView.Size = new System.Drawing.Size(580, 179);
            this.изделияDataGridView.TabIndex = 1;
            this.изделияDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.ИзделияDataGridView_DataError);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Purple;
            this.button5.ForeColor = System.Drawing.Color.Lime;
            this.button5.Location = new System.Drawing.Point(799, 82);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 41);
            this.button5.TabIndex = 11;
            this.button5.Text = "Промотать вверх";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Purple;
            this.button4.ForeColor = System.Drawing.Color.Lime;
            this.button4.Location = new System.Drawing.Point(604, 82);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 41);
            this.button4.TabIndex = 10;
            this.button4.Text = "Промотать вниз";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Purple;
            this.button3.ForeColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(415, 82);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 41);
            this.button3.TabIndex = 9;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.ForeColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(232, 82);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(56, 82);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // испытательныеЛабораторииBindingSource
            // 
            this.испытательныеЛабораторииBindingSource.DataMember = "Испытательные лаборатории";
            this.испытательныеЛабораторииBindingSource.DataSource = this.automobPredpDataSet;
            // 
            // испытательные_лабораторииTableAdapter
            // 
            this.испытательные_лабораторииTableAdapter.ClearBeforeFill = true;
            // 
            // работыBindingSource
            // 
            this.работыBindingSource.DataMember = "Работы";
            this.работыBindingSource.DataSource = this.automobPredpDataSet;
            // 
            // работыTableAdapter
            // 
            this.работыTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Изделия";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Изделия";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Испытательные_лаборатории";
            this.dataGridViewTextBoxColumn2.DataSource = this.испытательныеЛабораторииBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Испытательные_изделия";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Испытательные_лаборатории";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ID_Испытательные_лаборатории";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_Работы";
            this.dataGridViewTextBoxColumn3.DataSource = this.работыBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Тип работ";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_Работы";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "ID_Работы";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Изделия
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(938, 520);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.изделияDataGridView);
            this.Controls.Add(this.изделияBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Изделия";
            this.Text = "Изделия";
            this.Load += new System.EventHandler(this.Изделия_Load);
            ((System.ComponentModel.ISupportInitialize)(this.automobPredpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.изделияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.изделияBindingNavigator)).EndInit();
            this.изделияBindingNavigator.ResumeLayout(false);
            this.изделияBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.изделияDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.испытательныеЛабораторииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.работыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AutomobPredpDataSet automobPredpDataSet;
        private System.Windows.Forms.BindingSource изделияBindingSource;
        private AutomobPredpDataSetTableAdapters.ИзделияTableAdapter изделияTableAdapter;
        private AutomobPredpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator изделияBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton изделияBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView изделияDataGridView;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource испытательныеЛабораторииBindingSource;
        private AutomobPredpDataSetTableAdapters.Испытательные_лабораторииTableAdapter испытательные_лабораторииTableAdapter;
        private System.Windows.Forms.BindingSource работыBindingSource;
        private AutomobPredpDataSetTableAdapters.РаботыTableAdapter работыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}