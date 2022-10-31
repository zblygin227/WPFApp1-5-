using System.Windows;
using Lib_5;

namespace WPFApp1_5_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NumK.Focus();
        }

        private void CloseProgram_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void taskShowed_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчки: \nЗадание: Вычислить сумму целых случайных чисел, распределенных в диапазоне от -7 до 3, пока эта сумма не превышает некоторого числа K. Вывести на экран сгенерированные числа, значение суммы, и количество сгенерированных чисел.", "Номер вариант №8");
        }
        //комментарий
        private void NumK_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            int.TryParse(NumK.Text, out int K);
            SumOfNum.Text = $"{LibClass.SumOfNums(out string generNums, out int countGen, K)}";
            GenNums.Text = generNums;
            CountGenNums.Text = $"{countGen}";
        }
    }
}
