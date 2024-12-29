namespace WinFormsApp1 
{
    partial class Info
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
            lblAuthorInfo = new Label();
            SuspendLayout();
            // 
            // lblAuthorInfo
            // 
            lblAuthorInfo.AutoSize = true;
            lblAuthorInfo.BackColor = SystemColors.Control;
            lblAuthorInfo.Location = new Point(15, 88);
            lblAuthorInfo.Name = "lblAuthorInfo";
            lblAuthorInfo.Size = new Size(471, 20);
            lblAuthorInfo.TabIndex = 0;
            lblAuthorInfo.Text = "ФИО: Пересыпкин Евгений Дмитриевич Группа: 6101-090301D";
            lblAuthorInfo.Click += lblAuthorInfo_Click;
            // 
            // Info
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 224, 160);
            ClientSize = new Size(498, 224);
            Controls.Add(lblAuthorInfo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Info";
            Text = "Информация об авторе";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblAuthorInfo;
    }
}
