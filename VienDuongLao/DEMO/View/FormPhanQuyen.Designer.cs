namespace DEMO.View
{
    partial class FormPhanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhanQuyen));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridPhanQuyen = new DevExpress.XtraGrid.GridControl();
            this.gridViewPhanQuyen = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.txtNgaySinh = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtQueQuan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbPhatTu = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnHuyBo = new DevExpress.XtraEditors.SimpleButton();
            this.btnThayDoi = new DevExpress.XtraEditors.SimpleButton();
            this.ckPhatTu = new DevExpress.XtraEditors.CheckEdit();
            this.ckNguoiNuoi = new DevExpress.XtraEditors.CheckEdit();
            this.ckChiTietPhong = new DevExpress.XtraEditors.CheckEdit();
            this.ckQuanLyPhong = new DevExpress.XtraEditors.CheckEdit();
            this.btnCapQuyen = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueQuan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPhatTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckPhatTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckNguoiNuoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckChiTietPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckQuanLyPhong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridPhanQuyen);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(721, 597);
            this.groupControl1.TabIndex = 0;
            // 
            // gridPhanQuyen
            // 
            this.gridPhanQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPhanQuyen.Location = new System.Drawing.Point(2, 238);
            this.gridPhanQuyen.MainView = this.gridViewPhanQuyen;
            this.gridPhanQuyen.Name = "gridPhanQuyen";
            this.gridPhanQuyen.Size = new System.Drawing.Size(717, 357);
            this.gridPhanQuyen.TabIndex = 10;
            this.gridPhanQuyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPhanQuyen});
            // 
            // gridViewPhanQuyen
            // 
            this.gridViewPhanQuyen.GridControl = this.gridPhanQuyen;
            this.gridViewPhanQuyen.Name = "gridViewPhanQuyen";
            this.gridViewPhanQuyen.OptionsView.ShowGroupPanel = false;
            this.gridViewPhanQuyen.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewPhanQuyen_RowClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCapQuyen);
            this.panelControl1.Controls.Add(this.btnTimKiem);
            this.panelControl1.Controls.Add(this.txtNgaySinh);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txtQueQuan);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txtMaTaiKhoan);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.cbPhatTu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 20);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(717, 218);
            this.panelControl1.TabIndex = 9;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Appearance.Options.UseFont = true;
            this.btnTimKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageOptions.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(45, 133);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(128, 49);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Xem quyền";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(440, 105);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaySinh.Properties.Appearance.Options.UseFont = true;
            this.txtNgaySinh.Size = new System.Drawing.Size(258, 26);
            this.txtNgaySinh.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(349, 163);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(64, 19);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Quê quán";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(440, 160);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueQuan.Properties.Appearance.Options.UseFont = true;
            this.txtQueQuan.Size = new System.Drawing.Size(258, 26);
            this.txtQueQuan.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(53, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(247, 22);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Chọn tài khoản cần cấp quyền";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(348, 108);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 19);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Ngày sinh";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(419, 19);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(236, 22);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "THÔNG TIN TƯƠNG ỨNG";
            // 
            // txtMaTaiKhoan
            // 
            this.txtMaTaiKhoan.Location = new System.Drawing.Point(440, 55);
            this.txtMaTaiKhoan.Name = "txtMaTaiKhoan";
            this.txtMaTaiKhoan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTaiKhoan.Properties.Appearance.Options.UseFont = true;
            this.txtMaTaiKhoan.Size = new System.Drawing.Size(258, 26);
            this.txtMaTaiKhoan.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(329, 58);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(104, 19);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Mã phân quyền";
            // 
            // cbPhatTu
            // 
            this.cbPhatTu.Location = new System.Drawing.Point(45, 85);
            this.cbPhatTu.Name = "cbPhatTu";
            this.cbPhatTu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPhatTu.Properties.Appearance.Options.UseFont = true;
            this.cbPhatTu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPhatTu.Properties.NullText = "";
            this.cbPhatTu.Properties.PopupSizeable = false;
            this.cbPhatTu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbPhatTu.Size = new System.Drawing.Size(262, 26);
            this.cbPhatTu.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.panelControl2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(721, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(315, 597);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Danh sách";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnHuyBo);
            this.panelControl2.Controls.Add(this.btnThayDoi);
            this.panelControl2.Controls.Add(this.ckPhatTu);
            this.panelControl2.Controls.Add(this.ckNguoiNuoi);
            this.panelControl2.Controls.Add(this.ckChiTietPhong);
            this.panelControl2.Controls.Add(this.ckQuanLyPhong);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 20);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(311, 575);
            this.panelControl2.TabIndex = 0;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.Appearance.Options.UseFont = true;
            this.btnHuyBo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyBo.ImageOptions.Image")));
            this.btnHuyBo.Location = new System.Drawing.Point(181, 524);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(94, 41);
            this.btnHuyBo.TabIndex = 5;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnThayDoi
            // 
            this.btnThayDoi.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThayDoi.Appearance.Options.UseFont = true;
            this.btnThayDoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThayDoi.ImageOptions.Image")));
            this.btnThayDoi.Location = new System.Drawing.Point(67, 524);
            this.btnThayDoi.Name = "btnThayDoi";
            this.btnThayDoi.Size = new System.Drawing.Size(94, 41);
            this.btnThayDoi.TabIndex = 4;
            this.btnThayDoi.Text = "Thay đổi";
            this.btnThayDoi.Click += new System.EventHandler(this.btnThayDoi_Click);
            // 
            // ckPhatTu
            // 
            this.ckPhatTu.Location = new System.Drawing.Point(16, 134);
            this.ckPhatTu.Name = "ckPhatTu";
            this.ckPhatTu.Properties.Caption = "Quản lý phật tử";
            this.ckPhatTu.Size = new System.Drawing.Size(273, 19);
            this.ckPhatTu.TabIndex = 3;
            // 
            // ckNguoiNuoi
            // 
            this.ckNguoiNuoi.Location = new System.Drawing.Point(16, 99);
            this.ckNguoiNuoi.Name = "ckNguoiNuoi";
            this.ckNguoiNuoi.Properties.Caption = "Quản lý người được nuôi dưỡng";
            this.ckNguoiNuoi.Size = new System.Drawing.Size(273, 19);
            this.ckNguoiNuoi.TabIndex = 2;
            // 
            // ckChiTietPhong
            // 
            this.ckChiTietPhong.Location = new System.Drawing.Point(16, 64);
            this.ckChiTietPhong.Name = "ckChiTietPhong";
            this.ckChiTietPhong.Properties.Caption = "Quản lý chi tiết phòng ở";
            this.ckChiTietPhong.Size = new System.Drawing.Size(273, 19);
            this.ckChiTietPhong.TabIndex = 1;
            // 
            // ckQuanLyPhong
            // 
            this.ckQuanLyPhong.Location = new System.Drawing.Point(16, 29);
            this.ckQuanLyPhong.Name = "ckQuanLyPhong";
            this.ckQuanLyPhong.Properties.Caption = "Quản lý phòng ở";
            this.ckQuanLyPhong.Size = new System.Drawing.Size(273, 19);
            this.ckQuanLyPhong.TabIndex = 0;
            // 
            // btnCapQuyen
            // 
            this.btnCapQuyen.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapQuyen.Appearance.Options.UseFont = true;
            this.btnCapQuyen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnCapQuyen.Location = new System.Drawing.Point(179, 133);
            this.btnCapQuyen.Name = "btnCapQuyen";
            this.btnCapQuyen.Size = new System.Drawing.Size(128, 49);
            this.btnCapQuyen.TabIndex = 10;
            this.btnCapQuyen.Text = "Cấp quyền";
            this.btnCapQuyen.Click += new System.EventHandler(this.btnCapQuyen_Click);
            // 
            // FormPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 597);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FormPhanQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấp quyền";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPhanQuyen_FormClosed);
            this.Load += new System.EventHandler(this.FormPhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueQuan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPhatTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ckPhatTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckNguoiNuoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckChiTietPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckQuanLyPhong.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtQueQuan;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtNgaySinh;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtMaTaiKhoan;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridPhanQuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPhanQuyen;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.CheckEdit ckQuanLyPhong;
        private DevExpress.XtraEditors.CheckEdit ckPhatTu;
        private DevExpress.XtraEditors.CheckEdit ckNguoiNuoi;
        private DevExpress.XtraEditors.CheckEdit ckChiTietPhong;
        private DevExpress.XtraEditors.LookUpEdit cbPhatTu;
        private DevExpress.XtraEditors.SimpleButton btnHuyBo;
        private DevExpress.XtraEditors.SimpleButton btnThayDoi;
        private DevExpress.XtraEditors.SimpleButton btnCapQuyen;
    }
}