using QuanLyDanhSachHinh.DAO;
using QuanLyDanhSachHinh.Models;

namespace QuanLyDanhSachHinh
{
    public partial class FormMain : Form
    {
        public HinhDAO hinhDAO;
        public FormMain()
        {
            InitializeComponent();
        }

        public void Injection(HinhDAO x)
        {
            this.hinhDAO = x;
        }
        private void btnNapDanhSach_Click(object sender, EventArgs e)
        {
            // 0. Khởi tạo đối tượng HinhDAO
            var daoHinh = new HinhDAO("D:\\Desktop\\QuanLyDanhSach\\QuanLyDanhSachHinh\\Models\\Data.txt");

            // 1. Dùng HinhDAO để đọc danh sách đối tượng hình học
            var lst = daoHinh.DocHinhTuFile();

            // 2. Cho bindingsource trỏ đến danh sách đối tượng hình học
            bsHinh.DataSource = lst;

            // 3. Cho lbxHinh trỏ đến bindingsource
            lbxHinh.DisplayMember = "ThongTin";
            lbxHinh.DataSource = bsHinh;

            // 4. Cho gridHinh trỏ đến bindingsource
            gridHinh.AutoGenerateColumns = false;
            gridHinh.DataSource = bsHinh;

            //5. Hiển thị thông tin chi tiết đối tượng đang được chọn
            var selected = bsHinh.Current;
            propertyGrid1.SelectedObject = selected;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bsHinh.Current != null)
            {
                //a. Xóa phần tử hiện tại của bsHinh
                bsHinh.RemoveCurrent();
                //b. Lấy danh sách đối tượng mà bsHinh đang quản lý
                //Chú ý, phải thêm using QuanLyDanhSach.Models ở đầu file này
                var lst = bsHinh.DataSource as List<Hinh>;

                //c. Thực hiện lưu lst xuống file
                var daoHinh = new HinhDAO("D:\\Desktop\\QuanLyDanhSach\\QuanLyDanhSachHinh\\Models\\Data.txt");
                daoHinh.LuuHinhVaoFile(lst);
            }
        }

        private void change_selected(object sender, EventArgs e)
        {
            var a = bsHinh.Current;
            propertyGrid1.SelectedObject = a;
        }
    }
}
