using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
namespace percobaan1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTableCollection tabelCollection;
        DataColumnCollection columnCollection;

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Worksheet|* .xlsx|Excel 97-2003 Workbook|* .xls" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    namaFile.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tabelCollection = result.Tables;

                            sheetList.Text = "";
                            sheetList.Items.Clear();

                            kategoriList.Text = "";
                            kategoriList.Items.Clear();

                            anggotaList.Text = "";
                            anggotaList.Items.Clear();

                            recapText.Text = "";

                            //tampil isi sheet
                            foreach (DataTable table in tabelCollection)
                                sheetList.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }


        private void sheetList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tabelCollection[sheetList.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;

            //tampil isi kolom
            kategoriList.Items.Clear();
            foreach (DataColumn column in dt.Columns)
                kategoriList.Items.Add(column.ColumnName);

            kategoriList.Text = "";

            anggotaList.Text = "";
            anggotaList.Items.Clear();

            recapText.Text = "";
        }

        private void kategoriList_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable dt = tabelCollection[sheetList.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;

            string dc = kategoriList.SelectedItem.ToString();
            string[] A = new string[dt.Rows.Count];
            int c = 0;

            anggotaList.Items.Clear();

            //cek kembar
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                A[i] = dt.Rows[i][dc].ToString();
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    if (A[i] == A[j] && i != j)
                    {
                        A[i] = "";
                    }
                }

                if (A[i] != "")
                {
                    c += 1;
                }
            }


            string[] B = new string[c];

            for (int i = 0; i < c; i++)
            {
                B[i] = "";
            }

            //tampil isi baris
            int n = 0;
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if (B[i] == "")
                    {
                        B[i] = A[n];
                        n += 1;
                    }
                }
                anggotaList.Items.Add(B[i]);
            }

            anggotaList.Text = "";

            recapText.Text = "";
        }
  
        private void anggotaList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataTable dt = tabelCollection[sheetList.SelectedItem.ToString()];
            string dc = kategoriList.SelectedItem.ToString();
            string dd = anggotaList.SelectedItem.ToString();
            int d = 0;

            DataView dv = new DataView(dt);
            dv.Sort = dc + " desc";
             dv.RowFilter ="[" + dc + "]" + "=" + "'" + dd + "'";

            dataGridView1.DataSource = dv;

            //tampil hasil jml rekap
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string a = dt.Rows[i][dc].ToString();
                if (dd == a)
                {
                    d += 1;
                } 
            }

            recapText.Text = d.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
 