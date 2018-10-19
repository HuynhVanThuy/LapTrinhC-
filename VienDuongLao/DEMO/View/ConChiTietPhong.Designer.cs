namespace DEMO.View
{
    partial class ConChiTietPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConChiTietPhong));
            this.id_phongo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lbId_Chitiet = new DevExpress.XtraEditors.LabelControl();
            this.txtMaChiTiet = new DevExpress.XtraEditors.LookUpEdit();
            this.lbTenPhong = new DevExpress.XtraEditors.LabelControl();
            this.lbSoNguoi = new DevExpress.XtraEditors.LabelControl();
            this.txtSoNguoi = new DevExpress.XtraEditors.TextEdit();
            this.txtNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.lbMaNguoi = new DevExpress.XtraEditors.LabelControl();
            this.lbNgaySinh = new DevExpress.XtraEditors.LabelControl();
            this.lbHoTen = new DevExpress.XtraEditors.LabelControl();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.lbMaPhong = new DevExpress.XtraEditors.LabelControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaPhong = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTenPhong = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNguoi = new DevExpress.XtraEditors.LookUpEdit();
            this.gridVPhongOChiTiet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tenphong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id_nguoinuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hoten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.quequan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngaysinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hienco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id_chitietphong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridPhongOChiTiet = new DevExpress.XtraGrid.GridControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaChiTiet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoNguoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNguoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVPhongOChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhongOChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_phongo
            // 
            this.id_phongo.Caption = "Mã phòng";
            this.id_phongo.FieldName = "id_phongo";
            this.id_phongo.Name = "id_phongo";
            this.id_phongo.Visible = true;
            this.id_phongo.VisibleIndex = 0;
            this.id_phongo.Width = 67;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lbId_Chitiet);
            this.groupControl2.Controls.Add(this.txtMaChiTiet);
            this.groupControl2.Controls.Add(this.lbTenPhong);
            this.groupControl2.Controls.Add(this.lbSoNguoi);
            this.groupControl2.Controls.Add(this.txtSoNguoi);
            this.groupControl2.Controls.Add(this.txtNgaySinh);
            this.groupControl2.Controls.Add(this.lbMaNguoi);
            this.groupControl2.Controls.Add(this.lbNgaySinh);
            this.groupControl2.Controls.Add(this.lbHoTen);
            this.groupControl2.Controls.Add(this.txtHoTen);
            this.groupControl2.Controls.Add(this.lbMaPhong);
            this.groupControl2.Controls.Add(this.btnHuy);
            this.groupControl2.Controls.Add(this.btnLuu);
            this.groupControl2.Controls.Add(this.txtMaPhong);
            this.groupControl2.Controls.Add(this.txtTenPhong);
            this.groupControl2.Controls.Add(this.txtMaNguoi);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 49);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1191, 151);
            this.groupControl2.TabIndex = 18;
            this.groupControl2.Text = "Thông tin";
            // 
            // lbId_Chitiet
            // 
            this.lbId_Chitiet.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId_Chitiet.Appearance.Options.UseFont = true;
            this.lbId_Chitiet.Location = new System.Drawing.Point(29, 46);
            this.lbId_Chitiet.Name = "lbId_Chitiet";
            this.lbId_Chitiet.Size = new System.Drawing.Size(78, 21);
            this.lbId_Chitiet.TabIndex = 22;
            this.lbId_Chitiet.Text = "Mã chi tiết";
            this.lbId_Chitiet.Visible = false;
            // 
            // txtMaChiTiet
            // 
            this.txtMaChiTiet.Location = new System.Drawing.Point(126, 42);
            this.txtMaChiTiet.Name = "txtMaChiTiet";
            this.txtMaChiTiet.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaChiTiet.Properties.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.txtMaChiTiet.Properties.Appearance.Options.UseFont = true;
            this.txtMaChiTiet.Properties.Appearance.Options.UseForeColor = true;
            this.txtMaChiTiet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtMaChiTiet.Properties.NullText = "";
            this.txtMaChiTiet.Size = new System.Drawing.Size(174, 28);
            this.txtMaChiTiet.TabIndex = 23;
            this.txtMaChiTiet.Visible = false;
            // 
            // lbTenPhong
            // 
            this.lbTenPhong.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenPhong.Appearance.Options.UseFont = true;
            this.lbTenPhong.Location = new System.Drawing.Point(316, 46);
            this.lbTenPhong.Name = "lbTenPhong";
            this.lbTenPhong.Size = new System.Drawing.Size(81, 21);
            this.lbTenPhong.TabIndex = 20;
            this.lbTenPhong.Text = "Tên phòng";
            // 
            // lbSoNguoi
            // 
            this.lbSoNguoi.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoNguoi.Appearance.Options.UseFont = true;
            this.lbSoNguoi.Location = new System.Drawing.Point(608, 97);
            this.lbSoNguoi.Name = "lbSoNguoi";
            this.lbSoNguoi.Size = new System.Drawing.Size(124, 21);
            this.lbSoNguoi.TabIndex = 19;
            this.lbSoNguoi.Text = "Số người đang ở";
            // 
            // txtSoNguoi
            // 
            this.txtSoNguoi.Location = new System.Drawing.Point(752, 93);
            this.txtSoNguoi.Name = "txtSoNguoi";
            this.txtSoNguoi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNguoi.Properties.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.txtSoNguoi.Properties.Appearance.Options.UseFont = true;
            this.txtSoNguoi.Properties.Appearance.Options.UseForeColor = true;
            this.txtSoNguoi.Size = new System.Drawing.Size(174, 28);
            this.txtSoNguoi.TabIndex = 18;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.EditValue = null;
            this.txtNgaySinh.Location = new System.Drawing.Point(408, 94);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaySinh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.txtNgaySinh.Properties.Appearance.Options.UseFont = true;
            this.txtNgaySinh.Properties.Appearance.Options.UseForeColor = true;
            this.txtNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgaySinh.Size = new System.Drawing.Size(174, 26);
            this.txtNgaySinh.TabIndex = 17;
            // 
            // lbMaNguoi
            // 
            this.lbMaNguoi.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNguoi.Appearance.Options.UseFont = true;
            this.lbMaNguoi.Location = new System.Drawing.Point(598, 46);
            this.lbMaNguoi.Name = "lbMaNguoi";
            this.lbMaNguoi.Size = new System.Drawing.Size(138, 21);
            this.lbMaNguoi.TabIndex = 16;
            this.lbMaNguoi.Text = "Mã người ở phòng";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinh.Appearance.Options.UseFont = true;
            this.lbNgaySinh.Location = new System.Drawing.Point(317, 97);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(74, 21);
            this.lbNgaySinh.TabIndex = 14;
            this.lbNgaySinh.Text = "Ngày sinh";
            // 
            // lbHoTen
            // 
            this.lbHoTen.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Appearance.Options.UseFont = true;
            this.lbHoTen.Location = new System.Drawing.Point(35, 97);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(72, 21);
            this.lbHoTen.TabIndex = 10;
            this.lbHoTen.Text = "Họ và tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(126, 93);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Properties.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.txtHoTen.Properties.Appearance.Options.UseFont = true;
            this.txtHoTen.Properties.Appearance.Options.UseForeColor = true;
            this.txtHoTen.Size = new System.Drawing.Size(174, 28);
            this.txtHoTen.TabIndex = 9;
            // 
            // lbMaPhong
            // 
            this.lbMaPhong.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhong.Appearance.Options.UseFont = true;
            this.lbMaPhong.Location = new System.Drawing.Point(31, 46);
            this.lbMaPhong.Name = "lbMaPhong";
            this.lbMaPhong.Size = new System.Drawing.Size(76, 21);
            this.lbMaPhong.TabIndex = 6;
            this.lbMaPhong.Text = "Mã phòng";
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Appearance.Options.UseForeColor = true;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(1033, 89);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(70, 29);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click_1);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Appearance.Options.UseForeColor = true;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(1033, 45);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(70, 29);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu lại";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(126, 42);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhong.Properties.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.txtMaPhong.Properties.Appearance.Options.UseFont = true;
            this.txtMaPhong.Properties.Appearance.Options.UseForeColor = true;
            this.txtMaPhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtMaPhong.Properties.NullText = "";
            this.txtMaPhong.Size = new System.Drawing.Size(174, 28);
            this.txtMaPhong.TabIndex = 7;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(408, 42);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhong.Properties.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.txtTenPhong.Properties.Appearance.Options.UseFont = true;
            this.txtTenPhong.Properties.Appearance.Options.UseForeColor = true;
            this.txtTenPhong.Size = new System.Drawing.Size(174, 28);
            this.txtTenPhong.TabIndex = 21;
            // 
            // txtMaNguoi
            // 
            this.txtMaNguoi.Location = new System.Drawing.Point(752, 42);
            this.txtMaNguoi.Name = "txtMaNguoi";
            this.txtMaNguoi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNguoi.Properties.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.txtMaNguoi.Properties.Appearance.Options.UseFont = true;
            this.txtMaNguoi.Properties.Appearance.Options.UseForeColor = true;
            this.txtMaNguoi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtMaNguoi.Properties.NullText = "";
            this.txtMaNguoi.Size = new System.Drawing.Size(174, 28);
            this.txtMaNguoi.TabIndex = 15;
            // 
            // gridVPhongOChiTiet
            // 
            this.gridVPhongOChiTiet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id_phongo,
            this.tenphong,
            this.id_nguoinuoi,
            this.hoten,
            this.quequan,
            this.ngaysinh,
            this.hienco,
            this.id_chitietphong});
            this.gridVPhongOChiTiet.GridControl = this.gridPhongOChiTiet;
            this.gridVPhongOChiTiet.Name = "gridVPhongOChiTiet";
            this.gridVPhongOChiTiet.OptionsBehavior.Editable = false;
            this.gridVPhongOChiTiet.OptionsFilter.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.Text;
            this.gridVPhongOChiTiet.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gridVPhongOChiTiet.OptionsFind.AlwaysVisible = true;
            this.gridVPhongOChiTiet.OptionsFind.FindNullPrompt = "Nhập thông tin cần tìm...";
            this.gridVPhongOChiTiet.OptionsView.ShowGroupPanel = false;
            this.gridVPhongOChiTiet.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridVPhongO_RowClick);
            // 
            // tenphong
            // 
            this.tenphong.Caption = "Tên Phòng";
            this.tenphong.FieldName = "tenphong";
            this.tenphong.Name = "tenphong";
            this.tenphong.Visible = true;
            this.tenphong.VisibleIndex = 1;
            this.tenphong.Width = 72;
            // 
            // id_nguoinuoi
            // 
            this.id_nguoinuoi.Caption = "Mã người ở phòng";
            this.id_nguoinuoi.FieldName = "id_nguoinuoi";
            this.id_nguoinuoi.Name = "id_nguoinuoi";
            this.id_nguoinuoi.Visible = true;
            this.id_nguoinuoi.VisibleIndex = 2;
            this.id_nguoinuoi.Width = 105;
            // 
            // hoten
            // 
            this.hoten.Caption = "Họ và tên";
            this.hoten.FieldName = "hoten";
            this.hoten.Name = "hoten";
            this.hoten.Visible = true;
            this.hoten.VisibleIndex = 3;
            this.hoten.Width = 227;
            // 
            // quequan
            // 
            this.quequan.Caption = "Quê quán";
            this.quequan.FieldName = "quequan";
            this.quequan.Name = "quequan";
            this.quequan.Visible = true;
            this.quequan.VisibleIndex = 4;
            this.quequan.Width = 346;
            // 
            // ngaysinh
            // 
            this.ngaysinh.Caption = "Ngày sinh";
            this.ngaysinh.FieldName = "ngaysinh";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Visible = true;
            this.ngaysinh.VisibleIndex = 5;
            this.ngaysinh.Width = 180;
            // 
            // hienco
            // 
            this.hienco.Caption = "Số người hiện có";
            this.hienco.FieldName = "hienco";
            this.hienco.Name = "hienco";
            this.hienco.Visible = true;
            this.hienco.VisibleIndex = 6;
            this.hienco.Width = 93;
            // 
            // id_chitietphong
            // 
            this.id_chitietphong.Caption = "STT";
            this.id_chitietphong.FieldName = "id_chitietphong";
            this.id_chitietphong.Name = "id_chitietphong";
            this.id_chitietphong.Visible = true;
            this.id_chitietphong.VisibleIndex = 7;
            this.id_chitietphong.Width = 79;
            // 
            // gridPhongOChiTiet
            // 
            this.gridPhongOChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPhongOChiTiet.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPhongOChiTiet.Location = new System.Drawing.Point(4, 206);
            this.gridPhongOChiTiet.MainView = this.gridVPhongOChiTiet;
            this.gridPhongOChiTiet.Name = "gridPhongOChiTiet";
            this.gridPhongOChiTiet.Size = new System.Drawing.Size(1187, 291);
            this.gridPhongOChiTiet.TabIndex = 4;
            this.gridPhongOChiTiet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVPhongOChiTiet});
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnIn);
            this.panelControl1.Controls.Add(this.btnThem);
            this.panelControl1.Controls.Add(this.btnXoa);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1191, 49);
            this.panelControl1.TabIndex = 19;
            // 
            // btnIn
            // 
            this.btnIn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Appearance.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnIn.Appearance.Options.UseFont = true;
            this.btnIn.Appearance.Options.UseForeColor = true;
            this.btnIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.ImageOptions.Image")));
            this.btnIn.Location = new System.Drawing.Point(743, 6);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(98, 36);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "In kết quả";
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Appearance.Options.UseForeColor = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(458, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 36);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Appearance.Options.UseForeColor = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(598, 6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 36);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa bỏ";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridPhongOChiTiet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1191, 499);
            this.groupControl1.TabIndex = 20;
            this.groupControl1.Text = "Danh sách";
            // 
            // ConChiTietPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 499);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "ConChiTietPhong";
            this.Text = "Chi tiết phòng";
            this.Load += new System.EventHandler(this.ConChiTietPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaChiTiet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoNguoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNguoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVPhongOChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhongOChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn id_phongo;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl lbNgaySinh;
        private DevExpress.XtraEditors.LabelControl lbHoTen;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.LabelControl lbMaPhong;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVPhongOChiTiet;
        private DevExpress.XtraGrid.Columns.GridColumn tenphong;
        private DevExpress.XtraGrid.Columns.GridColumn id_nguoinuoi;
        private DevExpress.XtraGrid.Columns.GridColumn hoten;
        private DevExpress.XtraGrid.Columns.GridColumn quequan;
        private DevExpress.XtraGrid.GridControl gridPhongOChiTiet;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn ngaysinh;
        private DevExpress.XtraGrid.Columns.GridColumn hienco;
        private DevExpress.XtraEditors.LabelControl lbSoNguoi;
        private DevExpress.XtraEditors.TextEdit txtSoNguoi;
        private DevExpress.XtraEditors.DateEdit txtNgaySinh;
        private DevExpress.XtraEditors.LabelControl lbMaNguoi;
        private DevExpress.XtraEditors.LabelControl lbTenPhong;
        private DevExpress.XtraEditors.LookUpEdit txtMaPhong;
        private DevExpress.XtraEditors.TextEdit txtTenPhong;
        private DevExpress.XtraEditors.LookUpEdit txtMaNguoi;
        private DevExpress.XtraGrid.Columns.GridColumn id_chitietphong;
        private DevExpress.XtraEditors.LabelControl lbId_Chitiet;
        private DevExpress.XtraEditors.LookUpEdit txtMaChiTiet;
    }
}