using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Async_Await_usage___2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var task = CountCharacters();
            int countWords = await task;
            MessageBox.Show(countWords.ToString());

        }

        private async Task<int> CountCharacters()
        {
            int countWords = 0;
            using (StreamReader reader = new StreamReader("E:\\0 C# IMP\\4.txt"))
            {
                string content = reader.ReadToEnd();
                countWords = content.Length;
                await Task.Delay(2000);
            }
            return countWords;
        }
    }
}
