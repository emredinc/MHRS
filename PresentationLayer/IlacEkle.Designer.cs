namespace PresentationLayer
{
    partial class IlacEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IlacEkle));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtIlac = new DevExpress.XtraEditors.TextEdit();
            this.btnIlacEkle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtIlac.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.labelControl1.Location = new System.Drawing.Point(73, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(194, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Eklemek İstediğiniz İlacı Yazıız";
            // 
            // txtIlac
            // 
            this.txtIlac.EditValue = "";
            this.txtIlac.Location = new System.Drawing.Point(73, 45);
            this.txtIlac.Name = "txtIlac";
            this.txtIlac.Size = new System.Drawing.Size(194, 20);
            this.txtIlac.TabIndex = 1;
            // 
            // btnIlacEkle
            // 
            this.btnIlacEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnIlacEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnIlacEkle.Image")));
            this.btnIlacEkle.Location = new System.Drawing.Point(73, 80);
            this.btnIlacEkle.Name = "btnIlacEkle";
            this.btnIlacEkle.Size = new System.Drawing.Size(194, 31);
            this.btnIlacEkle.TabIndex = 2;
            this.btnIlacEkle.Text = "İlaç Ekle";
            this.btnIlacEkle.Click += new System.EventHandler(this.btnIlacEkle_Click);
            // 
            // IlacEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(344, 164);
            this.Controls.Add(this.btnIlacEkle);
            this.Controls.Add(this.txtIlac);
            this.Controls.Add(this.labelControl1);
            this.Name = "IlacEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IlacEkle";
            ((System.ComponentModel.ISupportInitialize)(this.txtIlac.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtIlac;
        private DevExpress.XtraEditors.SimpleButton btnIlacEkle;
    }
}