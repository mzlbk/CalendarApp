
namespace CalendarApp
{
    partial class UserControlBlank
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDaysv1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDaysv1
            // 
            this.lblDaysv1.AutoSize = true;
            this.lblDaysv1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDaysv1.Location = new System.Drawing.Point(16, 28);
            this.lblDaysv1.Name = "lblDaysv1";
            this.lblDaysv1.Size = new System.Drawing.Size(66, 19);
            this.lblDaysv1.TabIndex = 0;
            this.lblDaysv1.Text = "Geçiciv1";
            // 
            // UserControlBlank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(104)))));
            this.Controls.Add(this.lblDaysv1);
            this.Name = "UserControlBlank";
            this.Size = new System.Drawing.Size(95, 76);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDaysv1;
    }
}
