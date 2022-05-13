using System.Data;
using Model;

namespace Controller
{
    public class ControllerLogin
    {
        Data db = new Data();
        // Đăng nhập
        public DataTable Login(string username, string password)
        {
            string sql_login = "SELECT * FROM QuanLy WHERE TenQuanLy = N'" + username + "' AND MatKhau = N'" + password + "'";
            DataTable dt = new DataTable();
            dt = db.GetTable(sql_login);
            return dt;
        }
    }
}
