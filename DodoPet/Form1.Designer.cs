namespace DodoPet
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Vendutobtn = new DevExpress.XtraBars.BarButtonItem();
            this.Editbtn = new DevExpress.XtraBars.BarButtonItem();
            this.Importbtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.Vendutobtn,
            this.Editbtn,
            this.Importbtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1423, 143);
            // 
            // Vendutobtn
            // 
            this.Vendutobtn.Caption = "Venduto";
            this.Vendutobtn.Id = 1;
            this.Vendutobtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Vendutobtn.ImageOptions.Image")));
            this.Vendutobtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Vendutobtn.ImageOptions.LargeImage")));
            this.Vendutobtn.Name = "Vendutobtn";
            this.Vendutobtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Vendutobtn_ItemClick);
            // 
            // Editbtn
            // 
            this.Editbtn.Caption = "Modifica Articoli";
            this.Editbtn.Id = 2;
            this.Editbtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Editbtn.ImageOptions.Image")));
            this.Editbtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Editbtn.ImageOptions.LargeImage")));
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Editbtn_ItemClick);
            // 
            // Importbtn
            // 
            this.Importbtn.Caption = "Importa Listini";
            this.Importbtn.Id = 3;
            this.Importbtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Importbtn.ImageOptions.Image")));
            this.Importbtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Importbtn.ImageOptions.LargeImage")));
            this.Importbtn.Name = "Importbtn";
            this.Importbtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Importbtn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "GENERALE";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Vendutobtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.Editbtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.Importbtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1423, 749);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Dodo Pet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem Vendutobtn;
        private DevExpress.XtraBars.BarButtonItem Editbtn;
        private DevExpress.XtraBars.BarButtonItem Importbtn;
    }
}

