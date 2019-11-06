using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CipherGenerator
{

    public partial class VizhenerCipher : Form
    {
        public VizhenerCipher()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            if (textBoxKeyWord.Text.Length > 0)
            {
                string s;

                StreamReader sr = new StreamReader("Ciph3\\in.txt");
                StreamWriter sw = new StreamWriter("Ciph3\\out.txt");

                while (!sr.EndOfStream)
                {
                    s = sr.ReadLine();
                    string cipherout = new Vizhener().Encode(s, textBoxKeyWord.Text);
                    sw.WriteLine(cipherout);
                    textBox1.Text += cipherout;
                }
                sr.Close();
                sw.Close();
            }
            else
                MessageBox.Show("Введите ключевое слово!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = null;

            StreamReader sr = new StreamReader("Ciph3\\in.txt");


            while (!sr.EndOfStream)
            {
                s += sr.ReadLine();
            }
            sr.Close();

            var IL = s.Length;
            var IK = textBoxKeyWord.Text.Length;
            var nad = IL - IK;
            for (int i = 0; i < nad; i++)
            {
                try
                {
                    textBoxKeyWord.Text += s[i];
                }
                catch
                {
                    nad = nad - i;
                    i = 0;
                }
            }
                /*obj.Generate_Pseudorandom_KeyWord(10, new Random().Next(10));//Second - pseudorandom*/
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            if (textBoxKeyWord.Text.Length > 0)
            {
                string s;

                StreamReader sr = new StreamReader("Ciph3\\out.txt");
                StreamWriter sw = new StreamWriter("Ciph3\\outAfterDecode.txt");

                while (!sr.EndOfStream)
                {
                    s = sr.ReadLine();
                    string cipherout = new Vizhener().Decode(s, textBoxKeyWord.Text);
                    sw.WriteLine(cipherout);
                    textBox1.Text += cipherout;
                }

                sr.Close();
                sw.Close();
            }
            else
                MessageBox.Show("Введите ключевое слово!");
        }
    }
    class Vizhener
    {
        static char[] characters = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
                                                'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
                                                'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ',
                                                'Э', 'Ю', 'Я', ' ', '1', '2', '3', '4', '5', '6', '7',
                                                '8', '9', '0' };
        int N = characters.Length;
        public string Encode(string input, string keyword)
        {
            input = input.ToUpper();
            keyword = keyword.ToUpper();


            

            string result = "";

            int keyword_index = 0;

            foreach (char symbol in input)
            {
                //ci = (pi+ku)modN
                int c = (Array.IndexOf(characters, symbol) +
                    Array.IndexOf(characters, keyword[keyword_index])) % N;

                result += characters[c];

                keyword_index++;

                if ((keyword_index + 1) == keyword.Length)
                    keyword_index = 0;
            }

            return result;
        }

        public string Decode(string input, string keyword)
        {
            //pi=(ci+N-ki)
            input = input.ToUpper();
            keyword = keyword.ToUpper();
            
            string result = "";

            int keyword_index = 0;

            foreach (char symbol in input)
            {
                int p = (Array.IndexOf(characters, symbol) + N -
                    Array.IndexOf(characters, keyword[keyword_index])) % N;

                result += characters[p];

                keyword_index++;

                if ((keyword_index + 1) == keyword.Length)
                    keyword_index = 0;
            }

            return result;
        }


        public string Generate_Pseudorandom_KeyWord(int length, int startSeed)
        {
            Random rand = new Random(startSeed);

            string result = "";

            for (int i = 0; i < length; i++)
                result += characters[rand.Next(0, characters.Length)];

            return result;
        }
    }
}
