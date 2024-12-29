namespace WinFormsApp1
{
    partial class TreasureHuntGame
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
            dgvGrid = new DataGridView();
            btnStart = new Button();
            numTraps = new NumericUpDown();
            lblTraps = new Label();
            lblTreasures = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTraps).BeginInit();
            SuspendLayout();
            // 
            // dgvGrid
            // 
            dgvGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrid.Location = new Point(537, 148);
            dgvGrid.Margin = new Padding(3, 4, 3, 4);
            dgvGrid.Name = "dgvGrid";
            dgvGrid.RowHeadersWidth = 51;
            dgvGrid.RowTemplate.Height = 28;
            dgvGrid.Size = new Size(327, 301);
            dgvGrid.TabIndex = 0;
            dgvGrid.CellClick += dgvGrid_CellClick;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(635, 102);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(112, 38);
            btnStart.TabIndex = 1;
            btnStart.Text = "Начать";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // numTraps
            // 
            numTraps.Location = new Point(735, 28);
            numTraps.Margin = new Padding(3, 4, 3, 4);
            numTraps.Maximum = new decimal(new int[] { 33, 0, 0, 0 });
            numTraps.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numTraps.Name = "numTraps";
            numTraps.Size = new Size(112, 27);
            numTraps.TabIndex = 2;
            numTraps.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numTraps.ValueChanged += numTraps_ValueChanged;
            numTraps.KeyPress += numTraps_KeyPress;
            // 
            // lblTraps
            // 
            lblTraps.AutoSize = true;
            lblTraps.Location = new Point(492, 30);
            lblTraps.Name = "lblTraps";
            lblTraps.Size = new Size(163, 20);
            lblTraps.TabIndex = 3;
            lblTraps.Text = "Количество ловушек";
            // 
            // lblTreasures
            // 
            lblTreasures.AutoSize = true;
            lblTreasures.Location = new Point(252, 595);
            lblTreasures.Name = "lblTreasures";
            lblTreasures.Size = new Size(0, 20);
            lblTreasures.TabIndex = 4;
            // 
            // TreasureHuntGame
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 224, 160);
            ClientSize = new Size(1312, 650);
            Controls.Add(lblTreasures);
            Controls.Add(lblTraps);
            Controls.Add(numTraps);
            Controls.Add(btnStart);
            Controls.Add(dgvGrid);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TreasureHuntGame";
            Text = "Игра с сокровищами и ловушками";
            ((System.ComponentModel.ISupportInitialize)dgvGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTraps).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvGrid;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numTraps;
        private System.Windows.Forms.Label lblTraps;
        private System.Windows.Forms.Label lblTreasures;
    }
}
