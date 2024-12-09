using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Excel = Microsoft.Office.Interop.Excel;

namespace Tyuiu.KurbanovFA.Sprint7.Project.V5
{
    public partial class FormGoods : Form
    {
        public FormGoods()
        {
            InitializeComponent();
        }
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

        public void buttonSaveGood_KFA_Click(object sender, EventArgs e)
        {

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

        private void buttonImportCSV_KFA_Click(object sender, EventArgs e)
        {
            // Open a file dialog to select the CSV file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            ImportCsvToDataGridView(filePath);
            for (int i = 0; i < dataGridViewGoods_KFA.RowCount - 1; i++)
            {

                if (dataGridViewGoods_KFA.Rows[i].Cells[3].Value.ToString() == "") //удаление пустых строк
                {
                    dataGridViewGoods_KFA.Rows.RemoveAt(i);
                    i--;
                }
            }
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
    }
}
