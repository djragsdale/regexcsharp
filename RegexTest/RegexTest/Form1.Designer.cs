namespace RegexTest
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
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtEvalString = new System.Windows.Forms.TextBox();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.lblPattern = new System.Windows.Forms.Label();
            this.lblEvalString = new System.Windows.Forms.Label();
            this.lblResultLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkIgnoreCase = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvaluate.Location = new System.Drawing.Point(108, 101);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(275, 42);
            this.btnEvaluate.TabIndex = 0;
            this.btnEvaluate.Text = "Evaluate";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(108, 160);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(275, 72);
            this.lblResult.TabIndex = 1;
            // 
            // txtEvalString
            // 
            this.txtEvalString.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvalString.Location = new System.Drawing.Point(108, 24);
            this.txtEvalString.Name = "txtEvalString";
            this.txtEvalString.Size = new System.Drawing.Size(275, 23);
            this.txtEvalString.TabIndex = 2;
            // 
            // txtPattern
            // 
            this.txtPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPattern.Location = new System.Drawing.Point(108, 60);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(275, 23);
            this.txtPattern.TabIndex = 3;
            // 
            // lblPattern
            // 
            this.lblPattern.AutoSize = true;
            this.lblPattern.Location = new System.Drawing.Point(23, 63);
            this.lblPattern.Name = "lblPattern";
            this.lblPattern.Size = new System.Drawing.Size(79, 13);
            this.lblPattern.TabIndex = 4;
            this.lblPattern.Text = "RegEx Pattern:";
            // 
            // lblEvalString
            // 
            this.lblEvalString.AutoSize = true;
            this.lblEvalString.Location = new System.Drawing.Point(41, 27);
            this.lblEvalString.Name = "lblEvalString";
            this.lblEvalString.Size = new System.Drawing.Size(61, 13);
            this.lblEvalString.TabIndex = 5;
            this.lblEvalString.Text = "Eval String:";
            // 
            // lblResultLabel
            // 
            this.lblResultLabel.AutoSize = true;
            this.lblResultLabel.Location = new System.Drawing.Point(62, 163);
            this.lblResultLabel.Name = "lblResultLabel";
            this.lblResultLabel.Size = new System.Drawing.Size(40, 13);
            this.lblResultLabel.TabIndex = 6;
            this.lblResultLabel.Text = "Result:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 244);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 65);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pattern Holder:";
            // 
            // chkIgnoreCase
            // 
            this.chkIgnoreCase.AutoSize = true;
            this.chkIgnoreCase.Location = new System.Drawing.Point(20, 115);
            this.chkIgnoreCase.Name = "chkIgnoreCase";
            this.chkIgnoreCase.Size = new System.Drawing.Size(82, 17);
            this.chkIgnoreCase.TabIndex = 9;
            this.chkIgnoreCase.Text = "Ignore case";
            this.chkIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(298, 357);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 37);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 406);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.chkIgnoreCase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblResultLabel);
            this.Controls.Add(this.lblEvalString);
            this.Controls.Add(this.lblPattern);
            this.Controls.Add(this.txtPattern);
            this.Controls.Add(this.txtEvalString);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnEvaluate);
            this.Name = "Form1";
            this.Text = "RegEx Pattern Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtEvalString;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.Label lblPattern;
        private System.Windows.Forms.Label lblEvalString;
        private System.Windows.Forms.Label lblResultLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkIgnoreCase;
        private System.Windows.Forms.Button btnExit;
    }
}

