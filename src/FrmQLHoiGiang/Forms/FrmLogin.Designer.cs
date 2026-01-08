namespace FrmQLHoiGiang.Forms;

partial class FrmLogin
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
        panelRoot = new Siticone.Desktop.UI.WinForms.SiticonePanel();
        pictureBox1 = new PictureBox();
        controlBoxMinimize = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
        controlBoxClose = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
        label3 = new Label();
        label2 = new Label();
        panelLogin = new Siticone.Desktop.UI.WinForms.SiticonePanel();
        label1 = new Label();
        btnLogin = new Siticone.Desktop.UI.WinForms.SiticoneButton();
        txtPassword = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        txtUsername = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
        dialog = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
        panelRoot.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        panelLogin.SuspendLayout();
        SuspendLayout();
        // 
        // siticoneBorderlessForm1
        // 
        siticoneBorderlessForm1.BorderRadius = 12;
        siticoneBorderlessForm1.ContainerControl = this;
        siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
        siticoneBorderlessForm1.TransparentWhileDrag = true;
        // 
        // panelRoot
        // 
        panelRoot.Anchor = AnchorStyles.None;
        panelRoot.Controls.Add(pictureBox1);
        panelRoot.Controls.Add(controlBoxMinimize);
        panelRoot.Controls.Add(controlBoxClose);
        panelRoot.Controls.Add(label3);
        panelRoot.Controls.Add(label2);
        panelRoot.Controls.Add(panelLogin);
        panelRoot.Location = new Point(0, 0);
        panelRoot.Name = "panelRoot";
        panelRoot.Padding = new Padding(40);
        panelRoot.Size = new Size(746, 421);
        panelRoot.TabIndex = 0;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.logot01;
        pictureBox1.Location = new Point(43, 43);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(291, 179);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 6;
        pictureBox1.TabStop = false;
        pictureBox1.Click += pictureBox1_Click;
        // 
        // controlBoxMinimize
        // 
        controlBoxMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        controlBoxMinimize.BorderRadius = 4;
        controlBoxMinimize.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
        controlBoxMinimize.FillColor = Color.White;
        controlBoxMinimize.HoverState.FillColor = Color.FromArgb(236, 242, 255);
        controlBoxMinimize.IconColor = Color.FromArgb(64, 64, 64);
        controlBoxMinimize.Location = new Point(637, 8);
        controlBoxMinimize.Margin = new Padding(2);
        controlBoxMinimize.Name = "controlBoxMinimize";
        controlBoxMinimize.Size = new Size(32, 21);
        controlBoxMinimize.TabIndex = 5;
        // 
        // controlBoxClose
        // 
        controlBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        controlBoxClose.BorderRadius = 4;
        controlBoxClose.FillColor = Color.White;
        controlBoxClose.HoverState.FillColor = Color.FromArgb(240, 85, 68);
        controlBoxClose.HoverState.IconColor = Color.White;
        controlBoxClose.IconColor = Color.FromArgb(64, 64, 64);
        controlBoxClose.Location = new Point(672, 8);
        controlBoxClose.Margin = new Padding(2);
        controlBoxClose.Name = "controlBoxClose";
        controlBoxClose.Size = new Size(32, 21);
        controlBoxClose.TabIndex = 4;
        controlBoxClose.Click += controlBoxClose_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 16F);
        label3.ForeColor = Color.FromArgb(64, 64, 64);
        label3.Location = new Point(68, 258);
        label3.Name = "label3";
        label3.Size = new Size(405, 30);
        label3.TabIndex = 2;
        label3.Text = "Quản lý hội giảng, sáng kiến và thống kê";
        label3.Click += label3_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
        label2.ForeColor = Color.FromArgb(31, 122, 224);
        label2.Location = new Point(84, 225);
        label2.Name = "label2";
        label2.Size = new Size(349, 37);
        label2.TabIndex = 1;
        label2.Text = "Học viện An ninh nhân dân";
        label2.Click += label2_Click;
        // 
        // panelLogin
        // 
        panelLogin.BorderColor = Color.Gainsboro;
        panelLogin.BorderRadius = 16;
        panelLogin.BorderThickness = 1;
        panelLogin.Controls.Add(label1);
        panelLogin.Controls.Add(btnLogin);
        panelLogin.Controls.Add(txtPassword);
        panelLogin.Controls.Add(txtUsername);
        panelLogin.FillColor = Color.White;
        panelLogin.Location = new Point(401, 44);
        panelLogin.Name = "panelLogin";
        panelLogin.Padding = new Padding(24);
        panelLogin.Size = new Size(295, 338);
        panelLogin.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
        label1.ForeColor = Color.FromArgb(31, 122, 224);
        label1.Location = new Point(24, 24);
        label1.Name = "label1";
        label1.Size = new Size(151, 37);
        label1.TabIndex = 3;
        label1.Text = "Đăng nhập";
        // 
        // btnLogin
        // 
        btnLogin.BorderRadius = 8;
        btnLogin.DisabledState.BorderColor = Color.DarkGray;
        btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
        btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        btnLogin.FillColor = Color.FromArgb(31, 122, 224);
        btnLogin.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        btnLogin.ForeColor = Color.White;
        btnLogin.Location = new Point(24, 214);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(244, 45);
        btnLogin.TabIndex = 2;
        btnLogin.Text = "Đăng nhập";
        btnLogin.Click += btnLogin_Click;
        // 
        // txtPassword
        // 
        txtPassword.BorderRadius = 8;
        txtPassword.Cursor = Cursors.IBeam;
        txtPassword.DefaultText = "";
        txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
        txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
        txtPassword.Font = new Font("Segoe UI", 16F);
        txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
        txtPassword.Location = new Point(24, 138);
        txtPassword.Margin = new Padding(3, 4, 3, 4);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '●';
        txtPassword.PlaceholderText = "Mật khẩu";
        txtPassword.SelectedText = "";
        txtPassword.Size = new Size(244, 45);
        txtPassword.TabIndex = 1;
        txtPassword.UseSystemPasswordChar = true;
        // 
        // txtUsername
        // 
        txtUsername.BorderRadius = 8;
        txtUsername.Cursor = Cursors.IBeam;
        txtUsername.DefaultText = "";
        txtUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
        txtUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        txtUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        txtUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
        txtUsername.Font = new Font("Segoe UI", 16F);
        txtUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
        txtUsername.Location = new Point(24, 69);
        txtUsername.Margin = new Padding(3, 4, 3, 4);
        txtUsername.Name = "txtUsername";
        txtUsername.PasswordChar = '\0';
        txtUsername.PlaceholderText = "Tên đăng nhập";
        txtUsername.SelectedText = "";
        txtUsername.Size = new Size(244, 45);
        txtUsername.TabIndex = 0;
        // 
        // dialog
        // 
        dialog.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.OK;
        dialog.Caption = "Thông báo";
        dialog.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Warning;
        dialog.Parent = null;
        dialog.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Light;
        dialog.Text = "message";
        // 
        // FrmLogin
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(746, 420);
        Controls.Add(panelRoot);
        FormBorderStyle = FormBorderStyle.None;
        Name = "FrmLogin";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "FrmLogin";
        Load += FrmLogin_Load;
        panelRoot.ResumeLayout(false);
        panelRoot.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        panelLogin.ResumeLayout(false);
        panelLogin.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
    private Siticone.Desktop.UI.WinForms.SiticonePanel panelRoot;
    private Siticone.Desktop.UI.WinForms.SiticoneControlBox controlBoxMinimize;
    private Siticone.Desktop.UI.WinForms.SiticoneControlBox controlBoxClose;
    private Siticone.Desktop.UI.WinForms.SiticonePanel panelLogin;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtPassword;
    private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtUsername;
    private Siticone.Desktop.UI.WinForms.SiticoneButton btnLogin;
    private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog dialog;
    private Label label1;
    private Label label2;
    private Label label3;
    private PictureBox pictureBox1;
}
