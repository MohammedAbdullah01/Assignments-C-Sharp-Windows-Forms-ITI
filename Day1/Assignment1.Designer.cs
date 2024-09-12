namespace Assignment_1
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
            this.Value = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.LabelChooseUnit = new System.Windows.Forms.Label();
            this.radioButtonMeterToKilometer = new System.Windows.Forms.RadioButton();
            this.radioButtonMeterToMile = new System.Windows.Forms.RadioButton();
            this.radioButtonMileToMeter = new System.Windows.Forms.RadioButton();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.ErrorInputValue = new System.Windows.Forms.Label();
            this.ErrorInputChooseUint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Value
            // 
            this.Value.AutoSize = true;
            this.Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value.Location = new System.Drawing.Point(37, 44);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(70, 24);
            this.Value.TabIndex = 0;
            this.Value.Text = "Value:";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(37, 126);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(69, 23);
            this.Result.TabIndex = 1;
            this.Result.Text = "Result:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.Location = new System.Drawing.Point(112, 126);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(121, 22);
            this.textBoxResult.TabIndex = 3;
            // 
            // textBoxValue
            // 
            this.textBoxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValue.Location = new System.Drawing.Point(113, 46);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(121, 22);
            this.textBoxValue.TabIndex = 2;
            // 
            // LabelChooseUnit
            // 
            this.LabelChooseUnit.AutoSize = true;
            this.LabelChooseUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelChooseUnit.Location = new System.Drawing.Point(450, 20);
            this.LabelChooseUnit.Name = "LabelChooseUnit";
            this.LabelChooseUnit.Size = new System.Drawing.Size(124, 24);
            this.LabelChooseUnit.TabIndex = 4;
            this.LabelChooseUnit.Text = "Choose Unit";
            // 
            // radioButtonMeterToKilometer
            // 
            this.radioButtonMeterToKilometer.AutoSize = true;
            this.radioButtonMeterToKilometer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonMeterToKilometer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMeterToKilometer.Location = new System.Drawing.Point(422, 53);
            this.radioButtonMeterToKilometer.Name = "radioButtonMeterToKilometer";
            this.radioButtonMeterToKilometer.Size = new System.Drawing.Size(160, 24);
            this.radioButtonMeterToKilometer.TabIndex = 5;
            this.radioButtonMeterToKilometer.TabStop = true;
            this.radioButtonMeterToKilometer.Text = "Meter To Kilometer";
            this.radioButtonMeterToKilometer.UseVisualStyleBackColor = true;
            // 
            // radioButtonMeterToMile
            // 
            this.radioButtonMeterToMile.AutoSize = true;
            this.radioButtonMeterToMile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonMeterToMile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMeterToMile.Location = new System.Drawing.Point(422, 90);
            this.radioButtonMeterToMile.Name = "radioButtonMeterToMile";
            this.radioButtonMeterToMile.Size = new System.Drawing.Size(122, 24);
            this.radioButtonMeterToMile.TabIndex = 6;
            this.radioButtonMeterToMile.TabStop = true;
            this.radioButtonMeterToMile.Text = "Meter To Mile";
            this.radioButtonMeterToMile.UseVisualStyleBackColor = true;
            // 
            // radioButtonMileToMeter
            // 
            this.radioButtonMileToMeter.AutoSize = true;
            this.radioButtonMileToMeter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonMileToMeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMileToMeter.Location = new System.Drawing.Point(422, 124);
            this.radioButtonMileToMeter.Name = "radioButtonMileToMeter";
            this.radioButtonMileToMeter.Size = new System.Drawing.Size(122, 24);
            this.radioButtonMileToMeter.TabIndex = 7;
            this.radioButtonMileToMeter.TabStop = true;
            this.radioButtonMileToMeter.Text = "Mile To Meter\r\n";
            this.radioButtonMileToMeter.UseVisualStyleBackColor = true;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvert.Location = new System.Drawing.Point(300, 220);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(127, 29);
            this.buttonConvert.TabIndex = 8;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // ErrorInputValue
            // 
            this.ErrorInputValue.AutoSize = true;
            this.ErrorInputValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorInputValue.ForeColor = System.Drawing.Color.Red;
            this.ErrorInputValue.Location = new System.Drawing.Point(110, 71);
            this.ErrorInputValue.Name = "ErrorInputValue";
            this.ErrorInputValue.Size = new System.Drawing.Size(151, 15);
            this.ErrorInputValue.TabIndex = 9;
            this.ErrorInputValue.Text = "Require Enter Number";
            this.ErrorInputValue.Visible = false;
            // 
            // ErrorInputChooseUint
            // 
            this.ErrorInputChooseUint.AutoSize = true;
            this.ErrorInputChooseUint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorInputChooseUint.ForeColor = System.Drawing.Color.Red;
            this.ErrorInputChooseUint.Location = new System.Drawing.Point(419, 151);
            this.ErrorInputChooseUint.Name = "ErrorInputChooseUint";
            this.ErrorInputChooseUint.Size = new System.Drawing.Size(140, 15);
            this.ErrorInputChooseUint.TabIndex = 10;
            this.ErrorInputChooseUint.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.ErrorInputChooseUint);
            this.Controls.Add(this.ErrorInputValue);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.radioButtonMileToMeter);
            this.Controls.Add(this.radioButtonMeterToMile);
            this.Controls.Add(this.radioButtonMeterToKilometer);
            this.Controls.Add(this.LabelChooseUnit);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Value);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Value;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Label LabelChooseUnit;
        private System.Windows.Forms.RadioButton radioButtonMeterToKilometer;
        private System.Windows.Forms.RadioButton radioButtonMeterToMile;
        private System.Windows.Forms.RadioButton radioButtonMileToMeter;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label ErrorInputValue;
        private System.Windows.Forms.Label ErrorInputChooseUint;
    }
}

