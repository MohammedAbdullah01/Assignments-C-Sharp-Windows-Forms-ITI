namespace Day2
{
    partial class Assignment1
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
            this.labelTrainees = new System.Windows.Forms.Label();
            this.buttonMoveSelector = new System.Windows.Forms.Button();
            this.buttonMoveSelectorAll = new System.Windows.Forms.Button();
            this.buttonReturnSpecified = new System.Windows.Forms.Button();
            this.buttonReturnSpecifiedAll = new System.Windows.Forms.Button();
            this.comboBoxLab = new System.Windows.Forms.ComboBox();
            this.labelLab = new System.Windows.Forms.Label();
            this.checkedListBoxTrainees = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxLab = new System.Windows.Forms.CheckedListBox();
            this.labelTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTrainees
            // 
            this.labelTrainees.AutoSize = true;
            this.labelTrainees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrainees.Location = new System.Drawing.Point(36, 78);
            this.labelTrainees.Name = "labelTrainees";
            this.labelTrainees.Size = new System.Drawing.Size(92, 24);
            this.labelTrainees.TabIndex = 0;
            this.labelTrainees.Text = "Trainees";
            // 
            // buttonMoveSelector
            // 
            this.buttonMoveSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveSelector.Location = new System.Drawing.Point(373, 139);
            this.buttonMoveSelector.Name = "buttonMoveSelector";
            this.buttonMoveSelector.Size = new System.Drawing.Size(45, 32);
            this.buttonMoveSelector.TabIndex = 1;
            this.buttonMoveSelector.Text = ">";
            this.buttonMoveSelector.UseVisualStyleBackColor = true;
            this.buttonMoveSelector.Click += new System.EventHandler(this.buttonMoveSelector_Click);
            // 
            // buttonMoveSelectorAll
            // 
            this.buttonMoveSelectorAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveSelectorAll.Location = new System.Drawing.Point(373, 208);
            this.buttonMoveSelectorAll.Name = "buttonMoveSelectorAll";
            this.buttonMoveSelectorAll.Size = new System.Drawing.Size(45, 32);
            this.buttonMoveSelectorAll.TabIndex = 2;
            this.buttonMoveSelectorAll.Text = ">>";
            this.buttonMoveSelectorAll.UseVisualStyleBackColor = true;
            this.buttonMoveSelectorAll.Click += new System.EventHandler(this.buttonMoveSelectorAll_Click);
            // 
            // buttonReturnSpecified
            // 
            this.buttonReturnSpecified.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturnSpecified.Location = new System.Drawing.Point(373, 280);
            this.buttonReturnSpecified.Name = "buttonReturnSpecified";
            this.buttonReturnSpecified.Size = new System.Drawing.Size(45, 32);
            this.buttonReturnSpecified.TabIndex = 3;
            this.buttonReturnSpecified.Text = "<";
            this.buttonReturnSpecified.UseVisualStyleBackColor = true;
            this.buttonReturnSpecified.Click += new System.EventHandler(this.buttonReturnSpecified_Click);
            // 
            // buttonReturnSpecifiedAll
            // 
            this.buttonReturnSpecifiedAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturnSpecifiedAll.Location = new System.Drawing.Point(373, 350);
            this.buttonReturnSpecifiedAll.Name = "buttonReturnSpecifiedAll";
            this.buttonReturnSpecifiedAll.Size = new System.Drawing.Size(45, 32);
            this.buttonReturnSpecifiedAll.TabIndex = 4;
            this.buttonReturnSpecifiedAll.Text = "<<";
            this.buttonReturnSpecifiedAll.UseVisualStyleBackColor = true;
            this.buttonReturnSpecifiedAll.Click += new System.EventHandler(this.buttonReturnSpecifiedAll_Click);
            // 
            // comboBoxLab
            // 
            this.comboBoxLab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLab.FormattingEnabled = true;
            this.comboBoxLab.Items.AddRange(new object[] {
            "Lab1",
            "Lab2",
            "Lab3"});
            this.comboBoxLab.Location = new System.Drawing.Point(601, 81);
            this.comboBoxLab.Name = "comboBoxLab";
            this.comboBoxLab.Size = new System.Drawing.Size(132, 23);
            this.comboBoxLab.TabIndex = 5;
            this.comboBoxLab.SelectedIndexChanged += new System.EventHandler(this.comboBoxLab_SelectedIndexChanged);
            // 
            // labelLab
            // 
            this.labelLab.AutoSize = true;
            this.labelLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLab.Location = new System.Drawing.Point(528, 78);
            this.labelLab.Name = "labelLab";
            this.labelLab.Size = new System.Drawing.Size(50, 24);
            this.labelLab.TabIndex = 6;
            this.labelLab.Text = "Lab:";
            // 
            // checkedListBoxTrainees
            // 
            this.checkedListBoxTrainees.CheckOnClick = true;
            this.checkedListBoxTrainees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxTrainees.FormattingEnabled = true;
            this.checkedListBoxTrainees.Location = new System.Drawing.Point(12, 110);
            this.checkedListBoxTrainees.Name = "checkedListBoxTrainees";
            this.checkedListBoxTrainees.Size = new System.Drawing.Size(227, 310);
            this.checkedListBoxTrainees.TabIndex = 7;
            // 
            // checkedListBoxLab
            // 
            this.checkedListBoxLab.CheckOnClick = true;
            this.checkedListBoxLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxLab.FormattingEnabled = true;
            this.checkedListBoxLab.Location = new System.Drawing.Point(561, 110);
            this.checkedListBoxLab.Name = "checkedListBoxLab";
            this.checkedListBoxLab.Size = new System.Drawing.Size(227, 310);
            this.checkedListBoxLab.TabIndex = 8;
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTest.Location = new System.Drawing.Point(341, 29);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(0, 16);
            this.labelTest.TabIndex = 9;
            // 
            // Assignment1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.checkedListBoxLab);
            this.Controls.Add(this.checkedListBoxTrainees);
            this.Controls.Add(this.labelLab);
            this.Controls.Add(this.comboBoxLab);
            this.Controls.Add(this.buttonReturnSpecifiedAll);
            this.Controls.Add(this.buttonReturnSpecified);
            this.Controls.Add(this.buttonMoveSelectorAll);
            this.Controls.Add(this.buttonMoveSelector);
            this.Controls.Add(this.labelTrainees);
            this.Name = "Assignment1";
            this.Text = "Assignment1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTrainees;
        private System.Windows.Forms.Button buttonMoveSelector;
        private System.Windows.Forms.Button buttonMoveSelectorAll;
        private System.Windows.Forms.Button buttonReturnSpecified;
        private System.Windows.Forms.Button buttonReturnSpecifiedAll;
        private System.Windows.Forms.Label labelLab;
        private System.Windows.Forms.CheckedListBox checkedListBoxTrainees;
        private System.Windows.Forms.CheckedListBox checkedListBoxLab;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.ComboBox comboBoxLab;
    }
}

