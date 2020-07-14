namespace QL_Vat_Lieu_Xay_Dung_WinFormApp
{
    partial class frmKhachHang_NCC
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
            this.gv_KhachHang_NCC = new System.Windows.Forms.DataGridView();
            this.panelInfor = new DevExpress.Utils.Layout.TablePanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtTenUser = new DevExpress.XtraEditors.TextEdit();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.txtConfirmEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtMaUser = new DevExpress.XtraEditors.TextEdit();
            this.lblMaKH = new DevExpress.XtraEditors.LabelControl();
            this.dateBirthday = new DevExpress.XtraEditors.DateEdit();
            this.lblBirthDay = new DevExpress.XtraEditors.LabelControl();
            this.lblPhone = new DevExpress.XtraEditors.LabelControl();
            this.lblConfirmEmail = new DevExpress.XtraEditors.LabelControl();
            this.lblEmail = new DevExpress.XtraEditors.LabelControl();
            this.lblUserName = new DevExpress.XtraEditors.LabelControl();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gv_KhachHang_NCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInfor)).BeginInit();
            this.panelInfor.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBirthday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBirthday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gv_KhachHang_NCC
            // 
            this.panelInfor.SetColumn(this.gv_KhachHang_NCC, 0);
            this.gv_KhachHang_NCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_KhachHang_NCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_KhachHang_NCC.Location = new System.Drawing.Point(3, 241);
            this.gv_KhachHang_NCC.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.gv_KhachHang_NCC.Name = "gv_KhachHang_NCC";
            this.panelInfor.SetRow(this.gv_KhachHang_NCC, 2);
            this.gv_KhachHang_NCC.RowHeadersWidth = 51;
            this.gv_KhachHang_NCC.RowTemplate.Height = 24;
            this.gv_KhachHang_NCC.Size = new System.Drawing.Size(1182, 458);
            this.gv_KhachHang_NCC.TabIndex = 2;
            // 
            // panelInfor
            // 
            this.panelInfor.Appearance.BackColor = System.Drawing.Color.White;
            this.panelInfor.Appearance.Options.UseBackColor = true;
            this.panelInfor.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.panelInfor.Controls.Add(this.panel1);
            this.panelInfor.Controls.Add(this.gv_KhachHang_NCC);
            this.panelInfor.Controls.Add(this.stackPanel1);
            this.panelInfor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfor.Location = new System.Drawing.Point(0, 0);
            this.panelInfor.Name = "panelInfor";
            this.panelInfor.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 67.59998F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 173.2003F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.panelInfor.Size = new System.Drawing.Size(1188, 702);
            this.panelInfor.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelInfor.SetColumn(this.panel1, 0);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtTenUser);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.txtConfirmEmail);
            this.panel1.Controls.Add(this.txtMaUser);
            this.panel1.Controls.Add(this.lblMaKH);
            this.panel1.Controls.Add(this.dateBirthday);
            this.panel1.Controls.Add(this.lblBirthDay);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Controls.Add(this.lblConfirmEmail);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel1.Name = "panel1";
            this.panelInfor.SetRow(this.panel1, 1);
            this.panel1.Size = new System.Drawing.Size(1182, 170);
            this.panel1.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(552, 29);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtEmail.Size = new System.Drawing.Size(261, 30);
            this.txtEmail.TabIndex = 24;
            // 
            // txtTenUser
            // 
            this.txtTenUser.Location = new System.Drawing.Point(140, 95);
            this.txtTenUser.Name = "txtTenUser";
            this.txtTenUser.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenUser.Properties.Appearance.Options.UseFont = true;
            this.txtTenUser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtTenUser.Size = new System.Drawing.Size(236, 30);
            this.txtTenUser.TabIndex = 23;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(940, 29);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Properties.Appearance.Options.UseFont = true;
            this.txtPhone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtPhone.Size = new System.Drawing.Size(219, 30);
            this.txtPhone.TabIndex = 22;
            // 
            // txtConfirmEmail
            // 
            this.txtConfirmEmail.Location = new System.Drawing.Point(552, 95);
            this.txtConfirmEmail.Name = "txtConfirmEmail";
            this.txtConfirmEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmEmail.Properties.Appearance.Options.UseFont = true;
            this.txtConfirmEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtConfirmEmail.Size = new System.Drawing.Size(261, 30);
            this.txtConfirmEmail.TabIndex = 21;
            // 
            // txtMaUser
            // 
            this.txtMaUser.Location = new System.Drawing.Point(140, 29);
            this.txtMaUser.Name = "txtMaUser";
            this.txtMaUser.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaUser.Properties.Appearance.Options.UseFont = true;
            this.txtMaUser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtMaUser.Size = new System.Drawing.Size(236, 30);
            this.txtMaUser.TabIndex = 20;
            // 
            // lblMaKH
            // 
            this.lblMaKH.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKH.Appearance.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblMaKH.Appearance.Options.UseFont = true;
            this.lblMaKH.Appearance.Options.UseForeColor = true;
            this.lblMaKH.Location = new System.Drawing.Point(24, 33);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(95, 21);
            this.lblMaKH.TabIndex = 19;
            this.lblMaKH.Text = "Mã KH,NCC";
            // 
            // dateBirthday
            // 
            this.dateBirthday.EditValue = null;
            this.dateBirthday.Location = new System.Drawing.Point(940, 95);
            this.dateBirthday.Name = "dateBirthday";
            this.dateBirthday.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBirthday.Properties.Appearance.Options.UseFont = true;
            this.dateBirthday.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.dateBirthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBirthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBirthday.Size = new System.Drawing.Size(219, 30);
            this.dateBirthday.TabIndex = 18;
            // 
            // lblBirthDay
            // 
            this.lblBirthDay.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDay.Appearance.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblBirthDay.Appearance.Options.UseFont = true;
            this.lblBirthDay.Appearance.Options.UseForeColor = true;
            this.lblBirthDay.Location = new System.Drawing.Point(845, 99);
            this.lblBirthDay.Name = "lblBirthDay";
            this.lblBirthDay.Size = new System.Drawing.Size(79, 21);
            this.lblBirthDay.TabIndex = 17;
            this.lblBirthDay.Text = "Brithday:";
            // 
            // lblPhone
            // 
            this.lblPhone.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Appearance.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPhone.Appearance.Options.UseFont = true;
            this.lblPhone.Appearance.Options.UseForeColor = true;
            this.lblPhone.Location = new System.Drawing.Point(845, 33);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(60, 21);
            this.lblPhone.TabIndex = 16;
            this.lblPhone.Text = "Phone:";
            // 
            // lblConfirmEmail
            // 
            this.lblConfirmEmail.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmEmail.Appearance.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblConfirmEmail.Appearance.Options.UseFont = true;
            this.lblConfirmEmail.Appearance.Options.UseForeColor = true;
            this.lblConfirmEmail.Location = new System.Drawing.Point(405, 99);
            this.lblConfirmEmail.Name = "lblConfirmEmail";
            this.lblConfirmEmail.Size = new System.Drawing.Size(125, 21);
            this.lblConfirmEmail.TabIndex = 15;
            this.lblConfirmEmail.Text = "Confirm email:";
            // 
            // lblEmail
            // 
            this.lblEmail.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Appearance.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblEmail.Appearance.Options.UseFont = true;
            this.lblEmail.Appearance.Options.UseForeColor = true;
            this.lblEmail.Location = new System.Drawing.Point(405, 33);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 21);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email:";
            // 
            // lblUserName
            // 
            this.lblUserName.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Appearance.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblUserName.Appearance.Options.UseFont = true;
            this.lblUserName.Appearance.Options.UseForeColor = true;
            this.lblUserName.Location = new System.Drawing.Point(24, 99);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(55, 21);
            this.lblUserName.TabIndex = 13;
            this.lblUserName.Text = "Name:";
            // 
            // stackPanel1
            // 
            this.stackPanel1.Appearance.BackColor = System.Drawing.Color.White;
            this.stackPanel1.Appearance.Options.UseBackColor = true;
            this.panelInfor.SetColumn(this.stackPanel1, 0);
            this.stackPanel1.Controls.Add(this.btnThem);
            this.stackPanel1.Controls.Add(this.btnSua);
            this.stackPanel1.Controls.Add(this.btnXoa);
            this.stackPanel1.Controls.Add(this.btnTimKiem);
            this.stackPanel1.Location = new System.Drawing.Point(3, 3);
            this.stackPanel1.Name = "stackPanel1";
            this.panelInfor.SetRow(this.stackPanel1, 0);
            this.stackPanel1.Size = new System.Drawing.Size(1182, 62);
            this.stackPanel1.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Appearance.Options.UseForeColor = true;
            this.btnThem.Appearance.Options.UseTextOptions = true;
            this.btnThem.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.ImageOptions.Image = global::QL_Vat_Lieu_Xay_Dung_WinFormApp.Properties.Resources.add_32x322;
            this.btnThem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnThem.Location = new System.Drawing.Point(20, -3);
            this.btnThem.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnThem.Size = new System.Drawing.Size(250, 68);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm khách hàng,NCC";
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Appearance.Options.UseForeColor = true;
            this.btnSua.Appearance.Options.UseTextOptions = true;
            this.btnSua.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua.ImageOptions.Image = global::QL_Vat_Lieu_Xay_Dung_WinFormApp.Properties.Resources.publicfix_32x32;
            this.btnSua.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSua.Location = new System.Drawing.Point(310, -3);
            this.btnSua.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSua.Size = new System.Drawing.Size(300, 68);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa thông tin khách hàng,NCC";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Appearance.Options.UseForeColor = true;
            this.btnXoa.Appearance.Options.UseTextOptions = true;
            this.btnXoa.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.ImageOptions.Image = global::QL_Vat_Lieu_Xay_Dung_WinFormApp.Properties.Resources.deletetablerows_32x32;
            this.btnXoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnXoa.Location = new System.Drawing.Point(650, -3);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnXoa.Size = new System.Drawing.Size(250, 68);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xoá khách hàng,NCC";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTimKiem.Appearance.Options.UseFont = true;
            this.btnTimKiem.Appearance.Options.UseForeColor = true;
            this.btnTimKiem.Appearance.Options.UseTextOptions = true;
            this.btnTimKiem.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimKiem.ImageOptions.Image = global::QL_Vat_Lieu_Xay_Dung_WinFormApp.Properties.Resources.findcustomers_32x32;
            this.btnTimKiem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnTimKiem.Location = new System.Drawing.Point(940, -3);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnTimKiem.Size = new System.Drawing.Size(250, 68);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            // 
            // frmKhachHang_NCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 702);
            this.Controls.Add(this.panelInfor);
            this.Name = "frmKhachHang_NCC";
            this.Text = "frmKhachHang_NCC";
            ((System.ComponentModel.ISupportInitialize)(this.gv_KhachHang_NCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInfor)).EndInit();
            this.panelInfor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBirthday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBirthday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Layout.TablePanel panelInfor;
        private System.Windows.Forms.DataGridView gv_KhachHang_NCC;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtTenUser;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.TextEdit txtConfirmEmail;
        private DevExpress.XtraEditors.TextEdit txtMaUser;
        private DevExpress.XtraEditors.LabelControl lblMaKH;
        private DevExpress.XtraEditors.DateEdit dateBirthday;
        private DevExpress.XtraEditors.LabelControl lblBirthDay;
        private DevExpress.XtraEditors.LabelControl lblPhone;
        private DevExpress.XtraEditors.LabelControl lblConfirmEmail;
        private DevExpress.XtraEditors.LabelControl lblEmail;
        private DevExpress.XtraEditors.LabelControl lblUserName;
    }
}