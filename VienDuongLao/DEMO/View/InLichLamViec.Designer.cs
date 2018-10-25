namespace DEMO.View
{
    partial class InLichLamViec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InLichLamViec));
            this.gridLichLamViec = new DevExpress.XtraGrid.GridControl();
            this.gridViewLichLamViec = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnInLoc = new DevExpress.XtraEditors.SimpleButton();
            this.btnInToanBo = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnQuayLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnToi = new DevExpress.XtraEditors.SimpleButton();
            this.nhomTacVu = new DevExpress.XtraEditors.PanelControl();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnChieu = new DevExpress.XtraEditors.SimpleButton();
            this.btnSang = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridLichLamViec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLichLamViec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhomTacVu)).BeginInit();
            this.nhomTacVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridLichLamViec
            // 
            this.gridLichLamViec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLichLamViec.Location = new System.Drawing.Point(2, 23);
            this.gridLichLamViec.MainView = this.gridViewLichLamViec;
            this.gridLichLamViec.Name = "gridLichLamViec";
            this.gridLichLamViec.Size = new System.Drawing.Size(1192, 316);
            this.gridLichLamViec.TabIndex = 0;
            this.gridLichLamViec.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLichLamViec});
            // 
            // gridViewLichLamViec
            // 
            this.gridViewLichLamViec.GridControl = this.gridLichLamViec;
            this.gridViewLichLamViec.Name = "gridViewLichLamViec";
            this.gridViewLichLamViec.OptionsView.ShowGroupPanel = false;
            // 
            // btnInLoc
            // 
            this.btnInLoc.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInLoc.Appearance.Options.UseFont = true;
            this.btnInLoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInLoc.ImageOptions.Image")));
            this.btnInLoc.Location = new System.Drawing.Point(54, 91);
            this.btnInLoc.Name = "btnInLoc";
            this.btnInLoc.Size = new System.Drawing.Size(150, 40);
            this.btnInLoc.TabIndex = 1;
            this.btnInLoc.Text = "In chọn lọc";
            this.btnInLoc.Click += new System.EventHandler(this.btnInLoc_Click);
            // 
            // btnInToanBo
            // 
            this.btnInToanBo.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInToanBo.Appearance.Options.UseFont = true;
            this.btnInToanBo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInToanBo.ImageOptions.Image")));
            this.btnInToanBo.Location = new System.Drawing.Point(54, 34);
            this.btnInToanBo.Name = "btnInToanBo";
            this.btnInToanBo.Size = new System.Drawing.Size(150, 40);
            this.btnInToanBo.TabIndex = 0;
            this.btnInToanBo.Text = "In toàn bộ";
            this.btnInToanBo.Click += new System.EventHandler(this.btnInToanBo_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridLichLamViec);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 158);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1196, 341);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Danh sách";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Appearance.Options.UseFont = true;
            this.btnQuayLai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuayLai.ImageOptions.Image")));
            this.btnQuayLai.Location = new System.Drawing.Point(711, 60);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(150, 37);
            this.btnQuayLai.TabIndex = 11;
            this.btnQuayLai.Text = "Quay lại";
            // 
            // btnToi
            // 
            this.btnToi.Location = new System.Drawing.Point(520, 45);
            this.btnToi.Name = "btnToi";
            this.btnToi.Size = new System.Drawing.Size(97, 30);
            this.btnToi.TabIndex = 2;
            this.btnToi.Text = "Buổi tối";
            this.btnToi.Click += new System.EventHandler(this.btnToi_Click);
            // 
            // nhomTacVu
            // 
            this.nhomTacVu.Controls.Add(this.btnQuayLai);
            this.nhomTacVu.Controls.Add(this.btnIn);
            this.nhomTacVu.Controls.Add(this.btnToi);
            this.nhomTacVu.Controls.Add(this.btnChieu);
            this.nhomTacVu.Controls.Add(this.btnSang);
            this.nhomTacVu.Dock = System.Windows.Forms.DockStyle.Right;
            this.nhomTacVu.Location = new System.Drawing.Point(286, 20);
            this.nhomTacVu.Name = "nhomTacVu";
            this.nhomTacVu.Size = new System.Drawing.Size(908, 136);
            this.nhomTacVu.TabIndex = 2;
            // 
            // btnIn
            // 
            this.btnIn.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Appearance.Options.UseFont = true;
            this.btnIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.ImageOptions.Image")));
            this.btnIn.Location = new System.Drawing.Point(711, 14);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(150, 40);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "In kết quả";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnChieu
            // 
            this.btnChieu.Location = new System.Drawing.Point(334, 45);
            this.btnChieu.Name = "btnChieu";
            this.btnChieu.Size = new System.Drawing.Size(97, 30);
            this.btnChieu.TabIndex = 1;
            this.btnChieu.Text = "Buổi chiều";
            this.btnChieu.Click += new System.EventHandler(this.btnChieu_Click);
            // 
            // btnSang
            // 
            this.btnSang.Location = new System.Drawing.Point(158, 45);
            this.btnSang.Name = "btnSang";
            this.btnSang.Size = new System.Drawing.Size(97, 30);
            this.btnSang.TabIndex = 0;
            this.btnSang.Text = "Buổi sáng";
            this.btnSang.Click += new System.EventHandler(this.btnSang_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.nhomTacVu);
            this.groupControl1.Controls.Add(this.btnInLoc);
            this.groupControl1.Controls.Add(this.btnInToanBo);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1196, 158);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Tác vụ";
            // 
            // InLichLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 499);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "InLichLamViec";
            this.Text = "Lịch làm việc";
            this.Load += new System.EventHandler(this.InLichLamViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLichLamViec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLichLamViec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nhomTacVu)).EndInit();
            this.nhomTacVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridLichLamViec;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLichLamViec;
        private DevExpress.XtraEditors.SimpleButton btnInLoc;
        private DevExpress.XtraEditors.SimpleButton btnInToanBo;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnQuayLai;
        private DevExpress.XtraEditors.SimpleButton btnToi;
        private DevExpress.XtraEditors.PanelControl nhomTacVu;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.SimpleButton btnChieu;
        private DevExpress.XtraEditors.SimpleButton btnSang;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}