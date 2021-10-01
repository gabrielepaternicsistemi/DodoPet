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
using DevExpress.XtraPrinting;

namespace DodoPet
{
    public partial class FrmVenduto : DevExpress.XtraEditors.XtraForm
    {

        DataHelper data = new DataHelper();
        DataSet dati = new DataSet();

        public FrmVenduto()
        {
            InitializeComponent();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            aggiornaGridControl();
        }

        public void aggiornaGridControl()
        {
            dati = data.GetVenduto(dateTimePicker1.Value, dateTimePicker2.Value);
            Testmaggc.DataSource = dati.Tables[0];
            dati.Relations.Add("Corpo", dati.Tables["TESTMAG"].Columns["XX_CHIAVEGLOBALE"], dati.Tables["MOVMAG"].Columns["XX_CHIAVEGLOBALE"], false);
            Testmaggc.LevelTree.Nodes.Add("Corpo", gridView2);

            Testmaggc.DataSource = dati.Tables[1];
        }

        private void Exortbtn_Click(object sender, EventArgs e)
        {
            string path = "EXPORT.xlsx";

            gridView1.OptionsPrint.ExpandAllDetails = true;
            gridView1.OptionsPrint.PrintDetails = true;

            XlsxExportOptionsEx o = new XlsxExportOptionsEx();
            o.ExportType = DevExpress.Export.ExportType.WYSIWYG;
            //o.CustomizeCell += o_CustomizeCell;
            //DevExpress.XtraPrinting.XlsxExportOptions oXlsExportOptions = new DevExpress.XtraPrinting.XlsxExportOptions { TextExportMode = DevExpress.XtraPrinting.TextExportMode.Value };
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel Documents (*.xls)|*.xls";
            saveFileDialog1.Title = "Save";
            saveFileDialog1.ShowDialog();
            if (!String.IsNullOrEmpty(saveFileDialog1.FileName))
            {
                path = saveFileDialog1.FileName;
            }
            gridView1.ExportToXlsx(path, o);
        }
    }
}