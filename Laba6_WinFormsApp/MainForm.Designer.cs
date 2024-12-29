namespace WinFormsApp1
{
    partial class MainForm
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
            GuessButton = new Button();
            ArrayButton = new Button();
            GameButton = new Button();
            InfoButton = new Button();
            SuspendLayout();
            // 
            // GuessButton
            // 
            GuessButton.Location = new Point(165, 33);
            GuessButton.Margin = new Padding(3, 4, 3, 4);
            GuessButton.Name = "GuessButton";
            GuessButton.Size = new Size(225, 50);
            GuessButton.TabIndex = 0;
            GuessButton.Text = "Игра по отгадыванию";
            GuessButton.UseVisualStyleBackColor = true;
            GuessButton.Click += GuessButton_Click;
            // 
            // ArrayButton
            // 
            ArrayButton.Location = new Point(165, 107);
            ArrayButton.Margin = new Padding(3, 4, 3, 4);
            ArrayButton.Name = "ArrayButton";
            ArrayButton.Size = new Size(225, 50);
            ArrayButton.TabIndex = 1;
            ArrayButton.Text = "Работа с массивами";
            ArrayButton.UseVisualStyleBackColor = true;
            ArrayButton.Click += ArrayButton_Click;
            // 
            // GameButton
            // 
            GameButton.Location = new Point(165, 180);
            GameButton.Margin = new Padding(3, 4, 3, 4);
            GameButton.Name = "GameButton";
            GameButton.Size = new Size(225, 50);
            GameButton.TabIndex = 2;
            GameButton.Text = "Игра";
            GameButton.UseVisualStyleBackColor = true;
            GameButton.Click += GameButton_Click;
            // 
            // InfoButton
            // 
            InfoButton.Location = new Point(165, 247);
            InfoButton.Margin = new Padding(3, 4, 3, 4);
            InfoButton.Name = "InfoButton";
            InfoButton.Size = new Size(225, 50);
            InfoButton.TabIndex = 3;
            InfoButton.Text = "Информация об авторе";
            InfoButton.UseVisualStyleBackColor = true;
            InfoButton.Click += InfoButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 224, 160);
            ClientSize = new Size(573, 343);
            Controls.Add(GuessButton);
            Controls.Add(ArrayButton);
            Controls.Add(GameButton);
            Controls.Add(InfoButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Main Form";
            FormClosing += FormClosing_Event;
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button GuessButton;
        private System.Windows.Forms.Button ArrayButton;
        private System.Windows.Forms.Button GameButton;
        private System.Windows.Forms.Button InfoButton;
    }
}
