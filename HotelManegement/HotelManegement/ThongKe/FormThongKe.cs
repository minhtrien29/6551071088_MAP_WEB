using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.ThongKe
{
    public partial class FormThongKe : Form
    {
        private readonly CultureInfo viVN = new CultureInfo("vi-VN");

        // Chart data cache
        private List<(string Label, decimal Value)> dataDoanhThuLoaiPhong = new();
        private List<(string Label, int Value)> dataDichVuSuDung = new();
        private List<(string Label, int Value)> dataSoLuongDatLoaiPhong = new();

        public FormThongKe()
        {
            InitializeComponent();

            picChart1.Paint += PicChart1_Paint;
            picChart2.Paint += PicChart2_Paint;
            picChart3.Paint += PicChart3_Paint;
        }

        private void FormThongKe_Load(object? sender, EventArgs e)
        {
            // Default date range: start of current month to today
            DateTime now = DateTime.Today;
            dtpTuNgay.Value = new DateTime(now.Year, now.Month, 1);
            dtpDenNgay.Value = now;

            CapNhatThongKe();
        }

        private void btnXemThongKe_Click(object? sender, EventArgs e)
        {
            CapNhatThongKe();
        }

        private string DinhDangTien(decimal soTien)
        {
            return soTien.ToString("N0", viVN) + " VND";
        }

        public void CapNhatThongKe()
        {
            try
            {
                DateTime tuNgay = dtpTuNgay.Value.Date;
                DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1);

                if (tuNgay > denNgay)
                {
                    MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var db = new HotelManagementContext();

                var hoaDons = db.HoaDons
                    .AsNoTracking()
                    .Where(h => h.DaXoa != true && h.NgHd >= tuNgay && h.NgHd < denNgay)
                    .Select(h => new
                    {
                        h.MaHd,
                        h.NgHd,
                        TienPhong = h.MaCtdpNavigation.ThanhTien ?? 0,
                        TenLoaiPhong = h.MaCtdpNavigation.MaPhNavigation.MaLphNavigation.TenLph,
                        MaPhong = h.MaCtdpNavigation.MaPh,
                        DichVus = h.MaCtdpNavigation.Ctdvs
                            .Where(c => c.DaXoa != true)
                            .Select(c => new
                            {
                                c.MaDvNavigation.TenDv,
                                c.Sl,
                                DonGia = c.MaDvNavigation.DonGia,
                                ThanhTien = c.MaDvNavigation.DonGia * c.Sl
                            })
                            .ToList()
                    })
                    .ToList();

                // 1. Summary Metrics
                decimal tongDoanhThuPhong = hoaDons.Sum(h => h.TienPhong);
                decimal tongDoanhThuDichVu = hoaDons.Sum(h => h.DichVus.Sum(d => d.ThanhTien));
                int soPhongDat = hoaDons.Select(h => h.MaPhong).Distinct().Count();

                lblValCard1.Text = DinhDangTien(tongDoanhThuPhong);
                lblValCard2.Text = DinhDangTien(tongDoanhThuDichVu);
                lblValCard3.Text = soPhongDat.ToString();

                // 2. Highlights
                // Loại phòng doanh thu cao nhất
                var nhomDoanhThuLoaiPhong = hoaDons
                    .GroupBy(h => h.TenLoaiPhong ?? "Khác")
                    .Select(g => new { TenLph = g.Key, TongTien = g.Sum(x => x.TienPhong) })
                    .OrderByDescending(x => x.TongTien)
                    .ToList();

                if (nhomDoanhThuLoaiPhong.Count > 0 && nhomDoanhThuLoaiPhong[0].TongTien > 0)
                {
                    lblHighVal1.Text = $"{nhomDoanhThuLoaiPhong[0].TenLph} ({DinhDangTien(nhomDoanhThuLoaiPhong[0].TongTien)})";
                }
                else
                {
                    lblHighVal1.Text = "Không có";
                }

                // Loại phòng được đặt nhiều nhất
                var nhomSoLuongLoaiPhong = hoaDons
                    .GroupBy(h => h.TenLoaiPhong ?? "Khác")
                    .Select(g => new { TenLph = g.Key, SoLuong = g.Count() })
                    .OrderByDescending(x => x.SoLuong)
                    .ToList();

                if (nhomSoLuongLoaiPhong.Count > 0 && nhomSoLuongLoaiPhong[0].SoLuong > 0)
                {
                    lblHighVal2.Text = $"{nhomSoLuongLoaiPhong[0].TenLph} ({nhomSoLuongLoaiPhong[0].SoLuong} lượt)";
                }
                else
                {
                    lblHighVal2.Text = "Không có";
                }

                // Dịch vụ doanh thu cao nhất
                var nhomDichVu = hoaDons
                    .SelectMany(h => h.DichVus)
                    .GroupBy(d => d.TenDv ?? "Khác")
                    .Select(g => new
                    {
                        TenDv = g.Key,
                        TongTien = g.Sum(x => x.ThanhTien),
                        TongSl = g.Sum(x => x.Sl)
                    })
                    .OrderByDescending(x => x.TongTien)
                    .ToList();

                if (nhomDichVu.Count > 0 && nhomDichVu[0].TongTien > 0)
                {
                    lblHighVal3.Text = $"{nhomDichVu[0].TenDv} ({DinhDangTien(nhomDichVu[0].TongTien)})";
                }
                else
                {
                    lblHighVal3.Text = "Không có";
                }

                // 3. Cache Data for Charts
                dataDoanhThuLoaiPhong = nhomDoanhThuLoaiPhong
                    .Select(x => (x.TenLph, x.TongTien))
                    .ToList();

                dataDichVuSuDung = nhomDichVu
                    .Select(x => (x.TenDv, x.TongSl))
                    .ToList();

                dataSoLuongDatLoaiPhong = nhomSoLuongLoaiPhong
                    .Select(x => (x.TenLph, x.SoLuong))
                    .ToList();

                // Redraw charts
                picChart1.Invalidate();
                picChart2.Invalidate();
                picChart3.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================= GDI+ CHART RENDERING =================

        private void PicChart1_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int w = picChart1.Width;
            int h = picChart1.Height;

            if (dataDoanhThuLoaiPhong.Count == 0)
            {
                using Font font = new Font("Segoe UI", 10F, FontStyle.Italic);
                g.DrawString("Không có dữ liệu trong khoảng thời gian này", font, Brushes.Gray, new PointF(w / 4f, h / 2f - 10));
                return;
            }

            decimal maxVal = dataDoanhThuLoaiPhong.Max(d => d.Value);
            if (maxVal == 0) maxVal = 1;

            int leftPadding = 80;
            int rightPadding = 30;
            int topPadding = 20;
            int bottomPadding = 40;

            int chartWidth = w - leftPadding - rightPadding;
            int chartHeight = h - topPadding - bottomPadding;

            // Draw Gridlines and Y-axis labels
            using Pen gridPen = new Pen(Color.FromArgb(235, 235, 235), 1);
            using Font labelFont = new Font("Segoe UI", 8F);
            int stepCount = 4;
            for (int i = 0; i <= stepCount; i++)
            {
                float y = topPadding + chartHeight - (i * chartHeight / (float)stepCount);
                g.DrawLine(gridPen, leftPadding, y, leftPadding + chartWidth, y);

                decimal val = (maxVal / stepCount) * i;
                string valStr = val.ToString("N0", viVN);
                g.DrawString(valStr, labelFont, Brushes.Gray, new PointF(10, y - 6));
            }

            // Draw Bars
            int count = dataDoanhThuLoaiPhong.Count;
            float barSpace = chartWidth / (float)count;
            float barWidth = Math.Min(barSpace * 0.5f, 60);

            Color[] colors = { Color.FromArgb(70, 140, 240), Color.FromArgb(240, 110, 95), Color.FromArgb(60, 190, 150), Color.FromArgb(250, 180, 50) };

            for (int i = 0; i < count; i++)
            {
                var item = dataDoanhThuLoaiPhong[i];
                float barHeight = (float)(item.Value / maxVal) * chartHeight;
                float x = leftPadding + (i * barSpace) + (barSpace - barWidth) / 2;
                float y = topPadding + chartHeight - barHeight;

                Color c = colors[i % colors.Length];
                using (Brush brush = new SolidBrush(c))
                {
                    g.FillRectangle(brush, x, y, barWidth, barHeight);
                }

                // X label
                using Font xFont = new Font("Segoe UI", 8.5F, FontStyle.Regular);
                SizeF sf = g.MeasureString(item.Label, xFont);
                g.DrawString(item.Label, xFont, Brushes.DarkSlateGray, x + (barWidth - sf.Width) / 2, topPadding + chartHeight + 6);
            }
        }

        private void PicChart2_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int w = picChart2.Width;
            int h = picChart2.Height;

            if (dataDichVuSuDung.Count == 0)
            {
                using Font font = new Font("Segoe UI", 10F, FontStyle.Italic);
                g.DrawString("Không có dịch vụ nào", font, Brushes.Gray, new PointF(w / 4f, h / 2f - 10));
                return;
            }

            int total = dataDichVuSuDung.Sum(d => d.Value);
            if (total == 0) total = 1;

            Color[] colors = {
                Color.FromArgb(70, 140, 240),
                Color.FromArgb(250, 140, 60),
                Color.FromArgb(60, 190, 150),
                Color.FromArgb(230, 80, 120),
                Color.FromArgb(150, 100, 220),
                Color.FromArgb(240, 200, 60)
            };

            // Pie circle bounding box
            int diameter = Math.Min(w / 2 - 20, h - 30);
            Rectangle pieRect = new Rectangle(15, (h - diameter) / 2, diameter, diameter);

            float startAngle = 0;
            for (int i = 0; i < dataDichVuSuDung.Count; i++)
            {
                float sweepAngle = ((float)dataDichVuSuDung[i].Value / total) * 360f;
                using (Brush b = new SolidBrush(colors[i % colors.Length]))
                {
                    g.FillPie(b, pieRect, startAngle, sweepAngle);
                }
                startAngle += sweepAngle;
            }

            // Legend
            int legendX = pieRect.Right + 20;
            int legendY = 20;
            using Font legFont = new Font("Segoe UI", 8.5F);

            for (int i = 0; i < dataDichVuSuDung.Count && i < 7; i++)
            {
                Color c = colors[i % colors.Length];
                using (Brush b = new SolidBrush(c))
                {
                    g.FillRectangle(b, legendX, legendY + i * 22, 12, 12);
                }

                string text = $"{dataDichVuSuDung[i].Label} ({dataDichVuSuDung[i].Value})";
                using (Brush textBrush = new SolidBrush(Color.FromArgb(50, 50, 50)))
                {
                    g.DrawString(text, legFont, textBrush, legendX + 18, legendY + i * 22 - 2);
                }
            }
        }

        private void PicChart3_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int w = picChart3.Width;
            int h = picChart3.Height;

            if (dataSoLuongDatLoaiPhong.Count == 0)
            {
                using Font font = new Font("Segoe UI", 10F, FontStyle.Italic);
                g.DrawString("Không có dữ liệu trong khoảng thời gian này", font, Brushes.Gray, new PointF(w / 4f, h / 2f - 10));
                return;
            }

            int maxVal = dataSoLuongDatLoaiPhong.Max(d => d.Value);
            if (maxVal == 0) maxVal = 1;

            int leftPadding = 50;
            int rightPadding = 30;
            int topPadding = 20;
            int bottomPadding = 40;

            int chartWidth = w - leftPadding - rightPadding;
            int chartHeight = h - topPadding - bottomPadding;

            // Draw Gridlines and Y-axis labels
            using Pen gridPen = new Pen(Color.FromArgb(235, 235, 235), 1);
            using Font labelFont = new Font("Segoe UI", 8F);
            int stepCount = Math.Min(maxVal, 4);
            if (stepCount == 0) stepCount = 1;

            for (int i = 0; i <= stepCount; i++)
            {
                float y = topPadding + chartHeight - (i * chartHeight / (float)stepCount);
                g.DrawLine(gridPen, leftPadding, y, leftPadding + chartWidth, y);

                float val = ((float)maxVal / stepCount) * i;
                g.DrawString(val.ToString("0.#"), labelFont, Brushes.Gray, new PointF(15, y - 6));
            }

            // Draw Bars
            int count = dataSoLuongDatLoaiPhong.Count;
            float barSpace = chartWidth / (float)count;
            float barWidth = Math.Min(barSpace * 0.5f, 60);

            Color[] colors = { Color.FromArgb(60, 160, 240), Color.FromArgb(240, 140, 80), Color.FromArgb(100, 200, 140) };

            for (int i = 0; i < count; i++)
            {
                var item = dataSoLuongDatLoaiPhong[i];
                float barHeight = ((float)item.Value / maxVal) * chartHeight;
                float x = leftPadding + (i * barSpace) + (barSpace - barWidth) / 2;
                float y = topPadding + chartHeight - barHeight;

                Color c = colors[i % colors.Length];
                using (Brush brush = new SolidBrush(c))
                {
                    g.FillRectangle(brush, x, y, barWidth, barHeight);
                }

                // Bar count label above
                using Font countFont = new Font("Segoe UI", 8.5F, FontStyle.Bold);
                SizeF cSize = g.MeasureString(item.Value.ToString(), countFont);
                g.DrawString(item.Value.ToString(), countFont, Brushes.DarkSlateGray, x + (barWidth - cSize.Width) / 2, y - 18);

                // X label
                using Font xFont = new Font("Segoe UI", 8.5F, FontStyle.Regular);
                SizeF sf = g.MeasureString(item.Label, xFont);
                g.DrawString(item.Label, xFont, Brushes.DarkSlateGray, x + (barWidth - sf.Width) / 2, topPadding + chartHeight + 6);
            }
        }
    }
}
