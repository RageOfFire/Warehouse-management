using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Controls;
using Controller;

namespace View
{
    public partial class Warehouse : Form
    {
        DataTable dt = new DataTable();
        ControllerKhoHang kh = new ControllerKhoHang();
        int value;
        public Warehouse()
        {
            InitializeComponent();
        }

        private void AddButtonKH_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(SLTonBoxKH.Text, out value))
            {
                PoisonMessageBox.Show(this, "Số lượng tồn không phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SLTonBoxKH.Focus();
            }
            else
            {
                try
                {
                    kh.InsertKH(this.TenKhoBoxKH.Text, this.DiaChiBoxKH.Text, Convert.ToInt32(this.SLTonBoxKH.Text));
                    PoisonMessageBox.Show(this, "Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    PoisonMessageBox.Show(this, "Error" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void EditButtonKH_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(SLTonBoxKH.Text, out value))
            {
                PoisonMessageBox.Show(this, "Số lượng tồn không phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SLTonBoxKH.Focus();
            }
            else
            {
                try
                {
                    kh.UpdateKH(this.MaKhoBoxKH.Text, this.TenKhoBoxKH.Text, this.DiaChiBoxKH.Text, Convert.ToInt32(this.SLTonBoxKH.Text));
                    PoisonMessageBox.Show(this, "Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddButtonKH.Enabled = true;
                }
                catch (Exception ex)
                {
                    PoisonMessageBox.Show(this, "Error" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void DeleteButtonKH_Click(object sender, EventArgs e)
        {
                DialogResult rs = PoisonMessageBox.Show(this, "Bạn có chắc muốn xóa ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    kh.DeleteKH(this.MaKhoBoxKH.Text);
                    PoisonMessageBox.Show(this, "Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddButtonKH.Enabled = true;
                }    
        }

        private void ExcelButtonKH_Click(object sender, EventArgs e)
        {
            if (KhoHangGridView.Rows.Count > 0)
            {
                Excel(KhoHangGridView);
            }
            else
            {
                PoisonMessageBox.Show(this, "Cần ít nhất 1 dữ liệu trong bảng để xuất ra excels", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExitButtonKH_Click(object sender, EventArgs e)
        {
            DialogResult rs = PoisonMessageBox.Show(this, "Bạn có chắc muốn thoát khỏi ứng dụng ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void SearchButtonKH_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(SearchBoxKH.Text))
            {
                PoisonMessageBox.Show(this, "Bạn cần nhập thông tin để tìm kiếm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    PoisonMessageBox.Show(this, "Error" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ResetButtonKH_Click(object sender, EventArgs e)
        {
            ResetAlls(KhoHangGroupBox);
            AddButtonKH.Enabled = true;
        }

        private void KhoHangTab_Layout(object sender, LayoutEventArgs e)
        {
            dt = kh.HienThiKH();
            KhoHangGridView.DataSource = dt;
            for (int i = 0; i < KhoHangGridView.Rows.Count; i++)
            {
                KhoHangGridView.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

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
