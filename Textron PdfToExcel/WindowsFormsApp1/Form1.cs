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

namespace PdfToExcel
{
    // The class definition for Form1, inheriting from the Form class
    public partial class Form1 : Form
    {
        // Initial Textron PdfToExcel window
        // This is the main window holding the Convert and Help Button
        public Form1()
        {
            InitializeComponent();
        }

        // Picture container for Textron logo in Form1
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        // Do not delete
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // ReadMe Button
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 formTwo = new Form2();
            formTwo.Show();
        }

        // Convert Button
        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog1 = new FolderBrowserDialog();
            DialogResult result = folderDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string userPath = folderDialog1.SelectedPath;

                foreach (string file in Directory.EnumerateFiles(userPath, "*.pdf"))
                {
                    string excelPath = Path.ChangeExtension(file, ".xls");

                    // Converting PDF to Excel filetype
                    SautinSoft.PdfFocus f = new SautinSoft.PdfFocus();

                    // 'true' = convert data to spreadsheet (tabular and textual)
                    // 'false' = skip textual data and convert only tabular (tables)
                    f.ExcelOptions.ConvertNonTabularDataToSpreadsheet = true;

                    f.OpenPdf(file);

                    

                    if (f.PageCount > 0)
                    {
                        int resultExcelPath = f.ToExcel(excelPath);

                        // open an excel workbook
                        if (resultExcelPath == 0)
                        {
                            // Uncomment the line below if you'd like to launch excel upon conversion
                            // System.Diagnostics.Process.Start(excelPath);
                        }
                    }
                }

                ///////////////////////////////////////////////////////////////////
                int j = progressBar1.Minimum;

                if (j == progressBar1.Minimum)
                {
                    for (j = progressBar1.Minimum; j <= progressBar1.Maximum; j++)
                    {
                        progressBar1.Value = j;
                    }

                    

                }

                if (j == progressBar1.Maximum)
                {
                    result = DialogResult.None;

                }

                ///////////////////////////////////////////////////////////////////

            }

            //while (result != DialogResult.OK)
            //{
            //    progressBar1.Value = progressBar1.Minimum;
            //}

        }

        // Do not delete
        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
