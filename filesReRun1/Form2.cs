using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace filesReRun1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        DataTableCollection dtc;

        private void OriginalDataGridViewPopulate()
        {
            //what we use to populate the og datagridview
            if (comboBox1.SelectedItem != null)
            {
                DataTable dataTable = dtc[comboBox1.SelectedItem.ToString()];
                dataGridViewOriginal.DataSource = dataTable;
            }
        }

        private DataTable ProcessDataTable(DataTable originalTable)
        {
            //where the magic happens
            //adds comlumns we will use in csv
            //set the csv to look in a specific way(produtCode and imei linked)
            DataTable newTable = new DataTable();
            newTable.Columns.Add("product_code");
            newTable.Columns.Add("dealer_code");
            newTable.Columns.Add("device_imei");
            newTable.Columns.Add("reserved");
            newTable.Columns.Add("capture_date");
            newTable.Columns.Add("capture_user");
            newTable.Columns.Add("modified_date");
            newTable.Columns.Add("modified_user");

            for (int i = 0; i < originalTable.Rows.Count; i++)
            {
                var productCode = originalTable.Rows[i]["VodaCode"].ToString();
                var quan = originalTable.Rows[i]["Qty"].ToString();
  
                if (!String.IsNullOrWhiteSpace(productCode) && !String.IsNullOrWhiteSpace(quan)) 
                {
                    var quantityCount = Int32.Parse(quan);
                    var ImeiList = new List<string>();
                    for (int x = 0; x < quantityCount; x++)
                    {
                        ImeiList.Add(originalTable.Rows[x + 1]["SerialNumber"].ToString());
                    }

                    foreach (var item in ImeiList)
                    {
                        DataRow newRow = newTable.NewRow();

                        newRow["product_code"] = productCode.ToString();
                        newRow["dealer_code"] = "IRD";
                        newRow["device_imei"] = item.ToString();
                        newRow["reserved"] = "FALSE";
                        newRow["capture_date"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        newRow["capture_user"] = txt_name.Text; //"FSIV_ASHTON";
                        newRow["modified_date"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        newRow["modified_user"] = txt_name.Text; //"FSIV_ASHTON";
                        newTable.Rows.Add(newRow);
                    }
                }
            }

            return newTable;
        }

    
 
        private bool OnlytaketheseExcelFiles(DataTable dataTable)
        {
            //checks if the excel file has these specfic  columns, if a column is missing it gives false
            string [] expected = { "ItemCode", "Description", "VodaCode", "Qty", "SerialNumber" };

            for (int i = 0; i < expected.Length; i++)
            {
                if (!dataTable.Columns.Contains(expected[i]))
                {
                    return false;
                }
            }
            return true;
        }



        private void Convert(DataTable dataTable, string csvFilePath)
        {
            //method to convert the xls to csv
            StringBuilder stringBuilder = new StringBuilder();
            IEnumerable<string> columnNames = dataTable.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
            stringBuilder.AppendLine(string.Join(",", columnNames));

       

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                string[] fields = dataTable.Rows[i].ItemArray.Select(field => field.ToString()).ToArray();
                stringBuilder.AppendLine(string.Join(",", fields));
            }

            File.WriteAllText(csvFilePath, stringBuilder.ToString(), Encoding.UTF8);
            MessageBox.Show("Your data has been converted to a CSV file !"); 
        }
        


        private void btnUpload_Click(object sender, EventArgs e)
        {
            //we open the file here
            //and write the path but use the cmb to open it
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "Excel Files|*.xls;*.xlsx" })
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = openFileDialog1.FileName;
                    openFileDialog1.RestoreDirectory = true;
                    using (var stream = File.Open(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            dtc = result.Tables;

                            
                            //checks if its the correct file is in correct format
                            if (!OnlytaketheseExcelFiles(dtc[0]))
                            {
                                MessageBox.Show("Invalid file format. The file must have these columns: ItemCode, Description, VodaCode, Qty, SerialNumber.");
                                return;
                            }
                            
                            comboBox1.Items.Clear();
                            for (int l = 0; l < dtc.Count; l++)
                            {
                                comboBox1.Items.Add(dtc[l].TableName);
                            }
                        }
                    }
                }
            }

        }
    
            

        private void btnSave_Click(object sender, EventArgs e)
        {
            //saves file in csv
            if (dataGridViewNew.DataSource == null)
            {
                MessageBox.Show("Please process the data first!");
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "CSV files (*.csv)|*.csv" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string csvFilePath = saveFileDialog.FileName;
                    Convert((DataTable)dataGridViewNew.DataSource, csvFilePath);
                }
            }

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OriginalDataGridViewPopulate();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void btn_process_Click(object sender, EventArgs e)
        {
            //processes the files from csv to excel by taking og file and using the processdatatable method to output it the way we want
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a excel file from the combobox first!");
                return;
            }

            DataTable originalTable = dtc[comboBox1.SelectedItem.ToString()];

            DataTable processedTable = ProcessDataTable(originalTable);
            dataGridViewNew.DataSource = processedTable;

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            //closes program
            this.Close();   
        }
    }
}
