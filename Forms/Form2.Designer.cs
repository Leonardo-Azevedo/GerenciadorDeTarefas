namespace TasksWithBD.Forms
{
    partial class Form2
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
            lblCName = new Label();
            lblCDescription = new Label();
            lblCStartDate = new Label();
            lblCStatus = new Label();
            txtCName = new TextBox();
            txtCDescription = new TextBox();
            dtCStartDate = new DateTimePicker();
            listCStatus = new ComboBox();
            btnCCreate = new Button();
            SuspendLayout();
            // 
            // lblCName
            // 
            lblCName.AutoSize = true;
            lblCName.Location = new Point(84, 43);
            lblCName.Name = "lblCName";
            lblCName.Size = new Size(39, 15);
            lblCName.TabIndex = 0;
            lblCName.Text = "Name";
            // 
            // lblCDescription
            // 
            lblCDescription.AutoSize = true;
            lblCDescription.Location = new Point(56, 82);
            lblCDescription.Name = "lblCDescription";
            lblCDescription.Size = new Size(67, 15);
            lblCDescription.TabIndex = 1;
            lblCDescription.Text = "Description";
            // 
            // lblCStartDate
            // 
            lblCStartDate.AutoSize = true;
            lblCStartDate.Location = new Point(65, 200);
            lblCStartDate.Name = "lblCStartDate";
            lblCStartDate.Size = new Size(58, 15);
            lblCStartDate.TabIndex = 2;
            lblCStartDate.Text = "Start Date";
            // 
            // lblCStatus
            // 
            lblCStatus.AutoSize = true;
            lblCStatus.Location = new Point(84, 243);
            lblCStatus.Name = "lblCStatus";
            lblCStatus.Size = new Size(39, 15);
            lblCStatus.TabIndex = 3;
            lblCStatus.Text = "Status";
            // 
            // txtCName
            // 
            txtCName.Location = new Point(138, 40);
            txtCName.Name = "txtCName";
            txtCName.Size = new Size(242, 23);
            txtCName.TabIndex = 4;
            // 
            // txtCDescription
            // 
            txtCDescription.Location = new Point(138, 79);
            txtCDescription.Multiline = true;
            txtCDescription.Name = "txtCDescription";
            txtCDescription.Size = new Size(242, 65);
            txtCDescription.TabIndex = 5;
            // 
            // dtCStartDate
            // 
            dtCStartDate.Format = DateTimePickerFormat.Short;
            dtCStartDate.Location = new Point(138, 194);
            dtCStartDate.Name = "dtCStartDate";
            dtCStartDate.Size = new Size(132, 23);
            dtCStartDate.TabIndex = 6;
            // 
            // listCStatus
            // 
            listCStatus.Enabled = false;
            listCStatus.FormattingEnabled = true;
            listCStatus.Items.AddRange(new object[] { "Pending", "InProgress", "Finished" });
            listCStatus.Location = new Point(138, 240);
            listCStatus.Name = "listCStatus";
            listCStatus.Size = new Size(129, 23);
            listCStatus.TabIndex = 21;
            // 
            // btnCCreate
            // 
            btnCCreate.Location = new Point(221, 321);
            btnCCreate.Name = "btnCCreate";
            btnCCreate.Size = new Size(75, 23);
            btnCCreate.TabIndex = 22;
            btnCCreate.Text = "Create";
            btnCCreate.UseVisualStyleBackColor = true;
            btnCCreate.Click += btnCCreate_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 418);
            Controls.Add(btnCCreate);
            Controls.Add(listCStatus);
            Controls.Add(dtCStartDate);
            Controls.Add(txtCDescription);
            Controls.Add(txtCName);
            Controls.Add(lblCStatus);
            Controls.Add(lblCStartDate);
            Controls.Add(lblCDescription);
            Controls.Add(lblCName);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New task";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCName;
        private Label lblCDescription;
        private Label lblCStartDate;
        private Label lblCStatus;
        private TextBox txtCName;
        private TextBox txtCDescription;
        private DateTimePicker dtCStartDate;
        private ComboBox listCStatus;
        private Button btnCCreate;
    }
}