using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using FrmQLHoiGiang.Models;
using FrmQLHoiGiang.Services;
using FrmQLHoiGiang.Ui;
using Siticone.Desktop.UI.WinForms;

namespace FrmQLHoiGiang.Controls;

public partial class UcHoiGiang : UserControl
{
    private const string CapHocVien = "H\u1ECDc vi\u1EC7n";
    private const string CapKhoa = "Khoa";
    private const string CapBo = "B\u1ED9";
    private const string RoleChuTich = "Ch\u1EE7 t\u1ECBch";
    private const string RoleThanhVien = "Th\u00E0nh vi\u00EAn";
    private const string RoleThuKy = "Th\u01B0 k\u00FD";
    private readonly BindingSource _bindingHoiGiang = new();
    private readonly List<GiangVien> _giangVien = new();
    private readonly List<LookupItem> _hocPhan = new();
    private readonly List<LookupItem> _capBac = new();
    private readonly List<LookupItem> _chucDanh = new();
    private readonly List<DonVi> _donVi = new();
    private readonly List<LookupItem> _khoa = new();
    private List<BaiHoiGiang> _hoiGiang = new();
    private BaiHoiGiang? _selected;
    private bool _suppressHocPhanTextChange;

    private SiticoneTextBox[] PracticeScoreBoxes =>
        new[] { txtDiemThanhVien1, txtDiemThanhVien2, txtDiemThanhVien3, txtDiemThanhVien4, txtDiemThanhVien5 };

    public UcHoiGiang()
    {
        InitializeComponent();
        txtDiemThucHanh.ReadOnly = true;
        gridHoiGiang.AutoGenerateColumns = false;
        gridHoiGiang.DataSource = _bindingHoiGiang;
        cboHocPhan.DropDownStyle = ComboBoxStyle.DropDown;
        txtQuickFilter.TextChanged += (_, _) => ApplyQuickFilter();
        LoadLookups();
        cboGiangVien.SelectedIndexChanged += (_, _) => UpdateGiangVienInfo();
        cboHocPhan.TextChanged += cboHocPhan_TextChanged;
        LoadHoiGiang();
        AppServices.GiangVien.Changed += HandleGiangVienChanged;
    }

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        dialog.Parent = FindForm();
    }

    private void btnRefreshHoiGiang_Click(object sender, EventArgs e)
    {
        LoadHoiGiang();
    }

    private void LoadLookups()
    {
        _giangVien.Clear();
        _giangVien.AddRange(AppServices.GiangVien.GetGiangVien());
        cboGiangVien.DataSource = _giangVien.ToList();
        cboGiangVien.DisplayMember = "HoTen";
        cboGiangVien.ValueMember = "GiangVienId";

        _hocPhan.Clear();
        _hocPhan.AddRange(AppServices.Lookup.GetHocPhan());
        cboHocPhan.DataSource = _hocPhan.ToList();
        cboHocPhan.DisplayMember = "Name";
        cboHocPhan.ValueMember = "Id";

        _capBac.Clear();
        _capBac.AddRange(AppServices.Lookup.GetCapBac());
        _chucDanh.Clear();
        _chucDanh.AddRange(AppServices.Lookup.GetChucDanhGiangDay());
        _donVi.Clear();
        _donVi.AddRange(AppServices.Lookup.GetDonVi());
        _khoa.Clear();
        _khoa.AddRange(AppServices.Lookup.GetKhoa());

        var gvSource = _giangVien.Select(g => new { g.GiangVienId, g.HoTen }).ToList();
        foreach (var combo in new[] { cboThanhVien1, cboThanhVien2, cboThanhVien3, cboThanhVien4, cboThanhVien5 })
        {
            combo.DataSource = gvSource.ToList();
            combo.DisplayMember = "HoTen";
            combo.ValueMember = "GiangVienId";
            combo.SelectedIndex = -1;
        }

        cboCapThucHien.Items.Clear();
        cboCapThucHien.Items.AddRange(new object[] { CapHocVien, CapKhoa, CapBo });
        cboCapThucHien.SelectedIndex = 0;
    }

    private void LoadHoiGiang()
    {
        _hoiGiang = AppServices.HoiGiang.GetBaiHoiGiang();
        ApplyQuickFilter();
        BindHoiGiangCombos();
        ClearHoiGiangForm();
        gridHoiGiang.ClearSelection();
    }

    private void ApplyQuickFilter()
    {
        var query = txtQuickFilter.Text.Trim();
        if (string.IsNullOrWhiteSpace(query))
        {
            _bindingHoiGiang.DataSource = _hoiGiang;
            return;
        }

        var needle = query.ToLowerInvariant();
        _bindingHoiGiang.DataSource = _hoiGiang.Where(b =>
            b.TenBai.ToLowerInvariant().Contains(needle) ||
            b.GiangVien.ToLowerInvariant().Contains(needle) ||
            b.ThoiGian.ToString("dd/MM/yyyy").ToLowerInvariant().Contains(needle) ||
            b.CapThucHien.ToLowerInvariant().Contains(needle)
        ).ToList();
    }

    private void BindHoiGiangCombos()
    {
        cboHoiDongBai.DataSource = _hoiGiang.Select(b => new { b.BaiHoiGiangId, b.TenBai }).ToList();
        cboHoiDongBai.DisplayMember = "TenBai";
        cboHoiDongBai.ValueMember = "BaiHoiGiangId";

        cboKetQuaBai.DataSource = _hoiGiang.Select(b => new { b.BaiHoiGiangId, b.TenBai }).ToList();
        cboKetQuaBai.DisplayMember = "TenBai";
        cboKetQuaBai.ValueMember = "BaiHoiGiangId";
    }

    private void cboHocPhan_TextChanged(object? sender, EventArgs e)
    {
        if (_suppressHocPhanTextChange)
        {
            return;
        }

        var text = cboHocPhan.Text.Trim();
        if (string.IsNullOrWhiteSpace(text))
        {
            return;
        }

        var match = _hocPhan.FirstOrDefault(h =>
            string.Equals(h.Name, text, StringComparison.OrdinalIgnoreCase));
        if (match == null)
        {
            return;
        }

        var currentId = GetSelectedId(cboHocPhan);
        if (currentId == match.Id)
        {
            return;
        }

        _suppressHocPhanTextChange = true;
        cboHocPhan.SelectedValue = match.Id;
        _suppressHocPhanTextChange = false;
    }

    private void FillHoiGiangForm(BaiHoiGiang entity)
    {
        _selected = entity;
        cboGiangVien.SelectedValue = entity.GiangVienId;
        txtTenBai.Text = entity.TenBai;
        if (entity.HocPhanId.HasValue)
        {
            cboHocPhan.SelectedValue = entity.HocPhanId.Value;
        }
        else
        {
            cboHocPhan.SelectedIndex = -1;
        }

        txtLop.Text = entity.LopThucHien ?? string.Empty;
        dtThoiGian.Value = entity.ThoiGian;
        SetCapThucHienSelection(entity.CapThucHien);
        btnLuuHoiGiang.Text = "Cap nhat";
        btnLuuHoiGiang.FillColor = Color.SeaGreen;
        UpdateGiangVienInfo();
    }

    private void ClearHoiGiangForm()
    {
        _selected = null;
        txtTenBai.Text = string.Empty;
        txtLop.Text = string.Empty;
        dtThoiGian.Value = DateTime.Now;
        cboCapThucHien.SelectedIndex = 0;
        cboHocPhan.SelectedIndex = -1;
        cboHocPhan.Text = string.Empty;
        btnLuuHoiGiang.Text = "Them moi";
        btnLuuHoiGiang.FillColor = Color.FromArgb(31, 122, 224);
        txtGiangVienDonVi.Text = string.Empty;
        txtGiangVienCapBac.Text = string.Empty;
        txtGiangVienChucDanh.Text = string.Empty;
        txtGiangVienEmail.Text = string.Empty;
        txtGiangVienDienThoai.Text = string.Empty;
        txtGiangVienNgaySinh.Text = string.Empty;
    }

    private void UpdateGiangVienInfo()
    {
        if (cboGiangVien.SelectedValue is not int id)
        {
            txtGiangVienDonVi.Text = "";
            txtGiangVienCapBac.Text = "";
            txtGiangVienChucDanh.Text = "";
            txtGiangVienEmail.Text = "";
            txtGiangVienDienThoai.Text = "";
            txtGiangVienNgaySinh.Text = "";
            return;
        }

        var gv = _giangVien.FirstOrDefault(g => g.GiangVienId == id);
        if (gv == null)
        {
            txtGiangVienDonVi.Text = "";
            txtGiangVienCapBac.Text = "";
            txtGiangVienChucDanh.Text = "";
            txtGiangVienEmail.Text = "";
            txtGiangVienDienThoai.Text = "";
            txtGiangVienNgaySinh.Text = "";
            return;
        }

        var khoa = gv.KhoaId.HasValue
            ? _khoa.FirstOrDefault(k => k.Id == gv.KhoaId.Value)?.Name
            : null;
        if (string.IsNullOrWhiteSpace(khoa) && gv.DonViId.HasValue)
        {
            khoa = _donVi.FirstOrDefault(d => d.Id == gv.DonViId.Value)?.Khoa;
        }

        txtGiangVienDonVi.Text = khoa ?? string.Empty;
        txtGiangVienCapBac.Text = _capBac.FirstOrDefault(c => c.Id == gv.CapBacId)?.Name ?? string.Empty;
        txtGiangVienChucDanh.Text = _chucDanh.FirstOrDefault(c => c.Id == gv.ChucDanhId)?.Name ?? string.Empty;
        txtGiangVienEmail.Text = gv.Email ?? string.Empty;
        txtGiangVienDienThoai.Text = gv.SoDienThoai ?? string.Empty;
        txtGiangVienNgaySinh.Text = FormatNgaySinh(gv.NgaySinh);
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

    private void gridHoiGiang_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.RowIndex >= _bindingHoiGiang.Count)
        {
            return;
        }

        var selected = _bindingHoiGiang[e.RowIndex] as BaiHoiGiang;
        if (selected == null)
        {
            return;
        }
        FillHoiGiangForm(selected);
        SelectBaiHoiGiangForTabs(selected.BaiHoiGiangId);
        LoadHoiDong();
        LoadKetQua();
    }

    private void btnLuuHoiGiang_Click(object sender, EventArgs e)
    {
        if (cboGiangVien.SelectedValue == null || string.IsNullOrWhiteSpace(txtTenBai.Text))
        {
            ShowMessage("Chon giang vien va nhap ten bai.");
            return;
        }

        var entity = _selected ?? new BaiHoiGiang();
        var selectedGv = _giangVien.First(g => g.GiangVienId == (int)cboGiangVien.SelectedValue);
        entity.GiangVienId = selectedGv.GiangVienId;
        entity.CapBacId = selectedGv.CapBacId;
        entity.DonViId = selectedGv.DonViId;
        entity.ChucDanhId = selectedGv.ChucDanhId;
        entity.TenBai = txtTenBai.Text.Trim();
        entity.HocPhanId = GetHocPhanIdFromInput();
        if (!string.IsNullOrWhiteSpace(cboHocPhan.Text) && !entity.HocPhanId.HasValue)
        {
            ShowMessage("Hoc phan khong ton tai. Vui long chon dung ten hoc phan.");
            return;
        }
        entity.LopThucHien = txtLop.Text.Trim();
        entity.ThoiGian = dtThoiGian.Value;
        entity.CapThucHien = GetCapThucHienFromSelection();
        entity.TrangThai ??= "Chua cham";

        try
        {
            AppServices.HoiGiang.SaveBaiHoiGiang(entity);
            LoadHoiGiang();
            ClearHoiGiangForm();
        }
        catch (Exception ex)
        {
            ShowMessage($"Khong the luu bai hoi giang: {ex.Message}", MessageDialogIcon.Error);
        }
    }

    private void btnHoiDongLoad_Click(object sender, EventArgs e)
    {
        LoadHoiDong();
    }

    private void LoadHoiDong()
    {
        if (cboHoiDongBai.SelectedValue == null)
        {
            return;
        }

        var hoiDong = AppServices.HoiGiang.GetHoiDong(Convert.ToInt32(cboHoiDongBai.SelectedValue));
        ClearHoiDongForm();
        if (hoiDong == null)
        {
            return;
        }

        txtTenHoiDong.Text = hoiDong.TenHoiDong;
        var thanhVien = hoiDong.ThanhVien.ToList();
        var members = thanhVien.Where(m => m.VaiTro == RoleThanhVien).Take(3).ToList();
        var chair = thanhVien.FirstOrDefault(m => m.VaiTro == RoleChuTich);
        var secretary = thanhVien.FirstOrDefault(m => m.VaiTro == RoleThuKy);

        if (chair != null) cboThanhVien1.SelectedValue = chair.GiangVienId;
        for (var i = 0; i < members.Count; i++)
        {
            new[] { cboThanhVien2, cboThanhVien3, cboThanhVien4 }[i].SelectedValue = members[i].GiangVienId;
        }

        if (secretary != null) cboThanhVien5.SelectedValue = secretary.GiangVienId;
    }

    private void ClearHoiDongForm()
    {
        txtTenHoiDong.Text = "Hoi dong khoa";
        foreach (var combo in new[] { cboThanhVien1, cboThanhVien2, cboThanhVien3, cboThanhVien4, cboThanhVien5 })
        {
            combo.SelectedIndex = -1;
        }
    }

    private void btnLuuHoiDong_Click(object sender, EventArgs e)
    {
        if (cboHoiDongBai.SelectedValue == null)
        {
            ShowMessage("Chon bai hoi giang truoc khi gan hoi dong.");
            return;
        }

        var baiHoiGiangId = Convert.ToInt32(cboHoiDongBai.SelectedValue);
        var baiHoiGiang = _hoiGiang.FirstOrDefault(b => b.BaiHoiGiangId == baiHoiGiangId);
        if (baiHoiGiang == null)
        {
            ShowMessage("Khong tim thay bai hoi giang.");
            return;
        }

        var selections = new[]
        {
            (Combo:cboThanhVien1, Role:RoleChuTich),
            (Combo:cboThanhVien2, Role:RoleThanhVien),
            (Combo:cboThanhVien3, Role:RoleThanhVien),
            (Combo:cboThanhVien4, Role:RoleThanhVien),
            (Combo:cboThanhVien5, Role:RoleThuKy),
        };

        if (selections.Any(x => x.Combo.SelectedValue == null))
        {
            ShowMessage("Can du 5 thanh vien theo co cau.");
            return;
        }

        var selectedIds = selections.Select(x => (int)x.Combo.SelectedValue!).ToList();
        if (selectedIds.Contains(baiHoiGiang.GiangVienId))
        {
            ShowMessage("Giang vien dang hoi giang khong duoc tham gia hoi dong.");
            return;
        }

        if (selectedIds.Distinct().Count() != selectedIds.Count)
        {
            ShowMessage("Moi thanh vien chi duoc chon mot lan.");
            return;
        }

        var hoiDong = new HoiDong
        {
            BaiHoiGiangId = baiHoiGiangId,
            TenHoiDong = txtTenHoiDong.Text.Trim(),
            NgayLap = DateTime.Now
        };

        foreach (var item in selections)
        {
            hoiDong.ThanhVien.Add(new ThanhVienHoiDong
            {
                GiangVienId = (int)item.Combo.SelectedValue!,
                VaiTro = item.Role
            });
        }

        try
        {
            AppServices.HoiGiang.SaveHoiDong(hoiDong);
            ShowMessage("Da luu hoi dong.", MessageDialogIcon.Information);
        }
        catch (Exception ex)
        {
            ShowMessage($"Khong the luu hoi dong: {ex.Message}", MessageDialogIcon.Error);
        }
    }

    private void btnLoadKetQua_Click(object sender, EventArgs e)
    {
        LoadKetQua();
    }

    private void btnTinhKetQua_Click(object sender, EventArgs e)
    {
        if (!decimal.TryParse(txtDiemHieuBiet.Text, out var hieuBiet) ||
            !decimal.TryParse(txtDiemHoSo.Text, out var hoSo))
        {
            ShowMessage("Diem hien biet va ho so khong hop le.");
            return;
        }

        if (!TryGetPracticeAverage(out var thucHanh))
        {
            return;
        }

        txtDiemThucHanh.Text = thucHanh.ToString("0.##");
        var tong = hieuBiet + hoSo + thucHanh;
        txtTongDiem.Text = tong.ToString("0.##");

        if (tong >= 25)
        {
            txtXepLoai.Text = "Nhất";
        }
        else if (tong >= 22.5m)
        {
            txtXepLoai.Text = "Nhì";
        }
        else if (tong >= 20)
        {
            txtXepLoai.Text = "Ba";
        }
        else
        {
            txtXepLoai.Text = "Khuyến khích";
        }
    }

    private bool TryGetPracticeAverage(out decimal average)
    {
        average = 0;
        var scores = new List<decimal>();
        foreach (var box in PracticeScoreBoxes)
        {
            if (!decimal.TryParse(box.Text, out var diem))
            {
                ShowMessage("Nhap diem cho moi thanh vien hoi dong.");
                return false;
            }

            scores.Add(diem);
        }

        average = scores.Average();
        return true;
    }

    private bool TryGetMemberScores(out List<decimal> scores)
    {
        scores = new List<decimal>();
        foreach (var box in PracticeScoreBoxes)
        {
            if (!decimal.TryParse(box.Text, out var diem))
            {
                ShowMessage("Nhap diem cho moi thanh vien hoi dong.");
                return false;
            }

            scores.Add(diem);
        }

        return true;
    }

    private void btnLuuKetQua_Click(object sender, EventArgs e)
    {
        if (cboKetQuaBai.SelectedValue == null)
        {
            ShowMessage("Chon bai hoi giang.");
            return;
        }

        if (!decimal.TryParse(txtDiemHieuBiet.Text, out var hieuBiet) ||
            !decimal.TryParse(txtDiemHoSo.Text, out var hoSo) ||
            !decimal.TryParse(txtDiemThucHanh.Text, out var thucHanh) ||
            !decimal.TryParse(txtTongDiem.Text, out var tong))
        {
            ShowMessage("Vui long tinh diem truoc khi luu.");
            return;
        }

        if (!TryGetMemberScores(out var memberScores))
        {
            return;
        }

        var selectedBaiHoiGiangId = (int)cboKetQuaBai.SelectedValue;
        var existing = AppServices.HoiGiang.GetKetQua(selectedBaiHoiGiangId);
        var ketQua = new KetQuaHoiGiang
        {
            BaiHoiGiangId = selectedBaiHoiGiangId,
            TongDiem = tong,
            XepLoai = txtXepLoai.Text,
            KetQuaHoiGiangId = existing?.KetQuaHoiGiangId ?? 0
        };

        ketQua.ThanhPhan.Add(new KetQuaThanhPhan { TenPhanThi = "Phan thi hieu biet", Diem = hieuBiet });
        ketQua.ThanhPhan.Add(new KetQuaThanhPhan { TenPhanThi = "Phan thi gioi thieu giang vien va ho so bai", Diem = hoSo });
        ketQua.ThanhPhan.Add(new KetQuaThanhPhan { TenPhanThi = "Phan thuc hanh giang (TB 5 phieu)", Diem = thucHanh });
        for (var i = 0; i < memberScores.Count; i++)
        {
            ketQua.ThanhPhan.Add(new KetQuaThanhPhan
            {
                TenPhanThi = $"Diem TV {i + 1}",
                Diem = memberScores[i]
            });
        }

        try
        {
            AppServices.HoiGiang.SaveKetQua(ketQua);
            ShowMessage("Da luu ket qua.", MessageDialogIcon.Information);
            LoadHoiGiang();
        }
        catch (Exception ex)
        {
            ShowMessage($"Khong the luu ket qua: {ex.Message}", MessageDialogIcon.Error);
        }
    }

    private static int? GetSelectedId(SiticoneComboBox combo)
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

    private int? GetHocPhanIdFromInput()
    {
        var text = cboHocPhan.Text.Trim();
        if (string.IsNullOrWhiteSpace(text))
        {
            return null;
        }

        var match = _hocPhan.FirstOrDefault(h =>
            string.Equals(h.Name, text, StringComparison.OrdinalIgnoreCase));
        return match?.Id;
    }

    private static string NormalizeCapThucHien(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return CapHocVien;
        }

        var text = value.Trim();
        var compareInfo = CultureInfo.GetCultureInfo("vi-VN").CompareInfo;
        var options = CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace;
        if (compareInfo.Compare(text, CapHocVien, options) == 0)
        {
            return CapHocVien;
        }

        if (compareInfo.Compare(text, CapKhoa, options) == 0)
        {
            return CapKhoa;
        }

        if (compareInfo.Compare(text, CapBo, options) == 0 ||
            compareInfo.Compare(text, "Bo", options) == 0)
        {
            return CapBo;
        }

        return text;
    }

    private void SetCapThucHienSelection(string? value)
    {
        var normalized = NormalizeCapThucHien(value);
        if (normalized == CapKhoa && cboCapThucHien.Items.Count > 1)
        {
            cboCapThucHien.SelectedIndex = 1;
            return;
        }

        if (normalized == CapBo && cboCapThucHien.Items.Count > 2)
        {
            cboCapThucHien.SelectedIndex = 2;
            return;
        }

        if (cboCapThucHien.Items.Count > 0)
        {
            cboCapThucHien.SelectedIndex = 0;
        }
    }

    private string GetCapThucHienFromSelection()
    {
        return cboCapThucHien.SelectedIndex switch
        {
            1 => CapKhoa,
            2 => CapBo,
            _ => CapHocVien
        };
    }

    private void SelectBaiHoiGiangForTabs(int baiHoiGiangId)
    {
        if (cboHoiDongBai.DataSource != null)
        {
            cboHoiDongBai.SelectedValue = baiHoiGiangId;
        }

        if (cboKetQuaBai.DataSource != null)
        {
            cboKetQuaBai.SelectedValue = baiHoiGiangId;
        }
    }

    private void btnXoaHoiGiang_Click(object sender, EventArgs e)
    {
        if (_selected == null)
        {
            ShowMessage("Chon bai hoi giang can xoa.");
            return;
        }

        var confirmed = DialogHelper.Confirm(FindForm(), $"Xoa bai hoi giang \"{_selected.TenBai}\"?");
        if (!confirmed)
        {
            return;
        }

        try
        {
            AppServices.HoiGiang.DeleteBaiHoiGiang(_selected.BaiHoiGiangId);
            LoadHoiGiang();
            ClearHoiGiangForm();
        }
        catch (Exception ex)
        {
            ShowMessage($"Khong the xoa bai hoi giang: {ex.Message}", MessageDialogIcon.Error);
        }
    }

    private void LoadKetQua()
    {
        if (cboKetQuaBai.SelectedValue == null)
        {
            return;
        }

        var ketQua = AppServices.HoiGiang.GetKetQua((int)cboKetQuaBai.SelectedValue);
        foreach (var box in PracticeScoreBoxes)
        {
            box.Text = string.Empty;
        }

        if (ketQua == null)
        {
            txtDiemHieuBiet.Text = "";
            txtDiemHoSo.Text = "";
            txtDiemThucHanh.Text = "";
            txtTongDiem.Text = "";
            txtXepLoai.Text = "";
            return;
        }

        txtTongDiem.Text = ketQua.TongDiem.ToString("0.##");
        txtXepLoai.Text = ketQua.XepLoai;
        txtDiemHieuBiet.Text = ketQua.ThanhPhan.FirstOrDefault(x => x.TenPhanThi == "Phan thi hieu biet")?.Diem.ToString("0.##") ?? "";
        txtDiemHoSo.Text = ketQua.ThanhPhan.FirstOrDefault(x => x.TenPhanThi == "Phan thi gioi thieu giang vien va ho so bai")?.Diem.ToString("0.##") ?? "";
        txtDiemThucHanh.Text = ketQua.ThanhPhan.FirstOrDefault(x => x.TenPhanThi.StartsWith("Phan thuc hanh"))?.Diem.ToString("0.##") ?? "";
        for (var i = 0; i < PracticeScoreBoxes.Length; i++)
        {
            var score = ketQua.ThanhPhan.FirstOrDefault(x => x.TenPhanThi == $"Diem TV {i + 1}")?.Diem;
            PracticeScoreBoxes[i].Text = score?.ToString("0.##") ?? "";
        }
    }

    private void gridHoiGiang_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void tabDangKy_Click(object sender, EventArgs e)
    {

    }

    private void panelLeft_Paint(object sender, PaintEventArgs e)
    {

    }

    private void panelRight_Paint(object sender, PaintEventArgs e)
    {

    }

    private void tabKetQua_Click(object sender, EventArgs e)
    {

    }

    private void cboHocPhan_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void txtGiangVienDonVi_TextChanged(object sender, EventArgs e)
    {

    }
    private void HandleGiangVienChanged()
    {
        LoadLookups();
    }
}


