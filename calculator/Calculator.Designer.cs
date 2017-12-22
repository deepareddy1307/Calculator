namespace calculator
{
    partial class CalculatorForm
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
            this.FirstNumTextBox = new System.Windows.Forms.TextBox();
            this.FirstNumberLabel = new System.Windows.Forms.Label();
            this.SecondNumTextBox = new System.Windows.Forms.TextBox();
            this.SecondNumLabel = new System.Windows.Forms.Label();
            this.SUBbutton = new System.Windows.Forms.Button();
            this.MULTbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Divbutton = new System.Windows.Forms.Button();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ADDbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNumTextBox
            // 
            this.FirstNumTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.FirstNumTextBox.Location = new System.Drawing.Point(133, 72);
            this.FirstNumTextBox.Name = "FirstNumTextBox";
            this.FirstNumTextBox.Size = new System.Drawing.Size(127, 20);
            this.FirstNumTextBox.TabIndex = 0;
            // 
            // FirstNumberLabel
            // 
            this.FirstNumberLabel.AutoSize = true;
            this.FirstNumberLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FirstNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.FirstNumberLabel.Location = new System.Drawing.Point(104, 21);
            this.FirstNumberLabel.Name = "FirstNumberLabel";
            this.FirstNumberLabel.Size = new System.Drawing.Size(125, 15);
            this.FirstNumberLabel.TabIndex = 1;
            this.FirstNumberLabel.Text = "Calculator Application";
            // 
            // SecondNumTextBox
            // 
            this.SecondNumTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.SecondNumTextBox.Location = new System.Drawing.Point(133, 117);
            this.SecondNumTextBox.Name = "SecondNumTextBox";
            this.SecondNumTextBox.Size = new System.Drawing.Size(127, 20);
            this.SecondNumTextBox.TabIndex = 2;
            // 
            // SecondNumLabel
            // 
            this.SecondNumLabel.AutoSize = true;
            this.SecondNumLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SecondNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondNumLabel.ForeColor = System.Drawing.Color.Black;
            this.SecondNumLabel.Location = new System.Drawing.Point(26, 124);
            this.SecondNumLabel.Name = "SecondNumLabel";
            this.SecondNumLabel.Size = new System.Drawing.Size(97, 15);
            this.SecondNumLabel.TabIndex = 3;
            this.SecondNumLabel.Text = "Second Number";
            this.SecondNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SUBbutton
            // 
            this.SUBbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUBbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SUBbutton.Location = new System.Drawing.Point(133, 187);
            this.SUBbutton.Name = "SUBbutton";
            this.SUBbutton.Size = new System.Drawing.Size(91, 23);
            this.SUBbutton.TabIndex = 5;
            this.SUBbutton.Text = "SUB";
            this.SUBbutton.UseVisualStyleBackColor = true;
            this.SUBbutton.Click += new System.EventHandler(this.SUBbutton_Click);
            // 
            // MULTbutton
            // 
            this.MULTbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MULTbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MULTbutton.Location = new System.Drawing.Point(29, 216);
            this.MULTbutton.Name = "MULTbutton";
            this.MULTbutton.Size = new System.Drawing.Size(89, 23);
            this.MULTbutton.TabIndex = 6;
            this.MULTbutton.Text = "MULT";
            this.MULTbutton.UseVisualStyleBackColor = true;
            this.MULTbutton.Click += new System.EventHandler(this.MULTbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(26, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "RESULT";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.ResultTextBox.Location = new System.Drawing.Point(124, 288);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(100, 20);
            this.ResultTextBox.TabIndex = 8;
            this.ResultTextBox.TextChanged += new System.EventHandler(this.ResultTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "First Number";
            // 
            // Divbutton
            // 
            this.Divbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Divbutton.Location = new System.Drawing.Point(133, 216);
            this.Divbutton.Name = "Divbutton";
            this.Divbutton.Size = new System.Drawing.Size(91, 23);
            this.Divbutton.TabIndex = 11;
            this.Divbutton.Text = "Division";
            this.Divbutton.UseVisualStyleBackColor = true;
            this.Divbutton.Click += new System.EventHandler(this.Divbutton_Click);
            // 
            // Clearbutton
            // 
            this.Clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Clearbutton.Location = new System.Drawing.Point(320, 187);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(91, 23);
            this.Clearbutton.TabIndex = 12;
            this.Clearbutton.Text = "CLEAR";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExitButton.Location = new System.Drawing.Point(320, 216);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(91, 23);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ADDbutton
            // 
            this.ADDbutton.BackColor = System.Drawing.SystemColors.Control;
            this.ADDbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDbutton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ADDbutton.Location = new System.Drawing.Point(29, 187);
            this.ADDbutton.Name = "ADDbutton";
            this.ADDbutton.Size = new System.Drawing.Size(89, 23);
            this.ADDbutton.TabIndex = 4;
            this.ADDbutton.Text = "Addition";
            this.ADDbutton.UseVisualStyleBackColor = false;
            this.ADDbutton.Click += new System.EventHandler(this.ADDbutton_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(505, 320);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.Divbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MULTbutton);
            this.Controls.Add(this.SUBbutton);
            this.Controls.Add(this.ADDbutton);
            this.Controls.Add(this.SecondNumLabel);
            this.Controls.Add(this.SecondNumTextBox);
            this.Controls.Add(this.FirstNumberLabel);
            this.Controls.Add(this.FirstNumTextBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNumTextBox;
        private System.Windows.Forms.Label FirstNumberLabel;
        private System.Windows.Forms.TextBox SecondNumTextBox;
        private System.Windows.Forms.Label SecondNumLabel;
        private System.Windows.Forms.Button SUBbutton;
        private System.Windows.Forms.Button MULTbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Divbutton;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ADDbutton;
    }
}

