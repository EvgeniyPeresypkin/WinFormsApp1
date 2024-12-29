using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FormClosing_Event(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы действительно хотите выйти?", "Выход из программы", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = !(res == DialogResult.Yes);
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            GuessCorrectAnswer guessForm = new GuessCorrectAnswer();
            guessForm.ShowDialog();
        }

        private void ArrayButton_Click(object sender, EventArgs e)
        {
            ArraySorter arrayForm = new ArraySorter();
            arrayForm.ShowDialog();
        }

        private void GameButton_Click(object sender, EventArgs e)
        {
            TreasureHuntGame gameForm = new TreasureHuntGame();
            gameForm.ShowDialog();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            Info infoForm = new Info();
            infoForm.ShowDialog();
        }
    }
}
