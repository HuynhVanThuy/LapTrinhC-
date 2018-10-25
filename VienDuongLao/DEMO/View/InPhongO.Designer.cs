namespace DEMO.View
{
    partial class InPhongO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InPhongO));
            this.gridNguoiO = new DevExpress.XtraGrid.GridControl();
            this.gridViewNguoiO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnInLoc = new DevExpress.XtraEditors.SimpleButton();
            this.btnSoNguoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnInToanBo = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnQuayLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnNhoHon = new DevExpress.XtraEditors.SimpleButton();
            this.nhomTacVu = new DevExpress.XtraEditors.PanelControl();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnBangTuoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnLonHon = new DevExpress.XtraEditors.SimpleButton();
            this.txtTuoi = new DevExpress.XtraEditors.TextEdit();
            this.txtSoNguoi = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridNguoiO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNguoiO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhomTacVu)).BeginInit();
            this.nhomTacVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoNguoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridNguoiO
            // 
            this.gridNguoiO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridNguoiO.Location = new System.Drawing.Point(2, 23);
            this.gridNguoiO.MainView = this.gridViewNguoiO;
            this.gridNguoiO.Name = "gridNguoiO";
            this.gridNguoiO.Size = new System.Drawing.Size(1192, 316);
            this.gridNguoiO.TabIndex = 0;
            this.gridNguoiO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNguoiO});
            // 
            // gridViewNguoiO
            // 
            this.gridViewNguoiO.GridControl = this.gridNguoiO;
            this.gridViewNguoiO.Name = "gridViewNguoiO";
            this.gridViewNguoiO.OptionsView.ShowGroupPanel = false;
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
            // btnSoNguoi
            // 
            this.btnSoNguoi.Location = new System.Drawing.Point(550, 24);
            this.btnSoNguoi.Name = "btnSoNguoi";
            this.btnSoNguoi.Size = new System.Drawing.Size(97, 30);
            this.btnSoNguoi.TabIndex = 12;
            this.btnSoNguoi.Text = "Theo số người";
            this.btnSoNguoi.Click += new System.EventHandler(this.btnSoNguoi_Click);
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
            this.groupControl2.Controls.Add(this.gridNguoiO);
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
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnNhoHon
            // 
            this.btnNhoHon.Location = new System.Drawing.Point(371, 22);
            this.btnNhoHon.Name = "btnNhoHon";
            this.btnNhoHon.Size = new System.Drawing.Size(97, 30);
            this.btnNhoHon.TabIndex = 2;
            this.btnNhoHon.Text = "Lớn hơn tuổi";
            this.btnNhoHon.Click += new System.EventHandler(this.btnNhoHon_Click);
            // 
            // nhomTacVu
            // 
            this.nhomTacVu.Controls.Add(this.btnSoNguoi);
            this.nhomTacVu.Controls.Add(this.btnQuayLai);
            this.nhomTacVu.Controls.Add(this.btnIn);
            this.nhomTacVu.Controls.Add(this.labelControl1);
            this.nhomTacVu.Controls.Add(this.btnNhoHon);
            this.nhomTacVu.Controls.Add(this.btnBangTuoi);
            this.nhomTacVu.Controls.Add(this.btnLonHon);
            this.nhomTacVu.Controls.Add(this.txtTuoi);
            this.nhomTacVu.Controls.Add(this.txtSoNguoi);
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
            this.labelControl1.Location = new System.Drawing.Point(135, 85);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(20, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Tuổi";
            // 
            // btnBangTuoi
            // 
            this.btnBangTuoi.Location = new System.Drawing.Point(185, 22);
            this.btnBangTuoi.Name = "btnBangTuoi";
            this.btnBangTuoi.Size = new System.Drawing.Size(97, 30);
            this.btnBangTuoi.TabIndex = 1;
            this.btnBangTuoi.Text = "Bằng tuổi";
            this.btnBangTuoi.Click += new System.EventHandler(this.btnBangTuoi_Click);
            // 
            // btnLonHon
            // 
            this.btnLonHon.Location = new System.Drawing.Point(9, 22);
            this.btnLonHon.Name = "btnLonHon";
            this.btnLonHon.Size = new System.Drawing.Size(97, 30);
            this.btnLonHon.TabIndex = 0;
            this.btnLonHon.Text = "Nhỏ hơn tuổi";
            this.btnLonHon.Click += new System.EventHandler(this.btnLonHon_Click);
            // 
            // txtTuoi
            // 
            this.txtTuoi.Location = new System.Drawing.Point(172, 81);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.Properties.DisplayFormat.FormatString = "d";
            this.txtTuoi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTuoi.Properties.EditFormat.FormatString = "d";
            this.txtTuoi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTuoi.Properties.Mask.EditMask = "n0";
            this.txtTuoi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTuoi.Size = new System.Drawing.Size(136, 20);
            this.txtTuoi.TabIndex = 3;
            // 
            // txtSoNguoi
            // 
            this.txtSoNguoi.Location = new System.Drawing.Point(550, 81);
            this.txtSoNguoi.Name = "txtSoNguoi";
            this.txtSoNguoi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoNguoi.Properties.DisplayFormat.FormatString = "d";
            this.txtSoNguoi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtSoNguoi.Properties.EditFormat.FormatString = "d";
            this.txtSoNguoi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtSoNguoi.Properties.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.txtSoNguoi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtSoNguoi.Size = new System.Drawing.Size(97, 20);
            this.txtSoNguoi.TabIndex = 13;
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
            // InPhongO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 499);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "InPhongO";
            this.Text = "In người trong phòng";
            this.Load += new System.EventHandler(this.InPhongO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridNguoiO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNguoiO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nhomTacVu)).EndInit();
            this.nhomTacVu.ResumeLayout(false);
            this.nhomTacVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoNguoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridNguoiO;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNguoiO;
        private DevExpress.XtraEditors.SimpleButton btnInLoc;
        private DevExpress.XtraEditors.SimpleButton btnSoNguoi;
        private DevExpress.XtraEditors.SimpleButton btnInToanBo;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnQuayLai;
        private DevExpress.XtraEditors.SimpleButton btnNhoHon;
        private DevExpress.XtraEditors.PanelControl nhomTacVu;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnBangTuoi;
        private DevExpress.XtraEditors.SimpleButton btnLonHon;
        private DevExpress.XtraEditors.TextEdit txtTuoi;
        private DevExpress.XtraEditors.ComboBoxEdit txtSoNguoi;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}