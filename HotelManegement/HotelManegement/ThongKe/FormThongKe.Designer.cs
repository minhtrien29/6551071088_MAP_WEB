namespace HotelManagement.ThongKe
{
    partial class FormThongKe
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
            pnlHeader = new Panel();
            btnXemThongKe = new Button();
            dtpDenNgay = new DateTimePicker();
            lblDenNgay = new Label();
            dtpTuNgay = new DateTimePicker();
            lblTuNgay = new Label();
            pnlCard1 = new Panel();
            lblValCard1 = new Label();
            lblTitleCard1 = new Label();
            pnlCard2 = new Panel();
            lblValCard2 = new Label();
            lblTitleCard2 = new Label();
            pnlCard3 = new Panel();
            lblValCard3 = new Label();
            lblTitleCard3 = new Label();
            pnlHighlights = new Panel();
            pnlHigh3 = new Panel();
            lblHighVal3 = new Label();
            lblHighTitle3 = new Label();
            pnlHigh2 = new Panel();
            lblHighVal2 = new Label();
            lblHighTitle2 = new Label();
            pnlHigh1 = new Panel();
            lblHighVal1 = new Label();
            lblHighTitle1 = new Label();
            pnlChart1 = new Panel();
            lblTitleChart1 = new Label();
            picChart1 = new PictureBox();
            pnlChart2 = new Panel();
            lblTitleChart2 = new Label();
            picChart2 = new PictureBox();
            pnlChart3 = new Panel();
            lblTitleChart3 = new Label();
            picChart3 = new PictureBox();
            pnlHeader.SuspendLayout();
            pnlCard1.SuspendLayout();
            pnlCard2.SuspendLayout();
            pnlCard3.SuspendLayout();
            pnlHighlights.SuspendLayout();
            pnlHigh3.SuspendLayout();
            pnlHigh2.SuspendLayout();
            pnlHigh1.SuspendLayout();
            pnlChart1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picChart1).BeginInit();
            pnlChart2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picChart2).BeginInit();
            pnlChart3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picChart3).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(btnXemThongKe);
            pnlHeader.Controls.Add(dtpDenNgay);
            pnlHeader.Controls.Add(lblDenNgay);
            pnlHeader.Controls.Add(dtpTuNgay);
            pnlHeader.Controls.Add(lblTuNgay);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1160, 50);
            pnlHeader.TabIndex = 0;
            // 
            // btnXemThongKe
            // 
            btnXemThongKe.BackColor = Color.FromArgb(70, 130, 240);
            btnXemThongKe.FlatStyle = FlatStyle.Flat;
            btnXemThongKe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXemThongKe.ForeColor = Color.White;
            btnXemThongKe.Location = new Point(780, 8);
            btnXemThongKe.Name = "btnXemThongKe";
            btnXemThongKe.Size = new Size(130, 34);
            btnXemThongKe.TabIndex = 4;
            btnXemThongKe.Text = "Xem thống kê";
            btnXemThongKe.UseVisualStyleBackColor = false;
            btnXemThongKe.Click += btnXemThongKe_Click;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Font = new Font("Segoe UI", 10F);
            dtpDenNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Location = new Point(530, 11);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(200, 30);
            dtpDenNgay.TabIndex = 3;
            // 
            // lblDenNgay
            // 
            lblDenNgay.AutoSize = true;
            lblDenNgay.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDenNgay.Location = new Point(435, 15);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new Size(89, 23);
            lblDenNgay.TabIndex = 2;
            lblDenNgay.Text = "Đến ngày:";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Font = new Font("Segoe UI", 10F);
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpTuNgay.Location = new Point(190, 11);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(200, 30);
            dtpTuNgay.TabIndex = 1;
            // 
            // lblTuNgay
            // 
            lblTuNgay.AutoSize = true;
            lblTuNgay.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTuNgay.Location = new Point(105, 15);
            lblTuNgay.Name = "lblTuNgay";
            lblTuNgay.Size = new Size(79, 23);
            lblTuNgay.TabIndex = 0;
            lblTuNgay.Text = "Từ ngày:";
            // 
            // pnlCard1
            // 
            pnlCard1.BackColor = Color.FromArgb(240, 110, 95);
            pnlCard1.Controls.Add(lblValCard1);
            pnlCard1.Controls.Add(lblTitleCard1);
            pnlCard1.Location = new Point(20, 60);
            pnlCard1.Name = "pnlCard1";
            pnlCard1.Size = new Size(350, 90);
            pnlCard1.TabIndex = 1;
            // 
            // lblValCard1
            // 
            lblValCard1.Dock = DockStyle.Bottom;
            lblValCard1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblValCard1.ForeColor = Color.White;
            lblValCard1.Location = new Point(0, 40);
            lblValCard1.Name = "lblValCard1";
            lblValCard1.Padding = new Padding(15, 0, 0, 10);
            lblValCard1.Size = new Size(350, 50);
            lblValCard1.TabIndex = 1;
            lblValCard1.Text = "0 VND";
            // 
            // lblTitleCard1
            // 
            lblTitleCard1.Dock = DockStyle.Top;
            lblTitleCard1.Font = new Font("Segoe UI", 10.5F);
            lblTitleCard1.ForeColor = Color.White;
            lblTitleCard1.Location = new Point(0, 0);
            lblTitleCard1.Name = "lblTitleCard1";
            lblTitleCard1.Padding = new Padding(15, 12, 0, 0);
            lblTitleCard1.Size = new Size(350, 40);
            lblTitleCard1.TabIndex = 0;
            lblTitleCard1.Text = "Doanh thu thuê phòng";
            // 
            // pnlCard2
            // 
            pnlCard2.BackColor = Color.FromArgb(50, 180, 190);
            pnlCard2.Controls.Add(lblValCard2);
            pnlCard2.Controls.Add(lblTitleCard2);
            pnlCard2.Location = new Point(390, 60);
            pnlCard2.Name = "pnlCard2";
            pnlCard2.Size = new Size(350, 90);
            pnlCard2.TabIndex = 2;
            // 
            // lblValCard2
            // 
            lblValCard2.Dock = DockStyle.Bottom;
            lblValCard2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblValCard2.ForeColor = Color.White;
            lblValCard2.Location = new Point(0, 40);
            lblValCard2.Name = "lblValCard2";
            lblValCard2.Padding = new Padding(15, 0, 0, 10);
            lblValCard2.Size = new Size(350, 50);
            lblValCard2.TabIndex = 1;
            lblValCard2.Text = "0 VND";
            // 
            // lblTitleCard2
            // 
            lblTitleCard2.Dock = DockStyle.Top;
            lblTitleCard2.Font = new Font("Segoe UI", 10.5F);
            lblTitleCard2.ForeColor = Color.White;
            lblTitleCard2.Location = new Point(0, 0);
            lblTitleCard2.Name = "lblTitleCard2";
            lblTitleCard2.Padding = new Padding(15, 12, 0, 0);
            lblTitleCard2.Size = new Size(350, 40);
            lblTitleCard2.TabIndex = 0;
            lblTitleCard2.Text = "Doanh thu dịch vụ";
            // 
            // pnlCard3
            // 
            pnlCard3.BackColor = Color.FromArgb(120, 185, 90);
            pnlCard3.Controls.Add(lblValCard3);
            pnlCard3.Controls.Add(lblTitleCard3);
            pnlCard3.Location = new Point(760, 60);
            pnlCard3.Name = "pnlCard3";
            pnlCard3.Size = new Size(375, 90);
            pnlCard3.TabIndex = 3;
            // 
            // lblValCard3
            // 
            lblValCard3.Dock = DockStyle.Bottom;
            lblValCard3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblValCard3.ForeColor = Color.White;
            lblValCard3.Location = new Point(0, 40);
            lblValCard3.Name = "lblValCard3";
            lblValCard3.Padding = new Padding(15, 0, 0, 10);
            lblValCard3.Size = new Size(375, 50);
            lblValCard3.TabIndex = 1;
            lblValCard3.Text = "0";
            // 
            // lblTitleCard3
            // 
            lblTitleCard3.Dock = DockStyle.Top;
            lblTitleCard3.Font = new Font("Segoe UI", 10.5F);
            lblTitleCard3.ForeColor = Color.White;
            lblTitleCard3.Location = new Point(0, 0);
            lblTitleCard3.Name = "lblTitleCard3";
            lblTitleCard3.Padding = new Padding(15, 12, 0, 0);
            lblTitleCard3.Size = new Size(375, 40);
            lblTitleCard3.TabIndex = 0;
            lblTitleCard3.Text = "Số phòng đặt";
            // 
            // pnlHighlights
            // 
            pnlHighlights.BackColor = Color.White;
            pnlHighlights.BorderStyle = BorderStyle.FixedSingle;
            pnlHighlights.Controls.Add(pnlHigh3);
            pnlHighlights.Controls.Add(pnlHigh2);
            pnlHighlights.Controls.Add(pnlHigh1);
            pnlHighlights.Location = new Point(20, 165);
            pnlHighlights.Name = "pnlHighlights";
            pnlHighlights.Size = new Size(420, 240);
            pnlHighlights.TabIndex = 4;
            // 
            // pnlHigh3
            // 
            pnlHigh3.BackColor = Color.FromArgb(248, 248, 252);
            pnlHigh3.Controls.Add(lblHighVal3);
            pnlHigh3.Controls.Add(lblHighTitle3);
            pnlHigh3.Location = new Point(15, 160);
            pnlHigh3.Name = "pnlHigh3";
            pnlHigh3.Size = new Size(388, 65);
            pnlHigh3.TabIndex = 2;
            // 
            // lblHighVal3
            // 
            lblHighVal3.AutoSize = true;
            lblHighVal3.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblHighVal3.ForeColor = Color.FromArgb(210, 60, 60);
            lblHighVal3.Location = new Point(12, 33);
            lblHighVal3.Name = "lblHighVal3";
            lblHighVal3.Size = new Size(67, 25);
            lblHighVal3.TabIndex = 1;
            lblHighVal3.Text = "Không có";
            // 
            // lblHighTitle3
            // 
            lblHighTitle3.AutoSize = true;
            lblHighTitle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            lblHighTitle3.ForeColor = Color.Gray;
            lblHighTitle3.Location = new Point(12, 8);
            lblHighTitle3.Name = "lblHighTitle3";
            lblHighTitle3.Size = new Size(183, 20);
            lblHighTitle3.TabIndex = 0;
            lblHighTitle3.Text = "Dịch vụ doanh thu cao nhất";
            // 
            // pnlHigh2
            // 
            pnlHigh2.BackColor = Color.FromArgb(248, 248, 252);
            pnlHigh2.Controls.Add(lblHighVal2);
            pnlHigh2.Controls.Add(lblHighTitle2);
            pnlHigh2.Location = new Point(15, 85);
            pnlHigh2.Name = "pnlHigh2";
            pnlHigh2.Size = new Size(388, 65);
            pnlHigh2.TabIndex = 1;
            // 
            // lblHighVal2
            // 
            lblHighVal2.AutoSize = true;
            lblHighVal2.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblHighVal2.ForeColor = Color.FromArgb(70, 70, 180);
            lblHighVal2.Location = new Point(12, 33);
            lblHighVal2.Name = "lblHighVal2";
            lblHighVal2.Size = new Size(67, 25);
            lblHighVal2.TabIndex = 1;
            lblHighVal2.Text = "Không có";
            // 
            // lblHighTitle2
            // 
            lblHighTitle2.AutoSize = true;
            lblHighTitle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            lblHighTitle2.ForeColor = Color.Gray;
            lblHighTitle2.Location = new Point(12, 8);
            lblHighTitle2.Name = "lblHighTitle2";
            lblHighTitle2.Size = new Size(198, 20);
            lblHighTitle2.TabIndex = 0;
            lblHighTitle2.Text = "Loại phòng được đặt nhiều nhất";
            // 
            // pnlHigh1
            // 
            pnlHigh1.BackColor = Color.FromArgb(248, 248, 252);
            pnlHigh1.Controls.Add(lblHighVal1);
            pnlHigh1.Controls.Add(lblHighTitle1);
            pnlHigh1.Location = new Point(15, 10);
            pnlHigh1.Name = "pnlHigh1";
            pnlHigh1.Size = new Size(388, 65);
            pnlHigh1.TabIndex = 0;
            // 
            // lblHighVal1
            // 
            lblHighVal1.AutoSize = true;
            lblHighVal1.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblHighVal1.ForeColor = Color.FromArgb(40, 120, 200);
            lblHighVal1.Location = new Point(12, 33);
            lblHighVal1.Name = "lblHighVal1";
            lblHighVal1.Size = new Size(67, 25);
            lblHighVal1.TabIndex = 1;
            lblHighVal1.Text = "Không có";
            // 
            // lblHighTitle1
            // 
            lblHighTitle1.AutoSize = true;
            lblHighTitle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            lblHighTitle1.ForeColor = Color.Gray;
            lblHighTitle1.Location = new Point(12, 8);
            lblHighTitle1.Name = "lblHighTitle1";
            lblHighTitle1.Size = new Size(204, 20);
            lblHighTitle1.TabIndex = 0;
            lblHighTitle1.Text = "Loại phòng doanh thu cao nhất";
            // 
            // pnlChart1
            // 
            pnlChart1.BackColor = Color.White;
            pnlChart1.BorderStyle = BorderStyle.FixedSingle;
            pnlChart1.Controls.Add(lblTitleChart1);
            pnlChart1.Controls.Add(picChart1);
            pnlChart1.Location = new Point(460, 165);
            pnlChart1.Name = "pnlChart1";
            pnlChart1.Size = new Size(675, 240);
            pnlChart1.TabIndex = 5;
            // 
            // lblTitleChart1
            // 
            lblTitleChart1.AutoSize = true;
            lblTitleChart1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitleChart1.ForeColor = Color.FromArgb(70, 70, 70);
            lblTitleChart1.Location = new Point(15, 10);
            lblTitleChart1.Name = "lblTitleChart1";
            lblTitleChart1.Size = new Size(213, 25);
            lblTitleChart1.TabIndex = 0;
            lblTitleChart1.Text = "Doanh thu thuê phòng";
            // 
            // picChart1
            // 
            picChart1.Dock = DockStyle.Bottom;
            picChart1.Location = new Point(0, 40);
            picChart1.Name = "picChart1";
            picChart1.Size = new Size(673, 198);
            picChart1.TabIndex = 1;
            picChart1.TabStop = false;
            // 
            // pnlChart2
            // 
            pnlChart2.BackColor = Color.White;
            pnlChart2.BorderStyle = BorderStyle.FixedSingle;
            pnlChart2.Controls.Add(lblTitleChart2);
            pnlChart2.Controls.Add(picChart2);
            pnlChart2.Location = new Point(20, 420);
            pnlChart2.Name = "pnlChart2";
            pnlChart2.Size = new Size(420, 260);
            pnlChart2.TabIndex = 6;
            // 
            // lblTitleChart2
            // 
            lblTitleChart2.AutoSize = true;
            lblTitleChart2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitleChart2.ForeColor = Color.FromArgb(70, 70, 70);
            lblTitleChart2.Location = new Point(15, 10);
            lblTitleChart2.Name = "lblTitleChart2";
            lblTitleChart2.Size = new Size(230, 25);
            lblTitleChart2.TabIndex = 0;
            lblTitleChart2.Text = "Các dịch vụ được sử dụng";
            // 
            // picChart2
            // 
            picChart2.Dock = DockStyle.Bottom;
            picChart2.Location = new Point(0, 40);
            picChart2.Name = "picChart2";
            picChart2.Size = new Size(418, 218);
            picChart2.TabIndex = 1;
            picChart2.TabStop = false;
            // 
            // pnlChart3
            // 
            pnlChart3.BackColor = Color.White;
            pnlChart3.BorderStyle = BorderStyle.FixedSingle;
            pnlChart3.Controls.Add(lblTitleChart3);
            pnlChart3.Controls.Add(picChart3);
            pnlChart3.Location = new Point(460, 420);
            pnlChart3.Name = "pnlChart3";
            pnlChart3.Size = new Size(675, 260);
            pnlChart3.TabIndex = 7;
            // 
            // lblTitleChart3
            // 
            lblTitleChart3.AutoSize = true;
            lblTitleChart3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitleChart3.ForeColor = Color.FromArgb(70, 70, 70);
            lblTitleChart3.Location = new Point(15, 10);
            lblTitleChart3.Name = "lblTitleChart3";
            lblTitleChart3.Size = new Size(183, 25);
            lblTitleChart3.TabIndex = 0;
            lblTitleChart3.Text = "Số phòng được đặt";
            // 
            // picChart3
            // 
            picChart3.Dock = DockStyle.Bottom;
            picChart3.Location = new Point(0, 40);
            picChart3.Name = "picChart3";
            picChart3.Size = new Size(673, 218);
            picChart3.TabIndex = 1;
            picChart3.TabStop = false;
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(1160, 700);
            Controls.Add(pnlChart3);
            Controls.Add(pnlChart2);
            Controls.Add(pnlChart1);
            Controls.Add(pnlHighlights);
            Controls.Add(pnlCard3);
            Controls.Add(pnlCard2);
            Controls.Add(pnlCard1);
            Controls.Add(pnlHeader);
            Name = "FormThongKe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Báo cáo thống kê tình hình kinh doanh";
            Load += FormThongKe_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlCard1.ResumeLayout(false);
            pnlCard2.ResumeLayout(false);
            pnlCard3.ResumeLayout(false);
            pnlHighlights.ResumeLayout(false);
            pnlHigh3.ResumeLayout(false);
            pnlHigh3.PerformLayout();
            pnlHigh2.ResumeLayout(false);
            pnlHigh2.PerformLayout();
            pnlHigh1.ResumeLayout(false);
            pnlHigh1.PerformLayout();
            pnlChart1.ResumeLayout(false);
            pnlChart1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picChart1).EndInit();
            pnlChart2.ResumeLayout(false);
            pnlChart2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picChart2).EndInit();
            pnlChart3.ResumeLayout(false);
            pnlChart3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picChart3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTuNgay;
        private DateTimePicker dtpTuNgay;
        private Label lblDenNgay;
        private DateTimePicker dtpDenNgay;
        private Button btnXemThongKe;
        private Panel pnlCard1;
        private Label lblTitleCard1;
        private Label lblValCard1;
        private Panel pnlCard2;
        private Label lblTitleCard2;
        private Label lblValCard2;
        private Panel pnlCard3;
        private Label lblTitleCard3;
        private Label lblValCard3;
        private Panel pnlHighlights;
        private Panel pnlHigh1;
        private Label lblHighTitle1;
        private Label lblHighVal1;
        private Panel pnlHigh2;
        private Label lblHighTitle2;
        private Label lblHighVal2;
        private Panel pnlHigh3;
        private Label lblHighTitle3;
        private Label lblHighVal3;
        private Panel pnlChart1;
        private Label lblTitleChart1;
        private PictureBox picChart1;
        private Panel pnlChart2;
        private Label lblTitleChart2;
        private PictureBox picChart2;
        private Panel pnlChart3;
        private Label lblTitleChart3;
        private PictureBox picChart3;
    }
}
