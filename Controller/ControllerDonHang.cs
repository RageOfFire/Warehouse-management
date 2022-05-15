using Model;
using System.Data;
using System.Data.SqlClient;

namespace Controller
{
    public class ControllerDonHang
    {
        // Khai báo db từ Model
        Data db = new Data();
        // Khi người dùng thêm
        public void InsertDH(string masp, int sl, string makho)
        {
            string sql_add = "INSERT INTO DonHang (MaSanPham, SoLuong, MaKho) VALUES('" + masp + "','" + sl + "','" + makho + "')";
            db.ExecuteNonQuery(sql_add);
        }
        // Khi người dùng sửa
        public void UpdateDH(string madonhang, string masp, int sl, string makho)
        {
            string sql_update = "UPDATE DonHang SET MaSanPham = N'" + masp + "',SoLuong = '" + sl + "', MaKho = N'" + makho + "' WHERE MaDonHang = N'" + madonhang + "'";
            db.ExecuteNonQuery(sql_update);
        }
        // Khi người dùng xóa
        public void DeleteDH(string madonhang)
        {
            string sql_delete = "DELETE DonHang WHERE MaDonHang = N'" + madonhang + "'";
            db.ExecuteNonQuery(sql_delete);
        }
        // Khi người dùng tìm kiếm với từ khóa
        public DataTable TimDH(string key)
        {
            string sql = "SELECT * FROM DonHang WHERE MaDonHang LIKE '%" + key + "%'";
            DataTable dt = new DataTable();
            dt = db.GetTable(sql);
            return dt;
        }
        // Hiển thị dữ liệu trên DataGridView
        public DataTable HienThiDH()
        {
            string sql = "SELECT * FROM DonHang";
            DataTable dt = new DataTable();
            dt = db.GetTable(sql);
            return dt;
        }
        public SqlDataReader HienthiSP_CB()
        {
            string sqlsp_cb = "SELECT * FROM SanPham";
            SqlDataReader drSP;
            drSP = db.Get_DR(sqlsp_cb);
            return drSP;
        }
        public SqlDataReader HienthiKH_CB()
        {
            string sqlkh_cb = "SELECT * FROM KhoHang";
            SqlDataReader drKH;
            drKH = db.Get_DR(sqlkh_cb);
            return drKH;
        }
    }
}
