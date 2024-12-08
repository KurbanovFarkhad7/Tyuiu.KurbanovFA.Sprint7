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

namespace Tyuiu.KurbanovFA.Sprint7.Project.V5
{
    public partial class FormGoods : Form
    {
        public FormGoods()
        {
            InitializeComponent();
        }

        public void FormGoods_Load(object sender, EventArgs e)
        {
            OpenFileDialog dilg = new OpenFileDialog();
            dilg.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
            string filepath = @"C:\Users\Cruise\source\repos\Tyuiu.KurbanovFA.Sprint7\objects\Goods.xlsx";
            LoadDataFromExceltoDataGridView(filepath, ".xlsx", "yes");
        }

        private void buttonGoMain_KFA_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain fmain = new FormMain();
            fmain.ShowDialog();
        }

        public void buttonExportCVS_KFA_Click(object sender, EventArgs e)
        {
            

            /*string filepath = dilg.FileName;
            textBoxFilePath_KFA.Text = filepath;*/
            /*if (dilg.ShowDialog() == DialogResult.OK)
            {
                string filepath = dilg.FileName;
                textBoxFilePath_KFA.Text = filepath;
                *//*string filepath = "C:\Users\Cruise\source\repos\Tyuiu.KurbanovFA.Sprint7\objects\Goods.xlsx";*//*
                LoadDataFromExceltoDataGridView(filepath, ".xlsx", "yes");
            }*/
        }

        public void LoadDataFromExceltoDataGridView(string fpath, string ext, string hdr)
        {
            string con = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
            con = String.Format(con, fpath, hdr);
            OleDbConnection excelcon = new OleDbConnection(con);
            excelcon.Open();
            DataTable exceldata = excelcon.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            string exsheetname = exceldata.Rows[0]["TABLE_NAME"].ToString();
            OleDbCommand com = new OleDbCommand("Select * from [" + exsheetname + "]", excelcon);
            OleDbDataAdapter oda = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            excelcon.Close();
            dataGridViewGoods_KFA.DataSource = dt;
        }
        
    }
}
