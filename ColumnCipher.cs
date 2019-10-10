using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CipherGenerator
{
    public partial class ColumnCipher : Form
    {
        public ColumnCipher()
        {
            InitializeComponent();
        }

        public static void DisplayIntoDataGrid(string[,] array, DataGridView dataGridView)
        {
            //указываем контроллу в который пишем количество строк и столбцов
            dataGridView.RowCount = array.GetLength(0);
            dataGridView.ColumnCount = array.GetLength(1);
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    dataGridView.Columns[j].Width = 20;
                    //пишем значения из массива в ячейки контролла
                    dataGridView.Rows[i].Cells[j].Value = array[i, j];
                }
            }
        }
        

        public static string[,] SortArray(string[,] array, int rowCount)
        {
            //Смена столбца А, на столбец B
            string buff;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = i + 1; j < array.GetLength(1); j++)
                {
                    if (Convert.ToInt32(array[1, i]) > Convert.ToInt32(array[1, j]))
                    {
                        for (int Row = 0; Row < rowCount; Row++)
                        {
                            buff = array[Row, i];
                            array[Row, i] = array[Row, j];
                            array[Row, j] = buff;
                        }
                    }
                }
            }
            return array;
        }

        public static string[,] EncodeSortAray(string[,] array, int rowCount, string CipherKey)
        {
            //eslu trablu, to key vsegda dolzhen but lowercase
            string buff;
            string tempCipherKey = CipherKey;
            for (int i = 0; i < CipherKey.Length; i++)
            {
                if (tempCipherKey[i] != Convert.ToChar(array[0, i]))
                {
                    int j = 0;
                    char temp = ' ';
                    do
                    {
                        temp = Convert.ToChar(array[0, j]);
                        j++;
                    }
                    while (tempCipherKey[i] != temp);
                    array[0, j - 1] = array[0, j - 1].ToUpper();
                    for (int Row = 0; Row < rowCount; Row++)
                    {
                        buff = array[Row, i];
                        array[Row, i] = array[Row, j - 1];
                        array[Row, j - 1] = buff;
                    }

                }
            }
            //Prosto delaem lowercase;
            for (int i = 0; i < CipherKey.Length; i++)
                array[0, i] = array[0, i].ToLower();
            return array;
        }

        private void Cipher(string Message, string Key)
        {
            /*
              key = text;
              message hell;
                j ------------>          
            i   [T]  [E]  [X]  [T] 
            |   [20] [5]  [24  [20]
            v   [h]  [e]  [l]  [l]
            
             */


            int messageLength = Message.Length;
            int keyLength = Key.Length;
            double rowCount = (double)messageLength / (double)keyLength;
            if (rowCount != Math.Truncate(rowCount))
                rowCount = rowCount + 1;
            string[,] CipherArray = new string[(int)rowCount + 2, keyLength]; //2е доп строки под ключ и AlphabetIndex

            //Заполняем в массив ключ и AlphabetIndex
            for (int j = 0; j < keyLength; j++)
            {
                string letter = Convert.ToString(Key[j]);
                CipherArray[0, j] = letter;
                CipherArray[1, j] = Convert.ToString(char.ToUpper(Key[j]) - 64);
            }

            //Если буква встречается несколько раз, то следующей присваивается другой индекс
            for (int i = 0; i < CipherArray.GetLength(1); i++)
            {
                for (int j = i + 1; j < CipherArray.GetLength(1); j++)
                {
                    if (Convert.ToInt32(CipherArray[1, i]) == Convert.ToInt32(CipherArray[1, j]))
                    {
                        CipherArray[1, j] = Convert.ToString(Convert.ToInt32(CipherArray[1, j]) + 1);
                    }
                }
            }


            //Добавляем в массив текст
            int count = 0;
            for (int i = 2; i < CipherArray.GetLength(0); i++)
            {
                for (int j = 0; j < CipherArray.GetLength(1); j++)
                {
                    if (count != messageLength+1)
                    {
                        //if (Convert.ToString(Message[count]) == " ")
                        //    CipherArray[i, j] = "*";
                        //else
                        try
                        {
                            CipherArray[i, j] = Convert.ToString(Message[count]).ToLower();
                            count = count + 1;
                        }
                        catch
                        {
                            CipherArray[i, j] = " ";
                            count = count + 1;
                        }
                    }
                }
            }



            count = 0;
            DisplayIntoDataGrid(CipherArray, FirstDataGrid);
            DisplayIntoDataGrid(SortArray(CipherArray, (int)rowCount + 2), SecondDataGrid);
            //2,1
            // +
            //3,1 
            // +
            //4,1
            //Вывод результата
            ResultBox.Text = "";
            for (int j = 0; j < CipherArray.GetLength(1); j++)
            {
                for (int i = 2; i < CipherArray.GetLength(0); i++)
                {

                    if (count != messageLength)
                    {
                        if (CipherArray[i, j] == null)
                        {
                            ResultBox.Text += " ";
                        }
                        else
                        {
                            ResultBox.Text += CipherArray[i, j];
                        }
                        }
                }
            }
            try
            {
                File.Delete("Ciph1\\CipherText.txt");
                File.WriteAllLines("Ciph1\\CipherText.txt", new[] { ResultBox.Text });
                File.Delete("Ciph1\\CipherKey.txt");
                File.WriteAllLines("Ciph1\\CipherKey.txt", new[] { KeyBox.Text });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FirstDataGrid.Columns.Clear();
            SecondDataGrid.Columns.Clear();
            if (SourceBox.Text == "")
                MessageBox.Show("Заполните текст");
            else if (Regex.IsMatch(SourceBox.Text, @"\p{IsCyrillic}"))
                MessageBox.Show("Текст содержит кириллицу");
            else if (KeyBox.Text == "")
                MessageBox.Show("Заполните ключ");
            else if (Regex.IsMatch(KeyBox.Text, @"\p{IsCyrillic}"))
                MessageBox.Show("В ключе присутствует кириллица");
            else
                Cipher(SourceBox.Text, KeyBox.Text);
        }

        private void Encode(string Message, string Key)
        {
            int messageLength = Message.Length;
            int keyLength = Key.Length;
            double rowCount = (double)messageLength / (double)keyLength;
            if (rowCount != Math.Truncate(rowCount))
                rowCount = rowCount + 1;
            string[,] CipherArray = new string[(int)rowCount + 2, keyLength];

            //Заполняем в массив ключ и AlphabetIndex
            for (int j = 0; j < keyLength; j++)
            {
                string letter = Convert.ToString(Key[j]);
                CipherArray[0, j] = letter;
                CipherArray[1, j] = Convert.ToString(char.ToUpper(Key[j]) - 64);
            }

            //Если буква встречается несколько раз, то следующей присваивается другой индекс
            for (int i = 0; i < CipherArray.GetLength(1); i++)
            {
                for (int j = i + 1; j < CipherArray.GetLength(1); j++)
                {
                    if (Convert.ToInt32(CipherArray[1, i]) == Convert.ToInt32(CipherArray[1, j]))
                    {
                        CipherArray[1, j] = Convert.ToString(Convert.ToInt32(CipherArray[1, j]) + 1);
                    }
                }
            }

            CipherArray = SortArray(CipherArray, (int)rowCount + 2);

            //Добавляем в массив текст
            int count = 0;
            for (int j = 0; j < CipherArray.GetLength(1)+1; j++)
            {
                for (int i = 2; i < CipherArray.GetLength(0); i++)
            {
                    if (count != messageLength)
                    {
                        try
                        {
                            CipherArray[i, j] = Convert.ToString(Message[count]);
                            count = count + 1;
                        }
                        catch
                        {
                            CipherArray[i, j] = " ";
                            count = count + 1;
                        }
                    }
                }
            }



            DisplayIntoDataGrid(CipherArray, FirstEncodeGrid);
            DisplayIntoDataGrid(EncodeSortAray(CipherArray, (int)rowCount + 2, CipherKeyBox.Text), SecondEncodeGrid);


            count = 0;
            ResultEncryptBox.Text = "";
            for (int i = 2; i < CipherArray.GetLength(0); i++)
            {
                for (int j = 0; j < CipherArray.GetLength(1); j++)
            {
                    if (count != messageLength)
                        ResultEncryptBox.Text += CipherArray[i, j];
                }
            }
            try
            {
                File.Delete("Ciph1\\CipherOUTText.txt");
                File.WriteAllLines("Ciph1\\CipherOUTText.txt", new[] { ResultEncryptBox.Text });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EncodeButton_Click(object sender, EventArgs e)
        {
            FirstEncodeGrid.Columns.Clear();
            if (CipherBox.Text == "")
                MessageBox.Show("Заполните текст");
            else if (Regex.IsMatch(CipherBox.Text, @"\p{IsCyrillic}"))
                MessageBox.Show("Шифро текст содержит кириллицу");
            else if (CipherKeyBox.Text == "")
                MessageBox.Show("Заполните ключ");
            else if (Regex.IsMatch(CipherKeyBox.Text, @"\p{IsCyrillic}"))
                MessageBox.Show("В ключе присутствует кириллица");
            else
                Encode(CipherBox.Text, CipherKeyBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SourceBox.Text = "";
            try
            {
                var file = File.ReadAllLines("Ciph1\\SourceText.txt");
                foreach (var line in file)
                {
                    foreach (char symbol in line)
                    {
                        if(Regex.IsMatch(Convert.ToString(symbol), @"[A-Za-z]"))
                        SourceBox.Text += symbol;
                    }
                    SourceBox.Text += " ";
                }
                //SourceBox.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при чтении " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                CipherBox.Text = File.ReadAllLines("Ciph1\\CipherText.txt")[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при чтении " + ex.Message);
            }
        }
    }
}
