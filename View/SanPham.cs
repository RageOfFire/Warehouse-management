using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Controller;

namespace View
{
    public partial class Warehouse : Form
    {
        ControllerSanPham sp = new ControllerSanPham();
        SqlDataReader drKH;
        private void AddButtonSP_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(GiaBoxSP.Text, out value))
            {
                EasyMessageBox("Giá không phải là số", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GiaBoxSP.Focus();
            }
            else
            {
                try
                {
                    sp.InsertSP(this.TenSanPhamBoxSP.Text, this.MaKhoComboSP.Text, this.DonViTinhComboSP.Text, Convert.ToInt32(this.GiaBoxSP.Text));
                    EasyMessageBox("Thêm thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    EasyMessageBox("Error" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void EditButtonSP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MaSanPhamBoxSP.Text))
            {
                EasyMessageBox("Bạn cần chọn 1 dữ liệu để sửa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!int.TryParse(GiaBoxSP.Text, out value))
            {
                EasyMessageBox("Giá không phải là số", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GiaBoxSP.Focus();
            }
            else
            {
                try
                {
                    sp.UpdateSP(this.MaSanPhamBoxSP.Text, this.TenSanPhamBoxSP.Text, this.MaKhoComboSP.Text, this.DonViTinhComboSP.Text, Convert.ToInt32(this.GiaBoxSP.Text));
                    EasyMessageBox("Sửa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddButtonSP.Enabled = true;
                }
                catch (Exception ex)
                {
                    EasyMessageBox("Error" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void DeleteButtonSP_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(MaSanPhamBoxSP.Text))
            {
                EasyMessageBox("Bạn cần chọn 1 dữ liệu để xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult rs = EasyMessageBox("Bạn có chắc muốn xóa ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    sp.DeleteSP(this.MaSanPhamBoxSP.Text);
                    EasyMessageBox("Xóa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddButtonSP.Enabled = true;
                }
            }
        }
        private void ResetButtonSP_Click(object sender, EventArgs e)
        {
            ResetAlls(SanPhamGroupBox);
            AddButtonSP.Enabled = true;
        }
        private void ExcelButtonSP_Click(object sender, EventArgs e)
        {
            if (SanPhamGridView.Rows.Count > 0)
            {
                Excel(SanPhamGridView);
            }
            else
            {
                EasyMessageBox("Cần ít nhất 1 dữ liệu trong bảng để xuất ra excels", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ExitButtonSP_Click(object sender, EventArgs e)
        {
            DialogResult rs = EasyMessageBox("Bạn có chắc muốn thoát khỏi ứng dụng ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                Exit();
            }
        }
        private void SearchButtonSP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchBoxSP.Text))
            {
                EasyMessageBox("Bạn cần nhập thông tin để tìm kiếm !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    dt = sp.TimSP(this.SearchBoxSP.Text);
                    SanPhamGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    EasyMessageBox("Error" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SanPhamTab_Layout(object sender, LayoutEventArgs e)
        {
            dt = sp.HienThiSP();
            SanPhamGridView.DataSource = dt;
            for (int i = 0; i < SanPhamGridView.Rows.Count; i++)
            {
                SanPhamGridView.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
            drKH = sp.HienthiKH_CB();
            while (drKH.Read())
            {
                if (drKH.FieldCount > 0)
                {
                    if (!MaKhoComboSP.Items.Contains(drKH[0].ToString()))
                    {
                        MaKhoComboSP.Items.Add(drKH[0].ToString());
                    }
                }
            }
        }
        private void SanPhamGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AddButtonSP.Enabled = false;
            int i;
            i = e.RowIndex;
            MaSanPhamBoxSP.Text = SanPhamGridView.Rows[i].Cells[1].Value.ToString();
            TenSanPhamBoxSP.Text = SanPhamGridView.Rows[i].Cells[2].Value.ToString();
            MaKhoComboSP.Text = SanPhamGridView.Rows[i].Cells[3].Value.ToString();
            DonViTinhComboSP.Text = SanPhamGridView.Rows[i].Cells[4].Value.ToString();
            GiaBoxSP.Text = SanPhamGridView.Rows[i].Cells[5].Value.ToString();
        }
    }
}
