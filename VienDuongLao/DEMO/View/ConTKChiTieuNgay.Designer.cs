namespace DEMO.View
{
    partial class ConTKChiTieuNgay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConTKChiTieuNgay));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.txtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridTKChiTieu = new DevExpress.XtraGrid.GridControl();
            this.gridViewTKChiTieu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnTungNgay = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoiNgay = new DevExpress.XtraEditors.SimpleButton();
            this.btnInKetQua = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuyBo = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTKChiTieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTKChiTieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnTungNgay);
            this.panelControl1.Controls.Add(this.btnMoiNgay);
            this.panelControl1.Controls.Add(this.btnInKetQua);
            this.panelControl1.Controls.Add(this.btnHuyBo);
            this.panelControl1.Controls.Add(this.txtDenNgay);
            this.panelControl1.Controls.Add(this.txtTuNgay);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1136, 116);
            this.panelControl1.TabIndex = 3;
            // 
            // txtDenNgay
            // 
            this.txtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDenNgay.Location = new System.Drawing.Point(370, 64);
            this.txtDenNgay.Name = "txtDenNgay";
            this.txtDenNgay.Size = new System.Drawing.Size(225, 21);
            this.txtDenNgay.TabIndex = 13;
            // 
            // txtTuNgay
            // 
            this.txtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtTuNgay.Location = new System.Drawing.Point(78, 64);
            this.txtTuNgay.Name = "txtTuNgay";
            this.txtTuNgay.Size = new System.Drawing.Size(225, 21);
            this.txtTuNgay.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(435, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Từ ngày";
            // 
            // gridTKChiTieu
            // 
            this.gridTKChiTieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTKChiTieu.Location = new System.Drawing.Point(2, 20);
            this.gridTKChiTieu.MainView = this.gridViewTKChiTieu;
            this.gridTKChiTieu.Name = "gridTKChiTieu";
            this.gridTKChiTieu.Size = new System.Drawing.Size(1132, 359);
            this.gridTKChiTieu.TabIndex = 0;
            this.gridTKChiTieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTKChiTieu});
            // 
            // gridViewTKChiTieu
            // 
            this.gridViewTKChiTieu.GridControl = this.gridTKChiTieu;
            this.gridViewTKChiTieu.Name = "gridViewTKChiTieu";
            this.gridViewTKChiTieu.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gridTKChiTieu);
            this.groupControl1.Location = new System.Drawing.Point(0, 118);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1136, 381);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Kết quả thống kê";
            // 
            // btnTungNgay
            // 
            this.btnTungNgay.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTungNgay.Appearance.Options.UseFont = true;
            this.btnTungNgay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTungNgay.ImageOptions.Image")));
            this.btnTungNgay.Location = new System.Drawing.Point(691, 74);
            this.btnTungNgay.Name = "btnTungNgay";
            this.btnTungNgay.Size = new System.Drawing.Size(142, 28);
            this.btnTungNgay.TabIndex = 21;
            this.btnTungNgay.Text = "THEO TỪNG NGÀY";
            this.btnTungNgay.Click += new System.EventHandler(this.btnTungNgay_Click);
            // 
            // btnMoiNgay
            // 
            this.btnMoiNgay.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoiNgay.Appearance.Options.UseFont = true;
            this.btnMoiNgay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMoiNgay.ImageOptions.Image")));
            this.btnMoiNgay.Location = new System.Drawing.Point(691, 35);
            this.btnMoiNgay.Name = "btnMoiNgay";
            this.btnMoiNgay.Size = new System.Drawing.Size(142, 28);
            this.btnMoiNgay.TabIndex = 20;
            this.btnMoiNgay.Text = "THEO MỌI NGÀY";
            this.btnMoiNgay.Click += new System.EventHandler(this.btnMoiNgay_Click);
            // 
            // btnInKetQua
            // 
            this.btnInKetQua.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInKetQua.Appearance.Options.UseFont = true;
            this.btnInKetQua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInKetQua.ImageOptions.Image")));
            this.btnInKetQua.Location = new System.Drawing.Point(856, 28);
            this.btnInKetQua.Name = "btnInKetQua";
            this.btnInKetQua.Size = new System.Drawing.Size(156, 39);
            this.btnInKetQua.TabIndex = 19;
            this.btnInKetQua.Text = "IN KẾT QUẢ";
            this.btnInKetQua.Click += new System.EventHandler(this.btnInKetQua_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.Appearance.Options.UseFont = true;
            this.btnHuyBo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyBo.ImageOptions.Image")));
            this.btnHuyBo.Location = new System.Drawing.Point(888, 69);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(83, 34);
            this.btnHuyBo.TabIndex = 18;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // ConTKChiTieuNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 499);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "ConTKChiTieuNgay";
            this.Text = "Chi tiêu ngày";
            this.Load += new System.EventHandler(this.ConTKChiTieuNgay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTKChiTieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTKChiTieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.DateTimePicker txtDenNgay;
        private System.Windows.Forms.DateTimePicker txtTuNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridTKChiTieu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTKChiTieu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnTungNgay;
        private DevExpress.XtraEditors.SimpleButton btnMoiNgay;
        private DevExpress.XtraEditors.SimpleButton btnInKetQua;
        private DevExpress.XtraEditors.SimpleButton btnHuyBo;
    }
}