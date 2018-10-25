namespace DEMO.View
{
    partial class InTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InTaiKhoan));
            this.gridTaiKhoan = new DevExpress.XtraGrid.GridControl();
            this.gridViewTaiKhoan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnInLoc = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuyen = new DevExpress.XtraEditors.SimpleButton();
            this.btnInToanBo = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnQuayLai = new DevExpress.XtraEditors.SimpleButton();
            this.nhomTacVu = new DevExpress.XtraEditors.PanelControl();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.txtChucDanh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhomTacVu)).BeginInit();
            this.nhomTacVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChucDanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridTaiKhoan
            // 
            this.gridTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTaiKhoan.Location = new System.Drawing.Point(2, 20);
            this.gridTaiKhoan.MainView = this.gridViewTaiKhoan;
            this.gridTaiKhoan.Name = "gridTaiKhoan";
            this.gridTaiKhoan.Size = new System.Drawing.Size(1192, 319);
            this.gridTaiKhoan.TabIndex = 0;
            this.gridTaiKhoan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTaiKhoan});
            // 
            // gridViewTaiKhoan
            // 
            this.gridViewTaiKhoan.GridControl = this.gridTaiKhoan;
            this.gridViewTaiKhoan.Name = "gridViewTaiKhoan";
            this.gridViewTaiKhoan.OptionsView.ShowGroupPanel = false;
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
            // btnQuyen
            // 
            this.btnQuyen.Location = new System.Drawing.Point(160, 22);
            this.btnQuyen.Name = "btnQuyen";
            this.btnQuyen.Size = new System.Drawing.Size(97, 30);
            this.btnQuyen.TabIndex = 12;
            this.btnQuyen.Text = "Theo quyền";
            this.btnQuyen.Click += new System.EventHandler(this.btnQuyen_Click);
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
            this.groupControl2.Controls.Add(this.gridTaiKhoan);
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
            this.btnQuayLai.Location = new System.Drawing.Point(561, 41);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(150, 37);
            this.btnQuayLai.TabIndex = 11;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // nhomTacVu
            // 
            this.nhomTacVu.Controls.Add(this.btnQuyen);
            this.nhomTacVu.Controls.Add(this.btnQuayLai);
            this.nhomTacVu.Controls.Add(this.btnIn);
            this.nhomTacVu.Controls.Add(this.txtChucDanh);
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
            this.btnIn.Location = new System.Drawing.Point(366, 38);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(150, 40);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "In kết quả";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // txtChucDanh
            // 
            this.txtChucDanh.Location = new System.Drawing.Point(160, 79);
            this.txtChucDanh.Name = "txtChucDanh";
            this.txtChucDanh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtChucDanh.Properties.DisplayFormat.FormatString = "d";
            this.txtChucDanh.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtChucDanh.Properties.EditFormat.FormatString = "d";
            this.txtChucDanh.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtChucDanh.Properties.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.txtChucDanh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtChucDanh.Size = new System.Drawing.Size(97, 20);
            this.txtChucDanh.TabIndex = 13;
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
            // InTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 499);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "InTaiKhoan";
            this.Text = "InTaiKhoan";
            this.Load += new System.EventHandler(this.InTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nhomTacVu)).EndInit();
            this.nhomTacVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtChucDanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridTaiKhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTaiKhoan;
        private DevExpress.XtraEditors.SimpleButton btnInLoc;
        private DevExpress.XtraEditors.SimpleButton btnQuyen;
        private DevExpress.XtraEditors.SimpleButton btnInToanBo;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnQuayLai;
        private DevExpress.XtraEditors.PanelControl nhomTacVu;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.ComboBoxEdit txtChucDanh;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}