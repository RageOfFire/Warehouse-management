using Controller;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class Warehouse : Form
    {
        ControllerKhachHang kha = new ControllerKhachHang();
        private void AddButtonKHA_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(SDTBoxKHA.Text, out value))
            {
                EasyMessageBox("Số điện thoại không phải là số", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SDTBoxKHA.Focus();
            }
            else
            {
                try
                {
                    kha.InsertKHA(this.TenCongTyBoxKHA.Text, this.DiaChiBoxKHA.Text, Convert.ToInt32(this.SDTBoxKHA.Text));
                    EasyMessageBox("Thêm thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    EasyMessageBox("Error" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void EditButtonKHA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MaCongTyBoxKHA.Text))
            {
                EasyMessageBox("Bạn cần chọn 1 dữ liệu để sửa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!int.TryParse(SDTBoxKHA.Text, out value))
            {
                EasyMessageBox("Số lượng tồn không phải là số", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SDTBoxKHA.Focus();
            }
            else
            {
                try
                {
                    kha.UpdateKHA(this.MaCongTyBoxKHA.Text, this.TenCongTyBoxKHA.Text, this.DiaChiBoxKHA.Text, Convert.ToInt32(this.SDTBoxKHA.Text));
                    EasyMessageBox("Sửa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddButtonKHA.Enabled = true;
                }
                catch (Exception ex)
                {
                    EasyMessageBox("Error" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void DeleteButtonKHA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MaCongTyBoxKHA.Text))
            {
                EasyMessageBox("Bạn cần chọn 1 dữ liệu để xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult rs = EasyMessageBox("Bạn có chắc muốn xóa ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    kha.DeleteKHA(this.MaCongTyBoxKHA.Text);
                    EasyMessageBox("Xóa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddButtonKHA.Enabled = true;
                }
            }
        }
        private void ResetButtonKHA_Click(object sender, EventArgs e)
        {
            ResetAlls(KhachHangGroupBox);
            AddButtonKHA.Enabled = true;
        }
        private void ExcelButtonKHA_Click(object sender, EventArgs e)
        {
            if (KhachHangGridView.Rows.Count > 0)
            {
                Excel(KhachHangGridView);
            }
            else
            {
                EasyMessageBox("Cần ít nhất 1 dữ liệu trong bảng để xuất ra excels", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ExitButtonKHA_Click(object sender, EventArgs e)
        {
            DialogResult rs = EasyMessageBox("Bạn có chắc muốn thoát khỏi ứng dụng ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                Exit();
            }
        }
        private void SearchButtonKHA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchBoxKHA.Text))
            {
                EasyMessageBox("Bạn cần nhập thông tin để tìm kiếm !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    dt = kha.TimKHA(this.SearchBoxKHA.Text);
                    KhachHangGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    EasyMessageBox("Error" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void KhachHangTab_Layout(object sender, LayoutEventArgs e)
        {
            dt = kha.HienThiKHA();
            KhachHangGridView.DataSource = dt;
            for (int i = 0; i < KhachHangGridView.Rows.Count; i++)
            {
                KhachHangGridView.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }
        private void KhachHangGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AddButtonKHA.Enabled = false;
            int i;
            i = e.RowIndex;
            MaCongTyBoxKHA.Text = KhachHangGridView.Rows[i].Cells[1].Value.ToString();
            TenCongTyBoxKHA.Text = KhachHangGridView.Rows[i].Cells[2].Value.ToString();
            DiaChiBoxKHA.Text = KhachHangGridView.Rows[i].Cells[3].Value.ToString();
            SDTBoxKHA.Text = KhachHangGridView.Rows[i].Cells[4].Value.ToString();
        }
    }
}
