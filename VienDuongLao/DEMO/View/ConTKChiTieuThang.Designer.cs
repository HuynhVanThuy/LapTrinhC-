namespace DEMO.View
{
    partial class ConTKChiTieuThang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConTKChiTieuThang));
            this.btnMotThang = new DevExpress.XtraEditors.SimpleButton();
            this.btnNhieuThang = new DevExpress.XtraEditors.SimpleButton();
            this.txtThang = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtNam = new DevExpress.XtraEditors.SpinEdit();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridTKChiTieu = new DevExpress.XtraGrid.GridControl();
            this.gridViewTKChiTieu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnHuyBo = new DevExpress.XtraEditors.SimpleButton();
            this.btnTungNgay = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoiNgay = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtThang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTKChiTieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTKChiTieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMotThang
            // 
            this.btnMotThang.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMotThang.Appearance.Options.UseFont = true;
            this.btnMotThang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMotThang.ImageOptions.Image")));
            this.btnMotThang.Location = new System.Drawing.Point(659, 65);
            this.btnMotThang.Name = "btnMotThang";
            this.btnMotThang.Size = new System.Drawing.Size(149, 28);
            this.btnMotThang.TabIndex = 20;
            this.btnMotThang.Text = "THEO MỘT THÁNG";
            this.btnMotThang.Click += new System.EventHandler(this.btnMotThang_Click);
            // 
            // btnNhieuThang
            // 
            this.btnNhieuThang.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhieuThang.Appearance.Options.UseFont = true;
            this.btnNhieuThang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhieuThang.ImageOptions.Image")));
            this.btnNhieuThang.Location = new System.Drawing.Point(659, 23);
            this.btnNhieuThang.Name = "btnNhieuThang";
            this.btnNhieuThang.Size = new System.Drawing.Size(149, 28);
            this.btnNhieuThang.TabIndex = 19;
            this.btnNhieuThang.Text = "THEO TỪNG THÁNG";
            this.btnNhieuThang.Click += new System.EventHandler(this.btnNhieuThang_Click);
            // 
            // txtThang
            // 
            this.txtThang.EditValue = "1";
            this.txtThang.Location = new System.Drawing.Point(168, 47);
            this.txtThang.Name = "txtThang";
            this.txtThang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThang.Properties.Appearance.Options.UseFont = true;
            this.txtThang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtThang.Properties.DropDownRows = 12;
            this.txtThang.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.txtThang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtThang.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtThang.Size = new System.Drawing.Size(154, 30);
            this.txtThang.TabIndex = 18;
            // 
            // txtNam
            // 
            this.txtNam.EditValue = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.txtNam.Location = new System.Drawing.Point(481, 47);
            this.txtNam.Name = "txtNam";
            this.txtNam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.Properties.Appearance.Options.UseFont = true;
            this.txtNam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNam.Properties.IsFloatValue = false;
            this.txtNam.Properties.Mask.EditMask = "d";
            this.txtNam.Size = new System.Drawing.Size(154, 30);
            this.txtNam.TabIndex = 17;
            // 
            // btnIn
            // 
            this.btnIn.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Appearance.Options.UseFont = true;
            this.btnIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.ImageOptions.Image")));
            this.btnIn.Location = new System.Drawing.Point(915, 23);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(142, 36);
            this.btnIn.TabIndex = 15;
            this.btnIn.Text = "IN KẾT QUẢ";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Chọn năm";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridTKChiTieu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 118);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1136, 381);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Kết quả thống kê";
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
            // btnHuyBo
            // 
            this.btnHuyBo.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.Appearance.Options.UseFont = true;
            this.btnHuyBo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyBo.ImageOptions.Image")));
            this.btnHuyBo.Location = new System.Drawing.Point(955, 65);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(74, 28);
            this.btnHuyBo.TabIndex = 23;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnTungNgay
            // 
            this.btnTungNgay.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTungNgay.Appearance.Options.UseFont = true;
            this.btnTungNgay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTungNgay.ImageOptions.Image")));
            this.btnTungNgay.Location = new System.Drawing.Point(815, 65);
            this.btnTungNgay.Name = "btnTungNgay";
            this.btnTungNgay.Size = new System.Drawing.Size(94, 28);
            this.btnTungNgay.TabIndex = 22;
            this.btnTungNgay.Text = "Từng ngày";
            this.btnTungNgay.Click += new System.EventHandler(this.btnTungNgay_Click);
            // 
            // btnMoiNgay
            // 
            this.btnMoiNgay.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoiNgay.Appearance.Options.UseFont = true;
            this.btnMoiNgay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMoiNgay.ImageOptions.Image")));
            this.btnMoiNgay.Location = new System.Drawing.Point(815, 23);
            this.btnMoiNgay.Name = "btnMoiNgay";
            this.btnMoiNgay.Size = new System.Drawing.Size(94, 28);
            this.btnMoiNgay.TabIndex = 21;
            this.btnMoiNgay.Text = "Toàn bộ";
            this.btnMoiNgay.Click += new System.EventHandler(this.btnMoiNgay_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chọn tháng";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnHuyBo);
            this.panelControl1.Controls.Add(this.btnTungNgay);
            this.panelControl1.Controls.Add(this.btnMoiNgay);
            this.panelControl1.Controls.Add(this.btnMotThang);
            this.panelControl1.Controls.Add(this.btnNhieuThang);
            this.panelControl1.Controls.Add(this.txtThang);
            this.panelControl1.Controls.Add(this.txtNam);
            this.panelControl1.Controls.Add(this.btnIn);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1136, 499);
            this.panelControl1.TabIndex = 7;
            // 
            // ConTKChiTieuThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 499);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "ConTKChiTieuThang";
            this.Text = "Chi tiêu tháng";
            this.Load += new System.EventHandler(this.ConTKChiTieuThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtThang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTKChiTieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTKChiTieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnMotThang;
        private DevExpress.XtraEditors.SimpleButton btnNhieuThang;
        private DevExpress.XtraEditors.ComboBoxEdit txtThang;
        private DevExpress.XtraEditors.SpinEdit txtNam;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridTKChiTieu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTKChiTieu;
        private DevExpress.XtraEditors.SimpleButton btnHuyBo;
        private DevExpress.XtraEditors.SimpleButton btnTungNgay;
        private DevExpress.XtraEditors.SimpleButton btnMoiNgay;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}