using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorna4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonResTab1_Click(object sender, EventArgs e)
        {
            try
            {
                double[] mass = txtArray.Text.Split(' ').Select(x => double.Parse(x)).ToArray();

                double count = 0;
                double summa = 1;
                int maxIndex = Array.IndexOf(mass, mass.Max());
                int minIndex = Array.IndexOf(mass,mass.Min());

                for (int i = 0; i < mass.Length; i++)
                {
                    if (mass[i] < 0)
                    {
                        count++;
                    }
                }

                for (int i = minIndex; i < mass.Length; i++)
                {
                        summa += Math.Abs(mass[i]);
                }

                for(int i = 0; i < mass.Length; i++)
                {
                    if (mass[i] < 0)
                    {
                        mass[i] = Math.Pow(mass[i],2);
                    }
                }
                double[] sortetArr = mass.OrderBy(x => x).ToArray();

                ResLab.Text = $"Кількість від’ємних елементів масиву: {count}\n";
                ResLab.Text += $"Суму модулів елементів масиву, розташованих після мінімального за\r\nмодулем елементу : {summa}\n";
                ResLab.Text += $"Впорядкувати елементи масиву за зростанням : ";
                foreach (int i in sortetArr)
                {
                    ResLab.Text += $"{i} ";
                }
            }
            catch(Exception ex)
            {
                ResLab.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                LabelResult2.Text = string.Empty;

                string[] inputLines = txt2DArray.Text.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                string[,] array2D = new string[inputLines.Length, inputLines[0].Split(' ').Length];

                for (int i = 0; i < inputLines.Length; i++)
                {
                    string[] values = inputLines[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    for (int j = 0; j < values.Length; j++)
                    {
                        array2D[i, j] = values[j];
                    }
                }
                LabelResult2.Text = "Виводимо двохмірний массив\n";
                for (int i = 0; i < array2D.GetLength(0); i++)
                {
                    for (int j = 0; j < array2D.GetLength(1); j++)
                    {
                        LabelResult2.Text += $"{array2D[i, j]} ";
                    }
                    LabelResult2.Text += "\n";
                }

                LabelResult2.Text += $"Усі елементи другого стовбцю масиву : ";
                for (int i = 0; i < array2D.GetLength(0); i++)
                {
                    LabelResult2.Text += $"{array2D[i,1]} ";
                }
                LabelResult2.Text += $"\n";
                LabelResult2.Text += $"Усі елементи m-го рядка масиву : ";
                int m = 2;
                for (int i = 0; i < array2D.GetLength(1); i++)
                {
                    LabelResult2.Text += $"{array2D[m, i]} ";
                }
            }
            catch (Exception ex)
            {
                LabelResult2.Text = ex.Message;
            }
        }
    }
}
