namespace QuanLyDanhSachHinh
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            toolStrip1 = new ToolStrip();
            btnNapDanhSach = new ToolStripButton();
            btnXoa = new ToolStripButton();
            lbxHinh = new ListBox();
            bsHinh = new BindingSource(components);
            gridHinh = new DataGridView();
            colMaSo = new DataGridViewTextBoxColumn();
            colVatLieu = new DataGridViewTextBoxColumn();
            colThongTin = new DataGridViewTextBoxColumn();
            propertyGrid1 = new PropertyGrid();
            btnThem = new ToolStripDropDownButton();
            thêm1HìnhTrònToolStripMenuItem = new ToolStripMenuItem();
            thêm1HìnhChữNhậtToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsHinh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridHinh).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNapDanhSach, btnXoa, btnThem });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1066, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNapDanhSach
            // 
            btnNapDanhSach.Image = (Image)resources.GetObject("btnNapDanhSach.Image");
            btnNapDanhSach.ImageTransparentColor = Color.Magenta;
            btnNapDanhSach.Name = "btnNapDanhSach";
            btnNapDanhSach.Size = new Size(131, 24);
            btnNapDanhSach.Text = "Nạp danh sách";
            btnNapDanhSach.Click += btnNapDanhSach_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageTransparentColor = Color.Magenta;
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(59, 24);
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // lbxHinh
            // 
            lbxHinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbxHinh.FormattingEnabled = true;
            lbxHinh.Location = new Point(12, 28);
            lbxHinh.Name = "lbxHinh";
            lbxHinh.Size = new Size(396, 224);
            lbxHinh.TabIndex = 1;
            // 
            // bsHinh
            // 
            bsHinh.CurrentChanged += change_selected;
            // 
            // gridHinh
            // 
            gridHinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridHinh.Columns.AddRange(new DataGridViewColumn[] { colMaSo, colVatLieu, colThongTin });
            gridHinh.Location = new Point(414, 30);
            gridHinh.Name = "gridHinh";
            gridHinh.RowHeadersWidth = 51;
            gridHinh.Size = new Size(561, 222);
            gridHinh.TabIndex = 2;
            // 
            // colMaSo
            // 
            colMaSo.DataPropertyName = "ID";
            colMaSo.HeaderText = "Mã số";
            colMaSo.MinimumWidth = 6;
            colMaSo.Name = "colMaSo";
            colMaSo.Width = 80;
            // 
            // colVatLieu
            // 
            colVatLieu.DataPropertyName = "VatLieu";
            colVatLieu.HeaderText = "Vật liệu";
            colVatLieu.MinimumWidth = 6;
            colVatLieu.Name = "colVatLieu";
            colVatLieu.Width = 120;
            // 
            // colThongTin
            // 
            colThongTin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colThongTin.DataPropertyName = "ThongTin";
            colThongTin.HeaderText = "Thông tin";
            colThongTin.MinimumWidth = 6;
            colThongTin.Name = "colThongTin";
            // 
            // propertyGrid1
            // 
            propertyGrid1.Location = new Point(12, 258);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.Size = new Size(396, 162);
            propertyGrid1.TabIndex = 3;
            // 
            // btnThem
            // 
            btnThem.DropDownItems.AddRange(new ToolStripItem[] { thêm1HìnhTrònToolStripMenuItem, thêm1HìnhChữNhậtToolStripMenuItem });
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageTransparentColor = Color.Magenta;
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(80, 24);
            btnThem.Text = "Thêm";
            // 
            // thêm1HìnhTrònToolStripMenuItem
            // 
            thêm1HìnhTrònToolStripMenuItem.Name = "thêm1HìnhTrònToolStripMenuItem";
            thêm1HìnhTrònToolStripMenuItem.Size = new Size(234, 26);
            thêm1HìnhTrònToolStripMenuItem.Text = "Thêm 1 hình tròn";
            // 
            // thêm1HìnhChữNhậtToolStripMenuItem
            // 
            thêm1HìnhChữNhậtToolStripMenuItem.Name = "thêm1HìnhChữNhậtToolStripMenuItem";
            thêm1HìnhChữNhậtToolStripMenuItem.Size = new Size(234, 26);
            thêm1HìnhChữNhậtToolStripMenuItem.Text = "Thêm 1 hình chữ nhật";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 450);
            Controls.Add(propertyGrid1);
            Controls.Add(gridHinh);
            Controls.Add(lbxHinh);
            Controls.Add(toolStrip1);
            Name = "FormMain";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsHinh).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridHinh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnNapDanhSach;
        private ToolStripButton btnXoa;
        private ListBox lbxHinh;
        private BindingSource bsHinh;
        private DataGridView gridHinh;
        private DataGridViewTextBoxColumn colMaSo;
        private DataGridViewTextBoxColumn colVatLieu;
        private DataGridViewTextBoxColumn colThongTin;
        private PropertyGrid propertyGrid1;
        private ToolStripDropDownButton btnThem;
        private ToolStripMenuItem thêm1HìnhTrònToolStripMenuItem;
        private ToolStripMenuItem thêm1HìnhChữNhậtToolStripMenuItem;
    }
}
