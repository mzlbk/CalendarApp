
namespace CalendarApp
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.darkMode = new System.Windows.Forms.Label();
            this.darkModeSwitch = new DevExpress.XtraEditors.ToggleSwitch();
            this.btnX = new System.Windows.Forms.Button();
            this.btnTamEkran = new System.Windows.Forms.Button();
            this.btnSimge = new System.Windows.Forms.Button();
            this.altLabel = new System.Windows.Forms.Label();
            this.solLabel = new System.Windows.Forms.Label();
            this.sagLabel = new System.Windows.Forms.Label();
            this.timerMove = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.darkModeSwitch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(747, 38);
            this.label1.TabIndex = 0;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // darkMode
            // 
            this.darkMode.AutoSize = true;
            this.darkMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.darkMode.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.darkMode.ForeColor = System.Drawing.Color.White;
            this.darkMode.Location = new System.Drawing.Point(15, 10);
            this.darkMode.Name = "darkMode";
            this.darkMode.Size = new System.Drawing.Size(77, 17);
            this.darkMode.TabIndex = 1;
            this.darkMode.Text = "Dark Mode";
            // 
            // darkModeSwitch
            // 
            this.darkModeSwitch.EditValue = true;
            this.darkModeSwitch.Location = new System.Drawing.Point(98, 10);
            this.darkModeSwitch.Name = "darkModeSwitch";
            this.darkModeSwitch.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.darkModeSwitch.Properties.Appearance.Options.UseBackColor = true;
            this.darkModeSwitch.Properties.OffText = "";
            this.darkModeSwitch.Properties.OnText = "";
            this.darkModeSwitch.Size = new System.Drawing.Size(49, 18);
            this.darkModeSwitch.TabIndex = 2;
            // 
            // btnX
            // 
            this.btnX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Location = new System.Drawing.Point(716, 0);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(31, 38);
            this.btnX.TabIndex = 3;
            this.btnX.Text = "✖";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnTamEkran
            // 
            this.btnTamEkran.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTamEkran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.btnTamEkran.FlatAppearance.BorderSize = 0;
            this.btnTamEkran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTamEkran.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamEkran.ForeColor = System.Drawing.Color.White;
            this.btnTamEkran.Location = new System.Drawing.Point(685, 0);
            this.btnTamEkran.Name = "btnTamEkran";
            this.btnTamEkran.Size = new System.Drawing.Size(29, 38);
            this.btnTamEkran.TabIndex = 4;
            this.btnTamEkran.Text = "▢";
            this.btnTamEkran.UseVisualStyleBackColor = false;
            this.btnTamEkran.Click += new System.EventHandler(this.btnTamEkran_Click);
            // 
            // btnSimge
            // 
            this.btnSimge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.btnSimge.FlatAppearance.BorderSize = 0;
            this.btnSimge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimge.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSimge.ForeColor = System.Drawing.Color.White;
            this.btnSimge.Location = new System.Drawing.Point(653, 0);
            this.btnSimge.Name = "btnSimge";
            this.btnSimge.Size = new System.Drawing.Size(29, 38);
            this.btnSimge.TabIndex = 5;
            this.btnSimge.Text = "⎯";
            this.btnSimge.UseVisualStyleBackColor = false;
            this.btnSimge.Click += new System.EventHandler(this.btnSimge_Click);
            // 
            // altLabel
            // 
            this.altLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.altLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.altLabel.Location = new System.Drawing.Point(0, 477);
            this.altLabel.Name = "altLabel";
            this.altLabel.Size = new System.Drawing.Size(747, 3);
            this.altLabel.TabIndex = 6;
            // 
            // solLabel
            // 
            this.solLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.solLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.solLabel.Location = new System.Drawing.Point(0, 38);
            this.solLabel.Name = "solLabel";
            this.solLabel.Size = new System.Drawing.Size(3, 439);
            this.solLabel.TabIndex = 7;
            // 
            // sagLabel
            // 
            this.sagLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.sagLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sagLabel.Location = new System.Drawing.Point(744, 38);
            this.sagLabel.Name = "sagLabel";
            this.sagLabel.Size = new System.Drawing.Size(3, 439);
            this.sagLabel.TabIndex = 8;
            // 
            // timerMove
            // 
            this.timerMove.Interval = 1;
            this.timerMove.Tick += new System.EventHandler(this.timerMove_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(747, 480);
            this.Controls.Add(this.sagLabel);
            this.Controls.Add(this.solLabel);
            this.Controls.Add(this.altLabel);
            this.Controls.Add(this.btnSimge);
            this.Controls.Add(this.btnTamEkran);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.darkModeSwitch);
            this.Controls.Add(this.darkMode);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.darkModeSwitch.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label darkMode;
        private DevExpress.XtraEditors.ToggleSwitch darkModeSwitch;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnTamEkran;
        private System.Windows.Forms.Button btnSimge;
        private System.Windows.Forms.Label altLabel;
        private System.Windows.Forms.Label solLabel;
        private System.Windows.Forms.Label sagLabel;
        private System.Windows.Forms.Timer timerMove;
    }
}

