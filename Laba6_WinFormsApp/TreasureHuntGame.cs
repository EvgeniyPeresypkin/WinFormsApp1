using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class TreasureHuntGame : Form
    {
        private const int gridSize = 10;
        private int[,] grid = new int[gridSize, gridSize];
        private bool[,] visited = new bool[gridSize, gridSize];
        private Random random = new Random();
        private int trapCount;
        private int treasureCount;
        private bool gameStarted = false;

        public TreasureHuntGame()
        {
            InitializeComponent();
            InitializeGridDisplay();
        }

        private void InitializeGame()
        {
            trapCount = (int)numTraps.Value;

            // Проверка на допустимый диапазон для ловушек
            if (trapCount < 1 || trapCount > 33)
            {
                MessageBox.Show("Ошибка: Количество ловушек должно быть в диапазоне от 1 до 33.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Сбросить значение в пределах диапазона
                if (trapCount < 1)
                    numTraps.Value = 1;
                else
                    numTraps.Value = 33;

                return; // Не продолжаем, если введено некорректное значение
            }

            // Запретить изменение количества ловушек после начала игры
            numTraps.Enabled = false;

            // Количество сокровищ в 2 раза больше
            treasureCount = trapCount * 2;

            // Очистить сетку и посещённые ячейки
            Array.Clear(grid, 0, grid.Length);
            Array.Clear(visited, 0, visited.Length);

            // Разместить сокровища
            PlaceItems(treasureCount, 1);

            // Разместить ловушки
            PlaceItems(trapCount, -1);

            UpdateGridDisplay();
            gameStarted = true; // Отметить, что игра началась
        }

        private void PlaceItems(int count, int item)
        {
            for (int i = 0; i < count; i++)
            {
                int x, y;
                do
                {
                    x = random.Next(gridSize);
                    y = random.Next(gridSize);
                }
                while (grid[x, y] != 0);

                grid[x, y] = item;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            trapCount = (int)numTraps.Value;
            InitializeGame();
        }

        private void dgvGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!gameStarted)
            {
                MessageBox.Show("Пожалуйста, начните игру перед тем, как нажимать на клетки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int x = e.ColumnIndex;
            int y = e.RowIndex;

            ProcessCell(x, y);
        }

        private void ProcessCell(int x, int y)
        {
            if (visited[x, y])
            {
                MessageBox.Show("Эту клетку уже проверяли. Выберите другую клетку.");
                return;
            }

            visited[x, y] = true;

            if (grid[x, y] == 1)
            {
                MessageBox.Show("Вы нашли сокровище!");
                grid[x, y] = 0; // Отметить как найденное
            }
            else if (grid[x, y] == -1)
            {
                MessageBox.Show("Вы попали в ловушку! Игра окончена.");
                InitializeGame(); // Перезапуск игры
            }
            else
            {
                MessageBox.Show("Пустая клетка. Продолжайте поиски!");
            }

            UpdateGridDisplay();
        }

        private void InitializeGridDisplay()
        {
            dgvGrid.ColumnCount = gridSize;
            dgvGrid.RowCount = gridSize;
            for (int i = 0; i < gridSize; i++)
            {
                dgvGrid.Columns[i].Name = ((char)('A' + i)).ToString();
                dgvGrid.Columns[i].Width = 20;
            }

            for (int i = 0; i < gridSize; i++)
            {
                dgvGrid.Rows[i].Height = 20;
            }
            UpdateGridDisplay();
        }

        private void UpdateGridDisplay()
        {
            for (int x = 0; x < gridSize; x++)
            {
                for (int y = 0; y < gridSize; y++)
                {
                    if (visited[x, y])
                    {
                        if (grid[x, y] == 0)
                        {
                            dgvGrid.Rows[y].Cells[x].Value = "П"; // Пустая клетка
                        }
                        else if (grid[x, y] == 1)
                        {
                            dgvGrid.Rows[y].Cells[x].Value = "С"; // Сокровище найдено
                        }
                        else if (grid[x, y] == -1)
                        {
                            dgvGrid.Rows[y].Cells[x].Value = "Л"; // Ловушка найдена
                        }
                    }
                    else
                    {
                        dgvGrid.Rows[y].Cells[x].Value = "";
                    }
                }
            }
        }

        private void numTraps_ValueChanged(object sender, EventArgs e)
        {
            trapCount = (int)numTraps.Value;

            // Если количество ловушек меньше 1, устанавливаем 1
            if (trapCount < 1)
            {
                numTraps.Value = 1;
            }
            // Если количество ловушек больше 33, устанавливаем 33
            else if (trapCount > 33)
            {
                numTraps.Value = 33;
            }

            lblTreasures.Text = $"Количество сокровищ: {trapCount * 2}";
        }

        // Метод, который запрещает ввод с клавиатуры
        private void numTraps_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;  // Заблокировать ввод с клавиатуры
        }
    }
}

