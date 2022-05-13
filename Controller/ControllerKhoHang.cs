using System.Data;
using Model;

namespace Controller
{
    public class ControllerKhoHang
    {
        Data db = new Data();
        public void InsertKH(string tenkho, string diachi, int slton)
        {
            string sql_add = "INSERT INTO KhoHang (TenKho, DiaChi, SLTon) VALUES('" + tenkho + "',N'" + diachi + "',N'" + slton + "')";
            db.ExecuteNonQuery(sql_add);
        }
        public void UpdateKH(string makho, string tenkho, string diachi, int slton)
        {
            string sql_update = "UPDATE KhoHang SET TenKho = N'" + tenkho + "',DiaChi = N'" + diachi + "', SLTon = '" + slton + "' WHERE MaKho = N'" + makho + "'";
            db.ExecuteNonQuery(sql_update);
        }
        public void DeleteKH(string makho)
        {
            string sql_delete = "DELETE KhoHang WHERE MaKho = N'" + makho + "'";
            db.ExecuteNonQuery(sql_delete);
        }
        public DataTable TimKH(string key)
        {
            string sql = "SELECT * FROM KhoHang WHERE MaKho LIKE '%" + key + "%' OR TenKho LIKE '%" + key + "%'";
            DataTable dt = new DataTable();
            dt = db.GetTable(sql);
            return dt;
        }
        public DataTable HienThiKH()
        {
            string sql = "SELECT * FROM KhoHang";
            DataTable dt = new DataTable();
            dt = db.GetTable(sql);
            return dt;
        }
    }
}
