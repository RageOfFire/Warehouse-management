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

namespace View
{
    public partial class Warehouse : Form
    {
        int value;
        public Warehouse()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(SLTonBox.Text, out value))
            {
                PoisonMessageBox.Show(this, "Số lượng tồn không phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SLTonBox.Focus();
            }
            else
            {
                PoisonMessageBox.Show(this, "Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(SLTonBox.Text, out value))
            {
                PoisonMessageBox.Show(this, "Số lượng tồn không phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SLTonBox.Focus();
            }
            else
            {
                PoisonMessageBox.Show(this, "Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
                DialogResult rs = PoisonMessageBox.Show(this, "Bạn có chắc muốn xóa ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    PoisonMessageBox.Show(this, "Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
        }

        private void ExcelButton_Click(object sender, EventArgs e)
        {
            if (KhoHangGridView.Rows.Count > 0)
            {
                PoisonMessageBox.Show(this, "Xuất ra excels thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                PoisonMessageBox.Show(this, "Cần ít nhất 1 dữ liệu trong bảng để xuất ra excels", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
