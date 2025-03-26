using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Microsoft.Win32;

namespace TextEditor
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void FontSize_Changed(object sender, SelectionChangedEventArgs e)
        {
            if (ПТ.SelectedItem is ComboBoxItem selectedItem)
            {
                txtEditor.FontSize = Convert.ToDouble(selectedItem.Content);
            }
        }
        private void FontFamily_Changed(object sender, SelectionChangedEventArgs e)
        {
            if (Arial.SelectedItem is ComboBoxItem selectedItem)
            {
                txtEditor.FontFamily = new FontFamily(selectedItem.Content.ToString());
            }
        }

        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog() == true)
            {
                txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void SaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"
            };
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, txtEditor.Text);
            }
        }

        private void ClearText_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.Clear();
        }

        private void txtEditor_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
