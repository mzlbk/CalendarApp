
namespace CalendarApp
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
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
            this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.btnNext = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnPrev = new Bunifu.UI.WinForms.BunifuImageButton();
            this.lblPazartesi = new System.Windows.Forms.Label();
            this.lblSali = new System.Windows.Forms.Label();
            this.lblPersembe = new System.Windows.Forms.Label();
            this.lblCarsamba = new System.Windows.Forms.Label();
            this.lblCumartesi = new System.Windows.Forms.Label();
            this.lblCuma = new System.Windows.Forms.Label();
            this.lblPazar = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.darkModeSwitch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(1328, 38);
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
            this.btnX.Location = new System.Drawing.Point(1297, 0);
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
            this.btnTamEkran.Location = new System.Drawing.Point(1266, 0);
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
            this.btnSimge.Location = new System.Drawing.Point(1234, 0);
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
            this.altLabel.Location = new System.Drawing.Point(0, 761);
            this.altLabel.Name = "altLabel";
            this.altLabel.Size = new System.Drawing.Size(1328, 3);
            this.altLabel.TabIndex = 6;
            // 
            // solLabel
            // 
            this.solLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.solLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.solLabel.Location = new System.Drawing.Point(0, 38);
            this.solLabel.Name = "solLabel";
            this.solLabel.Size = new System.Drawing.Size(3, 723);
            this.solLabel.TabIndex = 7;
            // 
            // sagLabel
            // 
            this.sagLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.sagLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sagLabel.Location = new System.Drawing.Point(1325, 38);
            this.sagLabel.Name = "sagLabel";
            this.sagLabel.Size = new System.Drawing.Size(3, 723);
            this.sagLabel.TabIndex = 8;
            // 
            // timerMove
            // 
            this.timerMove.Interval = 1;
            this.timerMove.Tick += new System.EventHandler(this.timerMove_Tick);
            // 
            // daycontainer
            // 
            this.daycontainer.Location = new System.Drawing.Point(611, 126);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(708, 495);
            this.daycontainer.TabIndex = 9;
            // 
            // btnNext
            // 
            this.btnNext.ActiveImage = null;
            this.btnNext.AllowAnimations = true;
            this.btnNext.AllowBuffering = false;
            this.btnNext.AllowToggling = false;
            this.btnNext.AllowZooming = true;
            this.btnNext.AllowZoomingOnFocus = false;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNext.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnNext.ErrorImage")));
            this.btnNext.FadeWhenInactive = false;
            this.btnNext.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageActive = null;
            this.btnNext.ImageLocation = null;
            this.btnNext.ImageMargin = 40;
            this.btnNext.ImageSize = new System.Drawing.Size(42, 31);
            this.btnNext.ImageZoomSize = new System.Drawing.Size(82, 71);
            this.btnNext.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnNext.InitialImage")));
            this.btnNext.Location = new System.Drawing.Point(1237, 623);
            this.btnNext.Name = "btnNext";
            this.btnNext.Rotation = 0;
            this.btnNext.ShowActiveImage = true;
            this.btnNext.ShowCursorChanges = true;
            this.btnNext.ShowImageBorders = true;
            this.btnNext.ShowSizeMarkers = false;
            this.btnNext.Size = new System.Drawing.Size(82, 71);
            this.btnNext.TabIndex = 10;
            this.btnNext.ToolTipText = "";
            this.btnNext.WaitOnLoad = false;
            this.btnNext.Zoom = 40;
            this.btnNext.ZoomSpeed = 10;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.ActiveImage = null;
            this.btnPrev.AllowAnimations = true;
            this.btnPrev.AllowBuffering = false;
            this.btnPrev.AllowToggling = false;
            this.btnPrev.AllowZooming = true;
            this.btnPrev.AllowZoomingOnFocus = false;
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrev.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnPrev.ErrorImage")));
            this.btnPrev.FadeWhenInactive = false;
            this.btnPrev.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Horizontal;
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.ImageActive = null;
            this.btnPrev.ImageLocation = null;
            this.btnPrev.ImageMargin = 40;
            this.btnPrev.ImageSize = new System.Drawing.Size(42, 31);
            this.btnPrev.ImageZoomSize = new System.Drawing.Size(82, 71);
            this.btnPrev.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnPrev.InitialImage")));
            this.btnPrev.Location = new System.Drawing.Point(1149, 623);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Rotation = 0;
            this.btnPrev.ShowActiveImage = true;
            this.btnPrev.ShowCursorChanges = true;
            this.btnPrev.ShowImageBorders = true;
            this.btnPrev.ShowSizeMarkers = false;
            this.btnPrev.Size = new System.Drawing.Size(82, 71);
            this.btnPrev.TabIndex = 11;
            this.btnPrev.ToolTipText = "";
            this.btnPrev.WaitOnLoad = false;
            this.btnPrev.Zoom = 40;
            this.btnPrev.ZoomSpeed = 10;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblPazartesi
            // 
            this.lblPazartesi.AutoSize = true;
            this.lblPazartesi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPazartesi.Location = new System.Drawing.Point(627, 97);
            this.lblPazartesi.Name = "lblPazartesi";
            this.lblPazartesi.Size = new System.Drawing.Size(72, 19);
            this.lblPazartesi.TabIndex = 12;
            this.lblPazartesi.Text = "Pazartesi";
            // 
            // lblSali
            // 
            this.lblSali.AutoSize = true;
            this.lblSali.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSali.Location = new System.Drawing.Point(746, 97);
            this.lblSali.Name = "lblSali";
            this.lblSali.Size = new System.Drawing.Size(33, 19);
            this.lblSali.TabIndex = 13;
            this.lblSali.Text = "Salı";
            // 
            // lblPersembe
            // 
            this.lblPersembe.AutoSize = true;
            this.lblPersembe.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersembe.Location = new System.Drawing.Point(927, 97);
            this.lblPersembe.Name = "lblPersembe";
            this.lblPersembe.Size = new System.Drawing.Size(78, 19);
            this.lblPersembe.TabIndex = 15;
            this.lblPersembe.Text = "Perşembe";
            // 
            // lblCarsamba
            // 
            this.lblCarsamba.AutoSize = true;
            this.lblCarsamba.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCarsamba.Location = new System.Drawing.Point(826, 97);
            this.lblCarsamba.Name = "lblCarsamba";
            this.lblCarsamba.Size = new System.Drawing.Size(78, 19);
            this.lblCarsamba.TabIndex = 14;
            this.lblCarsamba.Text = "Çarşamba";
            // 
            // lblCumartesi
            // 
            this.lblCumartesi.AutoSize = true;
            this.lblCumartesi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCumartesi.Location = new System.Drawing.Point(1128, 97);
            this.lblCumartesi.Name = "lblCumartesi";
            this.lblCumartesi.Size = new System.Drawing.Size(79, 19);
            this.lblCumartesi.TabIndex = 17;
            this.lblCumartesi.Text = "Cumartesi";
            // 
            // lblCuma
            // 
            this.lblCuma.AutoSize = true;
            this.lblCuma.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCuma.Location = new System.Drawing.Point(1043, 97);
            this.lblCuma.Name = "lblCuma";
            this.lblCuma.Size = new System.Drawing.Size(48, 19);
            this.lblCuma.TabIndex = 16;
            this.lblCuma.Text = "Cuma";
            // 
            // lblPazar
            // 
            this.lblPazar.AutoSize = true;
            this.lblPazar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPazar.Location = new System.Drawing.Point(1244, 97);
            this.lblPazar.Name = "lblPazar";
            this.lblPazar.Size = new System.Drawing.Size(48, 19);
            this.lblPazar.TabIndex = 18;
            this.lblPazar.Text = "Pazar";
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(611, 57);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(708, 30);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "MONTH YEAR";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(78)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1328, 764);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPazar);
            this.Controls.Add(this.lblCumartesi);
            this.Controls.Add(this.lblCuma);
            this.Controls.Add(this.lblPersembe);
            this.Controls.Add(this.lblCarsamba);
            this.Controls.Add(this.lblSali);
            this.Controls.Add(this.lblPazartesi);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.daycontainer);
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
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.darkModeSwitch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel daycontainer;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private Bunifu.UI.WinForms.BunifuImageButton btnNext;
        private Bunifu.UI.WinForms.BunifuImageButton btnPrev;
        private System.Windows.Forms.Label lblPazartesi;
        private System.Windows.Forms.Label lblSali;
        private System.Windows.Forms.Label lblPersembe;
        private System.Windows.Forms.Label lblCarsamba;
        private System.Windows.Forms.Label lblCumartesi;
        private System.Windows.Forms.Label lblCuma;
        private System.Windows.Forms.Label lblPazar;
        private System.Windows.Forms.Label lblDate;
    }
}

