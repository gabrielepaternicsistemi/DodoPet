namespace DodoPet
{
    partial class FrmImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImport));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnClear = new DevExpress.XtraEditors.SimpleButton();
            this.BtnCarica = new DevExpress.XtraEditors.SimpleButton();
            this.BtnScegliFile = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImporta = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.btnImporta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnScegliFile);
            this.groupBox1.Controls.Add(this.BtnCarica);
            this.groupBox1.Controls.Add(this.BtnClear);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1531, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // BtnClear
            // 
            this.BtnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnClear.ImageOptions.Image")));
            this.BtnClear.Location = new System.Drawing.Point(1347, 20);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(178, 44);
            this.BtnClear.TabIndex = 0;
            this.BtnClear.Text = "Svuota Importazione";
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnCarica
            // 
            this.BtnCarica.Enabled = false;
            this.BtnCarica.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image2")));
            this.BtnCarica.Location = new System.Drawing.Point(140, 20);
            this.BtnCarica.Name = "BtnCarica";
            this.BtnCarica.Size = new System.Drawing.Size(113, 44);
            this.BtnCarica.TabIndex = 1;
            this.BtnCarica.Text = "Carica";
            this.BtnCarica.Click += new System.EventHandler(this.BtnCarica_Click);
            // 
            // BtnScegliFile
            // 
            this.BtnScegliFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image1")));
            this.BtnScegliFile.Location = new System.Drawing.Point(6, 20);
            this.BtnScegliFile.Name = "BtnScegliFile";
            this.BtnScegliFile.Size = new System.Drawing.Size(128, 44);
            this.BtnScegliFile.TabIndex = 2;
            this.BtnScegliFile.Text = "Seleziona File";
            this.BtnScegliFile.Click += new System.EventHandler(this.BtnScegliFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOME FILE:";
            // 
            // btnImporta
            // 
            this.btnImporta.Enabled = false;
            this.btnImporta.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnImporta.Location = new System.Drawing.Point(630, 20);
            this.btnImporta.Name = "btnImporta";
            this.btnImporta.Size = new System.Drawing.Size(113, 44);
            this.btnImporta.TabIndex = 4;
            this.btnImporta.Text = "Elabora";
            // 
            // FrmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1555, 631);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmImport";
            this.Text = "Importa da File";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton BtnClear;
        private DevExpress.XtraEditors.SimpleButton BtnScegliFile;
        private DevExpress.XtraEditors.SimpleButton BtnCarica;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnImporta;
    }
}