using FrmQLHoiGiang.DTOs;
using FrmQLHoiGiang.Services;
using System.Linq;

namespace FrmQLHoiGiang.Controls;

public partial class UcBaoCao : UserControl
{
    private List<TietDayTheoGiangVienDto> _tietGiangVien = new();
    private List<TietDayTheoKhoaDto> _tietKhoa = new();
    private List<SangKienTheoGiangVienDto> _sangKien = new();
    private List<GiaiThuongTheoKhoaDto> _giaiThuong = new();
    private List<ThamGiaHoiDongDto> _hoiDong = new();
    private List<TongHopHoiGiangDto> _hoiGiang = new();

    public UcBaoCao()
    {
        InitializeComponent();
        txtNamHoc.Text = DateTime.Now.Year.ToString();
        txtQuickFilter.TextChanged += (_, _) => ApplyQuickFilter();
        tabBaoCao.SelectedIndexChanged += (_, _) => ApplyQuickFilter();
        LoadThongKe();
        AppServices.GiangVien.Changed += HandleGiangVienChanged;
    }

    private void btnTaiBaoCao_Click(object sender, EventArgs e)
    {
        LoadThongKe();
    }

    private void LoadThongKe()
    {
        var namHoc = txtNamHoc.Text.Trim();
        if (string.IsNullOrWhiteSpace(namHoc))
        {
            namHoc = DateTime.Now.Year.ToString();
        }

        _tietGiangVien = AppServices.ThongKe.GetTietDayTheoGiangVien(namHoc);
        _tietKhoa = AppServices.ThongKe.GetTietDayTheoKhoa(namHoc);
        _sangKien = AppServices.ThongKe.GetSangKienTheoGiangVien();
        _giaiThuong = AppServices.ThongKe.GetGiaiThuongTheoKhoa();
        _hoiDong = AppServices.ThongKe.GetThamGiaHoiDong();
        _hoiGiang = AppServices.ThongKe.GetTongHopHoiGiang(namHoc);
        ApplyQuickFilter();
    }

    private void HandleGiangVienChanged()
    {
        LoadThongKe();
    }

    private void panelTop_Paint(object sender, PaintEventArgs e)
    {

    }

    private void gridTietGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void ApplyQuickFilter()
    {
        var query = txtQuickFilter.Text.Trim().ToLowerInvariant();
        if (string.IsNullOrWhiteSpace(query))
        {
            gridTietGV.DataSource = _tietGiangVien;
            gridTietKhoa.DataSource = _tietKhoa;
            gridSangKien.DataSource = _sangKien;
            gridGiaiThuong.DataSource = _giaiThuong;
            gridHoiDong.DataSource = _hoiDong;
            gridHoiGiang.DataSource = _hoiGiang;
            return;
        }

        var tab = tabBaoCao.SelectedTab;
        if (tab == tabTiet)
        {
            gridTietGV.DataSource = _tietGiangVien.Where(x =>
                x.GiangVien.ToLowerInvariant().Contains(query) ||
                x.TongTiet.ToString().Contains(query)).ToList();
            gridTietKhoa.DataSource = _tietKhoa.Where(x =>
                x.Khoa.ToLowerInvariant().Contains(query) ||
                x.TongTiet.ToString().Contains(query)).ToList();
            return;
        }

        if (tab == tabSangKien)
        {
            gridSangKien.DataSource = _sangKien.Where(x =>
                x.GiangVien.ToLowerInvariant().Contains(query) ||
                x.SoSangKien.ToString().Contains(query)).ToList();
            return;
        }

        if (tab == tabGiaiThuong)
        {
            gridGiaiThuong.DataSource = _giaiThuong.Where(x =>
                x.Khoa.ToLowerInvariant().Contains(query) ||
                x.Nhat.ToString().Contains(query) ||
                x.Nhi.ToString().Contains(query) ||
                x.Ba.ToString().Contains(query) ||
                x.KhuyenKhich.ToString().Contains(query)).ToList();
            return;
        }

        if (tab == tabHoiDong)
        {
            gridHoiDong.DataSource = _hoiDong.Where(x =>
                x.ThanhVien.ToLowerInvariant().Contains(query) ||
                x.SoLan.ToString().Contains(query)).ToList();
            return;
        }

        if (tab == tabHoiGiang)
        {
            gridHoiGiang.DataSource = _hoiGiang.Where(x =>
                x.CapThucHien.ToLowerInvariant().Contains(query) ||
                x.SoBai.ToString().Contains(query)).ToList();
        }
    }
}
