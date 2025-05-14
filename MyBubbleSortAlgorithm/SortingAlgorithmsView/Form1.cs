using Library;

namespace SortingAlgorithmsView
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// ќбъ€вл€ем переменную алгоритма, которую инициализируем класса BubbleSort
        /// </summary>
        AlgorithmBase<int> algorithm = new BubbleSortAlgorithm<int>();

        /// <summary>
        /// Form constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            inputLabel.Text = string.Empty;
            resultLabel.Text = string.Empty;
        }

        /// <summary>
        /// Add number to collection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxNumber.Text, out int value))
            {
                algorithm.Elements.Add(value);
                inputLabel.Text += value + " ";
                textBoxNumber.Clear();
                textBoxNumber.Focus();
            }
        }

        /// <summary>
        /// Running sort algorithm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = string.Empty;
            algorithm.Sort();
            foreach(int value in algorithm.Elements)
            {
                resultLabel.Text += value + " ";
            }
        }
    }
}