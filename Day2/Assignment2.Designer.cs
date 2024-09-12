namespace Day2
{
    partial class Assignment2
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.dateTimeBirthdate = new System.Windows.Forms.DateTimePicker();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelBirthdate = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.listViewData = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBirthdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.buttonUpdateItem = new System.Windows.Forms.Button();
            this.labelErrorInputName = new System.Windows.Forms.Label();
            this.labelErrorInputPhone = new System.Windows.Forms.Label();
            this.labelErrorInputBirthDate = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.labelErrorListView = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(132, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(189, 26);
            this.textBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(16, 39);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(71, 24);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name:";
            // 
            // dateTimeBirthdate
            // 
            this.dateTimeBirthdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimeBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeBirthdate.Location = new System.Drawing.Point(132, 196);
            this.dateTimeBirthdate.Name = "dateTimeBirthdate";
            this.dateTimeBirthdate.Size = new System.Drawing.Size(295, 26);
            this.dateTimeBirthdate.TabIndex = 3;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(16, 114);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(77, 24);
            this.labelPhone.TabIndex = 3;
            this.labelPhone.Text = "Phone:";
            // 
            // labelBirthdate
            // 
            this.labelBirthdate.AutoSize = true;
            this.labelBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthdate.Location = new System.Drawing.Point(16, 196);
            this.labelBirthdate.Name = "labelBirthdate";
            this.labelBirthdate.Size = new System.Drawing.Size(98, 24);
            this.labelBirthdate.TabIndex = 4;
            this.labelBirthdate.Text = "Birthdate:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(132, 112);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(189, 26);
            this.textBoxPhone.TabIndex = 2;
            // 
            // listViewData
            // 
            this.listViewData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listViewData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderPhone,
            this.columnHeaderBirthdate});
            this.listViewData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewData.ForeColor = System.Drawing.Color.Black;
            this.listViewData.HideSelection = false;
            this.listViewData.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listViewData.Location = new System.Drawing.Point(483, 34);
            this.listViewData.Name = "listViewData";
            this.listViewData.Size = new System.Drawing.Size(389, 426);
            this.listViewData.TabIndex = 6;
            this.listViewData.UseCompatibleStateImageBehavior = false;
            this.listViewData.View = System.Windows.Forms.View.Details;
            this.listViewData.SelectedIndexChanged += new System.EventHandler(this.listViewData_SelectedIndexChanged);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 133;
            // 
            // columnHeaderPhone
            // 
            this.columnHeaderPhone.Text = "Phone";
            this.columnHeaderPhone.Width = 140;
            // 
            // columnHeaderBirthdate
            // 
            this.columnHeaderBirthdate.Text = "Birthdate";
            this.columnHeaderBirthdate.Width = 106;
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddItem.ForeColor = System.Drawing.Color.Blue;
            this.buttonAddItem.Location = new System.Drawing.Point(20, 324);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(114, 35);
            this.buttonAddItem.TabIndex = 4;
            this.buttonAddItem.Text = "Add";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // buttonUpdateItem
            // 
            this.buttonUpdateItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdateItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonUpdateItem.Location = new System.Drawing.Point(187, 324);
            this.buttonUpdateItem.Name = "buttonUpdateItem";
            this.buttonUpdateItem.Size = new System.Drawing.Size(114, 35);
            this.buttonUpdateItem.TabIndex = 5;
            this.buttonUpdateItem.Text = "Update";
            this.buttonUpdateItem.UseVisualStyleBackColor = true;
            this.buttonUpdateItem.Click += new System.EventHandler(this.buttonUpdateItem_Click);
            // 
            // labelErrorInputName
            // 
            this.labelErrorInputName.AutoSize = true;
            this.labelErrorInputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorInputName.ForeColor = System.Drawing.Color.Red;
            this.labelErrorInputName.Location = new System.Drawing.Point(129, 78);
            this.labelErrorInputName.Name = "labelErrorInputName";
            this.labelErrorInputName.Size = new System.Drawing.Size(0, 16);
            this.labelErrorInputName.TabIndex = 9;
            // 
            // labelErrorInputPhone
            // 
            this.labelErrorInputPhone.AutoSize = true;
            this.labelErrorInputPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorInputPhone.ForeColor = System.Drawing.Color.Red;
            this.labelErrorInputPhone.Location = new System.Drawing.Point(129, 150);
            this.labelErrorInputPhone.Name = "labelErrorInputPhone";
            this.labelErrorInputPhone.Size = new System.Drawing.Size(0, 16);
            this.labelErrorInputPhone.TabIndex = 10;
            // 
            // labelErrorInputBirthDate
            // 
            this.labelErrorInputBirthDate.AutoSize = true;
            this.labelErrorInputBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorInputBirthDate.ForeColor = System.Drawing.Color.Red;
            this.labelErrorInputBirthDate.Location = new System.Drawing.Point(129, 241);
            this.labelErrorInputBirthDate.Name = "labelErrorInputBirthDate";
            this.labelErrorInputBirthDate.Size = new System.Drawing.Size(0, 16);
            this.labelErrorInputBirthDate.TabIndex = 11;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRemove.Location = new System.Drawing.Point(347, 324);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(114, 35);
            this.buttonRemove.TabIndex = 12;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // labelErrorListView
            // 
            this.labelErrorListView.AutoSize = true;
            this.labelErrorListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorListView.ForeColor = System.Drawing.Color.Red;
            this.labelErrorListView.Location = new System.Drawing.Point(480, 9);
            this.labelErrorListView.Name = "labelErrorListView";
            this.labelErrorListView.Size = new System.Drawing.Size(50, 16);
            this.labelErrorListView.TabIndex = 13;
            // 
            // Assignment2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 472);
            this.Controls.Add(this.labelErrorListView);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.labelErrorInputBirthDate);
            this.Controls.Add(this.labelErrorInputPhone);
            this.Controls.Add(this.labelErrorInputName);
            this.Controls.Add(this.buttonUpdateItem);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.listViewData);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelBirthdate);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.dateTimeBirthdate);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Name = "Assignment2";
            this.Text = "Assignment2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DateTimePicker dateTimeBirthdate;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelBirthdate;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.ListView listViewData;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderPhone;
        private System.Windows.Forms.ColumnHeader columnHeaderBirthdate;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Button buttonUpdateItem;
        private System.Windows.Forms.Label labelErrorInputName;
        private System.Windows.Forms.Label labelErrorInputPhone;
        private System.Windows.Forms.Label labelErrorInputBirthDate;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label labelErrorListView;
    }
}