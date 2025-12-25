namespace FrmQLHoiGiang.Controls;

partial class UcGiangVien
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Component Designer generated code

    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        gridGiangVien = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
        colMaSo = new DataGridViewTextBoxColumn();
        colHoTen = new DataGridViewTextBoxColumn();
        colSoDienThoai = new DataGridViewTextBoxColumn();
        colEmail = new DataGridViewTextBoxColumn();
        panelRight = new Siticone.Desktop.UI.WinForms.SiticonePanel();
        label11 = new Label();
        label10 = new Label();
        label9 = new Label();
        label8 = new Label();
        label7 = new Label();
        label6 = new Label();
        label5 = new Label();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        txtNamDayGioi = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtLinhVuc = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtChucVu = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        cboDonVi = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
        cboHocVi = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
        cboHocHam = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
        cboChucDanh = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
        txtHeSoLuong = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        cboCapBac = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
        cboTrinhDoLLCT = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
        cboTrinhDoCM = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
        txtTonGiao = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtDanToc = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtQueQuanTinh = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtQueQuanXa = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        label1 = new Label();
        btnXoa = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnHuy = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnLuu = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        txtSoDienThoai = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtEmail = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        dtNgaySinh = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
        cboGioiTinh = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
        txtHoTen = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtMaSo = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        btnLamMoi = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        txtQuickFilter = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        panelLeft = new Siticone.Desktop.UI.WinForms.SiticonePanel();
        messageDialog = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
        layoutMain = new TableLayoutPanel();
        label12 = new Label();
        label13 = new Label();
        label14 = new Label();
        ((System.ComponentModel.ISupportInitialize)gridGiangVien).BeginInit();
        panelRight.SuspendLayout();
        panelLeft.SuspendLayout();
        layoutMain.SuspendLayout();
        SuspendLayout();
        // 
        // gridGiangVien
        // 
        gridGiangVien.AllowUserToAddRows = false;
        gridGiangVien.AllowUserToDeleteRows = false;
        dataGridViewCellStyle1.BackColor = Color.White;
        gridGiangVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        gridGiangVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        gridGiangVien.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 16F);
        dataGridViewCellStyle2.ForeColor = Color.White;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        gridGiangVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        gridGiangVien.ColumnHeadersHeight = 45;
        gridGiangVien.Columns.AddRange(new DataGridViewColumn[] { colMaSo, colHoTen, colSoDienThoai, colEmail });
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.White;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 16F);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        gridGiangVien.DefaultCellStyle = dataGridViewCellStyle3;
        gridGiangVien.GridColor = Color.FromArgb(231, 229, 255);
        gridGiangVien.Location = new Point(13, 73);
        gridGiangVien.Margin = new Padding(3, 4, 3, 4);
        gridGiangVien.Name = "gridGiangVien";
        gridGiangVien.ReadOnly = true;
        gridGiangVien.RowHeadersVisible = false;
        gridGiangVien.RowHeadersWidth = 62;
        gridGiangVien.RowTemplate.Height = 32;
        gridGiangVien.Size = new Size(1007, 1466);
        gridGiangVien.TabIndex = 0;
        gridGiangVien.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
        gridGiangVien.ThemeStyle.AlternatingRowsStyle.Font = null;
        gridGiangVien.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
        gridGiangVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
        gridGiangVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
        gridGiangVien.ThemeStyle.BackColor = Color.White;
        gridGiangVien.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
        gridGiangVien.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
        gridGiangVien.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Sunken;
        gridGiangVien.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 16F);
        gridGiangVien.ThemeStyle.HeaderStyle.ForeColor = Color.White;
        gridGiangVien.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        gridGiangVien.ThemeStyle.HeaderStyle.Height = 45;
        gridGiangVien.ThemeStyle.ReadOnly = true;
        gridGiangVien.ThemeStyle.RowsStyle.BackColor = Color.White;
        gridGiangVien.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        gridGiangVien.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 16F);
        gridGiangVien.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
        gridGiangVien.ThemeStyle.RowsStyle.Height = 32;
        gridGiangVien.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
        gridGiangVien.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
        gridGiangVien.CellClick += gridGiangVien_CellClick;
        // 
        // colMaSo
        // 
        colMaSo.DataPropertyName = "MaSo";
        colMaSo.HeaderText = "MÃ SỐ";
        colMaSo.MinimumWidth = 8;
        colMaSo.Name = "colMaSo";
        colMaSo.ReadOnly = true;
        // 
        // colHoTen
        // 
        colHoTen.DataPropertyName = "HoTen";
        colHoTen.HeaderText = "HỌ TÊN";
        colHoTen.MinimumWidth = 8;
        colHoTen.Name = "colHoTen";
        colHoTen.ReadOnly = true;
        // 
        // colSoDienThoai
        // 
        colSoDienThoai.DataPropertyName = "SoDienThoai";
        colSoDienThoai.HeaderText = "ĐIỆN THOẠI";
        colSoDienThoai.MinimumWidth = 8;
        colSoDienThoai.Name = "colSoDienThoai";
        colSoDienThoai.ReadOnly = true;
        // 
        // colEmail
        // 
        colEmail.DataPropertyName = "Email";
        colEmail.HeaderText = "EMAIL";
        colEmail.MinimumWidth = 8;
        colEmail.Name = "colEmail";
        colEmail.ReadOnly = true;
        // 
        // panelRight
        // 
        panelRight.AutoScroll = true;
        panelRight.BorderRadius = 12;
        panelRight.Controls.Add(label14);
        panelRight.Controls.Add(label13);
        panelRight.Controls.Add(label12);
        panelRight.Controls.Add(label11);
        panelRight.Controls.Add(label10);
        panelRight.Controls.Add(label9);
        panelRight.Controls.Add(label8);
        panelRight.Controls.Add(label7);
        panelRight.Controls.Add(label6);
        panelRight.Controls.Add(label5);
        panelRight.Controls.Add(label4);
        panelRight.Controls.Add(label3);
        panelRight.Controls.Add(label2);
        panelRight.Controls.Add(txtNamDayGioi);
        panelRight.Controls.Add(txtLinhVuc);
        panelRight.Controls.Add(txtChucVu);
        panelRight.Controls.Add(cboDonVi);
        panelRight.Controls.Add(cboHocVi);
        panelRight.Controls.Add(cboHocHam);
        panelRight.Controls.Add(cboChucDanh);
        panelRight.Controls.Add(txtHeSoLuong);
        panelRight.Controls.Add(cboCapBac);
        panelRight.Controls.Add(cboTrinhDoLLCT);
        panelRight.Controls.Add(cboTrinhDoCM);
        panelRight.Controls.Add(txtTonGiao);
        panelRight.Controls.Add(txtDanToc);
        panelRight.Controls.Add(txtQueQuanTinh);
        panelRight.Controls.Add(txtQueQuanXa);
        panelRight.Controls.Add(label1);
        panelRight.Controls.Add(btnXoa);
        panelRight.Controls.Add(btnHuy);
        panelRight.Controls.Add(btnLuu);
        panelRight.Controls.Add(txtSoDienThoai);
        panelRight.Controls.Add(txtEmail);
        panelRight.Controls.Add(dtNgaySinh);
        panelRight.Controls.Add(cboGioiTinh);
        panelRight.Controls.Add(txtHoTen);
        panelRight.Controls.Add(txtMaSo);
        panelRight.Dock = DockStyle.Fill;
        panelRight.FillColor = Color.White;
        panelRight.Location = new Point(1071, 24);
        panelRight.Margin = new Padding(24, 0, 0, 0);
        panelRight.Name = "panelRight";
        panelRight.Padding = new Padding(18, 22, 18, 22);
        panelRight.Size = new Size(659, 824);
        panelRight.TabIndex = 1;
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Font = new Font("Segoe UI", 16F);
        label11.Location = new Point(393, 73);
        label11.Name = "label11";
        label11.Size = new Size(131, 30);
        label11.TabIndex = 38;
        label11.Text = "Hệ số lương";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Font = new Font("Segoe UI", 16F);
        label10.Location = new Point(395, 508);
        label10.Name = "label10";
        label10.Size = new Size(232, 30);
        label10.TabIndex = 37;
        label10.Text = "Năm dạy giỏi gần nhất";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Font = new Font("Segoe UI", 16F);
        label9.Location = new Point(395, 442);
        label9.Name = "label9";
        label9.Size = new Size(92, 30);
        label9.TabIndex = 36;
        label9.Text = "Lĩnh vực";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Font = new Font("Segoe UI", 16F);
        label8.Location = new Point(395, 388);
        label8.Name = "label8";
        label8.Size = new Size(91, 30);
        label8.TabIndex = 35;
        label8.Text = "Chức vụ";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI", 16F);
        label7.Location = new Point(395, 310);
        label7.Name = "label7";
        label7.Size = new Size(62, 30);
        label7.TabIndex = 34;
        label7.Text = "Khoa";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 16F);
        label6.Location = new Point(395, 254);
        label6.Name = "label6";
        label6.Size = new Size(74, 30);
        label6.TabIndex = 33;
        label6.Text = "Học vị";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 16F);
        label5.Location = new Point(395, 186);
        label5.Name = "label5";
        label5.Size = new Size(100, 30);
        label5.TabIndex = 32;
        label5.Text = "Học hàm";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 16F);
        label4.Location = new Point(395, 132);
        label4.Name = "label4";
        label4.Size = new Size(116, 30);
        label4.TabIndex = 31;
        label4.Text = "Chức danh";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 16F);
        label3.Location = new Point(23, 548);
        label3.Name = "label3";
        label3.Size = new Size(96, 30);
        label3.TabIndex = 30;
        label3.Text = "Tôn giáo";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 16F);
        label2.Location = new Point(23, 465);
        label2.Name = "label2";
        label2.Size = new Size(87, 30);
        label2.TabIndex = 29;
        label2.Text = "Dân tộc";
        // 
        // txtNamDayGioi
        // 
        txtNamDayGioi.BorderRadius = 8;
        txtNamDayGioi.DefaultText = "";
        txtNamDayGioi.Font = new Font("Segoe UI", 16F);
        txtNamDayGioi.Location = new Point(635, 494);
        txtNamDayGioi.Margin = new Padding(5, 6, 5, 6);
        txtNamDayGioi.Name = "txtNamDayGioi";
        txtNamDayGioi.PasswordChar = '\0';
        txtNamDayGioi.PlaceholderText = "Năm gần nhất dạy giỏi";
        txtNamDayGioi.SelectedText = "";
        txtNamDayGioi.Size = new Size(173, 54);
        txtNamDayGioi.TabIndex = 25;
        // 
        // txtLinhVuc
        // 
        txtLinhVuc.BorderRadius = 8;
        txtLinhVuc.DefaultText = "";
        txtLinhVuc.Font = new Font("Segoe UI", 16F);
        txtLinhVuc.Location = new Point(517, 432);
        txtLinhVuc.Margin = new Padding(5, 6, 5, 6);
        txtLinhVuc.Name = "txtLinhVuc";
        txtLinhVuc.PasswordChar = '\0';
        txtLinhVuc.PlaceholderText = "Lĩnh vực chuyên môn";
        txtLinhVuc.SelectedText = "";
        txtLinhVuc.Size = new Size(291, 54);
        txtLinhVuc.TabIndex = 24;
        // 
        // txtChucVu
        // 
        txtChucVu.BorderRadius = 8;
        txtChucVu.DefaultText = "";
        txtChucVu.Font = new Font("Segoe UI", 16F);
        txtChucVu.Location = new Point(517, 370);
        txtChucVu.Margin = new Padding(5, 6, 5, 6);
        txtChucVu.Name = "txtChucVu";
        txtChucVu.PasswordChar = '\0';
        txtChucVu.PlaceholderText = "Chức vụ";
        txtChucVu.SelectedText = "";
        txtChucVu.Size = new Size(291, 54);
        txtChucVu.TabIndex = 23;
        // 
        // cboDonVi
        // 
        cboDonVi.BackColor = Color.Transparent;
        cboDonVi.BorderRadius = 8;
        cboDonVi.DrawMode = DrawMode.OwnerDrawFixed;
        cboDonVi.DropDownStyle = ComboBoxStyle.DropDownList;
        cboDonVi.FocusedColor = Color.Empty;
        cboDonVi.Font = new Font("Segoe UI", 16F);
        cboDonVi.ForeColor = Color.FromArgb(68, 88, 112);
        cboDonVi.ItemHeight = 30;
        cboDonVi.Location = new Point(517, 310);
        cboDonVi.Margin = new Padding(3, 4, 3, 4);
        cboDonVi.Name = "cboDonVi";
        cboDonVi.Size = new Size(291, 36);
        cboDonVi.TabIndex = 22;
        // 
        // cboHocVi
        // 
        cboHocVi.BackColor = Color.Transparent;
        cboHocVi.BorderRadius = 8;
        cboHocVi.DrawMode = DrawMode.OwnerDrawFixed;
        cboHocVi.DropDownStyle = ComboBoxStyle.DropDownList;
        cboHocVi.FocusedColor = Color.Empty;
        cboHocVi.Font = new Font("Segoe UI", 16F);
        cboHocVi.ForeColor = Color.FromArgb(68, 88, 112);
        cboHocVi.ItemHeight = 30;
        cboHocVi.Location = new Point(517, 248);
        cboHocVi.Margin = new Padding(3, 4, 3, 4);
        cboHocVi.Name = "cboHocVi";
        cboHocVi.Size = new Size(291, 36);
        cboHocVi.TabIndex = 21;
        // 
        // cboHocHam
        // 
        cboHocHam.BackColor = Color.Transparent;
        cboHocHam.BorderRadius = 8;
        cboHocHam.DrawMode = DrawMode.OwnerDrawFixed;
        cboHocHam.DropDownStyle = ComboBoxStyle.DropDownList;
        cboHocHam.FocusedColor = Color.Empty;
        cboHocHam.Font = new Font("Segoe UI", 16F);
        cboHocHam.ForeColor = Color.FromArgb(68, 88, 112);
        cboHocHam.ItemHeight = 30;
        cboHocHam.Location = new Point(517, 186);
        cboHocHam.Margin = new Padding(3, 4, 3, 4);
        cboHocHam.Name = "cboHocHam";
        cboHocHam.Size = new Size(291, 36);
        cboHocHam.TabIndex = 20;
        // 
        // cboChucDanh
        // 
        cboChucDanh.BackColor = Color.Transparent;
        cboChucDanh.BorderRadius = 8;
        cboChucDanh.DrawMode = DrawMode.OwnerDrawFixed;
        cboChucDanh.DropDownStyle = ComboBoxStyle.DropDownList;
        cboChucDanh.FocusedColor = Color.Empty;
        cboChucDanh.Font = new Font("Segoe UI", 16F);
        cboChucDanh.ForeColor = Color.FromArgb(68, 88, 112);
        cboChucDanh.ItemHeight = 30;
        cboChucDanh.Location = new Point(517, 126);
        cboChucDanh.Margin = new Padding(3, 4, 3, 4);
        cboChucDanh.Name = "cboChucDanh";
        cboChucDanh.Size = new Size(291, 36);
        cboChucDanh.TabIndex = 19;
        // 
        // txtHeSoLuong
        // 
        txtHeSoLuong.BorderRadius = 8;
        txtHeSoLuong.DefaultText = "";
        txtHeSoLuong.Font = new Font("Segoe UI", 16F);
        txtHeSoLuong.Location = new Point(532, 64);
        txtHeSoLuong.Margin = new Padding(5, 6, 5, 6);
        txtHeSoLuong.Name = "txtHeSoLuong";
        txtHeSoLuong.PasswordChar = '\0';
        txtHeSoLuong.PlaceholderText = "Hệ số lương";
        txtHeSoLuong.SelectedText = "";
        txtHeSoLuong.Size = new Size(276, 54);
        txtHeSoLuong.TabIndex = 18;
        // 
        // cboCapBac
        // 
        cboCapBac.BackColor = Color.Transparent;
        cboCapBac.BorderRadius = 8;
        cboCapBac.DrawMode = DrawMode.OwnerDrawFixed;
        cboCapBac.DropDownStyle = ComboBoxStyle.DropDownList;
        cboCapBac.FocusedColor = Color.Empty;
        cboCapBac.Font = new Font("Segoe UI", 16F);
        cboCapBac.ForeColor = Color.FromArgb(68, 88, 112);
        cboCapBac.ItemHeight = 30;
        cboCapBac.Location = new Point(168, 723);
        cboCapBac.Margin = new Padding(3, 4, 3, 4);
        cboCapBac.Name = "cboCapBac";
        cboCapBac.Size = new Size(196, 36);
        cboCapBac.TabIndex = 17;
        // 
        // cboTrinhDoLLCT
        // 
        cboTrinhDoLLCT.BackColor = Color.Transparent;
        cboTrinhDoLLCT.BorderRadius = 8;
        cboTrinhDoLLCT.DrawMode = DrawMode.OwnerDrawFixed;
        cboTrinhDoLLCT.DropDownStyle = ComboBoxStyle.DropDownList;
        cboTrinhDoLLCT.FocusedColor = Color.Empty;
        cboTrinhDoLLCT.Font = new Font("Segoe UI", 16F);
        cboTrinhDoLLCT.ForeColor = Color.FromArgb(68, 88, 112);
        cboTrinhDoLLCT.ItemHeight = 30;
        cboTrinhDoLLCT.Location = new Point(168, 661);
        cboTrinhDoLLCT.Margin = new Padding(3, 4, 3, 4);
        cboTrinhDoLLCT.Name = "cboTrinhDoLLCT";
        cboTrinhDoLLCT.Size = new Size(196, 36);
        cboTrinhDoLLCT.TabIndex = 16;
        // 
        // cboTrinhDoCM
        // 
        cboTrinhDoCM.BackColor = Color.Transparent;
        cboTrinhDoCM.BorderRadius = 8;
        cboTrinhDoCM.DrawMode = DrawMode.OwnerDrawFixed;
        cboTrinhDoCM.DropDownStyle = ComboBoxStyle.DropDownList;
        cboTrinhDoCM.FocusedColor = Color.Empty;
        cboTrinhDoCM.Font = new Font("Segoe UI", 16F);
        cboTrinhDoCM.ForeColor = Color.FromArgb(68, 88, 112);
        cboTrinhDoCM.ItemHeight = 30;
        cboTrinhDoCM.Location = new Point(168, 599);
        cboTrinhDoCM.Margin = new Padding(3, 4, 3, 4);
        cboTrinhDoCM.Name = "cboTrinhDoCM";
        cboTrinhDoCM.Size = new Size(196, 36);
        cboTrinhDoCM.TabIndex = 15;
        cboTrinhDoCM.SelectedIndexChanged += cboTrinhDoCM_SelectedIndexChanged;
        // 
        // txtTonGiao
        // 
        txtTonGiao.BorderRadius = 8;
        txtTonGiao.DefaultText = "";
        txtTonGiao.Font = new Font("Segoe UI", 16F);
        txtTonGiao.Location = new Point(118, 535);
        txtTonGiao.Margin = new Padding(5, 6, 5, 6);
        txtTonGiao.Name = "txtTonGiao";
        txtTonGiao.PasswordChar = '\0';
        txtTonGiao.PlaceholderText = "Tôn giáo";
        txtTonGiao.SelectedText = "";
        txtTonGiao.Size = new Size(248, 54);
        txtTonGiao.TabIndex = 14;
        // 
        // txtDanToc
        // 
        txtDanToc.BorderRadius = 8;
        txtDanToc.DefaultText = "";
        txtDanToc.Font = new Font("Segoe UI", 16F);
        txtDanToc.Location = new Point(118, 454);
        txtDanToc.Margin = new Padding(5, 6, 5, 6);
        txtDanToc.Name = "txtDanToc";
        txtDanToc.PasswordChar = '\0';
        txtDanToc.PlaceholderText = "Dân tộc";
        txtDanToc.SelectedText = "";
        txtDanToc.Size = new Size(246, 54);
        txtDanToc.TabIndex = 13;
        // 
        // txtQueQuanTinh
        // 
        txtQueQuanTinh.BorderRadius = 8;
        txtQueQuanTinh.DefaultText = "";
        txtQueQuanTinh.Font = new Font("Segoe UI", 15F);
        txtQueQuanTinh.Location = new Point(194, 388);
        txtQueQuanTinh.Margin = new Padding(8, 11, 8, 11);
        txtQueQuanTinh.Name = "txtQueQuanTinh";
        txtQueQuanTinh.PasswordChar = '\0';
        txtQueQuanTinh.PlaceholderText = "Quê quán - Tỉnh";
        txtQueQuanTinh.SelectedText = "";
        txtQueQuanTinh.Size = new Size(172, 54);
        txtQueQuanTinh.TabIndex = 12;
        // 
        // txtQueQuanXa
        // 
        txtQueQuanXa.BorderRadius = 8;
        txtQueQuanXa.DefaultText = "";
        txtQueQuanXa.Font = new Font("Segoe UI", 16F);
        txtQueQuanXa.Location = new Point(23, 388);
        txtQueQuanXa.Margin = new Padding(5, 6, 5, 6);
        txtQueQuanXa.Name = "txtQueQuanXa";
        txtQueQuanXa.PasswordChar = '\0';
        txtQueQuanXa.PlaceholderText = "Quê quán - Xã";
        txtQueQuanXa.SelectedText = "";
        txtQueQuanXa.Size = new Size(169, 54);
        txtQueQuanXa.TabIndex = 11;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
        label1.Location = new Point(18, 22);
        label1.Name = "label1";
        label1.Size = new Size(306, 41);
        label1.TabIndex = 0;
        label1.Text = "THÔNG TIN CHI TIẾT";
        // 
        // btnXoa
        // 
        btnXoa.BorderRadius = 8;
        btnXoa.FillColor = Color.FromArgb(250, 60, 76);
        btnXoa.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        btnXoa.ForeColor = Color.White;
        btnXoa.Location = new Point(230, 769);
        btnXoa.Margin = new Padding(3, 4, 3, 4);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new Size(160, 60);
        btnXoa.TabIndex = 28;
        btnXoa.Text = "Xóa";
        btnXoa.Click += btnXoa_Click;
        // 
        // btnHuy
        // 
        btnHuy.BorderRadius = 8;
        btnHuy.FillColor = Color.Gray;
        btnHuy.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        btnHuy.ForeColor = Color.White;
        btnHuy.Location = new Point(439, 769);
        btnHuy.Margin = new Padding(3, 4, 3, 4);
        btnHuy.Name = "btnHuy";
        btnHuy.Size = new Size(160, 60);
        btnHuy.TabIndex = 27;
        btnHuy.Text = "Hủy";
        btnHuy.Visible = false;
        btnHuy.Click += btnHuy_Click;
        // 
        // btnLuu
        // 
        btnLuu.BorderRadius = 8;
        btnLuu.FillColor = Color.FromArgb(31, 122, 224);
        btnLuu.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        btnLuu.ForeColor = Color.White;
        btnLuu.Location = new Point(21, 769);
        btnLuu.Margin = new Padding(3, 4, 3, 4);
        btnLuu.Name = "btnLuu";
        btnLuu.Size = new Size(160, 60);
        btnLuu.TabIndex = 26;
        btnLuu.Text = "Thêm mới";
        btnLuu.Click += btnLuu_Click;
        // 
        // txtSoDienThoai
        // 
        txtSoDienThoai.BorderRadius = 8;
        txtSoDienThoai.DefaultText = "";
        txtSoDienThoai.Font = new Font("Segoe UI", 16F);
        txtSoDienThoai.Location = new Point(23, 310);
        txtSoDienThoai.Margin = new Padding(5, 6, 5, 6);
        txtSoDienThoai.Name = "txtSoDienThoai";
        txtSoDienThoai.PasswordChar = '\0';
        txtSoDienThoai.PlaceholderText = "Số điện thoại";
        txtSoDienThoai.SelectedText = "";
        txtSoDienThoai.Size = new Size(343, 54);
        txtSoDienThoai.TabIndex = 10;
        // 
        // txtEmail
        // 
        txtEmail.BorderRadius = 8;
        txtEmail.DefaultText = "";
        txtEmail.Font = new Font("Segoe UI", 16F);
        txtEmail.Location = new Point(23, 248);
        txtEmail.Margin = new Padding(5, 6, 5, 6);
        txtEmail.Name = "txtEmail";
        txtEmail.PasswordChar = '\0';
        txtEmail.PlaceholderText = "Email";
        txtEmail.SelectedText = "";
        txtEmail.Size = new Size(343, 54);
        txtEmail.TabIndex = 9;
        // 
        // dtNgaySinh
        // 
        dtNgaySinh.BorderRadius = 8;
        dtNgaySinh.Checked = true;
        dtNgaySinh.FillColor = Color.WhiteSmoke;
        dtNgaySinh.Font = new Font("Segoe UI", 16F);
        dtNgaySinh.Format = DateTimePickerFormat.Short;
        dtNgaySinh.Location = new Point(210, 186);
        dtNgaySinh.Margin = new Padding(3, 4, 3, 4);
        dtNgaySinh.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
        dtNgaySinh.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        dtNgaySinh.Name = "dtNgaySinh";
        dtNgaySinh.Size = new Size(155, 48);
        dtNgaySinh.TabIndex = 8;
        dtNgaySinh.Value = new DateTime(2025, 6, 11, 0, 0, 0, 0);
        dtNgaySinh.ValueChanged += dtNgaySinh_ValueChanged;
        // 
        // cboGioiTinh
        // 
        cboGioiTinh.BackColor = Color.Transparent;
        cboGioiTinh.BorderRadius = 8;
        cboGioiTinh.DrawMode = DrawMode.OwnerDrawFixed;
        cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
        cboGioiTinh.FocusedColor = Color.Empty;
        cboGioiTinh.Font = new Font("Segoe UI", 16F);
        cboGioiTinh.ForeColor = Color.FromArgb(68, 88, 112);
        cboGioiTinh.ItemHeight = 30;
        cboGioiTinh.Items.AddRange(new object[] { "Nữ", "Nam" });
        cboGioiTinh.Location = new Point(23, 186);
        cboGioiTinh.Margin = new Padding(3, 4, 3, 4);
        cboGioiTinh.Name = "cboGioiTinh";
        cboGioiTinh.Size = new Size(169, 36);
        cboGioiTinh.TabIndex = 7;
        // 
        // txtHoTen
        // 
        txtHoTen.BorderRadius = 8;
        txtHoTen.DefaultText = "";
        txtHoTen.Font = new Font("Segoe UI", 16F);
        txtHoTen.Location = new Point(23, 126);
        txtHoTen.Margin = new Padding(5, 6, 5, 6);
        txtHoTen.Name = "txtHoTen";
        txtHoTen.PasswordChar = '\0';
        txtHoTen.PlaceholderText = "Họ tên";
        txtHoTen.SelectedText = "";
        txtHoTen.Size = new Size(343, 54);
        txtHoTen.TabIndex = 6;
        // 
        // txtMaSo
        // 
        txtMaSo.BorderRadius = 8;
        txtMaSo.DefaultText = "";
        txtMaSo.Font = new Font("Segoe UI", 16F);
        txtMaSo.Location = new Point(23, 64);
        txtMaSo.Margin = new Padding(5, 6, 5, 6);
        txtMaSo.Name = "txtMaSo";
        txtMaSo.PasswordChar = '\0';
        txtMaSo.PlaceholderText = "Mã số cán bộ";
        txtMaSo.SelectedText = "";
        txtMaSo.Size = new Size(343, 54);
        txtMaSo.TabIndex = 5;
        // 
        // btnLamMoi
        // 
        btnLamMoi.BorderRadius = 8;
        btnLamMoi.FillColor = Color.FromArgb(31, 122, 224);
        btnLamMoi.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        btnLamMoi.ForeColor = Color.White;
        btnLamMoi.Location = new Point(13, 13);
        btnLamMoi.Margin = new Padding(3, 4, 3, 4);
        btnLamMoi.Name = "btnLamMoi";
        btnLamMoi.Size = new Size(156, 52);
        btnLamMoi.TabIndex = 2;
        btnLamMoi.Text = "Làm mới";
        btnLamMoi.Click += btnLamMoi_Click;
        // 
        // txtQuickFilter
        // 
        txtQuickFilter.BorderRadius = 8;
        txtQuickFilter.DefaultText = "";
        txtQuickFilter.Font = new Font("Segoe UI", 16F);
        txtQuickFilter.Location = new Point(183, 13);
        txtQuickFilter.Margin = new Padding(5, 6, 5, 6);
        txtQuickFilter.Name = "txtQuickFilter";
        txtQuickFilter.PasswordChar = '\0';
        txtQuickFilter.PlaceholderText = "Loc nhanh";
        txtQuickFilter.SelectedText = "";
        txtQuickFilter.Size = new Size(300, 52);
        txtQuickFilter.TabIndex = 3;
        // 
        // panelLeft
        // 
        panelLeft.BorderRadius = 12;
        panelLeft.Controls.Add(gridGiangVien);
        panelLeft.Controls.Add(txtQuickFilter);
        panelLeft.Controls.Add(btnLamMoi);
        panelLeft.Dock = DockStyle.Fill;
        panelLeft.FillColor = Color.White;
        panelLeft.Location = new Point(24, 24);
        panelLeft.Margin = new Padding(0);
        panelLeft.Name = "panelLeft";
        panelLeft.Padding = new Padding(18, 22, 18, 22);
        panelLeft.Size = new Size(1023, 824);
        panelLeft.TabIndex = 3;
        // 
        // messageDialog
        // 
        messageDialog.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.OK;
        messageDialog.Caption = "Thông báo";
        messageDialog.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Warning;
        messageDialog.Parent = null;
        messageDialog.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Light;
        messageDialog.Text = "message";
        // 
        // layoutMain
        // 
        layoutMain.BackColor = Color.FromArgb(245, 247, 250);
        layoutMain.ColumnCount = 2;
        layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
        layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
        layoutMain.Controls.Add(panelLeft, 0, 0);
        layoutMain.Controls.Add(panelRight, 1, 0);
        layoutMain.Dock = DockStyle.Fill;
        layoutMain.Location = new Point(0, 0);
        layoutMain.Margin = new Padding(0);
        layoutMain.Name = "layoutMain";
        layoutMain.Padding = new Padding(24);
        layoutMain.RowCount = 1;
        layoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        layoutMain.Size = new Size(1754, 872);
        layoutMain.TabIndex = 4;
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Font = new Font("Segoe UI", 16F);
        label12.Location = new Point(21, 599);
        label12.Name = "label12";
        label12.Size = new Size(141, 30);
        label12.TabIndex = 39;
        label12.Text = "Chuyên môn:";
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Font = new Font("Segoe UI", 16F);
        label13.Location = new Point(18, 661);
        label13.Name = "label13";
        label13.Size = new Size(143, 30);
        label13.TabIndex = 40;
        label13.Text = "Trình độ LLCT";
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.Font = new Font("Segoe UI", 16F);
        label14.Location = new Point(19, 729);
        label14.Name = "label14";
        label14.Size = new Size(91, 30);
        label14.TabIndex = 41;
        label14.Text = "Cấp bậc";
        // 
        // UcGiangVien
        // 
        AutoScaleMode = AutoScaleMode.None;
        BackColor = Color.FromArgb(245, 247, 250);
        Controls.Add(layoutMain);
        Margin = new Padding(3, 4, 3, 4);
        Name = "UcGiangVien";
        Size = new Size(1754, 872);
        ((System.ComponentModel.ISupportInitialize)gridGiangVien).EndInit();
        panelRight.ResumeLayout(false);
        panelRight.PerformLayout();
        panelLeft.ResumeLayout(false);
        layoutMain.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Siticone.Desktop.UI.WinForms.SiticoneDataGridView gridGiangVien;
    private Siticone.Desktop.UI.WinForms.SiticonePanel panelRight;
    private Siticone.Desktop.UI.WinForms.SiticonePanel panelLeft;
    private Label label1;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnLamMoi;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtQuickFilter;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnXoa;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnHuy;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnLuu;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtSoDienThoai;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtEmail;
    private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dtNgaySinh;
    private Siticone.Desktop.UI.WinForms.SiticoneComboBox cboGioiTinh;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtHoTen;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtMaSo;
    private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog messageDialog;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtNamDayGioi;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtLinhVuc;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtChucVu;
    private Siticone.Desktop.UI.WinForms.SiticoneComboBox cboDonVi;
    private Siticone.Desktop.UI.WinForms.SiticoneComboBox cboHocVi;
    private Siticone.Desktop.UI.WinForms.SiticoneComboBox cboHocHam;
    private Siticone.Desktop.UI.WinForms.SiticoneComboBox cboChucDanh;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtHeSoLuong;
    private Siticone.Desktop.UI.WinForms.SiticoneComboBox cboCapBac;
    private Siticone.Desktop.UI.WinForms.SiticoneComboBox cboTrinhDoLLCT;
    private Siticone.Desktop.UI.WinForms.SiticoneComboBox cboTrinhDoCM;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTonGiao;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtDanToc;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtQueQuanTinh;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtQueQuanXa;
    private DataGridViewTextBoxColumn colMaSo;
    private DataGridViewTextBoxColumn colHoTen;
    private DataGridViewTextBoxColumn colSoDienThoai;
    private DataGridViewTextBoxColumn colEmail;
    private TableLayoutPanel layoutMain;
    private Label label3;
    private Label label2;
    private Label label10;
    private Label label9;
    private Label label8;
    private Label label7;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label label11;
    private Label label14;
    private Label label13;
    private Label label12;
}
