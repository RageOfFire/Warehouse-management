using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Controller;

namespace View
{
    public partial class Warehouse : Form
    {
        ControllerDonHang dh = new ControllerDonHang();
        SqlDataReader drSP;
        private void AddButtonDH_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(SLBoxDH.Text, out value))
            {
                EasyMessageBox("Số lượng không phải là số", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SLBoxDH.Focus();
            }
            else
            {
                try
                {
                    dh.InsertDH(this.MaSanPhamComboDH.Text, Convert.ToInt32(this.SLBoxDH.Text), this.MaKhoComboDH.Text);
                    EasyMessageBox("Thêm thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    EasyMessageBox("Error" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void EditButtonDH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MaDonHangBoxDH.Text))
            {
                EasyMessageBox("Bạn cần chọn 1 dữ liệu để sửa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!int.TryParse(SLBoxDH.Text, out value))
            {
                EasyMessageBox("Số lượng không phải là số", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SLBoxDH.Focus();
            }
            else
            {
                try
                {
                    dh.UpdateDH(this.MaDonHangBoxDH.Text, this.MaSanPhamComboDH.Text, Convert.ToInt32(this.SLBoxDH.Text), this.MaKhoComboDH.Text);
                    EasyMessageBox("Sửa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddButtonDH.Enabled = true;
                }
                catch (Exception ex)
                {
                    EasyMessageBox("Error" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void DeleteButtonDH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MaDonHangBoxDH.Text))
            {
                EasyMessageBox("Bạn cần chọn 1 dữ liệu để xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult rs = EasyMessageBox("Bạn có chắc muốn xóa ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    dh.DeleteDH(this.MaDonHangBoxDH.Text);
                    EasyMessageBox("Xóa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddButtonDH.Enabled = true;
                }
            }
        }
        private void ResetButtonDH_Click(object sender, EventArgs e)
        {
            ResetAlls(DonHangGroupBox);
            AddButtonDH.Enabled = true;
        }
        private void ExcelButtonDH_Click(object sender, EventArgs e)
        {
            if (DonHangGridView.Rows.Count > 0)
            {
                Excel(DonHangGridView);
            }
            else
            {
                EasyMessageBox("Cần ít nhất 1 dữ liệu trong bảng để xuất ra excels", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void SearchButtonDH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchBoxDH.Text))
            {
                EasyMessageBox("Bạn cần nhập thông tin để tìm kiếm !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    dt = dh.TimDH(this.SearchBoxDH.Text);
                    DonHangGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    EasyMessageBox("Error" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ExitButtonDH_Click(object sender, EventArgs e)
        {
            DialogResult rs = EasyMessageBox("Bạn có chắc muốn thoát khỏi ứng dụng ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                Exit();
            }
        }
        private void DonHangTab_Layout(object sender, LayoutEventArgs e)
        {
            dt = dh.HienThiDH();
            DonHangGridView.DataSource = dt;
            for (int i = 0; i < DonHangGridView.Rows.Count; i++)
            {
                DonHangGridView.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
            drKH = dh.HienthiKH_CB();
            drSP = dh.HienthiSP_CB();
            while (drKH.Read())
            {
                if (drKH.FieldCount > 0)
                {
                    if (!MaKhoComboDH.Items.Contains(drKH[0].ToString()))
                    {
                        MaKhoComboDH.Items.Add(drKH[0].ToString());
                    }
                }
            }
            while (drSP.Read())
            {
                if(drSP.FieldCount > 0)
                {
                    if(!MaSanPhamComboDH.Items.Contains(drSP[0].ToString()))
                    {
                        MaSanPhamComboDH.Items.Add(drSP[0].ToString());
                    }
                }
            }
        }
        private void DonHangGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AddButtonDH.Enabled = false;
            int i;
            i = e.RowIndex;
            MaDonHangBoxDH.Text = DonHangGridView.Rows[i].Cells[1].Value.ToString();
            MaSanPhamComboDH.Text = DonHangGridView.Rows[i].Cells[2].Value.ToString();
            SLBoxDH.Text = DonHangGridView.Rows[i].Cells[3].Value.ToString();
            MaKhoComboDH.Text = DonHangGridView.Rows[i].Cells[4].Value.ToString();
        }
    }
}
