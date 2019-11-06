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
    public partial class RotateCipher : Form
    {
        static string[,] Matrix = null;
        static string[,] WorkMatrix = null;
        static int SourceIndex = 0;
        Random random = new Random();
        public RotateCipher()
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
                    dataGridView.Columns[j].Width = 36;
                    dataGridView.Rows[j].Height = 36;
                    //пишем значения из массива в ячейки контролла
                    dataGridView.Rows[i].Cells[j].Value = array[i, j];
                }
            }
        }

        private string[,] initKey()
        {
            string[,] array = new string[4, 4]
                {
                    { "X","","","" },
                    { "","","","X" },
                    { "","","X","" },
                    { "","X","","" }
                };
            return array;
        }
        static string[,] RotateSquareMatrix(string[,] matrix, int n)
        {
            string[,] ret = new string[n, n];

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    ret[i, j] = matrix[n - j - 1, i];
                }
            }

            return ret;
        }
        private void RotateCipher_Load(object sender, EventArgs e)
        {
            DisplayIntoDataGrid(Matrix = initKey(), KeyDataGrid);
        }

        private void RotateButton_Click(object sender, EventArgs e)
        {
            DisplayIntoDataGrid(Matrix = RotateSquareMatrix(Matrix, 4), KeyDataGrid);
        }

        private string[,] MatrixWrite(string[,] workArray, string[,] keyMatrix)
        {
            int n = 4;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (SourceBox.Text.Length <= SourceIndex && keyMatrix[i, j] == "X")
                    {
                        int a = random.Next(0, 26);
                        char ch = (char)('a' + a);
                        workArray[i, j] = Convert.ToString(ch);
                    }
                    else if (keyMatrix[i, j] == "X" && SourceBox.Text.Length > SourceIndex)
                    {
                        string character = Convert.ToString(SourceBox.Text[SourceIndex]);

                        if (character == " " && SourceIndex + 1 < SourceBox.Text.Length)
                        {
                            SourceIndex++;
                            character = Convert.ToString(SourceBox.Text[SourceIndex]);
                        }
                        workArray[i, j] = character;
                        SourceIndex++;
                    }
                }
            }
            return workArray;
        }

        private void EnCryptButton_Click(object sender, EventArgs e)
        {
            EnCryptResultBox.Text = "";
            WorkMatrix = new string[4, 4];
            SourceIndex = 0;
            DisplayIntoDataGrid(Matrix = initKey(), KeyDataGrid);
            //Не больше 4*4(16) символов
            List<DataGridView> DataGrids = new List<DataGridView> { FirstDataGrid, SecondDataGrid, ThirdDataGrid, FourthDataGrid };

            foreach (var item in DataGrids)
            {
                DisplayIntoDataGrid(WorkMatrix = MatrixWrite(WorkMatrix, Matrix), item);
                Matrix = RotateSquareMatrix(Matrix, 4);
            }
            DisplayIntoDataGrid(Matrix, KeyDataGrid);
            foreach (var item in WorkMatrix)
            {
                EnCryptResultBox.Text += item;
            }
            try
            {
                File.Delete("Ciph2\\CipherText.txt");
                File.WriteAllLines("Ciph2\\CipherText.txt", new[] { EnCryptResultBox.Text });

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EncryptFromFile_Click(object sender, EventArgs e)
        {
            SourceBox.Text = "";
            try
            {
                var file = File.ReadAllLines("Ciph2\\SourceText.txt");
                foreach (var line in file)
                {
                    foreach (char symbol in line)
                    {
                        if (Regex.IsMatch(Convert.ToString(symbol), @"[A-Za-z]"))
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

        private void DecryptFromFile_Click(object sender, EventArgs e)
        {
            CipherSourceBox.Text = "";
            try
            {
                var file = File.ReadAllLines("Ciph2\\CipherText.txt");
                foreach (var line in file)
                {
                    foreach (char symbol in line)
                    {
                        if (Regex.IsMatch(Convert.ToString(symbol), @"[A-Za-z]"))
                            CipherSourceBox.Text += symbol;
                    }
                    CipherSourceBox.Text += " ";
                }
                //SourceBox.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при чтении " + ex.Message);
            }
        }
        private string[,] DeMatrixWrite(string[,] workArray, string[,] keyMatrix, DataGridView dv)
        {
            if (dv.Name == "FirstCryptDataGrid")
            {
                int n = 4;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        workArray[i, j] = Convert.ToString(CipherSourceBox.Text[SourceIndex++]);
                    }
                }
                return workArray;
            }
            else
            {
                int n = 4;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (keyMatrix[i, j] == "X")
                        {
                            DeCryptResultBox.Text += workArray[i, j];
                            workArray[i, j] = " ";
                        }
                    }
                }
                return workArray;
            }
        }
        private void DeCryptButton_Click(object sender, EventArgs e)
        {
            DeCryptResultBox.Text = "";
            SourceIndex = 0;
            WorkMatrix = new string[4, 4];
            DisplayIntoDataGrid(Matrix = initKey(), KeyDataGrid);
            //Не больше 4*4(16) символов
            List<DataGridView> DataGrids = new List<DataGridView> { FirstCryptDataGrid, SecondCryptDataGrid, ThirdCryptDataGrid, FourthCryptDataGrid };

            foreach (var item in DataGrids)
            {
                DisplayIntoDataGrid(WorkMatrix = DeMatrixWrite(WorkMatrix, Matrix, item), item);
                if (item.Name != "FirstCryptDataGrid")
                Matrix = RotateSquareMatrix(Matrix, 4);
            }
            foreach (var item in WorkMatrix)
            {
                if(item!=" ")
                DeCryptResultBox.Text += item;
            }
            //DisplayIntoDataGrid(Matrix, KeyDataGrid);
            try
            {
                File.Delete("Ciph2\\DeCipherText.txt");
                File.WriteAllLines("Ciph2\\DeCipherText.txt", new[] { EnCryptResultBox.Text });

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
