using System.Data;
using System.Data.SqlClient;
using Model;

namespace Controller
{
    public class ControllerSanPham
    {
        // Khai báo db từ Model
        Data db = new Data();
        // Khi người dùng thêm
        public void InsertSP(string tensp, string makho, string donvitinh, int gia)
        {
            string sql_add = "INSERT INTO SanPham (TenSanPham, MaKho, DonViTinh, Gia) VALUES(N'" + tensp + "',N'" + makho + "',N'" + donvitinh + "','"+ gia +"')";
            db.ExecuteNonQuery(sql_add);
        }
        // Khi người dùng sửa
        public void UpdateSP(string masp, string tensp, string makho, string donvitinh, int gia)
        {
            string sql_update = "UPDATE SanPham SET TenSanPham = N'" + tensp + "',MaKho = N'" + makho + "', DonViTinh = N'" + donvitinh + "', Gia = '"+ gia +"' WHERE MaSanPham = N'" + masp + "'";
            db.ExecuteNonQuery(sql_update);
        }
        // Khi người dùng xóa
        public void DeleteSP(string masp)
        {
            string sql_delete = "DELETE SanPham WHERE MaSanPham = N'" + masp + "'";
            db.ExecuteNonQuery(sql_delete);
        }
        // Khi người dùng tìm kiếm với từ khóa
        public DataTable TimSP(string key)
        {
            string sql = "SELECT * FROM SanPham WHERE MaSanPham LIKE '%" + key + "%' OR TenSanPham LIKE '%" + key + "%'";
            DataTable dt = new DataTable();
            dt = db.GetTable(sql);
            return dt;
        }
        // Hiển thị dữ liệu trên DataGridView
        public DataTable HienThiSP()
        {
            string sql = "SELECT * FROM SanPham";
            DataTable dt = new DataTable();
            dt = db.GetTable(sql);
            return dt;
        }
        public SqlDataReader HienthiKH_CB()
        {
            string sql_cb = "SELECT * FROM KhoHang";
            SqlDataReader dr;
            dr = db.Get_DR(sql_cb);
            return dr;
        }
    }
}
