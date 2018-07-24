namespace TodoList01
{
    partial class Form4
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
            this.dataGridViewAchieved = new System.Windows.Forms.DataGridView();
            this.achievedDataSet = new TodoList01.achievedDataSet();
            this.atodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atodoTableAdapter = new TodoList01.achievedDataSetTableAdapters.atodoTableAdapter();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acvDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAchieved)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.achievedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atodoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAchieved
            // 
            this.dataGridViewAchieved.AutoGenerateColumns = false;
            this.dataGridViewAchieved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAchieved.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.listDataGridViewTextBoxColumn,
            this.prmDataGridViewTextBoxColumn,
            this.acvDateDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
            this.dataGridViewAchieved.DataSource = this.atodoBindingSource;
            this.dataGridViewAchieved.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAchieved.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAchieved.Name = "dataGridViewAchieved";
            this.dataGridViewAchieved.RowTemplate.Height = 21;
            this.dataGridViewAchieved.Size = new System.Drawing.Size(642, 366);
            this.dataGridViewAchieved.TabIndex = 0;
            // 
            // achievedDataSet
            // 
            this.achievedDataSet.DataSetName = "achievedDataSet";
            this.achievedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // atodoBindingSource
            // 
            this.atodoBindingSource.DataMember = "atodo";
            this.atodoBindingSource.DataSource = this.achievedDataSet;
            // 
            // atodoTableAdapter
            // 
            this.atodoTableAdapter.ClearBeforeFill = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // listDataGridViewTextBoxColumn
            // 
            this.listDataGridViewTextBoxColumn.DataPropertyName = "list";
            this.listDataGridViewTextBoxColumn.HeaderText = "list";
            this.listDataGridViewTextBoxColumn.Name = "listDataGridViewTextBoxColumn";
            // 
            // prmDataGridViewTextBoxColumn
            // 
            this.prmDataGridViewTextBoxColumn.DataPropertyName = "Prm";
            this.prmDataGridViewTextBoxColumn.HeaderText = "Prm";
            this.prmDataGridViewTextBoxColumn.Name = "prmDataGridViewTextBoxColumn";
            // 
            // acvDateDataGridViewTextBoxColumn
            // 
            this.acvDateDataGridViewTextBoxColumn.DataPropertyName = "acvDate";
            this.acvDateDataGridViewTextBoxColumn.HeaderText = "acvDate";
            this.acvDateDataGridViewTextBoxColumn.Name = "acvDateDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 366);
            this.Controls.Add(this.dataGridViewAchieved);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAchieved)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.achievedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atodoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAchieved;
        private achievedDataSet achievedDataSet;
        private System.Windows.Forms.BindingSource atodoBindingSource;
        private achievedDataSetTableAdapters.atodoTableAdapter atodoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acvDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
    }
}