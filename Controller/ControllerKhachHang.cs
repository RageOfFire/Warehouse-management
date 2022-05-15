using Model;
using System.Data;

namespace Controller
{
    public class ControllerKhachHang
    {
        // Khai báo db từ Model
        Data db = new Data();
        // Khi người dùng thêm
        public void InsertKHA(string tencty, string diachi, int sdt)
        {
            string sql_add = "INSERT INTO KhachHang (TenCongTy, DiaChi, SDT) VALUES(N'" + tencty + "',N'" + diachi + "','" + sdt + "')";
            db.ExecuteNonQuery(sql_add);
        }
        // Khi người dùng sửa
        public void UpdateKHA(string macty, string tencty, string diachi, int sdt)
        {
            string sql_update = "UPDATE KhachHang SET TenCongTy = N'" + tencty + "',DiaChi = N'" + diachi + "', sdt = '" + sdt + "' WHERE MaCongTy = N'" + macty + "'";
            db.ExecuteNonQuery(sql_update);
        }
        // Khi người dùng xóa
        public void DeleteKHA(string macty)
        {
            string sql_delete = "DELETE KhachHang WHERE MaCongTy = N'" + macty + "'";
            db.ExecuteNonQuery(sql_delete);
        }
        // Khi người dùng tìm kiếm với từ khóa
        public DataTable TimKHA(string key)
        {
            string sql = "SELECT * FROM KhachHang WHERE MaCongTy LIKE '%" + key + "%' OR TenCongTy LIKE '%" + key + "%'";
            DataTable dt = new DataTable();
            dt = db.GetTable(sql);
            return dt;
        }
        // Hiển thị dữ liệu trên DataGridView
        public DataTable HienThiKHA()
        {
            string sql = "SELECT * FROM KhachHang";
            DataTable dt = new DataTable();
            dt = db.GetTable(sql);
            return dt;
        }
    }
}
