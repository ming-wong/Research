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

namespace TrendsDataToDB
{
    public partial class FormResearch : Form
    {
        public FormResearch()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dlgOpenFile.ShowDialog();
            txbPath.Text = dlgOpenFile.FileName;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbPath.Text)) { MessageBox.Show("未選擇檔案路徑！"); return; }
            String fileText = "";
            using (StreamReader sr = new StreamReader(txbPath.Text,Encoding.UTF8))
            {
                String line;
                while (sr.Peek() != -1)
                {
                    line = sr.ReadLine();
                    fileText += line;
                }
            }
        }
    }
}
