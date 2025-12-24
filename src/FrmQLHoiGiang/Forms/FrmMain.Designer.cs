namespace FrmQLHoiGiang.Forms;

partial class FrmMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(components);
        panelMenu = new Siticone.Desktop.UI.WinForms.SiticonePanel();
        pictureBox1 = new PictureBox();
        btnGiangVien = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnKhoa = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnBoMon = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnSangKien = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnThongKe = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnLichGiang = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        btnHoiGiang = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        panelHeader = new Siticone.Desktop.UI.WinForms.SiticonePanel();
        flowHeaderTools = new FlowLayoutPanel();
        controlBoxClose = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
        controlBoxMinimize = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
        lblUser = new Label();
        label1 = new Label();
        panelContainer = new Siticone.Desktop.UI.WinForms.SiticonePanel();
        panelMenu.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        panelHeader.SuspendLayout();
        flowHeaderTools.SuspendLayout();
        SuspendLayout();
        // 
        // siticoneBorderlessForm1
        // 
        siticoneBorderlessForm1.ContainerControl = this;
        siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
        siticoneBorderlessForm1.DragEndTransparencyValue = 0.9D;
        siticoneBorderlessForm1.ResizeForm = false;
        siticoneBorderlessForm1.TransparentWhileDrag = true;
        // 
        // panelMenu
        // 
        panelMenu.AutoScroll = true;
        panelMenu.BackColor = Color.White;
        panelMenu.Controls.Add(pictureBox1);
        panelMenu.Controls.Add(btnGiangVien);
        panelMenu.Controls.Add(btnKhoa);
        panelMenu.Controls.Add(btnBoMon);
        panelMenu.Controls.Add(btnSangKien);
        panelMenu.Controls.Add(btnThongKe);
        panelMenu.Controls.Add(btnLichGiang);
        panelMenu.Controls.Add(btnHoiGiang);
        panelMenu.Dock = DockStyle.Left;
        panelMenu.FillColor = Color.White;
        panelMenu.Location = new Point(0, 0);
        panelMenu.Name = "panelMenu";
        panelMenu.Padding = new Padding(16, 32, 16, 16);
        panelMenu.Size = new Size(232, 654);
        panelMenu.TabIndex = 0;
        panelMenu.Paint += panelMenu_Paint;
        // 
        // pictureBox1
        // 
        pictureBox1.BackgroundImageLayout = ImageLayout.None;
        pictureBox1.Image = Properties.Resources.logot01;
        pictureBox1.Location = new Point(40, 0);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(142, 86);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 7;
        pictureBox1.TabStop = false;
        // 
        // btnGiangVien
        // 
        btnGiangVien.BackColor = SystemColors.MenuHighlight;
        btnGiangVien.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
        btnGiangVien.Checked = true;
        btnGiangVien.CustomBorderColor = Color.Turquoise;
        btnGiangVien.FillColor = Color.White;
        btnGiangVien.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        btnGiangVien.ForeColor = Color.FromArgb(64, 64, 64);
        btnGiangVien.Location = new Point(0, 85);
        btnGiangVien.Name = "btnGiangVien";
        btnGiangVien.Size = new Size(232, 105);
        btnGiangVien.TabIndex = 0;
        btnGiangVien.Tag = "GV";
        btnGiangVien.Text = "Cán bộ - giảng viên";
        btnGiangVien.Click += btnGiangVien_Click;
        // 
        // btnKhoa
        // 
        btnKhoa.BackColor = SystemColors.MenuHighlight;
        btnKhoa.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
        btnKhoa.FillColor = Color.White;
        btnKhoa.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        btnKhoa.ForeColor = Color.FromArgb(64, 64, 64);
        btnKhoa.Location = new Point(0, 603);
        btnKhoa.Name = "btnKhoa";
        btnKhoa.Size = new Size(232, 105);
        btnKhoa.TabIndex = 5;
        btnKhoa.Tag = "KHOA";
        btnKhoa.Text = "Khoa";
        btnKhoa.Click += btnKhoa_Click;
        // 
        // btnBoMon
        // 
        btnBoMon.BackColor = SystemColors.MenuHighlight;
        btnBoMon.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
        btnBoMon.FillColor = Color.White;
        btnBoMon.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        btnBoMon.ForeColor = Color.FromArgb(64, 64, 64);
        btnBoMon.Location = new Point(0, 708);
        btnBoMon.Name = "btnBoMon";
        btnBoMon.Size = new Size(232, 105);
        btnBoMon.TabIndex = 5;
        btnBoMon.Tag = "BM";
        btnBoMon.Text = "Bộ môn";
        btnBoMon.Click += btnBoMon_Click;
        // 
        // btnSangKien
        // 
        btnSangKien.BackColor = SystemColors.MenuHighlight;
        btnSangKien.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
        btnSangKien.FillColor = Color.White;
        btnSangKien.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        btnSangKien.ForeColor = Color.FromArgb(64, 64, 64);
        btnSangKien.Location = new Point(0, 292);
        btnSangKien.Name = "btnSangKien";
        btnSangKien.Size = new Size(232, 105);
        btnSangKien.TabIndex = 2;
        btnSangKien.Tag = "SK";
        btnSangKien.Text = "Sáng kiến - cải tiến";
        btnSangKien.Click += btnSangKien_Click;
        // 
        // btnThongKe
        // 
        btnThongKe.BackColor = SystemColors.MenuHighlight;
        btnThongKe.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
        btnThongKe.FillColor = Color.White;
        btnThongKe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        btnThongKe.ForeColor = Color.FromArgb(64, 64, 64);
        btnThongKe.Location = new Point(0, 498);
        btnThongKe.Name = "btnThongKe";
        btnThongKe.Size = new Size(232, 105);
        btnThongKe.TabIndex = 4;
        btnThongKe.Tag = "TK";
        btnThongKe.Text = "Thống kê";
        btnThongKe.Click += btnThongKe_Click;
        // 
        // btnLichGiang
        // 
        btnLichGiang.BackColor = SystemColors.MenuHighlight;
        btnLichGiang.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
        btnLichGiang.FillColor = Color.White;
        btnLichGiang.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        btnLichGiang.ForeColor = Color.FromArgb(64, 64, 64);
        btnLichGiang.Location = new Point(0, 395);
        btnLichGiang.Name = "btnLichGiang";
        btnLichGiang.Size = new Size(232, 105);
        btnLichGiang.TabIndex = 3;
        btnLichGiang.Tag = "LG";
        btnLichGiang.Text = "Lịch giảng dạy";
        btnLichGiang.Click += btnLichGiang_Click;
        // 
        // btnHoiGiang
        // 
        btnHoiGiang.BackColor = SystemColors.MenuHighlight;
        btnHoiGiang.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
        btnHoiGiang.FillColor = Color.White;
        btnHoiGiang.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        btnHoiGiang.ForeColor = Color.FromArgb(64, 64, 64);
        btnHoiGiang.Location = new Point(0, 190);
        btnHoiGiang.Name = "btnHoiGiang";
        btnHoiGiang.Size = new Size(232, 105);
        btnHoiGiang.TabIndex = 1;
        btnHoiGiang.Tag = "HG";
        btnHoiGiang.Text = "Hội giảng";
        btnHoiGiang.Click += btnHoiGiang_Click;
        // 
        // panelHeader
        // 
        panelHeader.Controls.Add(flowHeaderTools);
        panelHeader.Controls.Add(label1);
        panelHeader.Dock = DockStyle.Top;
        panelHeader.FillColor = Color.White;
        panelHeader.Location = new Point(232, 0);
        panelHeader.Name = "panelHeader";
        panelHeader.Padding = new Padding(24, 12, 24, 12);
        panelHeader.Size = new Size(968, 79);
        panelHeader.TabIndex = 1;
        panelHeader.Paint += panelHeader_Paint;
        // 
        // flowHeaderTools
        // 
        flowHeaderTools.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        flowHeaderTools.AutoSize = true;
        flowHeaderTools.BackColor = Color.Transparent;
        flowHeaderTools.Controls.Add(controlBoxClose);
        flowHeaderTools.Controls.Add(controlBoxMinimize);
        flowHeaderTools.Controls.Add(lblUser);
        flowHeaderTools.FlowDirection = FlowDirection.RightToLeft;
        flowHeaderTools.Location = new Point(603, 20);
        flowHeaderTools.Margin = new Padding(0);
        flowHeaderTools.Name = "flowHeaderTools";
        flowHeaderTools.Size = new Size(341, 96);
        flowHeaderTools.TabIndex = 4;
        flowHeaderTools.WrapContents = false;
        // 
        // controlBoxClose
        // 
        controlBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        controlBoxClose.BorderRadius = 4;
        controlBoxClose.FillColor = Color.White;
        controlBoxClose.HoverState.FillColor = Color.FromArgb(240, 85, 68);
        controlBoxClose.HoverState.IconColor = Color.White;
        controlBoxClose.IconColor = Color.FromArgb(64, 64, 64);
        controlBoxClose.Location = new Point(294, 2);
        controlBoxClose.Margin = new Padding(2);
        controlBoxClose.Name = "controlBoxClose";
        controlBoxClose.Size = new Size(45, 36);
        controlBoxClose.TabIndex = 2;
        // 
        // controlBoxMinimize
        // 
        controlBoxMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        controlBoxMinimize.BorderRadius = 4;
        controlBoxMinimize.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
        controlBoxMinimize.FillColor = Color.White;
        controlBoxMinimize.HoverState.FillColor = Color.FromArgb(236, 242, 255);
        controlBoxMinimize.IconColor = Color.Black;
        controlBoxMinimize.Location = new Point(245, 2);
        controlBoxMinimize.Margin = new Padding(2);
        controlBoxMinimize.Name = "controlBoxMinimize";
        controlBoxMinimize.Size = new Size(45, 36);
        controlBoxMinimize.TabIndex = 3;
        // 
        // lblUser
        // 
        lblUser.AutoSize = true;
        lblUser.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblUser.ForeColor = Color.FromArgb(31, 122, 224);
        lblUser.Location = new Point(151, 12);
        lblUser.Margin = new Padding(0, 12, 11, 0);
        lblUser.Name = "lblUser";
        lblUser.Size = new Size(81, 30);
        lblUser.TabIndex = 1;
        lblUser.Text = "Admin";
        lblUser.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.BackColor = Color.White;
        label1.Font = new Font("Segoe UI Semibold", 35F, FontStyle.Bold);
        label1.ForeColor = Color.FromArgb(31, 122, 224);
        label1.Location = new Point(6, 24);
        label1.Name = "label1";
        label1.Size = new Size(483, 62);
        label1.TabIndex = 0;
        label1.Text = "QUẢN LÝ HỘI GIẢNG";
        // 
        // panelContainer
        // 
        panelContainer.Dock = DockStyle.Fill;
        panelContainer.FillColor = Color.White;
        panelContainer.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 163);
        panelContainer.Location = new Point(232, 79);
        panelContainer.Name = "panelContainer";
        panelContainer.Size = new Size(968, 575);
        panelContainer.TabIndex = 2;
        panelContainer.Paint += panelContainer_Paint;
        // 
        // FrmMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1200, 654);
        Controls.Add(panelContainer);
        Controls.Add(panelHeader);
        Controls.Add(panelMenu);
        FormBorderStyle = FormBorderStyle.None;
        MinimumSize = new Size(1200, 610);
        Name = "FrmMain";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "FrmMain";
        panelMenu.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        panelHeader.ResumeLayout(false);
        panelHeader.PerformLayout();
        flowHeaderTools.ResumeLayout(false);
        flowHeaderTools.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
    private Siticone.Desktop.UI.WinForms.SiticonePanel panelMenu;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnThongKe;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnLichGiang;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnSangKien;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnHoiGiang;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnBoMon;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnKhoa;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnGiangVien;
    private Siticone.Desktop.UI.WinForms.SiticonePanel panelHeader;
    private FlowLayoutPanel flowHeaderTools;
    private Siticone.Desktop.UI.WinForms.SiticoneControlBox controlBoxClose;
    private Siticone.Desktop.UI.WinForms.SiticoneControlBox controlBoxMinimize;
    private Label lblUser;
    private Label label1;
    private Siticone.Desktop.UI.WinForms.SiticonePanel panelContainer;
    private PictureBox pictureBox1;
}
