using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QLSV
{
    public partial class Form1 : Form
    {
        string flag; // xem khi nào thêm , sửa
        DataTable dtLop;
        int index; // xem sửa ở đâu
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            blockButton();
            //load data lớp
            DataTable dt = new DataTable();
            dt.Columns.Add("MaLop");
            dt.Columns.Add("TenLop");
            StreamReader file = new StreamReader("lop.txt");
            while (!file.EndOfStream)
            {
                string[] str = file.ReadLine().Split(':');
                DataRow dr = dt.NewRow();
                dr["MaLop"] = str[0];
                dr["TenLop"] = str[1];
                dt.Rows.Add(dr);
            }
            dtLop = dt;
            dgvLop.DataSource = dtLop;
            dgvLop.RefreshEdit();
        }
       
        private void btnSua_Click(object sender, EventArgs e)
        {
            unlockButton();
            flag = "edit";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            unlockButton();
            flag = "add";
            txtMasolop.Text = "";
            txtTenlop.Text = "";
            
         
        }
        public void blockButton()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnThoat.Enabled = true;
            txtMasolop.ReadOnly = true;
            txtTenlop.ReadOnly = true;
            btnThem.Focus();
           
        }
        public void unlockButton()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThoat.Enabled = true;
            txtMasolop.ReadOnly = false;
            txtTenlop.ReadOnly = false;
            txtMasolop.Focus();
        }
    

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                if (checkData())
                {
                    dtLop.Rows.Add(txtMasolop.Text, txtTenlop.Text);
                    dgvLop.DataSource = dtLop;
                    dgvLop.RefreshEdit();
                }
               

            }
            else if (flag == "edit")
            {
                if (checkData())
                {
                    dtLop.Rows[0][0] = txtMasolop.Text;
                    dtLop.Rows[0][1] = txtTenlop.Text;
                    dgvLop.DataSource = dtLop;
                    dgvLop.RefreshEdit();
                }
            }
            blockButton();
           
        }
        public bool checkData()
        {
            if (string.IsNullOrWhiteSpace(txtMasolop.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMasolop.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenlop.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenlop.Focus();
                return false;
            }
            return true;
        }

        private void dgvLop_SelectionChanged(object sender, EventArgs e)// đổ lên textbox
        {
            if (dgvLop.SelectedRows.Count > 0)
            {
                txtMasolop.Text = dgvLop.SelectedRows[0].Cells["colMalop"].Value.ToString();
                txtTenlop.Text = dgvLop.SelectedRows[0].Cells["colTenlop"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            index = dgvLop.CurrentCell.RowIndex;
            if (MessageBox.Show("Bạn có muốn xóa lớp này ?","Cảnh báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dtLop.Rows.RemoveAt(index);
                dgvLop.DataSource = dtLop;
                dgvLop.RefreshEdit();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát ? ","Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgvLop_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {   
            if (e.RowIndex >= 0)
            {
                var malop = dgvLop.Rows[e.RowIndex].Cells["colMalop"].Value.ToString();
                new Form2(malop).ShowDialog();
            }
          
        }



       

    }
}
