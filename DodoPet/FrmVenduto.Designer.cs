namespace DodoPet
{
    partial class FrmVenduto
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenduto));
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mm_codart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mm_descr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mm_quant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mm_prezzo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mm_scont1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mm_scont2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Testmaggc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.an_descr1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tm_datdoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tm_numdoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tm_anno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tm_totdoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Exortbtn = new DevExpress.XtraEditors.SimpleButton();
            this.Searchbtn = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Testmaggc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.mm_codart,
            this.mm_descr,
            this.mm_quant,
            this.mm_prezzo,
            this.mm_scont1,
            this.mm_scont2});
            this.gridView2.GridControl = this.Testmaggc;
            this.gridView2.Name = "gridView2";
            // 
            // mm_codart
            // 
            this.mm_codart.Caption = "Cod. Articolo";
            this.mm_codart.FieldName = "mm_codart";
            this.mm_codart.Name = "mm_codart";
            this.mm_codart.Visible = true;
            this.mm_codart.VisibleIndex = 0;
            // 
            // mm_descr
            // 
            this.mm_descr.Caption = "Descrizione";
            this.mm_descr.FieldName = "mm_descr";
            this.mm_descr.Name = "mm_descr";
            this.mm_descr.Visible = true;
            this.mm_descr.VisibleIndex = 1;
            // 
            // mm_quant
            // 
            this.mm_quant.Caption = "Quant";
            this.mm_quant.FieldName = "mm_quant";
            this.mm_quant.Name = "mm_quant";
            this.mm_quant.Visible = true;
            this.mm_quant.VisibleIndex = 2;
            // 
            // mm_prezzo
            // 
            this.mm_prezzo.Caption = "Prezzo";
            this.mm_prezzo.FieldName = "mm_prezzo";
            this.mm_prezzo.Name = "mm_prezzo";
            this.mm_prezzo.Visible = true;
            this.mm_prezzo.VisibleIndex = 3;
            // 
            // mm_scont1
            // 
            this.mm_scont1.Caption = "Sconto 1";
            this.mm_scont1.FieldName = "mm_scont1";
            this.mm_scont1.Name = "mm_scont1";
            this.mm_scont1.Visible = true;
            this.mm_scont1.VisibleIndex = 4;
            // 
            // mm_scont2
            // 
            this.mm_scont2.Caption = "Sconto 2";
            this.mm_scont2.FieldName = "mm_scont2";
            this.mm_scont2.Name = "mm_scont2";
            this.mm_scont2.Visible = true;
            this.mm_scont2.VisibleIndex = 5;
            // 
            // Testmaggc
            // 
            this.Testmaggc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "Level1";
            this.Testmaggc.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.Testmaggc.Location = new System.Drawing.Point(6, 20);
            this.Testmaggc.MainView = this.gridView1;
            this.Testmaggc.Name = "Testmaggc";
            this.Testmaggc.Size = new System.Drawing.Size(1429, 605);
            this.Testmaggc.TabIndex = 1;
            this.Testmaggc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.an_descr1,
            this.tm_datdoc,
            this.tm_numdoc,
            this.tm_anno,
            this.tm_totdoc});
            this.gridView1.GridControl = this.Testmaggc;
            this.gridView1.Name = "gridView1";
            // 
            // an_descr1
            // 
            this.an_descr1.Caption = "Cliente";
            this.an_descr1.FieldName = "an_descr1";
            this.an_descr1.Name = "an_descr1";
            this.an_descr1.Visible = true;
            this.an_descr1.VisibleIndex = 0;
            // 
            // tm_datdoc
            // 
            this.tm_datdoc.Caption = "Data";
            this.tm_datdoc.FieldName = "tm_datdoc";
            this.tm_datdoc.Name = "tm_datdoc";
            this.tm_datdoc.Visible = true;
            this.tm_datdoc.VisibleIndex = 1;
            // 
            // tm_numdoc
            // 
            this.tm_numdoc.Caption = "Numero Doc";
            this.tm_numdoc.FieldName = "tm_numdoc";
            this.tm_numdoc.Name = "tm_numdoc";
            this.tm_numdoc.Visible = true;
            this.tm_numdoc.VisibleIndex = 2;
            // 
            // tm_anno
            // 
            this.tm_anno.Caption = "Anno Doc";
            this.tm_anno.FieldName = "tm_anno";
            this.tm_anno.Name = "tm_anno";
            this.tm_anno.Visible = true;
            this.tm_anno.VisibleIndex = 3;
            // 
            // tm_totdoc
            // 
            this.tm_totdoc.Caption = "Totale";
            this.tm_totdoc.FieldName = "tm_totdoc";
            this.tm_totdoc.Name = "tm_totdoc";
            this.tm_totdoc.Visible = true;
            this.tm_totdoc.VisibleIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Exortbtn);
            this.groupBox1.Controls.Add(this.Searchbtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1441, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Exortbtn
            // 
            this.Exortbtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Exortbtn.ImageOptions.Image")));
            this.Exortbtn.Location = new System.Drawing.Point(604, 33);
            this.Exortbtn.Name = "Exortbtn";
            this.Exortbtn.Size = new System.Drawing.Size(84, 23);
            this.Exortbtn.TabIndex = 5;
            this.Exortbtn.Text = "Esporta";
            this.Exortbtn.Click += new System.EventHandler(this.Exortbtn_Click);
            // 
            // Searchbtn
            // 
            this.Searchbtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Searchbtn.ImageOptions.Image")));
            this.Searchbtn.Location = new System.Drawing.Point(511, 34);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(75, 23);
            this.Searchbtn.TabIndex = 4;
            this.Searchbtn.Text = "Cerca";
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "A Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Da Data";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(278, 36);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Testmaggc);
            this.groupBox2.Location = new System.Drawing.Point(12, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1441, 631);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // FrmVenduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1465, 722);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmVenduto";
            this.Text = "Venduto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Testmaggc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton Searchbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.SimpleButton Exortbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl Testmaggc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn an_descr1;
        private DevExpress.XtraGrid.Columns.GridColumn tm_datdoc;
        private DevExpress.XtraGrid.Columns.GridColumn tm_numdoc;
        private DevExpress.XtraGrid.Columns.GridColumn tm_anno;
        private DevExpress.XtraGrid.Columns.GridColumn tm_totdoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn mm_codart;
        private DevExpress.XtraGrid.Columns.GridColumn mm_descr;
        private DevExpress.XtraGrid.Columns.GridColumn mm_quant;
        private DevExpress.XtraGrid.Columns.GridColumn mm_prezzo;
        private DevExpress.XtraGrid.Columns.GridColumn mm_scont1;
        private DevExpress.XtraGrid.Columns.GridColumn mm_scont2;
    }
}