namespace TODOList
{
    partial class Form1
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
            this.btnSignUp = new System.Windows.Forms.Button();
            this.toDoItemList = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadlineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDoItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toDoItems = new TODOList.ToDoItems();
            this.toDoItemsTableAdapter = new TODOList.ToDoItemsTableAdapters.ToDoItemsTableAdapter();
            this.newItembtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteItemBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.toDoItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(520, 37);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 23);
            this.btnSignUp.TabIndex = 9;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // toDoItemList
            // 
            this.toDoItemList.AllowUserToAddRows = false;
            this.toDoItemList.AllowUserToDeleteRows = false;
            this.toDoItemList.AllowUserToResizeColumns = false;
            this.toDoItemList.AllowUserToResizeRows = false;
            this.toDoItemList.AutoGenerateColumns = false;
            this.toDoItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toDoItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.textDataGridViewTextBoxColumn,
            this.deadlineDataGridViewTextBoxColumn});
            this.toDoItemList.DataSource = this.toDoItemsBindingSource;
            this.toDoItemList.Location = new System.Drawing.Point(59, 47);
            this.toDoItemList.MultiSelect = false;
            this.toDoItemList.Name = "toDoItemList";
            this.toDoItemList.ReadOnly = true;
            this.toDoItemList.RowHeadersVisible = false;
            this.toDoItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.toDoItemList.Size = new System.Drawing.Size(435, 150);
            this.toDoItemList.TabIndex = 10;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Text";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deadlineDataGridViewTextBoxColumn
            // 
            this.deadlineDataGridViewTextBoxColumn.DataPropertyName = "Deadline";
            this.deadlineDataGridViewTextBoxColumn.HeaderText = "Deadline";
            this.deadlineDataGridViewTextBoxColumn.Name = "deadlineDataGridViewTextBoxColumn";
            this.deadlineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toDoItemsBindingSource
            // 
            this.toDoItemsBindingSource.DataMember = "ToDoItems";
            this.toDoItemsBindingSource.DataSource = this.toDoItems;
            // 
            // toDoItems
            // 
            this.toDoItems.DataSetName = "ToDoItems";
            this.toDoItems.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toDoItemsTableAdapter
            // 
            this.toDoItemsTableAdapter.ClearBeforeFill = true;
            // 
            // newItembtn
            // 
            this.newItembtn.Location = new System.Drawing.Point(388, 325);
            this.newItembtn.Name = "newItembtn";
            this.newItembtn.Size = new System.Drawing.Size(106, 39);
            this.newItembtn.TabIndex = 11;
            this.newItembtn.Text = "Add New Item";
            this.newItembtn.UseVisualStyleBackColor = true;
            this.newItembtn.Click += new System.EventHandler(this.newItembtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 39);
            this.button1.TabIndex = 12;
            this.button1.Text = "Open Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteItemBtn
            // 
            this.deleteItemBtn.Location = new System.Drawing.Point(164, 325);
            this.deleteItemBtn.Name = "deleteItemBtn";
            this.deleteItemBtn.Size = new System.Drawing.Size(106, 39);
            this.deleteItemBtn.TabIndex = 13;
            this.deleteItemBtn.Text = "Delete Item";
            this.deleteItemBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.deleteItemBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newItembtn);
            this.Controls.Add(this.toDoItemList);
            this.Controls.Add(this.btnSignUp);
            this.Name = "Form1";
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toDoItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.DataGridView toDoItemList;
        private ToDoItems toDoItems;
        private System.Windows.Forms.BindingSource toDoItemsBindingSource;
        private ToDoItemsTableAdapters.ToDoItemsTableAdapter toDoItemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadlineDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button newItembtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button deleteItemBtn;
    }
}

