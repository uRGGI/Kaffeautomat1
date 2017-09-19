namespace Database
{
    partial class Database
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Database));
            System.Windows.Forms.Label dryckens_namnLabel;
            System.Windows.Forms.Label dryckens_prisLabel;
            this.drinksDataSet = new Database.DrinksDataSet();
            this.dryckerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dryckerTableAdapter = new Database.DrinksDataSetTableAdapters.DryckerTableAdapter();
            this.tableAdapterManager = new Database.DrinksDataSetTableAdapters.TableAdapterManager();
            this.dryckerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.dryckerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dryckens_namnTextBox = new System.Windows.Forms.TextBox();
            this.dryckens_prisTextBox = new System.Windows.Forms.TextBox();
            dryckens_namnLabel = new System.Windows.Forms.Label();
            dryckens_prisLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drinksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dryckerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dryckerBindingNavigator)).BeginInit();
            this.dryckerBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // drinksDataSet
            // 
            this.drinksDataSet.DataSetName = "DrinksDataSet";
            this.drinksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dryckerBindingSource
            // 
            this.dryckerBindingSource.DataMember = "Drycker";
            this.dryckerBindingSource.DataSource = this.drinksDataSet;
            // 
            // dryckerTableAdapter
            // 
            this.dryckerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DryckerTableAdapter = this.dryckerTableAdapter;
            this.tableAdapterManager.UpdateOrder = Database.DrinksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dryckerBindingNavigator
            // 
            this.dryckerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dryckerBindingNavigator.BindingSource = this.dryckerBindingSource;
            this.dryckerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dryckerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dryckerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dryckerBindingNavigatorSaveItem});
            this.dryckerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dryckerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dryckerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dryckerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dryckerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dryckerBindingNavigator.Name = "dryckerBindingNavigator";
            this.dryckerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dryckerBindingNavigator.Size = new System.Drawing.Size(511, 25);
            this.dryckerBindingNavigator.TabIndex = 0;
            this.dryckerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // dryckerBindingNavigatorSaveItem
            // 
            this.dryckerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dryckerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dryckerBindingNavigatorSaveItem.Image")));
            this.dryckerBindingNavigatorSaveItem.Name = "dryckerBindingNavigatorSaveItem";
            this.dryckerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.dryckerBindingNavigatorSaveItem.Text = "Save Data";
            this.dryckerBindingNavigatorSaveItem.Click += new System.EventHandler(this.dryckerBindingNavigatorSaveItem_Click);
            // 
            // dryckens_namnLabel
            // 
            dryckens_namnLabel.AutoSize = true;
            dryckens_namnLabel.Location = new System.Drawing.Point(31, 50);
            dryckens_namnLabel.Name = "dryckens_namnLabel";
            dryckens_namnLabel.Size = new System.Drawing.Size(84, 13);
            dryckens_namnLabel.TabIndex = 1;
            dryckens_namnLabel.Text = "Dryckens namn:";
            // 
            // dryckens_namnTextBox
            // 
            this.dryckens_namnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dryckerBindingSource, "Dryckens namn", true));
            this.dryckens_namnTextBox.Location = new System.Drawing.Point(121, 47);
            this.dryckens_namnTextBox.Name = "dryckens_namnTextBox";
            this.dryckens_namnTextBox.Size = new System.Drawing.Size(100, 20);
            this.dryckens_namnTextBox.TabIndex = 2;
            // 
            // dryckens_prisLabel
            // 
            dryckens_prisLabel.AutoSize = true;
            dryckens_prisLabel.Location = new System.Drawing.Point(31, 76);
            dryckens_prisLabel.Name = "dryckens_prisLabel";
            dryckens_prisLabel.Size = new System.Drawing.Size(74, 13);
            dryckens_prisLabel.TabIndex = 3;
            dryckens_prisLabel.Text = "Dryckens pris:";
            // 
            // dryckens_prisTextBox
            // 
            this.dryckens_prisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dryckerBindingSource, "Dryckens pris", true));
            this.dryckens_prisTextBox.Location = new System.Drawing.Point(121, 73);
            this.dryckens_prisTextBox.Name = "dryckens_prisTextBox";
            this.dryckens_prisTextBox.Size = new System.Drawing.Size(100, 20);
            this.dryckens_prisTextBox.TabIndex = 4;
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 402);
            this.Controls.Add(dryckens_namnLabel);
            this.Controls.Add(this.dryckens_namnTextBox);
            this.Controls.Add(dryckens_prisLabel);
            this.Controls.Add(this.dryckens_prisTextBox);
            this.Controls.Add(this.dryckerBindingNavigator);
            this.Name = "Database";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Database_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drinksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dryckerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dryckerBindingNavigator)).EndInit();
            this.dryckerBindingNavigator.ResumeLayout(false);
            this.dryckerBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database.DrinksDataSet drinksDataSet;
        private System.Windows.Forms.BindingSource dryckerBindingSource;
        private Database.DrinksDataSetTableAdapters.DryckerTableAdapter dryckerTableAdapter;
        private Database.DrinksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dryckerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dryckerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox dryckens_namnTextBox;
        private System.Windows.Forms.TextBox dryckens_prisTextBox;
    }
}

