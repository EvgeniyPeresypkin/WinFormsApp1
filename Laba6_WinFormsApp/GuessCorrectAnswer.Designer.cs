namespace WinFormsApp1
{
    partial class GuessCorrectAnswer
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblFormula = new Label();
            txtInput = new TextBox();
            btnSubmit = new Button();
            lblA = new Label();
            lblB = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            numAttempts = new NumericUpDown();
            lblAttempts = new Label();
            ((System.ComponentModel.ISupportInitialize)numAttempts).BeginInit();
            SuspendLayout();
            // 
            // lblFormula
            // 
            lblFormula.AutoSize = true;
            lblFormula.Location = new Point(194, 9);
            lblFormula.Name = "lblFormula";
            lblFormula.Size = new Size(379, 20);
            lblFormula.TabIndex = 0;
            lblFormula.Text = "Формула: Math.Log(Math.Sqrt(b + sinA) / cos3A, b)";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(210, 125);
            txtInput.Margin = new Padding(3, 4, 3, 4);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(337, 27);
            txtInput.TabIndex = 1;
            txtInput.Text = "Ответ:";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(210, 175);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 38);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Проверить";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(210, 40);
            lblA.Name = "lblA";
            lblA.Size = new Size(24, 20);
            lblA.TabIndex = 4;
            lblA.Text = "A:";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(211, 86);
            lblB.Name = "lblB";
            lblB.Size = new Size(23, 20);
            lblB.TabIndex = 6;
            lblB.Text = "B:";
            // 
            // txtA
            // 
            txtA.Location = new Point(271, 40);
            txtA.Margin = new Padding(3, 4, 3, 4);
            txtA.Name = "txtA";
            txtA.Size = new Size(112, 27);
            txtA.TabIndex = 5;
            // 
            // txtB
            // 
            txtB.Location = new Point(271, 84);
            txtB.Margin = new Padding(3, 4, 3, 4);
            txtB.Name = "txtB";
            txtB.Size = new Size(112, 27);
            txtB.TabIndex = 7;
            // 
            // numAttempts
            // 
            numAttempts.Location = new Point(345, 175);
            numAttempts.Margin = new Padding(3, 4, 3, 4);
            numAttempts.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAttempts.Name = "numAttempts";
            numAttempts.Size = new Size(112, 27);
            numAttempts.TabIndex = 3;
            numAttempts.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblAttempts
            // 
            lblAttempts.AutoSize = true;
            lblAttempts.Location = new Point(463, 175);
            lblAttempts.Name = "lblAttempts";
            lblAttempts.Size = new Size(91, 20);
            lblAttempts.TabIndex = 8;
            lblAttempts.Text = "Попытки: 3";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 224, 160);
            ClientSize = new Size(734, 330);
            Controls.Add(lblAttempts);
            Controls.Add(txtB);
            Controls.Add(lblB);
            Controls.Add(txtA);
            Controls.Add(lblA);
            Controls.Add(numAttempts);
            Controls.Add(btnSubmit);
            Controls.Add(txtInput);
            Controls.Add(lblFormula);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Игра по отгадыванию функции";
            ((System.ComponentModel.ISupportInitialize)numAttempts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.NumericUpDown numAttempts;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblAttempts;
    }
}
