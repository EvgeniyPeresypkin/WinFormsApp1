
namespace WinFormsApp1
{
    partial class ArraySorter
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblArraySize;
        private System.Windows.Forms.TextBox txtArraySize;
        private System.Windows.Forms.Button btnDefaultArray;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnFindMax;
        private System.Windows.Forms.Button btnFindMin;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.DataGridView dgvArray;

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
            lblArraySize = new Label();
            txtArraySize = new TextBox();
            btnDefaultArray = new Button();
            btnGenerate = new Button();
            btnSort = new Button();
            btnFindMax = new Button();
            btnFindMin = new Button();
            btnAverage = new Button();
            dgvArray = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvArray).BeginInit();
            SuspendLayout();
            // 
            // lblArraySize
            // 
            lblArraySize.AutoSize = true;
            lblArraySize.Location = new Point(422, 22);
            lblArraySize.Margin = new Padding(4, 0, 4, 0);
            lblArraySize.Name = "lblArraySize";
            lblArraySize.Size = new Size(130, 20);
            lblArraySize.TabIndex = 0;
            lblArraySize.Text = "Размер массива:";
            // 
            // txtArraySize
            // 
            txtArraySize.Location = new Point(576, 15);
            txtArraySize.Margin = new Padding(4);
            txtArraySize.Name = "txtArraySize";
            txtArraySize.Size = new Size(112, 27);
            txtArraySize.TabIndex = 1;
            // 
            // btnDefaultArray
            // 
            btnDefaultArray.Location = new Point(422, 145);
            btnDefaultArray.Margin = new Padding(4);
            btnDefaultArray.Name = "btnDefaultArray";
            btnDefaultArray.Size = new Size(235, 37);
            btnDefaultArray.TabIndex = 2;
            btnDefaultArray.Text = "Массив по умолчанию";
            btnDefaultArray.UseVisualStyleBackColor = true;
            btnDefaultArray.Click += btnDefaultArray_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(422, 190);
            btnGenerate.Margin = new Padding(4);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(235, 37);
            btnGenerate.TabIndex = 3;
            btnGenerate.Text = "Создать массив вручную";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(422, 235);
            btnSort.Margin = new Padding(4);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(235, 37);
            btnSort.TabIndex = 4;
            btnSort.Text = "Сортировка";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // btnFindMax
            // 
            btnFindMax.Location = new Point(422, 280);
            btnFindMax.Margin = new Padding(4);
            btnFindMax.Name = "btnFindMax";
            btnFindMax.Size = new Size(235, 37);
            btnFindMax.TabIndex = 5;
            btnFindMax.Text = "Макс.";
            btnFindMax.UseVisualStyleBackColor = true;
            btnFindMax.Click += btnFindMax_Click;
            // 
            // btnFindMin
            // 
            btnFindMin.Location = new Point(422, 325);
            btnFindMin.Margin = new Padding(4);
            btnFindMin.Name = "btnFindMin";
            btnFindMin.Size = new Size(235, 37);
            btnFindMin.TabIndex = 6;
            btnFindMin.Text = "Мин.";
            btnFindMin.UseVisualStyleBackColor = true;
            btnFindMin.Click += btnFindMin_Click;
            // 
            // btnAverage
            // 
            btnAverage.Location = new Point(422, 370);
            btnAverage.Margin = new Padding(4);
            btnAverage.Name = "btnAverage";
            btnAverage.Size = new Size(235, 37);
            btnAverage.TabIndex = 7;
            btnAverage.Text = "Среднее арифметическое";
            btnAverage.UseVisualStyleBackColor = true;
            btnAverage.Click += btnAverage_Click;
            // 
            // dgvArray
            // 
            dgvArray.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArray.Location = new Point(422, 55);
            dgvArray.Margin = new Padding(4);
            dgvArray.Name = "dgvArray";
            dgvArray.RowHeadersWidth = 51;
            dgvArray.RowTemplate.Height = 28;
            dgvArray.Size = new Size(654, 82);
            dgvArray.TabIndex = 8;
            // 
            // ArraySorter
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 224, 160);
            ClientSize = new Size(1330, 563);
            Controls.Add(dgvArray);
            Controls.Add(btnAverage);
            Controls.Add(btnFindMin);
            Controls.Add(btnFindMax);
            Controls.Add(btnSort);
            Controls.Add(btnGenerate);
            Controls.Add(btnDefaultArray);
            Controls.Add(txtArraySize);
            Controls.Add(lblArraySize);
            Margin = new Padding(4);
            Name = "ArraySorter";
            Text = "Работа с одномерными массивами";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArray).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}