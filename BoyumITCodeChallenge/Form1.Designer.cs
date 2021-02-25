namespace BoyumITCodeChallenge
{
    partial class boyumChallenge
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
            this.fileInputLable = new System.Windows.Forms.Label();
            this.fileInputField = new System.Windows.Forms.TextBox();
            this.fileInputBtn = new System.Windows.Forms.Button();
            this.processBtn = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.GroupBox();
            this.totalOutput = new System.Windows.Forms.Label();
            this.idOutput = new System.Windows.Forms.Label();
            this.customerOutput = new System.Windows.Forms.Label();
            this.dateOutputLable = new System.Windows.Forms.Label();
            this.priceAverageOutput = new System.Windows.Forms.Label();
            this.totalLable = new System.Windows.Forms.Label();
            this.priceAverageLable = new System.Windows.Forms.Label();
            this.dateLable = new System.Windows.Forms.Label();
            this.customerLable = new System.Windows.Forms.Label();
            this.idLable = new System.Windows.Forms.Label();
            this.resultBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileInputLable
            // 
            this.fileInputLable.AutoSize = true;
            this.fileInputLable.Location = new System.Drawing.Point(13, 13);
            this.fileInputLable.Name = "fileInputLable";
            this.fileInputLable.Size = new System.Drawing.Size(62, 15);
            this.fileInputLable.TabIndex = 0;
            this.fileInputLable.Text = "Input XML";
            // 
            // fileInputField
            // 
            this.fileInputField.Location = new System.Drawing.Point(97, 10);
            this.fileInputField.Name = "fileInputField";
            this.fileInputField.Size = new System.Drawing.Size(380, 23);
            this.fileInputField.TabIndex = 1;
            this.fileInputField.TextChanged += new System.EventHandler(this.fileInputField_TextChanged);
            // 
            // fileInputBtn
            // 
            this.fileInputBtn.Location = new System.Drawing.Point(483, 10);
            this.fileInputBtn.Name = "fileInputBtn";
            this.fileInputBtn.Size = new System.Drawing.Size(33, 24);
            this.fileInputBtn.TabIndex = 2;
            this.fileInputBtn.Text = "...";
            this.fileInputBtn.UseVisualStyleBackColor = true;
            this.fileInputBtn.Click += new System.EventHandler(this.fileInputBtn_Click);
            // 
            // processBtn
            // 
            this.processBtn.Enabled = false;
            this.processBtn.Location = new System.Drawing.Point(522, 11);
            this.processBtn.Name = "processBtn";
            this.processBtn.Size = new System.Drawing.Size(75, 23);
            this.processBtn.TabIndex = 3;
            this.processBtn.Text = "Process";
            this.processBtn.UseVisualStyleBackColor = true;
            this.processBtn.Click += new System.EventHandler(this.processBtn_Click);
            // 
            // resultBox
            // 
            this.resultBox.Controls.Add(this.totalOutput);
            this.resultBox.Controls.Add(this.idOutput);
            this.resultBox.Controls.Add(this.customerOutput);
            this.resultBox.Controls.Add(this.dateOutputLable);
            this.resultBox.Controls.Add(this.priceAverageOutput);
            this.resultBox.Controls.Add(this.totalLable);
            this.resultBox.Controls.Add(this.priceAverageLable);
            this.resultBox.Controls.Add(this.dateLable);
            this.resultBox.Controls.Add(this.customerLable);
            this.resultBox.Controls.Add(this.idLable);
            this.resultBox.Location = new System.Drawing.Point(97, 39);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(500, 171);
            this.resultBox.TabIndex = 4;
            this.resultBox.TabStop = false;
            this.resultBox.Text = "Result";
            // 
            // totalOutput
            // 
            this.totalOutput.AutoSize = true;
            this.totalOutput.Location = new System.Drawing.Point(99, 143);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(12, 15);
            this.totalOutput.TabIndex = 7;
            this.totalOutput.Text = "-";
            // 
            // idOutput
            // 
            this.idOutput.AutoSize = true;
            this.idOutput.Location = new System.Drawing.Point(99, 23);
            this.idOutput.Name = "idOutput";
            this.idOutput.Size = new System.Drawing.Size(12, 15);
            this.idOutput.TabIndex = 7;
            this.idOutput.Text = "-";
            // 
            // customerOutput
            // 
            this.customerOutput.AutoSize = true;
            this.customerOutput.Location = new System.Drawing.Point(99, 53);
            this.customerOutput.Name = "customerOutput";
            this.customerOutput.Size = new System.Drawing.Size(12, 15);
            this.customerOutput.TabIndex = 7;
            this.customerOutput.Text = "-";
            // 
            // dateOutputLable
            // 
            this.dateOutputLable.AutoSize = true;
            this.dateOutputLable.Location = new System.Drawing.Point(99, 83);
            this.dateOutputLable.Name = "dateOutputLable";
            this.dateOutputLable.Size = new System.Drawing.Size(12, 15);
            this.dateOutputLable.TabIndex = 7;
            this.dateOutputLable.Text = "-";
            // 
            // priceAverageOutput
            // 
            this.priceAverageOutput.AutoSize = true;
            this.priceAverageOutput.Location = new System.Drawing.Point(99, 113);
            this.priceAverageOutput.Name = "priceAverageOutput";
            this.priceAverageOutput.Size = new System.Drawing.Size(12, 15);
            this.priceAverageOutput.TabIndex = 6;
            this.priceAverageOutput.Text = "-";
            // 
            // totalLable
            // 
            this.totalLable.AutoSize = true;
            this.totalLable.Location = new System.Drawing.Point(7, 143);
            this.totalLable.Name = "totalLable";
            this.totalLable.Size = new System.Drawing.Size(32, 15);
            this.totalLable.TabIndex = 5;
            this.totalLable.Text = "Total";
            // 
            // priceAverageLable
            // 
            this.priceAverageLable.AutoSize = true;
            this.priceAverageLable.Location = new System.Drawing.Point(6, 113);
            this.priceAverageLable.Name = "priceAverageLable";
            this.priceAverageLable.Size = new System.Drawing.Size(79, 15);
            this.priceAverageLable.TabIndex = 3;
            this.priceAverageLable.Text = "Price Average";
            // 
            // dateLable
            // 
            this.dateLable.AutoSize = true;
            this.dateLable.Location = new System.Drawing.Point(7, 83);
            this.dateLable.Name = "dateLable";
            this.dateLable.Size = new System.Drawing.Size(31, 15);
            this.dateLable.TabIndex = 2;
            this.dateLable.Text = "Date";
            // 
            // customerLable
            // 
            this.customerLable.AutoSize = true;
            this.customerLable.Location = new System.Drawing.Point(7, 53);
            this.customerLable.Name = "customerLable";
            this.customerLable.Size = new System.Drawing.Size(59, 15);
            this.customerLable.TabIndex = 1;
            this.customerLable.Text = "Customer";
            // 
            // idLable
            // 
            this.idLable.AutoSize = true;
            this.idLable.Location = new System.Drawing.Point(7, 23);
            this.idLable.Name = "idLable";
            this.idLable.Size = new System.Drawing.Size(17, 15);
            this.idLable.TabIndex = 0;
            this.idLable.Text = "Id";
            // 
            // boyumChallenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 219);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.processBtn);
            this.Controls.Add(this.fileInputBtn);
            this.Controls.Add(this.fileInputField);
            this.Controls.Add(this.fileInputLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "boyumChallenge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boyum Challenge";
            this.resultBox.ResumeLayout(false);
            this.resultBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fileInputLable;
        private System.Windows.Forms.TextBox fileInputField;
        private System.Windows.Forms.Button fileInputBtn;
        private System.Windows.Forms.Button processBtn;
        private System.Windows.Forms.GroupBox resultBox;
        private System.Windows.Forms.Label totalLable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label priceAverageLable;
        private System.Windows.Forms.Label dateLable;
        private System.Windows.Forms.Label customerLable;
        private System.Windows.Forms.Label idLable;
        private System.Windows.Forms.Label priceAverageOutput;
        private System.Windows.Forms.Label idOutput;
        private System.Windows.Forms.Label customerOutput;
        private System.Windows.Forms.Label dateOutputLable;
        private System.Windows.Forms.Label totalOutput;
    }
}

