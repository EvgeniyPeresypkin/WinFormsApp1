using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ArraySorter : Form
    {
        private int[] array;

        public ArraySorter()
        {
            InitializeComponent();
        }

        private void btnDefaultArray_Click(object sender, EventArgs e)
        {
            // Создание массива по умолчанию
            array = new int[10];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(100);
            }
            UpdateArrayDisplay();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Создание массива вручную заданного размера
            if (int.TryParse(txtArraySize.Text, out int size))
            {
                // Проверка на корректность размера массива
                if (size <= 0)
                {
                    MessageBox.Show("Размер массива должен быть больше 0.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                array = new int[size];
                Random rand = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(100);
                }
                UpdateArrayDisplay();
            }
            else
            {
                MessageBox.Show("Введите корректное числовое значение для размера массива.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            // Сортировка массива
            if (array == null || array.Length == 0)
            {
                MessageBox.Show("Массив пуст. Создайте или загрузите массив перед сортировкой.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ArrayOperations.BubbleSort(array);
            UpdateArrayDisplay();
        }

        private void btnFindMax_Click(object sender, EventArgs e)
        {
            // Нахождение максимального значения и выделение его цветом
            if (array == null || array.Length == 0)
            {
                MessageBox.Show("Массив пуст. Создайте или загрузите массив перед поиском максимального значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int max = ArrayOperations.FindMax(array);
            MessageBox.Show($"Максимальное значение: {max}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HighlightCell(max, Color.Red);
        }

        private void btnFindMin_Click(object sender, EventArgs e)
        {
            // Нахождение минимального значения и выделение его цветом
            if (array == null || array.Length == 0)
            {
                MessageBox.Show("Массив пуст. Создайте или загрузите массив перед поиском минимального значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int min = ArrayOperations.FindMin(array);
            MessageBox.Show($"Минимальное значение: {min}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HighlightCell(min, Color.Blue);
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            // Нахождение среднего арифметического значения
            if (array == null || array.Length == 0)
            {
                MessageBox.Show("Массив пуст. Создайте или загрузите массив перед вычислением среднего.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double average = ArrayOperations.Average(array);
            MessageBox.Show($"Среднее арифметическое значение: {average}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void HighlightCell(int value, Color color)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    dgvArray.Rows[0].Cells[i].Style.BackColor = color;
                }
            }
        }

        private void UpdateArrayDisplay()
        {
            // Обновление отображения массива в DataGridView
            dgvArray.Rows.Clear();
            dgvArray.ColumnCount = array.Length;
            dgvArray.RowCount = 1;
            for (int i = 0; i < array.Length; i++)
            {
                dgvArray.Columns[i].Name = i.ToString();
                dgvArray.Rows[0].Cells[i].Value = array[i].ToString();
                dgvArray.Rows[0].Cells[i].Style.BackColor = Color.White; // Сброс цвета
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
