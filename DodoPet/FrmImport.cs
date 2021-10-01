using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DodoPet
{
    public partial class FrmImport : DevExpress.XtraEditors.XtraForm
    {
        DataSet listaArticoliDataSet = new DataSet();

        DataHelper data = new DataHelper();
        public FrmImport()
        {
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            data.svuotaTempImport();
        }

        private void BtnScegliFile_Click(object sender, EventArgs e)
        {
            data.svuotaTempImport();
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    string filePath = openFileDialog.FileName;
                    label1.Text = filePath;

                    BtnCarica.Enabled = true;
                }
            }
        }

        private void BtnCarica_Click(object sender, EventArgs e)
        {
            string result = data.importDataFromExcelx(label1.Text);
            if (result.Equals(String.Empty))
            {
                MessageBox.Show("Importazione Terminata ! ", "GB IMPORT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnImporta.Enabled = false;
                label1.Text = "";

                data.eliminaNullExcel("JACOB");
                listaArticoliDataSet = data.getListaArticoli("JACOB");
                gcListaExcel.DataSource = listaArticoliDataSet.Tables[0];
                btnElabora.Enabled = true;
            }
            else
            {
                MessageBox.Show("Errore!", "GBHUB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnImporta.Enabled = false;
                label1.Text = "";
            }
        }
    }
}