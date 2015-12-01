using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace VocabularyTest
{
    /// <summary>
    /// Interaction logic for Vocabulary.xaml
    /// </summary>
    public partial class Vocabulary : Window
    {
        //call MainWindow
        MainWindow myMainWindow;

        //instance variables
        public string[] vocabFinnishWords;
        public string[] vocabEnglishWords;

        public Vocabulary(MainWindow main)
        {
            InitializeComponent();
            vocabFinnishWords = main.finnishWords;
            vocabEnglishWords = main.englishWords;
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            lsbWords.Items.Clear();
            if (rdbFinEng.IsChecked == true)
            {
                for (int i = 0; i < vocabFinnishWords.Length; i++)
                {
                    lsbWords.Items.Add(vocabFinnishWords[i]);
                    lsbWords.Items.Add(vocabEnglishWords[i]);
                }
            }
            else
            {
                for (int i = 0; i < vocabFinnishWords.Length; i++)
                {
                    lsbWords.Items.Add(vocabEnglishWords[i]);
                    lsbWords.Items.Add(vocabFinnishWords[i]);
                }
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
