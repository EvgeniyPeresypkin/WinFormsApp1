using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class GuessCorrectAnswer : Form
    {
        private int attempts;
        private bool gameStarted = false;

        public GuessCorrectAnswer()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            gameStarted = false;
            numAttempts.Enabled = true; // Разблокировать изменение количества попыток до начала игры
            attempts = (int)numAttempts.Value; // Начальное количество попыток
            UpdateAttemptsLabel();
        }

        private void UpdateAttemptsLabel()
        {
            lblAttempts.Text = $"Попытки: {attempts}";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!gameStarted)
            {
                attempts = (int)numAttempts.Value; // Устанавливаем количество попыток при старте игры
                gameStarted = true;
                numAttempts.Enabled = false; // Заблокировать изменение количества попыток после старта игры
            }

            try
            {
                // Парсинг ввода пользователя
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double input = double.Parse(txtInput.Text);

                // Блокировка полей a и b после первого ввода
                txtA.Enabled = false;
                txtB.Enabled = false;

                // Логика вычисления правильного ответа
                double expectedValue = Math.Log(Math.Sqrt(b + Math.Sin(a)) / Math.Cos(3 * a), b);
                expectedValue = Math.Round(expectedValue, 2); // Округление до 2 знаков после запятой

                // Проверка правильности ответа
                if (Math.Abs(input - expectedValue) < 0.001)
                {
                    MessageBox.Show("Правильный ответ!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetGame();
                }
                else
                {
                    attempts--;
                    if (attempts > 0)
                    {
                        MessageBox.Show($"Неправильный ответ. Попробуйте снова. Осталось попыток: {attempts}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        UpdateAttemptsLabel();
                    }
                    else
                    {
                        MessageBox.Show($"Игра окончена. Правильный ответ: {expectedValue}", "Конец игры", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetGame();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка: Введите корректные числовые значения для A, B и ответа.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetGame()
        {
            txtA.Enabled = true;
            txtB.Enabled = true;
            txtInput.Text = "";
            txtA.Text = "";
            txtB.Text = "";
            gameStarted = false;
            InitializeGame();
        }
    }
}
