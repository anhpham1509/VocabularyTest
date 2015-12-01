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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VocabularyTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //VOCABULARY is given here in arrays
        public string[] finnishWords = { "ruoanlaitto", "tanssi", "draama", "piirustus", "pokeri", "lukeminen", "laulaminen", "jooga",
                                    "kirjoittaminen", "patikointi", "valokuvaus", "nyrkkeily","keskusteleminen", "matkustaminen", "ostokset",
                                    "ammunta", "kalastus", "ajaminen", "pyöräily", "maaginen", "musiikki", "elokuva", "leivonta",
                                    "tietokonepeli", "sauna", "palapeli", "antiquing", "kolikon kerätä", "puutarhanhoito", "yo-yoing"};

        public string[] englishWords = { "cooking", "dancing", "drama", "drawing", "poker", "reading", "singing", "yoga", "writing", "hiking", "photography",
                                "boxing", "chatting", "traveling", "shopping", "shooting", "fishing", "driving", "cycling", "magic", "music", "movie",
                                "baking", "computer game", "sauna", "puzzle", "antiquing", "coin collecting", "gardening", "yo-yoing"
                               };

        public bool[] markWords = new bool[60];

        //instance variable
        int wordAskedIndex = -1;
        int countWords = 0;
        int countRight = 0;
        int countWrong = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            //Initial Bars
            lblRightBar.Width = 1;
            lblWrongBar.Width = 1;
            countRight = 0;
            countWrong = 0;

            updateResults();
            btnCheck.IsEnabled = true;

            for (int i = 0; i <= finnishWords.Length; i++)
                markWords[i] = true;

            if (rdb10.IsChecked == true)
            {
                countWords = 10; 
            }

            if (rdbAll.IsChecked == true)
            {
                countWords = finnishWords.Length;
            }

            if (rdbRepeat.IsChecked == true)
            {
                countWords = finnishWords.Length;
            }
            ShowNewQuestion();
        }

        private int randomNumber(){ //Select a random number
            int randomNum = 0;
            bool isDone = false;
            Random r;
            while (isDone == false)
            {
                r = new Random();
                randomNum = r.Next(0, finnishWords.Length);
                if (markWords[randomNum] == true)
                {
                    markWords[randomNum] = false;
                    isDone = true;
                }
            }
            return randomNum;
        }

        private void ShowNewQuestion()
        {
            wordAskedIndex = randomNumber();
            txtWord2.Text = "";

            if (rdbEngFin.IsChecked == true) //English-Finnish
            {
                txtWord1.Text = englishWords[wordAskedIndex];
            }
            
            if (rdbFinEng.IsChecked == true) //Finnish-English
            {
                txtWord1.Text = finnishWords[wordAskedIndex];
            }
            
            if (rdbMixed.IsChecked == true) //Mixed Language
            {
                Random r = new Random(); // Random Lang
                int randomLang = r.Next(0, 10);
                if (randomLang <= 5) //English-Finnish Mode
                {
                    txtWord1.Text = englishWords[wordAskedIndex];
                }
                else //Finnish-English Mode
                {
                    txtWord1.Text = finnishWords[wordAskedIndex];
                }
                //choose which one to display
            }
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            string correctWord;
            bool checkWord;

            countWords--;

            if (rdbEngFin.IsChecked == true) //English-Finnish Mode
            {
                correctWord = finnishWords[wordAskedIndex];
                checkWord = checkAnswers(correctWord);
                notification(checkWord,correctWord);
            }
            if (rdbFinEng.IsChecked == true) //Finnish-English Mode
            {
                correctWord = englishWords[wordAskedIndex];
                checkWord = checkAnswers(correctWord);
                notification(checkWord, correctWord);
            }
                
            if (rdbMixed.IsChecked == true) //Mixed Mode
            {
                if ((txtWord1.Text).Equals(finnishWords[wordAskedIndex]))
                {
                    correctWord = englishWords[wordAskedIndex]; 
                }
                else
                {
                    correctWord = finnishWords[wordAskedIndex]; 
                }
                checkWord = checkAnswers(correctWord);
                notification(checkWord, correctWord);
            }

            if (countWords > 0)
            {
                ShowNewQuestion();
            }
            else
            {
                testOver();
            }
        }

        private void notification(bool check, string correctWord)
        {
            if (check)
            {
                countRight++;
                lblRightBar.Width += 10;
                MessageBox.Show("Right!");
            }
            else
            {
                countWrong++;
                lblWrongBar.Width += 10;
                if (rdbRepeat.IsChecked == true)
                {
                    markWords[wordAskedIndex] = true;
                    countWords++;
                }
                MessageBox.Show("Wrong! The answer is " + correctWord, "Error", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
            updateResults();
        }

        private void updateResults()
        {
            txbRight.Text = "Right: " + countRight;
            txbWrong.Text = "Wrong: " + countWrong;
        }
        private void testOver()
        {
            double grade;
            MessageBox.Show("Test is over!");
            grade = (countRight*5)/(countRight+countWrong);
            grade = System.Math.Round(grade, MidpointRounding.AwayFromZero);
            MessageBox.Show("Grade is " + grade);
            btnCheck.IsEnabled = false;
            btnStart.IsEnabled = true;
        }

        private bool checkAnswers(string word)
        {
            if ((txtWord2.Text).Equals(word))
                return true;
            else
                return false;
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            Vocabulary v = new Vocabulary(main);
            v.ShowDialog();
        }

        public Button AcceptButton { get; set; }
    }
}
