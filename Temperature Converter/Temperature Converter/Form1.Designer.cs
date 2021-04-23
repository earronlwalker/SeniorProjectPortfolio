namespace Temperature_Converter
{
    partial class frmTempConverter
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
            this.lblConvert = new System.Windows.Forms.Label();
            this.btnCelsius = new System.Windows.Forms.RadioButton();
            this.btnFahrenheit = new System.Windows.Forms.RadioButton();
            this.lblTemp = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Label();
            this.numTemp = new System.Windows.Forms.NumericUpDown();
            this.lblOuput = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConvert
            // 
            this.lblConvert.AutoSize = true;
            this.lblConvert.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvert.Location = new System.Drawing.Point(60, 55);
            this.lblConvert.Name = "lblConvert";
            this.lblConvert.Size = new System.Drawing.Size(125, 19);
            this.lblConvert.TabIndex = 0;
            this.lblConvert.Text = "Convert From";
            // 
            // btnCelsius
            // 
            this.btnCelsius.AutoSize = true;
            this.btnCelsius.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCelsius.Location = new System.Drawing.Point(179, 77);
            this.btnCelsius.Name = "btnCelsius";
            this.btnCelsius.Size = new System.Drawing.Size(79, 21);
            this.btnCelsius.TabIndex = 1;
            this.btnCelsius.TabStop = true;
            this.btnCelsius.Text = "Celsius";
            this.btnCelsius.UseVisualStyleBackColor = true;
            // 
            // btnFahrenheit
            // 
            this.btnFahrenheit.AutoSize = true;
            this.btnFahrenheit.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFahrenheit.Location = new System.Drawing.Point(179, 110);
            this.btnFahrenheit.Name = "btnFahrenheit";
            this.btnFahrenheit.Size = new System.Drawing.Size(111, 21);
            this.btnFahrenheit.TabIndex = 2;
            this.btnFahrenheit.TabStop = true;
            this.btnFahrenheit.Text = "Fahrenheit";
            this.btnFahrenheit.UseVisualStyleBackColor = true;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(64, 165);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(165, 19);
            this.lblTemp.TabIndex = 3;
            this.lblTemp.Text = "Enter Temperature";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(152, 226);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(106, 45);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.AutoSize = true;
            this.btnOutput.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutput.Location = new System.Drawing.Point(64, 299);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(235, 19);
            this.btnOutput.TabIndex = 6;
            this.btnOutput.Text = "The Output Temperature is:";
            // 
            // numTemp
            // 
            this.numTemp.Location = new System.Drawing.Point(257, 164);
            this.numTemp.Name = "numTemp";
            this.numTemp.Size = new System.Drawing.Size(120, 20);
            this.numTemp.TabIndex = 8;
            this.numTemp.ValueChanged += new System.EventHandler(this.numTemp_ValueChanged);
            // 
            // lblOuput
            // 
            this.lblOuput.AutoSize = true;
            this.lblOuput.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOuput.Location = new System.Drawing.Point(321, 299);
            this.lblOuput.Name = "lblOuput";
            this.lblOuput.Size = new System.Drawing.Size(0, 19);
            this.lblOuput.TabIndex = 9;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(253, 187);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(0, 15);
            this.lblMin.TabIndex = 10;
            // 
            // frmTempConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 437);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblOuput);
            this.Controls.Add(this.numTemp);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.btnFahrenheit);
            this.Controls.Add(this.btnCelsius);
            this.Controls.Add(this.lblConvert);
            this.Name = "frmTempConverter";
            this.Text = "Temperature Converter";
            ((System.ComponentModel.ISupportInitialize)(this.numTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConvert;
        private System.Windows.Forms.RadioButton btnCelsius;
        private System.Windows.Forms.RadioButton btnFahrenheit;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label btnOutput;
        private System.Windows.Forms.NumericUpDown numTemp;
        private System.Windows.Forms.Label lblOuput;
        private System.Windows.Forms.Label lblMin;
    }
}

