using FrmQLHoiGiang.Models;
using FrmQLHoiGiang.Services;
using FrmQLHoiGiang.Ui;
using Siticone.Desktop.UI.WinForms;
using System.Linq;
using System.Windows.Forms;

namespace FrmQLHoiGiang.Controls;

public partial class UcLichGiang : UserControl
{
    private readonly BindingSource _binding = new();
    private List<LichGiang> _data = new();
    private LichGiang? _current;
    private List<GiangVien> _giangVien = new();
    private List<DonVi> _donVi = new();
    private List<LookupItem> _khoa = new();
    private bool _suppressBoMonChange;

    public UcLichGiang()
    {
        InitializeComponent();
        gridLichGiang.AutoGenerateColumns = false;
        gridLichGiang.DataSource = _binding;
        cboGiangVien.SelectedIndexChanged += (_, _) => UpdateGiangVienInfo();
        cboBoMon.SelectedIndexChanged += (_, _) => HandleBoMonChanged();
        LoadLookups();
        LoadData();
        AppServices.GiangVien.Changed += HandleGiangVienChanged;
        AppServices.Lookup.LookupsChanged += HandleLookupsChanged;
    }

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        dialog.Parent = FindForm();
    }

    private void LoadLookups()
    {
        _giangVien = AppServices.GiangVien.GetGiangVien();
        _donVi = AppServices.Lookup.GetDonVi();
        _khoa = AppServices.Lookup.GetKhoa();
        BindGiangVien(_giangVien, GetSelectedId(cboGiangVien));
        BindBoMon(GetSelectedId(cboBoMon));

        cboLocGiangVien.DataSource = _giangVien.ToList();
        cboLocGiangVien.DisplayMember = "HoTen";
        cboLocGiangVien.ValueMember = "GiangVienId";
        UpdateKhoaFromBoMon(GetSelectedId(cboBoMon));
    }

    private void HandleGiangVienChanged()
    {
        var selectedMain = GetSelectedId(cboGiangVien);
        var selectedFilter = GetSelectedId(cboLocGiangVien);
        var selectedBoMon = GetSelectedId(cboBoMon);

        LoadLookups();

        if (selectedBoMon.HasValue)
        {
            cboBoMon.SelectedValue = selectedBoMon.Value;
        }

        if (selectedFilter.HasValue)
        {
            cboLocGiangVien.SelectedValue = selectedFilter.Value;
        }

        UpdateLichCaNhan();
        UpdateGiangVienInfo();
    }

    private void HandleLookupsChanged()
    {
        var selectedBoMon = GetSelectedId(cboBoMon);
        var selectedGiangVien = GetSelectedId(cboGiangVien);
        LoadLookups();
        RestoreSelection(cboBoMon, selectedBoMon);
        RestoreSelection(cboGiangVien, selectedGiangVien);
        UpdateKhoaFromBoMon(GetSelectedId(cboBoMon));
    }

    private static int? GetSelectedId(ComboBox combo)
    {
        if (combo.SelectedValue == null)
        {
            return null;
        }

        if (combo.SelectedValue is int value)
        {
            return value;
        }

        return int.TryParse(combo.SelectedValue.ToString(), out var parsed) ? parsed : null;
    }

    private static void RestoreSelection(ComboBox combo, int? value)
    {
        if (value.HasValue)
        {
            combo.SelectedValue = value.Value;
            if (combo.SelectedIndex != -1)
            {
                return;
            }
        }

        combo.SelectedIndex = combo.Items.Count > 0 ? 0 : -1;
    }

    private void LoadData()
    {
        _data = AppServices.LichGiang.GetAll();
        _binding.DataSource = _data;
        UpdateLichCaNhan();
        ClearForm();
    }

    private void ClearForm()
    {
        _current = null;
        txtNamHoc.Text = $"{DateTime.Now.Year}-{DateTime.Now.Year + 1}";
        txtTenLop.Text = string.Empty;
        txtTenMon.Text = string.Empty;
        cboBoMon.SelectedIndex = cboBoMon.Items.Count > 0 ? 0 : -1;
        txtKhoa.Text = string.Empty;
        txtGiangVienMaSo.Text = string.Empty;
        txtGiangVienKhoa.Text = string.Empty;
        cboBuoi.SelectedIndex = 0;
        dtNgayHoc.Value = DateTime.Today;
        txtPhong.Text = string.Empty;
        txtSoTiet.Text = "3";
        txtSiSo.Text = "40";
        btnHuy.Visible = false;
        btnLuu.FillColor = Color.FromArgb(31, 122, 224);
        btnLuu.Text = "Thêm mới";
        UpdateGiangVienInfo();
    }

    private void gridLichGiang_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.RowIndex >= _data.Count)
        {
            return;
        }

        _current = _data[e.RowIndex];
        txtNamHoc.Text = _current.NamHoc;
        txtTenLop.Text = _current.TenLop;
        txtTenMon.Text = _current.TenMon;
        cboGiangVien.SelectedValue = _current.GiangVienId;
        cboBuoi.SelectedItem = _current.Buoi;
        dtNgayHoc.Value = _current.NgayHoc;
        txtPhong.Text = _current.PhongHoc ?? string.Empty;
        txtSoTiet.Text = _current.SoTiet.ToString();
        txtSiSo.Text = _current.SoSinhVien?.ToString() ?? "0";

        btnHuy.Visible = true;
        btnLuu.FillColor = Color.SeaGreen;
        btnLuu.Text = "Cập nhật";
        UpdateGiangVienInfo();
    }

    private void UpdateGiangVienInfo()
    {
        if (cboGiangVien.SelectedValue is not int id)
        {
            txtGiangVienEmail.Text = string.Empty;
            txtGiangVienDienThoai.Text = string.Empty;
            txtGiangVienNgaySinh.Text = string.Empty;
            txtGiangVienMaSo.Text = string.Empty;
            txtGiangVienKhoa.Text = string.Empty;
            txtKhoa.Text = string.Empty;
            return;
        }

        var gv = _giangVien.FirstOrDefault(item => item.GiangVienId == id);
        if (gv == null)
        {
            txtGiangVienEmail.Text = string.Empty;
            txtGiangVienDienThoai.Text = string.Empty;
            txtGiangVienNgaySinh.Text = string.Empty;
            txtGiangVienMaSo.Text = string.Empty;
            txtGiangVienKhoa.Text = string.Empty;
            txtKhoa.Text = string.Empty;
            return;
        }

        txtGiangVienEmail.Text = gv.Email ?? string.Empty;
        txtGiangVienDienThoai.Text = gv.SoDienThoai ?? string.Empty;
        txtGiangVienNgaySinh.Text = FormatNgaySinh(gv.NgaySinh);
        txtGiangVienMaSo.Text = gv.MaSo ?? string.Empty;

        var khoa = gv.KhoaId.HasValue
            ? _khoa.FirstOrDefault(k => k.Id == gv.KhoaId.Value)?.Name
            : null;
        if (string.IsNullOrWhiteSpace(khoa) && gv.DonViId.HasValue)
        {
            khoa = _donVi.FirstOrDefault(d => d.Id == gv.DonViId.Value)?.Khoa;
        }

        txtGiangVienKhoa.Text = khoa ?? string.Empty;

        if (gv.DonViId.HasValue)
        {
            _suppressBoMonChange = true;
            cboBoMon.SelectedValue = gv.DonViId.Value;
            _suppressBoMonChange = false;
            UpdateKhoaFromBoMon(gv.DonViId.Value);
        }
    }

    private void HandleBoMonChanged()
    {
        if (_suppressBoMonChange)
        {
            return;
        }

        UpdateKhoaFromBoMon(GetSelectedId(cboBoMon));
    }

    private void UpdateKhoaFromBoMon(int? donViId)
    {
        if (!donViId.HasValue)
        {
            txtKhoa.Text = string.Empty;
            return;
        }

        var boMon = _donVi.FirstOrDefault(d => d.Id == donViId.Value);
        txtKhoa.Text = boMon?.Khoa ?? string.Empty;
    }

    private void BindBoMon(int? selectedId)
    {
        cboBoMon.DataSource = _donVi.ToList();
        cboBoMon.DisplayMember = "Name";
        cboBoMon.ValueMember = "Id";
        RestoreSelection(cboBoMon, selectedId);
    }

    private void BindGiangVien(IEnumerable<GiangVien> list, int? selectedId)
    {
        var data = list.ToList();
        cboGiangVien.DataSource = data;
        cboGiangVien.DisplayMember = "HoTen";
        cboGiangVien.ValueMember = "GiangVienId";
        RestoreSelection(cboGiangVien, selectedId);
        if (data.Count > 0 && cboGiangVien.SelectedIndex == -1)
        {
            cboGiangVien.SelectedIndex = 0;
        }
    }

    private static string FormatNgaySinh(DateTime ngaySinh)
    {
        return ngaySinh == default ? string.Empty : ngaySinh.ToString("dd/MM/yyyy");
    }

    private void ShowMessage(string message, MessageDialogIcon icon = MessageDialogIcon.Warning)
    {
        var mapped = MessageBoxIcon.Warning;
        if (icon == MessageDialogIcon.Information)
        {
            mapped = MessageBoxIcon.Information;
        }
        else if (icon == MessageDialogIcon.Error)
        {
            mapped = MessageBoxIcon.Error;
        }

        MessageBox.Show(FindForm(), message, "Thong bao", MessageBoxButtons.OK, mapped);
    }
    private void btnLuu_Click(object sender, EventArgs e)
    {
        if (cboGiangVien.SelectedValue == null || string.IsNullOrWhiteSpace(txtTenMon.Text))
        {
            ShowMessage("Chon giang vien va nhap ten mon.");
            return;
        }

        var entity = _current ?? new LichGiang();
        entity.NamHoc = txtNamHoc.Text.Trim();
        entity.TenLop = txtTenLop.Text.Trim();
        entity.TenMon = txtTenMon.Text.Trim();
        entity.GiangVienId = (int)cboGiangVien.SelectedValue;
        var gv = _giangVien.FirstOrDefault(item => item.GiangVienId == entity.GiangVienId);
        var selectedBoMonId = GetSelectedId(cboBoMon);
        if (gv != null && selectedBoMonId.HasValue)
        {
            var khoaGiangVien = gv.KhoaId.HasValue
                ? _khoa.FirstOrDefault(k => k.Id == gv.KhoaId.Value)?.Name
                : null;
            if (string.IsNullOrWhiteSpace(khoaGiangVien) && gv.DonViId.HasValue)
            {
                khoaGiangVien = _donVi.FirstOrDefault(d => d.Id == gv.DonViId.Value)?.Khoa;
            }

            var khoaBoMon = _donVi.FirstOrDefault(d => d.Id == selectedBoMonId.Value)?.Khoa;
            if (!string.IsNullOrWhiteSpace(khoaGiangVien) &&
                !string.IsNullOrWhiteSpace(khoaBoMon) &&
                !string.Equals(khoaGiangVien, khoaBoMon, StringComparison.OrdinalIgnoreCase))
            {
                ShowMessage("Giang vien nay khong thuoc khoa nay, khong the giang day.");
                return;
            }
        }        entity.Buoi = cboBuoi.SelectedItem?.ToString() ?? "Sáng";
        entity.NgayHoc = dtNgayHoc.Value.Date;
        entity.PhongHoc = txtPhong.Text.Trim();
        if (!int.TryParse(txtSoTiet.Text, out var soTiet))
        {
            ShowMessage("So tiet khong hop le.");
            return;
        }

        if (!int.TryParse(txtSiSo.Text, out var siSo))
        {
            ShowMessage("Si so khong hop le.");
            return;
        }

        entity.SoTiet = soTiet;
        entity.SoSinhVien = siSo;

        var result = AppServices.LichGiang.Save(entity);
        if (!result.Success)
        {
            ShowMessage(result.Error ?? "Khong the luu.", MessageDialogIcon.Error);
            return;
        }

        LoadData();
    }

    private void btnHuy_Click(object sender, EventArgs e)
    {
        ClearForm();
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        if (_current == null)
        {
            ShowMessage("Si so khong hop le.");
            return;
        }
        var confirmed = DialogHelper.Confirm(FindForm(), $"Xoa lich day {_current.TenMon}?");
        if (confirmed)
        {
            AppServices.LichGiang.Delete(_current.LichGiangId);
            LoadData();
        }
    }

    private void btnLamMoi_Click(object sender, EventArgs e)
    {
        LoadData();
    }

    private void btnXemLich_Click(object sender, EventArgs e)
    {
        UpdateLichCaNhan();
    }

    private void UpdateLichCaNhan()
    {
        if (cboLocGiangVien.SelectedValue == null)
        {
            return;
        }

        var id = (int)cboLocGiangVien.SelectedValue;
        var lich = _data.Where(l => l.GiangVienId == id)
            .OrderBy(l => l.NgayHoc)
            .ThenBy(l => l.Buoi)
            .Select(l => $"{l.NgayHoc:dd/MM} - {l.Buoi} - {l.TenMon} ({l.TenLop})")
            .ToList();

        lstLichCaNhan.Items.Clear();
        lstLichCaNhan.Items.AddRange(lich.Cast<object>().ToArray());
        lblTongTiet.Text = $"Tổng tiết/năm: {_data.Where(l => l.GiangVienId == id).Sum(l => l.SoTiet)}";
    }

    private void panelRight_Paint(object sender, PaintEventArgs e)
    {

    }

    private void cboLocGiangVien_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void dtNgayHoc_ValueChanged(object sender, EventArgs e)
    {
        dtNgayHoc.Format = DateTimePickerFormat.Custom;
        // Display the date as "dd-MM-yyyy"
        dtNgayHoc.CustomFormat = "dd-MM-yyyy";

    }

    private void cboGiangVien_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

