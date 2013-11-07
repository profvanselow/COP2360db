namespace WindowsFormsApplication3
{
    partial class FormDetails
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
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label payment_DateLabel;
            System.Windows.Forms.Label amountLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetails));
            this.karateDataSet = new WindowsFormsApplication3.KarateDataSet();
            this.paymentsWithNamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsWithNamesTableAdapter = new WindowsFormsApplication3.KarateDataSetTableAdapters.PaymentsWithNamesTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication3.KarateDataSetTableAdapters.TableAdapterManager();
            this.paymentsWithNamesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.paymentsWithNamesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.payment_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            payment_DateLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.karateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsWithNamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsWithNamesBindingNavigator)).BeginInit();
            this.paymentsWithNamesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(16, 92);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 13);
            first_NameLabel.TabIndex = 1;
            first_NameLabel.Text = "First Name:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(16, 118);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(61, 13);
            last_NameLabel.TabIndex = 3;
            last_NameLabel.Text = "Last Name:";
            // 
            // payment_DateLabel
            // 
            payment_DateLabel.AutoSize = true;
            payment_DateLabel.Location = new System.Drawing.Point(16, 145);
            payment_DateLabel.Name = "payment_DateLabel";
            payment_DateLabel.Size = new System.Drawing.Size(77, 13);
            payment_DateLabel.TabIndex = 5;
            payment_DateLabel.Text = "Payment Date:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(16, 170);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(46, 13);
            amountLabel.TabIndex = 7;
            amountLabel.Text = "Amount:";
            // 
            // karateDataSet
            // 
            this.karateDataSet.DataSetName = "KarateDataSet";
            this.karateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentsWithNamesBindingSource
            // 
            this.paymentsWithNamesBindingSource.DataMember = "PaymentsWithNames";
            this.paymentsWithNamesBindingSource.DataSource = this.karateDataSet;
            // 
            // paymentsWithNamesTableAdapter
            // 
            this.paymentsWithNamesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DaysTableAdapter = null;
            this.tableAdapterManager.InstructorsTableAdapter = null;
            this.tableAdapterManager.MembersTableAdapter = null;
            this.tableAdapterManager.PaymentsTableAdapter = null;
            this.tableAdapterManager.ScheduleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication3.KarateDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // paymentsWithNamesBindingNavigator
            // 
            this.paymentsWithNamesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.paymentsWithNamesBindingNavigator.BindingSource = this.paymentsWithNamesBindingSource;
            this.paymentsWithNamesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.paymentsWithNamesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.paymentsWithNamesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.paymentsWithNamesBindingNavigatorSaveItem});
            this.paymentsWithNamesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.paymentsWithNamesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.paymentsWithNamesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.paymentsWithNamesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.paymentsWithNamesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.paymentsWithNamesBindingNavigator.Name = "paymentsWithNamesBindingNavigator";
            this.paymentsWithNamesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.paymentsWithNamesBindingNavigator.Size = new System.Drawing.Size(319, 25);
            this.paymentsWithNamesBindingNavigator.TabIndex = 0;
            this.paymentsWithNamesBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // paymentsWithNamesBindingNavigatorSaveItem
            // 
            this.paymentsWithNamesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.paymentsWithNamesBindingNavigatorSaveItem.Enabled = false;
            this.paymentsWithNamesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("paymentsWithNamesBindingNavigatorSaveItem.Image")));
            this.paymentsWithNamesBindingNavigatorSaveItem.Name = "paymentsWithNamesBindingNavigatorSaveItem";
            this.paymentsWithNamesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.paymentsWithNamesBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentsWithNamesBindingSource, "First_Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(99, 89);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(200, 20);
            this.first_NameTextBox.TabIndex = 2;
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentsWithNamesBindingSource, "Last_Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(99, 115);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(200, 20);
            this.last_NameTextBox.TabIndex = 4;
            // 
            // payment_DateDateTimePicker
            // 
            this.payment_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.paymentsWithNamesBindingSource, "Payment_Date", true));
            this.payment_DateDateTimePicker.Location = new System.Drawing.Point(99, 141);
            this.payment_DateDateTimePicker.Name = "payment_DateDateTimePicker";
            this.payment_DateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.payment_DateDateTimePicker.TabIndex = 6;
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentsWithNamesBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(99, 167);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(200, 20);
            this.amountTextBox.TabIndex = 8;
            // 
            // FormDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 261);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(last_NameLabel);
            this.Controls.Add(this.last_NameTextBox);
            this.Controls.Add(payment_DateLabel);
            this.Controls.Add(this.payment_DateDateTimePicker);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.paymentsWithNamesBindingNavigator);
            this.Name = "FormDetails";
            this.Text = "Details Form";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.karateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsWithNamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsWithNamesBindingNavigator)).EndInit();
            this.paymentsWithNamesBindingNavigator.ResumeLayout(false);
            this.paymentsWithNamesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KarateDataSet karateDataSet;
        private System.Windows.Forms.BindingSource paymentsWithNamesBindingSource;
        private KarateDataSetTableAdapters.PaymentsWithNamesTableAdapter paymentsWithNamesTableAdapter;
        private KarateDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator paymentsWithNamesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton paymentsWithNamesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.DateTimePicker payment_DateDateTimePicker;
        private System.Windows.Forms.TextBox amountTextBox;
    }
}