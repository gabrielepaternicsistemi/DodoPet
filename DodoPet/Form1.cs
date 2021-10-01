using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DodoPet
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Vendutobtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmVenduto venduto = new FrmVenduto();
            venduto.MdiParent = this;
            venduto.Show();
        }

        private void Editbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmModificaArticoli frmModificaArticoli = new FrmModificaArticoli();
            frmModificaArticoli.MdiParent = this;
            frmModificaArticoli.Show();
        }

        private void Importbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmImport frmImport = new FrmImport();
            frmImport.MdiParent = this;
            frmImport.Show();
        }
    }
}
