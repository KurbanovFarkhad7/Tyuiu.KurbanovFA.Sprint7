using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;

using Tyuiu.KurbanovFA.Sprint7.Project.V5.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.KurbanovFA.Sprint7.Project.V5
{
    public partial class FormGoods : Form
    {
        public FormGoods()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string filePath = @"C:\Users\Cruise\source\repos\Tyuiu.KurbanovFA.Sprint7\objects\SavedGoods.csv"; //путь для импорта/экспорта


        public void FormGoods_Load(object sender, EventArgs e)
        {
            buttonImportCSV_KFA_Click(sender, e); //чтоб файл загружался сразу
        }

        private void buttonGoMain_KFA_Click(object sender, EventArgs e)
        {
            buttonExportCVS_KFA_Click(sender, e);
            this.Hide();
            FormMain fmain = new FormMain();
            fmain.ShowDialog();
        }

        public void buttonDeleteGood_KFA_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewGoods_KFA.SelectedRows)
            {
                dataGridViewGoods_KFA.Rows.RemoveAt(row.Index);
            }
        }

        private void ImportCsvToDataGridView(string filePath)
        {
            DataTable dataTable = new DataTable();
            using (StreamReader sr = new StreamReader(filePath))
            {
                // Read the header line
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dataTable.Columns.Add(header);
                }

                // Read the data lines
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    dataTable.Rows.Add(values);
                }
            }
            // Bind the DataTable to the DataGridView
            dataGridViewGoods_KFA.DataSource = dataTable;
        }

        public void DeleteNullCells()
        {
            for (int i = 0; i < dataGridViewGoods_KFA.RowCount - 1; i++)
            {
                if (dataGridViewGoods_KFA.Rows[i].Cells[3].Value.ToString() == "") //удаление пустых строк
                {
                    dataGridViewGoods_KFA.Rows.RemoveAt(i);
                    i--;
                }
            }
        }

        private void buttonImportCSV_KFA_Click(object sender, EventArgs e)
        {
            // Open a file dialog to select the CSV file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            ImportCsvToDataGridView(filePath);
            DeleteNullCells();
        }


        public void buttonExportCVS_KFA_Click(object sender, EventArgs e)
        {

            // Create the CSV file
            using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                // Write the header row
                for (int i = 0; i < dataGridViewGoods_KFA.ColumnCount; i++)
                {
                    sw.Write(dataGridViewGoods_KFA.Columns[i].HeaderText);
                    if (i < dataGridViewGoods_KFA.ColumnCount - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.WriteLine();

                // Write the data rows
                foreach (DataGridViewRow row in dataGridViewGoods_KFA.Rows)
                {
                    for (int i = 0; i < dataGridViewGoods_KFA.ColumnCount; i++)
                    {
                        if (row.Cells[i].Value != null)
                        {
                            sw.Write(row.Cells[i].Value.ToString());
                        }
                        if (i < dataGridViewGoods_KFA.ColumnCount - 1)
                        {
                            sw.Write(",");
                        }
                    }
                    sw.WriteLine();
                }

            }
        }

        private void buttonFindValue_KFA_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewGoods_KFA.RowCount; i++)
            {
                dataGridViewGoods_KFA.Rows[i].Selected = false;
                for (int j = 0; j < dataGridViewGoods_KFA.ColumnCount; j++)
                    if (dataGridViewGoods_KFA.Rows[i].Cells[j].Value != null)
                        if (dataGridViewGoods_KFA.Rows[i].Cells[j].Value.ToString().Contains(textBoxFindValue_KFA.Text))
                        {
                            dataGridViewGoods_KFA.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        public double[] GetArrayRow(int row) //Универсальный метод получения столбца массива
        {
            double[] array = new double[dataGridViewGoods_KFA.Rows.Count];
            for (int i = 0; i < dataGridViewGoods_KFA.Rows.Count; i++)
            {
                array[i] = dataGridViewGoods_KFA.Rows[i].Cells[0].Value == null ? array[i - 1] : Convert.ToInt32(dataGridViewGoods_KFA.Rows[i].Cells[row].Value);
                //второй, в конце Cells[1] - номер столбца
            }
            return array;
        }

        private void buttonSearchMiddlePrice_KFA_Click(object sender, EventArgs e)
        {
            double[] array = GetArrayRow(1);
            textBoxResultCalculation_KFA.Text = ds.FindMiddleValue(array).ToString();

            //без либы
            /*double sum = 0;
            double middleValue = 0;
            for (int i = 0; i < dataGridViewGoods_KFA.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridViewGoods_KFA.Rows[i].Cells[1].Value); //всего цена
            }
            middleValue = sum / (dataGridViewGoods_KFA.RowCount - 1);
            textBoxResultCalculation_KFA.Text = middleValue.ToString();*/

        }

        private void buttonSearchTotalPrice_KFA_Click(object sender, EventArgs e)
        {
            double[] array = GetArrayRow(1);
            textBoxResultCalculation_KFA.Text = ds.FindTotalValue(array).ToString();

            /*int[] array = new int[dataGridViewGoods_KFA.Rows.Count];
            for (int i = 0; i < dataGridViewGoods_KFA.Rows.Count; i++)
            {
                array[i] = dataGridViewGoods_KFA.Rows[i].Cells[0].Value == null ? -1 : Convert.ToInt32(dataGridViewGoods_KFA.Rows[i].Cells[1].Value);
                //второй, в конце Cells[1] - номер столбца
            }
            textBoxResultCalculation_KFA.Text = array.Max().ToString();*/
        }

        private void buttonSearchMinPrice_KFA_Click(object sender, EventArgs e)
        {
            double[] array = GetArrayRow(1);
            textBoxResultCalculation_KFA.Text = ds.FindMinValue(array).ToString();
        }

        private void buttonSearchMaxNumber_KFA_Click(object sender, EventArgs e)
        {
            double[] array = GetArrayRow(3);
            textBoxResultCalculation_KFA.Text = ds.FindMaxValue(array).ToString();
        }
    }
}
