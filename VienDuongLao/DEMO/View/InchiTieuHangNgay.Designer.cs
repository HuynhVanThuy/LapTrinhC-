namespace DEMO.View
{
    partial class InchiTieuHangNgay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InchiTieuHangNgay));
            this.btnQuayLai = new DevExpress.XtraEditors.SimpleButton();
            this.gridTienTuThien = new DevExpress.XtraGrid.GridControl();
            this.gridViewTienTuThien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nhomTacVu = new DevExpress.XtraEditors.PanelControl();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnNhoHon = new DevExpress.XtraEditors.SimpleButton();
            this.btnBangTien = new DevExpress.XtraEditors.SimpleButton();
            this.btnLonHon = new DevExpress.XtraEditors.SimpleButton();
            this.txtTien = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnInLoc = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnInToanBo = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridTienTuThien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTienTuThien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomTacVu)).BeginInit();
            this.nhomTacVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // gridTienTuThien
            // 
            this.gridTienTuThien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTienTuThien.Location = new System.Drawing.Point(2, 23);
            this.gridTienTuThien.MainView = this.gridViewTienTuThien;
            this.gridTienTuThien.Name = "gridTienTuThien";
            this.gridTienTuThien.Size = new System.Drawing.Size(1192, 316);
            this.gridTienTuThien.TabIndex = 0;
            this.gridTienTuThien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTienTuThien});
            // 
            // gridViewTienTuThien
            // 
            this.gridViewTienTuThien.GridControl = this.gridTienTuThien;
            this.gridViewTienTuThien.Name = "gridViewTienTuThien";
            this.gridViewTienTuThien.OptionsView.ShowGroupPanel = false;
            // 
            // nhomTacVu
            // 
            this.nhomTacVu.Controls.Add(this.btnQuayLai);
            this.nhomTacVu.Controls.Add(this.btnIn);
            this.nhomTacVu.Controls.Add(this.labelControl1);
            this.nhomTacVu.Controls.Add(this.btnNhoHon);
            this.nhomTacVu.Controls.Add(this.btnBangTien);
            this.nhomTacVu.Controls.Add(this.btnLonHon);
            this.nhomTacVu.Controls.Add(this.txtTien);
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
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(256, 87);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(20, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Tiền";
            // 
            // btnNhoHon
            // 
            this.btnNhoHon.Location = new System.Drawing.Point(492, 24);
            this.btnNhoHon.Name = "btnNhoHon";
            this.btnNhoHon.Size = new System.Drawing.Size(97, 30);
            this.btnNhoHon.TabIndex = 2;
            this.btnNhoHon.Text = "Nhỏ hơn tiền";
            this.btnNhoHon.Click += new System.EventHandler(this.btnNhoHon_Click);
            // 
            // btnBangTien
            // 
            this.btnBangTien.Location = new System.Drawing.Point(306, 24);
            this.btnBangTien.Name = "btnBangTien";
            this.btnBangTien.Size = new System.Drawing.Size(97, 30);
            this.btnBangTien.TabIndex = 1;
            this.btnBangTien.Text = "Bằng tiền";
            this.btnBangTien.Click += new System.EventHandler(this.btnBangTien_Click);
            // 
            // btnLonHon
            // 
            this.btnLonHon.Location = new System.Drawing.Point(130, 24);
            this.btnLonHon.Name = "btnLonHon";
            this.btnLonHon.Size = new System.Drawing.Size(97, 30);
            this.btnLonHon.TabIndex = 0;
            this.btnLonHon.Text = "Lớn hơn tiền";
            this.btnLonHon.Click += new System.EventHandler(this.btnLonHon_Click);
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(293, 83);
            this.txtTien.Name = "txtTien";
            this.txtTien.Properties.DisplayFormat.FormatString = "d";
            this.txtTien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTien.Properties.EditFormat.FormatString = "d";
            this.txtTien.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTien.Properties.Mask.EditMask = "n0";
            this.txtTien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTien.Size = new System.Drawing.Size(136, 20);
            this.txtTien.TabIndex = 3;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridTienTuThien);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 158);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1196, 341);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "Danh sách";
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.nhomTacVu);
            this.groupControl1.Controls.Add(this.btnInLoc);
            this.groupControl1.Controls.Add(this.btnInToanBo);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1196, 158);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Tác vụ";
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
            // InchiTieuHangNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 499);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "InchiTieuHangNgay";
            this.Text = "Chi tiêu";
            this.Load += new System.EventHandler(this.InchiTieuHangNgay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTienTuThien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTienTuThien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomTacVu)).EndInit();
            this.nhomTacVu.ResumeLayout(false);
            this.nhomTacVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnQuayLai;
        private DevExpress.XtraGrid.GridControl gridTienTuThien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTienTuThien;
        private DevExpress.XtraEditors.PanelControl nhomTacVu;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnNhoHon;
        private DevExpress.XtraEditors.SimpleButton btnBangTien;
        private DevExpress.XtraEditors.SimpleButton btnLonHon;
        private DevExpress.XtraEditors.TextEdit txtTien;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnInLoc;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnInToanBo;
    }
}