using System;
using System.Windows;

namespace WindowsPresentationFoundation
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }        

        private void SplitString(object sender, RoutedEventArgs e)
        {            
            string userInput = SplitStringTextBox.Text;           

            string[] stringSplited = userInput.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);            

            foreach (string word in stringSplited)
            {
                SplitStringListBox.Items.Add(word);
            }            
        }

        private void ClearSplitStringTextBox(object sender, RoutedEventArgs e)
        {
            SplitStringTextBox.Text = String.Empty;
        }

        private void ClearListBox(object sender, RoutedEventArgs e)
        {
            SplitStringListBox.Items.Clear();
        }

        private void InvertString(object sender, RoutedEventArgs e)
        {
            string userInput = InvertStringTextBox.Text;

            string[] stringSplited = userInput.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(stringSplited);

            string stringInverted = String.Empty;            

            foreach (string word in stringSplited)
            {
                stringInverted += $"{word} ";

                InvertStringTextBlock.Text = $"{stringInverted}";                              
            }            
        }

        private void ClearInvertStringTextBox(object sender, RoutedEventArgs e)
        {
            InvertStringTextBox.Text = String.Empty;
        }

        private void ClearInvertStringLabel(object sender, RoutedEventArgs e)
        {
            InvertStringTextBlock.Text = $"результат Получите";
        }
    }
}
