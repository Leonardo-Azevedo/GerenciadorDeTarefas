namespace TasksWithBD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtName = new TextBox();
            txtDescription = new TextBox();
            dtStartDate = new DateTimePicker();
            lblName = new Label();
            lblDescription = new Label();
            lblStartDate = new Label();
            btnList = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            dtgView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            CreateDate = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            FinishDate = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            label2 = new Label();
            listStatus = new ComboBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            novoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            newToolStripMenuItem = new ToolStripMenuItem();
            taskToolStripMenuItem = new ToolStripMenuItem();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(103, 46);
            txtName.Name = "txtName";
            txtName.Size = new Size(251, 23);
            txtName.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Enabled = false;
            txtDescription.Location = new Point(103, 93);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(251, 71);
            txtDescription.TabIndex = 1;
            // 
            // dtStartDate
            // 
            dtStartDate.Enabled = false;
            dtStartDate.Format = DateTimePickerFormat.Short;
            dtStartDate.Location = new Point(103, 188);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(129, 23);
            dtStartDate.TabIndex = 2;
            dtStartDate.Value = new DateTime(2025, 8, 23, 0, 0, 0, 0);
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(58, 49);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Name";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(30, 96);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(39, 194);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(58, 15);
            lblStartDate.TabIndex = 5;
            lblStartDate.Text = "Start Date";
            // 
            // btnList
            // 
            btnList.Location = new Point(433, 612);
            btnList.Name = "btnList";
            btnList.Size = new Size(75, 23);
            btnList.TabIndex = 8;
            btnList.Text = "List tasks";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(446, 250);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Enabled = false;
            btnEdit.Location = new Point(365, 250);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // dtgView
            // 
            dtgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Columns.AddRange(new DataGridViewColumn[] { Id, colName, Description, CreateDate, StartDate, FinishDate, Status });
            dtgView.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgView.Location = new Point(12, 292);
            dtgView.MultiSelect = false;
            dtgView.Name = "dtgView";
            dtgView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgView.Size = new Size(936, 314);
            dtgView.TabIndex = 9;
            dtgView.CellClick += dtgView_CellClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.Frozen = true;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Visible = false;
            Id.Width = 42;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.Frozen = true;
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.Width = 64;
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.Name = "Description";
            Description.Width = 92;
            // 
            // CreateDate
            // 
            CreateDate.DataPropertyName = "CreateDate";
            CreateDate.HeaderText = "Create Date";
            CreateDate.Name = "CreateDate";
            CreateDate.Width = 93;
            // 
            // StartDate
            // 
            StartDate.DataPropertyName = "StartDate";
            StartDate.HeaderText = "Start Date";
            StartDate.Name = "StartDate";
            StartDate.Width = 83;
            // 
            // FinishDate
            // 
            FinishDate.DataPropertyName = "FinishDate";
            FinishDate.HeaderText = "Finish Date";
            FinishDate.Name = "FinishDate";
            FinishDate.Width = 90;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.Width = 64;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(401, 49);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 19;
            label2.Text = "Status";
            // 
            // listStatus
            // 
            listStatus.Enabled = false;
            listStatus.FormattingEnabled = true;
            listStatus.Items.AddRange(new object[] { "Pending", "InProgress", "Finished", "Cancelled" });
            listStatus.Location = new Point(446, 46);
            listStatus.Name = "listStatus";
            listStatus.Size = new Size(129, 23);
            listStatus.TabIndex = 20;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { novoToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(104, 26);
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(103, 22);
            novoToolStripMenuItem.Text = "Novo";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonHighlight;
            menuStrip1.Items.AddRange(new ToolStripItem[] { newToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(966, 24);
            menuStrip1.TabIndex = 21;
            menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { taskToolStripMenuItem });
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(43, 20);
            newToolStripMenuItem.Text = "New";
            // 
            // taskToolStripMenuItem
            // 
            taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            taskToolStripMenuItem.Size = new Size(96, 22);
            taskToolStripMenuItem.Text = "Task";
            taskToolStripMenuItem.Click += taskToolStripMenuItem_Click;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(527, 250);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 647);
            Controls.Add(btnSave);
            Controls.Add(menuStrip1);
            Controls.Add(listStatus);
            Controls.Add(label2);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(dtgView);
            Controls.Add(btnList);
            Controls.Add(lblStartDate);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Controls.Add(dtStartDate);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgView).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtDescription;
        private DateTimePicker dtStartDate;
        private Label lblName;
        private Label lblDescription;
        private Label lblStartDate;
        private Button btnList;
        private Button btnDelete;
        private Button btnEdit;
        private DataGridView dtgView;
        private Label label2;
        private ComboBox listStatus;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn CreateDate;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn FinishDate;
        private DataGridViewTextBoxColumn Status;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem novoToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem taskToolStripMenuItem;
        private Button btnSave;
    }
}
