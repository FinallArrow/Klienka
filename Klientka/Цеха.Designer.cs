namespace Klientka
{
    partial class Цеха
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
            System.Windows.Forms.Label iD_ЦехаLabel;
            System.Windows.Forms.Label iD_ОборудованиеLabel;
            System.Windows.Forms.Label начальник_цехаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Цеха));
            this.automobPredpDataSet = new Klientka.AutomobPredpDataSet();
            this.цехаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.цехаTableAdapter = new Klientka.AutomobPredpDataSetTableAdapters.ЦехаTableAdapter();
            this.tableAdapterManager = new Klientka.AutomobPredpDataSetTableAdapters.TableAdapterManager();
            this.цехаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.цехаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.цехаDataGridView = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.iD_ЦехаTextBox = new System.Windows.Forms.TextBox();
            this.iD_ОборудованиеTextBox = new System.Windows.Forms.TextBox();
            this.начальник_цехаTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_ЦехаLabel = new System.Windows.Forms.Label();
            iD_ОборудованиеLabel = new System.Windows.Forms.Label();
            начальник_цехаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.automobPredpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.цехаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.цехаBindingNavigator)).BeginInit();
            this.цехаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.цехаDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_ЦехаLabel
            // 
            iD_ЦехаLabel.AutoSize = true;
            iD_ЦехаLabel.Location = new System.Drawing.Point(100, 466);
            iD_ЦехаLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            iD_ЦехаLabel.Name = "iD_ЦехаLabel";
            iD_ЦехаLabel.Size = new System.Drawing.Size(49, 13);
            iD_ЦехаLabel.TabIndex = 11;
            iD_ЦехаLabel.Text = "ID Цеха:";
            // 
            // iD_ОборудованиеLabel
            // 
            iD_ОборудованиеLabel.AutoSize = true;
            iD_ОборудованиеLabel.Location = new System.Drawing.Point(368, 469);
            iD_ОборудованиеLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            iD_ОборудованиеLabel.Name = "iD_ОборудованиеLabel";
            iD_ОборудованиеLabel.Size = new System.Drawing.Size(97, 13);
            iD_ОборудованиеLabel.TabIndex = 12;
            iD_ОборудованиеLabel.Text = "ID Оборудование:";
            // 
            // начальник_цехаLabel
            // 
            начальник_цехаLabel.AutoSize = true;
            начальник_цехаLabel.Location = new System.Drawing.Point(652, 469);
            начальник_цехаLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            начальник_цехаLabel.Name = "начальник_цехаLabel";
            начальник_цехаLabel.Size = new System.Drawing.Size(91, 13);
            начальник_цехаLabel.TabIndex = 13;
            начальник_цехаLabel.Text = "Начальник цеха:";
            // 
            // automobPredpDataSet
            // 
            this.automobPredpDataSet.DataSetName = "AutomobPredpDataSet";
            this.automobPredpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // цехаBindingSource
            // 
            this.цехаBindingSource.DataMember = "Цеха";
            this.цехаBindingSource.DataSource = this.automobPredpDataSet;
            // 
            // цехаTableAdapter
            // 
            this.цехаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Klientka.AutomobPredpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БригадыTableAdapter = null;
            this.tableAdapterManager.ДолжностьTableAdapter = null;
            this.tableAdapterManager.ИзделияTableAdapter = null;
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
            this.tableAdapterManager.ЦехаTableAdapter = this.цехаTableAdapter;
            // 
            // цехаBindingNavigator
            // 
            this.цехаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.цехаBindingNavigator.BindingSource = this.цехаBindingSource;
            this.цехаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.цехаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.цехаBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.цехаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.цехаBindingNavigatorSaveItem});
            this.цехаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.цехаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.цехаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.цехаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.цехаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.цехаBindingNavigator.Name = "цехаBindingNavigator";
            this.цехаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.цехаBindingNavigator.Size = new System.Drawing.Size(950, 27);
            this.цехаBindingNavigator.TabIndex = 0;
            this.цехаBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // цехаBindingNavigatorSaveItem
            // 
            this.цехаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.цехаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("цехаBindingNavigatorSaveItem.Image")));
            this.цехаBindingNavigatorSaveItem.Name = "цехаBindingNavigatorSaveItem";
            this.цехаBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.цехаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.цехаBindingNavigatorSaveItem.Click += new System.EventHandler(this.цехаBindingNavigatorSaveItem_Click);
            // 
            // цехаDataGridView
            // 
            this.цехаDataGridView.AutoGenerateColumns = false;
            this.цехаDataGridView.BackgroundColor = System.Drawing.Color.Gold;
            this.цехаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.цехаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.цехаDataGridView.DataSource = this.цехаBindingSource;
            this.цехаDataGridView.GridColor = System.Drawing.Color.Red;
            this.цехаDataGridView.Location = new System.Drawing.Point(345, 229);
            this.цехаDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.цехаDataGridView.Name = "цехаDataGridView";
            this.цехаDataGridView.RowTemplate.Height = 24;
            this.цехаDataGridView.Size = new System.Drawing.Size(335, 179);
            this.цехаDataGridView.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Purple;
            this.button5.ForeColor = System.Drawing.Color.Lime;
            this.button5.Location = new System.Drawing.Point(797, 77);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 41);
            this.button5.TabIndex = 11;
            this.button5.Text = "Промотать вверх";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Purple;
            this.button4.ForeColor = System.Drawing.Color.Lime;
            this.button4.Location = new System.Drawing.Point(602, 77);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 41);
            this.button4.TabIndex = 10;
            this.button4.Text = "Промотать вниз";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Purple;
            this.button3.ForeColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(413, 77);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 41);
            this.button3.TabIndex = 9;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.ForeColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(230, 77);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(54, 77);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // iD_ЦехаTextBox
            // 
            this.iD_ЦехаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.цехаBindingSource, "ID_Цеха", true));
            this.iD_ЦехаTextBox.Location = new System.Drawing.Point(152, 464);
            this.iD_ЦехаTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.iD_ЦехаTextBox.Name = "iD_ЦехаTextBox";
            this.iD_ЦехаTextBox.Size = new System.Drawing.Size(123, 20);
            this.iD_ЦехаTextBox.TabIndex = 12;
            // 
            // iD_ОборудованиеTextBox
            // 
            this.iD_ОборудованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.цехаBindingSource, "ID_Оборудование", true));
            this.iD_ОборудованиеTextBox.Location = new System.Drawing.Point(467, 466);
            this.iD_ОборудованиеTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.iD_ОборудованиеTextBox.Name = "iD_ОборудованиеTextBox";
            this.iD_ОборудованиеTextBox.Size = new System.Drawing.Size(116, 20);
            this.iD_ОборудованиеTextBox.TabIndex = 13;
            // 
            // начальник_цехаTextBox
            // 
            this.начальник_цехаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.цехаBindingSource, "Начальник_цеха", true));
            this.начальник_цехаTextBox.Location = new System.Drawing.Point(746, 466);
            this.начальник_цехаTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.начальник_цехаTextBox.Name = "начальник_цехаTextBox";
            this.начальник_цехаTextBox.Size = new System.Drawing.Size(131, 20);
            this.начальник_цехаTextBox.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Цеха";
            this.dataGridViewTextBoxColumn1.DataSource = this.цехаBindingSource;
            this.dataGridViewTextBoxColumn1.DisplayMember = "ID_Оборудование";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Цеха";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.ValueMember = "ID_Цеха";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Оборудование";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Оборудование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Начальник_цеха";
            this.dataGridViewTextBoxColumn3.HeaderText = "Начальник_цеха";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Цеха
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(950, 519);
            this.Controls.Add(начальник_цехаLabel);
            this.Controls.Add(this.начальник_цехаTextBox);
            this.Controls.Add(iD_ОборудованиеLabel);
            this.Controls.Add(this.iD_ОборудованиеTextBox);
            this.Controls.Add(iD_ЦехаLabel);
            this.Controls.Add(this.iD_ЦехаTextBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.цехаDataGridView);
            this.Controls.Add(this.цехаBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Цеха";
            this.Text = "Цеха";
            this.Load += new System.EventHandler(this.Цеха_Load);
            ((System.ComponentModel.ISupportInitialize)(this.automobPredpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.цехаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.цехаBindingNavigator)).EndInit();
            this.цехаBindingNavigator.ResumeLayout(false);
            this.цехаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.цехаDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AutomobPredpDataSet automobPredpDataSet;
        private System.Windows.Forms.BindingSource цехаBindingSource;
        private AutomobPredpDataSetTableAdapters.ЦехаTableAdapter цехаTableAdapter;
        private AutomobPredpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator цехаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton цехаBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView цехаDataGridView;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox iD_ЦехаTextBox;
        private System.Windows.Forms.TextBox iD_ОборудованиеTextBox;
        private System.Windows.Forms.TextBox начальник_цехаTextBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}