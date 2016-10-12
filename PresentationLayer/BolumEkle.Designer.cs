namespace PresentationLayer
{
    partial class BolumEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BolumEkle));
            this.btnBolumEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txtBolum = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtBolum.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBolumEkle
            // 
            this.btnBolumEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnBolumEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnBolumEkle.Image")));
            this.btnBolumEkle.Location = new System.Drawing.Point(63, 80);
            this.btnBolumEkle.Name = "btnBolumEkle";
            this.btnBolumEkle.Size = new System.Drawing.Size(194, 31);
            this.btnBolumEkle.TabIndex = 5;
            this.btnBolumEkle.Text = "Bölüm Ekle";
            this.btnBolumEkle.Click += new System.EventHandler(this.btnBolumEkle_Click);
            // 
            // txtBolum
            // 
            this.txtBolum.EditValue = "";
            this.txtBolum.Location = new System.Drawing.Point(63, 45);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(194, 20);
            this.txtBolum.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.labelControl1.Location = new System.Drawing.Point(63, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(214, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Eklemek İstediğiniz Bölümü Yazıız";
            // 
            // BolumEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(331, 136);
            this.Controls.Add(this.btnBolumEkle);
            this.Controls.Add(this.txtBolum);
            this.Controls.Add(this.labelControl1);
            this.Name = "BolumEkle";
            this.Text = "BolumEkle";
            ((System.ComponentModel.ISupportInitialize)(this.txtBolum.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnBolumEkle;
        private DevExpress.XtraEditors.TextEdit txtBolum;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}