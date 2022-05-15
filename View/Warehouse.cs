using System;
using System.Data;
using System.Windows.Forms;
using Controller;

namespace View
{
    public partial class Warehouse : Form
    {
        // Khai 1 Datatable mới cho DataGridView
        DataTable dt = new DataTable();
        // Khai báo biến cho Controller của kho hàng
        ControllerKhoHang kh = new ControllerKhoHang();
        // Biến tạo để kiếm tra số
        int value;
        public Warehouse()
        {
            InitializeComponent();
        }

        // Khi người dùng ấn nút thêm
        private void AddButtonKH_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(SLTonBoxKH.Text, out value))
            {
                EasyMessageBox("Số lượng tồn không phải là số", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SLTonBoxKH.Focus();
            }
            else
            {
                try
                {
                    kh.InsertKH(this.TenKhoBoxKH.Text, this.DiaChiBoxKH.Text, Convert.ToInt32(this.SLTonBoxKH.Text));
                    EasyMessageBox("Thêm thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    EasyMessageBox("Error" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        // Khi người dùng ấn nút sửa
        private void EditButtonKH_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(MaKhoBoxKH.Text))
            {
                EasyMessageBox("Bạn cần chọn 1 dữ liệu để sửa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!int.TryParse(SLTonBoxKH.Text, out value))
            {
                EasyMessageBox("Số lượng tồn không phải là số", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SLTonBoxKH.Focus();
            }
            else
            {
                try
                {
                    kh.UpdateKH(this.MaKhoBoxKH.Text, this.TenKhoBoxKH.Text, this.DiaChiBoxKH.Text, Convert.ToInt32(this.SLTonBoxKH.Text));
                    EasyMessageBox("Sửa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddButtonKH.Enabled = true;
                }
                catch (Exception ex)
                {
                    EasyMessageBox("Error" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        // Khi người dùng ấn nút xóa
        private void DeleteButtonKH_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(MaKhoBoxKH.Text))
            {
                EasyMessageBox("Bạn cần chọn 1 dữ liệu để xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult rs = EasyMessageBox("Bạn có chắc muốn xóa ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    kh.DeleteKH(this.MaKhoBoxKH.Text);
                    EasyMessageBox("Xóa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddButtonKH.Enabled = true;
                }
            } 
        }

        // Khi người dùng ấn nút xuất Excel
        private void ExcelButtonKH_Click(object sender, EventArgs e)
        {
            if (KhoHangGridView.Rows.Count > 0)
            {
                Excel(KhoHangGridView);
            }
            else
            {
                EasyMessageBox("Cần ít nhất 1 dữ liệu trong bảng để xuất ra excels", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Khi người dùng ấn nút thoát
        private void ExitButtonKH_Click(object sender, EventArgs e)
        {
            DialogResult rs = EasyMessageBox("Bạn có chắc muốn thoát khỏi ứng dụng ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                Exit();
            }
        }

        // Khi người dùng ấn nút tìm kiếm
        private void SearchButtonKH_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(SearchBoxKH.Text))
            {
                EasyMessageBox("Bạn cần nhập thông tin để tìm kiếm !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    dt = kh.TimKH(this.SearchBoxKH.Text);
                    KhoHangGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    EasyMessageBox("Error" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Khi người dùng ấn nút làm khôi phục
        private void ResetButtonKH_Click(object sender, EventArgs e)
        {
            ResetAlls(KhoHangGroupBox);
            AddButtonKH.Enabled = true;
        }

        // Khi giao diện được tải lại
        private void KhoHangTab_Layout(object sender, LayoutEventArgs e)
        {
            dt = kh.HienThiKH();
            KhoHangGridView.DataSource = dt;
            for (int i = 0; i < KhoHangGridView.Rows.Count; i++)
            {
                KhoHangGridView.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

        // Khi người dùng ấn vào dữ liệu trong DataGridView
        private void KhoHangGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AddButtonKH.Enabled = false;
            int i;
            i = e.RowIndex;
            MaKhoBoxKH.Text = KhoHangGridView.Rows[i].Cells[1].Value.ToString();
            TenKhoBoxKH.Text = KhoHangGridView.Rows[i].Cells[2].Value.ToString();
            DiaChiBoxKH.Text = KhoHangGridView.Rows[i].Cells[3].Value.ToString();
            SLTonBoxKH.Text = KhoHangGridView.Rows[i].Cells[4].Value.ToString();
        }
    }
}
